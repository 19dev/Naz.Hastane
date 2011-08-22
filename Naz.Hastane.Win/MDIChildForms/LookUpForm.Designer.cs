namespace Naz.Hastane.Win.MDIChildForms
{
    partial class LookUpForm<T>
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
            this.sbEdit = new DevExpress.XtraEditors.SimpleButton();
            this.gcLookUp = new DevExpress.XtraGrid.GridControl();
            this.gvLookUp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.sbNew = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciClose = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciNew = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.sbDelete = new DevExpress.XtraEditors.SimpleButton();
            this.lciDelete = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbDelete);
            this.layoutControl1.Controls.Add(this.sbEdit);
            this.layoutControl1.Controls.Add(this.gcLookUp);
            this.layoutControl1.Controls.Add(this.sbClose);
            this.layoutControl1.Controls.Add(this.sbNew);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1989, -90, 459, 561);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(494, 275);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbEdit
            // 
            this.sbEdit.Location = new System.Drawing.Point(406, 55);
            this.sbEdit.Name = "sbEdit";
            this.sbEdit.Size = new System.Drawing.Size(66, 22);
            this.sbEdit.StyleController = this.layoutControl1;
            this.sbEdit.TabIndex = 5;
            this.sbEdit.Text = "Değiştir";
            this.sbEdit.Click += new System.EventHandler(this.sbEdit_Click);
            // 
            // gcLookUp
            // 
            this.gcLookUp.Location = new System.Drawing.Point(12, 12);
            this.gcLookUp.MainView = this.gvLookUp;
            this.gcLookUp.Name = "gcLookUp";
            this.gcLookUp.Size = new System.Drawing.Size(380, 251);
            this.gcLookUp.TabIndex = 4;
            this.gcLookUp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLookUp});
            // 
            // gvLookUp
            // 
            this.gvLookUp.GridControl = this.gcLookUp;
            this.gvLookUp.Name = "gvLookUp";
            this.gvLookUp.OptionsBehavior.Editable = false;
            this.gvLookUp.OptionsView.ShowGroupPanel = false;
            this.gvLookUp.DoubleClick += new System.EventHandler(this.gvLookUp_DoubleClick);
            // 
            // sbClose
            // 
            this.sbClose.Location = new System.Drawing.Point(406, 191);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(66, 22);
            this.sbClose.StyleController = this.layoutControl1;
            this.sbClose.TabIndex = 7;
            this.sbClose.Text = "Kapat";
            this.sbClose.Click += new System.EventHandler(this.sbClose_Click);
            // 
            // sbNew
            // 
            this.sbNew.Location = new System.Drawing.Point(406, 91);
            this.sbNew.Name = "sbNew";
            this.sbNew.Size = new System.Drawing.Size(66, 22);
            this.sbNew.StyleController = this.layoutControl1;
            this.sbNew.TabIndex = 6;
            this.sbNew.Text = "Yeni";
            this.sbNew.Click += new System.EventHandler(this.sbNew_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGrid,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(494, 275);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciGrid
            // 
            this.lciGrid.Control = this.gcLookUp;
            this.lciGrid.CustomizationFormText = "lciGrid";
            this.lciGrid.Location = new System.Drawing.Point(0, 0);
            this.lciGrid.Name = "lciGrid";
            this.lciGrid.Size = new System.Drawing.Size(384, 255);
            this.lciGrid.Text = "lciGrid";
            this.lciGrid.TextSize = new System.Drawing.Size(0, 0);
            this.lciGrid.TextToControlDistance = 0;
            this.lciGrid.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.lciClose,
            this.lciEdit,
            this.emptySpaceItem4,
            this.lciNew,
            this.emptySpaceItem3,
            this.emptySpaceItem1,
            this.lciDelete,
            this.emptySpaceItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(384, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(90, 255);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 195);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(70, 40);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciClose
            // 
            this.lciClose.Control = this.sbClose;
            this.lciClose.CustomizationFormText = "lciClose";
            this.lciClose.Location = new System.Drawing.Point(0, 169);
            this.lciClose.Name = "lciClose";
            this.lciClose.Size = new System.Drawing.Size(70, 26);
            this.lciClose.Text = "lciClose";
            this.lciClose.TextSize = new System.Drawing.Size(0, 0);
            this.lciClose.TextToControlDistance = 0;
            this.lciClose.TextVisible = false;
            // 
            // lciEdit
            // 
            this.lciEdit.Control = this.sbEdit;
            this.lciEdit.CustomizationFormText = "lciEdit";
            this.lciEdit.Location = new System.Drawing.Point(0, 33);
            this.lciEdit.Name = "lciEdit";
            this.lciEdit.Size = new System.Drawing.Size(70, 26);
            this.lciEdit.Text = "lciEdit";
            this.lciEdit.TextSize = new System.Drawing.Size(0, 0);
            this.lciEdit.TextToControlDistance = 0;
            this.lciEdit.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 59);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(70, 10);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciNew
            // 
            this.lciNew.Control = this.sbNew;
            this.lciNew.CustomizationFormText = "lciNew";
            this.lciNew.Location = new System.Drawing.Point(0, 69);
            this.lciNew.Name = "lciNew";
            this.lciNew.Size = new System.Drawing.Size(70, 26);
            this.lciNew.Text = "lciNew";
            this.lciNew.TextSize = new System.Drawing.Size(0, 0);
            this.lciNew.TextToControlDistance = 0;
            this.lciNew.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 136);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(70, 33);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(70, 33);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // sbDelete
            // 
            this.sbDelete.Location = new System.Drawing.Point(406, 132);
            this.sbDelete.Name = "sbDelete";
            this.sbDelete.Size = new System.Drawing.Size(66, 22);
            this.sbDelete.StyleController = this.layoutControl1;
            this.sbDelete.TabIndex = 8;
            this.sbDelete.Text = "Sil";
            this.sbDelete.Click += new System.EventHandler(this.sbDelete_Click);
            // 
            // lciDelete
            // 
            this.lciDelete.Control = this.sbDelete;
            this.lciDelete.CustomizationFormText = "lciDelete";
            this.lciDelete.Location = new System.Drawing.Point(0, 110);
            this.lciDelete.Name = "lciDelete";
            this.lciDelete.Size = new System.Drawing.Size(70, 26);
            this.lciDelete.Text = "lciDelete";
            this.lciDelete.TextSize = new System.Drawing.Size(0, 0);
            this.lciDelete.TextToControlDistance = 0;
            this.lciDelete.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5";
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 95);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(70, 15);
            this.emptySpaceItem5.Text = "emptySpaceItem5";
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // LookUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 275);
            this.Controls.Add(this.layoutControl1);
            this.Name = "LookUpForm";
            this.Text = "LookUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLookUp;
        private DevExpress.XtraLayout.LayoutControlItem lciGrid;
        private DevExpress.XtraEditors.SimpleButton sbClose;
        private DevExpress.XtraEditors.SimpleButton sbNew;
        private DevExpress.XtraEditors.SimpleButton sbEdit;
        private DevExpress.XtraLayout.LayoutControlItem lciEdit;
        private DevExpress.XtraLayout.LayoutControlItem lciNew;
        private DevExpress.XtraLayout.LayoutControlItem lciClose;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.SimpleButton sbDelete;
        private DevExpress.XtraLayout.LayoutControlItem lciDelete;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
    }
}