using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;





namespace ОбменникВалют.Метаданные.Обменник
{
    
    public partial class ЗагрузкаКурсовФорма

    {
        public ЗагрузкаКурсовФорма()
        {
            InitializeComponent();
		}

		#region #Comments_Data# NsgSoft.Forms.NsgReportForm
		
		#endregion //#Comments_Data# NsgSoft.Forms.NsgReportForm

		#region #Comments_Constructors# NsgSoft.Forms.NsgReportForm
		
		#endregion //#Comments_Constructors# NsgSoft.Forms.NsgReportForm

		#region #Comments_Methods# NsgSoft.Forms.NsgReportForm
		
        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            base.OnCreateReport(nsgBackgroundReporter, e);

            // Формируем строку запроса
            string uri;
            bool requsetHasDate = Период.Value.Year >= 2000;
            if (requsetHasDate)
            {
                uri = $"{Валюта.Value.Код}/{Период.Value.Year}/{Период.Value.Month.ToString("00")}/{Период.Value.Day.ToString("00")}.tsv";
            }
            else
            {
                if (MessageBox.Show("Загрузка курсов за все время может быть долгой. Продолжить?", "Предупреждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    return;
                }
                uri = $"cb/{Валюта.Value.Код}.tsv";
            }

            // Делаем запрос
            HttpWebRequest webRequest = HttpWebRequest.Create(Path.Combine(@"http://cbrates.rbc.ru/tsv", uri)) as HttpWebRequest;
            WebResponse response;
            try
            {
                response = webRequest.GetResponse();
            }
            catch (WebException x)
            {
                Console.WriteLine(x.Message);
                MessageBox.Show(x.Message + "\n\nStack trace:\n" + x.StackTrace, "Ошибка", MessageBoxButtons.OK);
                return;
            }

            // Считываем ответ
            string[] res;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                res = reader.ReadToEnd().Split('\n');
            }
            //MessageBox.Show(uri + '\n' + res[res.Length - 1]);
            //Console.WriteLine(res[res.Length - 1]);

            // БД
            ИсторияКурсов history = ИсторияКурсов.Новый();
            NsgCompare nsgCompare = new NsgCompare();
            nsgCompare.Add(ИсторияКурсов.Names.Валюты, Валюта.Value, NsgSoft.Database.NsgComparison.Equal);
            if (requsetHasDate) // если в запросе была дата, учитывать её
            {
                nsgCompare.Add(ИсторияКурсов.Names.ДатаВремя, Период.Value.Date, NsgSoft.Database.NsgComparison.GreaterOrEqual);
                nsgCompare.Add(ИсторияКурсов.Names.ДатаВремя, Период.Value.AddDays(1).Date, NsgSoft.Database.NsgComparison.Less);
            }
            history.DeleteArray(nsgCompare);
            string[] resItem; // хранение текущей записи
            if (res.Length > 1) // если вернулось больше одной записи, каждая строка res имеет вид "[время] 1 [курс]"
            { // вносим всё в БД
                for (int i = 0; i < res.Length; i++)
                {
                    ReportProgress(i * 100 / res.Length, "Ждём-с!");
                    resItem = res[i].Split('\t');
                    history.New();
                    history.Валюты = Валюта.Value;
                    history.ДатаВремя = DateTime.ParseExact(resItem[0], "yyyyMMdd", CultureInfo.InvariantCulture);
                    history.Значение = Convert.ToDecimal(resItem[2], CultureInfo.InvariantCulture);
                    history.Post();
                }
            }
            else if (res.Length == 1) // единственная строка res имеет вид "1 [курс]"
            { // вносим её в БД
                resItem = res[0].Split('\t');
                history.New();
                history.Валюты = Валюта.Value;
                history.ДатаВремя = Период.Value.Date;
                history.Значение = Convert.ToDecimal(resItem[1], CultureInfo.InvariantCulture);
                history.Post();
            }
            nsgCompare.RemoveParameters(ИсторияКурсов.Names.ДатаВремя); // поиск за период нам больше не нужен
            // Присвоить валюте последний курс
            var sorting = new NsgSorting(new NsgSortingParam(ИсторияКурсов.Names.ДатаВремя, NsgSoft.Database.NsgSortDirection.Descending));
            int one = 1;
            var last = history.FindAll(ref one, 0, sorting, nsgCompare)[0];
            Валюта.Value.Edit();
            Валюта.Value.ТекущийКурс = last.Значение;
            Валюта.Value.Post();
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

        #endregion //#Comments_Methods# NsgSoft.Forms.NsgReportForm

        #region #Comments_Properties# NsgSoft.Forms.NsgReportForm

        #endregion //#Comments_Properties# NsgSoft.Forms.NsgReportForm
    }
    


}