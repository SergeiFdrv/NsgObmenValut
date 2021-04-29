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
    
    [NsgTypeName("NsgDataEnum", Guid = "929d2f5a-84ef-4708-9d7c-5275b95c04f8")]
    public partial class РазрешениеОперацииПользователя : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Разрешено
            {
                NsgDataEnumElement Разрешено = null;
                if (ObjectList.Contains("Разрешено"))
                    Разрешено = ObjectList["Разрешено"] as NsgDataEnumElement;
                else
                    Разрешено = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Разрешено.IsLoadedFromDll = true;
	Разрешено.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Разрешено.Index = 0;
	Разрешено.StringFormat = "";
	Разрешено.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Разрешено.IncludeInPredefined = false;
	Разрешено.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Разрешено.Required = false;
	Разрешено.EmptyValue = "";
	Разрешено.NullAllow = false;
	Разрешено.FieldName = "Razresheno";
	Разрешено.SaveInDatabase = true;
	Разрешено.InformMetaDataOnValueChanged = false;
	Разрешено.Visible = true;
	Разрешено.Name = "Разрешено";
	Разрешено.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Разрешено.Description = "Разрешено";
	Разрешено.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Разрешено.GroupName = "";
	Разрешено.Guid = NsgService.StringToGuid("f8b847cb-918b-45e1-acdd-5c53684dc832");
	
                if (!ObjectList.Contains("Разрешено"))
                    ObjectList.Add(Разрешено);
			}
			#endregion //создание System.String Разрешено
			
            #region создание System.String Запрещено
            {
                NsgDataEnumElement Запрещено = null;
                if (ObjectList.Contains("Запрещено"))
                    Запрещено = ObjectList["Запрещено"] as NsgDataEnumElement;
                else
                    Запрещено = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Запрещено.IsLoadedFromDll = true;
	Запрещено.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Запрещено.Index = 1;
	Запрещено.StringFormat = "";
	Запрещено.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Запрещено.IncludeInPredefined = false;
	Запрещено.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Запрещено.Required = false;
	Запрещено.EmptyValue = "";
	Запрещено.NullAllow = false;
	Запрещено.FieldName = "Zaprescheno";
	Запрещено.SaveInDatabase = true;
	Запрещено.InformMetaDataOnValueChanged = false;
	Запрещено.Visible = true;
	Запрещено.Name = "Запрещено";
	Запрещено.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Запрещено.Description = "Запрещено";
	Запрещено.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Запрещено.GroupName = "";
	Запрещено.Guid = NsgService.StringToGuid("a211e130-f002-4e2a-8ebe-78682e7f2a45");
	
                if (!ObjectList.Contains("Запрещено"))
                    ObjectList.Add(Запрещено);
			}
			#endregion //создание System.String Запрещено
			
            #region создание System.String Наследует
            {
                NsgDataEnumElement Наследует = null;
                if (ObjectList.Contains("Наследует"))
                    Наследует = ObjectList["Наследует"] as NsgDataEnumElement;
                else
                    Наследует = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Наследует.IsLoadedFromDll = true;
	Наследует.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Наследует.Index = 2;
	Наследует.StringFormat = "";
	Наследует.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Наследует.IncludeInPredefined = false;
	Наследует.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Наследует.Required = false;
	Наследует.EmptyValue = "";
	Наследует.NullAllow = false;
	Наследует.FieldName = "Nasleduet";
	Наследует.SaveInDatabase = true;
	Наследует.InformMetaDataOnValueChanged = false;
	Наследует.Visible = true;
	Наследует.Name = "Наследует";
	Наследует.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Наследует.Description = "Наследует";
	Наследует.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Наследует.GroupName = "";
	Наследует.Guid = NsgService.StringToGuid("85a3b098-5297-446f-a091-92c57f08ad5a");
	
                if (!ObjectList.Contains("Наследует"))
                    ObjectList.Add(Наследует);
			}
			#endregion //создание System.String Наследует
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "РазрешениеОперацииПользователя";
	Visible = true;
	Guid = NsgService.StringToGuid("929d2f5a-84ef-4708-9d7c-5275b95c04f8");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "UserOperationAccess";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Разрешение операции пользователя"});
	Description = "Разрешение операции пользователя";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	GroupName = "Сервис";
	
			#endregion //заполнение полей класса
			#region необходимые операции после создания реквизитов и заполнения полей
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

		#endregion //Инициализация

		#region Конструкторы

		#region Конструкторы NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Конструкторы NsgSoft.DataObjects.NsgDataEnum

		public static РазрешениеОперацииПользователя Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("929d2f5a-84ef-4708-9d7c-5275b95c04f8"));
            if (obj == null)
                obj = new РазрешениеОперацииПользователя();
            return obj as РазрешениеОперацииПользователя;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected РазрешениеОперацииПользователя()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  РазрешениеОперацииПользователя(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Сервис.РазрешениеОперацииПользователя";
        }

        
        /// <summary>
        /// Разрешено
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static РазрешениеОперацииПользователя Разрешено
        {
            get
            {
                РазрешениеОперацииПользователя res = РазрешениеОперацииПользователя.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Запрещено
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static РазрешениеОперацииПользователя Запрещено
        {
            get
            {
                РазрешениеОперацииПользователя res = РазрешениеОперацииПользователя.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Наследует
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static РазрешениеОперацииПользователя Наследует
        {
            get
            {
                РазрешениеОперацииПользователя res = РазрешениеОперацииПользователя.Новый();
                res.Value = 2;
                return res;
            }
        }

		
		#region Свойства NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Свойства NsgSoft.DataObjects.NsgDataEnum

		#endregion //Свойства

		#region Методы
		#region Методы NsgSoft.DataObjects.NsgDataEnum
		




        public static РазрешениеОперацииПользователя Parse(string str)
        {
            РазрешениеОперацииПользователя res = РазрешениеОперацииПользователя.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new РазрешениеОперацииПользователя(this as NsgObject);
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
                base.NSGType = typeof(РазрешениеОперацииПользователя);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new РазрешениеОперацииПользователя Value
            {
                get
                {
                    return (РазрешениеОперацииПользователя)base.Value;
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
