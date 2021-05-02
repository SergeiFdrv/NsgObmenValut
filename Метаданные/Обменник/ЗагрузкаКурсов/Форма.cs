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
            HttpWebRequest webRequest = HttpWebRequest.Create(Path.Combine(@"http://cbrates.rbc.ru/tsv", uri)) as HttpWebRequest;
            WebResponse response;
            try
            {
                response = webRequest.GetResponse();
            }
            catch (WebException x)
            {
                Console.WriteLine(x.Message);
                return;
            }
            var stream = response.GetResponseStream();
            string[] res;
            using (var reader = new StreamReader(stream))
            {
                res = reader.ReadToEnd().Split('\n');
            }
            //MessageBox.Show(uri + '\n' + res[res.Length - 1]);
            //Console.WriteLine(res[res.Length - 1]);

            NsgCompare nsgCompare = new NsgCompare();
            nsgCompare.Add(ЗагрузкаКурсов.Names.Валюты, Валюта.Value, NsgSoft.Database.NsgComparison.Equal);
            var obj = Валюты.Новый();
            if (obj.Find(nsgCompare))
            {
                if (!requsetHasDate)
                {
                    var old = ИсторияКурсов.Новый().FindAll(nsgCompare);
                    for (int i = 0; i < old.Length; i++)
                    {
                        old[i].Delete();
                    }
                    string[] a;
                    ;
                    ИсторияКурсов item = ИсторияКурсов.Новый();
                    for (int i = 0; i < res.Length; i++)
                    {
                        ReportProgress(i * 100 / res.Length, "Загрузка");
                        a = res[i].Split('\t');
                        item.New();
                        item.Валюты = obj;
                        item.ДатаВремя = DateTime.ParseExact(a[0], "yyyymmdd", CultureInfo.InvariantCulture);
                        item.Значение = Convert.ToDecimal(a[a.Length - 1], CultureInfo.InvariantCulture);
                        item.Post();
                    }
                }
                obj.Edit();
                var last = res[res.Length - 1].Split('\t');
                obj.ТекущийКурс = Convert.ToDecimal(last[last.Length - 1], CultureInfo.InvariantCulture);
                obj.Post();
                obj.Cancel();
            }
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