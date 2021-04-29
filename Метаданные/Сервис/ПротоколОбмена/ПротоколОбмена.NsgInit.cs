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
    
    [NsgTypeName("NsgDataDictionary", Guid = "1522c648-40dc-4ed1-97ff-a7d475391435")]
    public partial class ПротоколОбмена : NsgSoft.DataObjects.NsgDataDictionary
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
        protected ПротоколОбмена()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ПротоколОбмена(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ПротоколОбмена Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("1522c648-40dc-4ed1-97ff-a7d475391435"));
            if (obj == null)
                obj = new ПротоколОбмена();
            return obj as ПротоколОбмена;
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
	Идентификатор.Guid = NsgService.StringToGuid("44c6b127-c0b1-4732-abe2-7a48ef1e22d1");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("eb82ec2d-ccc1-4e70-9b10-9d0fd2764960");
	
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
	ЭтоГруппа.Guid = NsgService.StringToGuid("86024185-d1ca-4f4d-80f8-12cc49cb1750");
	
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
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("63147b99-ceaa-4c81-b8c7-44b77fa26c8e");
	
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
	Уровень.Guid = NsgService.StringToGuid("beaec4fc-e952-4180-aebc-894590c8af55");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("96ffcea3-d231-4893-8617-d02469294202");
	
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
	НомерКода.Guid = NsgService.StringToGuid("3e653348-d56f-4c4d-a96f-6df488006d3e");
	
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
	Код.Guid = NsgService.StringToGuid("09181e26-de21-4c93-bb1f-d913360e5258");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("828f903b-30a4-4840-ac98-cf3bc6de4e99");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
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
	БазаИсточник.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	БазаИсточник.GroupName = "";
	БазаИсточник.Guid = NsgService.StringToGuid("4be2460d-0516-4fce-9aa0-2a15afece1a4");
	
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
	БазаПолучатель.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	БазаПолучатель.GroupName = "";
	БазаПолучатель.Guid = NsgService.StringToGuid("93db29cf-72cd-4052-9e57-33d445086480");
	
				if (!ObjectList.Contains("БазаПолучатель"))
                    ObjectList.Add(БазаПолучатель);
			}
			#endregion //создание Сервис.БазыДанныхДляОбмена БазаПолучатель
			
			#region создание System.Int64 НомерОбмена
			{  
                NsgDataInteger НомерОбмена = null;
				if (ObjectList.Contains("НомерОбмена"))
                    НомерОбмена = ObjectList["НомерОбмена"] as NsgDataInteger;
                else
                    НомерОбмена = new NsgDataInteger();
	//NsgDataInteger
	НомерОбмена.IsLoadedFromDll = true;
	НомерОбмена.DefaultValue = 0M;
	НомерОбмена.MinValue = 0M;
	НомерОбмена.MaxValue = 0M;
	НомерОбмена.UseCalculator = true;
	НомерОбмена.StringFormat = "";
	НомерОбмена.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	НомерОбмена.IncludeInPredefined = false;
	НомерОбмена.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НомерОбмена.Required = false;
	НомерОбмена.EmptyValue = "";
	НомерОбмена.NullAllow = false;
	НомерОбмена.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НомерОбмена.FieldName = "_ExchangeNumber";
	НомерОбмена.SaveInDatabase = true;
	НомерОбмена.InformMetaDataOnValueChanged = false;
	НомерОбмена.Visible = true;
	НомерОбмена.Name = "НомерОбмена";
	НомерОбмена.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Номер обмена"});
	НомерОбмена.Description = "Номер обмена";
	НомерОбмена.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	НомерОбмена.GroupName = "";
	НомерОбмена.Guid = NsgService.StringToGuid("b734372c-95e3-4e09-b005-0f7fc57c7bf1");
	
				if (!ObjectList.Contains("НомерОбмена"))
                    ObjectList.Add(НомерОбмена);
			}
			#endregion //создание System.Int64 НомерОбмена
			
			#region создание System.DateTime ДатаОбмена
			{  
                NsgDataDateTime ДатаОбмена = null;
				if (ObjectList.Contains("ДатаОбмена"))
                    ДатаОбмена = ObjectList["ДатаОбмена"] as NsgDataDateTime;
                else
                    ДатаОбмена = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаОбмена.IsLoadedFromDll = true;
	ДатаОбмена.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаОбмена.StringFormat = "";
	ДатаОбмена.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ДатаОбмена.IncludeInPredefined = false;
	ДатаОбмена.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаОбмена.Required = false;
	ДатаОбмена.EmptyValue = "";
	ДатаОбмена.NullAllow = false;
	ДатаОбмена.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ДатаОбмена.FieldName = "_ExchangeDate";
	ДатаОбмена.SaveInDatabase = true;
	ДатаОбмена.InformMetaDataOnValueChanged = false;
	ДатаОбмена.Visible = true;
	ДатаОбмена.Name = "ДатаОбмена";
	ДатаОбмена.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Дата обмена"});
	ДатаОбмена.Description = "Дата обмена";
	ДатаОбмена.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ДатаОбмена.GroupName = "";
	ДатаОбмена.Guid = NsgService.StringToGuid("b07660e8-5540-4c03-bf9b-5c4121efbeee");
	
				if (!ObjectList.Contains("ДатаОбмена"))
                    ObjectList.Add(ДатаОбмена);
			}
			#endregion //создание System.DateTime ДатаОбмена
			
			#region создание System.String ВерсияПрограммы
			{  
                NsgDataString ВерсияПрограммы = null;
				if (ObjectList.Contains("ВерсияПрограммы"))
                    ВерсияПрограммы = ObjectList["ВерсияПрограммы"] as NsgDataString;
                else
                    ВерсияПрограммы = new NsgDataString();
	//NsgDataString
	ВерсияПрограммы.IsLoadedFromDll = true;
	ВерсияПрограммы.Length = 15;
	ВерсияПрограммы.StringFormat = "";
	ВерсияПрограммы.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ВерсияПрограммы.IncludeInPredefined = false;
	ВерсияПрограммы.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВерсияПрограммы.Required = false;
	ВерсияПрограммы.EmptyValue = "";
	ВерсияПрограммы.NullAllow = false;
	ВерсияПрограммы.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВерсияПрограммы.FieldName = "VersijaProgrammy";
	ВерсияПрограммы.SaveInDatabase = true;
	ВерсияПрограммы.InformMetaDataOnValueChanged = false;
	ВерсияПрограммы.Visible = true;
	ВерсияПрограммы.Name = "ВерсияПрограммы";
	ВерсияПрограммы.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"ВерсияПрограммы"});
	ВерсияПрограммы.Description = "ВерсияПрограммы";
	ВерсияПрограммы.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ВерсияПрограммы.GroupName = "";
	ВерсияПрограммы.Guid = NsgService.StringToGuid("196bb61a-d7e9-4ca1-9e9d-27df87f8dba1");
	
				if (!ObjectList.Contains("ВерсияПрограммы"))
                    ObjectList.Add(ВерсияПрограммы);
			}
			#endregion //создание System.String ВерсияПрограммы
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Код";
	PeriodicTable = "";
	MaxGroupLevel = 0;
	HasOwner = false;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ПротоколОбмена";
	Visible = true;
	Guid = NsgService.StringToGuid("1522c648-40dc-4ed1-97ff-a7d475391435");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = true;
	TableName = "ExchangeProtocol";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Протокол обмена"});
	Description = "Протокол обмена";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
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
            /// Номер обмена
            /// </summary>
            public static String НомерОбмена
            {
                get
                {
                    return "НомерОбмена";
                }
            }
            
            /// <summary>
            /// Дата обмена
            /// </summary>
            public static String ДатаОбмена
            {
                get
                {
                    return "ДатаОбмена";
                }
            }
            
            /// <summary>
            /// ВерсияПрограммы
            /// </summary>
            public static String ВерсияПрограммы
            {
                get
                {
                    return "ВерсияПрограммы";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public static string GetFullName()
        {
            return "Сервис.ПротоколОбмена";
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
        /// Номер обмена
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 НомерОбмена
        {
            get
            {
				 NsgDataInteger __НомерОбмена = ObjectList["НомерОбмена"] as NsgDataInteger;
                 return (System.Int64)__НомерОбмена.Value;
            }
            set
            {
                NsgDataInteger __НомерОбмена = ObjectList["НомерОбмена"] as NsgDataInteger;
                __НомерОбмена.Value = value;
            }
        }
        
        /// <summary>
        /// Дата обмена
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаОбмена
        {
            get
            {
				 NsgDataDateTime __ДатаОбмена = ObjectList["ДатаОбмена"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаОбмена.Value;
            }
            set
            {
                NsgDataDateTime __ДатаОбмена = ObjectList["ДатаОбмена"] as NsgDataDateTime;
                __ДатаОбмена.Value = value;
            }
        }
        
        /// <summary>
        /// ВерсияПрограммы
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ВерсияПрограммы
        {
            get
            {
				 NsgDataString __ВерсияПрограммы = ObjectList["ВерсияПрограммы"] as NsgDataString;
                 return (System.String)__ВерсияПрограммы.Value;
            }
            set
            {
                NsgDataString __ВерсияПрограммы = ObjectList["ВерсияПрограммы"] as NsgDataString;
                __ВерсияПрограммы.Value = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataDictionary
        

        /// <summary>
		/// Родитель для данного элемента справочника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        public ПротоколОбмена Родитель
        {
            get
            {
                return base.Parent as ПротоколОбмена;
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
        private ПротоколОбмена[] convertArray(NsgMultipleObject[] array)
        {
            ПротоколОбмена[] res = new ПротоколОбмена[array.Length];
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
        public new virtual ПротоколОбмена[] FindAll(NsgCompare compare)
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
        public new virtual ПротоколОбмена[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ПротоколОбмена[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ПротоколОбмена[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ПротоколОбмена(this as NsgObject);
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
                base.NSGType = typeof(ПротоколОбмена);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ПротоколОбмена Value
            {
                get
                {
                    return (ПротоколОбмена)base.Value;
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
