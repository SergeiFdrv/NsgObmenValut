using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.IO;

using NsgSoft.DataObjects;
using NsgSoft.Design;
using NsgSoft.Database;
using NsgSoft.Common;

// ================================================================ //
// Этот файл создается автоматически, все изменения будут потеряны. //
// ================================================================ //

namespace ОбменникВалют.Метаданные.Обменник
{
    
    [NsgTypeName("NsgReportObject", Guid = "3d6925ed-1f20-4348-b448-c67a337f16c4")]
    public partial class ЗагрузкаКурсов : NsgSoft.DataObjects.NsgReportObject
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgReportObject
        




        #endregion // Данные NsgSoft.DataObjects.NsgReportObject

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgReportObject
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgReportObject

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected ЗагрузкаКурсов()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ЗагрузкаКурсов(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ЗагрузкаКурсов Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("3d6925ed-1f20-4348-b448-c67a337f16c4"));
            if (obj == null)
                obj = new ЗагрузкаКурсов();
            return obj as ЗагрузкаКурсов;
        }

        /// <summary>
        /// Инициализация реквизитов объекта
        /// </summary>
        protected override void CreatePreDefinedFields()
		{
			#region необходимые операции до создания реквизитов и заполнения полей
			if (NsgSettings.Regime == NsgSoft.Common.NsgViewTypes.Load)
                base.CreatePreDefinedFields();
			#endregion //необходимые операции до создания реквизитов и заполнения полей
			#region начало инициализации NsgSoft.DataObjects.NsgReportObject
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgReportObject
			
			#region создание System.Guid Идентификатор
			{  
                NsgDataGuid Идентификатор = null;
				if (ObjectList.Contains("Идентификатор"))
                    Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                else
                    Идентификатор = new NsgDataGuid();
	//NsgDataGuid
	Идентификатор.IsLoadedFromDll = true;
	Идентификатор.StringFormat = "";
	Идентификатор.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Идентификатор.IncludeInPredefined = false;
	Идентификатор.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Идентификатор.Required = false;
	Идентификатор.EmptyValue = "";
	Идентификатор.NullAllow = false;
	Идентификатор.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Идентификатор.FieldName = "_ID";
	Идентификатор.SaveInDatabase = false;
	Идентификатор.InformMetaDataOnValueChanged = false;
	Идентификатор.Visible = true;
	Идентификатор.Name = "Идентификатор";
	Идентификатор.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Идентификатор.Description = "Идентификатор";
	Идентификатор.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Идентификатор.GroupName = "";
	Идентификатор.Guid = NsgService.StringToGuid("6641581a-f112-449d-8342-f5a8c56064b6");
	
				if (!ObjectList.Contains("Идентификатор"))
                    ObjectList.Add(Идентификатор);
			}
			#endregion //создание System.Guid Идентификатор
			
			#region создание System.Int64 Автоинкремент
			{  
                NsgDataInteger Автоинкремент = null;
				if (ObjectList.Contains("Автоинкремент"))
                    Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                else
                    Автоинкремент = new NsgDataInteger();
	//NsgDataInteger
	Автоинкремент.IsLoadedFromDll = true;
	Автоинкремент.DefaultValue = 0M;
	Автоинкремент.MinValue = 0M;
	Автоинкремент.MaxValue = 0M;
	Автоинкремент.UseCalculator = true;
	Автоинкремент.StringFormat = "";
	Автоинкремент.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Автоинкремент.IncludeInPredefined = false;
	Автоинкремент.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Автоинкремент.Required = false;
	Автоинкремент.EmptyValue = "";
	Автоинкремент.NullAllow = false;
	Автоинкремент.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Автоинкремент.FieldName = "_AutoInc";
	Автоинкремент.SaveInDatabase = false;
	Автоинкремент.InformMetaDataOnValueChanged = false;
	Автоинкремент.Visible = true;
	Автоинкремент.Name = "Автоинкремент";
	Автоинкремент.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Автоинкремент.Description = "Автоинкремент";
	Автоинкремент.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	Автоинкремент.GroupName = "";
	Автоинкремент.Guid = NsgService.StringToGuid("6c8f5131-1db2-4f88-a214-180485af86ea");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание ОбменникВалют.Метаданные.Обменник.ЗагрузкаКурсовФорма Форма
			{  
                NsgDataForm Форма = null;
				if (ObjectList.Contains("Форма"))
                    Форма = ObjectList["Форма"] as NsgDataForm;
                else
                    Форма = new NsgDataForm();
	//NsgDataForm
	Форма.IsLoadedFromDll = true;
	Форма.FormClassName = "ОбменникВалют.Метаданные.Обменник.ЗагрузкаКурсовФорма";
	Форма.SaveInDatabase = false;
	Форма.StringFormat = "";
	Форма.SubType = NsgSoft.Common.NsgRekvisitSubType.ElementForm;
	Форма.IncludeInPredefined = false;
	Форма.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Форма.Required = false;
	Форма.EmptyValue = "";
	Форма.NullAllow = false;
	Форма.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Форма.FieldName = "Forma";
	Форма.InformMetaDataOnValueChanged = false;
	Форма.Visible = true;
	Форма.Name = "Форма";
	Форма.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Форма.Description = "Форма";
	Форма.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Форма.GroupName = "";
	Форма.Guid = NsgService.StringToGuid("a81ed0e1-ccb0-4e3a-817a-f0600f90ad55");
	
				if (!ObjectList.Contains("Форма"))
                    ObjectList.Add(Форма);
			}
			#endregion //создание ОбменникВалют.Метаданные.Обменник.ЗагрузкаКурсовФорма Форма
			
			#region создание Обменник.Валюты Валюты
			{  
                NsgDataTypedReference Валюты = null;
				if (ObjectList.Contains("Валюты"))
                    Валюты = ObjectList["Валюты"] as NsgDataTypedReference;
                else
                    Валюты = new NsgDataTypedReference();
	//NsgDataTypedReference
	Валюты.IsLoadedFromDll = true;
	Валюты.ReferentGroup = "Обменник";
	Валюты.ReferentName = "Валюты";
	Валюты.SaveInDatabase = false;
	Валюты.OwnerName = "";
	Валюты.AllowEmptyOwner = false;
	Валюты.StringFormat = "";
	Валюты.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Валюты.IncludeInPredefined = false;
	Валюты.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Валюты.Required = false;
	Валюты.EmptyValue = "";
	Валюты.NullAllow = false;
	Валюты.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Валюты.FieldName = "Valjuty";
	Валюты.InformMetaDataOnValueChanged = false;
	Валюты.Visible = true;
	Валюты.Name = "Валюты";
	Валюты.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Валюты.Description = "Валюты";
	Валюты.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Валюты.GroupName = "";
	Валюты.Guid = NsgService.StringToGuid("a167bd7f-533e-48d7-9cff-62a7b49f2a99");
	
				if (!ObjectList.Contains("Валюты"))
                    ObjectList.Add(Валюты);
			}
			#endregion //создание Обменник.Валюты Валюты
			
			#region создание System.DateTime Период
			{  
                NsgDataDateTime Период = null;
				if (ObjectList.Contains("Период"))
                    Период = ObjectList["Период"] as NsgDataDateTime;
                else
                    Период = new NsgDataDateTime();
	//NsgDataDateTime
	Период.IsLoadedFromDll = true;
	Период.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	Период.StringFormat = "";
	Период.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Период.IncludeInPredefined = false;
	Период.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Период.Required = false;
	Период.EmptyValue = "";
	Период.NullAllow = false;
	Период.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Период.FieldName = "Period";
	Период.SaveInDatabase = false;
	Период.InformMetaDataOnValueChanged = false;
	Период.Visible = true;
	Период.Name = "Период";
	Период.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Период.Description = "Период";
	Период.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Период.GroupName = "";
	Период.Guid = NsgService.StringToGuid("58c1caaa-1465-4ec5-a82a-6883fedc31a6");
	
				if (!ObjectList.Contains("Период"))
                    ObjectList.Add(Период);
			}
			#endregion //создание System.DateTime Период
			

			#region заполнение полей класса
				//NsgReportObject
	IsLoadedFromDll = true;
	Name = "ЗагрузкаКурсов";
	Visible = true;
	Guid = NsgService.StringToGuid("3d6925ed-1f20-4348-b448-c67a337f16c4");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_report_ZagruzkaKursov";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Отчет";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Обменник";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgReportObject
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgReportObject

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            this.FieldsCash.Clear();
			foreach (NsgSimpleObject obj in ObjectList.All)
                if (!string.IsNullOrEmpty(obj.FieldName))
					this.FieldsCash.Add(obj.FieldName, obj.Name);
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgReportObject.Names
        {
            
            /// <summary>
            /// Идентификатор
            /// </summary>
            public static String Идентификатор
            {
                get
                {
                    return "Идентификатор";
                }
            }
            
            /// <summary>
            /// Автоинкремент
            /// </summary>
            public static String Автоинкремент
            {
                get
                {
                    return "Автоинкремент";
                }
            }
            
            /// <summary>
            /// Форма
            /// </summary>
            public static String Форма
            {
                get
                {
                    return "Форма";
                }
            }
            
            /// <summary>
            /// Валюты
            /// </summary>
            public static String Валюты
            {
                get
                {
                    return "Валюты";
                }
            }
            
            /// <summary>
            /// Период
            /// </summary>
            public static String Период
            {
                get
                {
                    return "Период";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public static string GetFullName()
        {
            return "Обменник.ЗагрузкаКурсов";
        }

        
        /// <summary>
        /// Идентификатор
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataGuid")]
        
        public System.Guid Идентификатор
        {
            get
            {
				 NsgDataGuid __Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                 return (System.Guid)__Идентификатор.Value;
            }
            set
            {
                NsgDataGuid __Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                __Идентификатор.Value = value;
            }
        }
        
        /// <summary>
        /// Автоинкремент
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 Автоинкремент
        {
            get
            {
				 NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                 return (System.Int64)__Автоинкремент.Value;
            }
            set
            {
                NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                __Автоинкремент.Value = value;
            }
        }
        
        /// <summary>
        /// Валюты
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Обменник.Валюты Валюты
        {
            get
            {
				 NsgDataTypedReference __Валюты = ObjectList["Валюты"] as NsgDataTypedReference;
                 return (Обменник.Валюты)__Валюты.Referent;
            }
            set
            {
                NsgDataTypedReference __Валюты = ObjectList["Валюты"] as NsgDataTypedReference;
                __Валюты.Referent = value;
            }
        }
        
        /// <summary>
        /// Период
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime Период
        {
            get
            {
				 NsgDataDateTime __Период = ObjectList["Период"] as NsgDataDateTime;
                 return (System.DateTime)__Период.Value;
            }
            set
            {
                NsgDataDateTime __Период = ObjectList["Период"] as NsgDataDateTime;
                __Период.Value = value;
            }
        }
        

        
        /// <summary>
        /// Форма
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataForm")]
        
        public INsgObjectForm Форма
        {
            get
            {
                INsgObjectForm res = null;
                if (ObjectList["Форма"].SubType == NsgRekvisitSubType.ListForm)
                   res = NsgSettings.MainForm.GetObjectListForm(this,"Форма");
                else
                   res = NsgSettings.MainForm.GetObjectForm(this,"Форма");
                return res;
           }
        }
        
        #region Свойства NsgSoft.DataObjects.NsgReportObject
        




        #endregion // Свойства NsgSoft.DataObjects.NsgReportObject

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgReportObject
        




        #endregion // Методы NsgSoft.DataObjects.NsgReportObject

        #region Методы NsgMultipleObject
        private ЗагрузкаКурсов[] convertArray(NsgMultipleObject[] array)
        {
            ЗагрузкаКурсов[] res = new ЗагрузкаКурсов[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск множества результатов на полное совпадение. Перегруженные методы.
        /// <summary>
        /// Метод поиска в БД по одному и более реквизитов с ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        /// </remarks>
        /// <param name="compare">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual ЗагрузкаКурсов[] FindAll(NsgCompare compare)
        {
            return convertArray(base.FindAll(compare));
        }

        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному и более реквизитов
        ///  c ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="paramAll">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual ЗагрузкаКурсов[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, compare));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Имя реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual ЗагрузкаКурсов[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Идентификатор реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual ЗагрузкаКурсов[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ЗагрузкаКурсов(this as NsgObject);
            }
        }

        #endregion // Методы NsgMultipleObject
        #endregion // Методы

        /// <summary>
        /// Описатель колонки источника данных
        /// </summary>
        public new class ColumnDescriptor : NsgSoft.Forms.NsgColumnDescriptor
        {
            public ColumnDescriptor()
                : base()
            {
                base.NSGType = typeof(ЗагрузкаКурсов);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ЗагрузкаКурсов Value
            {
                get
                {
                    return (ЗагрузкаКурсов)base.Value;
                }
                set
                {
                    base.Value = value;
                }
            }

            /// <summary>
            /// Имя иконки колонки
            /// </summary>
            public override string ImageKey
            {
                get
                {
                    return "s_NsgReportObject";
                }
            }
        }
    }

}
