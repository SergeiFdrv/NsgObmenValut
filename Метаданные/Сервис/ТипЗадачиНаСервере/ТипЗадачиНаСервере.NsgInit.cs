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
    
    [NsgTypeName("NsgDataEnum", Guid = "6342295c-c07a-41b2-bc74-4521dbd7b56c")]
    public partial class ТипЗадачиНаСервере : NsgSoft.DataObjects.NsgDataEnum
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

			
            #region создание System.String Провести
            {
                NsgDataEnumElement Провести = null;
                if (ObjectList.Contains("Провести"))
                    Провести = ObjectList["Провести"] as NsgDataEnumElement;
                else
                    Провести = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Провести.IsLoadedFromDll = true;
	Провести.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Провести.Index = 0;
	Провести.StringFormat = "";
	Провести.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Провести.IncludeInPredefined = false;
	Провести.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Провести.Required = false;
	Провести.EmptyValue = "";
	Провести.NullAllow = false;
	Провести.FieldName = "_Handle";
	Провести.SaveInDatabase = true;
	Провести.InformMetaDataOnValueChanged = false;
	Провести.Visible = true;
	Провести.Name = "Провести";
	Провести.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Провести"});
	Провести.Description = "Провести";
	Провести.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Провести.GroupName = "";
	Провести.Guid = NsgService.StringToGuid("fa4a0196-ec82-4eba-be28-90b96fcd4c58");
	
                if (!ObjectList.Contains("Провести"))
                    ObjectList.Add(Провести);
			}
			#endregion //создание System.String Провести
			
            #region создание System.String ОтменитьПроведение
            {
                NsgDataEnumElement ОтменитьПроведение = null;
                if (ObjectList.Contains("ОтменитьПроведение"))
                    ОтменитьПроведение = ObjectList["ОтменитьПроведение"] as NsgDataEnumElement;
                else
                    ОтменитьПроведение = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ОтменитьПроведение.IsLoadedFromDll = true;
	ОтменитьПроведение.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ОтменитьПроведение.Index = 1;
	ОтменитьПроведение.StringFormat = "";
	ОтменитьПроведение.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ОтменитьПроведение.IncludeInPredefined = false;
	ОтменитьПроведение.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ОтменитьПроведение.Required = false;
	ОтменитьПроведение.EmptyValue = "";
	ОтменитьПроведение.NullAllow = false;
	ОтменитьПроведение.FieldName = "_UnHandle";
	ОтменитьПроведение.SaveInDatabase = true;
	ОтменитьПроведение.InformMetaDataOnValueChanged = false;
	ОтменитьПроведение.Visible = true;
	ОтменитьПроведение.Name = "ОтменитьПроведение";
	ОтменитьПроведение.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Отменить проведение"});
	ОтменитьПроведение.Description = "Отменить проведение";
	ОтменитьПроведение.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ОтменитьПроведение.GroupName = "";
	ОтменитьПроведение.Guid = NsgService.StringToGuid("5146a9f9-ca84-403a-9554-9a6e3309ce99");
	
                if (!ObjectList.Contains("ОтменитьПроведение"))
                    ObjectList.Add(ОтменитьПроведение);
			}
			#endregion //создание System.String ОтменитьПроведение
			
            #region создание System.String ПометитьНаУдаление
            {
                NsgDataEnumElement ПометитьНаУдаление = null;
                if (ObjectList.Contains("ПометитьНаУдаление"))
                    ПометитьНаУдаление = ObjectList["ПометитьНаУдаление"] as NsgDataEnumElement;
                else
                    ПометитьНаУдаление = new NsgDataEnumElement();
                	//NsgDataEnumElement
	ПометитьНаУдаление.IsLoadedFromDll = true;
	ПометитьНаУдаление.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ПометитьНаУдаление.Index = 2;
	ПометитьНаУдаление.StringFormat = "";
	ПометитьНаУдаление.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПометитьНаУдаление.IncludeInPredefined = false;
	ПометитьНаУдаление.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПометитьНаУдаление.Required = false;
	ПометитьНаУдаление.EmptyValue = "";
	ПометитьНаУдаление.NullAllow = false;
	ПометитьНаУдаление.FieldName = "_SetDeleteMark";
	ПометитьНаУдаление.SaveInDatabase = true;
	ПометитьНаУдаление.InformMetaDataOnValueChanged = false;
	ПометитьНаУдаление.Visible = true;
	ПометитьНаУдаление.Name = "ПометитьНаУдаление";
	ПометитьНаУдаление.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Пометить на удаление"});
	ПометитьНаУдаление.Description = "Пометить на удаление";
	ПометитьНаУдаление.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ПометитьНаУдаление.GroupName = "";
	ПометитьНаУдаление.Guid = NsgService.StringToGuid("1a606d3b-c57b-4f00-90da-d6c92b982ec2");
	
                if (!ObjectList.Contains("ПометитьНаУдаление"))
                    ObjectList.Add(ПометитьНаУдаление);
			}
			#endregion //создание System.String ПометитьНаУдаление
			
            #region создание System.String Нет
            {
                NsgDataEnumElement Нет = null;
                if (ObjectList.Contains("Нет"))
                    Нет = ObjectList["Нет"] as NsgDataEnumElement;
                else
                    Нет = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Нет.IsLoadedFromDll = true;
	Нет.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Нет.Index = 3;
	Нет.StringFormat = "";
	Нет.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Нет.IncludeInPredefined = false;
	Нет.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Нет.Required = false;
	Нет.EmptyValue = "";
	Нет.NullAllow = false;
	Нет.FieldName = "_None";
	Нет.SaveInDatabase = true;
	Нет.InformMetaDataOnValueChanged = false;
	Нет.Visible = true;
	Нет.Name = "Нет";
	Нет.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Нет"});
	Нет.Description = "Нет";
	Нет.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Нет.GroupName = "";
	Нет.Guid = NsgService.StringToGuid("5c464c2b-5472-4500-896e-ae307ca77289");
	
                if (!ObjectList.Contains("Нет"))
                    ObjectList.Add(Нет);
			}
			#endregion //создание System.String Нет
			
            #region создание System.String Печать
            {
                NsgDataEnumElement Печать = null;
                if (ObjectList.Contains("Печать"))
                    Печать = ObjectList["Печать"] as NsgDataEnumElement;
                else
                    Печать = new NsgDataEnumElement();
                	//NsgDataEnumElement
	Печать.IsLoadedFromDll = true;
	Печать.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Печать.Index = 4;
	Печать.StringFormat = "";
	Печать.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Печать.IncludeInPredefined = false;
	Печать.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Печать.Required = false;
	Печать.EmptyValue = "";
	Печать.NullAllow = false;
	Печать.FieldName = "_Print";
	Печать.SaveInDatabase = true;
	Печать.InformMetaDataOnValueChanged = false;
	Печать.Visible = true;
	Печать.Name = "Печать";
	Печать.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Печать"});
	Печать.Description = "Печать";
	Печать.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Печать.GroupName = "";
	Печать.Guid = NsgService.StringToGuid("a770088e-c674-4071-a09a-427cb34b83ec");
	
                if (!ObjectList.Contains("Печать"))
                    ObjectList.Add(Печать);
			}
			#endregion //создание System.String Печать
			

			#region заполнение полей класса
				//NsgDataEnum
	IsLoadedFromDll = true;
	EntityType = NsgSoft.DataObjects.NsgInterfacedObject.EntityTypes.Object;
	Name = "ТипЗадачиНаСервере";
	Visible = true;
	Guid = NsgService.StringToGuid("6342295c-c07a-41b2-bc74-4521dbd7b56c");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "ServerJobAction";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"ТипЗадачиНаСервере"});
	Description = "ТипЗадачиНаСервере";
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

		public static ТипЗадачиНаСервере Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("6342295c-c07a-41b2-bc74-4521dbd7b56c"));
            if (obj == null)
                obj = new ТипЗадачиНаСервере();
            return obj as ТипЗадачиНаСервере;
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected ТипЗадачиНаСервере()
            : base()
        {
        }

        /// <summary>
		/// Создание объекта
        /// </summary>
        protected  ТипЗадачиНаСервере(NsgObject obj)
            : base(obj)
        {

        }

		#endregion //Конструкторы

		#region Свойства
		public static string GetFullName()
        {
            return "Сервис.ТипЗадачиНаСервере";
        }

        
        /// <summary>
        /// Провести
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипЗадачиНаСервере Провести
        {
            get
            {
                ТипЗадачиНаСервере res = ТипЗадачиНаСервере.Новый();
                res.Value = 0;
                return res;
            }
        }

		
        /// <summary>
        /// Отменить проведение
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипЗадачиНаСервере ОтменитьПроведение
        {
            get
            {
                ТипЗадачиНаСервере res = ТипЗадачиНаСервере.Новый();
                res.Value = 1;
                return res;
            }
        }

		
        /// <summary>
        /// Пометить на удаление
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипЗадачиНаСервере ПометитьНаУдаление
        {
            get
            {
                ТипЗадачиНаСервере res = ТипЗадачиНаСервере.Новый();
                res.Value = 2;
                return res;
            }
        }

		
        /// <summary>
        /// Нет
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипЗадачиНаСервере Нет
        {
            get
            {
                ТипЗадачиНаСервере res = ТипЗадачиНаСервере.Новый();
                res.Value = 3;
                return res;
            }
        }

		
        /// <summary>
        /// Печать
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnumElement")]
        public static ТипЗадачиНаСервере Печать
        {
            get
            {
                ТипЗадачиНаСервере res = ТипЗадачиНаСервере.Новый();
                res.Value = 4;
                return res;
            }
        }

		
		#region Свойства NsgSoft.DataObjects.NsgDataEnum
		




		#endregion //Свойства NsgSoft.DataObjects.NsgDataEnum

		#endregion //Свойства

		#region Методы
		#region Методы NsgSoft.DataObjects.NsgDataEnum
		




        public static ТипЗадачиНаСервере Parse(string str)
        {
            ТипЗадачиНаСервере res = ТипЗадачиНаСервере.Новый();
			res.Value = (res.ObjectList[str] as NsgDataEnumElement).Index;
            return res;
        }
		#endregion //Методы NsgSoft.DataObjects.NsgDataEnum

		#region Методы NsgMultipleObject

		public override NsgObject CloneObject
        {
            get
            {
                return new ТипЗадачиНаСервере(this as NsgObject);
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
                base.NSGType = typeof(ТипЗадачиНаСервере);
            }

            /// <summary>
			/// Значение для текущей строки
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public new ТипЗадачиНаСервере Value
            {
                get
                {
                    return (ТипЗадачиНаСервере)base.Value;
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
