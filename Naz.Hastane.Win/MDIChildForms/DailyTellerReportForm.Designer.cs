namespace Naz.Hastane.Win.MDIChildForms
{
    partial class DailyTellerReportForm
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
            this.lueUser = new DevExpress.XtraEditors.LookUpEdit();
            this.deEndDate = new DevExpress.XtraEditors.DateEdit();
            this.lbStatus = new DevExpress.XtraEditors.LabelControl();
            this.sbMonthly = new DevExpress.XtraEditors.SimpleButton();
            this.deStartDate = new DevExpress.XtraEditors.DateEdit();
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.sbPrint = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatientNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTellerVoucherNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGirenTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCikanTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciStartDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEndDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.sbRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lciRefresh = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lueUser);
            this.layoutControl1.Controls.Add(this.deEndDate);
            this.layoutControl1.Controls.Add(this.lbStatus);
            this.layoutControl1.Controls.Add(this.sbMonthly);
            this.layoutControl1.Controls.Add(this.sbRefresh);
            this.layoutControl1.Controls.Add(this.deStartDate);
            this.layoutControl1.Controls.Add(this.sbClose);
            this.layoutControl1.Controls.Add(this.sbPrint);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1006, 729);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lueUser
            // 
            this.lueUser.Location = new System.Drawing.Point(882, 28);
            this.lueUser.Name = "lueUser";
            this.lueUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUser.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USER_ID", "Kullanıcı")});
            this.lueUser.Properties.DisplayMember = "USER_ID";
            this.lueUser.Properties.ValueMember = "USER_ID";
            this.lueUser.Size = new System.Drawing.Size(112, 20);
            this.lueUser.StyleController = this.layoutControl1;
            this.lueUser.TabIndex = 11;
            // 
            // deEndDate
            // 
            this.deEndDate.EditValue = null;
            this.deEndDate.Location = new System.Drawing.Point(882, 108);
            this.deEndDate.Name = "deEndDate";
            this.deEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deEndDate.Size = new System.Drawing.Size(112, 20);
            this.deEndDate.StyleController = this.layoutControl1;
            this.deEndDate.TabIndex = 10;
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(882, 270);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(112, 13);
            this.lbStatus.StyleController = this.layoutControl1;
            this.lbStatus.TabIndex = 9;
            // 
            // sbMonthly
            // 
            this.sbMonthly.Location = new System.Drawing.Point(882, 244);
            this.sbMonthly.Name = "sbMonthly";
            this.sbMonthly.Size = new System.Drawing.Size(112, 22);
            this.sbMonthly.StyleController = this.layoutControl1;
            this.sbMonthly.TabIndex = 8;
            this.sbMonthly.Text = "Aylık";
            this.sbMonthly.Click += new System.EventHandler(this.sbMonthly_Click);
            // 
            // deStartDate
            // 
            this.deStartDate.EditValue = null;
            this.deStartDate.Location = new System.Drawing.Point(882, 68);
            this.deStartDate.Name = "deStartDate";
            this.deStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deStartDate.Size = new System.Drawing.Size(112, 20);
            this.deStartDate.StyleController = this.layoutControl1;
            this.deStartDate.TabIndex = 7;
            // 
            // sbClose
            // 
            this.sbClose.Location = new System.Drawing.Point(882, 365);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(112, 22);
            this.sbClose.StyleController = this.layoutControl1;
            this.sbClose.TabIndex = 6;
            this.sbClose.Text = "Kapat";
            // 
            // sbPrint
            // 
            this.sbPrint.Location = new System.Drawing.Point(882, 169);
            this.sbPrint.Name = "sbPrint";
            this.sbPrint.Size = new System.Drawing.Size(112, 22);
            this.sbPrint.StyleController = this.layoutControl1;
            this.sbPrint.TabIndex = 5;
            this.sbPrint.Text = "Yazıcıya";
            this.sbPrint.Click += new System.EventHandler(this.sbPrint_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(866, 705);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colPaymentType,
            this.colPatientNo,
            this.colTCID,
            this.colAciklama,
            this.colTellerVoucherNo,
            this.colGirenTutar,
            this.colCikanTutar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPaymentType, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colDate
            // 
            this.colDate.Caption = "Tarih";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colPaymentType
            // 
            this.colPaymentType.Caption = "Ödeme Şekli";
            this.colPaymentType.FieldName = "PaymentType";
            this.colPaymentType.Name = "colPaymentType";
            // 
            // colPatientNo
            // 
            this.colPatientNo.Caption = "Protokol No";
            this.colPatientNo.FieldName = "PatientNo";
            this.colPatientNo.Name = "colPatientNo";
            this.colPatientNo.Visible = true;
            this.colPatientNo.VisibleIndex = 4;
            // 
            // colTCID
            // 
            this.colTCID.Caption = "T.C. Kimlik No";
            this.colTCID.FieldName = "TCID";
            this.colTCID.Name = "colTCID";
            this.colTCID.Visible = true;
            this.colTCID.VisibleIndex = 3;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            // 
            // colTellerVoucherNo
            // 
            this.colTellerVoucherNo.Caption = "Makbuz No";
            this.colTellerVoucherNo.FieldName = "TellerVoucherNo";
            this.colTellerVoucherNo.Name = "colTellerVoucherNo";
            this.colTellerVoucherNo.Visible = true;
            this.colTellerVoucherNo.VisibleIndex = 1;
            // 
            // colGirenTutar
            // 
            this.colGirenTutar.Caption = "Giren Tutar";
            this.colGirenTutar.DisplayFormat.FormatString = "{0:#,###.00}";
            this.colGirenTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGirenTutar.FieldName = "GirenTutar";
            this.colGirenTutar.Name = "colGirenTutar";
            this.colGirenTutar.SummaryItem.DisplayFormat = "{0:#,###.00}";
            this.colGirenTutar.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colGirenTutar.Visible = true;
            this.colGirenTutar.VisibleIndex = 5;
            // 
            // colCikanTutar
            // 
            this.colCikanTutar.Caption = "Çıkan Tutar";
            this.colCikanTutar.DisplayFormat.FormatString = "{0:#,###.00}";
            this.colCikanTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCikanTutar.FieldName = "CikanTutar";
            this.colCikanTutar.Name = "colCikanTutar";
            this.colCikanTutar.SummaryItem.DisplayFormat = "{0:#,###.00}";
            this.colCikanTutar.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCikanTutar.Visible = true;
            this.colCikanTutar.VisibleIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.lciStartDate,
            this.layoutControlItem5,
            this.emptySpaceItem4,
            this.layoutControlItem6,
            this.lciEndDate,
            this.lciUser,
            this.lciRefresh});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1006, 729);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(870, 709);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbPrint;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(870, 157);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(116, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbClose;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(870, 353);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(116, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(870, 275);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(116, 78);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(870, 120);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(116, 11);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(870, 379);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(116, 330);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciStartDate
            // 
            this.lciStartDate.Control = this.deStartDate;
            this.lciStartDate.CustomizationFormText = "layoutControlItem4";
            this.lciStartDate.Location = new System.Drawing.Point(870, 40);
            this.lciStartDate.Name = "lciStartDate";
            this.lciStartDate.Size = new System.Drawing.Size(116, 40);
            this.lciStartDate.Text = "Başlangıç";
            this.lciStartDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciStartDate.TextSize = new System.Drawing.Size(44, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbMonthly;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(870, 232);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(116, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(870, 183);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(116, 49);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lbStatus;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(870, 258);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(116, 17);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // lciEndDate
            // 
            this.lciEndDate.Control = this.deEndDate;
            this.lciEndDate.CustomizationFormText = "layoutControlItem7";
            this.lciEndDate.Location = new System.Drawing.Point(870, 80);
            this.lciEndDate.Name = "lciEndDate";
            this.lciEndDate.Size = new System.Drawing.Size(116, 40);
            this.lciEndDate.Text = "Bitiş";
            this.lciEndDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciEndDate.TextSize = new System.Drawing.Size(44, 13);
            // 
            // lciUser
            // 
            this.lciUser.Control = this.lueUser;
            this.lciUser.CustomizationFormText = "Vezne";
            this.lciUser.Location = new System.Drawing.Point(870, 0);
            this.lciUser.Name = "lciUser";
            this.lciUser.Size = new System.Drawing.Size(116, 40);
            this.lciUser.Text = "Vezne";
            this.lciUser.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciUser.TextSize = new System.Drawing.Size(44, 13);
            // 
            // sbRefresh
            // 
            this.sbRefresh.Location = new System.Drawing.Point(882, 143);
            this.sbRefresh.Name = "sbRefresh";
            this.sbRefresh.Size = new System.Drawing.Size(112, 22);
            this.sbRefresh.StyleController = this.layoutControl1;
            this.sbRefresh.TabIndex = 12;
            this.sbRefresh.Text = "Sorgula";
            this.sbRefresh.Click += new System.EventHandler(this.sbRefresh_Click);
            // 
            // lciRefresh
            // 
            this.lciRefresh.Control = this.sbRefresh;
            this.lciRefresh.CustomizationFormText = "Sorgula";
            this.lciRefresh.Location = new System.Drawing.Point(870, 131);
            this.lciRefresh.Name = "lciRefresh";
            this.lciRefresh.Size = new System.Drawing.Size(116, 26);
            this.lciRefresh.Text = "Sorgula";
            this.lciRefresh.TextSize = new System.Drawing.Size(0, 0);
            this.lciRefresh.TextToControlDistance = 0;
            this.lciRefresh.TextVisible = false;
            // 
            // DailyTellerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 729);
            this.Controls.Add(this.layoutControl1);
            this.Name = "DailyTellerReportForm";
            this.Text = "Muhasebe Entegrasyon Formu";
            this.Load += new System.EventHandler(this.AccountingDailySummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit deStartDate;
        private DevExpress.XtraEditors.SimpleButton sbClose;
        private DevExpress.XtraEditors.SimpleButton sbPrint;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem lciStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType;
        private DevExpress.XtraGrid.Columns.GridColumn colTellerVoucherNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colGirenTutar;
        private DevExpress.XtraEditors.LabelControl lbStatus;
        private DevExpress.XtraEditors.SimpleButton sbMonthly;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.DateEdit deEndDate;
        private DevExpress.XtraLayout.LayoutControlItem lciEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCikanTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTCID;
        private DevExpress.XtraEditors.LookUpEdit lueUser;
        private DevExpress.XtraLayout.LayoutControlItem lciUser;
        private DevExpress.XtraEditors.SimpleButton sbRefresh;
        private DevExpress.XtraLayout.LayoutControlItem lciRefresh;
    }
}