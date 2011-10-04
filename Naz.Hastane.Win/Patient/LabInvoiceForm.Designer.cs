namespace Naz.Hastane.Win.MDIChildForms
{
    partial class LabInvoiceForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.invoiceControl = new Naz.Hastane.Win.Controls.LabInvoiceControl();
            this.sbClear = new DevExpress.XtraEditors.SimpleButton();
            this.tePatientNo = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.iSGK = new DevExpress.XtraBars.BarButtonItem();
            this.iSGKAcil = new DevExpress.XtraBars.BarButtonItem();
            this.iNormal = new DevExpress.XtraBars.BarButtonItem();
            this.iOzelHasta = new DevExpress.XtraBars.BarButtonItem();
            this.iAll = new DevExpress.XtraBars.BarButtonItem();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.deEndDate = new DevExpress.XtraEditors.DateEdit();
            this.deStartDate = new DevExpress.XtraEditors.DateEdit();
            this.gcPatients = new DevExpress.XtraGrid.GridControl();
            this.gvPatients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPatientNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatientInsuranceCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciStartDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEndDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPatientNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePatientNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.invoiceControl);
            this.layoutControl1.Controls.Add(this.sbClear);
            this.layoutControl1.Controls.Add(this.tePatientNo);
            this.layoutControl1.Controls.Add(this.dropDownButton1);
            this.layoutControl1.Controls.Add(this.deEndDate);
            this.layoutControl1.Controls.Add(this.deStartDate);
            this.layoutControl1.Controls.Add(this.gcPatients);
            this.layoutControl1.Controls.Add(this.sbRefresh);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1672, -141, 387, 543);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1071, 721);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // invoiceControl
            // 
            this.invoiceControl.Location = new System.Drawing.Point(275, 12);
            this.invoiceControl.Name = "invoiceControl";
            this.invoiceControl.Size = new System.Drawing.Size(784, 697);
            this.invoiceControl.TabIndex = 17;
            // 
            // sbClear
            // 
            this.sbClear.Location = new System.Drawing.Point(163, 38);
            this.sbClear.Name = "sbClear";
            this.sbClear.Size = new System.Drawing.Size(108, 22);
            this.sbClear.StyleController = this.layoutControl1;
            this.sbClear.TabIndex = 16;
            this.sbClear.Text = "Temizle";
            this.sbClear.Click += new System.EventHandler(this.sbClear_Click);
            // 
            // tePatientNo
            // 
            this.tePatientNo.Location = new System.Drawing.Point(89, 60);
            this.tePatientNo.MenuManager = this.barManager1;
            this.tePatientNo.Name = "tePatientNo";
            this.tePatientNo.Size = new System.Drawing.Size(70, 20);
            this.tePatientNo.StyleController = this.layoutControl1;
            this.tePatientNo.TabIndex = 15;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.iSGK,
            this.iSGKAcil,
            this.iNormal,
            this.iOzelHasta,
            this.iAll});
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1071, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 721);
            this.barDockControlBottom.Size = new System.Drawing.Size(1071, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 721);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1071, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 721);
            // 
            // iSGK
            // 
            this.iSGK.Caption = "SGK";
            this.iSGK.Id = 0;
            this.iSGK.Name = "iSGK";
            this.iSGK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iSGK_ItemClick);
            // 
            // iSGKAcil
            // 
            this.iSGKAcil.Caption = "SGK Acil";
            this.iSGKAcil.Id = 1;
            this.iSGKAcil.Name = "iSGKAcil";
            this.iSGKAcil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iSGKAcil_ItemClick);
            // 
            // iNormal
            // 
            this.iNormal.Caption = "KRM000 - Normal";
            this.iNormal.Id = 2;
            this.iNormal.Name = "iNormal";
            this.iNormal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iNormal_ItemClick);
            // 
            // iOzelHasta
            // 
            this.iOzelHasta.Caption = "KRM008 - Özel Hasta";
            this.iOzelHasta.Id = 3;
            this.iOzelHasta.Name = "iOzelHasta";
            this.iOzelHasta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iOzelHasta_ItemClick);
            // 
            // iAll
            // 
            this.iAll.Caption = "Hepsi";
            this.iAll.Id = 4;
            this.iAll.Name = "iAll";
            this.iAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iAll_ItemClick);
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.DropDownControl = this.popupMenu1;
            this.dropDownButton1.Location = new System.Drawing.Point(163, 12);
            this.dropDownButton1.MenuManager = this.barManager1;
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(108, 22);
            this.dropDownButton1.StyleController = this.layoutControl1;
            this.dropDownButton1.TabIndex = 14;
            this.dropDownButton1.Text = "Kurum Seç";
            this.dropDownButton1.Click += new System.EventHandler(this.ddbChangeInsuranceCompany_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iSGK),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSGKAcil),
            new DevExpress.XtraBars.LinkPersistInfo(this.iNormal),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOzelHasta),
            new DevExpress.XtraBars.LinkPersistInfo(this.iAll)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // deEndDate
            // 
            this.deEndDate.EditValue = null;
            this.deEndDate.Location = new System.Drawing.Point(89, 36);
            this.deEndDate.Name = "deEndDate";
            this.deEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deEndDate.Size = new System.Drawing.Size(70, 20);
            this.deEndDate.StyleController = this.layoutControl1;
            this.deEndDate.TabIndex = 13;
            // 
            // deStartDate
            // 
            this.deStartDate.EditValue = null;
            this.deStartDate.Location = new System.Drawing.Point(89, 12);
            this.deStartDate.Name = "deStartDate";
            this.deStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deStartDate.Size = new System.Drawing.Size(70, 20);
            this.deStartDate.StyleController = this.layoutControl1;
            this.deStartDate.TabIndex = 12;
            // 
            // gcPatients
            // 
            this.gcPatients.Location = new System.Drawing.Point(12, 106);
            this.gcPatients.MainView = this.gvPatients;
            this.gcPatients.Name = "gcPatients";
            this.gcPatients.Size = new System.Drawing.Size(259, 603);
            this.gcPatients.TabIndex = 10;
            this.gcPatients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatients});
            // 
            // gvPatients
            // 
            this.gvPatients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPatientNo,
            this.colFirstName,
            this.colLastName,
            this.colPatientInsuranceCompany});
            this.gvPatients.GridControl = this.gcPatients;
            this.gvPatients.Name = "gvPatients";
            this.gvPatients.OptionsBehavior.Editable = false;
            this.gvPatients.OptionsView.ShowGroupPanel = false;
            this.gvPatients.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPatients_FocusedRowChanged);
            // 
            // colPatientNo
            // 
            this.colPatientNo.Caption = "Protokol";
            this.colPatientNo.FieldName = "PatientNo";
            this.colPatientNo.Name = "colPatientNo";
            this.colPatientNo.Visible = true;
            this.colPatientNo.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Hasta Adı";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Hasta Soyadı";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // colPatientInsuranceCompany
            // 
            this.colPatientInsuranceCompany.Caption = "Kurum";
            this.colPatientInsuranceCompany.FieldName = "InsuranceCompany.Name";
            this.colPatientInsuranceCompany.Name = "colPatientInsuranceCompany";
            this.colPatientInsuranceCompany.Visible = true;
            this.colPatientInsuranceCompany.VisibleIndex = 3;
            // 
            // sbRefresh
            // 
            this.sbRefresh.Location = new System.Drawing.Point(163, 64);
            this.sbRefresh.Name = "sbRefresh";
            this.sbRefresh.Size = new System.Drawing.Size(108, 22);
            this.sbRefresh.StyleController = this.layoutControl1;
            this.sbRefresh.TabIndex = 8;
            this.sbRefresh.Text = "Yenile";
            this.sbRefresh.Click += new System.EventHandler(this.sbRefresh_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.lciStartDate,
            this.lciEndDate,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.lciPatientNo,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1071, 721);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gcPatients;
            this.layoutControlItem7.CustomizationFormText = "Hastalar";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(263, 623);
            this.layoutControlItem7.Text = "Hastalar";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(73, 13);
            // 
            // lciStartDate
            // 
            this.lciStartDate.Control = this.deStartDate;
            this.lciStartDate.CustomizationFormText = "Başlangıç Tarihi";
            this.lciStartDate.Location = new System.Drawing.Point(0, 0);
            this.lciStartDate.Name = "lciStartDate";
            this.lciStartDate.Size = new System.Drawing.Size(151, 24);
            this.lciStartDate.Text = "Başlangıç Tarihi";
            this.lciStartDate.TextSize = new System.Drawing.Size(73, 13);
            // 
            // lciEndDate
            // 
            this.lciEndDate.Control = this.deEndDate;
            this.lciEndDate.CustomizationFormText = "Bitiş Tarihi";
            this.lciEndDate.Location = new System.Drawing.Point(0, 24);
            this.lciEndDate.Name = "lciEndDate";
            this.lciEndDate.Size = new System.Drawing.Size(151, 24);
            this.lciEndDate.Text = "Bitiş Tarihi";
            this.lciEndDate.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbRefresh;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(151, 52);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(112, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dropDownButton1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(151, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(112, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // lciPatientNo
            // 
            this.lciPatientNo.Control = this.tePatientNo;
            this.lciPatientNo.CustomizationFormText = "Protokol No:";
            this.lciPatientNo.Location = new System.Drawing.Point(0, 48);
            this.lciPatientNo.Name = "lciPatientNo";
            this.lciPatientNo.Size = new System.Drawing.Size(151, 30);
            this.lciPatientNo.Text = "Protokol No:";
            this.lciPatientNo.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbClear;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(151, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(112, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.invoiceControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(263, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(788, 701);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // LabInvoiceForm
            // 
            this.AcceptButton = this.sbRefresh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 721);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "LabInvoiceForm";
            this.Text = "Laboratuvar Fiş Basma Formu";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tePatientNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton sbRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl gcPatients;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPatients;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientInsuranceCompany;
        private DevExpress.XtraEditors.DateEdit deEndDate;
        private DevExpress.XtraEditors.DateEdit deStartDate;
        private DevExpress.XtraLayout.LayoutControlItem lciStartDate;
        private DevExpress.XtraLayout.LayoutControlItem lciEndDate;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem iSGK;
        private DevExpress.XtraBars.BarButtonItem iSGKAcil;
        private DevExpress.XtraBars.BarButtonItem iNormal;
        private DevExpress.XtraBars.BarButtonItem iOzelHasta;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem iAll;
        private DevExpress.XtraEditors.SimpleButton sbClear;
        private DevExpress.XtraEditors.TextEdit tePatientNo;
        private DevExpress.XtraLayout.LayoutControlItem lciPatientNo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private Controls.LabInvoiceControl invoiceControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}