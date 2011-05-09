namespace Naz.Hastane.Win.MDIChildForms
{
    partial class SelectFunctionForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.teCompanyTotal = new DevExpress.XtraEditors.TextEdit();
            this.tePatientTotal = new DevExpress.XtraEditors.TextEdit();
            this.gcProducts = new DevExpress.XtraGrid.GridControl();
            this.gvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatientPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.sbSelect = new DevExpress.XtraEditors.SimpleButton();
            this.gcSelectedProducts = new DevExpress.XtraGrid.GridControl();
            this.gvSelectedProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSelectedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedPatientPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCompanyPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedDoctor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShouldBeIncoiced = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdmittedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExitDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedulaPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTedaviBaslangic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTedaviBitis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnomali = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tlFunctionGroups = new DevExpress.XtraTreeList.TreeList();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciFunctionGroups = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciProducts = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSelectedProducts = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPatientTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCompanyTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teCompanyTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePatientTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlFunctionGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFunctionGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSelectedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCompanyTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.teCompanyTotal);
            this.layoutControl1.Controls.Add(this.tePatientTotal);
            this.layoutControl1.Controls.Add(this.gcProducts);
            this.layoutControl1.Controls.Add(this.sbClose);
            this.layoutControl1.Controls.Add(this.sbSelect);
            this.layoutControl1.Controls.Add(this.gcSelectedProducts);
            this.layoutControl1.Controls.Add(this.tlFunctionGroups);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(850, 692);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // teCompanyTotal
            // 
            this.teCompanyTotal.Enabled = false;
            this.teCompanyTotal.Location = new System.Drawing.Point(447, 660);
            this.teCompanyTotal.Name = "teCompanyTotal";
            this.teCompanyTotal.Properties.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.teCompanyTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teCompanyTotal.Size = new System.Drawing.Size(108, 20);
            this.teCompanyTotal.StyleController = this.layoutControl1;
            this.teCompanyTotal.TabIndex = 12;
            // 
            // tePatientTotal
            // 
            this.tePatientTotal.Enabled = false;
            this.tePatientTotal.Location = new System.Drawing.Point(258, 660);
            this.tePatientTotal.Name = "tePatientTotal";
            this.tePatientTotal.Properties.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.tePatientTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tePatientTotal.Size = new System.Drawing.Size(108, 20);
            this.tePatientTotal.StyleController = this.layoutControl1;
            this.tePatientTotal.TabIndex = 11;
            // 
            // gcProducts
            // 
            this.gcProducts.Location = new System.Drawing.Point(359, 28);
            this.gcProducts.MainView = this.gvProducts;
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.Size = new System.Drawing.Size(403, 323);
            this.gcProducts.TabIndex = 9;
            this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProducts});
            // 
            // gvProducts
            // 
            this.gvProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colPatientPrice,
            this.colCompanyPrice});
            this.gvProducts.GridControl = this.gcProducts;
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.OptionsBehavior.Editable = false;
            this.gvProducts.OptionsView.ShowGroupPanel = false;
            this.gvProducts.DoubleClick += new System.EventHandler(this.gvProducts_DoubleClick);
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Açıklama";
            this.colProductName.FieldName = "NAME1";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 248;
            // 
            // colPatientPrice
            // 
            this.colPatientPrice.Caption = "Hasta Fiyatı";
            this.colPatientPrice.FieldName = "PatientPrice";
            this.colPatientPrice.Name = "colPatientPrice";
            this.colPatientPrice.Visible = true;
            this.colPatientPrice.VisibleIndex = 1;
            this.colPatientPrice.Width = 67;
            // 
            // colCompanyPrice
            // 
            this.colCompanyPrice.Caption = "Kurum Fiyatı";
            this.colCompanyPrice.FieldName = "CompanyPrice";
            this.colCompanyPrice.Name = "colCompanyPrice";
            this.colCompanyPrice.Visible = true;
            this.colCompanyPrice.VisibleIndex = 2;
            this.colCompanyPrice.Width = 68;
            // 
            // sbClose
            // 
            this.sbClose.Location = new System.Drawing.Point(766, 315);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(72, 22);
            this.sbClose.StyleController = this.layoutControl1;
            this.sbClose.TabIndex = 7;
            this.sbClose.Text = "Kapat";
            this.sbClose.Click += new System.EventHandler(this.sbClose_Click);
            // 
            // sbSelect
            // 
            this.sbSelect.Location = new System.Drawing.Point(766, 81);
            this.sbSelect.Name = "sbSelect";
            this.sbSelect.Size = new System.Drawing.Size(72, 22);
            this.sbSelect.StyleController = this.layoutControl1;
            this.sbSelect.TabIndex = 6;
            this.sbSelect.Text = "Seçilileri Ekle";
            this.sbSelect.Click += new System.EventHandler(this.sbSelect_Click);
            // 
            // gcSelectedProducts
            // 
            this.gcSelectedProducts.Location = new System.Drawing.Point(12, 371);
            this.gcSelectedProducts.MainView = this.gvSelectedProducts;
            this.gcSelectedProducts.Name = "gcSelectedProducts";
            this.gcSelectedProducts.Size = new System.Drawing.Size(826, 285);
            this.gcSelectedProducts.TabIndex = 10;
            this.gcSelectedProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSelectedProducts});
            // 
            // gvSelectedProducts
            // 
            this.gvSelectedProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelectedDate,
            this.colSelectedGroup,
            this.colSelectedCode,
            this.colSelectedProductName,
            this.colSelectedAmount,
            this.colSelectedPatientPrice,
            this.colSelectedCompanyPrice,
            this.colSelectedDoctor,
            this.colSelectedDoctor2,
            this.colSelectedUser,
            this.colShouldBeIncoiced,
            this.colAdmittedDate,
            this.colExitDate,
            this.colRefDays,
            this.colMedulaPrice,
            this.colTedaviBaslangic,
            this.colTedaviBitis,
            this.colOzelDurum,
            this.colAnomali,
            this.colAKOD});
            this.gvSelectedProducts.GridControl = this.gcSelectedProducts;
            this.gvSelectedProducts.Name = "gvSelectedProducts";
            this.gvSelectedProducts.OptionsBehavior.Editable = false;
            this.gvSelectedProducts.OptionsView.ColumnAutoWidth = false;
            this.gvSelectedProducts.OptionsView.ShowGroupPanel = false;
            this.gvSelectedProducts.DoubleClick += new System.EventHandler(this.gvSelectedProducts_DoubleClick);
            // 
            // colSelectedDate
            // 
            this.colSelectedDate.Caption = "Tarih / Saat";
            this.colSelectedDate.FieldName = "TARIH";
            this.colSelectedDate.Name = "colSelectedDate";
            this.colSelectedDate.Visible = true;
            this.colSelectedDate.VisibleIndex = 0;
            // 
            // colSelectedGroup
            // 
            this.colSelectedGroup.Caption = "Grup";
            this.colSelectedGroup.FieldName = "GRUP";
            this.colSelectedGroup.Name = "colSelectedGroup";
            this.colSelectedGroup.Visible = true;
            this.colSelectedGroup.VisibleIndex = 1;
            // 
            // colSelectedCode
            // 
            this.colSelectedCode.Caption = "Kodu";
            this.colSelectedCode.FieldName = "CODE";
            this.colSelectedCode.Name = "colSelectedCode";
            this.colSelectedCode.Visible = true;
            this.colSelectedCode.VisibleIndex = 2;
            // 
            // colSelectedProductName
            // 
            this.colSelectedProductName.Caption = "Açıklama";
            this.colSelectedProductName.FieldName = "NAME1";
            this.colSelectedProductName.Name = "colSelectedProductName";
            this.colSelectedProductName.Visible = true;
            this.colSelectedProductName.VisibleIndex = 3;
            // 
            // colSelectedAmount
            // 
            this.colSelectedAmount.Caption = "Adet";
            this.colSelectedAmount.FieldName = "ADET";
            this.colSelectedAmount.Name = "colSelectedAmount";
            this.colSelectedAmount.Visible = true;
            this.colSelectedAmount.VisibleIndex = 4;
            // 
            // colSelectedPatientPrice
            // 
            this.colSelectedPatientPrice.Caption = "Hasta Fiyatı";
            this.colSelectedPatientPrice.FieldName = "PatientPrice";
            this.colSelectedPatientPrice.Name = "colSelectedPatientPrice";
            this.colSelectedPatientPrice.Visible = true;
            this.colSelectedPatientPrice.VisibleIndex = 5;
            // 
            // colSelectedCompanyPrice
            // 
            this.colSelectedCompanyPrice.Caption = "Kurum Fiyatı";
            this.colSelectedCompanyPrice.FieldName = "CompanyPrice";
            this.colSelectedCompanyPrice.Name = "colSelectedCompanyPrice";
            this.colSelectedCompanyPrice.Visible = true;
            this.colSelectedCompanyPrice.VisibleIndex = 6;
            // 
            // colSelectedDoctor
            // 
            this.colSelectedDoctor.Caption = "Doktor";
            this.colSelectedDoctor.FieldName = "DoctorName";
            this.colSelectedDoctor.Name = "colSelectedDoctor";
            this.colSelectedDoctor.Visible = true;
            this.colSelectedDoctor.VisibleIndex = 8;
            // 
            // colSelectedDoctor2
            // 
            this.colSelectedDoctor2.Caption = "Yapan Doktor";
            this.colSelectedDoctor2.FieldName = "Doctor2Name";
            this.colSelectedDoctor2.Name = "colSelectedDoctor2";
            this.colSelectedDoctor2.Visible = true;
            this.colSelectedDoctor2.VisibleIndex = 9;
            // 
            // colSelectedUser
            // 
            this.colSelectedUser.Caption = "Kullanıcı";
            this.colSelectedUser.FieldName = "USER_ID";
            this.colSelectedUser.Name = "colSelectedUser";
            this.colSelectedUser.Visible = true;
            this.colSelectedUser.VisibleIndex = 10;
            // 
            // colShouldBeIncoiced
            // 
            this.colShouldBeIncoiced.Caption = "Fatura Edilsin";
            this.colShouldBeIncoiced.FieldName = "FATURAEDILSIN";
            this.colShouldBeIncoiced.Name = "colShouldBeIncoiced";
            this.colShouldBeIncoiced.Visible = true;
            this.colShouldBeIncoiced.VisibleIndex = 11;
            // 
            // colAdmittedDate
            // 
            this.colAdmittedDate.Caption = "Yatış Tarihi";
            this.colAdmittedDate.FieldName = "HYATISTARIHI";
            this.colAdmittedDate.Name = "colAdmittedDate";
            this.colAdmittedDate.Visible = true;
            this.colAdmittedDate.VisibleIndex = 12;
            // 
            // colExitDate
            // 
            this.colExitDate.Caption = "Çıkış Tarihi";
            this.colExitDate.FieldName = "HCIKISTARIHI";
            this.colExitDate.Name = "colExitDate";
            this.colExitDate.Visible = true;
            this.colExitDate.VisibleIndex = 13;
            // 
            // colRefDays
            // 
            this.colRefDays.Caption = "Ref. Gün Sayısı";
            this.colRefDays.FieldName = "REFGUNSAY";
            this.colRefDays.Name = "colRefDays";
            this.colRefDays.Visible = true;
            this.colRefDays.VisibleIndex = 14;
            // 
            // colMedulaPrice
            // 
            this.colMedulaPrice.Caption = "Medula Fiyatı";
            this.colMedulaPrice.Name = "colMedulaPrice";
            this.colMedulaPrice.Visible = true;
            this.colMedulaPrice.VisibleIndex = 15;
            // 
            // colTedaviBaslangic
            // 
            this.colTedaviBaslangic.Caption = "Tedavi Başlangıç";
            this.colTedaviBaslangic.FieldName = "MEDTUTAR";
            this.colTedaviBaslangic.Name = "colTedaviBaslangic";
            this.colTedaviBaslangic.Visible = true;
            this.colTedaviBaslangic.VisibleIndex = 16;
            // 
            // colTedaviBitis
            // 
            this.colTedaviBitis.Caption = "Tedavi Bitiş";
            this.colTedaviBitis.Name = "colTedaviBitis";
            this.colTedaviBitis.Visible = true;
            this.colTedaviBitis.VisibleIndex = 17;
            // 
            // colOzelDurum
            // 
            this.colOzelDurum.Caption = "Özel Durum";
            this.colOzelDurum.FieldName = "MEDOZDURUM";
            this.colOzelDurum.Name = "colOzelDurum";
            this.colOzelDurum.Visible = true;
            this.colOzelDurum.VisibleIndex = 18;
            // 
            // colAnomali
            // 
            this.colAnomali.Caption = "Anomali";
            this.colAnomali.FieldName = "MEDANOMALI";
            this.colAnomali.Name = "colAnomali";
            this.colAnomali.Visible = true;
            this.colAnomali.VisibleIndex = 19;
            // 
            // colAKOD
            // 
            this.colAKOD.Caption = "Ambar Kodu";
            this.colAKOD.FieldName = "AKOD";
            this.colAKOD.Name = "colAKOD";
            this.colAKOD.Visible = true;
            this.colAKOD.VisibleIndex = 7;
            // 
            // tlFunctionGroups
            // 
            this.tlFunctionGroups.Location = new System.Drawing.Point(12, 28);
            this.tlFunctionGroups.Name = "tlFunctionGroups";
            this.tlFunctionGroups.OptionsBehavior.Editable = false;
            this.tlFunctionGroups.Size = new System.Drawing.Size(343, 323);
            this.tlFunctionGroups.TabIndex = 8;
            this.tlFunctionGroups.AfterFocusNode += new DevExpress.XtraTreeList.NodeEventHandler(this.tlFunctionGroups_AfterFocusNode);
            this.tlFunctionGroups.Click += new System.EventHandler(this.tlFunctionGroups_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.lciFunctionGroups,
            this.lciProducts,
            this.lciSelectedProducts,
            this.lciPatientTotal,
            this.lciCompanyTotal,
            this.emptySpaceItem4,
            this.emptySpaceItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(850, 692);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbSelect;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(754, 69);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(76, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbClose;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(754, 303);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(76, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(754, 95);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(76, 208);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(754, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(76, 69);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(754, 329);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(76, 14);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciFunctionGroups
            // 
            this.lciFunctionGroups.Control = this.tlFunctionGroups;
            this.lciFunctionGroups.CustomizationFormText = "Hizmetler";
            this.lciFunctionGroups.Location = new System.Drawing.Point(0, 0);
            this.lciFunctionGroups.Name = "lciFunctionGroups";
            this.lciFunctionGroups.Size = new System.Drawing.Size(347, 343);
            this.lciFunctionGroups.Text = "Hizmetler";
            this.lciFunctionGroups.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciFunctionGroups.TextSize = new System.Drawing.Size(73, 13);
            // 
            // lciProducts
            // 
            this.lciProducts.Control = this.gcProducts;
            this.lciProducts.CustomizationFormText = "İşlemler";
            this.lciProducts.Location = new System.Drawing.Point(347, 0);
            this.lciProducts.Name = "lciProducts";
            this.lciProducts.Size = new System.Drawing.Size(407, 343);
            this.lciProducts.Text = "İşlemler";
            this.lciProducts.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciProducts.TextSize = new System.Drawing.Size(73, 13);
            // 
            // lciSelectedProducts
            // 
            this.lciSelectedProducts.Control = this.gcSelectedProducts;
            this.lciSelectedProducts.CustomizationFormText = "Seçili İşlemler";
            this.lciSelectedProducts.Location = new System.Drawing.Point(0, 343);
            this.lciSelectedProducts.Name = "lciSelectedProducts";
            this.lciSelectedProducts.Size = new System.Drawing.Size(830, 305);
            this.lciSelectedProducts.Text = "Seçili İşlemler";
            this.lciSelectedProducts.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciSelectedProducts.TextSize = new System.Drawing.Size(73, 13);
            // 
            // lciPatientTotal
            // 
            this.lciPatientTotal.Control = this.tePatientTotal;
            this.lciPatientTotal.CustomizationFormText = "Hasta Toplamı:";
            this.lciPatientTotal.Location = new System.Drawing.Point(169, 648);
            this.lciPatientTotal.Name = "lciPatientTotal";
            this.lciPatientTotal.Size = new System.Drawing.Size(189, 24);
            this.lciPatientTotal.Text = "Hasta Toplamı:";
            this.lciPatientTotal.TextSize = new System.Drawing.Size(73, 13);
            // 
            // lciCompanyTotal
            // 
            this.lciCompanyTotal.Control = this.teCompanyTotal;
            this.lciCompanyTotal.CustomizationFormText = "Kurum Toplamı:";
            this.lciCompanyTotal.Location = new System.Drawing.Point(358, 648);
            this.lciCompanyTotal.Name = "lciCompanyTotal";
            this.lciCompanyTotal.Size = new System.Drawing.Size(189, 24);
            this.lciCompanyTotal.Text = "Kurum Toplamı:";
            this.lciCompanyTotal.TextSize = new System.Drawing.Size(73, 13);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(547, 648);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(283, 24);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5";
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 648);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(169, 24);
            this.emptySpaceItem5.Text = "emptySpaceItem5";
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // SelectFunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 692);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "SelectFunctionForm";
            this.Text = "SGK Poliklinik Seçim Formu";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SelectFunctionForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teCompanyTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePatientTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlFunctionGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFunctionGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSelectedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCompanyTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton sbClose;
        private DevExpress.XtraEditors.SimpleButton sbSelect;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraTreeList.TreeList tlFunctionGroups;
        private DevExpress.XtraLayout.LayoutControlItem lciFunctionGroups;
        private DevExpress.XtraGrid.GridControl gcSelectedProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSelectedProducts;
        private DevExpress.XtraGrid.GridControl gcProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProducts;
        private DevExpress.XtraLayout.LayoutControlItem lciProducts;
        private DevExpress.XtraLayout.LayoutControlItem lciSelectedProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedPatientPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCompanyPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedDoctor;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedDoctor2;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedUser;
        private DevExpress.XtraGrid.Columns.GridColumn colShouldBeIncoiced;
        private DevExpress.XtraGrid.Columns.GridColumn colAdmittedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExitDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRefDays;
        private DevExpress.XtraGrid.Columns.GridColumn colMedulaPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTedaviBaslangic;
        private DevExpress.XtraGrid.Columns.GridColumn colTedaviBitis;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colAnomali;
        private DevExpress.XtraGrid.Columns.GridColumn colAKOD;
        private DevExpress.XtraEditors.TextEdit teCompanyTotal;
        private DevExpress.XtraEditors.TextEdit tePatientTotal;
        private DevExpress.XtraLayout.LayoutControlItem lciPatientTotal;
        private DevExpress.XtraLayout.LayoutControlItem lciCompanyTotal;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
    }
}