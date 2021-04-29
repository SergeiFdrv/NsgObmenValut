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
    
    [NsgTypeName("NsgDataEnum", Guid = "8eebd41d-a140-486e-b0e8-8c64784ed31a")]
    public partial class ТипСообщения : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Оповещение
            {
                NsgDataEnumElement Оповещение = null;
                if (ObjectList.Contains("Оповещение"))
                    Оповещение = ObjectList["Оповещение"] as NsgDataEnumElement;
                else
                    Оповещение = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Оповещение.IsLoadedFromDll = true;
	Оповещение.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Оповещение.Index = 0;
	Оповещение.StringFormat = "";
	Оповещение.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Оповещение.IncludeInPredefined = false;
	Оповещение.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Оповещение.Required = false;
	Оповещение.EmptyValue = "";
	Оповещение.NullAllow = false;
	Оповещение.FieldName = "_Notification";
	Оповещение.SaveInDatabase = true;
	Оповещение.InformMetaDataOnValueChanged = false;
	Оповещение.Visible = true;
	Оповещение.Name = "Оповещение";
	Оповещение.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Оповещение"});
	Оповещение.Description = "Оповещение";
	Оповещение.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Оповещение.GroupName = "";
	Оповещение.Guid = NsgService.StringToGuid("91f278ab-3ab5-457b-bff6-8344a6a15816");
	
                if (!ObjectList.Contains("Оповещение"))
                    ObjectList.Add(Оповещение);
			}
			#endregion //создание System.String Оповещение
			
            #region создание System.String Предупреждение
            {
                NsgDataEnumElement Предупреждение = null;
                if (ObjectList.Contains("Предупреждение"))
                    Предупреждение = ObjectList["Предупреждение"] as NsgDataEnumElement;
                else
                    Предупреждение = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Предупреждение.IsLoadedFromDll = true;
	Предупреждение.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Предупреждение.Index = 1;
	Предупреждение.StringFormat = "";
	Предупреждение.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Предупреждение.IncludeInPredefined = false;
	Предупреждение.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Предупреждение.Required = false;
	Предупреждение.EmptyValue = "";
	Предупреждение.NullAllow = false;
	Предупреждение.FieldName = "_Warning";
	Предупреждение.SaveInDatabase = true;
	Предупреждение.InformMetaDataOnValueChanged = false;
	Предупреждение.Visible = true;
	Предупреждение.Name = "Предупреждение";
	Предупреждение.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Предупреждение"});
	Предупреждение.Description = "Предупреждение";
	Предупреждение.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Предупреждение.GroupName = "";
	Предупреждение.Guid = NsgService.StringToGuid("c5b4a137-20a0-4182-accb-0d0f708760be");
	
                if (!ObjectList.Contains("Предупреждение"))
                    ObjectList.Add(Предупреждение);
			}
			#endregion //создание System.String Предупреждение
			
            #region создание System.String Напоминание
            {
                NsgDataEnumElement Напоминание = null;
                if (ObjectList.Contains("Напоминание"))
                    Напоминание = ObjectList["Напоминание"] as NsgDataEnumElement;
                else
                    Напоминание = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Напоминание.IsLoadedFromDll = true;
	Напоминание.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Напоминание.Index = 2;
	Напоминание.StringFormat = "";
	Напоминание.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Напоминание.IncludeInPredefined = false;
	Напоминание.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Напоминание.Required = false;
	Напоминание.EmptyValue = "";
	Напоминание.NullAllow = false;
	Напоминание.FieldName = "_Reminder";
	Напоминание.SaveInDatabase = true;
	Напоминание.InformMetaDataOnValueChanged = false;
	Напоминание.Visible = true;
	Напоминание.Name = "Напоминание";
	Напоминание.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Напоминание"});
	Напоминание.Description = "Напоминание";
	Напоминание.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Напоминание.GroupName = "";
	Напоминание.Guid = NsgService.StringToGuid("4dd9a7ae-211b-4087-9ad9-e6bf228df8bf");
	
                if (!ObjectList.Contains("Напоминание"))
                    ObjectList.Add(Напоминание);
			}
			#endregion //создание System.String Напоминание
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ТипСообщения";
	Visible = true;
	Guid = NsgService.StringToGuid("8eebd41d-a140-486e-b0e8-8c64784ed31a");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "MessageType";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Тип сообщения"});
	Description = "Тип сообщения";
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

		public static ТипСообщения Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("8eebd41d-a140-486e-b0e8-8c64784ed31a"));
            if (obj == null)
                obj = new ТипСообщения();
            return obj as ТипСообщения;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected ТипСообщения()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  ТипСообщения(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Сервис.ТипСообщения";
        }

        
        /// <summary>
        /// Оповещение
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипСообщения Оповещение
        {
            get
            {
                ТипСообщения res = ТипСообщения.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Предупреждение
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипСообщения Предупреждение
        {
            get
            {
                ТипСообщения res = ТипСообщения.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Напоминание
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипСообщения Напоминание
        {
            get
            {
                ТипСообщения res = ТипСообщения.Новый();
                res.Value = 2;
                return res;
            }
        }

		
		#region Свойства NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Свойства NsgSoft.DataObjects.NsgDataEnum

		#endregion //Свойства

		#region Методы
		#region Методы NsgSoft.DataObjects.NsgDataEnum
		




        public static ТипСообщения Parse(string str)
        {
            ТипСообщения res = ТипСообщения.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new ТипСообщения(this as NsgObject);
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
                base.NSGType = typeof(ТипСообщения);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new ТипСообщения Value
            {
                get
                {
                    return (ТипСообщения)base.Value;
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
