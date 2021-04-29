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

namespace ОбменникВалют.Метаданные.Сервис
{
    
    [NsgTypeName("NsgDataTable", Guid = "f9a47e31-2719-4d05-bd5c-9d8b3dcbd0d6")]
    public partial class НастройкиПользователей : NsgSoft.DataObjects.NsgDataTable
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataTable
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataTable

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataTable
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataTable

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected НастройкиПользователей()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected НастройкиПользователей(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static НастройкиПользователей Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("f9a47e31-2719-4d05-bd5c-9d8b3dcbd0d6"));
            if (obj == null)
                obj = new НастройкиПользователей();
            return obj as НастройкиПользователей;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataTable
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataTable
			
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
	Идентификатор.SaveInDatabase = true;
	Идентификатор.InformMetaDataOnValueChanged = false;
	Идентификатор.Visible = true;
	Идентификатор.Name = "Идентификатор";
	Идентификатор.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Идентификатор.Description = "Идентификатор";
	Идентификатор.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Идентификатор.GroupName = "";
	Идентификатор.Guid = NsgService.StringToGuid("dab3a7de-6b0c-472b-b0f6-11dc91c9a0b3");
	
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
	Автоинкремент.SaveInDatabase = true;
	Автоинкремент.InformMetaDataOnValueChanged = false;
	Автоинкремент.Visible = true;
	Автоинкремент.Name = "Автоинкремент";
	Автоинкремент.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Автоинкремент.Description = "Автоинкремент";
	Автоинкремент.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	Автоинкремент.GroupName = "";
	Автоинкремент.Guid = NsgService.StringToGuid("9c23f9c7-9d44-4bde-8d8b-6117a9364483");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			{  
                NsgDataUntypedReference Владелец = null;
				if (ObjectList.Contains("Владелец"))
                    Владелец = ObjectList["Владелец"] as NsgDataUntypedReference;
                else
                    Владелец = new NsgDataUntypedReference();
	//NsgDataUntypedReference
	Владелец.IsLoadedFromDll = true;
	Владелец.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.List;
	Владелец.FilterForConfigurator = "";
	Владелец.ReferentName = "";
	Владелец.ReferentGroup = "";
	Владелец.TypeSelectorName = "";
	Владелец.SaveInDatabase = true;
	Владелец.OwnerName = "";
	Владелец.AllowEmptyOwner = false;
	Владелец.StringFormat = "";
	Владелец.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Владелец.IncludeInPredefined = false;
	Владелец.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Владелец.Required = false;
	Владелец.EmptyValue = "";
	Владелец.NullAllow = false;
	Владелец.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Владелец.FieldName = "_Owner";
	Владелец.InformMetaDataOnValueChanged = false;
	Владелец.Visible = true;
	Владелец.Name = "Владелец";
	Владелец.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Владелец"});
	Владелец.Description = "Владелец";
	Владелец.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Владелец.GroupName = "";
	Владелец.Guid = NsgService.StringToGuid("5f5ec44a-e005-4b2c-b621-e676d7550610");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
			#region создание System.Int64 НомерСтроки
			{  
                NsgDataInteger НомерСтроки = null;
				if (ObjectList.Contains("НомерСтроки"))
                    НомерСтроки = ObjectList["НомерСтроки"] as NsgDataInteger;
                else
                    НомерСтроки = new NsgDataInteger();
	//NsgDataInteger
	НомерСтроки.IsLoadedFromDll = true;
	НомерСтроки.DefaultValue = 0M;
	НомерСтроки.MinValue = 0M;
	НомерСтроки.MaxValue = 0M;
	НомерСтроки.UseCalculator = true;
	НомерСтроки.StringFormat = "";
	НомерСтроки.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НомерСтроки.IncludeInPredefined = false;
	НомерСтроки.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерСтроки.Required = false;
	НомерСтроки.EmptyValue = "";
	НомерСтроки.NullAllow = false;
	НомерСтроки.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НомерСтроки.FieldName = "_RowNumber";
	НомерСтроки.SaveInDatabase = true;
	НомерСтроки.InformMetaDataOnValueChanged = false;
	НомерСтроки.Visible = true;
	НомерСтроки.Name = "НомерСтроки";
	НомерСтроки.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НомерСтроки.Description = "Номер строки";
	НомерСтроки.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	НомерСтроки.GroupName = "";
	НомерСтроки.Guid = NsgService.StringToGuid("07f904c5-e90c-41cf-a9b7-1bab71ba0373");
	
				if (!ObjectList.Contains("НомерСтроки"))
                    ObjectList.Add(НомерСтроки);
			}
			#endregion //создание System.Int64 НомерСтроки
			
			#region создание System.Guid ИдентификаторОбъекта
			{  
                NsgDataGuid ИдентификаторОбъекта = null;
				if (ObjectList.Contains("ИдентификаторОбъекта"))
                    ИдентификаторОбъекта = ObjectList["ИдентификаторОбъекта"] as NsgDataGuid;
                else
                    ИдентификаторОбъекта = new NsgDataGuid();
	//NsgDataGuid
	ИдентификаторОбъекта.IsLoadedFromDll = true;
	ИдентификаторОбъекта.StringFormat = "";
	ИдентификаторОбъекта.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ИдентификаторОбъекта.IncludeInPredefined = false;
	ИдентификаторОбъекта.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИдентификаторОбъекта.Required = false;
	ИдентификаторОбъекта.EmptyValue = "";
	ИдентификаторОбъекта.NullAllow = false;
	ИдентификаторОбъекта.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИдентификаторОбъекта.FieldName = "_ObjectID";
	ИдентификаторОбъекта.SaveInDatabase = true;
	ИдентификаторОбъекта.InformMetaDataOnValueChanged = false;
	ИдентификаторОбъекта.Visible = true;
	ИдентификаторОбъекта.Name = "ИдентификаторОбъекта";
	ИдентификаторОбъекта.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Идентификатор объекта"});
	ИдентификаторОбъекта.Description = "Идентификатор объекта";
	ИдентификаторОбъекта.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ИдентификаторОбъекта.GroupName = "";
	ИдентификаторОбъекта.Guid = NsgService.StringToGuid("cd98eff4-604a-4c96-8dce-12e977baee8a");
	
				if (!ObjectList.Contains("ИдентификаторОбъекта"))
                    ObjectList.Add(ИдентификаторОбъекта);
			}
			#endregion //создание System.Guid ИдентификаторОбъекта
			
			#region создание System.Guid ОбъектМетаданных
			{  
                NsgDataGuid ОбъектМетаданных = null;
				if (ObjectList.Contains("ОбъектМетаданных"))
                    ОбъектМетаданных = ObjectList["ОбъектМетаданных"] as NsgDataGuid;
                else
                    ОбъектМетаданных = new NsgDataGuid();
	//NsgDataGuid
	ОбъектМетаданных.IsLoadedFromDll = true;
	ОбъектМетаданных.StringFormat = "";
	ОбъектМетаданных.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ОбъектМетаданных.IncludeInPredefined = false;
	ОбъектМетаданных.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбъектМетаданных.Required = false;
	ОбъектМетаданных.EmptyValue = "";
	ОбъектМетаданных.NullAllow = false;
	ОбъектМетаданных.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбъектМетаданных.FieldName = "_MetaObject";
	ОбъектМетаданных.SaveInDatabase = true;
	ОбъектМетаданных.InformMetaDataOnValueChanged = false;
	ОбъектМетаданных.Visible = true;
	ОбъектМетаданных.Name = "ОбъектМетаданных";
	ОбъектМетаданных.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Объект метаданных"});
	ОбъектМетаданных.Description = "Объект метаданных";
	ОбъектМетаданных.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ОбъектМетаданных.GroupName = "";
	ОбъектМетаданных.Guid = NsgService.StringToGuid("81808ce4-5486-4c2d-8fb1-c6b2940042e7");
	
				if (!ObjectList.Contains("ОбъектМетаданных"))
                    ObjectList.Add(ОбъектМетаданных);
			}
			#endregion //создание System.Guid ОбъектМетаданных
			
			#region создание System.String Наименование
			{  
                NsgDataString Наименование = null;
				if (ObjectList.Contains("Наименование"))
                    Наименование = ObjectList["Наименование"] as NsgDataString;
                else
                    Наименование = new NsgDataString();
	//NsgDataString
	Наименование.IsLoadedFromDll = true;
	Наименование.Length = 50;
	Наименование.StringFormat = "";
	Наименование.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Наименование.IncludeInPredefined = false;
	Наименование.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Наименование.Required = false;
	Наименование.EmptyValue = "";
	Наименование.NullAllow = false;
	Наименование.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Наименование.FieldName = "_Name";
	Наименование.SaveInDatabase = true;
	Наименование.InformMetaDataOnValueChanged = false;
	Наименование.Visible = true;
	Наименование.Name = "Наименование";
	Наименование.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Имя настройки"});
	Наименование.Description = "Имя настройки";
	Наименование.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Наименование.GroupName = "";
	Наименование.Guid = NsgService.StringToGuid("a45b37e8-2381-4be2-bf70-4ec459a00029");
	
				if (!ObjectList.Contains("Наименование"))
                    ObjectList.Add(Наименование);
			}
			#endregion //создание System.String Наименование
			
			#region создание System.String XmlText
			{  
                NsgDataString XmlText = null;
				if (ObjectList.Contains("XmlText"))
                    XmlText = ObjectList["XmlText"] as NsgDataString;
                else
                    XmlText = new NsgDataString();
	//NsgDataString
	XmlText.IsLoadedFromDll = true;
	XmlText.Length = 0;
	XmlText.StringFormat = "";
	XmlText.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	XmlText.IncludeInPredefined = false;
	XmlText.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	XmlText.Required = false;
	XmlText.EmptyValue = "";
	XmlText.NullAllow = false;
	XmlText.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	XmlText.FieldName = "_XmlText";
	XmlText.SaveInDatabase = true;
	XmlText.InformMetaDataOnValueChanged = false;
	XmlText.Visible = true;
	XmlText.Name = "XmlText";
	XmlText.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Xml текст"});
	XmlText.Description = "Xml текст";
	XmlText.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	XmlText.GroupName = "";
	XmlText.Guid = NsgService.StringToGuid("794fc304-6cfa-4877-83fb-b147cf0262f7");
	
				if (!ObjectList.Contains("XmlText"))
                    ObjectList.Add(XmlText);
			}
			#endregion //создание System.String XmlText
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "НастройкиПользователей";
	Visible = true;
	Guid = NsgService.StringToGuid("f9a47e31-2719-4d05-bd5c-9d8b3dcbd0d6");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "UserSettingsTable";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Настройки пользователей"});
	Description = "Настройки пользователей";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	GroupName = "Сервис";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataTable
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataTable

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
        public new partial class Names// :NsgSoft.DataObjects.NsgDataTable.Names
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
            /// Владелец
            /// </summary>
            public static String Владелец
            {
                get
                {
                    return "Владелец";
                }
            }
            
            /// <summary>
            /// Номер строки
            /// </summary>
            public static String НомерСтроки
            {
                get
                {
                    return "НомерСтроки";
                }
            }
            
            /// <summary>
            /// Идентификатор объекта
            /// </summary>
            public static String ИдентификаторОбъекта
            {
                get
                {
                    return "ИдентификаторОбъекта";
                }
            }
            
            /// <summary>
            /// Объект метаданных
            /// </summary>
            public static String ОбъектМетаданных
            {
                get
                {
                    return "ОбъектМетаданных";
                }
            }
            
            /// <summary>
            /// Имя настройки
            /// </summary>
            public static String Наименование
            {
                get
                {
                    return "Наименование";
                }
            }
            
            /// <summary>
            /// Xml текст
            /// </summary>
            public static String XmlText
            {
                get
                {
                    return "XmlText";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public static string GetFullName()
        {
            return "Сервис.НастройкиПользователей";
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
        /// Владелец
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("")]
        public NsgSoft.DataObjects.NsgReferencedObject Владелец
        {
            get
            {
				 NsgDataUntypedReference __Владелец = ObjectList["Владелец"] as NsgDataUntypedReference;
                 return (NsgSoft.DataObjects.NsgReferencedObject)__Владелец.Referent;
            }
            set
            {
                NsgDataUntypedReference __Владелец = ObjectList["Владелец"] as NsgDataUntypedReference;
                __Владелец.Referent = value;
            }
        }
        
        /// <summary>
        /// Номер строки
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 НомерСтроки
        {
            get
            {
				 NsgDataInteger __НомерСтроки = ObjectList["НомерСтроки"] as NsgDataInteger;
                 return (System.Int64)__НомерСтроки.Value;
            }
            set
            {
                NsgDataInteger __НомерСтроки = ObjectList["НомерСтроки"] as NsgDataInteger;
                __НомерСтроки.Value = value;
            }
        }
        
        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataGuid")]
        
        public System.Guid ИдентификаторОбъекта
        {
            get
            {
				 NsgDataGuid __ИдентификаторОбъекта = ObjectList["ИдентификаторОбъекта"] as NsgDataGuid;
                 return (System.Guid)__ИдентификаторОбъекта.Value;
            }
            set
            {
                NsgDataGuid __ИдентификаторОбъекта = ObjectList["ИдентификаторОбъекта"] as NsgDataGuid;
                __ИдентификаторОбъекта.Value = value;
            }
        }
        
        /// <summary>
        /// Объект метаданных
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataGuid")]
        
        public System.Guid ОбъектМетаданных
        {
            get
            {
				 NsgDataGuid __ОбъектМетаданных = ObjectList["ОбъектМетаданных"] as NsgDataGuid;
                 return (System.Guid)__ОбъектМетаданных.Value;
            }
            set
            {
                NsgDataGuid __ОбъектМетаданных = ObjectList["ОбъектМетаданных"] as NsgDataGuid;
                __ОбъектМетаданных.Value = value;
            }
        }
        
        /// <summary>
        /// Имя настройки
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Наименование
        {
            get
            {
				 NsgDataString __Наименование = ObjectList["Наименование"] as NsgDataString;
                 return (System.String)__Наименование.Value;
            }
            set
            {
                NsgDataString __Наименование = ObjectList["Наименование"] as NsgDataString;
                __Наименование.Value = value;
            }
        }
        
        /// <summary>
        /// Xml текст
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String XmlText
        {
            get
            {
				 NsgDataString __XmlText = ObjectList["XmlText"] as NsgDataString;
                 return (System.String)__XmlText.Value;
            }
            set
            {
                NsgDataString __XmlText = ObjectList["XmlText"] as NsgDataString;
                __XmlText.Value = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataTable
        




        #endregion // Свойства NsgSoft.DataObjects.NsgDataTable

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataTable
        

        /// <summary>
        /// Добавить новую строку в таблицу
        /// </summary>
        public new НастройкиПользователей.Строка NewRow()
        {
            return newRow(null) as НастройкиПользователей.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new НастройкиПользователей.Строка(this);
            return base.newRow(row) as НастройкиПользователей.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public НастройкиПользователей.Строка NewRow(НастройкиПользователей.Строка inRow)
        {
            НастройкиПользователей.Строка row = inRow.Clone as НастройкиПользователей.Строка;
            return base.newRow(row) as НастройкиПользователей.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new НастройкиПользователей.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as НастройкиПользователей.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new НастройкиПользователей.Строка GetEtalonRow()
        {
            НастройкиПользователей.Строка row = new НастройкиПользователей.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private НастройкиПользователей.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            НастройкиПользователей.Строка[] res = new НастройкиПользователей.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new НастройкиПользователей.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as НастройкиПользователей.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new НастройкиПользователей.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new НастройкиПользователей.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as НастройкиПользователей.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new НастройкиПользователей.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as НастройкиПользователей.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new НастройкиПользователей.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as НастройкиПользователей.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new НастройкиПользователей.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new НастройкиПользователей.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new НастройкиПользователей.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<НастройкиПользователей> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<НастройкиПользователей>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new НастройкиПользователей.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new НастройкиПользователей.Строка[] AllRows
        {
            get
            {
                return convertRowsArray(base.AllRows);
            }
        }

        /// <summary>
        /// Получить строку таблицы
        /// </summary>
        /// <param name="inName">Идентификатор строки.</param>
        /// <returns>Найденные строки.</returns>
        public new НастройкиПользователей.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as НастройкиПользователей.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private НастройкиПользователей[] convertArray(NsgMultipleObject[] array)
        {
            НастройкиПользователей[] res = new НастройкиПользователей[array.Length];
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
        public new virtual НастройкиПользователей[] FindAll(NsgCompare compare)
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
        public new virtual НастройкиПользователей[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual НастройкиПользователей[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual НастройкиПользователей[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new НастройкиПользователей(this as NsgObject);
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
                base.NSGType = typeof(НастройкиПользователей);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new НастройкиПользователей Value
            {
                get
                {
                    return (НастройкиПользователей)base.Value;
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
                    return "s_NsgDataTable";
                }
            }
        }
    }

}
