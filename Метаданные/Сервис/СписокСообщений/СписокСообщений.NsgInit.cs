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
    
    [NsgTypeName("NsgDataDictionary", Guid = "0c9303d1-e7bf-4dd7-ac9a-5f77ace2cce9")]
    public partial class СписокСообщений : NsgSoft.DataObjects.NsgDataDictionary
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
        protected СписокСообщений()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected СписокСообщений(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static СписокСообщений Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("0c9303d1-e7bf-4dd7-ac9a-5f77ace2cce9"));
            if (obj == null)
                obj = new СписокСообщений();
            return obj as СписокСообщений;
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
	Идентификатор.Guid = NsgService.StringToGuid("8066249e-2c50-47a0-ae65-b6dc03edd97e");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("c54c0885-f5bb-4cc9-85c1-8982159994fa");
	
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
	ЭтоГруппа.Guid = NsgService.StringToGuid("b14eb73c-51c9-445f-a3d6-8dd4c885833d");
	
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
	ИдентификаторРодителя.Guid = NsgService.StringToGuid("1387e81e-023d-4d56-b200-e1de6c0c6d64");
	
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
	Уровень.Guid = NsgService.StringToGuid("1f155eae-e083-424d-b280-869c01d57728");
	
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
	ПрефиксКода.Guid = NsgService.StringToGuid("a4990bbf-6661-4110-a89e-2733757f953f");
	
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
	НомерКода.Guid = NsgService.StringToGuid("627b692b-e28f-4f97-805c-58c2f4542b3e");
	
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
	Код.Guid = NsgService.StringToGuid("91b1d8db-f99b-4664-a46e-071321a9cf7d");
	
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
	СостояниеДокумента.Guid = NsgService.StringToGuid("393388f3-5a83-4969-99a7-79613fd2d798");
	
				if (!ObjectList.Contains("СостояниеДокумента"))
                    ObjectList.Add(СостояниеДокумента);
			}
			#endregion //создание Сервис.СостоянияОбъекта СостояниеДокумента
			
			#region создание Сервис.ТипСообщения ТипСообщения
			{  
                NsgDataEnumReference ТипСообщения = null;
				if (ObjectList.Contains("ТипСообщения"))
                    ТипСообщения = ObjectList["ТипСообщения"] as NsgDataEnumReference;
                else
                    ТипСообщения = new NsgDataEnumReference();
	//NsgDataEnumReference
	ТипСообщения.IsLoadedFromDll = true;
	ТипСообщения.ReferentGroup = "Сервис";
	ТипСообщения.ReferentName = "ТипСообщения";
	ТипСообщения.SaveInDatabase = true;
	ТипСообщения.OwnerName = "";
	ТипСообщения.AllowEmptyOwner = false;
	ТипСообщения.StringFormat = "";
	ТипСообщения.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ТипСообщения.IncludeInPredefined = false;
	ТипСообщения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТипСообщения.Required = false;
	ТипСообщения.EmptyValue = "";
	ТипСообщения.NullAllow = false;
	ТипСообщения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТипСообщения.FieldName = "_MsgType";
	ТипСообщения.InformMetaDataOnValueChanged = false;
	ТипСообщения.Visible = true;
	ТипСообщения.Name = "ТипСообщения";
	ТипСообщения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Тип сообщения"});
	ТипСообщения.Description = "Тип сообщения";
	ТипСообщения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ТипСообщения.GroupName = "";
	ТипСообщения.Guid = NsgService.StringToGuid("d8a71fe8-5e7d-44ca-abc6-4d1fea7b9451");
	
				if (!ObjectList.Contains("ТипСообщения"))
                    ObjectList.Add(ТипСообщения);
			}
			#endregion //создание Сервис.ТипСообщения ТипСообщения
			
			#region создание System.String ТекстСообщения
			{  
                NsgDataString ТекстСообщения = null;
				if (ObjectList.Contains("ТекстСообщения"))
                    ТекстСообщения = ObjectList["ТекстСообщения"] as NsgDataString;
                else
                    ТекстСообщения = new NsgDataString();
	//NsgDataString
	ТекстСообщения.IsLoadedFromDll = true;
	ТекстСообщения.Length = 100;
	ТекстСообщения.StringFormat = "";
	ТекстСообщения.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ТекстСообщения.IncludeInPredefined = false;
	ТекстСообщения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ТекстСообщения.Required = false;
	ТекстСообщения.EmptyValue = "";
	ТекстСообщения.NullAllow = false;
	ТекстСообщения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ТекстСообщения.FieldName = "_MsgText";
	ТекстСообщения.SaveInDatabase = true;
	ТекстСообщения.InformMetaDataOnValueChanged = false;
	ТекстСообщения.Visible = true;
	ТекстСообщения.Name = "ТекстСообщения";
	ТекстСообщения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Текст сообщения"});
	ТекстСообщения.Description = "Текст сообщения";
	ТекстСообщения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ТекстСообщения.GroupName = "";
	ТекстСообщения.Guid = NsgService.StringToGuid("440fa052-2095-4fda-b83b-eff15d81624f");
	
				if (!ObjectList.Contains("ТекстСообщения"))
                    ObjectList.Add(ТекстСообщения);
			}
			#endregion //создание System.String ТекстСообщения
			
			#region создание NsgSoft.DataObjects.NsgReferencedObject ОбъектСообщения
			{  
                NsgDataUntypedReference ОбъектСообщения = null;
				if (ObjectList.Contains("ОбъектСообщения"))
                    ОбъектСообщения = ObjectList["ОбъектСообщения"] as NsgDataUntypedReference;
                else
                    ОбъектСообщения = new NsgDataUntypedReference();
	//NsgDataUntypedReference
	ОбъектСообщения.IsLoadedFromDll = true;
	ОбъектСообщения.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.Type;
	ОбъектСообщения.FilterForConfigurator = "NsgDataDocument,NsgDataDictionary";
	ОбъектСообщения.ReferentName = "";
	ОбъектСообщения.ReferentGroup = "";
	ОбъектСообщения.TypeSelectorName = "";
	ОбъектСообщения.SaveInDatabase = true;
	ОбъектСообщения.OwnerName = "";
	ОбъектСообщения.AllowEmptyOwner = false;
	ОбъектСообщения.StringFormat = "";
	ОбъектСообщения.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ОбъектСообщения.IncludeInPredefined = false;
	ОбъектСообщения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбъектСообщения.Required = false;
	ОбъектСообщения.EmptyValue = "";
	ОбъектСообщения.NullAllow = false;
	ОбъектСообщения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОбъектСообщения.FieldName = "ObektSoobschenija";
	ОбъектСообщения.InformMetaDataOnValueChanged = false;
	ОбъектСообщения.Visible = true;
	ОбъектСообщения.Name = "ОбъектСообщения";
	ОбъектСообщения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Объект, приложенный к сообщению"});
	ОбъектСообщения.Description = "Объект, приложенный к сообщению";
	ОбъектСообщения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	ОбъектСообщения.GroupName = "";
	ОбъектСообщения.Guid = NsgService.StringToGuid("004dbf11-5ff5-4e6d-99ea-c602192b7d5b");
	
				if (!ObjectList.Contains("ОбъектСообщения"))
                    ObjectList.Add(ОбъектСообщения);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject ОбъектСообщения
			
			#region создание Сервис.Пользователи АдресатСообщения
			{  
                NsgDataTypedReference АдресатСообщения = null;
				if (ObjectList.Contains("АдресатСообщения"))
                    АдресатСообщения = ObjectList["АдресатСообщения"] as NsgDataTypedReference;
                else
                    АдресатСообщения = new NsgDataTypedReference();
	//NsgDataTypedReference
	АдресатСообщения.IsLoadedFromDll = true;
	АдресатСообщения.ReferentGroup = "Сервис";
	АдресатСообщения.ReferentName = "Пользователи";
	АдресатСообщения.SaveInDatabase = true;
	АдресатСообщения.OwnerName = "";
	АдресатСообщения.AllowEmptyOwner = false;
	АдресатСообщения.StringFormat = "";
	АдресатСообщения.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	АдресатСообщения.IncludeInPredefined = false;
	АдресатСообщения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	АдресатСообщения.Required = false;
	АдресатСообщения.EmptyValue = "";
	АдресатСообщения.NullAllow = false;
	АдресатСообщения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	АдресатСообщения.FieldName = "_MsgReceiver";
	АдресатСообщения.InformMetaDataOnValueChanged = false;
	АдресатСообщения.Visible = true;
	АдресатСообщения.Name = "АдресатСообщения";
	АдресатСообщения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Адресат сообщения"});
	АдресатСообщения.Description = "Адресат сообщения";
	АдресатСообщения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	АдресатСообщения.GroupName = "";
	АдресатСообщения.Guid = NsgService.StringToGuid("fb4c9ace-a36d-493b-b0c8-559769da1f1c");
	
				if (!ObjectList.Contains("АдресатСообщения"))
                    ObjectList.Add(АдресатСообщения);
			}
			#endregion //создание Сервис.Пользователи АдресатСообщения
			
			#region создание System.DateTime АктуальностьСообщения
			{  
                NsgDataDateTime АктуальностьСообщения = null;
				if (ObjectList.Contains("АктуальностьСообщения"))
                    АктуальностьСообщения = ObjectList["АктуальностьСообщения"] as NsgDataDateTime;
                else
                    АктуальностьСообщения = new NsgDataDateTime();
	//NsgDataDateTime
	АктуальностьСообщения.IsLoadedFromDll = true;
	АктуальностьСообщения.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	АктуальностьСообщения.StringFormat = "";
	АктуальностьСообщения.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	АктуальностьСообщения.IncludeInPredefined = false;
	АктуальностьСообщения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	АктуальностьСообщения.Required = false;
	АктуальностьСообщения.EmptyValue = "";
	АктуальностьСообщения.NullAllow = false;
	АктуальностьСообщения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	АктуальностьСообщения.FieldName = "_MsgActualDate";
	АктуальностьСообщения.SaveInDatabase = true;
	АктуальностьСообщения.InformMetaDataOnValueChanged = false;
	АктуальностьСообщения.Visible = true;
	АктуальностьСообщения.Name = "АктуальностьСообщения";
	АктуальностьСообщения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Актуальность сообщения"});
	АктуальностьСообщения.Description = "Актуальность сообщения";
	АктуальностьСообщения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	АктуальностьСообщения.GroupName = "";
	АктуальностьСообщения.Guid = NsgService.StringToGuid("be1fc801-9e76-46b6-8cb9-11d34143d270");
	
				if (!ObjectList.Contains("АктуальностьСообщения"))
                    ObjectList.Add(АктуальностьСообщения);
			}
			#endregion //создание System.DateTime АктуальностьСообщения
			
			#region создание System.DateTime ВремяПоявленияСообщения
			{  
                NsgDataDateTime ВремяПоявленияСообщения = null;
				if (ObjectList.Contains("ВремяПоявленияСообщения"))
                    ВремяПоявленияСообщения = ObjectList["ВремяПоявленияСообщения"] as NsgDataDateTime;
                else
                    ВремяПоявленияСообщения = new NsgDataDateTime();
	//NsgDataDateTime
	ВремяПоявленияСообщения.IsLoadedFromDll = true;
	ВремяПоявленияСообщения.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ВремяПоявленияСообщения.StringFormat = "";
	ВремяПоявленияСообщения.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	ВремяПоявленияСообщения.IncludeInPredefined = false;
	ВремяПоявленияСообщения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВремяПоявленияСообщения.Required = false;
	ВремяПоявленияСообщения.EmptyValue = "";
	ВремяПоявленияСообщения.NullAllow = false;
	ВремяПоявленияСообщения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ВремяПоявленияСообщения.FieldName = "_MsgStartedDate";
	ВремяПоявленияСообщения.SaveInDatabase = true;
	ВремяПоявленияСообщения.InformMetaDataOnValueChanged = false;
	ВремяПоявленияСообщения.Visible = true;
	ВремяПоявленияСообщения.Name = "ВремяПоявленияСообщения";
	ВремяПоявленияСообщения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Время появления сообщения"});
	ВремяПоявленияСообщения.Description = "Время появления сообщения";
	ВремяПоявленияСообщения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ВремяПоявленияСообщения.GroupName = "";
	ВремяПоявленияСообщения.Guid = NsgService.StringToGuid("17a37be0-c8a0-4577-930a-3b10ff700feb");
	
				if (!ObjectList.Contains("ВремяПоявленияСообщения"))
                    ObjectList.Add(ВремяПоявленияСообщения);
			}
			#endregion //создание System.DateTime ВремяПоявленияСообщения
			
			#region создание System.Boolean СтатусСообщения
			{  
                NsgDataBoolean СтатусСообщения = null;
				if (ObjectList.Contains("СтатусСообщения"))
                    СтатусСообщения = ObjectList["СтатусСообщения"] as NsgDataBoolean;
                else
                    СтатусСообщения = new NsgDataBoolean();
	//NsgDataBoolean
	СтатусСообщения.IsLoadedFromDll = true;
	СтатусСообщения.DefaultValue = false;
	СтатусСообщения.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СтатусСообщения.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СтатусСообщения.StringFormat = "";
	СтатусСообщения.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	СтатусСообщения.IncludeInPredefined = false;
	СтатусСообщения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СтатусСообщения.Required = false;
	СтатусСообщения.EmptyValue = "";
	СтатусСообщения.NullAllow = false;
	СтатусСообщения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СтатусСообщения.FieldName = "_MsgStatus";
	СтатусСообщения.SaveInDatabase = true;
	СтатусСообщения.InformMetaDataOnValueChanged = false;
	СтатусСообщения.Visible = true;
	СтатусСообщения.Name = "СтатусСообщения";
	СтатусСообщения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Статус сообщения посланного в системе"});
	СтатусСообщения.Description = "Статус сообщения посланного в системе";
	СтатусСообщения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	СтатусСообщения.GroupName = "";
	СтатусСообщения.Guid = NsgService.StringToGuid("38aa5d0e-4438-4dd9-80d0-69abb80416e8");
	
				if (!ObjectList.Contains("СтатусСообщения"))
                    ObjectList.Add(СтатусСообщения);
			}
			#endregion //создание System.Boolean СтатусСообщения
			
			#region создание Сервис.Пользователи АвторСообщения
			{  
                NsgDataTypedReference АвторСообщения = null;
				if (ObjectList.Contains("АвторСообщения"))
                    АвторСообщения = ObjectList["АвторСообщения"] as NsgDataTypedReference;
                else
                    АвторСообщения = new NsgDataTypedReference();
	//NsgDataTypedReference
	АвторСообщения.IsLoadedFromDll = true;
	АвторСообщения.ReferentGroup = "Сервис";
	АвторСообщения.ReferentName = "Пользователи";
	АвторСообщения.SaveInDatabase = true;
	АвторСообщения.OwnerName = "";
	АвторСообщения.AllowEmptyOwner = false;
	АвторСообщения.StringFormat = "";
	АвторСообщения.SubType = NsgSoft.Common.NsgRekvisitSubType.Element;
	АвторСообщения.IncludeInPredefined = false;
	АвторСообщения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	АвторСообщения.Required = false;
	АвторСообщения.EmptyValue = "";
	АвторСообщения.NullAllow = false;
	АвторСообщения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	АвторСообщения.FieldName = "_MsgAuthor";
	АвторСообщения.InformMetaDataOnValueChanged = false;
	АвторСообщения.Visible = true;
	АвторСообщения.Name = "АвторСообщения";
	АвторСообщения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Автор сообщения"});
	АвторСообщения.Description = "Автор сообщения";
	АвторСообщения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	АвторСообщения.GroupName = "";
	АвторСообщения.Guid = NsgService.StringToGuid("1b1fc6fa-2498-457c-a730-25067c7ffdc6");
	
				if (!ObjectList.Contains("АвторСообщения"))
                    ObjectList.Add(АвторСообщения);
			}
			#endregion //создание Сервис.Пользователи АвторСообщения
			
			#region создание NsgSoft.Forms.NsgMailMessageListForm ФормаСписка
			{  
                NsgDataForm ФормаСписка = null;
				if (ObjectList.Contains("ФормаСписка"))
                    ФормаСписка = ObjectList["ФормаСписка"] as NsgDataForm;
                else
                    ФормаСписка = new NsgDataForm();
	//NsgDataForm
	ФормаСписка.IsLoadedFromDll = true;
	ФормаСписка.FormClassName = "NsgSoft.Forms.NsgMailMessageListForm";
	ФормаСписка.SaveInDatabase = false;
	ФормаСписка.StringFormat = "";
	ФормаСписка.SubType = NsgSoft.Common.NsgRekvisitSubType.ListForm;
	ФормаСписка.IncludeInPredefined = false;
	ФормаСписка.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ФормаСписка.Required = false;
	ФормаСписка.EmptyValue = "";
	ФормаСписка.NullAllow = false;
	ФормаСписка.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ФормаСписка.FieldName = "FormaSpiska";
	ФормаСписка.InformMetaDataOnValueChanged = false;
	ФормаСписка.Visible = true;
	ФормаСписка.Name = "ФормаСписка";
	ФормаСписка.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ФормаСписка.Description = "Форма списка";
	ФормаСписка.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ФормаСписка.GroupName = "";
	ФормаСписка.Guid = NsgService.StringToGuid("6808087c-67a4-4d1a-9e3f-96c8a0bad4a4");
	
				if (!ObjectList.Contains("ФормаСписка"))
                    ObjectList.Add(ФормаСписка);
			}
			#endregion //создание NsgSoft.Forms.NsgMailMessageListForm ФормаСписка
			
			#region создание NsgSoft.Forms.NsgMailMessageForm ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "NsgSoft.Forms.NsgMailMessageForm";
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
	ФормаЭлемента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ФормаЭлемента.GroupName = "";
	ФормаЭлемента.Guid = NsgService.StringToGuid("50b32c21-c245-4216-8c1c-6699dd68ad70");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание NsgSoft.Forms.NsgMailMessageForm ФормаЭлемента
			

			#region заполнение полей класса
				//NsgDataDictionary
	IsLoadedFromDll = true;
	DefaultGroupFormName = "";
	SearchFieldName = "Код";
	PeriodicTable = "";
	MaxGroupLevel = 1;
	HasOwner = false;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "СписокСообщений";
	Visible = true;
	Guid = NsgService.StringToGuid("0c9303d1-e7bf-4dd7-ac9a-5f77ace2cce9");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "MessageList";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Список сообщений"});
	Description = "Список сообщений";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
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
            /// Тип сообщения
            /// </summary>
            public static String ТипСообщения
            {
                get
                {
                    return "ТипСообщения";
                }
            }
            
            /// <summary>
            /// Текст сообщения
            /// </summary>
            public static String ТекстСообщения
            {
                get
                {
                    return "ТекстСообщения";
                }
            }
            
            /// <summary>
            /// Объект, приложенный к сообщению
            /// </summary>
            public static String ОбъектСообщения
            {
                get
                {
                    return "ОбъектСообщения";
                }
            }
            
            /// <summary>
            /// Адресат сообщения
            /// </summary>
            public static String АдресатСообщения
            {
                get
                {
                    return "АдресатСообщения";
                }
            }
            
            /// <summary>
            /// Актуальность сообщения
            /// </summary>
            public static String АктуальностьСообщения
            {
                get
                {
                    return "АктуальностьСообщения";
                }
            }
            
            /// <summary>
            /// Время появления сообщения
            /// </summary>
            public static String ВремяПоявленияСообщения
            {
                get
                {
                    return "ВремяПоявленияСообщения";
                }
            }
            
            /// <summary>
            /// Статус сообщения посланного в системе
            /// </summary>
            public static String СтатусСообщения
            {
                get
                {
                    return "СтатусСообщения";
                }
            }
            
            /// <summary>
            /// Автор сообщения
            /// </summary>
            public static String АвторСообщения
            {
                get
                {
                    return "АвторСообщения";
                }
            }
            
            /// <summary>
            /// Форма списка
            /// </summary>
            public static String ФормаСписка
            {
                get
                {
                    return "ФормаСписка";
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
            
        }

        #endregion // Имена

        #region Свойства
        public static string GetFullName()
        {
            return "Сервис.СписокСообщений";
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
        /// Тип сообщения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.ТипСообщения ТипСообщения
        {
            get
            {
				 NsgDataEnumReference __ТипСообщения = ObjectList["ТипСообщения"] as NsgDataEnumReference;
                 return (Сервис.ТипСообщения)__ТипСообщения.Referent;
            }
            set
            {
                NsgDataEnumReference __ТипСообщения = ObjectList["ТипСообщения"] as NsgDataEnumReference;
                __ТипСообщения.Referent = value;
            }
        }
        
        /// <summary>
        /// Текст сообщения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ТекстСообщения
        {
            get
            {
				 NsgDataString __ТекстСообщения = ObjectList["ТекстСообщения"] as NsgDataString;
                 return (System.String)__ТекстСообщения.Value;
            }
            set
            {
                NsgDataString __ТекстСообщения = ObjectList["ТекстСообщения"] as NsgDataString;
                __ТекстСообщения.Value = value;
            }
        }
        
        /// <summary>
        /// Объект, приложенный к сообщению
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("NsgDataDocument,NsgDataDictionary")]
        public NsgSoft.DataObjects.NsgReferencedObject ОбъектСообщения
        {
            get
            {
				 NsgDataUntypedReference __ОбъектСообщения = ObjectList["ОбъектСообщения"] as NsgDataUntypedReference;
                 return (NsgSoft.DataObjects.NsgReferencedObject)__ОбъектСообщения.Referent;
            }
            set
            {
                NsgDataUntypedReference __ОбъектСообщения = ObjectList["ОбъектСообщения"] as NsgDataUntypedReference;
                __ОбъектСообщения.Referent = value;
            }
        }
        
        /// <summary>
        /// Адресат сообщения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Сервис.Пользователи АдресатСообщения
        {
            get
            {
				 NsgDataTypedReference __АдресатСообщения = ObjectList["АдресатСообщения"] as NsgDataTypedReference;
                 return (Сервис.Пользователи)__АдресатСообщения.Referent;
            }
            set
            {
                NsgDataTypedReference __АдресатСообщения = ObjectList["АдресатСообщения"] as NsgDataTypedReference;
                __АдресатСообщения.Referent = value;
            }
        }
        
        /// <summary>
        /// Актуальность сообщения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime АктуальностьСообщения
        {
            get
            {
				 NsgDataDateTime __АктуальностьСообщения = ObjectList["АктуальностьСообщения"] as NsgDataDateTime;
                 return (System.DateTime)__АктуальностьСообщения.Value;
            }
            set
            {
                NsgDataDateTime __АктуальностьСообщения = ObjectList["АктуальностьСообщения"] as NsgDataDateTime;
                __АктуальностьСообщения.Value = value;
            }
        }
        
        /// <summary>
        /// Время появления сообщения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ВремяПоявленияСообщения
        {
            get
            {
				 NsgDataDateTime __ВремяПоявленияСообщения = ObjectList["ВремяПоявленияСообщения"] as NsgDataDateTime;
                 return (System.DateTime)__ВремяПоявленияСообщения.Value;
            }
            set
            {
                NsgDataDateTime __ВремяПоявленияСообщения = ObjectList["ВремяПоявленияСообщения"] as NsgDataDateTime;
                __ВремяПоявленияСообщения.Value = value;
            }
        }
        
        /// <summary>
        /// Статус сообщения посланного в системе
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean СтатусСообщения
        {
            get
            {
				 NsgDataBoolean __СтатусСообщения = ObjectList["СтатусСообщения"] as NsgDataBoolean;
                 return (System.Boolean)__СтатусСообщения.Value;
            }
            set
            {
                NsgDataBoolean __СтатусСообщения = ObjectList["СтатусСообщения"] as NsgDataBoolean;
                __СтатусСообщения.Value = value;
            }
        }
        
        /// <summary>
        /// Автор сообщения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Сервис.Пользователи АвторСообщения
        {
            get
            {
				 NsgDataTypedReference __АвторСообщения = ObjectList["АвторСообщения"] as NsgDataTypedReference;
                 return (Сервис.Пользователи)__АвторСообщения.Referent;
            }
            set
            {
                NsgDataTypedReference __АвторСообщения = ObjectList["АвторСообщения"] as NsgDataTypedReference;
                __АвторСообщения.Referent = value;
            }
        }
        

        
        /// <summary>
        /// Форма списка
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataForm")]
        
        public INsgObjectForm ФормаСписка
        {
            get
            {
                INsgObjectForm res = null;
                if (ObjectList["ФормаСписка"].SubType == NsgRekvisitSubType.ListForm)
                   res = NsgSettings.MainForm.GetObjectListForm(this,"ФормаСписка");
                else
                   res = NsgSettings.MainForm.GetObjectForm(this,"ФормаСписка");
                return res;
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
        
        #region Свойства NsgSoft.DataObjects.NsgDataDictionary
        

        /// <summary>
		/// Родитель для данного элемента справочника
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        public СписокСообщений Родитель
        {
            get
            {
                return base.Parent as СписокСообщений;
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
        private СписокСообщений[] convertArray(NsgMultipleObject[] array)
        {
            СписокСообщений[] res = new СписокСообщений[array.Length];
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
        public new virtual СписокСообщений[] FindAll(NsgCompare compare)
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
        public new virtual СписокСообщений[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual СписокСообщений[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual СписокСообщений[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new СписокСообщений(this as NsgObject);
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
                base.NSGType = typeof(СписокСообщений);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new СписокСообщений Value
            {
                get
                {
                    return (СписокСообщений)base.Value;
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
