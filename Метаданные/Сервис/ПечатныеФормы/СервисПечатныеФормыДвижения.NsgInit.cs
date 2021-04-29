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

namespace ОбменникВалют.Метаданные._SystemTables
{
    
    [NsgTypeName("NsgDataTable", Guid = "6d4129b9-66ec-4203-8df5-6fcfc98ba004")]
    public partial class СервисПечатныеФормыДвижения : NsgSoft.DataObjects.NsgDataTable
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
        protected СервисПечатныеФормыДвижения()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected СервисПечатныеФормыДвижения(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static СервисПечатныеФормыДвижения Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("6d4129b9-66ec-4203-8df5-6fcfc98ba004"));
            if (obj == null)
                obj = new СервисПечатныеФормыДвижения();
            return obj as СервисПечатныеФормыДвижения;
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
	Идентификатор.Guid = NsgService.StringToGuid("56a32842-c595-4870-871c-bb76d0d085cd");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("397890d5-8d90-4eda-8daf-e94da2024096");
	
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
	Владелец.FilterForConfigurator = "Сервис.КорректировкаРегистра";
	Владелец.ReferentName = "";
	Владелец.ReferentGroup = "";
	Владелец.TypeSelectorName = "";
	Владелец.SaveInDatabase = true;
	Владелец.OwnerName = "";
	Владелец.AllowEmptyOwner = false;
	Владелец.StringFormat = "";
	Владелец.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Владелец.IncludeInPredefined = false;
	Владелец.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Владелец.Required = false;
	Владелец.EmptyValue = "";
	Владелец.NullAllow = false;
	Владелец.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Владелец.FieldName = "_Owner";
	Владелец.InformMetaDataOnValueChanged = false;
	Владелец.Visible = true;
	Владелец.Name = "Владелец";
	Владелец.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Владелец.Description = "Владелец";
	Владелец.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Владелец.GroupName = "";
	Владелец.Guid = NsgService.StringToGuid("aa437a67-1f25-4f88-bc72-b1c3427ff0a2");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
			#region создание System.DateTime Дата
			{  
                NsgDataDateTime Дата = null;
				if (ObjectList.Contains("Дата"))
                    Дата = ObjectList["Дата"] as NsgDataDateTime;
                else
                    Дата = new NsgDataDateTime();
	//NsgDataDateTime
	Дата.IsLoadedFromDll = true;
	Дата.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	Дата.StringFormat = "";
	Дата.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Дата.IncludeInPredefined = false;
	Дата.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Дата.Required = false;
	Дата.EmptyValue = "";
	Дата.NullAllow = false;
	Дата.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Дата.FieldName = "_Date";
	Дата.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Дата.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Дата.CharactericticWeight = 1;
	Дата.InformMetaDataOnValueChanged = false;
	Дата.Visible = true;
	Дата.Name = "Дата";
	Дата.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Дата документа"});
	Дата.Description = "Дата документа";
	Дата.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Дата.GroupName = "";
	Дата.Guid = NsgService.StringToGuid("2913ade9-f85e-47b4-8a88-b556da46b88f");
	
				if (!ObjectList.Contains("Дата"))
                    ObjectList.Add(Дата);
			}
			#endregion //создание System.DateTime Дата
			
			#region создание System.DateTime КонецПериода
			{  
                NsgDataDateTime КонецПериода = null;
				if (ObjectList.Contains("КонецПериода"))
                    КонецПериода = ObjectList["КонецПериода"] as NsgDataDateTime;
                else
                    КонецПериода = new NsgDataDateTime();
	//NsgDataDateTime
	КонецПериода.IsLoadedFromDll = true;
	КонецПериода.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	КонецПериода.StringFormat = "";
	КонецПериода.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	КонецПериода.IncludeInPredefined = false;
	КонецПериода.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	КонецПериода.Required = false;
	КонецПериода.EmptyValue = "";
	КонецПериода.NullAllow = false;
	КонецПериода.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	КонецПериода.FieldName = "_DateEnd";
	КонецПериода.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	КонецПериода.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	КонецПериода.CharactericticWeight = 1;
	КонецПериода.InformMetaDataOnValueChanged = false;
	КонецПериода.Visible = true;
	КонецПериода.Name = "КонецПериода";
	КонецПериода.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	КонецПериода.Description = "Конец периода";
	КонецПериода.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	КонецПериода.GroupName = "";
	КонецПериода.Guid = NsgService.StringToGuid("46d21aa2-4150-469e-b07d-a04fabf789db");
	
				if (!ObjectList.Contains("КонецПериода"))
                    ObjectList.Add(КонецПериода);
			}
			#endregion //создание System.DateTime КонецПериода
			
			#region создание NsgSoft.DataObjects.NsgMultipleObject ОбъектМетаданных
			{  
                NsgObjectSelector ОбъектМетаданных = null;
				if (ObjectList.Contains("ОбъектМетаданных"))
                    ОбъектМетаданных = ObjectList["ОбъектМетаданных"] as NsgObjectSelector;
                else
                    ОбъектМетаданных = new NsgObjectSelector();
	//NsgObjectSelector
	ОбъектМетаданных.IsLoadedFromDll = true;
	ОбъектМетаданных.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.None;
	ОбъектМетаданных.FilterForConfigurator = "";
	ОбъектМетаданных.StringFormat = "";
	ОбъектМетаданных.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	ОбъектМетаданных.IncludeInPredefined = false;
	ОбъектМетаданных.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбъектМетаданных.Required = true;
	ОбъектМетаданных.EmptyValue = "";
	ОбъектМетаданных.NullAllow = false;
	ОбъектМетаданных.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбъектМетаданных.FieldName = "ObektMetadannykh";
	ОбъектМетаданных.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	ОбъектМетаданных.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	ОбъектМетаданных.CharactericticWeight = 1;
	ОбъектМетаданных.InformMetaDataOnValueChanged = false;
	ОбъектМетаданных.Visible = true;
	ОбъектМетаданных.Name = "ОбъектМетаданных";
	ОбъектМетаданных.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбъектМетаданных.Description = "Объект метаданных";
	ОбъектМетаданных.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ОбъектМетаданных.GroupName = "";
	ОбъектМетаданных.Guid = NsgService.StringToGuid("53880aac-5c66-42e1-8d19-cd74a094a060");
	
				if (!ObjectList.Contains("ОбъектМетаданных"))
                    ObjectList.Add(ОбъектМетаданных);
			}
			#endregion //создание NsgSoft.DataObjects.NsgMultipleObject ОбъектМетаданных
			
			#region создание NsgSoft.DataObjects.NsgMultipleObject Обработка
			{  
                NsgObjectSelector Обработка = null;
				if (ObjectList.Contains("Обработка"))
                    Обработка = ObjectList["Обработка"] as NsgObjectSelector;
                else
                    Обработка = new NsgObjectSelector();
	//NsgObjectSelector
	Обработка.IsLoadedFromDll = true;
	Обработка.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.Type;
	Обработка.FilterForConfigurator = "NsgReportObject";
	Обработка.StringFormat = "";
	Обработка.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Обработка.IncludeInPredefined = false;
	Обработка.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Обработка.Required = true;
	Обработка.EmptyValue = "";
	Обработка.NullAllow = false;
	Обработка.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Обработка.FieldName = "Obrabotka";
	Обработка.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Обработка.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Обработка.CharactericticWeight = 1;
	Обработка.InformMetaDataOnValueChanged = false;
	Обработка.Visible = true;
	Обработка.Name = "Обработка";
	Обработка.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Обработка.Description = "Обработка";
	Обработка.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Обработка.GroupName = "";
	Обработка.Guid = NsgService.StringToGuid("8e13fba9-21a7-4e82-a849-5840f66d1d02");
	
				if (!ObjectList.Contains("Обработка"))
                    ObjectList.Add(Обработка);
			}
			#endregion //создание NsgSoft.DataObjects.NsgMultipleObject Обработка
			
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
	Наименование.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Наименование.IncludeInPredefined = false;
	Наименование.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Наименование.Required = true;
	Наименование.EmptyValue = "";
	Наименование.NullAllow = false;
	Наименование.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Наименование.FieldName = "Naimenovanie";
	Наименование.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Наименование.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Наименование.CharactericticWeight = 1;
	Наименование.InformMetaDataOnValueChanged = false;
	Наименование.Visible = true;
	Наименование.Name = "Наименование";
	Наименование.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Наименование.Description = "Наименование";
	Наименование.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Наименование.GroupName = "";
	Наименование.Guid = NsgService.StringToGuid("680eb9ef-6cb3-4130-b8b6-5488e9b07c9b");
	
				if (!ObjectList.Contains("Наименование"))
                    ObjectList.Add(Наименование);
			}
			#endregion //создание System.String Наименование
			
			#region создание System.IO.MemoryStream ПечатнаяФорма
			{  
                NsgDataBinary ПечатнаяФорма = null;
				if (ObjectList.Contains("ПечатнаяФорма"))
                    ПечатнаяФорма = ObjectList["ПечатнаяФорма"] as NsgDataBinary;
                else
                    ПечатнаяФорма = new NsgDataBinary();
	//NsgDataBinary
	ПечатнаяФорма.IsLoadedFromDll = true;
	ПечатнаяФорма.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПечатнаяФорма.NullAllow = true;
	ПечатнаяФорма.StringFormat = "";
	ПечатнаяФорма.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ПечатнаяФорма.IncludeInPredefined = false;
	ПечатнаяФорма.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПечатнаяФорма.Required = false;
	ПечатнаяФорма.EmptyValue = "";
	ПечатнаяФорма.FieldName = "PechatnajaForma";
	ПечатнаяФорма.SaveInDatabase = true;
	ПечатнаяФорма.InformMetaDataOnValueChanged = false;
	ПечатнаяФорма.Visible = true;
	ПечатнаяФорма.Name = "ПечатнаяФорма";
	ПечатнаяФорма.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПечатнаяФорма.Description = "Печатная форма";
	ПечатнаяФорма.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ПечатнаяФорма.GroupName = "";
	ПечатнаяФорма.Guid = NsgService.StringToGuid("268831bd-049e-43c7-b684-e1c935c5fa28");
	
				if (!ObjectList.Contains("ПечатнаяФорма"))
                    ObjectList.Add(ПечатнаяФорма);
			}
			#endregion //создание System.IO.MemoryStream ПечатнаяФорма
			
			#region создание System.IO.MemoryStream Условие
			{  
                NsgDataBinary Условие = null;
				if (ObjectList.Contains("Условие"))
                    Условие = ObjectList["Условие"] as NsgDataBinary;
                else
                    Условие = new NsgDataBinary();
	//NsgDataBinary
	Условие.IsLoadedFromDll = true;
	Условие.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Условие.NullAllow = true;
	Условие.StringFormat = "";
	Условие.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Условие.IncludeInPredefined = false;
	Условие.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Условие.Required = false;
	Условие.EmptyValue = "";
	Условие.FieldName = "Uslovie";
	Условие.SaveInDatabase = true;
	Условие.InformMetaDataOnValueChanged = false;
	Условие.Visible = true;
	Условие.Name = "Условие";
	Условие.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Условие.Description = "Условие";
	Условие.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Условие.GroupName = "";
	Условие.Guid = NsgService.StringToGuid("987abefc-6851-4ed2-8bbb-abda1c3bfc1e");
	
				if (!ObjectList.Contains("Условие"))
                    ObjectList.Add(Условие);
			}
			#endregion //создание System.IO.MemoryStream Условие
			

			#region заполнение полей класса
				//NsgDataTable
	IsLoadedFromDll = true;
	OwnerFullName = "Сервис.ПечатныеФормы";
	RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	RegisterPeriodCount = 1;
	TableSubType = NsgSoft.Common.NsgTableSubType.RegisterCharacteristicsTable;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "СервисПечатныеФормыДвижения";
	Visible = true;
	Guid = NsgService.StringToGuid("6d4129b9-66ec-4203-8df5-6fcfc98ba004");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "Идентификатор";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "_tab_ServisPechatnyeForm";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Сервис печатные формы движения";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "_SystemTables";
	
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
            /// Дата документа
            /// </summary>
            public static String Дата
            {
                get
                {
                    return "Дата";
                }
            }
            
            /// <summary>
            /// Конец периода
            /// </summary>
            public static String КонецПериода
            {
                get
                {
                    return "КонецПериода";
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
            /// Обработка
            /// </summary>
            public static String Обработка
            {
                get
                {
                    return "Обработка";
                }
            }
            
            /// <summary>
            /// Наименование
            /// </summary>
            public static String Наименование
            {
                get
                {
                    return "Наименование";
                }
            }
            
            /// <summary>
            /// Печатная форма
            /// </summary>
            public static String ПечатнаяФорма
            {
                get
                {
                    return "ПечатнаяФорма";
                }
            }
            
            /// <summary>
            /// Условие
            /// </summary>
            public static String Условие
            {
                get
                {
                    return "Условие";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public static string GetFullName()
        {
            return "_SystemTables.СервисПечатныеФормыДвижения";
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
        [NsgReferentsFilterAttribute("Сервис.КорректировкаРегистра")]
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
        /// Дата документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime Дата
        {
            get
            {
				 NsgDataDateTime __Дата = ObjectList["Дата"] as NsgDataDateTime;
                 return (System.DateTime)__Дата.Value;
            }
            set
            {
                NsgDataDateTime __Дата = ObjectList["Дата"] as NsgDataDateTime;
                __Дата.Value = value;
            }
        }
        
        /// <summary>
        /// Конец периода
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime КонецПериода
        {
            get
            {
				 NsgDataDateTime __КонецПериода = ObjectList["КонецПериода"] as NsgDataDateTime;
                 return (System.DateTime)__КонецПериода.Value;
            }
            set
            {
                NsgDataDateTime __КонецПериода = ObjectList["КонецПериода"] as NsgDataDateTime;
                __КонецПериода.Value = value;
            }
        }
        
        /// <summary>
        /// Объект метаданных
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgObjectSelector")]
        
        public NsgSoft.DataObjects.NsgMultipleObject ОбъектМетаданных
        {
            get
            {
				 NsgObjectSelector __ОбъектМетаданных = ObjectList["ОбъектМетаданных"] as NsgObjectSelector;
                 return (NsgSoft.DataObjects.NsgMultipleObject)__ОбъектМетаданных.Object;
            }
            set
            {
                NsgObjectSelector __ОбъектМетаданных = ObjectList["ОбъектМетаданных"] as NsgObjectSelector;
                __ОбъектМетаданных.Object = value;
            }
        }
        
        /// <summary>
        /// Обработка
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgObjectSelector")]
        
        public NsgSoft.DataObjects.NsgMultipleObject Обработка
        {
            get
            {
				 NsgObjectSelector __Обработка = ObjectList["Обработка"] as NsgObjectSelector;
                 return (NsgSoft.DataObjects.NsgMultipleObject)__Обработка.Object;
            }
            set
            {
                NsgObjectSelector __Обработка = ObjectList["Обработка"] as NsgObjectSelector;
                __Обработка.Object = value;
            }
        }
        
        /// <summary>
        /// Наименование
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
        /// Печатная форма
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBinary")]
        
        public System.IO.MemoryStream ПечатнаяФорма
        {
            get
            {
				 NsgDataBinary __ПечатнаяФорма = ObjectList["ПечатнаяФорма"] as NsgDataBinary;
                 return (System.IO.MemoryStream)__ПечатнаяФорма.Value;
            }
            set
            {
                NsgDataBinary __ПечатнаяФорма = ObjectList["ПечатнаяФорма"] as NsgDataBinary;
                __ПечатнаяФорма.Value = value;
            }
        }
        
        /// <summary>
        /// Условие
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBinary")]
        
        public System.IO.MemoryStream Условие
        {
            get
            {
				 NsgDataBinary __Условие = ObjectList["Условие"] as NsgDataBinary;
                 return (System.IO.MemoryStream)__Условие.Value;
            }
            set
            {
                NsgDataBinary __Условие = ObjectList["Условие"] as NsgDataBinary;
                __Условие.Value = value;
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
        public new СервисПечатныеФормыДвижения.Строка NewRow()
        {
            return newRow(null) as СервисПечатныеФормыДвижения.Строка;
        }

        /// <summary>
        /// создание строки таблицы
        /// </summary>
        protected override NsgDataTableRow newRow(NsgDataTableRow row)
        {
            if (row == null)
                row = new СервисПечатныеФормыДвижения.Строка(this);
            return base.newRow(row) as СервисПечатныеФормыДвижения.Строка;
        }

        /// <summary>
        /// Добавить новую строку в таблицу путем копирования переданной строки
        /// </summary>
        public СервисПечатныеФормыДвижения.Строка NewRow(СервисПечатныеФормыДвижения.Строка inRow)
        {
            СервисПечатныеФормыДвижения.Строка row = inRow.Clone as СервисПечатныеФормыДвижения.Строка;
            return base.newRow(row) as СервисПечатныеФормыДвижения.Строка;
        }


        /// <summary>
        /// Получить строку таблицы по номеру
        /// </summary>
        public new СервисПечатныеФормыДвижения.Строка GetRow(int rowNumber)
        {
            return base.GetRow(rowNumber) as СервисПечатныеФормыДвижения.Строка;
        }

        /// <summary>
        /// Возвращает новую строку таблицы, но в саму таблицу ее не включает (эталонная строка)
        /// </summary>
        public new СервисПечатныеФормыДвижения.Строка GetEtalonRow()
        {
            СервисПечатныеФормыДвижения.Строка row = new СервисПечатныеФормыДвижения.Строка(this);
            row.MetaData = MetaData;
            return row;
        }

        private СервисПечатныеФормыДвижения.Строка[] convertRowsArray(NsgDataTableRow[] array)
        {
            СервисПечатныеФормыДвижения.Строка[] res = new СервисПечатныеФормыДвижения.Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск строк. Перегруженные методы.
        /// <summary>
        /// Метод поиска одной строки в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new СервисПечатныеФормыДвижения.Строка FindRowByTag(object Tag)
        {
            return base.FindRowByTag(Tag) as СервисПечатныеФормыДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению Tag
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new СервисПечатныеФормыДвижения.Строка[] FindRowsByTag(object Tag)
        {
            return convertRowsArray(base.FindRowsByTag(Tag));
        }

        /// <summary>
        /// Метод поиска одной строки в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new СервисПечатныеФормыДвижения.Строка FindRow(NsgCompare compare)
        {
            return base.FindRow(compare) as СервисПечатныеФормыДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new СервисПечатныеФормыДвижения.Строка FindRow(string inName, object inValue)
        {
            return base.FindRow(inName, inValue) as СервисПечатныеФормыДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска одной строки в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new СервисПечатныеФормыДвижения.Строка FindRow(NsgDataFixedFields inName, object inValue)
        {
            return base.FindRow(inName, inValue) as СервисПечатныеФормыДвижения.Строка;
        }

        /// <summary>
        /// Метод поиска строк в таблице, соответствующих заданным параметрам.
        /// </summary>
        /// <param name="compare">Критерии поиска.</param>
        /// <returns>Найденные строки.</returns>
        public new СервисПечатныеФормыДвижения.Строка[] FindRows(NsgCompare compare)
        {
            return convertRowsArray(base.FindRows(compare));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new СервисПечатныеФормыДвижения.Строка[] FindRows(string inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод поиска строк в таблице по значению конкретного предопределенного поля.
        /// </summary>
        /// <param name="inName">Имя колонки.</param>
        /// <param name="inValue">Значение поля.</param>
        /// <returns>Найденные строки.</returns>
        public new СервисПечатныеФормыДвижения.Строка[] FindRows(NsgDataFixedFields inName, object inValue)
        {
            return convertRowsArray(base.FindRows(inName, inValue));
        }

        /// <summary>
        /// Метод получения курсора на выборку документов.
        /// </summary>
        public  NsgVirtualCursor<СервисПечатныеФормыДвижения> GetNewVirtualCursor()
        {
            return base.GetNewVirtualCursor<СервисПечатныеФормыДвижения>();
        }

        /// <summary>
        /// Получить все строки таблицы с учетом наложенного фильтра. Для получения всех сьтрок без учета фильтра используется свойство AllRows
        /// </summary>
        public new СервисПечатныеФормыДвижения.Строка[] Rows
        {
            get
            {
                return convertRowsArray(base.Rows);
            }
        }

        /// <summary>
        /// Получить все строки таблицы без учето наложенного фильтра. Для получения всех сьтрок с учетом фильтра используется свойство Rows
        /// </summary>
        public new СервисПечатныеФормыДвижения.Строка[] AllRows
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
        public new СервисПечатныеФормыДвижения.Строка GetRow(Guid inID)
        {
            return base.GetRow(inID) as СервисПечатныеФормыДвижения.Строка;
        }
        #endregion
        



        #endregion // Методы NsgSoft.DataObjects.NsgDataTable

        #region Методы NsgMultipleObject
        private СервисПечатныеФормыДвижения[] convertArray(NsgMultipleObject[] array)
        {
            СервисПечатныеФормыДвижения[] res = new СервисПечатныеФормыДвижения[array.Length];
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
        public new virtual СервисПечатныеФормыДвижения[] FindAll(NsgCompare compare)
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
        public new virtual СервисПечатныеФормыДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual СервисПечатныеФормыДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual СервисПечатныеФормыДвижения[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new СервисПечатныеФормыДвижения(this as NsgObject);
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
                base.NSGType = typeof(СервисПечатныеФормыДвижения);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new СервисПечатныеФормыДвижения Value
            {
                get
                {
                    return (СервисПечатныеФормыДвижения)base.Value;
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
