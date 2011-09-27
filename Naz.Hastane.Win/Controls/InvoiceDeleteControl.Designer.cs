namespace Naz.Hastane.Win.Controls
{
    partial class InvoiceDeleteControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelInvoice = new DevExpress.XtraEditors.SimpleButton();
            this.gcAdvancePayments = new DevExpress.XtraGrid.GridControl();
            this.gvAdvancePayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcProducts = new DevExpress.XtraGrid.GridControl();
            this.gvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcInvoices = new DevExpress.XtraGrid.GridControl();
            this.gvInvoices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciInvoices = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciProducts = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAdvancePayments = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgButtons = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciRefresh = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCancelInvoice = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAdvancePayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdvancePayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdvancePayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancelInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // colDurum
            // 
            this.colDurum.Caption = "Durum";
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 8;
            this.colDurum.Width = 64;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbRefresh);
            this.layoutControl1.Controls.Add(this.sbCancelInvoice);
            this.layoutControl1.Controls.Add(this.gcAdvancePayments);
            this.layoutControl1.Controls.Add(this.gcProducts);
            this.layoutControl1.Controls.Add(this.gcInvoices);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(697, 513);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbRefresh
            // 
            this.sbRefresh.Location = new System.Drawing.Point(620, 35);
            this.sbRefresh.Name = "sbRefresh";
            this.sbRefresh.Size = new System.Drawing.Size(68, 22);
            this.sbRefresh.StyleController = this.layoutControl1;
            this.sbRefresh.TabIndex = 8;
            this.sbRefresh.Text = "Yenile";
            this.sbRefresh.Click += new System.EventHandler(this.sbRefresh_Click);
            // 
            // sbCancelInvoice
            // 
            this.sbCancelInvoice.Location = new System.Drawing.Point(620, 9);
            this.sbCancelInvoice.Name = "sbCancelInvoice";
            this.sbCancelInvoice.Size = new System.Drawing.Size(68, 22);
            this.sbCancelInvoice.StyleController = this.layoutControl1;
            this.sbCancelInvoice.TabIndex = 7;
            this.sbCancelInvoice.Text = "Fatura İptal";
            this.sbCancelInvoice.Click += new System.EventHandler(this.sbCancelInvoice_Click);
            // 
            // gcAdvancePayments
            // 
            this.gcAdvancePayments.Location = new System.Drawing.Point(388, 264);
            this.gcAdvancePayments.MainView = this.gvAdvancePayments;
            this.gcAdvancePayments.Name = "gcAdvancePayments";
            this.gcAdvancePayments.Size = new System.Drawing.Size(223, 245);
            this.gcAdvancePayments.TabIndex = 6;
            this.gcAdvancePayments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAdvancePayments});
            // 
            // gvAdvancePayments
            // 
            this.gvAdvancePayments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18});
            this.gvAdvancePayments.GridControl = this.gcAdvancePayments;
            this.gvAdvancePayments.Name = "gvAdvancePayments";
            this.gvAdvancePayments.OptionsBehavior.Editable = false;
            this.gvAdvancePayments.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Avans Tarihi";
            this.gridColumn16.FieldName = "TARIH";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 0;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Alınan Avans";
            this.gridColumn17.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.gridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn17.FieldName = "AdvancePayment.TUTAR";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 1;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Kullanılan Tutar";
            this.gridColumn18.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.gridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn18.FieldName = "TUTAR";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 2;
            // 
            // gcProducts
            // 
            this.gcProducts.Location = new System.Drawing.Point(4, 264);
            this.gcProducts.MainView = this.gvProducts;
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.Size = new System.Drawing.Size(380, 245);
            this.gcProducts.TabIndex = 5;
            this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProducts});
            // 
            // gvProducts
            // 
            this.gvProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15});
            this.gvProducts.GridControl = this.gcProducts;
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.OptionsBehavior.Editable = false;
            this.gvProducts.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Kart No";
            this.gridColumn11.FieldName = "PatientVisit.VisitNo";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            this.gridColumn11.Width = 49;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "İşlem Tarihi";
            this.gridColumn12.FieldName = "TARIH";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            this.gridColumn12.Width = 70;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Açıklama";
            this.gridColumn13.FieldName = "NAME1";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            this.gridColumn13.Width = 232;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Adet";
            this.gridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn14.FieldName = "ADET";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 3;
            this.gridColumn14.Width = 34;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Hasta Tutarı";
            this.gridColumn15.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.gridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn15.FieldName = "PatientPrice";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            this.gridColumn15.Width = 118;
            // 
            // gcInvoices
            // 
            this.gcInvoices.Location = new System.Drawing.Point(4, 20);
            this.gcInvoices.MainView = this.gvInvoices;
            this.gcInvoices.Name = "gcInvoices";
            this.gcInvoices.Size = new System.Drawing.Size(607, 224);
            this.gcInvoices.TabIndex = 4;
            this.gcInvoices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInvoices});
            // 
            // gvInvoices
            // 
            this.gvInvoices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.colDurum,
            this.gridColumn10});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colDurum;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "İptal";
            this.gvInvoices.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gvInvoices.GridControl = this.gcInvoices;
            this.gvInvoices.Name = "gvInvoices";
            this.gvInvoices.OptionsBehavior.Editable = false;
            this.gvInvoices.OptionsView.ShowGroupPanel = false;
            this.gvInvoices.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvInvoices_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Hazırlama Tarihi";
            this.gridColumn1.FieldName = "FATURATARIHI";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 81;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fatura No";
            this.gridColumn2.FieldName = "FATURANO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 71;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Hasta Tutarı";
            this.gridColumn3.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "HIZMETTUTARI";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 82;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "İndirim Tutarı";
            this.gridColumn4.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "INDIRIM";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 82;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "KDV Tutarı";
            this.gridColumn5.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "KDVTUTARI";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 67;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Yuvarlama";
            this.gridColumn6.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "YUVARLAMA";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 69;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Fatura Tutarı";
            this.gridColumn7.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "FATURATUTARI";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 77;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Hazırlayan";
            this.gridColumn8.FieldName = "USER_ID";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 91;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Fatura İptal Nedeni";
            this.gridColumn10.FieldName = "IPTAL_NEDENI";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            this.gridColumn10.Width = 126;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciInvoices,
            this.lciProducts,
            this.lciAdvancePayments,
            this.lcgButtons});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(697, 513);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciInvoices
            // 
            this.lciInvoices.Control = this.gcInvoices;
            this.lciInvoices.CustomizationFormText = "Kesilmiş Faturalar";
            this.lciInvoices.Location = new System.Drawing.Point(0, 0);
            this.lciInvoices.Name = "lciInvoices";
            this.lciInvoices.Size = new System.Drawing.Size(611, 244);
            this.lciInvoices.Text = "Kesilmiş Faturalar";
            this.lciInvoices.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciInvoices.TextSize = new System.Drawing.Size(151, 13);
            // 
            // lciProducts
            // 
            this.lciProducts.Control = this.gcProducts;
            this.lciProducts.CustomizationFormText = "Faturanın Hizmetleri";
            this.lciProducts.Location = new System.Drawing.Point(0, 244);
            this.lciProducts.Name = "lciProducts";
            this.lciProducts.Size = new System.Drawing.Size(384, 265);
            this.lciProducts.Text = "Faturanın Hizmetleri";
            this.lciProducts.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciProducts.TextSize = new System.Drawing.Size(151, 13);
            // 
            // lciAdvancePayments
            // 
            this.lciAdvancePayments.Control = this.gcAdvancePayments;
            this.lciAdvancePayments.CustomizationFormText = "Bu Faturada Kullanılan Avanslar";
            this.lciAdvancePayments.Location = new System.Drawing.Point(384, 244);
            this.lciAdvancePayments.Name = "lciAdvancePayments";
            this.lciAdvancePayments.Size = new System.Drawing.Size(227, 265);
            this.lciAdvancePayments.Text = "Bu Faturada Kullanılan Avanslar";
            this.lciAdvancePayments.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciAdvancePayments.TextSize = new System.Drawing.Size(151, 13);
            // 
            // lcgButtons
            // 
            this.lcgButtons.CustomizationFormText = "lcgButtons";
            this.lcgButtons.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciRefresh,
            this.lciCancelInvoice});
            this.lcgButtons.Location = new System.Drawing.Point(611, 0);
            this.lcgButtons.Name = "lcgButtons";
            this.lcgButtons.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcgButtons.Size = new System.Drawing.Size(82, 509);
            this.lcgButtons.Text = "lcgButtons";
            this.lcgButtons.TextVisible = false;
            // 
            // lciRefresh
            // 
            this.lciRefresh.Control = this.sbRefresh;
            this.lciRefresh.CustomizationFormText = "lciRefresh";
            this.lciRefresh.Location = new System.Drawing.Point(0, 26);
            this.lciRefresh.Name = "lciRefresh";
            this.lciRefresh.Size = new System.Drawing.Size(72, 473);
            this.lciRefresh.Text = "lciRefresh";
            this.lciRefresh.TextSize = new System.Drawing.Size(0, 0);
            this.lciRefresh.TextToControlDistance = 0;
            this.lciRefresh.TextVisible = false;
            // 
            // lciCancelInvoice
            // 
            this.lciCancelInvoice.Control = this.sbCancelInvoice;
            this.lciCancelInvoice.CustomizationFormText = "lciCancelInvoice";
            this.lciCancelInvoice.Location = new System.Drawing.Point(0, 0);
            this.lciCancelInvoice.Name = "lciCancelInvoice";
            this.lciCancelInvoice.Size = new System.Drawing.Size(72, 26);
            this.lciCancelInvoice.Text = "lciCancelInvoice";
            this.lciCancelInvoice.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancelInvoice.TextToControlDistance = 0;
            this.lciCancelInvoice.TextVisible = false;
            // 
            // InvoiceDeleteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "InvoiceDeleteControl";
            this.Size = new System.Drawing.Size(697, 513);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAdvancePayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdvancePayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdvancePayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancelInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton sbCancelInvoice;
        private DevExpress.XtraGrid.GridControl gcAdvancePayments;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAdvancePayments;
        private DevExpress.XtraGrid.GridControl gcProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProducts;
        private DevExpress.XtraGrid.GridControl gcInvoices;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvoices;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciInvoices;
        private DevExpress.XtraLayout.LayoutControlItem lciProducts;
        private DevExpress.XtraLayout.LayoutControlItem lciAdvancePayments;
        private DevExpress.XtraLayout.LayoutControlItem lciCancelInvoice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraEditors.SimpleButton sbRefresh;
        private DevExpress.XtraLayout.LayoutControlGroup lcgButtons;
        private DevExpress.XtraLayout.LayoutControlItem lciRefresh;

    }
}
