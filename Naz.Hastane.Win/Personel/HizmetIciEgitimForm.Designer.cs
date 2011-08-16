namespace Naz.Hastane.Win.MDIChildForms
{
    partial class HizmetIciEgitimForm
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
            this.sbChangePersonel = new DevExpress.XtraEditors.SimpleButton();
            this.sbAddPersonel = new DevExpress.XtraEditors.SimpleButton();
            this.sbDeletePersonel = new DevExpress.XtraEditors.SimpleButton();
            this.sbChangeHizmetIciEgitim = new DevExpress.XtraEditors.SimpleButton();
            this.sbAddHizmetIciEgitim = new DevExpress.XtraEditors.SimpleButton();
            this.sbDeleteHizmetIciEgitim = new DevExpress.XtraEditors.SimpleButton();
            this.gcPersonel = new DevExpress.XtraGrid.GridControl();
            this.gvPersonel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcHizmetIciEgitim = new DevExpress.XtraGrid.GridControl();
            this.gvHizmetIciEgitim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciHizmetIciEgitim = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPersonel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDeleteHizmetIciEgitim = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAddHizmetIciEgitim = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciChangeHizmetIciEgitim = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDeletePersonel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAddPersonel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciChangePersonel = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHizmetIciEgitim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHizmetIciEgitim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHizmetIciEgitim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDeleteHizmetIciEgitim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddHizmetIciEgitim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChangeHizmetIciEgitim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDeletePersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChangePersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbChangePersonel);
            this.layoutControl1.Controls.Add(this.sbAddPersonel);
            this.layoutControl1.Controls.Add(this.sbDeletePersonel);
            this.layoutControl1.Controls.Add(this.sbChangeHizmetIciEgitim);
            this.layoutControl1.Controls.Add(this.sbAddHizmetIciEgitim);
            this.layoutControl1.Controls.Add(this.sbDeleteHizmetIciEgitim);
            this.layoutControl1.Controls.Add(this.gcPersonel);
            this.layoutControl1.Controls.Add(this.gcHizmetIciEgitim);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(882, 472);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbChangePersonel
            // 
            this.sbChangePersonel.Location = new System.Drawing.Point(792, 38);
            this.sbChangePersonel.Name = "sbChangePersonel";
            this.sbChangePersonel.Size = new System.Drawing.Size(78, 22);
            this.sbChangePersonel.StyleController = this.layoutControl1;
            this.sbChangePersonel.TabIndex = 11;
            this.sbChangePersonel.Text = "Değiştir";
            this.sbChangePersonel.Click += new System.EventHandler(this.sbChangePersonel_Click);
            // 
            // sbAddPersonel
            // 
            this.sbAddPersonel.Location = new System.Drawing.Point(792, 12);
            this.sbAddPersonel.Name = "sbAddPersonel";
            this.sbAddPersonel.Size = new System.Drawing.Size(78, 22);
            this.sbAddPersonel.StyleController = this.layoutControl1;
            this.sbAddPersonel.TabIndex = 10;
            this.sbAddPersonel.Text = "Ekle";
            this.sbAddPersonel.Click += new System.EventHandler(this.sbAddPersonel_Click);
            // 
            // sbDeletePersonel
            // 
            this.sbDeletePersonel.Location = new System.Drawing.Point(792, 64);
            this.sbDeletePersonel.Name = "sbDeletePersonel";
            this.sbDeletePersonel.Size = new System.Drawing.Size(78, 22);
            this.sbDeletePersonel.StyleController = this.layoutControl1;
            this.sbDeletePersonel.TabIndex = 9;
            this.sbDeletePersonel.Text = "Sil";
            this.sbDeletePersonel.Click += new System.EventHandler(this.sbDeletePersonel_Click);
            // 
            // sbChangeHizmetIciEgitim
            // 
            this.sbChangeHizmetIciEgitim.Location = new System.Drawing.Point(12, 38);
            this.sbChangeHizmetIciEgitim.Name = "sbChangeHizmetIciEgitim";
            this.sbChangeHizmetIciEgitim.Size = new System.Drawing.Size(89, 22);
            this.sbChangeHizmetIciEgitim.StyleController = this.layoutControl1;
            this.sbChangeHizmetIciEgitim.TabIndex = 8;
            this.sbChangeHizmetIciEgitim.Text = "Değiştir";
            this.sbChangeHizmetIciEgitim.Click += new System.EventHandler(this.sbChangeHizmetIciEgitim_Click);
            // 
            // sbAddHizmetIciEgitim
            // 
            this.sbAddHizmetIciEgitim.Location = new System.Drawing.Point(12, 12);
            this.sbAddHizmetIciEgitim.Name = "sbAddHizmetIciEgitim";
            this.sbAddHizmetIciEgitim.Size = new System.Drawing.Size(89, 22);
            this.sbAddHizmetIciEgitim.StyleController = this.layoutControl1;
            this.sbAddHizmetIciEgitim.TabIndex = 7;
            this.sbAddHizmetIciEgitim.Text = "Ekle";
            this.sbAddHizmetIciEgitim.Click += new System.EventHandler(this.sbAddHizmetIciEgitim_Click);
            // 
            // sbDeleteHizmetIciEgitim
            // 
            this.sbDeleteHizmetIciEgitim.Location = new System.Drawing.Point(12, 64);
            this.sbDeleteHizmetIciEgitim.Name = "sbDeleteHizmetIciEgitim";
            this.sbDeleteHizmetIciEgitim.Size = new System.Drawing.Size(89, 22);
            this.sbDeleteHizmetIciEgitim.StyleController = this.layoutControl1;
            this.sbDeleteHizmetIciEgitim.TabIndex = 6;
            this.sbDeleteHizmetIciEgitim.Text = "Sil";
            this.sbDeleteHizmetIciEgitim.Click += new System.EventHandler(this.sbDeleteHizmetIciEgitim_Click);
            // 
            // gcPersonel
            // 
            this.gcPersonel.Location = new System.Drawing.Point(449, 28);
            this.gcPersonel.MainView = this.gvPersonel;
            this.gcPersonel.Name = "gcPersonel";
            this.gcPersonel.Size = new System.Drawing.Size(339, 432);
            this.gcPersonel.TabIndex = 5;
            this.gcPersonel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPersonel});
            // 
            // gvPersonel
            // 
            this.gvPersonel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6});
            this.gvPersonel.GridControl = this.gcPersonel;
            this.gvPersonel.Name = "gvPersonel";
            this.gvPersonel.OptionsBehavior.Editable = false;
            this.gvPersonel.OptionsView.ShowGroupPanel = false;
            this.gvPersonel.DoubleClick += new System.EventHandler(this.gvPersonel_DoubleClick);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Personel";
            this.gridColumn5.FieldName = "Personel.FullName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Açıklama";
            this.gridColumn6.FieldName = "Aciklama";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gcHizmetIciEgitim
            // 
            this.gcHizmetIciEgitim.Location = new System.Drawing.Point(105, 28);
            this.gcHizmetIciEgitim.MainView = this.gvHizmetIciEgitim;
            this.gcHizmetIciEgitim.Name = "gcHizmetIciEgitim";
            this.gcHizmetIciEgitim.Size = new System.Drawing.Size(340, 432);
            this.gcHizmetIciEgitim.TabIndex = 4;
            this.gcHizmetIciEgitim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHizmetIciEgitim});
            // 
            // gvHizmetIciEgitim
            // 
            this.gvHizmetIciEgitim.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvHizmetIciEgitim.GridControl = this.gcHizmetIciEgitim;
            this.gvHizmetIciEgitim.Name = "gvHizmetIciEgitim";
            this.gvHizmetIciEgitim.OptionsBehavior.Editable = false;
            this.gvHizmetIciEgitim.OptionsView.ShowGroupPanel = false;
            this.gvHizmetIciEgitim.Click += new System.EventHandler(this.gvHizmetIciEgitim_Click);
            this.gvHizmetIciEgitim.DoubleClick += new System.EventHandler(this.gvHizmetIciEgitim_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Eğitim Tipi";
            this.gridColumn1.FieldName = "HizmetIciEgitimTipi.Value";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Başlangıç Tarihi";
            this.gridColumn2.FieldName = "BaslangicTarihi";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Bitiş Tarihi";
            this.gridColumn3.FieldName = "BitisTarihi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Açıklama";
            this.gridColumn4.FieldName = "Aciklama";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciHizmetIciEgitim,
            this.lciPersonel,
            this.lciDeleteHizmetIciEgitim,
            this.lciAddHizmetIciEgitim,
            this.lciChangeHizmetIciEgitim,
            this.lciDeletePersonel,
            this.lciAddPersonel,
            this.lciChangePersonel});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(882, 472);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciHizmetIciEgitim
            // 
            this.lciHizmetIciEgitim.Control = this.gcHizmetIciEgitim;
            this.lciHizmetIciEgitim.CustomizationFormText = "Eğitimler";
            this.lciHizmetIciEgitim.Location = new System.Drawing.Point(93, 0);
            this.lciHizmetIciEgitim.Name = "lciHizmetIciEgitim";
            this.lciHizmetIciEgitim.Size = new System.Drawing.Size(344, 452);
            this.lciHizmetIciEgitim.Text = "Eğitimler";
            this.lciHizmetIciEgitim.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciHizmetIciEgitim.TextSize = new System.Drawing.Size(76, 13);
            // 
            // lciPersonel
            // 
            this.lciPersonel.Control = this.gcPersonel;
            this.lciPersonel.CustomizationFormText = "Katılan Personel";
            this.lciPersonel.Location = new System.Drawing.Point(437, 0);
            this.lciPersonel.Name = "lciPersonel";
            this.lciPersonel.Size = new System.Drawing.Size(343, 452);
            this.lciPersonel.Text = "Katılan Personel";
            this.lciPersonel.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciPersonel.TextSize = new System.Drawing.Size(76, 13);
            // 
            // lciDeleteHizmetIciEgitim
            // 
            this.lciDeleteHizmetIciEgitim.Control = this.sbDeleteHizmetIciEgitim;
            this.lciDeleteHizmetIciEgitim.CustomizationFormText = "layoutControlItem3";
            this.lciDeleteHizmetIciEgitim.Location = new System.Drawing.Point(0, 52);
            this.lciDeleteHizmetIciEgitim.Name = "lciDeleteHizmetIciEgitim";
            this.lciDeleteHizmetIciEgitim.Size = new System.Drawing.Size(93, 400);
            this.lciDeleteHizmetIciEgitim.Text = "lciDeleteHizmetIciEgitim";
            this.lciDeleteHizmetIciEgitim.TextSize = new System.Drawing.Size(0, 0);
            this.lciDeleteHizmetIciEgitim.TextToControlDistance = 0;
            this.lciDeleteHizmetIciEgitim.TextVisible = false;
            // 
            // lciAddHizmetIciEgitim
            // 
            this.lciAddHizmetIciEgitim.Control = this.sbAddHizmetIciEgitim;
            this.lciAddHizmetIciEgitim.CustomizationFormText = "layoutControlItem4";
            this.lciAddHizmetIciEgitim.Location = new System.Drawing.Point(0, 0);
            this.lciAddHizmetIciEgitim.Name = "lciAddHizmetIciEgitim";
            this.lciAddHizmetIciEgitim.Size = new System.Drawing.Size(93, 26);
            this.lciAddHizmetIciEgitim.Text = "lciAddHizmetIciEgitim";
            this.lciAddHizmetIciEgitim.TextSize = new System.Drawing.Size(0, 0);
            this.lciAddHizmetIciEgitim.TextToControlDistance = 0;
            this.lciAddHizmetIciEgitim.TextVisible = false;
            // 
            // lciChangeHizmetIciEgitim
            // 
            this.lciChangeHizmetIciEgitim.Control = this.sbChangeHizmetIciEgitim;
            this.lciChangeHizmetIciEgitim.CustomizationFormText = "layoutControlItem5";
            this.lciChangeHizmetIciEgitim.Location = new System.Drawing.Point(0, 26);
            this.lciChangeHizmetIciEgitim.Name = "lciChangeHizmetIciEgitim";
            this.lciChangeHizmetIciEgitim.Size = new System.Drawing.Size(93, 26);
            this.lciChangeHizmetIciEgitim.Text = "lciChangeHizmetIciEgitim";
            this.lciChangeHizmetIciEgitim.TextSize = new System.Drawing.Size(0, 0);
            this.lciChangeHizmetIciEgitim.TextToControlDistance = 0;
            this.lciChangeHizmetIciEgitim.TextVisible = false;
            // 
            // lciDeletePersonel
            // 
            this.lciDeletePersonel.Control = this.sbDeletePersonel;
            this.lciDeletePersonel.CustomizationFormText = "layoutControlItem6";
            this.lciDeletePersonel.Location = new System.Drawing.Point(780, 52);
            this.lciDeletePersonel.Name = "lciDeletePersonel";
            this.lciDeletePersonel.Size = new System.Drawing.Size(82, 400);
            this.lciDeletePersonel.Text = "lciDeletePersonel";
            this.lciDeletePersonel.TextSize = new System.Drawing.Size(0, 0);
            this.lciDeletePersonel.TextToControlDistance = 0;
            this.lciDeletePersonel.TextVisible = false;
            // 
            // lciAddPersonel
            // 
            this.lciAddPersonel.Control = this.sbAddPersonel;
            this.lciAddPersonel.CustomizationFormText = "layoutControlItem7";
            this.lciAddPersonel.Location = new System.Drawing.Point(780, 0);
            this.lciAddPersonel.Name = "lciAddPersonel";
            this.lciAddPersonel.Size = new System.Drawing.Size(82, 26);
            this.lciAddPersonel.Text = "lciAddPersonel";
            this.lciAddPersonel.TextSize = new System.Drawing.Size(0, 0);
            this.lciAddPersonel.TextToControlDistance = 0;
            this.lciAddPersonel.TextVisible = false;
            // 
            // lciChangePersonel
            // 
            this.lciChangePersonel.Control = this.sbChangePersonel;
            this.lciChangePersonel.CustomizationFormText = "layoutControlItem8";
            this.lciChangePersonel.Location = new System.Drawing.Point(780, 26);
            this.lciChangePersonel.Name = "lciChangePersonel";
            this.lciChangePersonel.Size = new System.Drawing.Size(82, 26);
            this.lciChangePersonel.Text = "lciChangePersonel";
            this.lciChangePersonel.TextSize = new System.Drawing.Size(0, 0);
            this.lciChangePersonel.TextToControlDistance = 0;
            this.lciChangePersonel.TextVisible = false;
            // 
            // HizmetIciEgitimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 472);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "HizmetIciEgitimForm";
            this.Text = "Hizmetiçi Eğitim İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHizmetIciEgitim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHizmetIciEgitim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHizmetIciEgitim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDeleteHizmetIciEgitim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddHizmetIciEgitim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChangeHizmetIciEgitim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDeletePersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChangePersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton sbChangePersonel;
        private DevExpress.XtraEditors.SimpleButton sbAddPersonel;
        private DevExpress.XtraEditors.SimpleButton sbDeletePersonel;
        private DevExpress.XtraEditors.SimpleButton sbChangeHizmetIciEgitim;
        private DevExpress.XtraEditors.SimpleButton sbAddHizmetIciEgitim;
        private DevExpress.XtraEditors.SimpleButton sbDeleteHizmetIciEgitim;
        private DevExpress.XtraGrid.GridControl gcPersonel;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPersonel;
        private DevExpress.XtraGrid.GridControl gcHizmetIciEgitim;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHizmetIciEgitim;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciHizmetIciEgitim;
        private DevExpress.XtraLayout.LayoutControlItem lciPersonel;
        private DevExpress.XtraLayout.LayoutControlItem lciDeleteHizmetIciEgitim;
        private DevExpress.XtraLayout.LayoutControlItem lciAddHizmetIciEgitim;
        private DevExpress.XtraLayout.LayoutControlItem lciChangeHizmetIciEgitim;
        private DevExpress.XtraLayout.LayoutControlItem lciDeletePersonel;
        private DevExpress.XtraLayout.LayoutControlItem lciAddPersonel;
        private DevExpress.XtraLayout.LayoutControlItem lciChangePersonel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;

    }
}