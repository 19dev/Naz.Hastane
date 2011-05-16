namespace Naz.Hastane.Win.MDIChildForms
{
    partial class EczaneReportForm
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
            this.pgcParasiGeriOdenecek = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.key1Key2ValueRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.deEndDate = new DevExpress.XtraEditors.DateEdit();
            this.sbRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.deStartDate = new DevExpress.XtraEditors.DateEdit();
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.sbPrint = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciStartDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEndDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRefresh = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciParasiGeriOdenecek = new DevExpress.XtraLayout.LayoutControlItem();
            this.pgcYatakliServisler = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgcParasiGeriOdenecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key1Key2ValueRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciParasiGeriOdenecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgcYatakliServisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.pgcYatakliServisler);
            this.layoutControl1.Controls.Add(this.pgcParasiGeriOdenecek);
            this.layoutControl1.Controls.Add(this.deEndDate);
            this.layoutControl1.Controls.Add(this.sbRefresh);
            this.layoutControl1.Controls.Add(this.deStartDate);
            this.layoutControl1.Controls.Add(this.sbClose);
            this.layoutControl1.Controls.Add(this.sbPrint);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1006, 729);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // pgcParasiGeriOdenecek
            // 
            this.pgcParasiGeriOdenecek.DataSource = this.key1Key2ValueRecordBindingSource;
            this.pgcParasiGeriOdenecek.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3});
            this.pgcParasiGeriOdenecek.Location = new System.Drawing.Point(12, 28);
            this.pgcParasiGeriOdenecek.Name = "pgcParasiGeriOdenecek";
            this.pgcParasiGeriOdenecek.Size = new System.Drawing.Size(864, 334);
            this.pgcParasiGeriOdenecek.TabIndex = 13;
            // 
            // key1Key2ValueRecordBindingSource
            // 
            this.key1Key2ValueRecordBindingSource.DataSource = typeof(Naz.Hastane.Data.Entities.StoredProcedure.Key1Key2ValueRecord);
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Depo";
            this.pivotGridField1.FieldName = "Key1";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Width = 170;
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField2.AreaIndex = 0;
            this.pivotGridField2.Caption = "Gruplar";
            this.pivotGridField2.FieldName = "Key2";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.Width = 70;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField3.AreaIndex = 0;
            this.pivotGridField3.Caption = "Toplam";
            this.pivotGridField3.CellFormat.FormatString = "#,##0.00";
            this.pivotGridField3.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.pivotGridField3.FieldName = "Value";
            this.pivotGridField3.Name = "pivotGridField3";
            this.pivotGridField3.TotalCellFormat.FormatString = "#,##0.00";
            this.pivotGridField3.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.pivotGridField3.TotalValueFormat.FormatString = "#,##0.00";
            this.pivotGridField3.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.pivotGridField3.ValueFormat.FormatString = "#,##0.00";
            this.pivotGridField3.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // deEndDate
            // 
            this.deEndDate.EditValue = null;
            this.deEndDate.Location = new System.Drawing.Point(880, 68);
            this.deEndDate.Name = "deEndDate";
            this.deEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deEndDate.Size = new System.Drawing.Size(114, 20);
            this.deEndDate.StyleController = this.layoutControl1;
            this.deEndDate.TabIndex = 10;
            // 
            // sbRefresh
            // 
            this.sbRefresh.Location = new System.Drawing.Point(880, 104);
            this.sbRefresh.Name = "sbRefresh";
            this.sbRefresh.Size = new System.Drawing.Size(114, 22);
            this.sbRefresh.StyleController = this.layoutControl1;
            this.sbRefresh.TabIndex = 12;
            this.sbRefresh.Text = "Sorgula";
            this.sbRefresh.Click += new System.EventHandler(this.sbRefresh_Click);
            // 
            // deStartDate
            // 
            this.deStartDate.EditValue = null;
            this.deStartDate.Location = new System.Drawing.Point(880, 28);
            this.deStartDate.Name = "deStartDate";
            this.deStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deStartDate.Size = new System.Drawing.Size(114, 20);
            this.deStartDate.StyleController = this.layoutControl1;
            this.deStartDate.TabIndex = 7;
            // 
            // sbClose
            // 
            this.sbClose.Location = new System.Drawing.Point(880, 315);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(114, 22);
            this.sbClose.StyleController = this.layoutControl1;
            this.sbClose.TabIndex = 6;
            this.sbClose.Text = "Kapat";
            // 
            // sbPrint
            // 
            this.sbPrint.Location = new System.Drawing.Point(880, 130);
            this.sbPrint.Name = "sbPrint";
            this.sbPrint.Size = new System.Drawing.Size(114, 22);
            this.sbPrint.StyleController = this.layoutControl1;
            this.sbPrint.TabIndex = 5;
            this.sbPrint.Text = "Yazıcıya";
            this.sbPrint.Click += new System.EventHandler(this.sbPrint_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.lciStartDate,
            this.lciEndDate,
            this.lciRefresh,
            this.lciParasiGeriOdenecek,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1006, 729);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbPrint;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(868, 118);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(118, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbClose;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(868, 303);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(118, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(868, 144);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(118, 159);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(868, 80);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(118, 12);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(868, 329);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(118, 380);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciStartDate
            // 
            this.lciStartDate.Control = this.deStartDate;
            this.lciStartDate.CustomizationFormText = "layoutControlItem4";
            this.lciStartDate.Location = new System.Drawing.Point(868, 0);
            this.lciStartDate.Name = "lciStartDate";
            this.lciStartDate.Size = new System.Drawing.Size(118, 40);
            this.lciStartDate.Text = "Başlangıç";
            this.lciStartDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciStartDate.TextSize = new System.Drawing.Size(114, 13);
            // 
            // lciEndDate
            // 
            this.lciEndDate.Control = this.deEndDate;
            this.lciEndDate.CustomizationFormText = "layoutControlItem7";
            this.lciEndDate.Location = new System.Drawing.Point(868, 40);
            this.lciEndDate.Name = "lciEndDate";
            this.lciEndDate.Size = new System.Drawing.Size(118, 40);
            this.lciEndDate.Text = "Bitiş";
            this.lciEndDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciEndDate.TextSize = new System.Drawing.Size(114, 13);
            // 
            // lciRefresh
            // 
            this.lciRefresh.Control = this.sbRefresh;
            this.lciRefresh.CustomizationFormText = "Sorgula";
            this.lciRefresh.Location = new System.Drawing.Point(868, 92);
            this.lciRefresh.Name = "lciRefresh";
            this.lciRefresh.Size = new System.Drawing.Size(118, 26);
            this.lciRefresh.Text = "Sorgula";
            this.lciRefresh.TextSize = new System.Drawing.Size(0, 0);
            this.lciRefresh.TextToControlDistance = 0;
            this.lciRefresh.TextVisible = false;
            // 
            // lciParasiGeriOdenecek
            // 
            this.lciParasiGeriOdenecek.Control = this.pgcParasiGeriOdenecek;
            this.lciParasiGeriOdenecek.CustomizationFormText = "Parası Geri Ödenecek";
            this.lciParasiGeriOdenecek.Location = new System.Drawing.Point(0, 0);
            this.lciParasiGeriOdenecek.Name = "lciParasiGeriOdenecek";
            this.lciParasiGeriOdenecek.Size = new System.Drawing.Size(868, 354);
            this.lciParasiGeriOdenecek.Text = "Parası Geri Ödenecek";
            this.lciParasiGeriOdenecek.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciParasiGeriOdenecek.TextSize = new System.Drawing.Size(114, 13);
            // 
            // pgcYatakliServisler
            // 
            this.pgcYatakliServisler.DataSource = this.key1Key2ValueRecordBindingSource;
            this.pgcYatakliServisler.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField4,
            this.pivotGridField5,
            this.pivotGridField6});
            this.pgcYatakliServisler.Location = new System.Drawing.Point(12, 382);
            this.pgcYatakliServisler.Name = "pgcYatakliServisler";
            this.pgcYatakliServisler.Size = new System.Drawing.Size(864, 335);
            this.pgcYatakliServisler.TabIndex = 14;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pgcYatakliServisler;
            this.layoutControlItem1.CustomizationFormText = "Yataklı Servisler Toplamı";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 354);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(868, 355);
            this.layoutControlItem1.Text = "Yataklı Servisler Toplamı";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(114, 13);
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField4.AreaIndex = 0;
            this.pivotGridField4.Caption = "Servis";
            this.pivotGridField4.FieldName = "Key1";
            this.pivotGridField4.Name = "pivotGridField4";
            this.pivotGridField4.Width = 170;
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField5.AreaIndex = 0;
            this.pivotGridField5.Caption = "Tutar";
            this.pivotGridField5.FieldName = "Key2";
            this.pivotGridField5.Name = "pivotGridField5";
            this.pivotGridField5.Width = 70;
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField6.AreaIndex = 0;
            this.pivotGridField6.Caption = "Toplam";
            this.pivotGridField6.CellFormat.FormatString = "#,##0.00";
            this.pivotGridField6.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.pivotGridField6.FieldName = "Value";
            this.pivotGridField6.Name = "pivotGridField6";
            this.pivotGridField6.TotalCellFormat.FormatString = "#,##0.00";
            this.pivotGridField6.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.pivotGridField6.TotalValueFormat.FormatString = "#,##0.00";
            this.pivotGridField6.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.pivotGridField6.ValueFormat.FormatString = "#,##0.00";
            this.pivotGridField6.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // EczaneReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 729);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EczaneReportForm";
            this.Text = "Muhasebe Entegrasyon Formu";
            this.Load += new System.EventHandler(this.EczaneReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pgcParasiGeriOdenecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key1Key2ValueRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciParasiGeriOdenecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgcYatakliServisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit deStartDate;
        private DevExpress.XtraEditors.SimpleButton sbClose;
        private DevExpress.XtraEditors.SimpleButton sbPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem lciStartDate;
        private DevExpress.XtraEditors.DateEdit deEndDate;
        private DevExpress.XtraLayout.LayoutControlItem lciEndDate;
        private DevExpress.XtraEditors.SimpleButton sbRefresh;
        private DevExpress.XtraLayout.LayoutControlItem lciRefresh;
        private DevExpress.XtraPivotGrid.PivotGridControl pgcParasiGeriOdenecek;
        private System.Windows.Forms.BindingSource key1Key2ValueRecordBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraLayout.LayoutControlItem lciParasiGeriOdenecek;
        private DevExpress.XtraPivotGrid.PivotGridControl pgcYatakliServisler;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}