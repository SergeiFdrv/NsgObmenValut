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
    
    [NsgTypeName("NsgDataEnum", Guid = "226605c2-7e81-4f06-83ba-7d7f9f378231")]
    public partial class Приоритет : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Минимальный
            {
                NsgDataEnumElement Минимальный = null;
                if (ObjectList.Contains("Минимальный"))
                    Минимальный = ObjectList["Минимальный"] as NsgDataEnumElement;
                else
                    Минимальный = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Минимальный.IsLoadedFromDll = true;
	Минимальный.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Минимальный.Index = 0;
	Минимальный.StringFormat = "";
	Минимальный.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Минимальный.IncludeInPredefined = false;
	Минимальный.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Минимальный.Required = false;
	Минимальный.EmptyValue = "";
	Минимальный.NullAllow = false;
	Минимальный.FieldName = "_Minimum";
	Минимальный.SaveInDatabase = true;
	Минимальный.InformMetaDataOnValueChanged = false;
	Минимальный.Visible = true;
	Минимальный.Name = "Минимальный";
	Минимальный.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Минимальный"});
	Минимальный.Description = "Минимальный";
	Минимальный.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Минимальный.GroupName = "";
	Минимальный.Guid = NsgService.StringToGuid("404deb34-4069-44e5-841d-cee01201f5a0");
	
                if (!ObjectList.Contains("Минимальный"))
                    ObjectList.Add(Минимальный);
			}
			#endregion //создание System.String Минимальный
			
            #region создание System.String Низкий
            {
                NsgDataEnumElement Низкий = null;
                if (ObjectList.Contains("Низкий"))
                    Низкий = ObjectList["Низкий"] as NsgDataEnumElement;
                else
                    Низкий = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Низкий.IsLoadedFromDll = true;
	Низкий.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Низкий.Index = 1;
	Низкий.StringFormat = "";
	Низкий.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Низкий.IncludeInPredefined = false;
	Низкий.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Низкий.Required = false;
	Низкий.EmptyValue = "";
	Низкий.NullAllow = false;
	Низкий.FieldName = "_Low";
	Низкий.SaveInDatabase = true;
	Низкий.InformMetaDataOnValueChanged = false;
	Низкий.Visible = true;
	Низкий.Name = "Низкий";
	Низкий.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Низкий"});
	Низкий.Description = "Низкий";
	Низкий.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Низкий.GroupName = "";
	Низкий.Guid = NsgService.StringToGuid("26ea9a7d-d8ef-4d75-a066-b609def37402");
	
                if (!ObjectList.Contains("Низкий"))
                    ObjectList.Add(Низкий);
			}
			#endregion //создание System.String Низкий
			
            #region создание System.String Средний
            {
                NsgDataEnumElement Средний = null;
                if (ObjectList.Contains("Средний"))
                    Средний = ObjectList["Средний"] as NsgDataEnumElement;
                else
                    Средний = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Средний.IsLoadedFromDll = true;
	Средний.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Средний.Index = 2;
	Средний.StringFormat = "";
	Средний.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Средний.IncludeInPredefined = false;
	Средний.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Средний.Required = false;
	Средний.EmptyValue = "";
	Средний.NullAllow = false;
	Средний.FieldName = "_Medium";
	Средний.SaveInDatabase = true;
	Средний.InformMetaDataOnValueChanged = false;
	Средний.Visible = true;
	Средний.Name = "Средний";
	Средний.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Средний"});
	Средний.Description = "Средний";
	Средний.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Средний.GroupName = "";
	Средний.Guid = NsgService.StringToGuid("5e11f68d-df67-4bef-bc85-d3f525109499");
	
                if (!ObjectList.Contains("Средний"))
                    ObjectList.Add(Средний);
			}
			#endregion //создание System.String Средний
			
            #region создание System.String Высокий
            {
                NsgDataEnumElement Высокий = null;
                if (ObjectList.Contains("Высокий"))
                    Высокий = ObjectList["Высокий"] as NsgDataEnumElement;
                else
                    Высокий = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Высокий.IsLoadedFromDll = true;
	Высокий.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Высокий.Index = 3;
	Высокий.StringFormat = "";
	Высокий.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Высокий.IncludeInPredefined = false;
	Высокий.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Высокий.Required = false;
	Высокий.EmptyValue = "";
	Высокий.NullAllow = false;
	Высокий.FieldName = "_High";
	Высокий.SaveInDatabase = true;
	Высокий.InformMetaDataOnValueChanged = false;
	Высокий.Visible = true;
	Высокий.Name = "Высокий";
	Высокий.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Высокий"});
	Высокий.Description = "Высокий";
	Высокий.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Высокий.GroupName = "";
	Высокий.Guid = NsgService.StringToGuid("d2fac93d-b161-4bff-a7f6-faa76c4bff8a");
	
                if (!ObjectList.Contains("Высокий"))
                    ObjectList.Add(Высокий);
			}
			#endregion //создание System.String Высокий
			
            #region создание System.String Максимальный
            {
                NsgDataEnumElement Максимальный = null;
                if (ObjectList.Contains("Максимальный"))
                    Максимальный = ObjectList["Максимальный"] as NsgDataEnumElement;
                else
                    Максимальный = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Максимальный.IsLoadedFromDll = true;
	Максимальный.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Максимальный.Index = 4;
	Максимальный.StringFormat = "";
	Максимальный.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Максимальный.IncludeInPredefined = false;
	Максимальный.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Максимальный.Required = false;
	Максимальный.EmptyValue = "";
	Максимальный.NullAllow = false;
	Максимальный.FieldName = "_Maximum";
	Максимальный.SaveInDatabase = true;
	Максимальный.InformMetaDataOnValueChanged = false;
	Максимальный.Visible = true;
	Максимальный.Name = "Максимальный";
	Максимальный.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Максимальный"});
	Максимальный.Description = "Максимальный";
	Максимальный.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Максимальный.GroupName = "";
	Максимальный.Guid = NsgService.StringToGuid("5e8cac67-0b16-4470-8f37-fcf81345d570");
	
                if (!ObjectList.Contains("Максимальный"))
                    ObjectList.Add(Максимальный);
			}
			#endregion //создание System.String Максимальный
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "Приоритет";
	Visible = true;
	Guid = NsgService.StringToGuid("226605c2-7e81-4f06-83ba-7d7f9f378231");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "Priority";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Тип приоритета"});
	Description = "Тип приоритета";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	GroupName = "Сервис";
	
			#endregion //заполнение полей класса
			#region необходимые операции после создания реквизитов и заполнения полей
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

		#endregion //Инициализация

		#region Конструкторы

		#region Конструкторы NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Конструкторы NsgSoft.DataObjects.NsgDataEnum

		public static Приоритет Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("226605c2-7e81-4f06-83ba-7d7f9f378231"));
            if (obj == null)
                obj = new Приоритет();
            return obj as Приоритет;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected Приоритет()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  Приоритет(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Сервис.Приоритет";
        }

        
        /// <summary>
        /// Минимальный
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static Приоритет Минимальный
        {
            get
            {
                Приоритет res = Приоритет.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Низкий
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static Приоритет Низкий
        {
            get
            {
                Приоритет res = Приоритет.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Средний
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static Приоритет Средний
        {
            get
            {
                Приоритет res = Приоритет.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// Высокий
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static Приоритет Высокий
        {
            get
            {
                Приоритет res = Приоритет.Новый();
                res.Value = 3;
                return res;
            }
        }

		
        /// <summary>
        /// Максимальный
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static Приоритет Максимальный
        {
            get
            {
                Приоритет res = Приоритет.Новый();
                res.Value = 4;
                return res;
            }
        }

		
		#region Свойства NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Свойства NsgSoft.DataObjects.NsgDataEnum

		#endregion //Свойства

		#region Методы
		#region Методы NsgSoft.DataObjects.NsgDataEnum
		




        public static Приоритет Parse(string str)
        {
            Приоритет res = Приоритет.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new Приоритет(this as NsgObject);
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
                base.NSGType = typeof(Приоритет);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new Приоритет Value
            {
                get
                {
                    return (Приоритет)base.Value;
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
