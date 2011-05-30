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
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.bsParasiGeriDonecek = new System.Windows.Forms.BindingSource(this.components);
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.pgParasiGeriDonecek = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.xrPivotGridField1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotGridField2 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotGridField3 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.pgParasiGeriDonmeyen = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.xrPivotGridField7 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotGridField8 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotGridField9 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.bsParasiGeriDonmeyen = new System.Windows.Forms.BindingSource(this.components);
            this.srptSiparisFaturalari = new DevExpress.XtraReports.UI.XRSubreport();
            this.srptToplamSatis = new DevExpress.XtraReports.UI.XRSubreport();
            this.srptUcretsizler = new DevExpress.XtraReports.UI.XRSubreport();
            this.lblMeccaniler = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblEczanedenCikan = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblMeccanilerCiktiktanSonraKalan = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblStok = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bsParasiGeriDonecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsParasiGeriDonmeyen)).BeginInit();
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
            // bsParasiGeriDonecek
            // 
            this.bsParasiGeriDonecek.DataSource = typeof(Naz.Hastane.Data.Entities.StoredProcedure.Key1Key2ValueRecord);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.lblStok,
            this.xrLabel5,
            this.lblMeccanilerCiktiktanSonraKalan,
            this.xrLabel3,
            this.lblEczanedenCikan,
            this.xrLabel2,
            this.lblMeccaniler,
            this.srptUcretsizler,
            this.srptToplamSatis,
            this.srptSiparisFaturalari,
            this.pgParasiGeriDonmeyen,
            this.pgParasiGeriDonecek});
            this.ReportHeader.HeightF = 584.1666F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // pgParasiGeriDonecek
            // 
            this.pgParasiGeriDonecek.DataSource = this.bsParasiGeriDonecek;
            this.pgParasiGeriDonecek.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.xrPivotGridField1,
            this.xrPivotGridField2,
            this.xrPivotGridField3});
            this.pgParasiGeriDonecek.LocationFloat = new DevExpress.Utils.PointFloat(0F, 135.6251F);
            this.pgParasiGeriDonecek.Name = "pgParasiGeriDonecek";
            this.pgParasiGeriDonecek.OptionsChartDataSource.UpdateDelay = 300;
            this.pgParasiGeriDonecek.SizeF = new System.Drawing.SizeF(384.7916F, 87.29161F);
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
            // pgParasiGeriDonmeyen
            // 
            this.pgParasiGeriDonmeyen.DataSource = this.bsParasiGeriDonecek;
            this.pgParasiGeriDonmeyen.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.xrPivotGridField7,
            this.xrPivotGridField8,
            this.xrPivotGridField9});
            this.pgParasiGeriDonmeyen.LocationFloat = new DevExpress.Utils.PointFloat(0F, 247.9167F);
            this.pgParasiGeriDonmeyen.Name = "pgParasiGeriDonmeyen";
            this.pgParasiGeriDonmeyen.OptionsChartDataSource.UpdateDelay = 300;
            this.pgParasiGeriDonmeyen.SizeF = new System.Drawing.SizeF(384.7916F, 85.2083F);
            // 
            // xrPivotGridField7
            // 
            this.xrPivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xrPivotGridField7.AreaIndex = 0;
            this.xrPivotGridField7.Caption = "Depo";
            this.xrPivotGridField7.FieldName = "Key1";
            this.xrPivotGridField7.Name = "xrPivotGridField7";
            this.xrPivotGridField7.Width = 180;
            // 
            // xrPivotGridField8
            // 
            this.xrPivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.xrPivotGridField8.AreaIndex = 0;
            this.xrPivotGridField8.Caption = "Gruplar";
            this.xrPivotGridField8.FieldName = "Key2";
            this.xrPivotGridField8.Name = "xrPivotGridField8";
            this.xrPivotGridField8.TotalCellFormat.FormatString = "{0:#,##0.00}";
            this.xrPivotGridField8.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xrPivotGridField8.TotalValueFormat.FormatString = "{0:#,##0.00}";
            this.xrPivotGridField8.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xrPivotGridField8.ValueFormat.FormatString = "{0:#,##0.00}";
            this.xrPivotGridField8.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xrPivotGridField8.Width = 70;
            // 
            // xrPivotGridField9
            // 
            this.xrPivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.xrPivotGridField9.AreaIndex = 0;
            this.xrPivotGridField9.Caption = "Toplam";
            this.xrPivotGridField9.CellFormat.FormatString = "#,##0.00";
            this.xrPivotGridField9.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.xrPivotGridField9.FieldName = "Value";
            this.xrPivotGridField9.Name = "xrPivotGridField9";
            this.xrPivotGridField9.TotalCellFormat.FormatString = "#,##0.00";
            this.xrPivotGridField9.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.xrPivotGridField9.TotalValueFormat.FormatString = "#,##0.00";
            this.xrPivotGridField9.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.xrPivotGridField9.ValueFormat.FormatString = "#,##0.00";
            this.xrPivotGridField9.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // bsParasiGeriDonmeyen
            // 
            this.bsParasiGeriDonmeyen.DataSource = typeof(Naz.Hastane.Data.Entities.StoredProcedure.Key1Key2ValueRecord);
            // 
            // srptSiparisFaturalari
            // 
            this.srptSiparisFaturalari.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.srptSiparisFaturalari.Name = "srptSiparisFaturalari";
            this.srptSiparisFaturalari.SizeF = new System.Drawing.SizeF(384.7916F, 53.20834F);
            // 
            // srptToplamSatis
            // 
            this.srptToplamSatis.LocationFloat = new DevExpress.Utils.PointFloat(0F, 60.95829F);
            this.srptToplamSatis.Name = "srptToplamSatis";
            this.srptToplamSatis.SizeF = new System.Drawing.SizeF(384.7916F, 53.20834F);
            // 
            // srptUcretsizler
            // 
            this.srptUcretsizler.LocationFloat = new DevExpress.Utils.PointFloat(0F, 347.9167F);
            this.srptUcretsizler.Name = "srptUcretsizler";
            this.srptUcretsizler.SizeF = new System.Drawing.SizeF(384.7916F, 53.20834F);
            // 
            // lblMeccaniler
            // 
            this.lblMeccaniler.LocationFloat = new DevExpress.Utils.PointFloat(284.7916F, 427.0417F);
            this.lblMeccaniler.Name = "lblMeccaniler";
            this.lblMeccaniler.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lblMeccaniler.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblMeccaniler.Text = "lblMeccaniler";
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 427.0417F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(273.9583F, 23F);
            this.xrLabel2.Text = "Meccaniler Toplam";
            // 
            // lblEczanedenCikan
            // 
            this.lblEczanedenCikan.LocationFloat = new DevExpress.Utils.PointFloat(284.7916F, 461.4583F);
            this.lblEczanedenCikan.Name = "lblEczanedenCikan";
            this.lblEczanedenCikan.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblEczanedenCikan.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblEczanedenCikan.Text = "lblEczanedenCikan";
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 461.4583F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(273.9583F, 23F);
            this.xrLabel3.Text = "Eczaneden Çýkan Toplam";
            // 
            // lblMeccanilerCiktiktanSonraKalan
            // 
            this.lblMeccanilerCiktiktanSonraKalan.LocationFloat = new DevExpress.Utils.PointFloat(284.7916F, 495.8333F);
            this.lblMeccanilerCiktiktanSonraKalan.Name = "lblMeccanilerCiktiktanSonraKalan";
            this.lblMeccanilerCiktiktanSonraKalan.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblMeccanilerCiktiktanSonraKalan.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblMeccanilerCiktiktanSonraKalan.Text = "lblMeccanilerCiktiktanSonraKalan";
            // 
            // xrLabel5
            // 
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 495.8333F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(273.9583F, 23.00003F);
            this.xrLabel5.Text = "Meccaniler Çýktýktan Sonra Kalan Toplam";
            // 
            // lblStok
            // 
            this.lblStok.LocationFloat = new DevExpress.Utils.PointFloat(284.7916F, 531.25F);
            this.lblStok.Name = "lblStok";
            this.lblStok.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblStok.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblStok.Text = "lblStok";
            // 
            // xrLabel7
            // 
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 531.25F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(273.9583F, 23F);
            this.xrLabel7.Text = "Stok";
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
            ((System.ComponentModel.ISupportInitialize)(this.bsParasiGeriDonecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsParasiGeriDonmeyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        public DevExpress.XtraReports.UI.XRPivotGrid pgParasiGeriDonecek;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField2;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField3;
        public DevExpress.XtraReports.UI.XRPivotGrid pgParasiGeriDonmeyen;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField7;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField8;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField9;
        public System.Windows.Forms.BindingSource bsParasiGeriDonecek;
        private System.Windows.Forms.BindingSource bsParasiGeriDonmeyen;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        public DevExpress.XtraReports.UI.XRLabel lblStok;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        public DevExpress.XtraReports.UI.XRLabel lblMeccanilerCiktiktanSonraKalan;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        public DevExpress.XtraReports.UI.XRLabel lblEczanedenCikan;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        public DevExpress.XtraReports.UI.XRLabel lblMeccaniler;
        public DevExpress.XtraReports.UI.XRSubreport srptUcretsizler;
        public DevExpress.XtraReports.UI.XRSubreport srptToplamSatis;
        public DevExpress.XtraReports.UI.XRSubreport srptSiparisFaturalari;
    }
}
