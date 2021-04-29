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
    
    [NsgTypeName("NsgDataCharacteristics", Guid = "118e3ca1-dca9-4989-a777-3eafcb46cac2")]
    public partial class ПраваПользователей : NsgSoft.DataObjects.NsgDataCharacteristics
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataCharacteristics
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataCharacteristics

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataCharacteristics
        

		/// <summary>
        /// Конструктор для проведения документов, передается проводимый документ.
        /// </summary>
        public static ПраваПользователей Новый(NsgDataDocument document)
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("118e3ca1-dca9-4989-a777-3eafcb46cac2"));
            if (obj == null)
                obj = new ПраваПользователей();
            (obj as ПраваПользователей).Document = document;
            return obj as ПраваПользователей;
        }
		



        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataCharacteristics

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected ПраваПользователей()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ПраваПользователей(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ПраваПользователей Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("118e3ca1-dca9-4989-a777-3eafcb46cac2"));
            if (obj == null)
                obj = new ПраваПользователей();
            return obj as ПраваПользователей;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataCharacteristics
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataCharacteristics
			
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
	Идентификатор.Guid = NsgService.StringToGuid("32f71c7e-3898-402e-adaf-a726c28faec4");
	
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
	Автоинкремент.Guid = NsgService.StringToGuid("7c20254d-7e25-4e19-82c0-fb523c558227");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание _SystemTables.СервисПраваПользователейДвижения Движения
			{  
                NsgRegisterTable Движения = null;
				if (ObjectList.Contains("Движения"))
                    Движения = ObjectList["Движения"] as NsgRegisterTable;
                else
                    Движения = new NsgRegisterTable();
	//NsgRegisterTable
	Движения.IsLoadedFromDll = true;
	Движения.Name = "Движения";
	Движения.RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	Движения.RegisterPeriodCount = 1;
	Движения.ReferentGroup = "_SystemTables";
	Движения.ReferentName = "СервисПраваПользователейДвижения";
	Движения.SaveInDatabase = false;
	Движения.OwnerName = "";
	Движения.AllowEmptyOwner = false;
	Движения.StringFormat = "";
	Движения.SubType = NsgSoft.Common.NsgRekvisitSubType.TabCharacteristics;
	Движения.IncludeInPredefined = false;
	Движения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Движения.Required = false;
	Движения.EmptyValue = "";
	Движения.NullAllow = false;
	Движения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Движения.FieldName = "Dvizhenija";
	Движения.InformMetaDataOnValueChanged = false;
	Движения.Visible = true;
	Движения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Движения.Description = "Движения";
	Движения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.NonRemovable;
	Движения.GroupName = "";
	Движения.Guid = NsgService.StringToGuid("0a8c4a4d-b45d-45e5-a9e3-2cb296b12130");
	
				if (!ObjectList.Contains("Движения"))
                    ObjectList.Add(Движения);
			}
			#endregion //создание _SystemTables.СервисПраваПользователейДвижения Движения
			
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
	Владелец.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Владелец.GroupName = "";
	Владелец.Guid = NsgService.StringToGuid("e6cc9af6-76a3-4417-ba29-a738955157e7");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
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
	Пользователь.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Пользователь.IncludeInPredefined = false;
	Пользователь.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Пользователь.Required = false;
	Пользователь.EmptyValue = "";
	Пользователь.NullAllow = false;
	Пользователь.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Пользователь.FieldName = "Polzovatel";
	Пользователь.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Пользователь.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Пользователь.CharactericticWeight = 1;
	Пользователь.InformMetaDataOnValueChanged = false;
	Пользователь.Visible = true;
	Пользователь.Name = "Пользователь";
	Пользователь.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Пользователь.Description = "Пользователь";
	Пользователь.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Пользователь.GroupName = "";
	Пользователь.Guid = NsgService.StringToGuid("8070e441-55a0-4306-8459-9610c1fcb0ab");
	
				if (!ObjectList.Contains("Пользователь"))
                    ObjectList.Add(Пользователь);
			}
			#endregion //создание Сервис.Пользователи Пользователь
			
			#region создание NsgSoft.DataObjects.NsgReferencedObject ОбъектМетаданных
			{  
                NsgReferencedObjectSelector ОбъектМетаданных = null;
				if (ObjectList.Contains("ОбъектМетаданных"))
                    ОбъектМетаданных = ObjectList["ОбъектМетаданных"] as NsgReferencedObjectSelector;
                else
                    ОбъектМетаданных = new NsgReferencedObjectSelector();
	//NsgReferencedObjectSelector
	ОбъектМетаданных.IsLoadedFromDll = true;
	ОбъектМетаданных.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.None;
	ОбъектМетаданных.FilterForConfigurator = "";
	ОбъектМетаданных.ReferentName = "";
	ОбъектМетаданных.ReferentGroup = "";
	ОбъектМетаданных.TypeSelectorName = "";
	ОбъектМетаданных.SaveInDatabase = true;
	ОбъектМетаданных.OwnerName = "";
	ОбъектМетаданных.AllowEmptyOwner = false;
	ОбъектМетаданных.StringFormat = "";
	ОбъектМетаданных.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	ОбъектМетаданных.IncludeInPredefined = false;
	ОбъектМетаданных.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОбъектМетаданных.Required = false;
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
	ОбъектМетаданных.Guid = NsgService.StringToGuid("db2238f1-ca6f-423f-b79c-edf99a039d9c");
	
				if (!ObjectList.Contains("ОбъектМетаданных"))
                    ObjectList.Add(ОбъектМетаданных);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject ОбъектМетаданных
			
			#region создание System.String Условие
			{  
                NsgDataString Условие = null;
				if (ObjectList.Contains("Условие"))
                    Условие = ObjectList["Условие"] as NsgDataString;
                else
                    Условие = new NsgDataString();
	//NsgDataString
	Условие.IsLoadedFromDll = true;
	Условие.Length = 0;
	Условие.StringFormat = "";
	Условие.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Условие.IncludeInPredefined = false;
	Условие.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Условие.Required = false;
	Условие.EmptyValue = "";
	Условие.NullAllow = false;
	Условие.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
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
	Условие.Guid = NsgService.StringToGuid("f46a278c-89e3-4710-b13d-69a6643bbf93");
	
				if (!ObjectList.Contains("Условие"))
                    ObjectList.Add(Условие);
			}
			#endregion //создание System.String Условие
			
			#region создание System.Boolean НеНаследуетУсловияРодителя
			{  
                NsgDataBoolean НеНаследуетУсловияРодителя = null;
				if (ObjectList.Contains("НеНаследуетУсловияРодителя"))
                    НеНаследуетУсловияРодителя = ObjectList["НеНаследуетУсловияРодителя"] as NsgDataBoolean;
                else
                    НеНаследуетУсловияРодителя = new NsgDataBoolean();
	//NsgDataBoolean
	НеНаследуетУсловияРодителя.IsLoadedFromDll = true;
	НеНаследуетУсловияРодителя.DefaultValue = true;
	НеНаследуетУсловияРодителя.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НеНаследуетУсловияРодителя.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НеНаследуетУсловияРодителя.StringFormat = "";
	НеНаследуетУсловияРодителя.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	НеНаследуетУсловияРодителя.IncludeInPredefined = false;
	НеНаследуетУсловияРодителя.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	НеНаследуетУсловияРодителя.Required = false;
	НеНаследуетУсловияРодителя.EmptyValue = "";
	НеНаследуетУсловияРодителя.NullAllow = false;
	НеНаследуетУсловияРодителя.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	НеНаследуетУсловияРодителя.FieldName = "_NoInheritCompare";
	НеНаследуетУсловияРодителя.SaveInDatabase = true;
	НеНаследуетУсловияРодителя.InformMetaDataOnValueChanged = false;
	НеНаследуетУсловияРодителя.Visible = true;
	НеНаследуетУсловияРодителя.Name = "НеНаследуетУсловияРодителя";
	НеНаследуетУсловияРодителя.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	НеНаследуетУсловияРодителя.Description = "Не наследует условия родителя";
	НеНаследуетУсловияРодителя.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	НеНаследуетУсловияРодителя.GroupName = "";
	НеНаследуетУсловияРодителя.Guid = NsgService.StringToGuid("c147427f-2e8e-4ef7-a77e-4494d4cf53a7");
	
				if (!ObjectList.Contains("НеНаследуетУсловияРодителя"))
                    ObjectList.Add(НеНаследуетУсловияРодителя);
			}
			#endregion //создание System.Boolean НеНаследуетУсловияРодителя
			
			#region создание Сервис.РазрешениеОперацииПользователя Чтение
			{  
                NsgDataEnumReference Чтение = null;
				if (ObjectList.Contains("Чтение"))
                    Чтение = ObjectList["Чтение"] as NsgDataEnumReference;
                else
                    Чтение = new NsgDataEnumReference();
	//NsgDataEnumReference
	Чтение.IsLoadedFromDll = true;
	Чтение.ReferentGroup = "Сервис";
	Чтение.ReferentName = "РазрешениеОперацииПользователя";
	Чтение.SaveInDatabase = true;
	Чтение.OwnerName = "";
	Чтение.AllowEmptyOwner = false;
	Чтение.StringFormat = "";
	Чтение.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Чтение.IncludeInPredefined = false;
	Чтение.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Чтение.Required = false;
	Чтение.EmptyValue = "";
	Чтение.NullAllow = false;
	Чтение.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Чтение.FieldName = "CHtenie";
	Чтение.InformMetaDataOnValueChanged = false;
	Чтение.Visible = true;
	Чтение.Name = "Чтение";
	Чтение.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Чтение.Description = "Чтение";
	Чтение.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Чтение.GroupName = "";
	Чтение.Guid = NsgService.StringToGuid("2748469a-66bf-469e-bfb2-c751b5450ebd");
	
				if (!ObjectList.Contains("Чтение"))
                    ObjectList.Add(Чтение);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя Чтение
			
			#region создание Сервис.РазрешениеОперацииПользователя Добавление
			{  
                NsgDataEnumReference Добавление = null;
				if (ObjectList.Contains("Добавление"))
                    Добавление = ObjectList["Добавление"] as NsgDataEnumReference;
                else
                    Добавление = new NsgDataEnumReference();
	//NsgDataEnumReference
	Добавление.IsLoadedFromDll = true;
	Добавление.ReferentGroup = "Сервис";
	Добавление.ReferentName = "РазрешениеОперацииПользователя";
	Добавление.SaveInDatabase = true;
	Добавление.OwnerName = "";
	Добавление.AllowEmptyOwner = false;
	Добавление.StringFormat = "";
	Добавление.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Добавление.IncludeInPredefined = false;
	Добавление.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Добавление.Required = false;
	Добавление.EmptyValue = "";
	Добавление.NullAllow = false;
	Добавление.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Добавление.FieldName = "Dobavlenie";
	Добавление.InformMetaDataOnValueChanged = false;
	Добавление.Visible = true;
	Добавление.Name = "Добавление";
	Добавление.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Добавление.Description = "Добавление";
	Добавление.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Добавление.GroupName = "";
	Добавление.Guid = NsgService.StringToGuid("4f841fee-f008-4708-bd63-75328f3de32c");
	
				if (!ObjectList.Contains("Добавление"))
                    ObjectList.Add(Добавление);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя Добавление
			
			#region создание Сервис.РазрешениеОперацииПользователя Изменение
			{  
                NsgDataEnumReference Изменение = null;
				if (ObjectList.Contains("Изменение"))
                    Изменение = ObjectList["Изменение"] as NsgDataEnumReference;
                else
                    Изменение = new NsgDataEnumReference();
	//NsgDataEnumReference
	Изменение.IsLoadedFromDll = true;
	Изменение.ReferentGroup = "Сервис";
	Изменение.ReferentName = "РазрешениеОперацииПользователя";
	Изменение.SaveInDatabase = true;
	Изменение.OwnerName = "";
	Изменение.AllowEmptyOwner = false;
	Изменение.StringFormat = "";
	Изменение.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Изменение.IncludeInPredefined = false;
	Изменение.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Изменение.Required = false;
	Изменение.EmptyValue = "";
	Изменение.NullAllow = false;
	Изменение.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Изменение.FieldName = "Izmenenie";
	Изменение.InformMetaDataOnValueChanged = false;
	Изменение.Visible = true;
	Изменение.Name = "Изменение";
	Изменение.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Изменение.Description = "Изменение";
	Изменение.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Изменение.GroupName = "";
	Изменение.Guid = NsgService.StringToGuid("7780574f-e37a-4f72-914f-9d35376b4805");
	
				if (!ObjectList.Contains("Изменение"))
                    ObjectList.Add(Изменение);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя Изменение
			
			#region создание Сервис.РазрешениеОперацииПользователя Удаление
			{  
                NsgDataEnumReference Удаление = null;
				if (ObjectList.Contains("Удаление"))
                    Удаление = ObjectList["Удаление"] as NsgDataEnumReference;
                else
                    Удаление = new NsgDataEnumReference();
	//NsgDataEnumReference
	Удаление.IsLoadedFromDll = true;
	Удаление.ReferentGroup = "Сервис";
	Удаление.ReferentName = "РазрешениеОперацииПользователя";
	Удаление.SaveInDatabase = true;
	Удаление.OwnerName = "";
	Удаление.AllowEmptyOwner = false;
	Удаление.StringFormat = "";
	Удаление.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Удаление.IncludeInPredefined = false;
	Удаление.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Удаление.Required = false;
	Удаление.EmptyValue = "";
	Удаление.NullAllow = false;
	Удаление.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Удаление.FieldName = "Udalenie";
	Удаление.InformMetaDataOnValueChanged = false;
	Удаление.Visible = true;
	Удаление.Name = "Удаление";
	Удаление.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Удаление.Description = "Удаление";
	Удаление.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Удаление.GroupName = "";
	Удаление.Guid = NsgService.StringToGuid("54e38809-58c9-46a7-a2f5-03b67572a44c");
	
				if (!ObjectList.Contains("Удаление"))
                    ObjectList.Add(Удаление);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя Удаление
			
			#region создание Сервис.РазрешениеОперацииПользователя Проведение
			{  
                NsgDataEnumReference Проведение = null;
				if (ObjectList.Contains("Проведение"))
                    Проведение = ObjectList["Проведение"] as NsgDataEnumReference;
                else
                    Проведение = new NsgDataEnumReference();
	//NsgDataEnumReference
	Проведение.IsLoadedFromDll = true;
	Проведение.ReferentGroup = "Сервис";
	Проведение.ReferentName = "РазрешениеОперацииПользователя";
	Проведение.SaveInDatabase = true;
	Проведение.OwnerName = "";
	Проведение.AllowEmptyOwner = false;
	Проведение.StringFormat = "";
	Проведение.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Проведение.IncludeInPredefined = false;
	Проведение.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Проведение.Required = false;
	Проведение.EmptyValue = "";
	Проведение.NullAllow = false;
	Проведение.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Проведение.FieldName = "Provedenie";
	Проведение.InformMetaDataOnValueChanged = false;
	Проведение.Visible = true;
	Проведение.Name = "Проведение";
	Проведение.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Проведение.Description = "Проведение";
	Проведение.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Проведение.GroupName = "";
	Проведение.Guid = NsgService.StringToGuid("ebf05807-06a1-4b17-8dd5-e6c4273416b0");
	
				if (!ObjectList.Contains("Проведение"))
                    ObjectList.Add(Проведение);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя Проведение
			
			#region создание Сервис.РазрешениеОперацииПользователя ОтменаПроведения
			{  
                NsgDataEnumReference ОтменаПроведения = null;
				if (ObjectList.Contains("ОтменаПроведения"))
                    ОтменаПроведения = ObjectList["ОтменаПроведения"] as NsgDataEnumReference;
                else
                    ОтменаПроведения = new NsgDataEnumReference();
	//NsgDataEnumReference
	ОтменаПроведения.IsLoadedFromDll = true;
	ОтменаПроведения.ReferentGroup = "Сервис";
	ОтменаПроведения.ReferentName = "РазрешениеОперацииПользователя";
	ОтменаПроведения.SaveInDatabase = true;
	ОтменаПроведения.OwnerName = "";
	ОтменаПроведения.AllowEmptyOwner = false;
	ОтменаПроведения.StringFormat = "";
	ОтменаПроведения.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ОтменаПроведения.IncludeInPredefined = false;
	ОтменаПроведения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОтменаПроведения.Required = false;
	ОтменаПроведения.EmptyValue = "";
	ОтменаПроведения.NullAllow = false;
	ОтменаПроведения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОтменаПроведения.FieldName = "OtmenaProvedenija";
	ОтменаПроведения.InformMetaDataOnValueChanged = false;
	ОтменаПроведения.Visible = true;
	ОтменаПроведения.Name = "ОтменаПроведения";
	ОтменаПроведения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ОтменаПроведения.Description = "Отмена проведения";
	ОтменаПроведения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ОтменаПроведения.GroupName = "";
	ОтменаПроведения.Guid = NsgService.StringToGuid("34b62df7-4418-4ca1-bb90-dfd8785f895f");
	
				if (!ObjectList.Contains("ОтменаПроведения"))
                    ObjectList.Add(ОтменаПроведения);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя ОтменаПроведения
			
			#region создание Сервис.РазрешениеОперацииПользователя ИнтерактивныйПросмотр
			{  
                NsgDataEnumReference ИнтерактивныйПросмотр = null;
				if (ObjectList.Contains("ИнтерактивныйПросмотр"))
                    ИнтерактивныйПросмотр = ObjectList["ИнтерактивныйПросмотр"] as NsgDataEnumReference;
                else
                    ИнтерактивныйПросмотр = new NsgDataEnumReference();
	//NsgDataEnumReference
	ИнтерактивныйПросмотр.IsLoadedFromDll = true;
	ИнтерактивныйПросмотр.ReferentGroup = "Сервис";
	ИнтерактивныйПросмотр.ReferentName = "РазрешениеОперацииПользователя";
	ИнтерактивныйПросмотр.SaveInDatabase = true;
	ИнтерактивныйПросмотр.OwnerName = "";
	ИнтерактивныйПросмотр.AllowEmptyOwner = false;
	ИнтерактивныйПросмотр.StringFormat = "";
	ИнтерактивныйПросмотр.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ИнтерактивныйПросмотр.IncludeInPredefined = false;
	ИнтерактивныйПросмотр.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИнтерактивныйПросмотр.Required = false;
	ИнтерактивныйПросмотр.EmptyValue = "";
	ИнтерактивныйПросмотр.NullAllow = false;
	ИнтерактивныйПросмотр.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИнтерактивныйПросмотр.FieldName = "InteraktivnyijPro";
	ИнтерактивныйПросмотр.InformMetaDataOnValueChanged = false;
	ИнтерактивныйПросмотр.Visible = true;
	ИнтерактивныйПросмотр.Name = "ИнтерактивныйПросмотр";
	ИнтерактивныйПросмотр.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИнтерактивныйПросмотр.Description = "Интерактивный просмотр";
	ИнтерактивныйПросмотр.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ИнтерактивныйПросмотр.GroupName = "";
	ИнтерактивныйПросмотр.Guid = NsgService.StringToGuid("c69ac6af-ecc8-45a7-ac6d-b1260cb7d185");
	
				if (!ObjectList.Contains("ИнтерактивныйПросмотр"))
                    ObjectList.Add(ИнтерактивныйПросмотр);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя ИнтерактивныйПросмотр
			
			#region создание Сервис.РазрешениеОперацииПользователя ИнтерактивноеДобавление
			{  
                NsgDataEnumReference ИнтерактивноеДобавление = null;
				if (ObjectList.Contains("ИнтерактивноеДобавление"))
                    ИнтерактивноеДобавление = ObjectList["ИнтерактивноеДобавление"] as NsgDataEnumReference;
                else
                    ИнтерактивноеДобавление = new NsgDataEnumReference();
	//NsgDataEnumReference
	ИнтерактивноеДобавление.IsLoadedFromDll = true;
	ИнтерактивноеДобавление.ReferentGroup = "Сервис";
	ИнтерактивноеДобавление.ReferentName = "РазрешениеОперацииПользователя";
	ИнтерактивноеДобавление.SaveInDatabase = true;
	ИнтерактивноеДобавление.OwnerName = "";
	ИнтерактивноеДобавление.AllowEmptyOwner = false;
	ИнтерактивноеДобавление.StringFormat = "";
	ИнтерактивноеДобавление.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ИнтерактивноеДобавление.IncludeInPredefined = false;
	ИнтерактивноеДобавление.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИнтерактивноеДобавление.Required = false;
	ИнтерактивноеДобавление.EmptyValue = "";
	ИнтерактивноеДобавление.NullAllow = false;
	ИнтерактивноеДобавление.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИнтерактивноеДобавление.FieldName = "InteraktivnoeDoba";
	ИнтерактивноеДобавление.InformMetaDataOnValueChanged = false;
	ИнтерактивноеДобавление.Visible = true;
	ИнтерактивноеДобавление.Name = "ИнтерактивноеДобавление";
	ИнтерактивноеДобавление.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИнтерактивноеДобавление.Description = "Интерактивное добавление";
	ИнтерактивноеДобавление.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ИнтерактивноеДобавление.GroupName = "";
	ИнтерактивноеДобавление.Guid = NsgService.StringToGuid("e3f5f49d-b1c7-41c2-b166-5abf80cd4482");
	
				if (!ObjectList.Contains("ИнтерактивноеДобавление"))
                    ObjectList.Add(ИнтерактивноеДобавление);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя ИнтерактивноеДобавление
			
			#region создание Сервис.РазрешениеОперацииПользователя ИнтерактивноеРедактирование
			{  
                NsgDataEnumReference ИнтерактивноеРедактирование = null;
				if (ObjectList.Contains("ИнтерактивноеРедактирование"))
                    ИнтерактивноеРедактирование = ObjectList["ИнтерактивноеРедактирование"] as NsgDataEnumReference;
                else
                    ИнтерактивноеРедактирование = new NsgDataEnumReference();
	//NsgDataEnumReference
	ИнтерактивноеРедактирование.IsLoadedFromDll = true;
	ИнтерактивноеРедактирование.ReferentGroup = "Сервис";
	ИнтерактивноеРедактирование.ReferentName = "РазрешениеОперацииПользователя";
	ИнтерактивноеРедактирование.SaveInDatabase = true;
	ИнтерактивноеРедактирование.OwnerName = "";
	ИнтерактивноеРедактирование.AllowEmptyOwner = false;
	ИнтерактивноеРедактирование.StringFormat = "";
	ИнтерактивноеРедактирование.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ИнтерактивноеРедактирование.IncludeInPredefined = false;
	ИнтерактивноеРедактирование.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИнтерактивноеРедактирование.Required = false;
	ИнтерактивноеРедактирование.EmptyValue = "";
	ИнтерактивноеРедактирование.NullAllow = false;
	ИнтерактивноеРедактирование.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИнтерактивноеРедактирование.FieldName = "InteraktivnoeReda";
	ИнтерактивноеРедактирование.InformMetaDataOnValueChanged = false;
	ИнтерактивноеРедактирование.Visible = true;
	ИнтерактивноеРедактирование.Name = "ИнтерактивноеРедактирование";
	ИнтерактивноеРедактирование.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИнтерактивноеРедактирование.Description = "Интерактивное редактирование";
	ИнтерактивноеРедактирование.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ИнтерактивноеРедактирование.GroupName = "";
	ИнтерактивноеРедактирование.Guid = NsgService.StringToGuid("5bb40e22-a301-4f8e-a1f7-a1857b4ff99c");
	
				if (!ObjectList.Contains("ИнтерактивноеРедактирование"))
                    ObjectList.Add(ИнтерактивноеРедактирование);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя ИнтерактивноеРедактирование
			
			#region создание Сервис.РазрешениеОперацииПользователя ИнтерактивноеУдаление
			{  
                NsgDataEnumReference ИнтерактивноеУдаление = null;
				if (ObjectList.Contains("ИнтерактивноеУдаление"))
                    ИнтерактивноеУдаление = ObjectList["ИнтерактивноеУдаление"] as NsgDataEnumReference;
                else
                    ИнтерактивноеУдаление = new NsgDataEnumReference();
	//NsgDataEnumReference
	ИнтерактивноеУдаление.IsLoadedFromDll = true;
	ИнтерактивноеУдаление.ReferentGroup = "Сервис";
	ИнтерактивноеУдаление.ReferentName = "РазрешениеОперацииПользователя";
	ИнтерактивноеУдаление.SaveInDatabase = true;
	ИнтерактивноеУдаление.OwnerName = "";
	ИнтерактивноеУдаление.AllowEmptyOwner = false;
	ИнтерактивноеУдаление.StringFormat = "";
	ИнтерактивноеУдаление.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ИнтерактивноеУдаление.IncludeInPredefined = false;
	ИнтерактивноеУдаление.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИнтерактивноеУдаление.Required = false;
	ИнтерактивноеУдаление.EmptyValue = "";
	ИнтерактивноеУдаление.NullAllow = false;
	ИнтерактивноеУдаление.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИнтерактивноеУдаление.FieldName = "InteraktivnoeUdal";
	ИнтерактивноеУдаление.InformMetaDataOnValueChanged = false;
	ИнтерактивноеУдаление.Visible = true;
	ИнтерактивноеУдаление.Name = "ИнтерактивноеУдаление";
	ИнтерактивноеУдаление.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИнтерактивноеУдаление.Description = "Интерактивное удаление";
	ИнтерактивноеУдаление.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ИнтерактивноеУдаление.GroupName = "";
	ИнтерактивноеУдаление.Guid = NsgService.StringToGuid("63fe272f-dfb6-462c-b1ee-081c69dff60e");
	
				if (!ObjectList.Contains("ИнтерактивноеУдаление"))
                    ObjectList.Add(ИнтерактивноеУдаление);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя ИнтерактивноеУдаление
			
			#region создание Сервис.РазрешениеОперацииПользователя ИнтерактивнаяПометкаУдаление
			{  
                NsgDataEnumReference ИнтерактивнаяПометкаУдаление = null;
				if (ObjectList.Contains("ИнтерактивнаяПометкаУдаление"))
                    ИнтерактивнаяПометкаУдаление = ObjectList["ИнтерактивнаяПометкаУдаление"] as NsgDataEnumReference;
                else
                    ИнтерактивнаяПометкаУдаление = new NsgDataEnumReference();
	//NsgDataEnumReference
	ИнтерактивнаяПометкаУдаление.IsLoadedFromDll = true;
	ИнтерактивнаяПометкаУдаление.ReferentGroup = "Сервис";
	ИнтерактивнаяПометкаУдаление.ReferentName = "РазрешениеОперацииПользователя";
	ИнтерактивнаяПометкаУдаление.SaveInDatabase = true;
	ИнтерактивнаяПометкаУдаление.OwnerName = "";
	ИнтерактивнаяПометкаУдаление.AllowEmptyOwner = false;
	ИнтерактивнаяПометкаУдаление.StringFormat = "";
	ИнтерактивнаяПометкаУдаление.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ИнтерактивнаяПометкаУдаление.IncludeInPredefined = false;
	ИнтерактивнаяПометкаУдаление.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИнтерактивнаяПометкаУдаление.Required = false;
	ИнтерактивнаяПометкаУдаление.EmptyValue = "";
	ИнтерактивнаяПометкаУдаление.NullAllow = false;
	ИнтерактивнаяПометкаУдаление.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИнтерактивнаяПометкаУдаление.FieldName = "InteraktivnajaPom";
	ИнтерактивнаяПометкаУдаление.InformMetaDataOnValueChanged = false;
	ИнтерактивнаяПометкаУдаление.Visible = true;
	ИнтерактивнаяПометкаУдаление.Name = "ИнтерактивнаяПометкаУдаление";
	ИнтерактивнаяПометкаУдаление.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИнтерактивнаяПометкаУдаление.Description = "Интерактивная пометка удаление";
	ИнтерактивнаяПометкаУдаление.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ИнтерактивнаяПометкаУдаление.GroupName = "";
	ИнтерактивнаяПометкаУдаление.Guid = NsgService.StringToGuid("f2aafb92-67f1-4ff0-a46b-4b9b5682c9d3");
	
				if (!ObjectList.Contains("ИнтерактивнаяПометкаУдаление"))
                    ObjectList.Add(ИнтерактивнаяПометкаУдаление);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя ИнтерактивнаяПометкаУдаление
			
			#region создание Сервис.РазрешениеОперацииПользователя ИнтерактивноеСнятиеПометкиУдаление
			{  
                NsgDataEnumReference ИнтерактивноеСнятиеПометкиУдаление = null;
				if (ObjectList.Contains("ИнтерактивноеСнятиеПометкиУдаление"))
                    ИнтерактивноеСнятиеПометкиУдаление = ObjectList["ИнтерактивноеСнятиеПометкиУдаление"] as NsgDataEnumReference;
                else
                    ИнтерактивноеСнятиеПометкиУдаление = new NsgDataEnumReference();
	//NsgDataEnumReference
	ИнтерактивноеСнятиеПометкиУдаление.IsLoadedFromDll = true;
	ИнтерактивноеСнятиеПометкиУдаление.ReferentGroup = "Сервис";
	ИнтерактивноеСнятиеПометкиУдаление.ReferentName = "РазрешениеОперацииПользователя";
	ИнтерактивноеСнятиеПометкиУдаление.SaveInDatabase = true;
	ИнтерактивноеСнятиеПометкиУдаление.OwnerName = "";
	ИнтерактивноеСнятиеПометкиУдаление.AllowEmptyOwner = false;
	ИнтерактивноеСнятиеПометкиУдаление.StringFormat = "";
	ИнтерактивноеСнятиеПометкиУдаление.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ИнтерактивноеСнятиеПометкиУдаление.IncludeInPredefined = false;
	ИнтерактивноеСнятиеПометкиУдаление.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИнтерактивноеСнятиеПометкиУдаление.Required = false;
	ИнтерактивноеСнятиеПометкиУдаление.EmptyValue = "";
	ИнтерактивноеСнятиеПометкиУдаление.NullAllow = false;
	ИнтерактивноеСнятиеПометкиУдаление.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИнтерактивноеСнятиеПометкиУдаление.FieldName = "InteraktivnoeSnja";
	ИнтерактивноеСнятиеПометкиУдаление.InformMetaDataOnValueChanged = false;
	ИнтерактивноеСнятиеПометкиУдаление.Visible = true;
	ИнтерактивноеСнятиеПометкиУдаление.Name = "ИнтерактивноеСнятиеПометкиУдаление";
	ИнтерактивноеСнятиеПометкиУдаление.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИнтерактивноеСнятиеПометкиУдаление.Description = "Интерактивное снятие пометки удаление";
	ИнтерактивноеСнятиеПометкиУдаление.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ИнтерактивноеСнятиеПометкиУдаление.GroupName = "";
	ИнтерактивноеСнятиеПометкиУдаление.Guid = NsgService.StringToGuid("78f61b21-427d-42a6-ab16-cc3484c7b345");
	
				if (!ObjectList.Contains("ИнтерактивноеСнятиеПометкиУдаление"))
                    ObjectList.Add(ИнтерактивноеСнятиеПометкиУдаление);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя ИнтерактивноеСнятиеПометкиУдаление
			
			#region создание Сервис.РазрешениеОперацииПользователя ИнтерактивноеПроведение
			{  
                NsgDataEnumReference ИнтерактивноеПроведение = null;
				if (ObjectList.Contains("ИнтерактивноеПроведение"))
                    ИнтерактивноеПроведение = ObjectList["ИнтерактивноеПроведение"] as NsgDataEnumReference;
                else
                    ИнтерактивноеПроведение = new NsgDataEnumReference();
	//NsgDataEnumReference
	ИнтерактивноеПроведение.IsLoadedFromDll = true;
	ИнтерактивноеПроведение.ReferentGroup = "Сервис";
	ИнтерактивноеПроведение.ReferentName = "РазрешениеОперацииПользователя";
	ИнтерактивноеПроведение.SaveInDatabase = true;
	ИнтерактивноеПроведение.OwnerName = "";
	ИнтерактивноеПроведение.AllowEmptyOwner = false;
	ИнтерактивноеПроведение.StringFormat = "";
	ИнтерактивноеПроведение.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ИнтерактивноеПроведение.IncludeInPredefined = false;
	ИнтерактивноеПроведение.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИнтерактивноеПроведение.Required = false;
	ИнтерактивноеПроведение.EmptyValue = "";
	ИнтерактивноеПроведение.NullAllow = false;
	ИнтерактивноеПроведение.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИнтерактивноеПроведение.FieldName = "InteraktivnoeProv";
	ИнтерактивноеПроведение.InformMetaDataOnValueChanged = false;
	ИнтерактивноеПроведение.Visible = true;
	ИнтерактивноеПроведение.Name = "ИнтерактивноеПроведение";
	ИнтерактивноеПроведение.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИнтерактивноеПроведение.Description = "Интерактивное проведение";
	ИнтерактивноеПроведение.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ИнтерактивноеПроведение.GroupName = "";
	ИнтерактивноеПроведение.Guid = NsgService.StringToGuid("2f032148-d477-4a36-ac85-9f7b7cacdd9a");
	
				if (!ObjectList.Contains("ИнтерактивноеПроведение"))
                    ObjectList.Add(ИнтерактивноеПроведение);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя ИнтерактивноеПроведение
			
			#region создание Сервис.РазрешениеОперацииПользователя ИнтерактивнаяОтменаПроведения
			{  
                NsgDataEnumReference ИнтерактивнаяОтменаПроведения = null;
				if (ObjectList.Contains("ИнтерактивнаяОтменаПроведения"))
                    ИнтерактивнаяОтменаПроведения = ObjectList["ИнтерактивнаяОтменаПроведения"] as NsgDataEnumReference;
                else
                    ИнтерактивнаяОтменаПроведения = new NsgDataEnumReference();
	//NsgDataEnumReference
	ИнтерактивнаяОтменаПроведения.IsLoadedFromDll = true;
	ИнтерактивнаяОтменаПроведения.ReferentGroup = "Сервис";
	ИнтерактивнаяОтменаПроведения.ReferentName = "РазрешениеОперацииПользователя";
	ИнтерактивнаяОтменаПроведения.SaveInDatabase = true;
	ИнтерактивнаяОтменаПроведения.OwnerName = "";
	ИнтерактивнаяОтменаПроведения.AllowEmptyOwner = false;
	ИнтерактивнаяОтменаПроведения.StringFormat = "";
	ИнтерактивнаяОтменаПроведения.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ИнтерактивнаяОтменаПроведения.IncludeInPredefined = false;
	ИнтерактивнаяОтменаПроведения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИнтерактивнаяОтменаПроведения.Required = false;
	ИнтерактивнаяОтменаПроведения.EmptyValue = "";
	ИнтерактивнаяОтменаПроведения.NullAllow = false;
	ИнтерактивнаяОтменаПроведения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИнтерактивнаяОтменаПроведения.FieldName = "InteraktivnajaOtm";
	ИнтерактивнаяОтменаПроведения.InformMetaDataOnValueChanged = false;
	ИнтерактивнаяОтменаПроведения.Visible = true;
	ИнтерактивнаяОтменаПроведения.Name = "ИнтерактивнаяОтменаПроведения";
	ИнтерактивнаяОтменаПроведения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИнтерактивнаяОтменаПроведения.Description = "Интерактивная отмена проведения";
	ИнтерактивнаяОтменаПроведения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ИнтерактивнаяОтменаПроведения.GroupName = "";
	ИнтерактивнаяОтменаПроведения.Guid = NsgService.StringToGuid("d4aff613-3476-4d23-9a0c-485a3e676a1f");
	
				if (!ObjectList.Contains("ИнтерактивнаяОтменаПроведения"))
                    ObjectList.Add(ИнтерактивнаяОтменаПроведения);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя ИнтерактивнаяОтменаПроведения
			
			#region создание Сервис.РазрешениеОперацииПользователя ИнтерактивноеПроведениеНеактуальное
			{  
                NsgDataEnumReference ИнтерактивноеПроведениеНеактуальное = null;
				if (ObjectList.Contains("ИнтерактивноеПроведениеНеактуальное"))
                    ИнтерактивноеПроведениеНеактуальное = ObjectList["ИнтерактивноеПроведениеНеактуальное"] as NsgDataEnumReference;
                else
                    ИнтерактивноеПроведениеНеактуальное = new NsgDataEnumReference();
	//NsgDataEnumReference
	ИнтерактивноеПроведениеНеактуальное.IsLoadedFromDll = true;
	ИнтерактивноеПроведениеНеактуальное.ReferentGroup = "Сервис";
	ИнтерактивноеПроведениеНеактуальное.ReferentName = "РазрешениеОперацииПользователя";
	ИнтерактивноеПроведениеНеактуальное.SaveInDatabase = true;
	ИнтерактивноеПроведениеНеактуальное.OwnerName = "";
	ИнтерактивноеПроведениеНеактуальное.AllowEmptyOwner = false;
	ИнтерактивноеПроведениеНеактуальное.StringFormat = "";
	ИнтерактивноеПроведениеНеактуальное.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ИнтерактивноеПроведениеНеактуальное.IncludeInPredefined = false;
	ИнтерактивноеПроведениеНеактуальное.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИнтерактивноеПроведениеНеактуальное.Required = false;
	ИнтерактивноеПроведениеНеактуальное.EmptyValue = "";
	ИнтерактивноеПроведениеНеактуальное.NullAllow = false;
	ИнтерактивноеПроведениеНеактуальное.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИнтерактивноеПроведениеНеактуальное.FieldName = "InteraktivnoeProv1";
	ИнтерактивноеПроведениеНеактуальное.InformMetaDataOnValueChanged = false;
	ИнтерактивноеПроведениеНеактуальное.Visible = true;
	ИнтерактивноеПроведениеНеактуальное.Name = "ИнтерактивноеПроведениеНеактуальное";
	ИнтерактивноеПроведениеНеактуальное.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИнтерактивноеПроведениеНеактуальное.Description = "Интерактивное проведение неактуальное";
	ИнтерактивноеПроведениеНеактуальное.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ИнтерактивноеПроведениеНеактуальное.GroupName = "";
	ИнтерактивноеПроведениеНеактуальное.Guid = NsgService.StringToGuid("f02fc70d-e06e-410f-a118-ea361bdc2553");
	
				if (!ObjectList.Contains("ИнтерактивноеПроведениеНеактуальное"))
                    ObjectList.Add(ИнтерактивноеПроведениеНеактуальное);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя ИнтерактивноеПроведениеНеактуальное
			
			#region создание Сервис.РазрешениеОперацииПользователя ИнтерактивноеИзменениеПроведенных
			{  
                NsgDataEnumReference ИнтерактивноеИзменениеПроведенных = null;
				if (ObjectList.Contains("ИнтерактивноеИзменениеПроведенных"))
                    ИнтерактивноеИзменениеПроведенных = ObjectList["ИнтерактивноеИзменениеПроведенных"] as NsgDataEnumReference;
                else
                    ИнтерактивноеИзменениеПроведенных = new NsgDataEnumReference();
	//NsgDataEnumReference
	ИнтерактивноеИзменениеПроведенных.IsLoadedFromDll = true;
	ИнтерактивноеИзменениеПроведенных.ReferentGroup = "Сервис";
	ИнтерактивноеИзменениеПроведенных.ReferentName = "РазрешениеОперацииПользователя";
	ИнтерактивноеИзменениеПроведенных.SaveInDatabase = true;
	ИнтерактивноеИзменениеПроведенных.OwnerName = "";
	ИнтерактивноеИзменениеПроведенных.AllowEmptyOwner = false;
	ИнтерактивноеИзменениеПроведенных.StringFormat = "";
	ИнтерактивноеИзменениеПроведенных.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ИнтерактивноеИзменениеПроведенных.IncludeInPredefined = false;
	ИнтерактивноеИзменениеПроведенных.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИнтерактивноеИзменениеПроведенных.Required = false;
	ИнтерактивноеИзменениеПроведенных.EmptyValue = "";
	ИнтерактивноеИзменениеПроведенных.NullAllow = false;
	ИнтерактивноеИзменениеПроведенных.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ИнтерактивноеИзменениеПроведенных.FieldName = "InteraktivnoeIzme";
	ИнтерактивноеИзменениеПроведенных.InformMetaDataOnValueChanged = false;
	ИнтерактивноеИзменениеПроведенных.Visible = true;
	ИнтерактивноеИзменениеПроведенных.Name = "ИнтерактивноеИзменениеПроведенных";
	ИнтерактивноеИзменениеПроведенных.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ИнтерактивноеИзменениеПроведенных.Description = "Интерактивное изменение проведенных";
	ИнтерактивноеИзменениеПроведенных.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ИнтерактивноеИзменениеПроведенных.GroupName = "";
	ИнтерактивноеИзменениеПроведенных.Guid = NsgService.StringToGuid("d0a7ba79-e51f-43f6-89cf-441c05296027");
	
				if (!ObjectList.Contains("ИнтерактивноеИзменениеПроведенных"))
                    ObjectList.Add(ИнтерактивноеИзменениеПроведенных);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя ИнтерактивноеИзменениеПроведенных
			
			#region создание Сервис.РазрешениеОперацииПользователя ВводНаОсновании
			{  
                NsgDataEnumReference ВводНаОсновании = null;
				if (ObjectList.Contains("ВводНаОсновании"))
                    ВводНаОсновании = ObjectList["ВводНаОсновании"] as NsgDataEnumReference;
                else
                    ВводНаОсновании = new NsgDataEnumReference();
	//NsgDataEnumReference
	ВводНаОсновании.IsLoadedFromDll = true;
	ВводНаОсновании.ReferentGroup = "Сервис";
	ВводНаОсновании.ReferentName = "РазрешениеОперацииПользователя";
	ВводНаОсновании.SaveInDatabase = true;
	ВводНаОсновании.OwnerName = "";
	ВводНаОсновании.AllowEmptyOwner = false;
	ВводНаОсновании.StringFormat = "";
	ВводНаОсновании.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ВводНаОсновании.IncludeInPredefined = false;
	ВводНаОсновании.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВводНаОсновании.Required = false;
	ВводНаОсновании.EmptyValue = "";
	ВводНаОсновании.NullAllow = false;
	ВводНаОсновании.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВводНаОсновании.FieldName = "VvodNaOsnovanii";
	ВводНаОсновании.InformMetaDataOnValueChanged = false;
	ВводНаОсновании.Visible = true;
	ВводНаОсновании.Name = "ВводНаОсновании";
	ВводНаОсновании.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВводНаОсновании.Description = "Ввод на основании";
	ВводНаОсновании.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ВводНаОсновании.GroupName = "";
	ВводНаОсновании.Guid = NsgService.StringToGuid("c0275855-7707-4dcd-84eb-6873401fcc5e");
	
				if (!ObjectList.Contains("ВводНаОсновании"))
                    ObjectList.Add(ВводНаОсновании);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя ВводНаОсновании
			
			#region создание Сервис.РазрешениеОперацииПользователя ЛокальноеПроведение
			{  
                NsgDataEnumReference ЛокальноеПроведение = null;
				if (ObjectList.Contains("ЛокальноеПроведение"))
                    ЛокальноеПроведение = ObjectList["ЛокальноеПроведение"] as NsgDataEnumReference;
                else
                    ЛокальноеПроведение = new NsgDataEnumReference();
	//NsgDataEnumReference
	ЛокальноеПроведение.IsLoadedFromDll = true;
	ЛокальноеПроведение.ReferentGroup = "Сервис";
	ЛокальноеПроведение.ReferentName = "РазрешениеОперацииПользователя";
	ЛокальноеПроведение.SaveInDatabase = true;
	ЛокальноеПроведение.OwnerName = "";
	ЛокальноеПроведение.AllowEmptyOwner = false;
	ЛокальноеПроведение.StringFormat = "";
	ЛокальноеПроведение.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ЛокальноеПроведение.IncludeInPredefined = false;
	ЛокальноеПроведение.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ЛокальноеПроведение.Required = false;
	ЛокальноеПроведение.EmptyValue = "";
	ЛокальноеПроведение.NullAllow = false;
	ЛокальноеПроведение.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ЛокальноеПроведение.FieldName = "LokalnoeProvedenie";
	ЛокальноеПроведение.InformMetaDataOnValueChanged = false;
	ЛокальноеПроведение.Visible = true;
	ЛокальноеПроведение.Name = "ЛокальноеПроведение";
	ЛокальноеПроведение.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ЛокальноеПроведение.Description = "Локальное проведение";
	ЛокальноеПроведение.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ЛокальноеПроведение.GroupName = "";
	ЛокальноеПроведение.Guid = NsgService.StringToGuid("c22d38ae-eca0-4e85-9cd0-c6a16d0d0ce4");
	
				if (!ObjectList.Contains("ЛокальноеПроведение"))
                    ObjectList.Add(ЛокальноеПроведение);
			}
			#endregion //создание Сервис.РазрешениеОперацииПользователя ЛокальноеПроведение
			

			#region заполнение полей класса
				//NsgDataCharacteristics
	IsLoadedFromDll = true;
	RegisterType = NsgSoft.DataObjects.NsgRegisterType.Characteristics;
	DateDependence = false;
	SearchFieldName = "";
	QuantityName = "";
	HandlingWarnings = NsgSoft.DataObjects.NsgHandlingWarnings.None;
	Name = "ПраваПользователей";
	Visible = false;
	Guid = NsgService.StringToGuid("118e3ca1-dca9-4989-a777-3eafcb46cac2");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "UserRightsRegister";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"ПраваПользователей"});
	Description = "ПраваПользователей";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	GroupName = "Сервис";
	ConnectAdditionalTables();

			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataCharacteristics
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataCharacteristics

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
        public new partial class Names// :NsgSoft.DataObjects.NsgDataCharacteristics.Names
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
            /// Движения
            /// </summary>
            public static String Движения
            {
                get
                {
                    return "Движения";
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
            /// Условие
            /// </summary>
            public static String Условие
            {
                get
                {
                    return "Условие";
                }
            }
            
            /// <summary>
            /// Не наследует условия родителя
            /// </summary>
            public static String НеНаследуетУсловияРодителя
            {
                get
                {
                    return "НеНаследуетУсловияРодителя";
                }
            }
            
            /// <summary>
            /// Чтение
            /// </summary>
            public static String Чтение
            {
                get
                {
                    return "Чтение";
                }
            }
            
            /// <summary>
            /// Добавление
            /// </summary>
            public static String Добавление
            {
                get
                {
                    return "Добавление";
                }
            }
            
            /// <summary>
            /// Изменение
            /// </summary>
            public static String Изменение
            {
                get
                {
                    return "Изменение";
                }
            }
            
            /// <summary>
            /// Удаление
            /// </summary>
            public static String Удаление
            {
                get
                {
                    return "Удаление";
                }
            }
            
            /// <summary>
            /// Проведение
            /// </summary>
            public static String Проведение
            {
                get
                {
                    return "Проведение";
                }
            }
            
            /// <summary>
            /// Отмена проведения
            /// </summary>
            public static String ОтменаПроведения
            {
                get
                {
                    return "ОтменаПроведения";
                }
            }
            
            /// <summary>
            /// Интерактивный просмотр
            /// </summary>
            public static String ИнтерактивныйПросмотр
            {
                get
                {
                    return "ИнтерактивныйПросмотр";
                }
            }
            
            /// <summary>
            /// Интерактивное добавление
            /// </summary>
            public static String ИнтерактивноеДобавление
            {
                get
                {
                    return "ИнтерактивноеДобавление";
                }
            }
            
            /// <summary>
            /// Интерактивное редактирование
            /// </summary>
            public static String ИнтерактивноеРедактирование
            {
                get
                {
                    return "ИнтерактивноеРедактирование";
                }
            }
            
            /// <summary>
            /// Интерактивное удаление
            /// </summary>
            public static String ИнтерактивноеУдаление
            {
                get
                {
                    return "ИнтерактивноеУдаление";
                }
            }
            
            /// <summary>
            /// Интерактивная пометка удаление
            /// </summary>
            public static String ИнтерактивнаяПометкаУдаление
            {
                get
                {
                    return "ИнтерактивнаяПометкаУдаление";
                }
            }
            
            /// <summary>
            /// Интерактивное снятие пометки удаление
            /// </summary>
            public static String ИнтерактивноеСнятиеПометкиУдаление
            {
                get
                {
                    return "ИнтерактивноеСнятиеПометкиУдаление";
                }
            }
            
            /// <summary>
            /// Интерактивное проведение
            /// </summary>
            public static String ИнтерактивноеПроведение
            {
                get
                {
                    return "ИнтерактивноеПроведение";
                }
            }
            
            /// <summary>
            /// Интерактивная отмена проведения
            /// </summary>
            public static String ИнтерактивнаяОтменаПроведения
            {
                get
                {
                    return "ИнтерактивнаяОтменаПроведения";
                }
            }
            
            /// <summary>
            /// Интерактивное проведение неактуальное
            /// </summary>
            public static String ИнтерактивноеПроведениеНеактуальное
            {
                get
                {
                    return "ИнтерактивноеПроведениеНеактуальное";
                }
            }
            
            /// <summary>
            /// Интерактивное изменение проведенных
            /// </summary>
            public static String ИнтерактивноеИзменениеПроведенных
            {
                get
                {
                    return "ИнтерактивноеИзменениеПроведенных";
                }
            }
            
            /// <summary>
            /// Ввод на основании
            /// </summary>
            public static String ВводНаОсновании
            {
                get
                {
                    return "ВводНаОсновании";
                }
            }
            
            /// <summary>
            /// Локальное проведение
            /// </summary>
            public static String ЛокальноеПроведение
            {
                get
                {
                    return "ЛокальноеПроведение";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public static string GetFullName()
        {
            return "Сервис.ПраваПользователей";
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
        /// Движения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.СервисПраваПользователейДвижения Движения
        {
            get
            {
				 NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                 return (_SystemTables.СервисПраваПользователейДвижения)__Движения.Referent;
            }
            set
            {
                NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                __Движения.Referent = value;
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
        /// Объект метаданных
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("")]
        public NsgSoft.DataObjects.NsgReferencedObject ОбъектМетаданных
        {
            get
            {
				 NsgReferencedObjectSelector __ОбъектМетаданных = ObjectList["ОбъектМетаданных"] as NsgReferencedObjectSelector;
                 return (NsgSoft.DataObjects.NsgReferencedObject)__ОбъектМетаданных.Referent;
            }
            set
            {
                NsgReferencedObjectSelector __ОбъектМетаданных = ObjectList["ОбъектМетаданных"] as NsgReferencedObjectSelector;
                __ОбъектМетаданных.Referent = value;
            }
        }
        
        /// <summary>
        /// Условие
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Условие
        {
            get
            {
				 NsgDataString __Условие = ObjectList["Условие"] as NsgDataString;
                 return (System.String)__Условие.Value;
            }
            set
            {
                NsgDataString __Условие = ObjectList["Условие"] as NsgDataString;
                __Условие.Value = value;
            }
        }
        
        /// <summary>
        /// Не наследует условия родителя
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean НеНаследуетУсловияРодителя
        {
            get
            {
				 NsgDataBoolean __НеНаследуетУсловияРодителя = ObjectList["НеНаследуетУсловияРодителя"] as NsgDataBoolean;
                 return (System.Boolean)__НеНаследуетУсловияРодителя.Value;
            }
            set
            {
                NsgDataBoolean __НеНаследуетУсловияРодителя = ObjectList["НеНаследуетУсловияРодителя"] as NsgDataBoolean;
                __НеНаследуетУсловияРодителя.Value = value;
            }
        }
        
        /// <summary>
        /// Чтение
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя Чтение
        {
            get
            {
				 NsgDataEnumReference __Чтение = ObjectList["Чтение"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__Чтение.Referent;
            }
            set
            {
                NsgDataEnumReference __Чтение = ObjectList["Чтение"] as NsgDataEnumReference;
                __Чтение.Referent = value;
            }
        }
        
        /// <summary>
        /// Добавление
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя Добавление
        {
            get
            {
				 NsgDataEnumReference __Добавление = ObjectList["Добавление"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__Добавление.Referent;
            }
            set
            {
                NsgDataEnumReference __Добавление = ObjectList["Добавление"] as NsgDataEnumReference;
                __Добавление.Referent = value;
            }
        }
        
        /// <summary>
        /// Изменение
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя Изменение
        {
            get
            {
				 NsgDataEnumReference __Изменение = ObjectList["Изменение"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__Изменение.Referent;
            }
            set
            {
                NsgDataEnumReference __Изменение = ObjectList["Изменение"] as NsgDataEnumReference;
                __Изменение.Referent = value;
            }
        }
        
        /// <summary>
        /// Удаление
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя Удаление
        {
            get
            {
				 NsgDataEnumReference __Удаление = ObjectList["Удаление"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__Удаление.Referent;
            }
            set
            {
                NsgDataEnumReference __Удаление = ObjectList["Удаление"] as NsgDataEnumReference;
                __Удаление.Referent = value;
            }
        }
        
        /// <summary>
        /// Проведение
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя Проведение
        {
            get
            {
				 NsgDataEnumReference __Проведение = ObjectList["Проведение"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__Проведение.Referent;
            }
            set
            {
                NsgDataEnumReference __Проведение = ObjectList["Проведение"] as NsgDataEnumReference;
                __Проведение.Referent = value;
            }
        }
        
        /// <summary>
        /// Отмена проведения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя ОтменаПроведения
        {
            get
            {
				 NsgDataEnumReference __ОтменаПроведения = ObjectList["ОтменаПроведения"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__ОтменаПроведения.Referent;
            }
            set
            {
                NsgDataEnumReference __ОтменаПроведения = ObjectList["ОтменаПроведения"] as NsgDataEnumReference;
                __ОтменаПроведения.Referent = value;
            }
        }
        
        /// <summary>
        /// Интерактивный просмотр
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя ИнтерактивныйПросмотр
        {
            get
            {
				 NsgDataEnumReference __ИнтерактивныйПросмотр = ObjectList["ИнтерактивныйПросмотр"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__ИнтерактивныйПросмотр.Referent;
            }
            set
            {
                NsgDataEnumReference __ИнтерактивныйПросмотр = ObjectList["ИнтерактивныйПросмотр"] as NsgDataEnumReference;
                __ИнтерактивныйПросмотр.Referent = value;
            }
        }
        
        /// <summary>
        /// Интерактивное добавление
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя ИнтерактивноеДобавление
        {
            get
            {
				 NsgDataEnumReference __ИнтерактивноеДобавление = ObjectList["ИнтерактивноеДобавление"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__ИнтерактивноеДобавление.Referent;
            }
            set
            {
                NsgDataEnumReference __ИнтерактивноеДобавление = ObjectList["ИнтерактивноеДобавление"] as NsgDataEnumReference;
                __ИнтерактивноеДобавление.Referent = value;
            }
        }
        
        /// <summary>
        /// Интерактивное редактирование
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя ИнтерактивноеРедактирование
        {
            get
            {
				 NsgDataEnumReference __ИнтерактивноеРедактирование = ObjectList["ИнтерактивноеРедактирование"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__ИнтерактивноеРедактирование.Referent;
            }
            set
            {
                NsgDataEnumReference __ИнтерактивноеРедактирование = ObjectList["ИнтерактивноеРедактирование"] as NsgDataEnumReference;
                __ИнтерактивноеРедактирование.Referent = value;
            }
        }
        
        /// <summary>
        /// Интерактивное удаление
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя ИнтерактивноеУдаление
        {
            get
            {
				 NsgDataEnumReference __ИнтерактивноеУдаление = ObjectList["ИнтерактивноеУдаление"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__ИнтерактивноеУдаление.Referent;
            }
            set
            {
                NsgDataEnumReference __ИнтерактивноеУдаление = ObjectList["ИнтерактивноеУдаление"] as NsgDataEnumReference;
                __ИнтерактивноеУдаление.Referent = value;
            }
        }
        
        /// <summary>
        /// Интерактивная пометка удаление
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя ИнтерактивнаяПометкаУдаление
        {
            get
            {
				 NsgDataEnumReference __ИнтерактивнаяПометкаУдаление = ObjectList["ИнтерактивнаяПометкаУдаление"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__ИнтерактивнаяПометкаУдаление.Referent;
            }
            set
            {
                NsgDataEnumReference __ИнтерактивнаяПометкаУдаление = ObjectList["ИнтерактивнаяПометкаУдаление"] as NsgDataEnumReference;
                __ИнтерактивнаяПометкаУдаление.Referent = value;
            }
        }
        
        /// <summary>
        /// Интерактивное снятие пометки удаление
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя ИнтерактивноеСнятиеПометкиУдаление
        {
            get
            {
				 NsgDataEnumReference __ИнтерактивноеСнятиеПометкиУдаление = ObjectList["ИнтерактивноеСнятиеПометкиУдаление"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__ИнтерактивноеСнятиеПометкиУдаление.Referent;
            }
            set
            {
                NsgDataEnumReference __ИнтерактивноеСнятиеПометкиУдаление = ObjectList["ИнтерактивноеСнятиеПометкиУдаление"] as NsgDataEnumReference;
                __ИнтерактивноеСнятиеПометкиУдаление.Referent = value;
            }
        }
        
        /// <summary>
        /// Интерактивное проведение
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя ИнтерактивноеПроведение
        {
            get
            {
				 NsgDataEnumReference __ИнтерактивноеПроведение = ObjectList["ИнтерактивноеПроведение"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__ИнтерактивноеПроведение.Referent;
            }
            set
            {
                NsgDataEnumReference __ИнтерактивноеПроведение = ObjectList["ИнтерактивноеПроведение"] as NsgDataEnumReference;
                __ИнтерактивноеПроведение.Referent = value;
            }
        }
        
        /// <summary>
        /// Интерактивная отмена проведения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя ИнтерактивнаяОтменаПроведения
        {
            get
            {
				 NsgDataEnumReference __ИнтерактивнаяОтменаПроведения = ObjectList["ИнтерактивнаяОтменаПроведения"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__ИнтерактивнаяОтменаПроведения.Referent;
            }
            set
            {
                NsgDataEnumReference __ИнтерактивнаяОтменаПроведения = ObjectList["ИнтерактивнаяОтменаПроведения"] as NsgDataEnumReference;
                __ИнтерактивнаяОтменаПроведения.Referent = value;
            }
        }
        
        /// <summary>
        /// Интерактивное проведение неактуальное
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя ИнтерактивноеПроведениеНеактуальное
        {
            get
            {
				 NsgDataEnumReference __ИнтерактивноеПроведениеНеактуальное = ObjectList["ИнтерактивноеПроведениеНеактуальное"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__ИнтерактивноеПроведениеНеактуальное.Referent;
            }
            set
            {
                NsgDataEnumReference __ИнтерактивноеПроведениеНеактуальное = ObjectList["ИнтерактивноеПроведениеНеактуальное"] as NsgDataEnumReference;
                __ИнтерактивноеПроведениеНеактуальное.Referent = value;
            }
        }
        
        /// <summary>
        /// Интерактивное изменение проведенных
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя ИнтерактивноеИзменениеПроведенных
        {
            get
            {
				 NsgDataEnumReference __ИнтерактивноеИзменениеПроведенных = ObjectList["ИнтерактивноеИзменениеПроведенных"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__ИнтерактивноеИзменениеПроведенных.Referent;
            }
            set
            {
                NsgDataEnumReference __ИнтерактивноеИзменениеПроведенных = ObjectList["ИнтерактивноеИзменениеПроведенных"] as NsgDataEnumReference;
                __ИнтерактивноеИзменениеПроведенных.Referent = value;
            }
        }
        
        /// <summary>
        /// Ввод на основании
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя ВводНаОсновании
        {
            get
            {
				 NsgDataEnumReference __ВводНаОсновании = ObjectList["ВводНаОсновании"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__ВводНаОсновании.Referent;
            }
            set
            {
                NsgDataEnumReference __ВводНаОсновании = ObjectList["ВводНаОсновании"] as NsgDataEnumReference;
                __ВводНаОсновании.Referent = value;
            }
        }
        
        /// <summary>
        /// Локальное проведение
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.РазрешениеОперацииПользователя ЛокальноеПроведение
        {
            get
            {
				 NsgDataEnumReference __ЛокальноеПроведение = ObjectList["ЛокальноеПроведение"] as NsgDataEnumReference;
                 return (Сервис.РазрешениеОперацииПользователя)__ЛокальноеПроведение.Referent;
            }
            set
            {
                NsgDataEnumReference __ЛокальноеПроведение = ObjectList["ЛокальноеПроведение"] as NsgDataEnumReference;
                __ЛокальноеПроведение.Referent = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataCharacteristics
        




        #endregion // Свойства NsgSoft.DataObjects.NsgDataCharacteristics

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataCharacteristics
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataCharacteristics

        #region Методы NsgMultipleObject
        private ПраваПользователей[] convertArray(NsgMultipleObject[] array)
        {
            ПраваПользователей[] res = new ПраваПользователей[array.Length];
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
        public new virtual ПраваПользователей[] FindAll(NsgCompare compare)
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
        public new virtual ПраваПользователей[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual ПраваПользователей[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual ПраваПользователей[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ПраваПользователей(this as NsgObject);
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
                base.NSGType = typeof(ПраваПользователей);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ПраваПользователей Value
            {
                get
                {
                    return (ПраваПользователей)base.Value;
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
                    return "s_NsgDataCharacteristics";
                }
            }
        }
    }

}
