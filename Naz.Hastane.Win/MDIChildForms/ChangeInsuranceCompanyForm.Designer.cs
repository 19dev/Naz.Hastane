namespace Naz.Hastane.Win.MDIChildForms
{
    partial class ChangeInsuranceCompanyForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceSelectAll = new DevExpress.XtraEditors.CheckEdit();
            this.gcPatientVisits = new DevExpress.XtraGrid.GridControl();
            this.gvPatientVisits = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVisitNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExitDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatientTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.gcPatientVisitDetails = new DevExpress.XtraGrid.GridControl();
            this.gvPatientVisitDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPatientVisitDetailVisitNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailPatientTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciClose = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSave = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceSelectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientVisitDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisitDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ceSelectAll);
            this.layoutControl1.Controls.Add(this.gcPatientVisits);
            this.layoutControl1.Controls.Add(this.sbClose);
            this.layoutControl1.Controls.Add(this.gcPatientVisitDetails);
            this.layoutControl1.Controls.Add(this.sbSave);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1672, -141, 387, 543);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(683, 575);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceSelectAll
            // 
            this.ceSelectAll.Location = new System.Drawing.Point(6, 550);
            this.ceSelectAll.Name = "ceSelectAll";
            this.ceSelectAll.Properties.Caption = "Hepsini Seç";
            this.ceSelectAll.Size = new System.Drawing.Size(77, 19);
            this.ceSelectAll.StyleController = this.layoutControl1;
            this.ceSelectAll.TabIndex = 30;
            // 
            // gcPatientVisits
            // 
            this.gcPatientVisits.Location = new System.Drawing.Point(6, 22);
            this.gcPatientVisits.MainView = this.gvPatientVisits;
            this.gcPatientVisits.Name = "gcPatientVisits";
            this.gcPatientVisits.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gcPatientVisits.Size = new System.Drawing.Size(571, 251);
            this.gcPatientVisits.TabIndex = 4;
            this.gcPatientVisits.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatientVisits});
            // 
            // gvPatientVisits
            // 
            this.gvPatientVisits.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVisitNo,
            this.colDate,
            this.colExitDate,
            this.colPatientTotal});
            this.gvPatientVisits.GridControl = this.gcPatientVisits;
            this.gvPatientVisits.Name = "gvPatientVisits";
            this.gvPatientVisits.OptionsView.ShowGroupPanel = false;
            // 
            // colVisitNo
            // 
            this.colVisitNo.Caption = "Kart No";
            this.colVisitNo.FieldName = "VisitNo";
            this.colVisitNo.Name = "colVisitNo";
            this.colVisitNo.OptionsColumn.AllowEdit = false;
            this.colVisitNo.Visible = true;
            this.colVisitNo.VisibleIndex = 0;
            // 
            // colDate
            // 
            this.colDate.Caption = "İşlem Tarihi";
            this.colDate.FieldName = "VisitDate";
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.AllowEdit = false;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            // 
            // colExitDate
            // 
            this.colExitDate.Caption = "Çıkış Tarihi";
            this.colExitDate.FieldName = "ExitDate";
            this.colExitDate.Name = "colExitDate";
            this.colExitDate.OptionsColumn.AllowEdit = false;
            this.colExitDate.Visible = true;
            this.colExitDate.VisibleIndex = 2;
            // 
            // colPatientTotal
            // 
            this.colPatientTotal.Caption = "Hasta Tutarı";
            this.colPatientTotal.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.colPatientTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPatientTotal.FieldName = "PatientTotal";
            this.colPatientTotal.Name = "colPatientTotal";
            this.colPatientTotal.OptionsColumn.AllowEdit = false;
            this.colPatientTotal.Visible = true;
            this.colPatientTotal.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // sbClose
            // 
            this.sbClose.Location = new System.Drawing.Point(581, 524);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(96, 22);
            this.sbClose.StyleController = this.layoutControl1;
            this.sbClose.TabIndex = 8;
            this.sbClose.Text = "Kapat";
            this.sbClose.Click += new System.EventHandler(this.sbClose_Click);
            // 
            // gcPatientVisitDetails
            // 
            this.gcPatientVisitDetails.Location = new System.Drawing.Point(6, 293);
            this.gcPatientVisitDetails.MainView = this.gvPatientVisitDetails;
            this.gcPatientVisitDetails.Name = "gcPatientVisitDetails";
            this.gcPatientVisitDetails.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcPatientVisitDetails.Size = new System.Drawing.Size(571, 253);
            this.gcPatientVisitDetails.TabIndex = 9;
            this.gcPatientVisitDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatientVisitDetails});
            // 
            // gvPatientVisitDetails
            // 
            this.gvPatientVisitDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPatientVisitDetailVisitNo,
            this.colDetailNo,
            this.colDetailDate,
            this.colDetailComment,
            this.colDetailCount,
            this.colDetailPatientTotal});
            this.gvPatientVisitDetails.GridControl = this.gcPatientVisitDetails;
            this.gvPatientVisitDetails.Name = "gvPatientVisitDetails";
            this.gvPatientVisitDetails.OptionsView.ShowGroupPanel = false;
            // 
            // colPatientVisitDetailVisitNo
            // 
            this.colPatientVisitDetailVisitNo.Caption = "Kart No";
            this.colPatientVisitDetailVisitNo.FieldName = "PatientVisit.VisitNo";
            this.colPatientVisitDetailVisitNo.Name = "colPatientVisitDetailVisitNo";
            this.colPatientVisitDetailVisitNo.Visible = true;
            this.colPatientVisitDetailVisitNo.VisibleIndex = 0;
            // 
            // colDetailNo
            // 
            this.colDetailNo.Caption = "İşlem No";
            this.colDetailNo.FieldName = "DetailNo";
            this.colDetailNo.Name = "colDetailNo";
            this.colDetailNo.OptionsColumn.AllowEdit = false;
            this.colDetailNo.Visible = true;
            this.colDetailNo.VisibleIndex = 1;
            // 
            // colDetailDate
            // 
            this.colDetailDate.Caption = "İşlem Tarihi";
            this.colDetailDate.FieldName = "TARIH";
            this.colDetailDate.Name = "colDetailDate";
            this.colDetailDate.OptionsColumn.AllowEdit = false;
            this.colDetailDate.Visible = true;
            this.colDetailDate.VisibleIndex = 2;
            // 
            // colDetailComment
            // 
            this.colDetailComment.Caption = "Açıklama";
            this.colDetailComment.FieldName = "NAME1";
            this.colDetailComment.Name = "colDetailComment";
            this.colDetailComment.OptionsColumn.AllowEdit = false;
            this.colDetailComment.Visible = true;
            this.colDetailComment.VisibleIndex = 3;
            // 
            // colDetailCount
            // 
            this.colDetailCount.Caption = "Adet";
            this.colDetailCount.FieldName = "ADET";
            this.colDetailCount.Name = "colDetailCount";
            this.colDetailCount.OptionsColumn.AllowEdit = false;
            this.colDetailCount.Visible = true;
            this.colDetailCount.VisibleIndex = 4;
            // 
            // colDetailPatientTotal
            // 
            this.colDetailPatientTotal.Caption = "Hasta Tutarı";
            this.colDetailPatientTotal.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.colDetailPatientTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetailPatientTotal.FieldName = "SATISF";
            this.colDetailPatientTotal.Name = "colDetailPatientTotal";
            this.colDetailPatientTotal.OptionsColumn.AllowEdit = false;
            this.colDetailPatientTotal.Visible = true;
            this.colDetailPatientTotal.VisibleIndex = 5;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // sbSave
            // 
            this.sbSave.Location = new System.Drawing.Point(581, 6);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(96, 22);
            this.sbSave.StyleController = this.layoutControl1;
            this.sbSave.TabIndex = 31;
            this.sbSave.Text = "Kaydet";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.layoutControlItem12,
            this.emptySpaceItem8,
            this.emptySpaceItem9,
            this.lciClose,
            this.lciSave});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup1.Size = new System.Drawing.Size(683, 575);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcPatientVisits;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(575, 271);
            this.layoutControlItem1.Text = "Kartlar";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(37, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gcPatientVisitDetails;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 271);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(575, 273);
            this.layoutControlItem6.Text = "İşlemler";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(37, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.ceSelectAll;
            this.layoutControlItem12.CustomizationFormText = "layoutControlItem12";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 544);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(81, 23);
            this.layoutControlItem12.Text = "layoutControlItem12";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextToControlDistance = 0;
            this.layoutControlItem12.TextVisible = false;
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.CustomizationFormText = "emptySpaceItem8";
            this.emptySpaceItem8.Location = new System.Drawing.Point(81, 544);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(594, 23);
            this.emptySpaceItem8.Text = "emptySpaceItem8";
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.CustomizationFormText = "emptySpaceItem9";
            this.emptySpaceItem9.Location = new System.Drawing.Point(575, 26);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(100, 492);
            this.emptySpaceItem9.Text = "emptySpaceItem9";
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciClose
            // 
            this.lciClose.Control = this.sbClose;
            this.lciClose.CustomizationFormText = "Kapat";
            this.lciClose.Location = new System.Drawing.Point(575, 518);
            this.lciClose.Name = "lciClose";
            this.lciClose.Size = new System.Drawing.Size(100, 26);
            this.lciClose.Text = "Kapat";
            this.lciClose.TextSize = new System.Drawing.Size(0, 0);
            this.lciClose.TextToControlDistance = 0;
            this.lciClose.TextVisible = false;
            // 
            // lciSave
            // 
            this.lciSave.Control = this.sbSave;
            this.lciSave.CustomizationFormText = "Kaydet";
            this.lciSave.Location = new System.Drawing.Point(575, 0);
            this.lciSave.Name = "lciSave";
            this.lciSave.Size = new System.Drawing.Size(100, 26);
            this.lciSave.Text = "Kaydet";
            this.lciSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciSave.TextToControlDistance = 0;
            this.lciSave.TextVisible = false;
            // 
            // ChangeInsuranceCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 575);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ChangeInsuranceCompanyForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceSelectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientVisitDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisitDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcPatientVisits;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPatientVisits;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton sbClose;
        private DevExpress.XtraLayout.LayoutControlItem lciClose;
        private DevExpress.XtraGrid.GridControl gcPatientVisitDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPatientVisitDetails;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailComment;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailCount;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailPatientTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExitDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.CheckEdit ceSelectAll;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientVisitDetailVisitNo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraEditors.SimpleButton sbSave;
        private DevExpress.XtraLayout.LayoutControlItem lciSave;
    }
}
