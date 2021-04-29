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
            bool hasDate = Период.Value.Year >= 2000;
            if (hasDate)
            {
                uri = $"{Валюта.Value.Код}/{Период.Value.Year}/{Период.Value.Month.ToString("00")}/{Период.Value.Day.ToString("00")}.tsv";
            }
            else
            {
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
                if (!hasDate)
                {
                    var old = ИсторияКурсов.Новый();
                    old.FindAll(nsgCompare);
                    foreach (var i in old.FindAll(nsgCompare))
                    {
                        i.Delete();
                    }
                    ИсторияКурсов item;
                    string[] a;
                    /*
                    foreach (var i in res)
                    {
                        item = ИсторияКурсов.Новый();
                        item.New();
                        a = i.Split('\t');
                        item.Валюты = obj;
                        item.ДатаВремя = Convert.ToDateTime(
                            a[0].Substring(0, 4) + '/' +
                            a[0].Substring(4, 2) + '/' +
                            a[0].Substring(6, 2)
                            );
                        item.Значение = Convert.ToDecimal(a[a.Length - 1], CultureInfo.InvariantCulture);
                        item.Post();
                    }*/
                    // долго
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