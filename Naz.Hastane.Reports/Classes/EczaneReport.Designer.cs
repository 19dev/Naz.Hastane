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
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblStok = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblMeccanilerCiktiktanSonraKalan = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblEczanedenCikan = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblMeccaniler = new DevExpress.XtraReports.UI.XRLabel();
            this.srptUcretsizler = new DevExpress.XtraReports.UI.XRSubreport();
            this.keyValueReport3 = new Naz.Hastane.Reports.Classes.KeyValueReport();
            this.srptToplamSatis = new DevExpress.XtraReports.UI.XRSubreport();
            this.keyValueReport2 = new Naz.Hastane.Reports.Classes.KeyValueReport();
            this.srptSiparisFaturalari = new DevExpress.XtraReports.UI.XRSubreport();
            this.keyValueReport1 = new Naz.Hastane.Reports.Classes.KeyValueReport();
            this.pgParasiGeriDonmeyen = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.xrPivotGridField7 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotGridField8 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotGridField9 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.pgParasiGeriDonecek = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.xrPivotGridField1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotGridField2 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotGridField3 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.bsParasiGeriDonmeyen = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsParasiGeriDonecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyValueReport3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyValueReport2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyValueReport1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsParasiGeriDonmeyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
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
            this.BottomMargin.HeightF = 0F;
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
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel6,
            this.xrLabel4,
            this.xrLabel1,
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
            this.ReportHeader.HeightF = 681.3334F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 306.1667F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(240.625F, 23F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "Ücretsizler";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 399.9167F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(240.625F, 23F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "Parasý Geri Dönmeyen";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 180.3334F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(240.625F, 23F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "Parasý Geri Dönecek";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 89.62511F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(240.625F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "Toplam Satýþ";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(240.625F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Sipariþ Faturalar";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 650F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(321.2499F, 23F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "Stok";
            // 
            // lblStok
            // 
            this.lblStok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblStok.LocationFloat = new DevExpress.Utils.PointFloat(321.2499F, 649.9999F);
            this.lblStok.Name = "lblStok";
            this.lblStok.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblStok.SizeF = new System.Drawing.SizeF(130.2083F, 23F);
            this.lblStok.StylePriority.UseFont = false;
            this.lblStok.StylePriority.UseTextAlignment = false;
            this.lblStok.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 614.5833F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(321.2499F, 23.00006F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "Meccaniler Çýktýktan Sonra Kalan Toplam";
            // 
            // lblMeccanilerCiktiktanSonraKalan
            // 
            this.lblMeccanilerCiktiktanSonraKalan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblMeccanilerCiktiktanSonraKalan.LocationFloat = new DevExpress.Utils.PointFloat(321.2499F, 614.5833F);
            this.lblMeccanilerCiktiktanSonraKalan.Name = "lblMeccanilerCiktiktanSonraKalan";
            this.lblMeccanilerCiktiktanSonraKalan.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblMeccanilerCiktiktanSonraKalan.SizeF = new System.Drawing.SizeF(130.2083F, 23F);
            this.lblMeccanilerCiktiktanSonraKalan.StylePriority.UseFont = false;
            this.lblMeccanilerCiktiktanSonraKalan.StylePriority.UseTextAlignment = false;
            this.lblMeccanilerCiktiktanSonraKalan.Text = "lblMeccanilerCiktiktanSonraKalan";
            this.lblMeccanilerCiktiktanSonraKalan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 580.2083F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(321.2499F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "Eczaneden Çýkan Toplam";
            // 
            // lblEczanedenCikan
            // 
            this.lblEczanedenCikan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblEczanedenCikan.LocationFloat = new DevExpress.Utils.PointFloat(321.2499F, 580.2083F);
            this.lblEczanedenCikan.Name = "lblEczanedenCikan";
            this.lblEczanedenCikan.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblEczanedenCikan.SizeF = new System.Drawing.SizeF(130.2083F, 23F);
            this.lblEczanedenCikan.StylePriority.UseFont = false;
            this.lblEczanedenCikan.StylePriority.UseTextAlignment = false;
            this.lblEczanedenCikan.Text = "lblEczanedenCikan";
            this.lblEczanedenCikan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 545.7917F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(321.2499F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Meccaniler Toplam";
            // 
            // lblMeccaniler
            // 
            this.lblMeccaniler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblMeccaniler.LocationFloat = new DevExpress.Utils.PointFloat(321.2499F, 545.7916F);
            this.lblMeccaniler.Name = "lblMeccaniler";
            this.lblMeccaniler.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblMeccaniler.SizeF = new System.Drawing.SizeF(130.2083F, 23F);
            this.lblMeccaniler.StylePriority.UseFont = false;
            this.lblMeccaniler.StylePriority.UseTextAlignment = false;
            this.lblMeccaniler.Text = "lblMeccaniler";
            this.lblMeccaniler.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // srptUcretsizler
            // 
            this.srptUcretsizler.LocationFloat = new DevExpress.Utils.PointFloat(0F, 329.1667F);
            this.srptUcretsizler.Name = "srptUcretsizler";
            this.srptUcretsizler.ReportSource = this.keyValueReport3;
            this.srptUcretsizler.SizeF = new System.Drawing.SizeF(384.7916F, 53.20834F);
            // 
            // srptToplamSatis
            // 
            this.srptToplamSatis.LocationFloat = new DevExpress.Utils.PointFloat(0F, 112.6251F);
            this.srptToplamSatis.Name = "srptToplamSatis";
            this.srptToplamSatis.ReportSource = this.keyValueReport2;
            this.srptToplamSatis.SizeF = new System.Drawing.SizeF(384.7916F, 53.20834F);
            // 
            // srptSiparisFaturalari
            // 
            this.srptSiparisFaturalari.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23F);
            this.srptSiparisFaturalari.Name = "srptSiparisFaturalari";
            this.srptSiparisFaturalari.ReportSource = this.keyValueReport1;
            this.srptSiparisFaturalari.SizeF = new System.Drawing.SizeF(384.7916F, 53.20834F);
            // 
            // pgParasiGeriDonmeyen
            // 
            this.pgParasiGeriDonmeyen.DataSource = this.bsParasiGeriDonecek;
            this.pgParasiGeriDonmeyen.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.xrPivotGridField7,
            this.xrPivotGridField8,
            this.xrPivotGridField9});
            this.pgParasiGeriDonmeyen.LocationFloat = new DevExpress.Utils.PointFloat(0F, 422.9167F);
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
            // pgParasiGeriDonecek
            // 
            this.pgParasiGeriDonecek.DataSource = this.bsParasiGeriDonecek;
            this.pgParasiGeriDonecek.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.xrPivotGridField1,
            this.xrPivotGridField2,
            this.xrPivotGridField3});
            this.pgParasiGeriDonecek.LocationFloat = new DevExpress.Utils.PointFloat(0F, 203.3334F);
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
            // bsParasiGeriDonmeyen
            // 
            this.bsParasiGeriDonmeyen.DataSource = typeof(Naz.Hastane.Data.Entities.StoredProcedure.Key1Key2ValueRecord);
            // 
            // EczaneReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.Margins = new System.Drawing.Printing.Margins(22, 30, 15, 0);
            this.Version = "10.2";
            ((System.ComponentModel.ISupportInitialize)(this.bsParasiGeriDonecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyValueReport3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyValueReport2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyValueReport1)).EndInit();
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
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private KeyValueReport keyValueReport3;
        private KeyValueReport keyValueReport2;
        private KeyValueReport keyValueReport1;
    }
}
