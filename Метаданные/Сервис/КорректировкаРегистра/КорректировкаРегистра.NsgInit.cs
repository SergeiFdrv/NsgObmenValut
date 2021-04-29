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
    
    [NsgTypeName("NsgDataRegisterCorrection", Guid = "137a9438-538e-48ca-9995-f3ba4ee23d2a")]
    public partial class КорректировкаРегистра : NsgSoft.DataObjects.NsgDataRegisterCorrection
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataRegisterCorrection
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataRegisterCorrection

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataRegisterCorrection
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataRegisterCorrection

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected КорректировкаРегистра()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected КорректировкаРегистра(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static КорректировкаРегистра Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("137a9438-538e-48ca-9995-f3ba4ee23d2a"));
            if (obj == null)
                obj = new КорректировкаРегистра();
            return obj as КорректировкаРегистра;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataRegisterCorrection
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataRegisterCorrection
			
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
	Идентификатор.Guid = NsgService.StringToGuid("04ff8cfe-446f-45b1-afe5-8ce8347d5031");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("f2f7f966-744f-4c43-9009-6bb10ac9437f");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
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
	ПрефиксКода.Guid = NsgService.StringToGuid("8ceeb2d7-f80a-4932-9f38-701e536338cb");
	
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
	НомерКода.Guid = NsgService.StringToGuid("f17344d8-a5b1-4799-a9ff-8b527e5729e2");
	
				if (!ObjectList.Contains("НомерКода"))
                    ObjectList.Add(НомерКода);
			}
			#endregion //создание System.Int64 НомерКода
			
			#region создание System.String НомерДокумента
			{  
                NsgDataVirtualObject НомерДокумента = null;
				if (ObjectList.Contains("НомерДокумента"))
                    НомерДокумента = ObjectList["НомерДокумента"] as NsgDataVirtualObject;
                else
                    НомерДокумента = new NsgDataVirtualObject();
	//NsgDataVirtualObject
	НомерДокумента.IsLoadedFromDll = true;
	НомерДокумента.ArrayField = new System.String[]{"ПрефиксКода", "НомерКода"};
	НомерДокумента.SaveInDatabase = false;
	НомерДокумента.StringFormat = "";
	НомерДокумента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	НомерДокумента.IncludeInPredefined = false;
	НомерДокумента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерДокумента.Required = false;
	НомерДокумента.EmptyValue = "";
	НомерДокумента.NullAllow = false;
	НомерДокумента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	НомерДокумента.FieldName = "_Code";
	НомерДокумента.InformMetaDataOnValueChanged = false;
	НомерДокумента.Visible = true;
	НомерДокумента.Name = "НомерДокумента";
	НомерДокумента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Номер документа"});
	НомерДокумента.Description = "Номер документа";
	НомерДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	НомерДокумента.GroupName = "";
	НомерДокумента.Guid = NsgService.StringToGuid("2a029566-1a81-4002-bb2a-1436b1453557");
	
				if (!ObjectList.Contains("НомерДокумента"))
                    ObjectList.Add(НомерДокумента);
			}
			#endregion //создание System.String НомерДокумента
			
			#region создание System.DateTime ДатаДокумента
			{  
                NsgDataDateTime ДатаДокумента = null;
				if (ObjectList.Contains("ДатаДокумента"))
                    ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                else
                    ДатаДокумента = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаДокумента.IsLoadedFromDll = true;
	ДатаДокумента.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаДокумента.StringFormat = "";
	ДатаДокумента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаДокумента.IncludeInPredefined = false;
	ДатаДокумента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаДокумента.Required = false;
	ДатаДокумента.EmptyValue = "";
	ДатаДокумента.NullAllow = false;
	ДатаДокумента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДатаДокумента.FieldName = "_Date";
	ДатаДокумента.SaveInDatabase = true;
	ДатаДокумента.InformMetaDataOnValueChanged = false;
	ДатаДокумента.Visible = true;
	ДатаДокумента.Name = "ДатаДокумента";
	ДатаДокумента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Дата документа"});
	ДатаДокумента.Description = "Дата документа";
	ДатаДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ДатаДокумента.GroupName = "";
	ДатаДокумента.Guid = NsgService.StringToGuid("ad1b35be-1b17-4dc5-bad3-623b7a36d4d8");
	
				if (!ObjectList.Contains("ДатаДокумента"))
                    ObjectList.Add(ДатаДокумента);
			}
			#endregion //создание System.DateTime ДатаДокумента
			
			#region создание System.String Индекс
			{  
                NsgDataIndex Индекс = null;
				if (ObjectList.Contains("Индекс"))
                    Индекс = ObjectList["Индекс"] as NsgDataIndex;
                else
                    Индекс = new NsgDataIndex();
	//NsgDataIndex
	Индекс.IsLoadedFromDll = true;
	Индекс.RequisiteList = "ДатаДокумента,Автоинкремент";
	Индекс.SaveInDatabase = false;
	Индекс.StringFormat = "";
	Индекс.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Индекс.IncludeInPredefined = false;
	Индекс.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Индекс.Required = false;
	Индекс.EmptyValue = "";
	Индекс.NullAllow = false;
	Индекс.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Индекс.FieldName = "_Index";
	Индекс.InformMetaDataOnValueChanged = false;
	Индекс.Visible = true;
	Индекс.Name = "Индекс";
	Индекс.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Индекс.Description = "Индекс";
	Индекс.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Индекс.GroupName = "";
	Индекс.Guid = NsgService.StringToGuid("7d08303d-fbaf-4364-a7dc-a3823733ce94");
	
				if (!ObjectList.Contains("Индекс"))
                    ObjectList.Add(Индекс);
			}
			#endregion //создание System.String Индекс
			
			#region создание NsgSoft.DataObjects.NsgReferencedObject ДокументОснование
			{  
                NsgDataUntypedReference ДокументОснование = null;
				if (ObjectList.Contains("ДокументОснование"))
                    ДокументОснование = ObjectList["ДокументОснование"] as NsgDataUntypedReference;
                else
                    ДокументОснование = new NsgDataUntypedReference();
	//NsgDataUntypedReference
	ДокументОснование.IsLoadedFromDll = true;
	ДокументОснование.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.List;
	ДокументОснование.FilterForConfigurator = "Сервис.КорректировкаРегистра";
	ДокументОснование.ReferentName = "";
	ДокументОснование.ReferentGroup = "";
	ДокументОснование.TypeSelectorName = "";
	ДокументОснование.SaveInDatabase = true;
	ДокументОснование.OwnerName = "";
	ДокументОснование.AllowEmptyOwner = false;
	ДокументОснование.StringFormat = "";
	ДокументОснование.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДокументОснование.IncludeInPredefined = false;
	ДокументОснование.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДокументОснование.Required = false;
	ДокументОснование.EmptyValue = "";
	ДокументОснование.NullAllow = false;
	ДокументОснование.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДокументОснование.FieldName = "_BaseDocument";
	ДокументОснование.InformMetaDataOnValueChanged = false;
	ДокументОснование.Visible = true;
	ДокументОснование.Name = "ДокументОснование";
	ДокументОснование.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДокументОснование.Description = "Документ основание";
	ДокументОснование.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ДокументОснование.GroupName = "";
	ДокументОснование.Guid = NsgService.StringToGuid("2c4921df-7cb4-485a-af38-6f6d5495f252");
	
				if (!ObjectList.Contains("ДокументОснование"))
                    ObjectList.Add(ДокументОснование);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject ДокументОснование
			
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
	СостояниеДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	СостояниеДокумента.GroupName = "";
	СостояниеДокумента.Guid = NsgService.StringToGuid("c9a74e5b-7829-40a9-94ac-ad24ea606294");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание NsgSoft.Forms.NsgDataRegisterCorrectionForm ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "NsgSoft.Forms.NsgDataRegisterCorrectionForm";
	ФормаЭлемента.SaveInDatabase = false;
	ФормаЭлемента.StringFormat = "";
	ФормаЭлемента.SubType = NsgSoft.Common.NsgRekvisitSubType.ElementForm;
	ФормаЭлемента.IncludeInPredefined = false;
	ФормаЭлемента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ФормаЭлемента.Required = false;
	ФормаЭлемента.EmptyValue = "";
	ФормаЭлемента.NullAllow = false;
	ФормаЭлемента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ФормаЭлемента.FieldName = "FormaEHlementa";
	ФормаЭлемента.InformMetaDataOnValueChanged = false;
	ФормаЭлемента.Visible = true;
	ФормаЭлемента.Name = "ФормаЭлемента";
	ФормаЭлемента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ФормаЭлемента.Description = "Форма элемента";
	ФормаЭлемента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ФормаЭлемента.GroupName = "";
	ФормаЭлемента.Guid = NsgService.StringToGuid("f03df222-0bdf-4753-a4a2-64aab3aacf01");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание NsgSoft.Forms.NsgDataRegisterCorrectionForm ФормаЭлемента
			
			#region создание NsgSoft.DataObjects.NsgMultipleObject Регистр
			{  
                NsgObjectSelector Регистр = null;
				if (ObjectList.Contains("Регистр"))
                    Регистр = ObjectList["Регистр"] as NsgObjectSelector;
                else
                    Регистр = new NsgObjectSelector();
	//NsgObjectSelector
	Регистр.IsLoadedFromDll = true;
	Регистр.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.Type;
	Регистр.FilterForConfigurator = "NsgDataRegister";
	Регистр.StringFormat = "";
	Регистр.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Регистр.IncludeInPredefined = false;
	Регистр.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Регистр.Required = false;
	Регистр.EmptyValue = "";
	Регистр.NullAllow = false;
	Регистр.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Регистр.FieldName = "Registr";
	Регистр.SaveInDatabase = true;
	Регистр.InformMetaDataOnValueChanged = false;
	Регистр.Visible = true;
	Регистр.Name = "Регистр";
	Регистр.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Регистр.Description = "Регистр";
	Регистр.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Регистр.GroupName = "";
	Регистр.Guid = NsgService.StringToGuid("d308b6af-b92a-4080-b8b4-1926bd8fee0d");
	
				if (!ObjectList.Contains("Регистр"))
                    ObjectList.Add(Регистр);
			}
			#endregion //создание NsgSoft.DataObjects.NsgMultipleObject Регистр
			
			#region создание System.String Операция
			{  
                NsgDataString Операция = null;
				if (ObjectList.Contains("Операция"))
                    Операция = ObjectList["Операция"] as NsgDataString;
                else
                    Операция = new NsgDataString();
	//NsgDataString
	Операция.IsLoadedFromDll = true;
	Операция.Length = 50;
	Операция.StringFormat = "";
	Операция.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Операция.IncludeInPredefined = false;
	Операция.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Операция.Required = true;
	Операция.EmptyValue = "";
	Операция.NullAllow = false;
	Операция.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Операция.FieldName = "Operacija";
	Операция.SaveInDatabase = true;
	Операция.InformMetaDataOnValueChanged = false;
	Операция.Visible = true;
	Операция.Name = "Операция";
	Операция.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Операция.Description = "Операция";
	Операция.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Операция.GroupName = "";
	Операция.Guid = NsgService.StringToGuid("a91cde10-ad6d-4705-94f3-d3a84b7ec421");
	
				if (!ObjectList.Contains("Операция"))
                    ObjectList.Add(Операция);
			}
			#endregion //создание System.String Операция
			
			#region создание System.DateTime ДатаНачалаДействия
			{  
                NsgDataDateTime ДатаНачалаДействия = null;
				if (ObjectList.Contains("ДатаНачалаДействия"))
                    ДатаНачалаДействия = ObjectList["ДатаНачалаДействия"] as NsgDataDateTime;
                else
                    ДатаНачалаДействия = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаНачалаДействия.IsLoadedFromDll = true;
	ДатаНачалаДействия.Format = NsgSoft.Common.NsgDateTimeFormat.Time;
	ДатаНачалаДействия.StringFormat = "";
	ДатаНачалаДействия.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаНачалаДействия.IncludeInPredefined = false;
	ДатаНачалаДействия.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаНачалаДействия.Required = false;
	ДатаНачалаДействия.EmptyValue = "";
	ДатаНачалаДействия.NullAllow = false;
	ДатаНачалаДействия.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаНачалаДействия.FieldName = "DataNachalaDeijst";
	ДатаНачалаДействия.SaveInDatabase = true;
	ДатаНачалаДействия.InformMetaDataOnValueChanged = false;
	ДатаНачалаДействия.Visible = true;
	ДатаНачалаДействия.Name = "ДатаНачалаДействия";
	ДатаНачалаДействия.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаНачалаДействия.Description = "Дата начала действия";
	ДатаНачалаДействия.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ДатаНачалаДействия.GroupName = "";
	ДатаНачалаДействия.Guid = NsgService.StringToGuid("2421785c-8b3c-47d8-b11d-e2a6860199df");
	
				if (!ObjectList.Contains("ДатаНачалаДействия"))
                    ObjectList.Add(ДатаНачалаДействия);
			}
			#endregion //создание System.DateTime ДатаНачалаДействия
			
			#region создание System.DateTime ДатаОкончанияДействия
			{  
                NsgDataDateTime ДатаОкончанияДействия = null;
				if (ObjectList.Contains("ДатаОкончанияДействия"))
                    ДатаОкончанияДействия = ObjectList["ДатаОкончанияДействия"] as NsgDataDateTime;
                else
                    ДатаОкончанияДействия = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаОкончанияДействия.IsLoadedFromDll = true;
	ДатаОкончанияДействия.Format = NsgSoft.Common.NsgDateTimeFormat.Time;
	ДатаОкончанияДействия.StringFormat = "";
	ДатаОкончанияДействия.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаОкончанияДействия.IncludeInPredefined = false;
	ДатаОкончанияДействия.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаОкончанияДействия.Required = false;
	ДатаОкончанияДействия.EmptyValue = "";
	ДатаОкончанияДействия.NullAllow = false;
	ДатаОкончанияДействия.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаОкончанияДействия.FieldName = "DataOkonchanijaDe";
	ДатаОкончанияДействия.SaveInDatabase = true;
	ДатаОкончанияДействия.InformMetaDataOnValueChanged = false;
	ДатаОкончанияДействия.Visible = true;
	ДатаОкончанияДействия.Name = "ДатаОкончанияДействия";
	ДатаОкончанияДействия.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаОкончанияДействия.Description = "Дата окончания действия";
	ДатаОкончанияДействия.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ДатаОкончанияДействия.GroupName = "";
	ДатаОкончанияДействия.Guid = NsgService.StringToGuid("eef39b8a-10d8-4026-ae95-4c909391693d");
	
				if (!ObjectList.Contains("ДатаОкончанияДействия"))
                    ObjectList.Add(ДатаОкончанияДействия);
			}
			#endregion //создание System.DateTime ДатаОкончанияДействия
			

			#region заполнение полей класса
				//NsgDataRegisterCorrection
	IsLoadedFromDll = true;
	SlaveDocuments = new List<string>(new string[]{"Сервис.ОбщийЖурнал", "Сервис.КорректировкаРегистра", "Сервис.СервернаяЗадача"});
	SearchFieldName = "НомерДокумента";
	HandleWithoutTransaction = false;
	UsedRegistersForConfigurator = new NsgSoft.DataObjects.NsgPropertyCollection(new System.String[]{"Сервис.ПечатныеФормы", "Сервис.ПраваПользователей"},
		 new System.Object[]{NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.Write, NsgSoft.DataObjects.NsgDataDocument.RegisterHandleRegime.Write});
	NumberPeriod = NsgSoft.Common.NsgPeriod.None;
	UseCommonJournal = true;
	DataInterfaces.AddRange( new NsgInterfaceImplement[] {new NsgSoft.DataObjects.NsgInterfaceImplement("Сервис.ОбщийЖурнал", NsgSoft.Common.RowsImplementation.AllRows, false)});
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "КорректировкаРегистра";
	Visible = true;
	Guid = NsgService.StringToGuid("137a9438-538e-48ca-9995-f3ba4ee23d2a");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Операция} {Регистр}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = true;
	TableName = "RegisterCorrection";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Корректировка регистра";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Сервис";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataRegisterCorrection
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataRegisterCorrection

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
        public new partial class Names// :NsgSoft.DataObjects.NsgDataRegisterCorrection.Names
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
            /// Номер документа
            /// </summary>
            public static String НомерДокумента
            {
                get
                {
                    return "НомерДокумента";
                }
            }
            
            /// <summary>
            /// Дата документа
            /// </summary>
            public static String ДатаДокумента
            {
                get
                {
                    return "ДатаДокумента";
                }
            }
            
            /// <summary>
            /// Индекс
            /// </summary>
            public static String Индекс
            {
                get
                {
                    return "Индекс";
                }
            }
            
            /// <summary>
            /// Документ основание
            /// </summary>
            public static String ДокументОснование
            {
                get
                {
                    return "ДокументОснование";
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
            /// Форма элемента
            /// </summary>
            public static String ФормаЭлемента
            {
                get
                {
                    return "ФормаЭлемента";
                }
            }
            
            /// <summary>
            /// Регистр
            /// </summary>
            public static String Регистр
            {
                get
                {
                    return "Регистр";
                }
            }
            
            /// <summary>
            /// Операция
            /// </summary>
            public static String Операция
            {
                get
                {
                    return "Операция";
                }
            }
            
            /// <summary>
            /// Дата начала действия
            /// </summary>
            public static String ДатаНачалаДействия
            {
                get
                {
                    return "ДатаНачалаДействия";
                }
            }
            
            /// <summary>
            /// Дата окончания действия
            /// </summary>
            public static String ДатаОкончанияДействия
            {
                get
                {
                    return "ДатаОкончанияДействия";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public static string GetFullName()
        {
            return "Сервис.КорректировкаРегистра";
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
        /// Номер документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataVirtualObject")]
        
        public System.String НомерДокумента
        {
            get
            {
				 NsgDataVirtualObject __НомерДокумента = ObjectList["НомерДокумента"] as NsgDataVirtualObject;
                 return (System.String)__НомерДокумента.Value;
            }
            set
            {
                NsgDataVirtualObject __НомерДокумента = ObjectList["НомерДокумента"] as NsgDataVirtualObject;
                __НомерДокумента.Value = value;
            }
        }
        
        /// <summary>
        /// Дата документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаДокумента
        {
            get
            {
				 NsgDataDateTime __ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаДокумента.Value;
            }
            set
            {
                NsgDataDateTime __ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                __ДатаДокумента.Value = value;
            }
        }
        
        /// <summary>
        /// Индекс
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataIndex")]
        
        public System.String Индекс
        {
            get
            {
				 NsgDataIndex __Индекс = ObjectList["Индекс"] as NsgDataIndex;
                 return (System.String)__Индекс.Value;
            }
            set
            {
                NsgDataIndex __Индекс = ObjectList["Индекс"] as NsgDataIndex;
                __Индекс.Value = value;
            }
        }
        
        /// <summary>
        /// Документ основание
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("Сервис.КорректировкаРегистра")]
        public NsgSoft.DataObjects.NsgReferencedObject ДокументОснование
        {
            get
            {
				 NsgDataUntypedReference __ДокументОснование = ObjectList["ДокументОснование"] as NsgDataUntypedReference;
                 return (NsgSoft.DataObjects.NsgReferencedObject)__ДокументОснование.Referent;
            }
            set
            {
                NsgDataUntypedReference __ДокументОснование = ObjectList["ДокументОснование"] as NsgDataUntypedReference;
                __ДокументОснование.Referent = value;
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
        /// Регистр
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgObjectSelector")]
        
        public NsgSoft.DataObjects.NsgMultipleObject Регистр
        {
            get
            {
				 NsgObjectSelector __Регистр = ObjectList["Регистр"] as NsgObjectSelector;
                 return (NsgSoft.DataObjects.NsgMultipleObject)__Регистр.Object;
            }
            set
            {
                NsgObjectSelector __Регистр = ObjectList["Регистр"] as NsgObjectSelector;
                __Регистр.Object = value;
            }
        }
        
        /// <summary>
        /// Операция
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Операция
        {
            get
            {
				 NsgDataString __Операция = ObjectList["Операция"] as NsgDataString;
                 return (System.String)__Операция.Value;
            }
            set
            {
                NsgDataString __Операция = ObjectList["Операция"] as NsgDataString;
                __Операция.Value = value;
            }
        }
        
        /// <summary>
        /// Дата начала действия
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаНачалаДействия
        {
            get
            {
				 NsgDataDateTime __ДатаНачалаДействия = ObjectList["ДатаНачалаДействия"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаНачалаДействия.Value;
            }
            set
            {
                NsgDataDateTime __ДатаНачалаДействия = ObjectList["ДатаНачалаДействия"] as NsgDataDateTime;
                __ДатаНачалаДействия.Value = value;
            }
        }
        
        /// <summary>
        /// Дата окончания действия
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаОкончанияДействия
        {
            get
            {
				 NsgDataDateTime __ДатаОкончанияДействия = ObjectList["ДатаОкончанияДействия"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаОкончанияДействия.Value;
            }
            set
            {
                NsgDataDateTime __ДатаОкончанияДействия = ObjectList["ДатаОкончанияДействия"] as NsgDataDateTime;
                __ДатаОкончанияДействия.Value = value;
            }
        }
        

        
        /// <summary>
        /// Форма элемента
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataForm")]
        
        public INsgObjectForm ФормаЭлемента
        {
            get
            {
                INsgObjectForm res = null;
                if (ObjectList["ФормаЭлемента"].SubType == NsgRekvisitSubType.ListForm)
                   res = NsgSettings.MainForm.GetObjectListForm(this,"ФормаЭлемента");
                else
                   res = NsgSettings.MainForm.GetObjectForm(this,"ФормаЭлемента");
                return res;
           }
        }
        
        #region Свойства NsgSoft.DataObjects.NsgDataRegisterCorrection
        




        #endregion // Свойства NsgSoft.DataObjects.NsgDataRegisterCorrection

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataRegisterCorrection
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataRegisterCorrection

        #region Методы NsgMultipleObject
        private КорректировкаРегистра[] convertArray(NsgMultipleObject[] array)
        {
            КорректировкаРегистра[] res = new КорректировкаРегистра[array.Length];
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
        public new virtual КорректировкаРегистра[] FindAll(NsgCompare compare)
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
        public new virtual КорректировкаРегистра[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual КорректировкаРегистра[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual КорректировкаРегистра[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new КорректировкаРегистра(this as NsgObject);
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
                base.NSGType = typeof(КорректировкаРегистра);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new КорректировкаРегистра Value
            {
                get
                {
                    return (КорректировкаРегистра)base.Value;
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
                    return "s_NsgDataDocument";
                }
            }
        }
    }

}
