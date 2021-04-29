using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Common;
using NsgSoft.Database;
using NsgSoft.Design;
using System.ComponentModel;

// ================================================================ //
// Этот файл создается автоматически, все изменения будут потеряны. //
// ================================================================ //

namespace ОбменникВалют.Метаданные.Сервис
{
    
    [NsgTypeName("NsgDataEnum", Guid = "d373efce-3fd1-4b4c-8573-10ca698f7553")]
    public partial class ВидыДвижений : NsgSoft.DataObjects.NsgDataEnum
	{
		#region Данные
		#region Данные NsgSoft.DataObjects.NsgDataEnum
		




		#endregion Данные NsgSoft.DataObjects.NsgDataEnum

		#endregion //Данные

		#region Инициализация

		/// <summary>
		/// Инициализация
        /// </summary>
        protected override void CreatePreDefinedFields()
		{
			#region необходимые операции до создания реквизитов и заполнения полей
			if (NsgSettings.Regime == NsgSoft.Common.NsgViewTypes.Load)
                base.CreatePreDefinedFields();
			#endregion //необходимые операции до создания реквизитов и заполнения полей

			
            #region создание System.String Расход
            {
                NsgDataEnumElement Расход = null;
                if (ObjectList.Contains("Расход"))
                    Расход = ObjectList["Расход"] as NsgDataEnumElement;
                else
                    Расход = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Расход.IsLoadedFromDll = true;
	Расход.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Расход.Index = -1;
	Расход.StringFormat = "";
	Расход.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Расход.IncludeInPredefined = false;
	Расход.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Расход.Required = false;
	Расход.EmptyValue = "";
	Расход.NullAllow = false;
	Расход.FieldName = "Raskhod";
	Расход.SaveInDatabase = true;
	Расход.InformMetaDataOnValueChanged = false;
	Расход.Visible = true;
	Расход.Name = "Расход";
	Расход.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Расход.Description = "Расход";
	Расход.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Расход.GroupName = "";
	Расход.Guid = NsgService.StringToGuid("3e8d6fc0-1e75-418d-9b22-001bf2599248");
	
                if (!ObjectList.Contains("Расход"))
                    ObjectList.Add(Расход);
			}
			#endregion //создание System.String Расход
			
            #region создание System.String Приход
            {
                NsgDataEnumElement Приход = null;
                if (ObjectList.Contains("Приход"))
                    Приход = ObjectList["Приход"] as NsgDataEnumElement;
                else
                    Приход = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Приход.IsLoadedFromDll = true;
	Приход.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Приход.Index = 1;
	Приход.StringFormat = "";
	Приход.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Приход.IncludeInPredefined = false;
	Приход.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Приход.Required = false;
	Приход.EmptyValue = "";
	Приход.NullAllow = false;
	Приход.FieldName = "Prikhod";
	Приход.SaveInDatabase = true;
	Приход.InformMetaDataOnValueChanged = false;
	Приход.Visible = true;
	Приход.Name = "Приход";
	Приход.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Приход.Description = "Приход";
	Приход.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Приход.GroupName = "";
	Приход.Guid = NsgService.StringToGuid("a0b6bb67-caf2-441d-880b-e281990b981b");
	
                if (!ObjectList.Contains("Приход"))
                    ObjectList.Add(Приход);
			}
			#endregion //создание System.String Приход
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ВидыДвижений";
	Visible = true;
	Guid = NsgService.StringToGuid("d373efce-3fd1-4b4c-8573-10ca698f7553");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "MovementSign";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Виды движений";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Сервис";
	
			#endregion //заполнение полей класса
			#region необходимые операции после создания реквизитов и заполнения полей
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

		#endregion //Инициализация

		#region Конструкторы

		#region Конструкторы NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Конструкторы NsgSoft.DataObjects.NsgDataEnum

		public static ВидыДвижений Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("d373efce-3fd1-4b4c-8573-10ca698f7553"));
            if (obj == null)
                obj = new ВидыДвижений();
            return obj as ВидыДвижений;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected ВидыДвижений()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  ВидыДвижений(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Сервис.ВидыДвижений";
        }

        
        /// <summary>
        /// Расход
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ВидыДвижений Расход
        {
            get
            {
                ВидыДвижений res = ВидыДвижений.Новый();
                res.Value = -1;
                return res;
            }
        }

		
        /// <summary>
        /// Приход
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ВидыДвижений Приход
        {
            get
            {
                ВидыДвижений res = ВидыДвижений.Новый();
                res.Value = 1;
                return res;
            }
        }

		
		#region Свойства NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Свойства NsgSoft.DataObjects.NsgDataEnum

		#endregion //Свойства

		#region Методы
		#region Методы NsgSoft.DataObjects.NsgDataEnum
		




        public static ВидыДвижений Parse(string str)
        {
            ВидыДвижений res = ВидыДвижений.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new ВидыДвижений(this as NsgObject);
            }
        }

		#endregion //Методы NsgMultipleObject
		#endregion //Методы

		/// <summary>
		///  Описатель колонки источника данных
		/// </summary>
        public new class ColumnDescriptor : NsgSoft.Forms.NsgColumnDescriptor
        {
            public ColumnDescriptor()
                : base()
            {
                base.NSGType = typeof(ВидыДвижений);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new ВидыДвижений Value
            {
                get
                {
                    return (ВидыДвижений)base.Value;
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
                    return "s_NsgDataEnum";
                }
            }
        }

    }
    
}
