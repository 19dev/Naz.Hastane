namespace Naz.Hastane.Reports.Classes
{
    partial class OZETAnaIslemAyXTab
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
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.rtblOzetAnaIslemAyTableAdapter = new Naz.Hastane.Reports.DataSets.TIPDATADataSetTableAdapters.rtblOzetAnaIslemAyTableAdapter();
            this.tipdataDataSet = new Naz.Hastane.Reports.DataSets.TIPDATADataSet();
            this.fieldKey21 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldKey1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldToplamC = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.prmPeriod = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tipdataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPivotGrid1});
            this.Detail.HeightF = 420.8333F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataAdapter = this.rtblOzetAnaIslemAyTableAdapter;
            this.xrPivotGrid1.DataMember = "rtblOzetAnaIslemAy";
            this.xrPivotGrid1.DataSource = this.tipdataDataSet;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldKey21,
            this.fieldKey1,
            this.fieldToplamC});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsChartDataSource.UpdateDelay = 300;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(771.25F, 357.2917F);
            // 
            // rtblOzetAnaIslemAyTableAdapter
            // 
            this.rtblOzetAnaIslemAyTableAdapter.ClearBeforeFill = true;
            // 
            // tipdataDataSet
            // 
            this.tipdataDataSet.DataSetName = "TIPDATADataSet";
            this.tipdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldKey21
            // 
            this.fieldKey21.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldKey21.AreaIndex = 0;
            this.fieldKey21.Caption = "Aylar";
            this.fieldKey21.FieldName = "Key2";
            this.fieldKey21.Name = "fieldKey21";
            this.fieldKey21.TotalCellFormat.FormatString = "{0:#,#}";
            this.fieldKey21.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldKey21.TotalValueFormat.FormatString = "{0:#,#}";
            this.fieldKey21.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldKey21.ValueFormat.FormatString = "{0:#,#}";
            this.fieldKey21.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldKey1
            // 
            this.fieldKey1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldKey1.AreaIndex = 0;
            this.fieldKey1.Caption = "Hizmetler";
            this.fieldKey1.FieldName = "Key1";
            this.fieldKey1.Name = "fieldKey1";
            this.fieldKey1.TotalCellFormat.FormatString = "{0:#,#}";
            this.fieldKey1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldKey1.TotalValueFormat.FormatString = "{0:#,#}";
            this.fieldKey1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldKey1.ValueFormat.FormatString = "{0:#,#}";
            this.fieldKey1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldToplamC
            // 
            this.fieldToplamC.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldToplamC.AreaIndex = 0;
            this.fieldToplamC.Caption = "Toplam Tutar";
            this.fieldToplamC.CellFormat.FormatString = "{0:#,#}";
            this.fieldToplamC.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldToplamC.FieldName = "ToplamC";
            this.fieldToplamC.GrandTotalCellFormat.FormatString = "{0:#,#}";
            this.fieldToplamC.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldToplamC.Name = "fieldToplamC";
            this.fieldToplamC.TotalCellFormat.FormatString = "{0:#,#}";
            this.fieldToplamC.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldToplamC.TotalValueFormat.FormatString = "{0:#,#}";
            this.fieldToplamC.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldToplamC.ValueFormat.FormatString = "{0:#,#}";
            this.fieldToplamC.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 35F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 39F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel1});
            this.PageHeader.HeightF = 88.54166F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prmPeriod, "Text", "")});
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(124.3752F, 40.20834F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(817.7083F, 40.625F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // prmPeriod
            // 
            this.prmPeriod.Name = "prmPeriod";
            this.prmPeriod.Value = "";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 9.999998F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "RAPOR-17";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(151.4582F, 9.999998F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(771.8751F, 30.20834F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "AYLARA GÖRE ÝÞLEM GELÝRÝ RAPORU";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // OZETAnaIslemAyXTab
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(25, 31, 35, 39);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prmPeriod});
            this.RequestParameters = false;
            this.ShowPrintMarginsWarning = false;
            this.ShowPrintStatusDialog = false;
            this.Version = "10.2";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            ((System.ComponentModel.ISupportInitialize)(this.tipdataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private DataSets.TIPDATADataSetTableAdapters.rtblOzetAnaIslemAyTableAdapter rtblOzetAnaIslemAyTableAdapter;
        private DataSets.TIPDATADataSet tipdataDataSet;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldKey21;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldKey1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldToplamC;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        public DevExpress.XtraReports.Parameters.Parameter prmPeriod;
    }
}
