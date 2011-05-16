namespace Naz.Hastane.Reports.Classes
{
    partial class EczaneReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.bsKey1Key2Value = new System.Windows.Forms.BindingSource();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.pgcParasiGeriOdenecek = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.xrPivotGridField1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotGridField2 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotGridField3 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.pgcYatakliServisler = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.xrPivotGridField4 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotGridField5 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotGridField6 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.bsKey1Key2Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 56.25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 15F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 21F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // bsKey1Key2Value
            // 
            this.bsKey1Key2Value.DataSource = typeof(Naz.Hastane.Data.Entities.StoredProcedure.Key1Key2ValueRecord);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pgcYatakliServisler,
            this.pgcParasiGeriOdenecek});
            this.ReportHeader.HeightF = 250.8333F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // pgcParasiGeriOdenecek
            // 
            this.pgcParasiGeriOdenecek.DataSource = this.bsKey1Key2Value;
            this.pgcParasiGeriOdenecek.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.xrPivotGridField1,
            this.xrPivotGridField2,
            this.xrPivotGridField3});
            this.pgcParasiGeriOdenecek.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 9.999998F);
            this.pgcParasiGeriOdenecek.Name = "pgcParasiGeriOdenecek";
            this.pgcParasiGeriOdenecek.OptionsChartDataSource.UpdateDelay = 300;
            this.pgcParasiGeriOdenecek.SizeF = new System.Drawing.SizeF(384.7916F, 112.2916F);
            // 
            // xrPivotGridField1
            // 
            this.xrPivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xrPivotGridField1.AreaIndex = 0;
            this.xrPivotGridField1.Caption = "Depo";
            this.xrPivotGridField1.FieldName = "Key1";
            this.xrPivotGridField1.Name = "xrPivotGridField1";
            this.xrPivotGridField1.Width = 180;
            // 
            // xrPivotGridField2
            // 
            this.xrPivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.xrPivotGridField2.AreaIndex = 0;
            this.xrPivotGridField2.Caption = "Gruplar";
            this.xrPivotGridField2.FieldName = "Key2";
            this.xrPivotGridField2.Name = "xrPivotGridField2";
            this.xrPivotGridField2.TotalCellFormat.FormatString = "{0:#,##0.00}";
            this.xrPivotGridField2.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xrPivotGridField2.TotalValueFormat.FormatString = "{0:#,##0.00}";
            this.xrPivotGridField2.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xrPivotGridField2.ValueFormat.FormatString = "{0:#,##0.00}";
            this.xrPivotGridField2.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xrPivotGridField2.Width = 70;
            // 
            // xrPivotGridField3
            // 
            this.xrPivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.xrPivotGridField3.AreaIndex = 0;
            this.xrPivotGridField3.Caption = "Toplam";
            this.xrPivotGridField3.CellFormat.FormatString = "#,##0.00";
            this.xrPivotGridField3.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.xrPivotGridField3.FieldName = "Value";
            this.xrPivotGridField3.Name = "xrPivotGridField3";
            this.xrPivotGridField3.TotalCellFormat.FormatString = "#,##0.00";
            this.xrPivotGridField3.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.xrPivotGridField3.TotalValueFormat.FormatString = "#,##0.00";
            this.xrPivotGridField3.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.xrPivotGridField3.ValueFormat.FormatString = "#,##0.00";
            this.xrPivotGridField3.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // pgcYatakliServisler
            // 
            this.pgcYatakliServisler.DataSource = this.bsKey1Key2Value;
            this.pgcYatakliServisler.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.xrPivotGridField4,
            this.xrPivotGridField5,
            this.xrPivotGridField6});
            this.pgcYatakliServisler.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 138.5417F);
            this.pgcYatakliServisler.Name = "pgcYatakliServisler";
            this.pgcYatakliServisler.OptionsChartDataSource.UpdateDelay = 300;
            this.pgcYatakliServisler.SizeF = new System.Drawing.SizeF(384.7916F, 112.2916F);
            // 
            // xrPivotGridField4
            // 
            this.xrPivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xrPivotGridField4.AreaIndex = 0;
            this.xrPivotGridField4.Caption = "Depo";
            this.xrPivotGridField4.FieldName = "Key1";
            this.xrPivotGridField4.Name = "xrPivotGridField4";
            this.xrPivotGridField4.Width = 180;
            // 
            // xrPivotGridField5
            // 
            this.xrPivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.xrPivotGridField5.AreaIndex = 0;
            this.xrPivotGridField5.Caption = "Gruplar";
            this.xrPivotGridField5.FieldName = "Key2";
            this.xrPivotGridField5.Name = "xrPivotGridField5";
            this.xrPivotGridField5.TotalCellFormat.FormatString = "{0:#,##0.00}";
            this.xrPivotGridField5.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xrPivotGridField5.TotalValueFormat.FormatString = "{0:#,##0.00}";
            this.xrPivotGridField5.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xrPivotGridField5.ValueFormat.FormatString = "{0:#,##0.00}";
            this.xrPivotGridField5.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xrPivotGridField5.Width = 70;
            // 
            // xrPivotGridField6
            // 
            this.xrPivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.xrPivotGridField6.AreaIndex = 0;
            this.xrPivotGridField6.Caption = "Toplam";
            this.xrPivotGridField6.CellFormat.FormatString = "#,##0.00";
            this.xrPivotGridField6.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.xrPivotGridField6.FieldName = "Value";
            this.xrPivotGridField6.Name = "xrPivotGridField6";
            this.xrPivotGridField6.TotalCellFormat.FormatString = "#,##0.00";
            this.xrPivotGridField6.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.xrPivotGridField6.TotalValueFormat.FormatString = "#,##0.00";
            this.xrPivotGridField6.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.xrPivotGridField6.ValueFormat.FormatString = "#,##0.00";
            this.xrPivotGridField6.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // EczaneReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.Margins = new System.Drawing.Printing.Margins(22, 30, 15, 21);
            this.Version = "10.2";
            ((System.ComponentModel.ISupportInitialize)(this.bsKey1Key2Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.Windows.Forms.BindingSource bsKey1Key2Value;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        public DevExpress.XtraReports.UI.XRPivotGrid pgcParasiGeriOdenecek;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField2;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField3;
        public DevExpress.XtraReports.UI.XRPivotGrid pgcYatakliServisler;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField4;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField5;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField6;
    }
}
