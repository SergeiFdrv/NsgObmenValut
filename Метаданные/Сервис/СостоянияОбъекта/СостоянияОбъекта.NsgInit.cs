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
    
    [NsgTypeName("NsgDataEnum", Guid = "4441400e-ad1e-4711-91ab-015b1086f5f6")]
    public partial class СостоянияОбъекта : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Создан
            {
                NsgDataEnumElement Создан = null;
                if (ObjectList.Contains("Создан"))
                    Создан = ObjectList["Создан"] as NsgDataEnumElement;
                else
                    Создан = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Создан.IsLoadedFromDll = true;
	Создан.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Создан.Index = 0;
	Создан.StringFormat = "";
	Создан.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Создан.IncludeInPredefined = false;
	Создан.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Создан.Required = false;
	Создан.EmptyValue = "";
	Создан.NullAllow = false;
	Создан.FieldName = "Sozdan";
	Создан.SaveInDatabase = true;
	Создан.InformMetaDataOnValueChanged = false;
	Создан.Visible = true;
	Создан.Name = "Создан";
	Создан.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Создан.Description = "Создан";
	Создан.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Создан.GroupName = "";
	Создан.Guid = NsgService.StringToGuid("f0480f89-8638-4cd2-a082-699c705910b2");
	
                if (!ObjectList.Contains("Создан"))
                    ObjectList.Add(Создан);
			}
			#endregion //создание System.String Создан
			
            #region создание System.String Сохранен
            {
                NsgDataEnumElement Сохранен = null;
                if (ObjectList.Contains("Сохранен"))
                    Сохранен = ObjectList["Сохранен"] as NsgDataEnumElement;
                else
                    Сохранен = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Сохранен.IsLoadedFromDll = true;
	Сохранен.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Сохранен.Index = 1;
	Сохранен.StringFormat = "";
	Сохранен.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Сохранен.IncludeInPredefined = false;
	Сохранен.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Сохранен.Required = false;
	Сохранен.EmptyValue = "";
	Сохранен.NullAllow = false;
	Сохранен.FieldName = "Sokhranen";
	Сохранен.SaveInDatabase = true;
	Сохранен.InformMetaDataOnValueChanged = false;
	Сохранен.Visible = true;
	Сохранен.Name = "Сохранен";
	Сохранен.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Сохранен.Description = "Сохранен";
	Сохранен.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Сохранен.GroupName = "";
	Сохранен.Guid = NsgService.StringToGuid("b31530f1-b383-4d3c-9ef9-7c3000d5acda");
	
                if (!ObjectList.Contains("Сохранен"))
                    ObjectList.Add(Сохранен);
			}
			#endregion //создание System.String Сохранен
			
            #region создание System.String Удален
            {
                NsgDataEnumElement Удален = null;
                if (ObjectList.Contains("Удален"))
                    Удален = ObjectList["Удален"] as NsgDataEnumElement;
                else
                    Удален = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Удален.IsLoadedFromDll = true;
	Удален.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Удален.Index = 2;
	Удален.StringFormat = "";
	Удален.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Удален.IncludeInPredefined = false;
	Удален.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Удален.Required = false;
	Удален.EmptyValue = "";
	Удален.NullAllow = false;
	Удален.FieldName = "Udalen";
	Удален.SaveInDatabase = true;
	Удален.InformMetaDataOnValueChanged = false;
	Удален.Visible = true;
	Удален.Name = "Удален";
	Удален.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Удален.Description = "Удален";
	Удален.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Удален.GroupName = "";
	Удален.Guid = NsgService.StringToGuid("d229e4d1-7d9d-41cb-a070-677925afcfcb");
	
                if (!ObjectList.Contains("Удален"))
                    ObjectList.Add(Удален);
			}
			#endregion //создание System.String Удален
			
            #region создание System.String Шаблон
            {
                NsgDataEnumElement Шаблон = null;
                if (ObjectList.Contains("Шаблон"))
                    Шаблон = ObjectList["Шаблон"] as NsgDataEnumElement;
                else
                    Шаблон = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Шаблон.IsLoadedFromDll = true;
	Шаблон.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Шаблон.Index = 4;
	Шаблон.StringFormat = "";
	Шаблон.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Шаблон.IncludeInPredefined = false;
	Шаблон.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Шаблон.Required = false;
	Шаблон.EmptyValue = "";
	Шаблон.NullAllow = false;
	Шаблон.FieldName = "SHablon";
	Шаблон.SaveInDatabase = true;
	Шаблон.InformMetaDataOnValueChanged = false;
	Шаблон.Visible = true;
	Шаблон.Name = "Шаблон";
	Шаблон.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Шаблон.Description = "Шаблон";
	Шаблон.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Шаблон.GroupName = "";
	Шаблон.Guid = NsgService.StringToGuid("f071afe1-4c78-4a33-b730-d5db4e8fad4a");
	
                if (!ObjectList.Contains("Шаблон"))
                    ObjectList.Add(Шаблон);
			}
			#endregion //создание System.String Шаблон
			
            #region создание System.String Проведен
            {
                NsgDataEnumElement Проведен = null;
                if (ObjectList.Contains("Проведен"))
                    Проведен = ObjectList["Проведен"] as NsgDataEnumElement;
                else
                    Проведен = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Проведен.IsLoadedFromDll = true;
	Проведен.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Проведен.Index = 8;
	Проведен.StringFormat = "";
	Проведен.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Проведен.IncludeInPredefined = false;
	Проведен.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Проведен.Required = false;
	Проведен.EmptyValue = "";
	Проведен.NullAllow = false;
	Проведен.FieldName = "Proveden";
	Проведен.SaveInDatabase = true;
	Проведен.InformMetaDataOnValueChanged = false;
	Проведен.Visible = true;
	Проведен.Name = "Проведен";
	Проведен.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Проведен.Description = "Проведен";
	Проведен.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Проведен.GroupName = "";
	Проведен.Guid = NsgService.StringToGuid("a9033137-9660-4f00-9425-6116e33e1551");
	
                if (!ObjectList.Contains("Проведен"))
                    ObjectList.Add(Проведен);
			}
			#endregion //создание System.String Проведен
			
            #region создание System.String Предопределенный
            {
                NsgDataEnumElement Предопределенный = null;
                if (ObjectList.Contains("Предопределенный"))
                    Предопределенный = ObjectList["Предопределенный"] as NsgDataEnumElement;
                else
                    Предопределенный = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Предопределенный.IsLoadedFromDll = true;
	Предопределенный.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Предопределенный.Index = 16;
	Предопределенный.StringFormat = "";
	Предопределенный.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Предопределенный.IncludeInPredefined = false;
	Предопределенный.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Предопределенный.Required = false;
	Предопределенный.EmptyValue = "";
	Предопределенный.NullAllow = false;
	Предопределенный.FieldName = "Predopredelennyij";
	Предопределенный.SaveInDatabase = true;
	Предопределенный.InformMetaDataOnValueChanged = false;
	Предопределенный.Visible = true;
	Предопределенный.Name = "Предопределенный";
	Предопределенный.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Предопределенный.Description = "Предопределенный";
	Предопределенный.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Предопределенный.GroupName = "";
	Предопределенный.Guid = NsgService.StringToGuid("0f6b1293-3ed6-4312-8e37-19569caa98d6");
	
                if (!ObjectList.Contains("Предопределенный"))
                    ObjectList.Add(Предопределенный);
			}
			#endregion //создание System.String Предопределенный
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "СостоянияОбъекта";
	Visible = true;
	Guid = NsgService.StringToGuid("4441400e-ad1e-4711-91ab-015b1086f5f6");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "ObjectStateEnum";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Состояния объекта";
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

		public static СостоянияОбъекта Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("4441400e-ad1e-4711-91ab-015b1086f5f6"));
            if (obj == null)
                obj = new СостоянияОбъекта();
            return obj as СостоянияОбъекта;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected СостоянияОбъекта()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  СостоянияОбъекта(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Сервис.СостоянияОбъекта";
        }

        
        /// <summary>
        /// Создан
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СостоянияОбъекта Создан
        {
            get
            {
                СостоянияОбъекта res = СостоянияОбъекта.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Сохранен
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СостоянияОбъекта Сохранен
        {
            get
            {
                СостоянияОбъекта res = СостоянияОбъекта.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Удален
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СостоянияОбъекта Удален
        {
            get
            {
                СостоянияОбъекта res = СостоянияОбъекта.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// Шаблон
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СостоянияОбъекта Шаблон
        {
            get
            {
                СостоянияОбъекта res = СостоянияОбъекта.Новый();
                res.Value = 4;
                return res;
            }
        }

		
        /// <summary>
        /// Проведен
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СостоянияОбъекта Проведен
        {
            get
            {
                СостоянияОбъекта res = СостоянияОбъекта.Новый();
                res.Value = 8;
                return res;
            }
        }

		
        /// <summary>
        /// Предопределенный
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static СостоянияОбъекта Предопределенный
        {
            get
            {
                СостоянияОбъекта res = СостоянияОбъекта.Новый();
                res.Value = 16;
                return res;
            }
        }

		
		#region Свойства NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Свойства NsgSoft.DataObjects.NsgDataEnum

		#endregion //Свойства

		#region Методы
		#region Методы NsgSoft.DataObjects.NsgDataEnum
		




        public static СостоянияОбъекта Parse(string str)
        {
            СостоянияОбъекта res = СостоянияОбъекта.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new СостоянияОбъекта(this as NsgObject);
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
                base.NSGType = typeof(СостоянияОбъекта);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new СостоянияОбъекта Value
            {
                get
                {
                    return (СостоянияОбъекта)base.Value;
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
