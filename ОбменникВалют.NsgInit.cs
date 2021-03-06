using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.IO;
using NsgSoft.DataObjects;
using NsgSoft.Common;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ОбменникВалют")]
[assembly: AssemblyDescription("New Configuration")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Unknown Developer ©  2011")]
[assembly: AssemblyProduct("ОбменникВалют")]
[assembly: AssemblyCopyright("Unknown Developer ©  2011")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("1b263e68-ff7d-4c6c-849e-1bb077f43b48")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("2021.4.29.3")]
[assembly: AssemblyFileVersion("2021.4.29.3")]
[assembly: NsgAssemblyAttribute(NsgAssemblyTypes.Configuration)]

namespace ОбменникВалют
{
    [NsgSoft.Common.NsgConfigurationClass()]
    public partial class Конфигурация : NsgConfiguration
	{
		#region Данные
		
        private Метаданные.Метаданные __Метаданные;
		#endregion //Данные

		#region Инициализация
		/// <summary>
		/// Инициализация
        /// </summary>
        private void InitializeComponent()
        {
            NsgSoft.DataObjects.NsgSettings.Regime = NsgSoft.Common.NsgViewTypes.Load;
            NsgService.AllowAccuracyChecks = false;
            ClearAllList();
            //NsgConfiguration
            	//NsgConfiguration
	IsLoadedFromDll = true;
	Prefics = "";
	Type = NsgSoft.DataObjects.NsgConfigurationTypes.Base;
	Guid = NsgService.StringToGuid("1b263e68-ff7d-4c6c-849e-1bb077f43b48");
	DatabaseManagerNames = "";
	Name = "ОбменникВалют";
	Description = "New Configuration";
	Copyright = "Unknown Developer ©  2011";
	Version = "2021.4.29.3";
	MetaDataList = new NsgSoft.DataObjects.NsgMetaData[]{};
	

            
            __Метаданные = ОбменникВалют.Метаданные.Метаданные.Новый();
            AddMetaData(__Метаданные);
            NsgSoft.DataObjects.NsgSettings.Regime = NsgSoft.Common.NsgViewTypes.RunTime;
        }
		#endregion //Инициализация

		#region Свойства
		
        /// <summary>
        /// Метаданные
        /// </summary>
        public Метаданные.Метаданные Метаданные
        {
            get
            {
                return __Метаданные;
            }
        }
		#endregion //Свойства

		#region Методы
		#endregion //Методы
	}
}
