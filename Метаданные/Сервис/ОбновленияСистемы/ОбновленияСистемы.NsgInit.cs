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
    
    [NsgTypeName("NsgDataDictionary", Guid = "5149360b-7895-4c40-a8d9-905b0e142f5c")]
    public partial class ОбновленияСистемы : NsgSoft.DataObjects.NsgDataDictionary
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
        protected ОбновленияСистемы()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ОбновленияСистемы(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ОбновленияСистемы Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("5149360b-7895-4c40-a8d9-905b0e142f5c"));
            if (obj == null)
                obj = new ОбновленияСистемы();
            return obj as ОбновленияСистемы;
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
	Идентификатор.Guid = NsgService.StringToGuid("eb2d45d1-0e8c-490e-b169-79774f495aa4");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("4cba4c55-d6b8-4974-99b7-3d31c6cea9af");
	
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
	ЭтоГруппа.Guid = NsgService.StringToGuid("ab31d431-43b9-47b1-b343-04467811d59c");
	
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
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("71d6862a-2c41-44b3-bac8-40e86d217d2c");
	
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
	Уровень.Guid = NsgService.StringToGuid("7927e9f9-e0e7-40ad-98bc-1dc63ae059ff");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("51231754-a3b4-4b0f-b640-26f92b47bf12");
	
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
	НомерКода.Guid = NsgService.StringToGuid("b7282e29-f27b-4750-b3b2-ff9dae2982b5");
	
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
	Код.Guid = NsgService.StringToGuid("af93f273-31a4-47ed-a4bd-807229e579dc");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("96521422-cc31-454a-b50a-931c72680d09");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
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
	Наименование.IncludeInPredefined = true;
	Наименование.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Наименование.Required = false;
	Наименование.EmptyValue = "";
	Наименование.NullAllow = false;
	Наименование.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Наименование.FieldName = "Naimenovanie";
	Наименование.SaveInDatabase = true;
	Наименование.InformMetaDataOnValueChanged = false;
	Наименование.Visible = true;
	Наименование.Name = "Наименование";
	Наименование.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Наименование"});
	Наименование.Description = "Наименование";
	Наименование.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Наименование.GroupName = "";
	Наименование.Guid = NsgService.StringToGuid("f5c40ac7-582e-4d0c-aef3-9d0701abdcfa");
	
				if (!ObjectList.Contains("Наименование"))
                    ObjectList.Add(Наименование);
			}
			#endregion //создание System.String Наименование
			
			#region создание Сервис.Пользователи Пользователь
			{  
                NsgDataTypedReference Пользователь = null;
				if (ObjectList.Contains("Пользователь"))
                    Пользователь = ObjectList["Пользователь"] as NsgDataTypedReference;
                else
                    Пользователь = new NsgDataTypedReference();
	//NsgDataTypedReference
	Пользователь.IsLoadedFromDll = true;
	Пользователь.ReferentGroup = "Сервис";
	Пользователь.ReferentName = "Пользователи";
	Пользователь.SaveInDatabase = true;
	Пользователь.OwnerName = "";
	Пользователь.AllowEmptyOwner = false;
	Пользователь.StringFormat = "";
	Пользователь.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Пользователь.IncludeInPredefined = false;
	Пользователь.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Пользователь.Required = false;
	Пользователь.EmptyValue = "";
	Пользователь.NullAllow = false;
	Пользователь.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Пользователь.FieldName = "Polzovatel";
	Пользователь.InformMetaDataOnValueChanged = false;
	Пользователь.Visible = true;
	Пользователь.Name = "Пользователь";
	Пользователь.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Пользователь"});
	Пользователь.Description = "Пользователь";
	Пользователь.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Пользователь.GroupName = "";
	Пользователь.Guid = NsgService.StringToGuid("272abde1-abd4-44da-9e5d-8608ba86aa8a");
	
				if (!ObjectList.Contains("Пользователь"))
                    ObjectList.Add(Пользователь);
			}
			#endregion //создание Сервис.Пользователи Пользователь
			
			#region создание System.Boolean ОбновлятьИзБД
			{  
                NsgDataBoolean ОбновлятьИзБД = null;
				if (ObjectList.Contains("ОбновлятьИзБД"))
                    ОбновлятьИзБД = ObjectList["ОбновлятьИзБД"] as NsgDataBoolean;
                else
                    ОбновлятьИзБД = new NsgDataBoolean();
	//NsgDataBoolean
	ОбновлятьИзБД.IsLoadedFromDll = true;
	ОбновлятьИзБД.DefaultValue = false;
	ОбновлятьИзБД.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбновлятьИзБД.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОбновлятьИзБД.StringFormat = "";
	ОбновлятьИзБД.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ОбновлятьИзБД.IncludeInPredefined = true;
	ОбновлятьИзБД.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбновлятьИзБД.Required = false;
	ОбновлятьИзБД.EmptyValue = "";
	ОбновлятьИзБД.NullAllow = false;
	ОбновлятьИзБД.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбновлятьИзБД.FieldName = "_FromDB";
	ОбновлятьИзБД.SaveInDatabase = true;
	ОбновлятьИзБД.InformMetaDataOnValueChanged = false;
	ОбновлятьИзБД.Visible = true;
	ОбновлятьИзБД.Name = "ОбновлятьИзБД";
	ОбновлятьИзБД.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Обновлять из БД"});
	ОбновлятьИзБД.Description = "Обновлять из БД";
	ОбновлятьИзБД.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ОбновлятьИзБД.GroupName = "";
	ОбновлятьИзБД.Guid = NsgService.StringToGuid("45e72538-2c08-4f63-905e-0ac0b8f44856");
	
				if (!ObjectList.Contains("ОбновлятьИзБД"))
                    ObjectList.Add(ОбновлятьИзБД);
			}
			#endregion //создание System.Boolean ОбновлятьИзБД
			
			#region создание System.Int64 ПриоритетОбновления
			{  
                NsgDataInteger ПриоритетОбновления = null;
				if (ObjectList.Contains("ПриоритетОбновления"))
                    ПриоритетОбновления = ObjectList["ПриоритетОбновления"] as NsgDataInteger;
                else
                    ПриоритетОбновления = new NsgDataInteger();
	//NsgDataInteger
	ПриоритетОбновления.IsLoadedFromDll = true;
	ПриоритетОбновления.DefaultValue = 0M;
	ПриоритетОбновления.MinValue = 0M;
	ПриоритетОбновления.MaxValue = 0M;
	ПриоритетОбновления.UseCalculator = true;
	ПриоритетОбновления.StringFormat = "";
	ПриоритетОбновления.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПриоритетОбновления.IncludeInPredefined = true;
	ПриоритетОбновления.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПриоритетОбновления.Required = false;
	ПриоритетОбновления.EmptyValue = "";
	ПриоритетОбновления.NullAllow = false;
	ПриоритетОбновления.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПриоритетОбновления.FieldName = "_Priority";
	ПриоритетОбновления.SaveInDatabase = true;
	ПриоритетОбновления.InformMetaDataOnValueChanged = false;
	ПриоритетОбновления.Visible = true;
	ПриоритетОбновления.Name = "ПриоритетОбновления";
	ПриоритетОбновления.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Приоритет обновления"});
	ПриоритетОбновления.Description = "Приоритет обновления";
	ПриоритетОбновления.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ПриоритетОбновления.GroupName = "";
	ПриоритетОбновления.Guid = NsgService.StringToGuid("a24146ef-8ac9-4b4d-a8ce-9e6d72a5c4ca");
	
				if (!ObjectList.Contains("ПриоритетОбновления"))
                    ObjectList.Add(ПриоритетОбновления);
			}
			#endregion //создание System.Int64 ПриоритетОбновления
			
			#region создание System.String ПутьДляОбновления
			{  
                NsgDataString ПутьДляОбновления = null;
				if (ObjectList.Contains("ПутьДляОбновления"))
                    ПутьДляОбновления = ObjectList["ПутьДляОбновления"] as NsgDataString;
                else
                    ПутьДляОбновления = new NsgDataString();
	//NsgDataString
	ПутьДляОбновления.IsLoadedFromDll = true;
	ПутьДляОбновления.Length = 50;
	ПутьДляОбновления.StringFormat = "";
	ПутьДляОбновления.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПутьДляОбновления.IncludeInPredefined = true;
	ПутьДляОбновления.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПутьДляОбновления.Required = false;
	ПутьДляОбновления.EmptyValue = "";
	ПутьДляОбновления.NullAllow = false;
	ПутьДляОбновления.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПутьДляОбновления.FieldName = "PutDljaObnovlenija";
	ПутьДляОбновления.SaveInDatabase = true;
	ПутьДляОбновления.InformMetaDataOnValueChanged = false;
	ПутьДляОбновления.Visible = true;
	ПутьДляОбновления.Name = "ПутьДляОбновления";
	ПутьДляОбновления.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Путь для обновления"});
	ПутьДляОбновления.Description = "Путь для обновления";
	ПутьДляОбновления.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ПутьДляОбновления.GroupName = "";
	ПутьДляОбновления.Guid = NsgService.StringToGuid("d9c242b4-c94e-4fbb-8d00-fe8b2a4b7aa5");
	
				if (!ObjectList.Contains("ПутьДляОбновления"))
                    ObjectList.Add(ПутьДляОбновления);
			}
			#endregion //создание System.String ПутьДляОбновления
			
			#region создание System.String Логин
			{  
                NsgDataString Логин = null;
				if (ObjectList.Contains("Логин"))
                    Логин = ObjectList["Логин"] as NsgDataString;
                else
                    Логин = new NsgDataString();
	//NsgDataString
	Логин.IsLoadedFromDll = true;
	Логин.Length = 50;
	Логин.StringFormat = "";
	Логин.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Логин.IncludeInPredefined = true;
	Логин.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Логин.Required = false;
	Логин.EmptyValue = "";
	Логин.NullAllow = false;
	Логин.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Логин.FieldName = "_Login";
	Логин.SaveInDatabase = true;
	Логин.InformMetaDataOnValueChanged = false;
	Логин.Visible = true;
	Логин.Name = "Логин";
	Логин.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Логин"});
	Логин.Description = "Логин";
	Логин.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Логин.GroupName = "";
	Логин.Guid = NsgService.StringToGuid("55ad4cd7-324e-4a58-a919-d2f428912bde");
	
				if (!ObjectList.Contains("Логин"))
                    ObjectList.Add(Логин);
			}
			#endregion //создание System.String Логин
			
			#region создание System.String Пароль
			{  
                NsgDataString Пароль = null;
				if (ObjectList.Contains("Пароль"))
                    Пароль = ObjectList["Пароль"] as NsgDataString;
                else
                    Пароль = new NsgDataString();
	//NsgDataString
	Пароль.IsLoadedFromDll = true;
	Пароль.Length = 50;
	Пароль.StringFormat = "";
	Пароль.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Пароль.IncludeInPredefined = false;
	Пароль.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Пароль.Required = false;
	Пароль.EmptyValue = "";
	Пароль.NullAllow = false;
	Пароль.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Пароль.FieldName = "_Password";
	Пароль.SaveInDatabase = true;
	Пароль.InformMetaDataOnValueChanged = false;
	Пароль.Visible = true;
	Пароль.Name = "Пароль";
	Пароль.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Пароль"});
	Пароль.Description = "Пароль";
	Пароль.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Пароль.GroupName = "";
	Пароль.Guid = NsgService.StringToGuid("62df83af-9e55-4f57-a163-14da0d44d82e");
	
				if (!ObjectList.Contains("Пароль"))
                    ObjectList.Add(Пароль);
			}
			#endregion //создание System.String Пароль
			
			#region создание Сервис.ОбновленияСистемы ДляВсехПользователей
			{  
                NsgDataPredefinedReference ДляВсехПользователей = null;
				if (ObjectList.Contains("ДляВсехПользователей"))
                    ДляВсехПользователей = ObjectList["ДляВсехПользователей"] as NsgDataPredefinedReference;
                else
                    ДляВсехПользователей = new NsgDataPredefinedReference();
	//NsgDataPredefinedReference
	ДляВсехПользователей.IsLoadedFromDll = true;
	ДляВсехПользователей.SaveInDatabase = false;
	ДляВсехПользователей.RequisiteValues = new NsgSoft.DataObjects.NsgPropertyCollection(new System.String[]{"Наименование", "ОбновлятьИзБД", "ПриоритетОбновления", "ПутьДляОбновления", "Логин"},
		 new System.Object[]{"Для всех пользователей", false, 0, "", ""});
	ДляВсехПользователей.Guid = NsgService.StringToGuid("215aff7f-098c-405c-8137-c89600c8fa23");
	ДляВсехПользователей.ReferentGroup = "Сервис";
	ДляВсехПользователей.ReferentName = "ОбновленияСистемы";
	ДляВсехПользователей.OwnerName = "";
	ДляВсехПользователей.AllowEmptyOwner = false;
	ДляВсехПользователей.StringFormat = "";
	ДляВсехПользователей.SubType = NsgSoft.Common.NsgRekvisitSubType.Predefined;
	ДляВсехПользователей.IncludeInPredefined = false;
	ДляВсехПользователей.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДляВсехПользователей.Required = false;
	ДляВсехПользователей.EmptyValue = "";
	ДляВсехПользователей.NullAllow = false;
	ДляВсехПользователей.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДляВсехПользователей.FieldName = "DljaVsekhPolzovat";
	ДляВсехПользователей.InformMetaDataOnValueChanged = false;
	ДляВсехПользователей.Visible = true;
	ДляВсехПользователей.Name = "ДляВсехПользователей";
	ДляВсехПользователей.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Для всех пользователей"});
	ДляВсехПользователей.Description = "Для всех пользователей";
	ДляВсехПользователей.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДляВсехПользователей.GroupName = "";
	
				if (!ObjectList.Contains("ДляВсехПользователей"))
                    ObjectList.Add(ДляВсехПользователей);
			}
			#endregion //создание Сервис.ОбновленияСистемы ДляВсехПользователей
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Наименование";
	PeriodicTable = "";
	MaxGroupLevel = 0;
	HasOwner = false;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ОбновленияСистемы";
	Visible = true;
	Guid = NsgService.StringToGuid("5149360b-7895-4c40-a8d9-905b0e142f5c");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Наименование}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = true;
	TableName = "UpdateDictionary";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Обновления системы"});
	Description = "Обновления системы";
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
            /// Пользователь
            /// </summary>
            public static String Пользователь
            {
                get
                {
                    return "Пользователь";
                }
            }
            
            /// <summary>
            /// Обновлять из БД
            /// </summary>
            public static String ОбновлятьИзБД
            {
                get
                {
                    return "ОбновлятьИзБД";
                }
            }
            
            /// <summary>
            /// Приоритет обновления
            /// </summary>
            public static String ПриоритетОбновления
            {
                get
                {
                    return "ПриоритетОбновления";
                }
            }
            
            /// <summary>
            /// Путь для обновления
            /// </summary>
            public static String ПутьДляОбновления
            {
                get
                {
                    return "ПутьДляОбновления";
                }
            }
            
            /// <summary>
            /// Логин
            /// </summary>
            public static String Логин
            {
                get
                {
                    return "Логин";
                }
            }
            
            /// <summary>
            /// Пароль
            /// </summary>
            public static String Пароль
            {
                get
                {
                    return "Пароль";
                }
            }
            
            /// <summary>
            /// Для всех пользователей
            /// </summary>
            public static String ДляВсехПользователей
            {
                get
                {
                    return "ДляВсехПользователей";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public static string GetFullName()
        {
            return "Сервис.ОбновленияСистемы";
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
        /// Пользователь
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Сервис.Пользователи Пользователь
        {
            get
            {
				 NsgDataTypedReference __Пользователь = ObjectList["Пользователь"] as NsgDataTypedReference;
                 return (Сервис.Пользователи)__Пользователь.Referent;
            }
            set
            {
                NsgDataTypedReference __Пользователь = ObjectList["Пользователь"] as NsgDataTypedReference;
                __Пользователь.Referent = value;
            }
        }
        
        /// <summary>
        /// Обновлять из БД
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean ОбновлятьИзБД
        {
            get
            {
				 NsgDataBoolean __ОбновлятьИзБД = ObjectList["ОбновлятьИзБД"] as NsgDataBoolean;
                 return (System.Boolean)__ОбновлятьИзБД.Value;
            }
            set
            {
                NsgDataBoolean __ОбновлятьИзБД = ObjectList["ОбновлятьИзБД"] as NsgDataBoolean;
                __ОбновлятьИзБД.Value = value;
            }
        }
        
        /// <summary>
        /// Приоритет обновления
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 ПриоритетОбновления
        {
            get
            {
				 NsgDataInteger __ПриоритетОбновления = ObjectList["ПриоритетОбновления"] as NsgDataInteger;
                 return (System.Int64)__ПриоритетОбновления.Value;
            }
            set
            {
                NsgDataInteger __ПриоритетОбновления = ObjectList["ПриоритетОбновления"] as NsgDataInteger;
                __ПриоритетОбновления.Value = value;
            }
        }
        
        /// <summary>
        /// Путь для обновления
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ПутьДляОбновления
        {
            get
            {
				 NsgDataString __ПутьДляОбновления = ObjectList["ПутьДляОбновления"] as NsgDataString;
                 return (System.String)__ПутьДляОбновления.Value;
            }
            set
            {
                NsgDataString __ПутьДляОбновления = ObjectList["ПутьДляОбновления"] as NsgDataString;
                __ПутьДляОбновления.Value = value;
            }
        }
        
        /// <summary>
        /// Логин
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Логин
        {
            get
            {
				 NsgDataString __Логин = ObjectList["Логин"] as NsgDataString;
                 return (System.String)__Логин.Value;
            }
            set
            {
                NsgDataString __Логин = ObjectList["Логин"] as NsgDataString;
                __Логин.Value = value;
            }
        }
        
        /// <summary>
        /// Пароль
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Пароль
        {
            get
            {
				 NsgDataString __Пароль = ObjectList["Пароль"] as NsgDataString;
                 return (System.String)__Пароль.Value;
            }
            set
            {
                NsgDataString __Пароль = ObjectList["Пароль"] as NsgDataString;
                __Пароль.Value = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataDictionary
        

        /// <summary>
		/// Родитель для данного элемента справочника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        public ОбновленияСистемы Родитель
        {
            get
            {
                return base.Parent as ОбновленияСистемы;
            }
            set
            {
                base.Parent = value;
            }
        }
        #region #Comment_Predefined#
        
        /// <summary>
        /// Для всех пользователей
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        public static ОбновленияСистемы ДляВсехПользователей
        {
            get
            {
                return (ОбновленияСистемы)getPredefined(NsgService.StringToGuid("5149360b-7895-4c40-a8d9-905b0e142f5c"), NsgService.StringToGuid("215aff7f-098c-405c-8137-c89600c8fa23"));
            }
        }
        
        #endregion //#Comment_Predefined#
		



        #endregion // Свойства NsgSoft.DataObjects.NsgDataDictionary

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataDictionary
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataDictionary

        #region Методы NsgMultipleObject
        private ОбновленияСистемы[] convertArray(NsgMultipleObject[] array)
        {
            ОбновленияСистемы[] res = new ОбновленияСистемы[array.Length];
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
        public new virtual ОбновленияСистемы[] FindAll(NsgCompare compare)
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
        public new virtual ОбновленияСистемы[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ОбновленияСистемы[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ОбновленияСистемы[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ОбновленияСистемы(this as NsgObject);
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
                base.NSGType = typeof(ОбновленияСистемы);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ОбновленияСистемы Value
            {
                get
                {
                    return (ОбновленияСистемы)base.Value;
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
