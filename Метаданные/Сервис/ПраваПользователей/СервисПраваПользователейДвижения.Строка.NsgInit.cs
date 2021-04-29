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

namespace ОбменникВалют.Метаданные._SystemTables
{
    public partial class СервисПраваПользователейДвижения
{
    [NsgTypeName("NsgDataTableRow", Guid = "89744974-6dcc-46f1-8ea2-d5570d4236f4")]
    public partial class Строка : NsgSoft.DataObjects.NsgDataTableRow
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataTableRow
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataTableRow

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataTableRow
        

		/// <summary>
        /// "Пустой" конструктор для строки таблицы, необходимо указание таблицы которой принадлежит строка
        /// </summary>
        public Строка(NsgDataTable owner)
            : base(owner)
        {
        }
        



        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataTableRow

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected Строка()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Строка(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Строка Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("89744974-6dcc-46f1-8ea2-d5570d4236f4"));
            if (obj == null)
                obj = new Строка();
            return obj as Строка;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataTableRow
			

            if (NsgSettings.Regime != NsgSoft.Common.NsgViewTypes.Load)
                base.CreatePreDefinedFields();
        



			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataTableRow
			

			#region заполнение полей класса
			
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataTableRow
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataTableRow

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
        public new partial class Names// :NsgSoft.DataObjects.NsgDataTableRow.Names
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
            return "_SystemTables.Строка";
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
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataTableRow
        




        #endregion // Свойства NsgSoft.DataObjects.NsgDataTableRow

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataTableRow
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataTableRow

        #region Методы NsgMultipleObject
        private Строка[] convertArray(NsgMultipleObject[] array)
        {
            Строка[] res = new Строка[array.Length];
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
        public new virtual Строка[] FindAll(NsgCompare compare)
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
        public new virtual Строка[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual Строка[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual Строка[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Строка(this as NsgObject);
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
                base.NSGType = typeof(Строка);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Строка Value
            {
                get
                {
                    return (Строка)base.Value;
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
                    return "s_NsgDataTableRow";
                }
            }
        }
    }
}
}
