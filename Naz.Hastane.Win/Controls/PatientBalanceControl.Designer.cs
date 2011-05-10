namespace Naz.Hastane.Win.Controls
{
    partial class PatientBalanceControl
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
            this.gcPatientBalance = new DevExpress.XtraGrid.GridControl();
            this.gvPatientBalance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRowNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlacak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.teBorcBakiyesi = new DevExpress.XtraEditors.TextEdit();
            this.sbRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPatientVisitControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRefresh = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciBorcBakiyesi = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teBorcBakiyesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientVisitControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBorcBakiyesi)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPatientBalance
            // 
            this.gcPatientBalance.DataMember = null;
            this.gcPatientBalance.Location = new System.Drawing.Point(4, 4);
            this.gcPatientBalance.MainView = this.gvPatientBalance;
            this.gcPatientBalance.Name = "gcPatientBalance";
            this.gcPatientBalance.Size = new System.Drawing.Size(667, 497);
            this.gcPatientBalance.TabIndex = 24;
            this.gcPatientBalance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatientBalance});
            // 
            // gvPatientBalance
            // 
            this.gvPatientBalance.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRowNumber,
            this.colDate,
            this.colType,
            this.colBorc,
            this.colAlacak});
            this.gvPatientBalance.GridControl = this.gcPatientBalance;
            this.gvPatientBalance.Name = "gvPatientBalance";
            this.gvPatientBalance.OptionsBehavior.Editable = false;
            this.gvPatientBalance.OptionsBehavior.ReadOnly = true;
            this.gvPatientBalance.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPatientBalance.OptionsView.EnableAppearanceOddRow = true;
            this.gvPatientBalance.OptionsView.ShowFooter = true;
            this.gvPatientBalance.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRowNumber, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colRowNumber
            // 
            this.colRowNumber.Caption = "Sıra No";
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
            // colType
            // 
            this.colType.Caption = "Tip";
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            // 
            // colBorc
            // 
            this.colBorc.Caption = "Borç";
            this.colBorc.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.colBorc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBorc.FieldName = "Borc";
            this.colBorc.Name = "colBorc";
            this.colBorc.SummaryItem.DisplayFormat = "{0:#,##0.00}";
            this.colBorc.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colBorc.Visible = true;
            this.colBorc.VisibleIndex = 3;
            // 
            // colAlacak
            // 
            this.colAlacak.Caption = "Alacak";
            this.colAlacak.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.colAlacak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlacak.FieldName = "Alacak";
            this.colAlacak.Name = "colAlacak";
            this.colAlacak.SummaryItem.DisplayFormat = "{0:#,##0.00}";
            this.colAlacak.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAlacak.Visible = true;
            this.colAlacak.VisibleIndex = 4;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.teBorcBakiyesi);
            this.layoutControl1.Controls.Add(this.sbRefresh);
            this.layoutControl1.Controls.Add(this.gcPatientBalance);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(757, 505);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // teBorcBakiyesi
            // 
            this.teBorcBakiyesi.Enabled = false;
            this.teBorcBakiyesi.Location = new System.Drawing.Point(675, 481);
            this.teBorcBakiyesi.Name = "teBorcBakiyesi";
            this.teBorcBakiyesi.Properties.DisplayFormat.FormatString = "#,##0.00";
            this.teBorcBakiyesi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teBorcBakiyesi.Size = new System.Drawing.Size(78, 20);
            this.teBorcBakiyesi.StyleController = this.layoutControl1;
            this.teBorcBakiyesi.TabIndex = 26;
            // 
            // sbRefresh
            // 
            this.sbRefresh.Location = new System.Drawing.Point(675, 45);
            this.sbRefresh.Name = "sbRefresh";
            this.sbRefresh.Size = new System.Drawing.Size(78, 22);
            this.sbRefresh.StyleController = this.layoutControl1;
            this.sbRefresh.TabIndex = 25;
            this.sbRefresh.Text = "Yenile";
            this.sbRefresh.Click += new System.EventHandler(this.sbRefresh_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPatientVisitControl,
            this.lciRefresh,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.lciBorcBakiyesi});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(757, 505);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciPatientVisitControl
            // 
            this.lciPatientVisitControl.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lciPatientVisitControl.AppearanceItemCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lciPatientVisitControl.AppearanceItemCaption.Options.UseBackColor = true;
            this.lciPatientVisitControl.Control = this.gcPatientBalance;
            this.lciPatientVisitControl.CustomizationFormText = "layoutControlItem1";
            this.lciPatientVisitControl.Location = new System.Drawing.Point(0, 0);
            this.lciPatientVisitControl.Name = "lciPatientVisitControl";
            this.lciPatientVisitControl.Size = new System.Drawing.Size(671, 501);
            this.lciPatientVisitControl.Text = "Ziyaretler";
            this.lciPatientVisitControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciPatientVisitControl.TextSize = new System.Drawing.Size(0, 0);
            this.lciPatientVisitControl.TextToControlDistance = 0;
            this.lciPatientVisitControl.TextVisible = false;
            // 
            // lciRefresh
            // 
            this.lciRefresh.Control = this.sbRefresh;
            this.lciRefresh.CustomizationFormText = "Yenile";
            this.lciRefresh.Location = new System.Drawing.Point(671, 41);
            this.lciRefresh.Name = "lciRefresh";
            this.lciRefresh.Size = new System.Drawing.Size(82, 26);
            this.lciRefresh.Text = "Yenile";
            this.lciRefresh.TextSize = new System.Drawing.Size(0, 0);
            this.lciRefresh.TextToControlDistance = 0;
            this.lciRefresh.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(671, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(82, 41);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(671, 67);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(82, 394);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciBorcBakiyesi
            // 
            this.lciBorcBakiyesi.Control = this.teBorcBakiyesi;
            this.lciBorcBakiyesi.CustomizationFormText = "Borç Bakiyesi";
            this.lciBorcBakiyesi.Location = new System.Drawing.Point(671, 461);
            this.lciBorcBakiyesi.Name = "lciBorcBakiyesi";
            this.lciBorcBakiyesi.Size = new System.Drawing.Size(82, 40);
            this.lciBorcBakiyesi.Text = "Borç Bakiyesi";
            this.lciBorcBakiyesi.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciBorcBakiyesi.TextSize = new System.Drawing.Size(62, 13);
            // 
            // PatientBalanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "PatientBalanceControl";
            this.Size = new System.Drawing.Size(757, 505);
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teBorcBakiyesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientVisitControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBorcBakiyesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciPatientVisitControl;
        public DevExpress.XtraGrid.GridControl gcPatientBalance;
        public DevExpress.XtraGrid.Views.Grid.GridView gvPatientBalance;
        private DevExpress.XtraGrid.Columns.GridColumn colRowNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colBorc;
        private DevExpress.XtraGrid.Columns.GridColumn colAlacak;
        private DevExpress.XtraEditors.SimpleButton sbRefresh;
        private DevExpress.XtraLayout.LayoutControlItem lciRefresh;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.TextEdit teBorcBakiyesi;
        private DevExpress.XtraLayout.LayoutControlItem lciBorcBakiyesi;
    }
}
