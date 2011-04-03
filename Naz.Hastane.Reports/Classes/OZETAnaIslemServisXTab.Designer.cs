namespace Naz.Hastane.Reports.Classes
{
    partial class OZETAnaIslemServisXTab
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
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.rtblOzetServisAnaIslemTableAdapter = new Naz.Hastane.Reports.DataSets.TIPDATADataSetTableAdapters.rtblOzetServisAnaIslemTableAdapter();
            this.tipdataDataSet = new Naz.Hastane.Reports.DataSets.TIPDATADataSet();
            this.fieldKey1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldKey2 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldToplamC = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
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
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataAdapter = this.rtblOzetServisAnaIslemTableAdapter;
            this.xrPivotGrid1.DataMember = "rtblOzetServisAnaIslem";
            this.xrPivotGrid1.DataSource = this.tipdataDataSet;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldKey1,
            this.fieldKey2,
            this.fieldToplamC});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsChartDataSource.UpdateDelay = 300;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(771.25F, 357.2917F);
            // 
            // rtblOzetServisAnaIslemTableAdapter
            // 
            this.rtblOzetServisAnaIslemTableAdapter.ClearBeforeFill = true;
            // 
            // tipdataDataSet
            // 
            this.tipdataDataSet.DataSetName = "TIPDATADataSet";
            this.tipdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldKey1
            // 
            this.fieldKey1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldKey1.AreaIndex = 0;
            this.fieldKey1.Caption = "Servisler";
            this.fieldKey1.FieldName = "Key1";
            this.fieldKey1.Name = "fieldKey1";
            this.fieldKey1.TotalCellFormat.FormatString = "{0:#,#}";
            this.fieldKey1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldKey1.TotalValueFormat.FormatString = "{0:#,#}";
            this.fieldKey1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldKey1.ValueFormat.FormatString = "{0:#,#}";
            this.fieldKey1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldKey2
            // 
            this.fieldKey2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldKey2.AreaIndex = 0;
            this.fieldKey2.Caption = "Hizmetler";
            this.fieldKey2.FieldName = "Key2";
            this.fieldKey2.Name = "fieldKey2";
            this.fieldKey2.TotalCellFormat.FormatString = "{0:#,#}";
            this.fieldKey2.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldKey2.TotalValueFormat.FormatString = "{0:#,#}";
            this.fieldKey2.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldKey2.ValueFormat.FormatString = "{0:#,#}";
            this.fieldKey2.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
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
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel1});
            this.PageHeader.HeightF = 52.08333F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(177.4999F, 9.999998F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(559.3751F, 30.20834F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "HÝZMET ÖZET RAPORU (Mart 2011)";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
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
            this.xrLabel3.Text = "RAPOR-14";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // OZETAnaIslemServisXTab
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
        private DataSets.TIPDATADataSetTableAdapters.rtblOzetServisAnaIslemTableAdapter rtblOzetServisAnaIslemTableAdapter;
        private DataSets.TIPDATADataSet tipdataDataSet;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldKey1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldKey2;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldToplamC;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
    }
}
