﻿namespace Naz.Hastane.Win.MDIChildForms
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
            this.gcSelectedProducts = new DevExpress.XtraGrid.GridControl();
            this.gvSelectedProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSelectedProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedPatientPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCompanyPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcProducts = new DevExpress.XtraGrid.GridControl();
            this.gvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatientPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tlFunctionGroups = new DevExpress.XtraTreeList.TreeList();
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.sbSelect = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciFunctionGroups = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciProducts = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSelectedProducts = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
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
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcSelectedProducts);
            this.layoutControl1.Controls.Add(this.gcProducts);
            this.layoutControl1.Controls.Add(this.tlFunctionGroups);
            this.layoutControl1.Controls.Add(this.sbClose);
            this.layoutControl1.Controls.Add(this.sbSelect);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(935, 626);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcSelectedProducts
            // 
            this.gcSelectedProducts.Location = new System.Drawing.Point(386, 417);
            this.gcSelectedProducts.MainView = this.gvSelectedProducts;
            this.gcSelectedProducts.Name = "gcSelectedProducts";
            this.gcSelectedProducts.Size = new System.Drawing.Size(428, 197);
            this.gcSelectedProducts.TabIndex = 10;
            this.gcSelectedProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSelectedProducts});
            // 
            // gvSelectedProducts
            // 
            this.gvSelectedProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelectedProductName,
            this.colSelectedPatientPrice,
            this.colSelectedCompanyPrice});
            this.gvSelectedProducts.GridControl = this.gcSelectedProducts;
            this.gvSelectedProducts.Name = "gvSelectedProducts";
            this.gvSelectedProducts.OptionsBehavior.Editable = false;
            this.gvSelectedProducts.OptionsView.ShowGroupPanel = false;
            this.gvSelectedProducts.DoubleClick += new System.EventHandler(this.gvSelectedProducts_DoubleClick);
            // 
            // colSelectedProductName
            // 
            this.colSelectedProductName.Caption = "Açıklama";
            this.colSelectedProductName.FieldName = "NAME1";
            this.colSelectedProductName.Name = "colSelectedProductName";
            this.colSelectedProductName.Visible = true;
            this.colSelectedProductName.VisibleIndex = 0;
            // 
            // colSelectedPatientPrice
            // 
            this.colSelectedPatientPrice.Caption = "Hasta Fiyatı";
            this.colSelectedPatientPrice.FieldName = "PatientPrice";
            this.colSelectedPatientPrice.Name = "colSelectedPatientPrice";
            this.colSelectedPatientPrice.Visible = true;
            this.colSelectedPatientPrice.VisibleIndex = 1;
            // 
            // colSelectedCompanyPrice
            // 
            this.colSelectedCompanyPrice.Caption = "Kurum Fiyatı";
            this.colSelectedCompanyPrice.FieldName = "CompanyPrice";
            this.colSelectedCompanyPrice.Name = "colSelectedCompanyPrice";
            this.colSelectedCompanyPrice.Visible = true;
            this.colSelectedCompanyPrice.VisibleIndex = 2;
            // 
            // gcProducts
            // 
            this.gcProducts.Location = new System.Drawing.Point(386, 28);
            this.gcProducts.MainView = this.gvProducts;
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.Size = new System.Drawing.Size(428, 369);
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
            // 
            // colPatientPrice
            // 
            this.colPatientPrice.Caption = "Hasta Fiyatı";
            this.colPatientPrice.FieldName = "PatientPrice";
            this.colPatientPrice.Name = "colPatientPrice";
            this.colPatientPrice.Visible = true;
            this.colPatientPrice.VisibleIndex = 1;
            // 
            // colCompanyPrice
            // 
            this.colCompanyPrice.Caption = "Kurum Fiyatı";
            this.colCompanyPrice.FieldName = "CompanyPrice";
            this.colCompanyPrice.Name = "colCompanyPrice";
            this.colCompanyPrice.Visible = true;
            this.colCompanyPrice.VisibleIndex = 2;
            // 
            // tlFunctionGroups
            // 
            this.tlFunctionGroups.Location = new System.Drawing.Point(12, 28);
            this.tlFunctionGroups.Name = "tlFunctionGroups";
            this.tlFunctionGroups.OptionsBehavior.Editable = false;
            this.tlFunctionGroups.Size = new System.Drawing.Size(370, 586);
            this.tlFunctionGroups.TabIndex = 8;
            this.tlFunctionGroups.Click += new System.EventHandler(this.tlFunctionGroups_Click);
            // 
            // sbClose
            // 
            this.sbClose.Location = new System.Drawing.Point(818, 370);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(105, 22);
            this.sbClose.StyleController = this.layoutControl1;
            this.sbClose.TabIndex = 7;
            this.sbClose.Text = "Kapat";
            this.sbClose.Click += new System.EventHandler(this.sbClose_Click);
            // 
            // sbSelect
            // 
            this.sbSelect.Location = new System.Drawing.Point(818, 88);
            this.sbSelect.Name = "sbSelect";
            this.sbSelect.Size = new System.Drawing.Size(105, 22);
            this.sbSelect.StyleController = this.layoutControl1;
            this.sbSelect.TabIndex = 6;
            this.sbSelect.Text = "Seçilileri Ekle";
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
            this.lciSelectedProducts});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(935, 626);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbSelect;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(806, 76);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(109, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbClose;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(806, 358);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(109, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(806, 102);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(109, 256);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(806, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(109, 76);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(806, 384);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(109, 222);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciFunctionGroups
            // 
            this.lciFunctionGroups.Control = this.tlFunctionGroups;
            this.lciFunctionGroups.CustomizationFormText = "Hizmetler";
            this.lciFunctionGroups.Location = new System.Drawing.Point(0, 0);
            this.lciFunctionGroups.Name = "lciFunctionGroups";
            this.lciFunctionGroups.Size = new System.Drawing.Size(374, 606);
            this.lciFunctionGroups.Text = "Hizmetler";
            this.lciFunctionGroups.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciFunctionGroups.TextSize = new System.Drawing.Size(63, 13);
            // 
            // lciProducts
            // 
            this.lciProducts.Control = this.gcProducts;
            this.lciProducts.CustomizationFormText = "İşlemler";
            this.lciProducts.Location = new System.Drawing.Point(374, 0);
            this.lciProducts.Name = "lciProducts";
            this.lciProducts.Size = new System.Drawing.Size(432, 389);
            this.lciProducts.Text = "İşlemler";
            this.lciProducts.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciProducts.TextSize = new System.Drawing.Size(63, 13);
            // 
            // lciSelectedProducts
            // 
            this.lciSelectedProducts.Control = this.gcSelectedProducts;
            this.lciSelectedProducts.CustomizationFormText = "Seçili İşlemler";
            this.lciSelectedProducts.Location = new System.Drawing.Point(374, 389);
            this.lciSelectedProducts.Name = "lciSelectedProducts";
            this.lciSelectedProducts.Size = new System.Drawing.Size(432, 217);
            this.lciSelectedProducts.Text = "Seçili İşlemler";
            this.lciSelectedProducts.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciSelectedProducts.TextSize = new System.Drawing.Size(63, 13);
            // 
            // SelectFunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 626);
            this.Controls.Add(this.layoutControl1);
            this.Name = "SelectFunctionForm";
            this.Text = "SGK Poliklinik Seçim Formu";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
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
    }
}