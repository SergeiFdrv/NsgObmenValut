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
    
    [NsgTypeName("NsgDataDictionary", Guid = "c51fefc3-49f6-4f95-9102-e6cd4fe1ab8c")]
    public partial class ПравилаОбменаДанными : NsgSoft.DataObjects.NsgDataDictionary
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataDictionary
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataDictionary

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataDictionary
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataDictionary

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected ПравилаОбменаДанными()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ПравилаОбменаДанными(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ПравилаОбменаДанными Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("c51fefc3-49f6-4f95-9102-e6cd4fe1ab8c"));
            if (obj == null)
                obj = new ПравилаОбменаДанными();
            return obj as ПравилаОбменаДанными;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataDictionary
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataDictionary
			
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
	Идентификатор.Guid = NsgService.StringToGuid("a291449e-cec1-4179-be00-1fdc4b9158fb");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("b0ca9a29-22fd-4ee9-9695-59248ef3571a");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание System.Boolean ЭтоГруппа
			{  
                NsgDataBoolean ЭтоГруппа = null;
				if (ObjectList.Contains("ЭтоГруппа"))
                    ЭтоГруппа = ObjectList["ЭтоГруппа"] as NsgDataBoolean;
                else
                    ЭтоГруппа = new NsgDataBoolean();
	//NsgDataBoolean
	ЭтоГруппа.IsLoadedFromDll = true;
	ЭтоГруппа.DefaultValue = false;
	ЭтоГруппа.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЭтоГруппа.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЭтоГруппа.StringFormat = "";
	ЭтоГруппа.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ЭтоГруппа.IncludeInPredefined = false;
	ЭтоГруппа.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЭтоГруппа.Required = false;
	ЭтоГруппа.EmptyValue = "";
	ЭтоГруппа.NullAllow = false;
	ЭтоГруппа.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ЭтоГруппа.FieldName = "_IsFolder";
	ЭтоГруппа.SaveInDatabase = true;
	ЭтоГруппа.InformMetaDataOnValueChanged = false;
	ЭтоГруппа.Visible = true;
	ЭтоГруппа.Name = "ЭтоГруппа";
	ЭтоГруппа.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЭтоГруппа.Description = "Это группа";
	ЭтоГруппа.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ЭтоГруппа.GroupName = "";
	ЭтоГруппа.Guid = NsgService.StringToGuid("c5cac19a-bcea-42a5-bf1b-70f3410644df");
	
				if (!ObjectList.Contains("ЭтоГруппа"))
                    ObjectList.Add(ЭтоГруппа);
			}
			#endregion //создание System.Boolean ЭтоГруппа
			
			#region создание System.Guid ИдентификаторРодителя
			{  
                NsgDataGuid ИдентификаторРодителя = null;
				if (ObjectList.Contains("ИдентификаторРодителя"))
                    ИдентификаторРодителя = ObjectList["ИдентификаторРодителя"] as NsgDataGuid;
                else
                    ИдентификаторРодителя = new NsgDataGuid();
	//NsgDataGuid
	ИдентификаторРодителя.IsLoadedFromDll = true;
	ИдентификаторРодителя.StringFormat = "";
	ИдентификаторРодителя.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ИдентификаторРодителя.IncludeInPredefined = false;
	ИдентификаторРодителя.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИдентификаторРодителя.Required = false;
	ИдентификаторРодителя.EmptyValue = "";
	ИдентификаторРодителя.NullAllow = false;
	ИдентификаторРодителя.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ИдентификаторРодителя.FieldName = "_ParentID";
	ИдентификаторРодителя.SaveInDatabase = true;
	ИдентификаторРодителя.InformMetaDataOnValueChanged = false;
	ИдентификаторРодителя.Visible = true;
	ИдентификаторРодителя.Name = "ИдентификаторРодителя";
	ИдентификаторРодителя.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИдентификаторРодителя.Description = "Идентификатор родителя";
	ИдентификаторРодителя.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ИдентификаторРодителя.GroupName = "";
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("5d312352-850a-4b0b-bd07-dcc361967a13");
	
				if (!ObjectList.Contains("ИдентификаторРодителя"))
                    ObjectList.Add(ИдентификаторРодителя);
			}
			#endregion //создание System.Guid ИдентификаторРодителя
			
			#region создание System.Byte Уровень
			{  
                NsgDataByte Уровень = null;
				if (ObjectList.Contains("Уровень"))
                    Уровень = ObjectList["Уровень"] as NsgDataByte;
                else
                    Уровень = new NsgDataByte();
	//NsgDataByte
	Уровень.IsLoadedFromDll = true;
	Уровень.DefaultValue = 0M;
	Уровень.MinValue = 0M;
	Уровень.MaxValue = 0M;
	Уровень.UseCalculator = true;
	Уровень.StringFormat = "";
	Уровень.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Уровень.IncludeInPredefined = false;
	Уровень.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Уровень.Required = false;
	Уровень.EmptyValue = "";
	Уровень.NullAllow = false;
	Уровень.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Уровень.FieldName = "_Level";
	Уровень.SaveInDatabase = true;
	Уровень.InformMetaDataOnValueChanged = false;
	Уровень.Visible = true;
	Уровень.Name = "Уровень";
	Уровень.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Уровень.Description = "Уровень";
	Уровень.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Уровень.GroupName = "";
	Уровень.Guid = NsgService.StringToGuid("79b34775-e14e-49ab-8faa-042eb80fc15a");
	
				if (!ObjectList.Contains("Уровень"))
                    ObjectList.Add(Уровень);
			}
			#endregion //создание System.Byte Уровень
			
			#region создание System.String ПрефиксКода
			{  
                NsgDataString ПрефиксКода = null;
				if (ObjectList.Contains("ПрефиксКода"))
                    ПрефиксКода = ObjectList["ПрефиксКода"] as NsgDataString;
                else
                    ПрефиксКода = new NsgDataString();
	//NsgDataString
	ПрефиксКода.IsLoadedFromDll = true;
	ПрефиксКода.Length = 10;
	ПрефиксКода.StringFormat = "";
	ПрефиксКода.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПрефиксКода.IncludeInPredefined = false;
	ПрефиксКода.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПрефиксКода.Required = false;
	ПрефиксКода.EmptyValue = "";
	ПрефиксКода.NullAllow = false;
	ПрефиксКода.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ПрефиксКода.FieldName = "_CodePrefix";
	ПрефиксКода.SaveInDatabase = true;
	ПрефиксКода.InformMetaDataOnValueChanged = false;
	ПрефиксКода.Visible = true;
	ПрефиксКода.Name = "ПрефиксКода";
	ПрефиксКода.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПрефиксКода.Description = "Префикс кода";
	ПрефиксКода.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ПрефиксКода.GroupName = "";
	ПрефиксКода.Guid = NsgService.StringToGuid("93d33219-bb77-4c10-b921-690c4489b5fe");
	
				if (!ObjectList.Contains("ПрефиксКода"))
                    ObjectList.Add(ПрефиксКода);
			}
			#endregion //создание System.String ПрефиксКода
			
			#region создание System.Int64 НомерКода
			{  
                NsgDataInteger НомерКода = null;
				if (ObjectList.Contains("НомерКода"))
                    НомерКода = ObjectList["НомерКода"] as NsgDataInteger;
                else
                    НомерКода = new NsgDataInteger();
	//NsgDataInteger
	НомерКода.IsLoadedFromDll = true;
	НомерКода.DefaultValue = 0M;
	НомерКода.MinValue = 0M;
	НомерКода.MaxValue = 0M;
	НомерКода.UseCalculator = true;
	НомерКода.StringFormat = "";
	НомерКода.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НомерКода.IncludeInPredefined = false;
	НомерКода.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерКода.Required = false;
	НомерКода.EmptyValue = "";
	НомерКода.NullAllow = false;
	НомерКода.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	НомерКода.FieldName = "_CodeNumber";
	НомерКода.SaveInDatabase = true;
	НомерКода.InformMetaDataOnValueChanged = false;
	НомерКода.Visible = true;
	НомерКода.Name = "НомерКода";
	НомерКода.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НомерКода.Description = "Номер кода";
	НомерКода.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	НомерКода.GroupName = "";
	НомерКода.Guid = NsgService.StringToGuid("565f3634-4714-41de-9192-224c6b9531b0");
	
				if (!ObjectList.Contains("НомерКода"))
                    ObjectList.Add(НомерКода);
			}
			#endregion //создание System.Int64 НомерКода
			
			#region создание System.String Код
			{  
                NsgDataVirtualObject Код = null;
				if (ObjectList.Contains("Код"))
                    Код = ObjectList["Код"] as NsgDataVirtualObject;
                else
                    Код = new NsgDataVirtualObject();
	//NsgDataVirtualObject
	Код.IsLoadedFromDll = true;
	Код.ArrayField = new System.String[]{"ПрефиксКода", "НомерКода"};
	Код.SaveInDatabase = false;
	Код.StringFormat = "";
	Код.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Код.IncludeInPredefined = false;
	Код.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Код.Required = false;
	Код.EmptyValue = "";
	Код.NullAllow = false;
	Код.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Код.FieldName = "_Code";
	Код.InformMetaDataOnValueChanged = false;
	Код.Visible = true;
	Код.Name = "Код";
	Код.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Код.Description = "Код элемента справочника";
	Код.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Код.GroupName = "";
	Код.Guid = NsgService.StringToGuid("5ff988cd-4469-465e-97c9-de5bdc6ed29c");
	
				if (!ObjectList.Contains("Код"))
                    ObjectList.Add(Код);
			}
			#endregion //создание System.String Код
			
			#region создание Сервис.СостоянияОбъекта СостояниеДокумента
			{  
                NsgDataEnumReference СостояниеДокумента = null;
				if (ObjectList.Contains("СостояниеДокумента"))
                    СостояниеДокумента = ObjectList["СостояниеДокумента"] as NsgDataEnumReference;
                else
                    СостояниеДокумента = new NsgDataEnumReference();
	//NsgDataEnumReference
	СостояниеДокумента.IsLoadedFromDll = true;
	СостояниеДокумента.ReferentGroup = "Сервис";
	СостояниеДокумента.ReferentName = "СостоянияОбъекта";
	СостояниеДокумента.SaveInDatabase = true;
	СостояниеДокумента.OwnerName = "";
	СостояниеДокумента.AllowEmptyOwner = false;
	СостояниеДокумента.StringFormat = "";
	СостояниеДокумента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	СостояниеДокумента.IncludeInPredefined = false;
	СостояниеДокумента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СостояниеДокумента.Required = false;
	СостояниеДокумента.EmptyValue = "";
	СостояниеДокумента.NullAllow = false;
	СостояниеДокумента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СостояниеДокумента.FieldName = "_State";
	СостояниеДокумента.InformMetaDataOnValueChanged = false;
	СостояниеДокумента.Visible = true;
	СостояниеДокумента.Name = "СостояниеДокумента";
	СостояниеДокумента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СостояниеДокумента.Description = "Состояние документа";
	СостояниеДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	СостояниеДокумента.GroupName = "";
	СостояниеДокумента.Guid = NsgService.StringToGuid("fbea5a5d-ae3d-4463-8d6c-6a26faea6cf6");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание NsgSoft.DataObjects.NsgMultipleObject ТипОбъектаОбмена
			{  
                NsgObjectSelector ТипОбъектаОбмена = null;
				if (ObjectList.Contains("ТипОбъектаОбмена"))
                    ТипОбъектаОбмена = ObjectList["ТипОбъектаОбмена"] as NsgObjectSelector;
                else
                    ТипОбъектаОбмена = new NsgObjectSelector();
	//NsgObjectSelector
	ТипОбъектаОбмена.IsLoadedFromDll = true;
	ТипОбъектаОбмена.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.Type;
	ТипОбъектаОбмена.FilterForConfigurator = "NsgDataDocument,NsgDataDictionary";
	ТипОбъектаОбмена.StringFormat = "";
	ТипОбъектаОбмена.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ТипОбъектаОбмена.IncludeInPredefined = false;
	ТипОбъектаОбмена.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТипОбъектаОбмена.Required = false;
	ТипОбъектаОбмена.EmptyValue = "";
	ТипОбъектаОбмена.NullAllow = false;
	ТипОбъектаОбмена.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТипОбъектаОбмена.FieldName = "_ExchangeObjectType";
	ТипОбъектаОбмена.SaveInDatabase = true;
	ТипОбъектаОбмена.InformMetaDataOnValueChanged = false;
	ТипОбъектаОбмена.Visible = true;
	ТипОбъектаОбмена.Name = "ТипОбъектаОбмена";
	ТипОбъектаОбмена.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Тип объекта обмена"});
	ТипОбъектаОбмена.Description = "Тип объекта обмена";
	ТипОбъектаОбмена.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ТипОбъектаОбмена.GroupName = "";
	ТипОбъектаОбмена.Guid = NsgService.StringToGuid("ae53c344-6fe7-4ef9-bde7-6089036f8153");
	
				if (!ObjectList.Contains("ТипОбъектаОбмена"))
                    ObjectList.Add(ТипОбъектаОбмена);
			}
			#endregion //создание NsgSoft.DataObjects.NsgMultipleObject ТипОбъектаОбмена
			
			#region создание System.Boolean ВыгрузкаЗависимыхОбъектов
			{  
                NsgDataBoolean ВыгрузкаЗависимыхОбъектов = null;
				if (ObjectList.Contains("ВыгрузкаЗависимыхОбъектов"))
                    ВыгрузкаЗависимыхОбъектов = ObjectList["ВыгрузкаЗависимыхОбъектов"] as NsgDataBoolean;
                else
                    ВыгрузкаЗависимыхОбъектов = new NsgDataBoolean();
	//NsgDataBoolean
	ВыгрузкаЗависимыхОбъектов.IsLoadedFromDll = true;
	ВыгрузкаЗависимыхОбъектов.DefaultValue = true;
	ВыгрузкаЗависимыхОбъектов.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВыгрузкаЗависимыхОбъектов.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВыгрузкаЗависимыхОбъектов.StringFormat = "";
	ВыгрузкаЗависимыхОбъектов.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ВыгрузкаЗависимыхОбъектов.IncludeInPredefined = false;
	ВыгрузкаЗависимыхОбъектов.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВыгрузкаЗависимыхОбъектов.Required = false;
	ВыгрузкаЗависимыхОбъектов.EmptyValue = "";
	ВыгрузкаЗависимыхОбъектов.NullAllow = false;
	ВыгрузкаЗависимыхОбъектов.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВыгрузкаЗависимыхОбъектов.FieldName = "_ExportBindedObjects";
	ВыгрузкаЗависимыхОбъектов.SaveInDatabase = true;
	ВыгрузкаЗависимыхОбъектов.InformMetaDataOnValueChanged = false;
	ВыгрузкаЗависимыхОбъектов.Visible = true;
	ВыгрузкаЗависимыхОбъектов.Name = "ВыгрузкаЗависимыхОбъектов";
	ВыгрузкаЗависимыхОбъектов.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Выгрузка зависимых объектов"});
	ВыгрузкаЗависимыхОбъектов.Description = "Выгрузка зависимых объектов";
	ВыгрузкаЗависимыхОбъектов.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ВыгрузкаЗависимыхОбъектов.GroupName = "";
	ВыгрузкаЗависимыхОбъектов.Guid = NsgService.StringToGuid("33e44dd3-e1f2-4223-b405-d916bb640975");
	
				if (!ObjectList.Contains("ВыгрузкаЗависимыхОбъектов"))
                    ObjectList.Add(ВыгрузкаЗависимыхОбъектов);
			}
			#endregion //создание System.Boolean ВыгрузкаЗависимыхОбъектов
			
			#region создание Сервис.БазыДанныхДляОбмена БазаИсточник
			{  
                NsgDataTypedReference БазаИсточник = null;
				if (ObjectList.Contains("БазаИсточник"))
                    БазаИсточник = ObjectList["БазаИсточник"] as NsgDataTypedReference;
                else
                    БазаИсточник = new NsgDataTypedReference();
	//NsgDataTypedReference
	БазаИсточник.IsLoadedFromDll = true;
	БазаИсточник.ReferentGroup = "Сервис";
	БазаИсточник.ReferentName = "БазыДанныхДляОбмена";
	БазаИсточник.SaveInDatabase = true;
	БазаИсточник.OwnerName = "";
	БазаИсточник.AllowEmptyOwner = false;
	БазаИсточник.StringFormat = "";
	БазаИсточник.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	БазаИсточник.IncludeInPredefined = false;
	БазаИсточник.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	БазаИсточник.Required = false;
	БазаИсточник.EmptyValue = "";
	БазаИсточник.NullAllow = false;
	БазаИсточник.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	БазаИсточник.FieldName = "_SourceDB";
	БазаИсточник.InformMetaDataOnValueChanged = false;
	БазаИсточник.Visible = true;
	БазаИсточник.Name = "БазаИсточник";
	БазаИсточник.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"База источник"});
	БазаИсточник.Description = "База источник";
	БазаИсточник.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	БазаИсточник.GroupName = "";
	БазаИсточник.Guid = NsgService.StringToGuid("17decb19-124e-4442-9a0e-8cdc2b242291");
	
				if (!ObjectList.Contains("БазаИсточник"))
                    ObjectList.Add(БазаИсточник);
			}
			#endregion //создание Сервис.БазыДанныхДляОбмена БазаИсточник
			
			#region создание Сервис.БазыДанныхДляОбмена БазаПолучатель
			{  
                NsgDataTypedReference БазаПолучатель = null;
				if (ObjectList.Contains("БазаПолучатель"))
                    БазаПолучатель = ObjectList["БазаПолучатель"] as NsgDataTypedReference;
                else
                    БазаПолучатель = new NsgDataTypedReference();
	//NsgDataTypedReference
	БазаПолучатель.IsLoadedFromDll = true;
	БазаПолучатель.ReferentGroup = "Сервис";
	БазаПолучатель.ReferentName = "БазыДанныхДляОбмена";
	БазаПолучатель.SaveInDatabase = true;
	БазаПолучатель.OwnerName = "";
	БазаПолучатель.AllowEmptyOwner = false;
	БазаПолучатель.StringFormat = "";
	БазаПолучатель.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	БазаПолучатель.IncludeInPredefined = false;
	БазаПолучатель.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	БазаПолучатель.Required = false;
	БазаПолучатель.EmptyValue = "";
	БазаПолучатель.NullAllow = false;
	БазаПолучатель.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	БазаПолучатель.FieldName = "_ReceiverDB";
	БазаПолучатель.InformMetaDataOnValueChanged = false;
	БазаПолучатель.Visible = true;
	БазаПолучатель.Name = "БазаПолучатель";
	БазаПолучатель.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"База получатель"});
	БазаПолучатель.Description = "База получатель";
	БазаПолучатель.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	БазаПолучатель.GroupName = "";
	БазаПолучатель.Guid = NsgService.StringToGuid("e71b098b-5c01-457b-bd08-56d38d116d8f");
	
				if (!ObjectList.Contains("БазаПолучатель"))
                    ObjectList.Add(БазаПолучатель);
			}
			#endregion //создание Сервис.БазыДанныхДляОбмена БазаПолучатель
			
			#region создание System.Boolean ПроводитьВсеДокументы
			{  
                NsgDataBoolean ПроводитьВсеДокументы = null;
				if (ObjectList.Contains("ПроводитьВсеДокументы"))
                    ПроводитьВсеДокументы = ObjectList["ПроводитьВсеДокументы"] as NsgDataBoolean;
                else
                    ПроводитьВсеДокументы = new NsgDataBoolean();
	//NsgDataBoolean
	ПроводитьВсеДокументы.IsLoadedFromDll = true;
	ПроводитьВсеДокументы.DefaultValue = false;
	ПроводитьВсеДокументы.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПроводитьВсеДокументы.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ПроводитьВсеДокументы.StringFormat = "";
	ПроводитьВсеДокументы.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ПроводитьВсеДокументы.IncludeInPredefined = false;
	ПроводитьВсеДокументы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПроводитьВсеДокументы.Required = false;
	ПроводитьВсеДокументы.EmptyValue = "";
	ПроводитьВсеДокументы.NullAllow = false;
	ПроводитьВсеДокументы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПроводитьВсеДокументы.FieldName = "_HandleAllDocuments";
	ПроводитьВсеДокументы.SaveInDatabase = true;
	ПроводитьВсеДокументы.InformMetaDataOnValueChanged = false;
	ПроводитьВсеДокументы.Visible = true;
	ПроводитьВсеДокументы.Name = "ПроводитьВсеДокументы";
	ПроводитьВсеДокументы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Проводить все документы"});
	ПроводитьВсеДокументы.Description = "Проводить все документы";
	ПроводитьВсеДокументы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ПроводитьВсеДокументы.GroupName = "";
	ПроводитьВсеДокументы.Guid = NsgService.StringToGuid("8525b12c-7fa9-434b-be2d-33c09dceaa68");
	
				if (!ObjectList.Contains("ПроводитьВсеДокументы"))
                    ObjectList.Add(ПроводитьВсеДокументы);
			}
			#endregion //создание System.Boolean ПроводитьВсеДокументы
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Код";
	PeriodicTable = "";
	MaxGroupLevel = 0;
	HasOwner = false;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ПравилаОбменаДанными";
	Visible = true;
	Guid = NsgService.StringToGuid("c51fefc3-49f6-4f95-9102-e6cd4fe1ab8c");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = true;
	TableName = "ExchangeDBDataRules";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Правила обмена данными"});
	Description = "Настройки канала обмена";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	GroupName = "Сервис";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataDictionary
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataDictionary

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
        public new partial class Names// :NsgSoft.DataObjects.NsgDataDictionary.Names
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
            /// Это группа
            /// </summary>
            public static String ЭтоГруппа
            {
                get
                {
                    return "ЭтоГруппа";
                }
            }
            
            /// <summary>
            /// Идентификатор родителя
            /// </summary>
            public static String ИдентификаторРодителя
            {
                get
                {
                    return "ИдентификаторРодителя";
                }
            }
            
            /// <summary>
            /// Уровень
            /// </summary>
            public static String Уровень
            {
                get
                {
                    return "Уровень";
                }
            }
            
            /// <summary>
            /// Префикс кода
            /// </summary>
            public static String ПрефиксКода
            {
                get
                {
                    return "ПрефиксКода";
                }
            }
            
            /// <summary>
            /// Номер кода
            /// </summary>
            public static String НомерКода
            {
                get
                {
                    return "НомерКода";
                }
            }
            
            /// <summary>
            /// Код элемента справочника
            /// </summary>
            public static String Код
            {
                get
                {
                    return "Код";
                }
            }
            
            /// <summary>
            /// Состояние документа
            /// </summary>
            public static String СостояниеДокумента
            {
                get
                {
                    return "СостояниеДокумента";
                }
            }
            
            /// <summary>
            /// Тип объекта обмена
            /// </summary>
            public static String ТипОбъектаОбмена
            {
                get
                {
                    return "ТипОбъектаОбмена";
                }
            }
            
            /// <summary>
            /// Выгрузка зависимых объектов
            /// </summary>
            public static String ВыгрузкаЗависимыхОбъектов
            {
                get
                {
                    return "ВыгрузкаЗависимыхОбъектов";
                }
            }
            
            /// <summary>
            /// База источник
            /// </summary>
            public static String БазаИсточник
            {
                get
                {
                    return "БазаИсточник";
                }
            }
            
            /// <summary>
            /// База получатель
            /// </summary>
            public static String БазаПолучатель
            {
                get
                {
                    return "БазаПолучатель";
                }
            }
            
            /// <summary>
            /// Проводить все документы
            /// </summary>
            public static String ПроводитьВсеДокументы
            {
                get
                {
                    return "ПроводитьВсеДокументы";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public static string GetFullName()
        {
            return "Сервис.ПравилаОбменаДанными";
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
        /// Это группа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ЭтоГруппа
        {
            get
            {
				 NsgDataBoolean __ЭтоГруппа = ObjectList["ЭтоГруппа"] as NsgDataBoolean;
                 return (System.Boolean)__ЭтоГруппа.Value;
            }
            set
            {
                NsgDataBoolean __ЭтоГруппа = ObjectList["ЭтоГруппа"] as NsgDataBoolean;
                __ЭтоГруппа.Value = value;
            }
        }
        
        /// <summary>
        /// Идентификатор родителя
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataGuid")]
        
        public System.Guid ИдентификаторРодителя
        {
            get
            {
				 NsgDataGuid __ИдентификаторРодителя = ObjectList["ИдентификаторРодителя"] as NsgDataGuid;
                 return (System.Guid)__ИдентификаторРодителя.Value;
            }
            set
            {
                NsgDataGuid __ИдентификаторРодителя = ObjectList["ИдентификаторРодителя"] as NsgDataGuid;
                __ИдентификаторРодителя.Value = value;
            }
        }
        
        /// <summary>
        /// Уровень
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataByte")]
        
        public System.Byte Уровень
        {
            get
            {
				 NsgDataByte __Уровень = ObjectList["Уровень"] as NsgDataByte;
                 return (System.Byte)__Уровень.Value;
            }
            set
            {
                NsgDataByte __Уровень = ObjectList["Уровень"] as NsgDataByte;
                __Уровень.Value = value;
            }
        }
        
        /// <summary>
        /// Префикс кода
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ПрефиксКода
        {
            get
            {
				 NsgDataString __ПрефиксКода = ObjectList["ПрефиксКода"] as NsgDataString;
                 return (System.String)__ПрефиксКода.Value;
            }
            set
            {
                NsgDataString __ПрефиксКода = ObjectList["ПрефиксКода"] as NsgDataString;
                __ПрефиксКода.Value = value;
            }
        }
        
        /// <summary>
        /// Номер кода
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 НомерКода
        {
            get
            {
				 NsgDataInteger __НомерКода = ObjectList["НомерКода"] as NsgDataInteger;
                 return (System.Int64)__НомерКода.Value;
            }
            set
            {
                NsgDataInteger __НомерКода = ObjectList["НомерКода"] as NsgDataInteger;
                __НомерКода.Value = value;
            }
        }
        
        /// <summary>
        /// Код элемента справочника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataVirtualObject")]
        
        public System.String Код
        {
            get
            {
				 NsgDataVirtualObject __Код = ObjectList["Код"] as NsgDataVirtualObject;
                 return (System.String)__Код.Value;
            }
            set
            {
                NsgDataVirtualObject __Код = ObjectList["Код"] as NsgDataVirtualObject;
                __Код.Value = value;
            }
        }
        
        /// <summary>
        /// Состояние документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.СостоянияОбъекта СостояниеДокумента
        {
            get
            {
				 NsgDataEnumReference __СостояниеДокумента = ObjectList["СостояниеДокумента"] as NsgDataEnumReference;
                 return (Сервис.СостоянияОбъекта)__СостояниеДокумента.Referent;
            }
            set
            {
                NsgDataEnumReference __СостояниеДокумента = ObjectList["СостояниеДокумента"] as NsgDataEnumReference;
                __СостояниеДокумента.Referent = value;
            }
        }
        
        /// <summary>
        /// Тип объекта обмена
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgObjectSelector")]
        
        public NsgSoft.DataObjects.NsgMultipleObject ТипОбъектаОбмена
        {
            get
            {
				 NsgObjectSelector __ТипОбъектаОбмена = ObjectList["ТипОбъектаОбмена"] as NsgObjectSelector;
                 return (NsgSoft.DataObjects.NsgMultipleObject)__ТипОбъектаОбмена.Object;
            }
            set
            {
                NsgObjectSelector __ТипОбъектаОбмена = ObjectList["ТипОбъектаОбмена"] as NsgObjectSelector;
                __ТипОбъектаОбмена.Object = value;
            }
        }
        
        /// <summary>
        /// Выгрузка зависимых объектов
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ВыгрузкаЗависимыхОбъектов
        {
            get
            {
				 NsgDataBoolean __ВыгрузкаЗависимыхОбъектов = ObjectList["ВыгрузкаЗависимыхОбъектов"] as NsgDataBoolean;
                 return (System.Boolean)__ВыгрузкаЗависимыхОбъектов.Value;
            }
            set
            {
                NsgDataBoolean __ВыгрузкаЗависимыхОбъектов = ObjectList["ВыгрузкаЗависимыхОбъектов"] as NsgDataBoolean;
                __ВыгрузкаЗависимыхОбъектов.Value = value;
            }
        }
        
        /// <summary>
        /// База источник
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Сервис.БазыДанныхДляОбмена БазаИсточник
        {
            get
            {
				 NsgDataTypedReference __БазаИсточник = ObjectList["БазаИсточник"] as NsgDataTypedReference;
                 return (Сервис.БазыДанныхДляОбмена)__БазаИсточник.Referent;
            }
            set
            {
                NsgDataTypedReference __БазаИсточник = ObjectList["БазаИсточник"] as NsgDataTypedReference;
                __БазаИсточник.Referent = value;
            }
        }
        
        /// <summary>
        /// База получатель
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Сервис.БазыДанныхДляОбмена БазаПолучатель
        {
            get
            {
				 NsgDataTypedReference __БазаПолучатель = ObjectList["БазаПолучатель"] as NsgDataTypedReference;
                 return (Сервис.БазыДанныхДляОбмена)__БазаПолучатель.Referent;
            }
            set
            {
                NsgDataTypedReference __БазаПолучатель = ObjectList["БазаПолучатель"] as NsgDataTypedReference;
                __БазаПолучатель.Referent = value;
            }
        }
        
        /// <summary>
        /// Проводить все документы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ПроводитьВсеДокументы
        {
            get
            {
				 NsgDataBoolean __ПроводитьВсеДокументы = ObjectList["ПроводитьВсеДокументы"] as NsgDataBoolean;
                 return (System.Boolean)__ПроводитьВсеДокументы.Value;
            }
            set
            {
                NsgDataBoolean __ПроводитьВсеДокументы = ObjectList["ПроводитьВсеДокументы"] as NsgDataBoolean;
                __ПроводитьВсеДокументы.Value = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataDictionary
        

        /// <summary>
		/// Родитель для данного элемента справочника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        public ПравилаОбменаДанными Родитель
        {
            get
            {
                return base.Parent as ПравилаОбменаДанными;
            }
            set
            {
                base.Parent = value;
            }
        }
        #region #Comment_Predefined#
        
        #endregion //#Comment_Predefined#
		



        #endregion // Свойства NsgSoft.DataObjects.NsgDataDictionary

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataDictionary
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataDictionary

        #region Методы NsgMultipleObject
        private ПравилаОбменаДанными[] convertArray(NsgMultipleObject[] array)
        {
            ПравилаОбменаДанными[] res = new ПравилаОбменаДанными[array.Length];
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
        public new virtual ПравилаОбменаДанными[] FindAll(NsgCompare compare)
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
        public new virtual ПравилаОбменаДанными[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ПравилаОбменаДанными[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ПравилаОбменаДанными[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ПравилаОбменаДанными(this as NsgObject);
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
                base.NSGType = typeof(ПравилаОбменаДанными);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ПравилаОбменаДанными Value
            {
                get
                {
                    return (ПравилаОбменаДанными)base.Value;
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
                    return "s_NsgDataDictionary";
                }
            }
        }
    }

}
