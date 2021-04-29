using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace ОбменникВалют.Метаданные.Обменник

{
    
    public partial class ВалютыФормаЭлемента:NsgSoft.Forms.NsgMultipleObjectElementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ВалютыФормаЭлемента));
            this.Идентификатор = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Автоинкремент = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.ЭтоГруппа = new NsgSoft.Forms.NsgColumnDescriptor.Boolean();
            this.ИдентификаторРодителя = new NsgSoft.Forms.NsgColumnDescriptor.Guid();
            this.Уровень = new NsgSoft.Forms.NsgColumnDescriptor.Byte();
            this.ПрефиксКода = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.НомерКода = new NsgSoft.Forms.NsgColumnDescriptor.Int64();
            this.Код = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Наименование = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.СостояниеДокумента = new ОбменникВалют.Метаданные.Сервис.СостоянияОбъекта.ColumnDescriptor();
            this.ТекущийКурс = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Родитель = new ОбменникВалют.Метаданные.Обменник.Валюты.ColumnDescriptor();
            this.nsgInput1 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel1 = new NsgSoft.Forms.NsgLabel();
            this.nsgLabel2 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput2 = new NsgSoft.Forms.NsgInput();
            this.nsgLabel3 = new NsgSoft.Forms.NsgLabel();
            this.nsgInput3 = new NsgSoft.Forms.NsgInput();
            ((System.ComponentModel.ISupportInitialize)(this.nsgEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgToolStrip2)).BeginInit();
            this.nsgToolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgHandling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgSave)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButtonBasic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMovementsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsersActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showInListButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentStructure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).BeginInit();
            this.SuspendLayout();
            // 
            // nsgEdit
            // 
            this.nsgEdit.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgEdit.DisabledImageKey = "disabled_EditElement";
            this.nsgEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgEdit.ImageKey = "EditElement";
            this.nsgEdit.Location = new System.Drawing.Point(546, 1);
            this.nsgEdit.Name = "nsgEdit";
            this.nsgEdit.NsgToolStrip = this.nsgToolStrip2;
            this.nsgEdit.Size = new System.Drawing.Size(116, 26);
            this.nsgEdit.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgEdit.TabIndex = 2;
            this.nsgEdit.Text = "Редактировать";
            this.nsgEdit.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nsgClose
            // 
            this.nsgClose.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgClose.DisabledImageKey = "disabled_Exit";
            this.nsgClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgClose.ImageKey = "Exit";
            this.nsgClose.Location = new System.Drawing.Point(662, 1);
            this.nsgClose.Name = "nsgClose";
            this.nsgClose.NsgToolStrip = this.nsgToolStrip2;
            this.nsgClose.Size = new System.Drawing.Size(78, 26);
            this.nsgClose.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgClose.TabIndex = 0;
            this.nsgClose.Text = "Закрыть";
            this.nsgClose.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nsgToolStrip2
            // 
            this.nsgToolStrip2.AllowDrop = true;
            this.nsgToolStrip2.CausesValidation = false;
            this.nsgToolStrip2.Controls.Add(this.documentStructure);
            this.nsgToolStrip2.Controls.Add(this.showInListButton);
            this.nsgToolStrip2.Controls.Add(this.btnUsersActions);
            this.nsgToolStrip2.Controls.Add(this.documentMovementsButton);
            this.nsgToolStrip2.Controls.Add(this.documentButton);
            this.nsgToolStrip2.Controls.Add(this.nsgButtonBasic);
            this.nsgToolStrip2.Controls.Add(this.printButton);
            this.nsgToolStrip2.Controls.Add(this.nsgAll);
            this.nsgToolStrip2.Controls.Add(this.nsgHandling);
            this.nsgToolStrip2.Controls.Add(this.nsgSave);
            this.nsgToolStrip2.Controls.Add(this.nsgEdit);
            this.nsgToolStrip2.Controls.Add(this.nsgClose);
            this.nsgToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nsgToolStrip2.Location = new System.Drawing.Point(0, 2);
            this.nsgToolStrip2.Name = "nsgToolStrip2";
            this.nsgToolStrip2.Padding = new System.Windows.Forms.Padding(1);
            this.nsgToolStrip2.Size = new System.Drawing.Size(741, 28);
            this.nsgToolStrip2.TabIndex = 1;
            this.nsgToolStrip2.TabStop = false;
            this.nsgToolStrip2.Text = "nsgToolStrip2";
            // 
            // nsgAll
            // 
            this.nsgAll.Location = new System.Drawing.Point(276, 1);
            this.nsgAll.Size = new System.Drawing.Size(95, 26);
            // 
            // nsgHandling
            // 
            this.nsgHandling.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgHandling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgHandling.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgHandling.DisabledImageKey = "disabled_Handle";
            this.nsgHandling.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgHandling.ImageKey = "Handle";
            this.nsgHandling.Location = new System.Drawing.Point(371, 1);
            this.nsgHandling.Name = "nsgHandling";
            this.nsgHandling.NsgToolStrip = this.nsgToolStrip2;
            this.nsgHandling.Size = new System.Drawing.Size(84, 26);
            this.nsgHandling.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgHandling.TabIndex = 9;
            this.nsgHandling.Text = "Провести";
            this.nsgHandling.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nsgSave
            // 
            this.nsgSave.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgSave.DisabledImageKey = "disabled_Save";
            this.nsgSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.nsgSave.ImageKey = "Save";
            this.nsgSave.Location = new System.Drawing.Point(455, 1);
            this.nsgSave.Name = "nsgSave";
            this.nsgSave.NsgToolStrip = this.nsgToolStrip2;
            this.nsgSave.Size = new System.Drawing.Size(91, 26);
            this.nsgSave.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgSave.TabIndex = 5;
            this.nsgSave.Text = "Сохранить";
            this.nsgSave.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtons
            // 
            this.panelButtons.AllowDrop = true;
            this.panelButtons.Controls.Add(this.nsgToolStrip2);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 380);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(741, 30);
            this.panelButtons.TabIndex = 2;
            // 
            // nsgButtonBasic
            // 
            this.nsgButtonBasic.Location = new System.Drawing.Point(276, 1);
            // 
            // documentButton
            // 
            this.documentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.documentButton.ButtonEnabled = true;
            this.documentButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("documentButton.ButtonImage")));
            this.documentButton.ButtonText = "";
            this.documentButton.DefaultCaption = "Действие";
            this.documentButton.DefaultImagekey = "";
            this.documentButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.documentButton.Location = new System.Drawing.Point(21, 1);
            this.documentButton.Name = "documentButton";
            this.documentButton.ShowImage = false;
            this.documentButton.ShowText = false;
            this.documentButton.Size = new System.Drawing.Size(147, 26);
            this.documentButton.TabIndex = 13;
            // 
            // printButton
            // 
            this.printButton.AutoSize = true;
            this.printButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printButton.ButtonEnabled = true;
            this.printButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("printButton.ButtonImage")));
            this.printButton.ButtonText = "Кнопка";
            this.printButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.printButton.ImageKey = "Print";
            this.printButton.Location = new System.Drawing.Point(1, 1);
            this.printButton.Name = "printButton";
            this.printButton.ShowImage = false;
            this.printButton.ShowText = false;
            this.printButton.Size = new System.Drawing.Size(20, 26);
            this.printButton.TabIndex = 11;
            // 
            // documentMovementsButton
            // 
            this.documentMovementsButton.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.documentMovementsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.documentMovementsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.documentMovementsButton.Container = this.documentButton;
            this.documentMovementsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.documentMovementsButton.Location = new System.Drawing.Point(168, 1);
            this.documentMovementsButton.Name = "documentMovementsButton";
            this.documentMovementsButton.Size = new System.Drawing.Size(68, 26);
            this.documentMovementsButton.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.documentMovementsButton.TabIndex = 14;
            this.documentMovementsButton.Text = "Движения документа";
            this.documentMovementsButton.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUsersActions
            // 
            this.btnUsersActions.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUsersActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsersActions.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsersActions.Container = this.documentButton;
            this.btnUsersActions.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUsersActions.Location = new System.Drawing.Point(236, 1);
            this.btnUsersActions.Name = "btnUsersActions";
            this.btnUsersActions.Size = new System.Drawing.Size(68, 26);
            this.btnUsersActions.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.btnUsersActions.TabIndex = 15;
            this.btnUsersActions.Text = "История Изменений";
            this.btnUsersActions.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showInListButton
            // 
            this.showInListButton.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.showInListButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showInListButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.showInListButton.Container = this.documentButton;
            this.showInListButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.showInListButton.Location = new System.Drawing.Point(304, 1);
            this.showInListButton.Name = "showInListButton";
            this.showInListButton.Size = new System.Drawing.Size(68, 26);
            this.showInListButton.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.showInListButton.TabIndex = 16;
            this.showInListButton.Text = "Показать в списке";
            this.showInListButton.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Comment
            // 
            this.Comment.BackColor = System.Drawing.SystemColors.Window;
            this.Comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Comment.ConfigurationName = "ОбменникВалют";
            this.Comment.DisableLeaveControlEvent = false;
            this.Comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Comment.FullName = "Обменник.Валюты.Идентификатор";
            this.Comment.FullTextSearch = false;
            this.Comment.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.Comment.IsButton = false;
            this.Comment.IsInitialized = true;
            this.Comment.IsPassword = false;
            this.Comment.Location = new System.Drawing.Point(0, 0);
            this.Comment.Margin = new System.Windows.Forms.Padding(0);
            this.Comment.Mask = "";
            this.Comment.MetaDataName = "Метаданные";
            this.Comment.MinimumSize = new System.Drawing.Size(4, 20);
            this.Comment.Name = "NsgInput";
            this.Comment.ObjectImages = null;
            this.Comment.ObjectIndex = null;
            this.Comment.ObjectStrings = null;
            this.Comment.Requsite = "Идентификатор";
            this.Comment.SearchFieldName = "";
            this.Comment.ShowMultipleObjectInComboBox = false;
            this.Comment.ShowRowCount = 10;
            this.Comment.Size = new System.Drawing.Size(741, 23);
            this.Comment.SourceObject = this.nsgVisualMultipleObject;
            this.Comment.TabIndex = 0;
            this.Comment.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // documentStructure
            // 
            this.documentStructure.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.documentStructure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.documentStructure.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.documentStructure.Container = this.documentButton;
            this.documentStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.documentStructure.Location = new System.Drawing.Point(372, 1);
            this.documentStructure.Name = "documentStructure";
            this.documentStructure.Size = new System.Drawing.Size(75, 26);
            this.documentStructure.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.documentStructure.TabIndex = 17;
            this.documentStructure.Text = "Структура документов";
            this.documentStructure.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nsgVisualMultipleObject
            // 
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Идентификатор);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Автоинкремент);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ЭтоГруппа);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ИдентификаторРодителя);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Уровень);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ПрефиксКода);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.НомерКода);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Код);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Наименование);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.СостояниеДокумента);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.ТекущийКурс);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Родитель);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.MetaDataName = "Метаданные";
            this.nsgVisualMultipleObject.FullName = "Обменник.Валюты";
            // 
            // Идентификатор
            // 
            this.Идентификатор.AutoGenerated = true;
            this.Идентификатор.Caption = "Идентификатор";
            this.Идентификатор.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Идентификатор.Name = "Идентификатор";
            this.Идентификатор.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.Идентификатор.PropertyType = typeof(System.Guid);
            this.Идентификатор.SearchCondition.OwnerComponent = this.Идентификатор;
            this.Идентификатор.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Идентификатор.Visible = false;
            // 
            // Автоинкремент
            // 
            this.Автоинкремент.AutoGenerated = true;
            this.Автоинкремент.CalcTotal = false;
            this.Автоинкремент.Caption = "Автоинкремент";
            this.Автоинкремент.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Автоинкремент.Name = "Автоинкремент";
            this.Автоинкремент.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.Автоинкремент.PropertyType = typeof(long);
            this.Автоинкремент.SearchCondition.OwnerComponent = this.Автоинкремент;
            this.Автоинкремент.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Автоинкремент.Visible = false;
            // 
            // ЭтоГруппа
            // 
            this.ЭтоГруппа.AutoGenerated = true;
            this.ЭтоГруппа.Caption = "ЭтоГруппа";
            this.ЭтоГруппа.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ЭтоГруппа.Name = "ЭтоГруппа";
            this.ЭтоГруппа.NSGType = typeof(NsgSoft.DataObjects.NsgDataBoolean);
            this.ЭтоГруппа.PropertyType = typeof(bool);
            this.ЭтоГруппа.SearchCondition.OwnerComponent = this.ЭтоГруппа;
            this.ЭтоГруппа.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ЭтоГруппа.Visible = false;
            // 
            // ИдентификаторРодителя
            // 
            this.ИдентификаторРодителя.AutoGenerated = true;
            this.ИдентификаторРодителя.Caption = "ИдентификаторРодителя";
            this.ИдентификаторРодителя.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ИдентификаторРодителя.Name = "ИдентификаторРодителя";
            this.ИдентификаторРодителя.NSGType = typeof(NsgSoft.DataObjects.NsgDataGuid);
            this.ИдентификаторРодителя.PropertyType = typeof(System.Guid);
            this.ИдентификаторРодителя.SearchCondition.OwnerComponent = this.ИдентификаторРодителя;
            this.ИдентификаторРодителя.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ИдентификаторРодителя.Visible = false;
            // 
            // Уровень
            // 
            this.Уровень.AutoGenerated = true;
            this.Уровень.Caption = "Уровень";
            this.Уровень.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Уровень.Name = "Уровень";
            this.Уровень.NSGType = typeof(NsgSoft.DataObjects.NsgDataByte);
            this.Уровень.PropertyType = typeof(byte);
            this.Уровень.SearchCondition.OwnerComponent = this.Уровень;
            this.Уровень.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.Уровень.Visible = false;
            // 
            // ПрефиксКода
            // 
            this.ПрефиксКода.AutoGenerated = true;
            this.ПрефиксКода.Caption = "ПрефиксКода";
            this.ПрефиксКода.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ПрефиксКода.Name = "ПрефиксКода";
            this.ПрефиксКода.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.ПрефиксКода.PropertyType = typeof(string);
            this.ПрефиксКода.SearchCondition.OwnerComponent = this.ПрефиксКода;
            this.ПрефиксКода.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.ПрефиксКода.Visible = false;
            // 
            // НомерКода
            // 
            this.НомерКода.AutoGenerated = true;
            this.НомерКода.CalcTotal = false;
            this.НомерКода.Caption = "НомерКода";
            this.НомерКода.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.НомерКода.Name = "НомерКода";
            this.НомерКода.NSGType = typeof(NsgSoft.DataObjects.NsgDataInteger);
            this.НомерКода.PropertyType = typeof(long);
            this.НомерКода.SearchCondition.OwnerComponent = this.НомерКода;
            this.НомерКода.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            this.НомерКода.Visible = false;
            // 
            // Код
            // 
            this.Код.AutoGenerated = true;
            this.Код.Caption = "Код";
            this.Код.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Код.Name = "Код";
            this.Код.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Код.PropertyType = typeof(string);
            this.Код.SearchCondition.OwnerComponent = this.Код;
            this.Код.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Наименование
            // 
            this.Наименование.AutoGenerated = true;
            this.Наименование.Caption = "Наименование";
            this.Наименование.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Наименование.Name = "Наименование";
            this.Наименование.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Наименование.PropertyType = typeof(string);
            this.Наименование.SearchCondition.OwnerComponent = this.Наименование;
            this.Наименование.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // СостояниеДокумента
            // 
            this.СостояниеДокумента.AutoGenerated = true;
            this.СостояниеДокумента.Caption = "СостояниеДокумента";
            this.СостояниеДокумента.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.СостояниеДокумента.Name = "СостояниеДокумента";
            this.СостояниеДокумента.NSGType = typeof(ОбменникВалют.Метаданные.Сервис.СостоянияОбъекта);
            this.СостояниеДокумента.PropertyType = typeof(ОбменникВалют.Метаданные.Сервис.СостоянияОбъекта);
            this.СостояниеДокумента.SearchCondition.OwnerComponent = this.СостояниеДокумента;
            this.СостояниеДокумента.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ТекущийКурс
            // 
            this.ТекущийКурс.AutoGenerated = true;
            this.ТекущийКурс.CalcTotal = false;
            this.ТекущийКурс.Caption = "ТекущийКурс";
            this.ТекущийКурс.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.ТекущийКурс.Name = "ТекущийКурс";
            this.ТекущийКурс.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ТекущийКурс.PropertyType = typeof(decimal);
            this.ТекущийКурс.SearchCondition.OwnerComponent = this.ТекущийКурс;
            this.ТекущийКурс.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Родитель
            // 
            this.Родитель.AutoGenerated = true;
            this.Родитель.Caption = "Родитель";
            this.Родитель.Creator = typeof(NsgSoft.Forms.NsgMultipleObjectElementForm);
            this.Родитель.Name = "Родитель";
            this.Родитель.NSGType = typeof(ОбменникВалют.Метаданные.Обменник.Валюты);
            this.Родитель.PropertyType = typeof(ОбменникВалют.Метаданные.Обменник.Валюты);
            this.Родитель.SearchCondition.OwnerComponent = this.Родитель;
            this.Родитель.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgInput1
            // 
            this.nsgInput1.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput1.ConfigurationName = "";
            this.nsgInput1.DisableLeaveControlEvent = false;
            this.nsgInput1.FullName = "Код";
            this.nsgInput1.FullTextSearch = false;
            this.nsgInput1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput1.IsButton = false;
            this.nsgInput1.IsInitialized = false;
            this.nsgInput1.IsPassword = false;
            this.nsgInput1.Location = new System.Drawing.Point(248, 31);
            this.nsgInput1.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput1.Mask = "";
            this.nsgInput1.MetaDataName = "";
            this.nsgInput1.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput1.Name = "NsgInput";
            this.nsgInput1.ObjectImages = null;
            this.nsgInput1.ObjectIndex = null;
            this.nsgInput1.ObjectStrings = null;
            this.nsgInput1.Requsite = "Код";
            this.nsgInput1.SearchFieldName = "";
            this.nsgInput1.ShowMultipleObjectInComboBox = false;
            this.nsgInput1.ShowRowCount = 10;
            this.nsgInput1.Size = new System.Drawing.Size(271, 20);
            this.nsgInput1.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput1.TabIndex = 9;
            this.nsgInput1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel1
            // 
            this.nsgLabel1.AutoSize = true;
            this.nsgLabel1.ConfigurationName = "";
            this.nsgLabel1.FullName = "";
            this.nsgLabel1.IsInitialized = false;
            this.nsgLabel1.Location = new System.Drawing.Point(133, 38);
            this.nsgLabel1.MetaDataName = "";
            this.nsgLabel1.Name = "nsgLabel1";
            this.nsgLabel1.Requsite = "";
            this.nsgLabel1.Size = new System.Drawing.Size(26, 13);
            this.nsgLabel1.TabIndex = 10;
            this.nsgLabel1.Text = "Код";
            // 
            // nsgLabel2
            // 
            this.nsgLabel2.AutoSize = true;
            this.nsgLabel2.ConfigurationName = "";
            this.nsgLabel2.FullName = "";
            this.nsgLabel2.IsInitialized = false;
            this.nsgLabel2.Location = new System.Drawing.Point(133, 67);
            this.nsgLabel2.MetaDataName = "";
            this.nsgLabel2.Name = "nsgLabel1";
            this.nsgLabel2.Requsite = "";
            this.nsgLabel2.Size = new System.Drawing.Size(83, 13);
            this.nsgLabel2.TabIndex = 12;
            this.nsgLabel2.Text = "Наименование";
            // 
            // nsgInput2
            // 
            this.nsgInput2.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput2.ConfigurationName = "";
            this.nsgInput2.DisableLeaveControlEvent = false;
            this.nsgInput2.FullName = "Наименование";
            this.nsgInput2.FullTextSearch = false;
            this.nsgInput2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput2.IsButton = false;
            this.nsgInput2.IsInitialized = true;
            this.nsgInput2.IsPassword = false;
            this.nsgInput2.Location = new System.Drawing.Point(248, 60);
            this.nsgInput2.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput2.Mask = "";
            this.nsgInput2.MetaDataName = "";
            this.nsgInput2.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput2.Name = "NsgInput";
            this.nsgInput2.ObjectImages = null;
            this.nsgInput2.ObjectIndex = null;
            this.nsgInput2.ObjectStrings = null;
            this.nsgInput2.Requsite = "Наименование";
            this.nsgInput2.SearchFieldName = "";
            this.nsgInput2.ShowMultipleObjectInComboBox = false;
            this.nsgInput2.ShowRowCount = 10;
            this.nsgInput2.Size = new System.Drawing.Size(271, 20);
            this.nsgInput2.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput2.TabIndex = 11;
            this.nsgInput2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nsgLabel3
            // 
            this.nsgLabel3.AutoSize = true;
            this.nsgLabel3.ConfigurationName = "";
            this.nsgLabel3.FullName = "";
            this.nsgLabel3.IsInitialized = false;
            this.nsgLabel3.Location = new System.Drawing.Point(133, 97);
            this.nsgLabel3.MetaDataName = "";
            this.nsgLabel3.Name = "nsgLabel1";
            this.nsgLabel3.Requsite = "";
            this.nsgLabel3.Size = new System.Drawing.Size(78, 13);
            this.nsgLabel3.TabIndex = 14;
            this.nsgLabel3.Text = "Текущий курс";
            // 
            // nsgInput3
            // 
            this.nsgInput3.BackColor = System.Drawing.SystemColors.Window;
            this.nsgInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgInput3.ConfigurationName = "";
            this.nsgInput3.DisableLeaveControlEvent = false;
            this.nsgInput3.FullName = "ТекущийКурс";
            this.nsgInput3.FullTextSearch = false;
            this.nsgInput3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.nsgInput3.IsButton = false;
            this.nsgInput3.IsInitialized = true;
            this.nsgInput3.IsPassword = false;
            this.nsgInput3.Location = new System.Drawing.Point(248, 90);
            this.nsgInput3.Margin = new System.Windows.Forms.Padding(0);
            this.nsgInput3.Mask = "";
            this.nsgInput3.MetaDataName = "";
            this.nsgInput3.MinimumSize = new System.Drawing.Size(4, 20);
            this.nsgInput3.Name = "NsgInput";
            this.nsgInput3.ObjectImages = null;
            this.nsgInput3.ObjectIndex = null;
            this.nsgInput3.ObjectStrings = null;
            this.nsgInput3.Requsite = "ТекущийКурс";
            this.nsgInput3.SearchFieldName = "";
            this.nsgInput3.ShowMultipleObjectInComboBox = false;
            this.nsgInput3.ShowRowCount = 10;
            this.nsgInput3.Size = new System.Drawing.Size(271, 20);
            this.nsgInput3.SourceObject = this.nsgVisualMultipleObject;
            this.nsgInput3.TabIndex = 13;
            this.nsgInput3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ВалютыФормаЭлемента
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(741, 410);
            this.Controls.Add(this.nsgLabel3);
            this.Controls.Add(this.nsgInput3);
            this.Controls.Add(this.nsgLabel2);
            this.Controls.Add(this.nsgInput2);
            this.Controls.Add(this.nsgLabel1);
            this.Controls.Add(this.nsgInput1);
            this.Controls.Add(this.panelButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HandleButtonVisible = true;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NsgMultipleObjectElementForm";
            this.SelectedObject = null;
            this.TabText = "NsgMultipleObjectBaseForm";
            this.Text = "NsgMultipleObjectElementForm";
            this.Controls.SetChildIndex(this.panelButtons, 0);
            this.Controls.SetChildIndex(this.nsgInput1, 0);
            this.Controls.SetChildIndex(this.nsgLabel1, 0);
            this.Controls.SetChildIndex(this.nsgInput2, 0);
            this.Controls.SetChildIndex(this.nsgLabel2, 0);
            this.Controls.SetChildIndex(this.nsgInput3, 0);
            this.Controls.SetChildIndex(this.nsgLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nsgEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgToolStrip2)).EndInit();
            this.nsgToolStrip2.ResumeLayout(false);
            this.nsgToolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgHandling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgSave)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButtonBasic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentMovementsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsersActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showInListButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentStructure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgInput3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected NsgColumnDescriptor.Guid Идентификатор;
        protected NsgColumnDescriptor.Int64 Автоинкремент;
        protected NsgColumnDescriptor.Boolean ЭтоГруппа;
        protected NsgColumnDescriptor.Guid ИдентификаторРодителя;
        protected NsgColumnDescriptor.Byte Уровень;
        protected NsgColumnDescriptor.String ПрефиксКода;
        protected NsgColumnDescriptor.Int64 НомерКода;
        protected NsgColumnDescriptor.String Код;
        protected NsgColumnDescriptor.String Наименование;
        protected Сервис.СостоянияОбъекта.ColumnDescriptor СостояниеДокумента;
        protected NsgColumnDescriptor.Decimal ТекущийКурс;
        protected Валюты.ColumnDescriptor Родитель;
        protected NsgInput nsgInput1;
        private NsgLabel nsgLabel1;
        protected NsgLabel nsgLabel2;
        protected NsgInput nsgInput2;
        protected NsgLabel nsgLabel3;
        protected NsgInput nsgInput3;
    }
}