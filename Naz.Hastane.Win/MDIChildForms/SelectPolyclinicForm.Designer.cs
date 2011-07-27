namespace Naz.Hastane.Win.MDIChildForms
{
    partial class SelectPolyclinicForm
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
            this.lblNewInsuranceCompany = new DevExpress.XtraEditors.LabelControl();
            this.ddbChangeInsuranceCompany = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.iSGK = new DevExpress.XtraBars.BarButtonItem();
            this.iSGKAcil = new DevExpress.XtraBars.BarButtonItem();
            this.iNormal = new DevExpress.XtraBars.BarButtonItem();
            this.iOzelHasta = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lblOldInsuranceCompany = new DevExpress.XtraEditors.LabelControl();
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.gcView = new DevExpress.XtraGrid.GridControl();
            this.gvPolyclinics = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colService = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQueueNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbSelect = new DevExpress.XtraEditors.SimpleButton();
            this.ceSameDay = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciSameDay = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPolyclinics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSameDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSameDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lblNewInsuranceCompany);
            this.layoutControl1.Controls.Add(this.ddbChangeInsuranceCompany);
            this.layoutControl1.Controls.Add(this.lblOldInsuranceCompany);
            this.layoutControl1.Controls.Add(this.sbClose);
            this.layoutControl1.Controls.Add(this.gcView);
            this.layoutControl1.Controls.Add(this.sbSelect);
            this.layoutControl1.Controls.Add(this.ceSameDay);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(696, 481);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lblNewInsuranceCompany
            // 
            this.lblNewInsuranceCompany.Location = new System.Drawing.Point(590, 93);
            this.lblNewInsuranceCompany.Name = "lblNewInsuranceCompany";
            this.lblNewInsuranceCompany.Size = new System.Drawing.Size(79, 13);
            this.lblNewInsuranceCompany.StyleController = this.layoutControl1;
            this.lblNewInsuranceCompany.TabIndex = 11;
            this.lblNewInsuranceCompany.Text = "Yeni Kurum: SGK";
            // 
            // ddbChangeInsuranceCompany
            // 
            this.ddbChangeInsuranceCompany.DropDownControl = this.popupMenu1;
            this.ddbChangeInsuranceCompany.Location = new System.Drawing.Point(590, 110);
            this.ddbChangeInsuranceCompany.Name = "ddbChangeInsuranceCompany";
            this.ddbChangeInsuranceCompany.Size = new System.Drawing.Size(94, 22);
            this.ddbChangeInsuranceCompany.StyleController = this.layoutControl1;
            this.ddbChangeInsuranceCompany.TabIndex = 10;
            this.ddbChangeInsuranceCompany.Text = "Kurum Değiştir";
            this.ddbChangeInsuranceCompany.Click += new System.EventHandler(this.ddbChangeInsuranceCompany_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iSGK),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSGKAcil),
            new DevExpress.XtraBars.LinkPersistInfo(this.iNormal),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOzelHasta),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSGK),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSGKAcil),
            new DevExpress.XtraBars.LinkPersistInfo(this.iNormal),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOzelHasta)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // iSGK
            // 
            this.iSGK.Caption = "SGK";
            this.iSGK.Id = 0;
            this.iSGK.Name = "iSGK";
            // 
            // iSGKAcil
            // 
            this.iSGKAcil.Caption = "SGK Acil";
            this.iSGKAcil.Id = 1;
            this.iSGKAcil.Name = "iSGKAcil";
            // 
            // iNormal
            // 
            this.iNormal.Caption = "KRM000 - Normal";
            this.iNormal.Id = 2;
            this.iNormal.Name = "iNormal";
            // 
            // iOzelHasta
            // 
            this.iOzelHasta.Caption = "KRM008 - Özel Hasta";
            this.iOzelHasta.Id = 3;
            this.iOzelHasta.Name = "iOzelHasta";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.iSGK,
            this.iSGKAcil,
            this.iNormal,
            this.iOzelHasta});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(696, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 481);
            this.barDockControlBottom.Size = new System.Drawing.Size(696, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 481);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(696, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 481);
            // 
            // lblOldInsuranceCompany
            // 
            this.lblOldInsuranceCompany.Location = new System.Drawing.Point(590, 35);
            this.lblOldInsuranceCompany.Name = "lblOldInsuranceCompany";
            this.lblOldInsuranceCompany.Size = new System.Drawing.Size(56, 13);
            this.lblOldInsuranceCompany.StyleController = this.layoutControl1;
            this.lblOldInsuranceCompany.TabIndex = 9;
            this.lblOldInsuranceCompany.Text = "Kurum: SGK";
            // 
            // sbClose
            // 
            this.sbClose.Location = new System.Drawing.Point(590, 348);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(94, 22);
            this.sbClose.StyleController = this.layoutControl1;
            this.sbClose.TabIndex = 7;
            this.sbClose.Text = "Kapat";
            this.sbClose.Click += new System.EventHandler(this.sbClose_Click);
            // 
            // gcView
            // 
            this.gcView.Location = new System.Drawing.Point(12, 12);
            this.gcView.MainView = this.gvPolyclinics;
            this.gcView.Name = "gcView";
            this.gcView.Size = new System.Drawing.Size(574, 457);
            this.gcView.TabIndex = 4;
            this.gcView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPolyclinics});
            // 
            // gvPolyclinics
            // 
            this.gvPolyclinics.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colService,
            this.colDoctor,
            this.colQueueNo});
            this.gvPolyclinics.GridControl = this.gcView;
            this.gvPolyclinics.Name = "gvPolyclinics";
            this.gvPolyclinics.OptionsBehavior.Editable = false;
            this.gvPolyclinics.OptionsFind.AlwaysVisible = true;
            this.gvPolyclinics.OptionsView.ShowGroupPanel = false;
            this.gvPolyclinics.DoubleClick += new System.EventHandler(this.gvPolyclinics_DoubleClick);
            // 
            // colService
            // 
            this.colService.Caption = "Servis";
            this.colService.FieldName = "Service.Value";
            this.colService.Name = "colService";
            this.colService.Visible = true;
            this.colService.VisibleIndex = 1;
            this.colService.Width = 140;
            // 
            // colDoctor
            // 
            this.colDoctor.Caption = "Doktor";
            this.colDoctor.FieldName = "Value";
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.Visible = true;
            this.colDoctor.VisibleIndex = 0;
            this.colDoctor.Width = 179;
            // 
            // colQueueNo
            // 
            this.colQueueNo.Caption = "Hasta Sayısı";
            this.colQueueNo.FieldName = "QueueNo";
            this.colQueueNo.Name = "colQueueNo";
            this.colQueueNo.Visible = true;
            this.colQueueNo.VisibleIndex = 2;
            this.colQueueNo.Width = 67;
            // 
            // sbSelect
            // 
            this.sbSelect.Location = new System.Drawing.Point(590, 201);
            this.sbSelect.Name = "sbSelect";
            this.sbSelect.Size = new System.Drawing.Size(94, 22);
            this.sbSelect.StyleController = this.layoutControl1;
            this.sbSelect.TabIndex = 6;
            this.sbSelect.Text = "Seç";
            this.sbSelect.Click += new System.EventHandler(this.sbSelect_Click);
            // 
            // ceSameDay
            // 
            this.ceSameDay.Location = new System.Drawing.Point(590, 12);
            this.ceSameDay.Name = "ceSameDay";
            this.ceSameDay.Properties.Caption = "İkinci Muayene";
            this.ceSameDay.Size = new System.Drawing.Size(94, 19);
            this.ceSameDay.StyleController = this.layoutControl1;
            this.ceSameDay.TabIndex = 8;
            this.ceSameDay.Visible = false;
            this.ceSameDay.CheckedChanged += new System.EventHandler(this.ceSameDay_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.lciSameDay,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(696, 481);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcView;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(578, 461);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbSelect;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(578, 189);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(98, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbClose;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(578, 336);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(98, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(578, 215);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(98, 121);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(578, 40);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(98, 41);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(578, 362);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(98, 99);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciSameDay
            // 
            this.lciSameDay.Control = this.ceSameDay;
            this.lciSameDay.CustomizationFormText = "İkinci Muayene";
            this.lciSameDay.Location = new System.Drawing.Point(578, 0);
            this.lciSameDay.Name = "lciSameDay";
            this.lciSameDay.Size = new System.Drawing.Size(98, 23);
            this.lciSameDay.Text = "İkinci Muayene";
            this.lciSameDay.TextSize = new System.Drawing.Size(0, 0);
            this.lciSameDay.TextToControlDistance = 0;
            this.lciSameDay.TextVisible = false;
            this.lciSameDay.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lblOldInsuranceCompany;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(578, 23);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(98, 17);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ddbChangeInsuranceCompany;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(578, 98);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(98, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lblNewInsuranceCompany;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(578, 81);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(98, 17);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(578, 124);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(98, 65);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // SelectPolyclinicForm
            // 
            this.AcceptButton = this.sbSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 481);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SelectPolyclinicForm";
            this.Text = "Poliklinik Seçim Formu";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPolyclinics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSameDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSameDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton sbClose;
        private DevExpress.XtraEditors.SimpleButton sbSelect;
        private DevExpress.XtraGrid.GridControl gcView;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPolyclinics;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        public DevExpress.XtraGrid.Columns.GridColumn colDoctor;
        public DevExpress.XtraGrid.Columns.GridColumn colService;
        private DevExpress.XtraGrid.Columns.GridColumn colQueueNo;
        private DevExpress.XtraEditors.CheckEdit ceSameDay;
        private DevExpress.XtraLayout.LayoutControlItem lciSameDay;
        private DevExpress.XtraEditors.LabelControl lblOldInsuranceCompany;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem iSGK;
        private DevExpress.XtraBars.BarButtonItem iSGKAcil;
        private DevExpress.XtraBars.BarButtonItem iNormal;
        private DevExpress.XtraBars.BarButtonItem iOzelHasta;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraEditors.LabelControl lblNewInsuranceCompany;
        private DevExpress.XtraEditors.DropDownButton ddbChangeInsuranceCompany;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
    }
}