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
    
    [NsgTypeName("NsgDataEnum", Guid = "c85172af-e97b-450f-ba4a-ffd8974c0f6a")]
    public partial class ДействиеЭлементаМеню : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Открыть
            {
                NsgDataEnumElement Открыть = null;
                if (ObjectList.Contains("Открыть"))
                    Открыть = ObjectList["Открыть"] as NsgDataEnumElement;
                else
                    Открыть = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Открыть.IsLoadedFromDll = true;
	Открыть.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Открыть.Index = 0;
	Открыть.StringFormat = "";
	Открыть.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Открыть.IncludeInPredefined = false;
	Открыть.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Открыть.Required = false;
	Открыть.EmptyValue = "";
	Открыть.NullAllow = false;
	Открыть.FieldName = "Otkryt";
	Открыть.SaveInDatabase = true;
	Открыть.InformMetaDataOnValueChanged = false;
	Открыть.Visible = true;
	Открыть.Name = "Открыть";
	Открыть.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Открыть.Description = "Открыть";
	Открыть.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Открыть.GroupName = "";
	Открыть.Guid = NsgService.StringToGuid("c07de838-389e-4578-958c-c747548f336b");
	
                if (!ObjectList.Contains("Открыть"))
                    ObjectList.Add(Открыть);
			}
			#endregion //создание System.String Открыть
			
            #region создание System.String СоздатьНовый
            {
                NsgDataEnumElement СоздатьНовый = null;
                if (ObjectList.Contains("СоздатьНовый"))
                    СоздатьНовый = ObjectList["СоздатьНовый"] as NsgDataEnumElement;
                else
                    СоздатьНовый = new NsgDataEnumElement();
                	//NsgDataEnumElement
	СоздатьНовый.IsLoadedFromDll = true;
	СоздатьНовый.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	СоздатьНовый.Index = 1;
	СоздатьНовый.StringFormat = "";
	СоздатьНовый.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	СоздатьНовый.IncludeInPredefined = false;
	СоздатьНовый.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СоздатьНовый.Required = false;
	СоздатьНовый.EmptyValue = "";
	СоздатьНовый.NullAllow = false;
	СоздатьНовый.FieldName = "SozdatNovyij";
	СоздатьНовый.SaveInDatabase = true;
	СоздатьНовый.InformMetaDataOnValueChanged = false;
	СоздатьНовый.Visible = true;
	СоздатьНовый.Name = "СоздатьНовый";
	СоздатьНовый.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	СоздатьНовый.Description = "Создать новый";
	СоздатьНовый.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	СоздатьНовый.GroupName = "";
	СоздатьНовый.Guid = NsgService.StringToGuid("b89528bf-6760-422c-b9a9-b58dee1c1c3d");
	
                if (!ObjectList.Contains("СоздатьНовый"))
                    ObjectList.Add(СоздатьНовый);
			}
			#endregion //создание System.String СоздатьНовый
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ДействиеЭлементаМеню";
	Visible = true;
	Guid = NsgService.StringToGuid("c85172af-e97b-450f-ba4a-ffd8974c0f6a");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = true;
	TableName = "UserMenuAction";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Действие элемента меню";
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

		public static ДействиеЭлементаМеню Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("c85172af-e97b-450f-ba4a-ffd8974c0f6a"));
            if (obj == null)
                obj = new ДействиеЭлементаМеню();
            return obj as ДействиеЭлементаМеню;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected ДействиеЭлементаМеню()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  ДействиеЭлементаМеню(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Сервис.ДействиеЭлементаМеню";
        }

        
        /// <summary>
        /// Открыть
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ДействиеЭлементаМеню Открыть
        {
            get
            {
                ДействиеЭлементаМеню res = ДействиеЭлементаМеню.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Создать новый
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ДействиеЭлементаМеню СоздатьНовый
        {
            get
            {
                ДействиеЭлементаМеню res = ДействиеЭлементаМеню.Новый();
                res.Value = 1;
                return res;
            }
        }

		
		#region Свойства NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Свойства NsgSoft.DataObjects.NsgDataEnum

		#endregion //Свойства

		#region Методы
		#region Методы NsgSoft.DataObjects.NsgDataEnum
		




        public static ДействиеЭлементаМеню Parse(string str)
        {
            ДействиеЭлементаМеню res = ДействиеЭлементаМеню.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new ДействиеЭлементаМеню(this as NsgObject);
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
                base.NSGType = typeof(ДействиеЭлементаМеню);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new ДействиеЭлементаМеню Value
            {
                get
                {
                    return (ДействиеЭлементаМеню)base.Value;
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
