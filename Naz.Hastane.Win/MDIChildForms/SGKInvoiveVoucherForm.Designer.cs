namespace Naz.Hastane.Win.MDIChildForms
{
    partial class SGKInvoiveVoucherForm
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
            this.gcPatients = new DevExpress.XtraGrid.GridControl();
            this.gvPatients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPatientNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPatientVisitDetails = new DevExpress.XtraGrid.GridControl();
            this.gvPatientVisitDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDetailNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailPatientTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gcPatientVisits = new DevExpress.XtraGrid.GridControl();
            this.gvPatientVisits = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVisitNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExitDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatientTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientVisitDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisitDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcPatients);
            this.layoutControl1.Controls.Add(this.gcPatientVisitDetails);
            this.layoutControl1.Controls.Add(this.sbRefresh);
            this.layoutControl1.Controls.Add(this.simpleButton3);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.gcPatientVisits);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1672, -141, 387, 543);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(965, 685);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcPatients
            // 
            this.gcPatients.Location = new System.Drawing.Point(12, 28);
            this.gcPatients.MainView = this.gvPatients;
            this.gcPatients.Name = "gcPatients";
            this.gcPatients.Size = new System.Drawing.Size(307, 296);
            this.gcPatients.TabIndex = 10;
            this.gcPatients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatients});
            // 
            // gvPatients
            // 
            this.gvPatients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPatientNo,
            this.colFirstName,
            this.colLastName});
            this.gvPatients.GridControl = this.gcPatients;
            this.gvPatients.Name = "gvPatients";
            this.gvPatients.OptionsBehavior.Editable = false;
            this.gvPatients.OptionsView.ShowGroupPanel = false;
            this.gvPatients.Click += new System.EventHandler(this.gvPatients_Click);
            // 
            // colPatientNo
            // 
            this.colPatientNo.Caption = "Protokol";
            this.colPatientNo.FieldName = "PatientNo";
            this.colPatientNo.Name = "colPatientNo";
            this.colPatientNo.Visible = true;
            this.colPatientNo.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Hasta Adı";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Hasta Soyadı";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // gcPatientVisitDetails
            // 
            this.gcPatientVisitDetails.Location = new System.Drawing.Point(12, 344);
            this.gcPatientVisitDetails.MainView = this.gvPatientVisitDetails;
            this.gcPatientVisitDetails.Name = "gcPatientVisitDetails";
            this.gcPatientVisitDetails.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcPatientVisitDetails.Size = new System.Drawing.Size(786, 329);
            this.gcPatientVisitDetails.TabIndex = 9;
            this.gcPatientVisitDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatientVisitDetails});
            // 
            // gvPatientVisitDetails
            // 
            this.gvPatientVisitDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelect,
            this.colDetailNo,
            this.colDetailDate,
            this.colDetailComment,
            this.colDetailCount,
            this.colDetailPatientTotal});
            this.gvPatientVisitDetails.GridControl = this.gcPatientVisitDetails;
            this.gvPatientVisitDetails.Name = "gvPatientVisitDetails";
            this.gvPatientVisitDetails.OptionsView.ShowGroupPanel = false;
            // 
            // colSelect
            // 
            this.colSelect.Caption = "Seç";
            this.colSelect.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colSelect.Name = "colSelect";
            this.colSelect.OptionsColumn.AllowEdit = false;
            this.colSelect.Visible = true;
            this.colSelect.VisibleIndex = 5;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colDetailNo
            // 
            this.colDetailNo.Caption = "Kart No";
            this.colDetailNo.FieldName = "DetailNo";
            this.colDetailNo.Name = "colDetailNo";
            this.colDetailNo.OptionsColumn.AllowEdit = false;
            this.colDetailNo.Visible = true;
            this.colDetailNo.VisibleIndex = 0;
            // 
            // colDetailDate
            // 
            this.colDetailDate.Caption = "İşlem Tarihi";
            this.colDetailDate.FieldName = "TARIH";
            this.colDetailDate.Name = "colDetailDate";
            this.colDetailDate.OptionsColumn.AllowEdit = false;
            this.colDetailDate.Visible = true;
            this.colDetailDate.VisibleIndex = 1;
            // 
            // colDetailComment
            // 
            this.colDetailComment.Caption = "Açıklama";
            this.colDetailComment.FieldName = "NAME1";
            this.colDetailComment.Name = "colDetailComment";
            this.colDetailComment.OptionsColumn.AllowEdit = false;
            this.colDetailComment.Visible = true;
            this.colDetailComment.VisibleIndex = 2;
            // 
            // colDetailCount
            // 
            this.colDetailCount.Caption = "Adet";
            this.colDetailCount.FieldName = "ADET";
            this.colDetailCount.Name = "colDetailCount";
            this.colDetailCount.OptionsColumn.AllowEdit = false;
            this.colDetailCount.Visible = true;
            this.colDetailCount.VisibleIndex = 3;
            // 
            // colDetailPatientTotal
            // 
            this.colDetailPatientTotal.Caption = "Hasta Tutarı";
            this.colDetailPatientTotal.FieldName = "SATISF";
            this.colDetailPatientTotal.Name = "colDetailPatientTotal";
            this.colDetailPatientTotal.OptionsColumn.AllowEdit = false;
            this.colDetailPatientTotal.Visible = true;
            this.colDetailPatientTotal.VisibleIndex = 4;
            // 
            // sbRefresh
            // 
            this.sbRefresh.Location = new System.Drawing.Point(802, 288);
            this.sbRefresh.Name = "sbRefresh";
            this.sbRefresh.Size = new System.Drawing.Size(151, 22);
            this.sbRefresh.StyleController = this.layoutControl1;
            this.sbRefresh.TabIndex = 8;
            this.sbRefresh.Text = "Yenile";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(802, 461);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(151, 22);
            this.simpleButton3.StyleController = this.layoutControl1;
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "Kapat";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(802, 122);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(151, 22);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Fatura";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(802, 96);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(151, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Makbuz";
            // 
            // gcPatientVisits
            // 
            this.gcPatientVisits.Location = new System.Drawing.Point(323, 28);
            this.gcPatientVisits.MainView = this.gvPatientVisits;
            this.gcPatientVisits.Name = "gcPatientVisits";
            this.gcPatientVisits.Size = new System.Drawing.Size(475, 296);
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
            this.gvPatientVisits.OptionsBehavior.Editable = false;
            this.gvPatientVisits.OptionsView.ShowGroupPanel = false;
            this.gvPatientVisits.Click += new System.EventHandler(this.gvPatientVisits_Click);
            // 
            // colVisitNo
            // 
            this.colVisitNo.Caption = "Kart No";
            this.colVisitNo.FieldName = "VisitNo";
            this.colVisitNo.Name = "colVisitNo";
            this.colVisitNo.Visible = true;
            this.colVisitNo.VisibleIndex = 0;
            // 
            // colDate
            // 
            this.colDate.Caption = "İşlem Tarihi";
            this.colDate.FieldName = "VisitDate";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            // 
            // colExitDate
            // 
            this.colExitDate.Caption = "Çıkış Tarihi";
            this.colExitDate.FieldName = "ExitDate";
            this.colExitDate.Name = "colExitDate";
            this.colExitDate.Visible = true;
            this.colExitDate.VisibleIndex = 2;
            // 
            // colPatientTotal
            // 
            this.colPatientTotal.Caption = "Hasta Tutarı";
            this.colPatientTotal.FieldName = "PatientTotal";
            this.colPatientTotal.Name = "colPatientTotal";
            this.colPatientTotal.Visible = true;
            this.colPatientTotal.VisibleIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem5,
            this.emptySpaceItem4,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(965, 685);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcPatientVisits;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(311, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(479, 316);
            this.layoutControlItem1.Text = "Kartlar";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(40, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(790, 84);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(155, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton2;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(790, 110);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(155, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton3;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(790, 449);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(155, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(790, 136);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(155, 140);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(790, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(155, 84);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(790, 475);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(155, 190);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbRefresh;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(790, 276);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(155, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(790, 302);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(155, 147);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gcPatientVisitDetails;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 316);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(790, 349);
            this.layoutControlItem6.Text = "İşlemler";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(40, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gcPatients;
            this.layoutControlItem7.CustomizationFormText = "Hastalar";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(311, 316);
            this.layoutControlItem7.Text = "Hastalar";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(40, 13);
            // 
            // SGKInvoiveVoucherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 685);
            this.Controls.Add(this.layoutControl1);
            this.Name = "SGKInvoiveVoucherForm";
            this.Text = "SGK Fatura/Makbuz Formu";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientVisitDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisitDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gcPatientVisits;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPatientVisits;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SimpleButton sbRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
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
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.GridControl gcPatients;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPatients;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
    }
}