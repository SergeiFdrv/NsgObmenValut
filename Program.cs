using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;

using NsgSoft.DataObjects;
using NsgSoft.Common;
using NsgSoft.Forms;
using NsgSoft.Design;

namespace ОбменникВалют
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
		[STAThread]
		public static void Main(string[] args)
        {
			if (NsgCommandLineParser.IsHelpNeeded(args))
			{
				NsgCommandLineParser.PrintHelp();
				return;
			}
			
			Application.EnableVisualStyles();
			// проверить на запуск из другого процесса
			if (!Application.MessageLoop)
				Application.SetCompatibleTextRenderingDefault(false);

			bool connected = false;
			MainForm main = null;
			NsgDatabaseGUIService dbServ = null;
			NsgBaseLogoForm logo = new NsgLogo();
			logo.FormFullShown += new EventHandler(delegate
			{
				NsgSettings.Regime = NsgViewTypes.RunTime;
				NsgSettings.CashWindows = true;
				// выполнить создание конфигурации в отдельном потоке
				main = new MainForm();
				NsgThread thread = new NsgThread();
				thread.DoWork += new NsgThread.NsgDoWorkEventHandler(delegate
				{
					NsgConfiguration cfg = new ОбменникВалют.Конфигурация();
					Form logoForm = NsgSettings.GetLogoForm();
					NsgSettings.Regime = NsgViewTypes.RunTime;
					dbServ = new NsgDatabaseGUIService(cfg, logoForm);
					connected = dbServ.Connect(args);
				});
				thread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
					delegate(object sender, RunWorkerCompletedEventArgs e)
					{
						if (e.Error != null)
						{
							Form logoForm = NsgSettings.GetLogoForm();
							string err = NsgService.ParseException(e.Error);
							NsgMessage.ShowErrorText(logoForm, err);
						}
						NsgSettings.CloseLogo();
					});
				thread.RunWorkerAsync("Launch");
			});
			NsgSettings.ShowLogo(logo, 200);
			// проверка флага соединения с БД
			if (connected && main != null && dbServ != null)
			{
				main.CurrentUser = dbServ.CurrentUser;
				main.BeforeRunApplication();
				// обработка ошибок основного потока
				Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
				if (!Application.MessageLoop)
				{
					// для режима сервера - без отображения окна
					if (NsgService.ServerMode)
						Application.Run();
					else
						Application.Run(main);
				}
				else
					main.ShowDialog();
				return;
			}
		}

		/// <summary>
		/// Обработчик исключений на потоке приложения.
		/// </summary>
		static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{
			Exception ex = e.Exception;
			string innerExceptionString = String.Empty;
			if (ex.InnerException != null)
			{
				innerExceptionString = Environment.NewLine + "Inner exception: " + ex.InnerException.Message +
									   Environment.NewLine + "StackTrace: " + ex.InnerException.StackTrace +
									   Environment.NewLine + "-------------------------------------------";
			}
			NsgTracer.WriteErrorWithCallstack(ex.Message + innerExceptionString);
			NsgMessage.ShowErrorText(NsgSettings.MainForm as IWin32Window,
				"Необработанная ошибка: " + ex.Message + ";\nStack: " + ex.StackTrace);
		}
	}
}