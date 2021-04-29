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
    
    [NsgTypeName("NsgDataTable", Guid = "68d38dd3-89a7-4c2e-bd0c-8aecee80c965")]
    public partial class ТаблицаЭлементаМенюПользователя : NsgSoft.DataObjects.NsgDataTable
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
        protected ТаблицаЭлементаМенюПользователя()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ТаблицаЭлементаМенюПользователя(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ТаблицаЭлементаМенюПользователя Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("68d38dd3-89a7-4c2e-bd0c-8aecee80c965"));
            if (obj == null)
                obj = new ТаблицаЭлементаМенюПользователя();
            return obj as ТаблицаЭлементаМенюПользователя;
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
	Идентификатор.Guid = NsgService.StringToGuid("8fc7b27c-b4ab-4fb8-b01c-d68679f8f6f7");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("141814a0-edb7-4420-bcb8-c9b69e97d8cd");
	
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
	Владелец.FilterForConfigurator = "Сервис.ЭлементМенюПользователя";
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
		 new System.Object[]{""});
	Владелец.Description = "Владелец";
	Владелец.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Владелец.GroupName = "";
	Владелец.Guid = NsgService.StringToGuid("80629349-39bc-4de8-a03a-51dde378fd87");
	
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
	НомерСтроки.Guid = NsgService.StringToGuid("9156a48d-dd98-4f51-b081-b4bd8a9ec981");
	
				if (!ObjectList.Contains("НомерСтроки"))
                    ObjectList.Add(НомерСтроки);
			}
			#endregion //создание System.Int64 НомерСтроки
			
			#region создание Сервис.РольПользователяМеню РольПользователя
			{  
                NsgDataTypedReference РольПользователя = null;
				if (ObjectList.Contains("РольПользователя"))
                    РольПользователя = ObjectList["РольПользователя"] as NsgDataTypedReference;
                else
                    РольПользователя = new NsgDataTypedReference();
	//NsgDataTypedReference
	РольПользователя.IsLoadedFromDll = true;
	РольПользователя.ReferentGroup = "Сервис";
	РольПользователя.ReferentName = "РольПользователяМеню";
	РольПользователя.SaveInDatabase = true;
	РольПользователя.OwnerName = "";
	РольПользователя.AllowEmptyOwner = false;
	РольПользователя.StringFormat = "";
	РольПользователя.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	РольПользователя.IncludeInPredefined = false;
	РольПользователя.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	РольПользователя.Required = false;
	РольПользователя.EmptyValue = "";
	РольПользователя.NullAllow = false;
	РольПользователя.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	РольПользователя.FieldName = "_Role";
	РольПользователя.InformMetaDataOnValueChanged = false;
	РольПользователя.Visible = true;
	РольПользователя.Name = "РольПользователя";
	РольПользователя.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Роль пользователя"});
	РольПользователя.Description = "Роль пользователя";
	РольПользователя.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	РольПользователя.GroupName = "";
	РольПользователя.Guid = NsgService.StringToGuid("46bce242-08e9-4db4-bb20-a80adf03d276");
	
				if (!ObjectList.Contains("РольПользователя"))
                    ObjectList.Add(РольПользователя);
			}
			#endregion //создание Сервис.РольПользователяМеню РольПользователя
			
			#region создание System.Boolean Активность
			{  
                NsgDataBoolean Активность = null;
				if (ObjectList.Contains("Активность"))
                    Активность = ObjectList["Активность"] as NsgDataBoolean;
                else
                    Активность = new NsgDataBoolean();
	//NsgDataBoolean
	Активность.IsLoadedFromDll = true;
	Активность.DefaultValue = false;
	Активность.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Активность.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Активность.StringFormat = "";
	Активность.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Активность.IncludeInPredefined = false;
	Активность.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Активность.Required = false;
	Активность.EmptyValue = "";
	Активность.NullAllow = false;
	Активность.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Активность.FieldName = "_Active";
	Активность.SaveInDatabase = true;
	Активность.InformMetaDataOnValueChanged = false;
	Активность.Visible = true;
	Активность.Name = "Активность";
	Активность.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Активность"});
	Активность.Description = "Активность";
	Активность.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Активность.GroupName = "";
	Активность.Guid = NsgService.StringToGuid("78ee517c-6300-48dd-9714-9b2b5e161e3e");
	
				if (!ObjectList.Contains("Активность"))
                    ObjectList.Add(Активность);
			}
			#endregion //создание System.Boolean Активность
			
			#region создание System.Boolean Открыть
			{  
                NsgDataBoolean Открыть = null;
				if (ObjectList.Contains("Открыть"))
                    Открыть = ObjectList["Открыть"] as NsgDataBoolean;
                else
                    Открыть = new NsgDataBoolean();
	//NsgDataBoolean
	Открыть.IsLoadedFromDll = true;
	Открыть.DefaultValue = false;
	Открыть.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Открыть.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Открыть.StringFormat = "";
	Открыть.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	Открыть.IncludeInPredefined = false;
	Открыть.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Открыть.Required = false;
	Открыть.EmptyValue = "";
	Открыть.NullAllow = false;
	Открыть.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Открыть.FieldName = "_Open";
	Открыть.SaveInDatabase = true;
	Открыть.InformMetaDataOnValueChanged = false;
	Открыть.Visible = true;
	Открыть.Name = "Открыть";
	Открыть.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Открыть"});
	Открыть.Description = "Открыть";
	Открыть.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Открыть.GroupName = "";
	Открыть.Guid = NsgService.StringToGuid("424cf29f-a5cc-42f2-8d20-639204209702");
	
				if (!ObjectList.Contains("Открыть"))
                    ObjectList.Add(Открыть);
			}
			#endregion //создание System.Boolean Открыть
			
			#region создание System.Boolean СоздатьНовый
			{  
                NsgDataBoolean СоздатьНовый = null;
				if (ObjectList.Contains("СоздатьНовый"))
                    СоздатьНовый = ObjectList["СоздатьНовый"] as NsgDataBoolean;
                else
                    СоздатьНовый = new NsgDataBoolean();
	//NsgDataBoolean
	СоздатьНовый.IsLoadedFromDll = true;
	СоздатьНовый.DefaultValue = false;
	СоздатьНовый.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СоздатьНовый.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СоздатьНовый.StringFormat = "";
	СоздатьНовый.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	СоздатьНовый.IncludeInPredefined = false;
	СоздатьНовый.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СоздатьНовый.Required = false;
	СоздатьНовый.EmptyValue = "";
	СоздатьНовый.NullAllow = false;
	СоздатьНовый.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СоздатьНовый.FieldName = "_CreateNew";
	СоздатьНовый.SaveInDatabase = true;
	СоздатьНовый.InformMetaDataOnValueChanged = false;
	СоздатьНовый.Visible = true;
	СоздатьНовый.Name = "СоздатьНовый";
	СоздатьНовый.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Создать новый"});
	СоздатьНовый.Description = "Создать новый";
	СоздатьНовый.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	СоздатьНовый.GroupName = "";
	СоздатьНовый.Guid = NsgService.StringToGuid("ea4fc8f4-275b-4bf5-98d3-fc3efb3f7a90");
	
				if (!ObjectList.Contains("СоздатьНовый"))
                    ObjectList.Add(СоздатьНовый);
			}
			#endregion //создание System.Boolean СоздатьНовый
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Сервис.ЭлементМенюПользователя";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 0;
	TableSubType = NsgSoft.Common.NsgTableSubType.TablePart;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ТаблицаЭлементаМенюПользователя";
	Visible = true;
	Guid = NsgService.StringToGuid("68d38dd3-89a7-4c2e-bd0c-8aecee80c965");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = true;
	TableName = "TablePartUserMenuItem";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Таблица элемента меню пользователя"});
	Description = "Таблица элемента меню пользователя";
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
            /// Роль пользователя
            /// </summary>
            public static String РольПользователя
            {
                get
                {
                    return "РольПользователя";
                }
            }
            
            /// <summary>
            /// Активность
            /// </summary>
            public static String Активность
            {
                get
                {
                    return "Активность";
                }
            }
            
            /// <summary>
            /// Открыть
            /// </summary>
            public static String Открыть
            {
                get
                {
                    return "Открыть";
                }
            }
            
            /// <summary>
            /// Создать новый
            /// </summary>
            public static String СоздатьНовый
            {
                get
                {
                    return "СоздатьНовый";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public static string GetFullName()
        {
            return "Сервис.ТаблицаЭлементаМенюПользователя";
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
        [NsgReferentsFilterAttribute("Сервис.ЭлементМенюПользователя")]
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
        /// Роль пользователя
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Сервис.РольПользователяМеню РольПользователя
        {
            get
            {
				 NsgDataTypedReference __РольПользователя = ObjectList["РольПользователя"] as NsgDataTypedReference;
                 return (Сервис.РольПользователяМеню)__РольПользователя.Referent;
            }
            set
            {
                NsgDataTypedReference __РольПользователя = ObjectList["РольПользователя"] as NsgDataTypedReference;
                __РольПользователя.Referent = value;
            }
        }
        
        /// <summary>
        /// Активность
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean Активность
        {
            get
            {
				 NsgDataBoolean __Активность = ObjectList["Активность"] as NsgDataBoolean;
                 return (System.Boolean)__Активность.Value;
            }
            set
            {
                NsgDataBoolean __Активность = ObjectList["Активность"] as NsgDataBoolean;
                __Активность.Value = value;
            }
        }
        
        /// <summary>
        /// Открыть
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean Открыть
        {
            get
            {
				 NsgDataBoolean __Открыть = ObjectList["Открыть"] as NsgDataBoolean;
                 return (System.Boolean)__Открыть.Value;
            }
            set
            {
                NsgDataBoolean __Открыть = ObjectList["Открыть"] as NsgDataBoolean;
                __Открыть.Value = value;
            }
        }
        
        /// <summary>
        /// Создать новый
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean СоздатьНовый
        {
            get
            {
				 NsgDataBoolean __СоздатьНовый = ObjectList["СоздатьНовый"] as NsgDataBoolean;
                 return (System.Boolean)__СоздатьНовый.Value;
            }
            set
            {
                NsgDataBoolean __СоздатьНовый = ObjectList["СоздатьНовый"] as NsgDataBoolean;
                __СоздатьНовый.Value = value;
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
        public new ТаблицаЭлементаМенюПользователя.Строка NewRow()
        {
            return newRow(null) as ТаблицаЭлементаМенюПользователя.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new ТаблицаЭлементаМенюПользователя.Строка(this);
            return base.newRow(row) as ТаблицаЭлементаМенюПользователя.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public ТаблицаЭлементаМенюПользователя.Строка NewRow(ТаблицаЭлементаМенюПользователя.Строка inRow)
        {
            ТаблицаЭлементаМенюПользователя.Строка row = inRow.Clone as ТаблицаЭлементаМенюПользователя.Строка;
            return base.newRow(row) as ТаблицаЭлементаМенюПользователя.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new ТаблицаЭлементаМенюПользователя.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as ТаблицаЭлементаМенюПользователя.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new ТаблицаЭлементаМенюПользователя.Строка GetEtalonRow()
        {
            ТаблицаЭлементаМенюПользователя.Строка row = new ТаблицаЭлементаМенюПользователя.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private ТаблицаЭлементаМенюПользователя.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            ТаблицаЭлементаМенюПользователя.Строка[] res = new ТаблицаЭлементаМенюПользователя.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ТаблицаЭлементаМенюПользователя.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as ТаблицаЭлементаМенюПользователя.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ТаблицаЭлементаМенюПользователя.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ТаблицаЭлементаМенюПользователя.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as ТаблицаЭлементаМенюПользователя.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ТаблицаЭлементаМенюПользователя.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as ТаблицаЭлементаМенюПользователя.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ТаблицаЭлементаМенюПользователя.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as ТаблицаЭлементаМенюПользователя.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new ТаблицаЭлементаМенюПользователя.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ТаблицаЭлементаМенюПользователя.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new ТаблицаЭлементаМенюПользователя.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<ТаблицаЭлементаМенюПользователя> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<ТаблицаЭлементаМенюПользователя>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new ТаблицаЭлементаМенюПользователя.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new ТаблицаЭлементаМенюПользователя.Строка[] AllRows
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
        public new ТаблицаЭлементаМенюПользователя.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as ТаблицаЭлементаМенюПользователя.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private ТаблицаЭлементаМенюПользователя[] convertArray(NsgMultipleObject[] array)
        {
            ТаблицаЭлементаМенюПользователя[] res = new ТаблицаЭлементаМенюПользователя[array.Length];
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
        public new virtual ТаблицаЭлементаМенюПользователя[] FindAll(NsgCompare compare)
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
        public new virtual ТаблицаЭлементаМенюПользователя[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ТаблицаЭлементаМенюПользователя[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ТаблицаЭлементаМенюПользователя[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ТаблицаЭлементаМенюПользователя(this as NsgObject);
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
                base.NSGType = typeof(ТаблицаЭлементаМенюПользователя);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ТаблицаЭлементаМенюПользователя Value
            {
                get
                {
                    return (ТаблицаЭлементаМенюПользователя)base.Value;
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
