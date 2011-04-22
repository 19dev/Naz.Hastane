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
            this.deLastDate = new DevExpress.XtraEditors.DateEdit();
            this.lbStatus = new DevExpress.XtraEditors.LabelControl();
            this.sbMonthly = new DevExpress.XtraEditors.SimpleButton();
            this.deFirstDate = new DevExpress.XtraEditors.DateEdit();
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.sbPrint = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRowNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTellerVoucherNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecordType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGirenTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCikanTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatientNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciFirstDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLastDate = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deLastDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deLastDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFirstDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFirstDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFirstDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLastDate)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.deLastDate);
            this.layoutControl1.Controls.Add(this.lbStatus);
            this.layoutControl1.Controls.Add(this.sbMonthly);
            this.layoutControl1.Controls.Add(this.deFirstDate);
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
            // deLastDate
            // 
            this.deLastDate.EditValue = null;
            this.deLastDate.Location = new System.Drawing.Point(901, 68);
            this.deLastDate.Name = "deLastDate";
            this.deLastDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deLastDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deLastDate.Size = new System.Drawing.Size(93, 20);
            this.deLastDate.StyleController = this.layoutControl1;
            this.deLastDate.TabIndex = 10;
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(901, 243);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(93, 13);
            this.lbStatus.StyleController = this.layoutControl1;
            this.lbStatus.TabIndex = 9;
            // 
            // sbMonthly
            // 
            this.sbMonthly.Location = new System.Drawing.Point(901, 217);
            this.sbMonthly.Name = "sbMonthly";
            this.sbMonthly.Size = new System.Drawing.Size(93, 22);
            this.sbMonthly.StyleController = this.layoutControl1;
            this.sbMonthly.TabIndex = 8;
            this.sbMonthly.Text = "Aylık";
            this.sbMonthly.Click += new System.EventHandler(this.sbMonthly_Click);
            // 
            // deFirstDate
            // 
            this.deFirstDate.EditValue = null;
            this.deFirstDate.Location = new System.Drawing.Point(901, 28);
            this.deFirstDate.Name = "deFirstDate";
            this.deFirstDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFirstDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFirstDate.Size = new System.Drawing.Size(93, 20);
            this.deFirstDate.StyleController = this.layoutControl1;
            this.deFirstDate.TabIndex = 7;
            this.deFirstDate.EditValueChanged += new System.EventHandler(this.deDate_EditValueChanged);
            // 
            // sbClose
            // 
            this.sbClose.Location = new System.Drawing.Point(901, 342);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(93, 22);
            this.sbClose.StyleController = this.layoutControl1;
            this.sbClose.TabIndex = 6;
            this.sbClose.Text = "Kapat";
            // 
            // sbPrint
            // 
            this.sbPrint.Location = new System.Drawing.Point(901, 140);
            this.sbPrint.Name = "sbPrint";
            this.sbPrint.Size = new System.Drawing.Size(93, 22);
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
            this.gridControl1.Size = new System.Drawing.Size(885, 705);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRowNumber,
            this.colDate,
            this.colPaymentType,
            this.colPatientNo,
            this.colTCID,
            this.colAciklama,
            this.colTellerVoucherNo,
            this.colRecordType,
            this.colUSER_ID,
            this.colGirenTutar,
            this.colCikanTutar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUSER_ID, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colRowNumber
            // 
            this.colRowNumber.Caption = "Sıra Numarası";
            this.colRowNumber.FieldName = "RowNumber";
            this.colRowNumber.Name = "colRowNumber";
            this.colRowNumber.Visible = true;
            this.colRowNumber.VisibleIndex = 0;
            // 
            // colDate
            // 
            this.colDate.Caption = "Tarih";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            // 
            // colPaymentType
            // 
            this.colPaymentType.Caption = "Ödeme Şekli";
            this.colPaymentType.FieldName = "PaymentType";
            this.colPaymentType.Name = "colPaymentType";
            this.colPaymentType.Visible = true;
            this.colPaymentType.VisibleIndex = 3;
            // 
            // colTellerVoucherNo
            // 
            this.colTellerVoucherNo.Caption = "Makbuz No";
            this.colTellerVoucherNo.FieldName = "TellerVoucherNo";
            this.colTellerVoucherNo.Name = "colTellerVoucherNo";
            this.colTellerVoucherNo.Visible = true;
            this.colTellerVoucherNo.VisibleIndex = 2;
            // 
            // colRecordType
            // 
            this.colRecordType.Caption = "Borç/Alacak";
            this.colRecordType.FieldName = "RecordType";
            this.colRecordType.Name = "colRecordType";
            this.colRecordType.Visible = true;
            this.colRecordType.VisibleIndex = 4;
            // 
            // colUSER_ID
            // 
            this.colUSER_ID.Caption = "Kullanıcı";
            this.colUSER_ID.DisplayFormat.FormatString = "#,###.00";
            this.colUSER_ID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUSER_ID.FieldName = "USER_ID";
            this.colUSER_ID.Name = "colUSER_ID";
            this.colUSER_ID.Visible = true;
            this.colUSER_ID.VisibleIndex = 5;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 5;
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
            this.colGirenTutar.VisibleIndex = 6;
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
            this.colCikanTutar.VisibleIndex = 7;
            // 
            // colPatientNo
            // 
            this.colPatientNo.Caption = "Protakol No";
            this.colPatientNo.FieldName = "PatientNo";
            this.colPatientNo.Name = "colPatientNo";
            this.colPatientNo.Visible = true;
            this.colPatientNo.VisibleIndex = 8;
            // 
            // colTCID
            // 
            this.colTCID.Caption = "T.C. Kimlik No";
            this.colTCID.FieldName = "TCID";
            this.colTCID.Name = "colTCID";
            this.colTCID.Visible = true;
            this.colTCID.VisibleIndex = 9;
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
            this.lciFirstDate,
            this.layoutControlItem5,
            this.emptySpaceItem4,
            this.layoutControlItem6,
            this.lciLastDate});
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
            this.layoutControlItem1.Size = new System.Drawing.Size(889, 709);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbPrint;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(889, 128);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(97, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbClose;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(889, 330);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(97, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(889, 248);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(97, 82);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(889, 80);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(97, 48);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(889, 356);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(97, 353);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciFirstDate
            // 
            this.lciFirstDate.Control = this.deFirstDate;
            this.lciFirstDate.CustomizationFormText = "layoutControlItem4";
            this.lciFirstDate.Location = new System.Drawing.Point(889, 0);
            this.lciFirstDate.Name = "lciFirstDate";
            this.lciFirstDate.Size = new System.Drawing.Size(97, 40);
            this.lciFirstDate.Text = "Başlangıç";
            this.lciFirstDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciFirstDate.TextSize = new System.Drawing.Size(44, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbMonthly;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(889, 205);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(97, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(889, 154);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(97, 51);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lbStatus;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(889, 231);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(97, 17);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // lciLastDate
            // 
            this.lciLastDate.Control = this.deLastDate;
            this.lciLastDate.CustomizationFormText = "layoutControlItem7";
            this.lciLastDate.Location = new System.Drawing.Point(889, 40);
            this.lciLastDate.Name = "lciLastDate";
            this.lciLastDate.Size = new System.Drawing.Size(97, 40);
            this.lciLastDate.Text = "Bitiş";
            this.lciLastDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciLastDate.TextSize = new System.Drawing.Size(44, 13);
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
            ((System.ComponentModel.ISupportInitialize)(this.deLastDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deLastDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFirstDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFirstDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFirstDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLastDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit deFirstDate;
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
        private DevExpress.XtraLayout.LayoutControlItem lciFirstDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRowNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType;
        private DevExpress.XtraGrid.Columns.GridColumn colTellerVoucherNo;
        private DevExpress.XtraGrid.Columns.GridColumn colRecordType;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colGirenTutar;
        private DevExpress.XtraEditors.LabelControl lbStatus;
        private DevExpress.XtraEditors.SimpleButton sbMonthly;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.DateEdit deLastDate;
        private DevExpress.XtraLayout.LayoutControlItem lciLastDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCikanTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTCID;
    }
}