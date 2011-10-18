namespace Naz.Hastane.Win.MDIChildForms
{
    partial class PatientArchiveEditForm
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.teYer = new DevExpress.XtraEditors.TextEdit();
            this.lciYer = new DevExpress.XtraLayout.LayoutControlItem();
            this.teOda = new DevExpress.XtraEditors.TextEdit();
            this.lciOda = new DevExpress.XtraLayout.LayoutControlItem();
            this.teRaf = new DevExpress.XtraEditors.TextEdit();
            this.lciRaf = new DevExpress.XtraLayout.LayoutControlItem();
            this.teKutu = new DevExpress.XtraEditors.TextEdit();
            this.lciKutu = new DevExpress.XtraLayout.LayoutControlItem();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.lciSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teYer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciYer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRaf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRaf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teKutu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKutu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbCancel);
            this.layoutControl1.Controls.Add(this.sbSave);
            this.layoutControl1.Controls.Add(this.teKutu);
            this.layoutControl1.Controls.Add(this.teRaf);
            this.layoutControl1.Controls.Add(this.teOda);
            this.layoutControl1.Controls.Add(this.teYer);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(394, 273);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciYer,
            this.lciOda,
            this.lciRaf,
            this.lciKutu,
            this.lciSave,
            this.lciCancel,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(394, 273);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // teYer
            // 
            this.teYer.Location = new System.Drawing.Point(38, 12);
            this.teYer.Name = "teYer";
            this.teYer.Size = new System.Drawing.Size(262, 20);
            this.teYer.StyleController = this.layoutControl1;
            this.teYer.TabIndex = 4;
            // 
            // lciYer
            // 
            this.lciYer.Control = this.teYer;
            this.lciYer.CustomizationFormText = "Yer";
            this.lciYer.Location = new System.Drawing.Point(0, 0);
            this.lciYer.Name = "lciYer";
            this.lciYer.Size = new System.Drawing.Size(292, 24);
            this.lciYer.Text = "Yer";
            this.lciYer.TextSize = new System.Drawing.Size(22, 13);
            // 
            // teOda
            // 
            this.teOda.Location = new System.Drawing.Point(38, 36);
            this.teOda.Name = "teOda";
            this.teOda.Size = new System.Drawing.Size(262, 20);
            this.teOda.StyleController = this.layoutControl1;
            this.teOda.TabIndex = 5;
            // 
            // lciOda
            // 
            this.lciOda.Control = this.teOda;
            this.lciOda.CustomizationFormText = "Oda";
            this.lciOda.Location = new System.Drawing.Point(0, 24);
            this.lciOda.Name = "lciOda";
            this.lciOda.Size = new System.Drawing.Size(292, 24);
            this.lciOda.Text = "Oda";
            this.lciOda.TextSize = new System.Drawing.Size(22, 13);
            // 
            // teRaf
            // 
            this.teRaf.Location = new System.Drawing.Point(38, 60);
            this.teRaf.Name = "teRaf";
            this.teRaf.Size = new System.Drawing.Size(262, 20);
            this.teRaf.StyleController = this.layoutControl1;
            this.teRaf.TabIndex = 6;
            // 
            // lciRaf
            // 
            this.lciRaf.Control = this.teRaf;
            this.lciRaf.CustomizationFormText = "Raf";
            this.lciRaf.Location = new System.Drawing.Point(0, 48);
            this.lciRaf.Name = "lciRaf";
            this.lciRaf.Size = new System.Drawing.Size(292, 24);
            this.lciRaf.Text = "Raf";
            this.lciRaf.TextSize = new System.Drawing.Size(22, 13);
            // 
            // teKutu
            // 
            this.teKutu.Location = new System.Drawing.Point(38, 84);
            this.teKutu.Name = "teKutu";
            this.teKutu.Size = new System.Drawing.Size(262, 20);
            this.teKutu.StyleController = this.layoutControl1;
            this.teKutu.TabIndex = 7;
            // 
            // lciKutu
            // 
            this.lciKutu.Control = this.teKutu;
            this.lciKutu.CustomizationFormText = "Kutu";
            this.lciKutu.Location = new System.Drawing.Point(0, 72);
            this.lciKutu.Name = "lciKutu";
            this.lciKutu.Size = new System.Drawing.Size(292, 181);
            this.lciKutu.Text = "Kutu";
            this.lciKutu.TextSize = new System.Drawing.Size(22, 13);
            // 
            // sbSave
            // 
            this.sbSave.Location = new System.Drawing.Point(304, 12);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(78, 22);
            this.sbSave.StyleController = this.layoutControl1;
            this.sbSave.TabIndex = 8;
            this.sbSave.Text = "Kaydet";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // lciSave
            // 
            this.lciSave.Control = this.sbSave;
            this.lciSave.CustomizationFormText = "lciSave";
            this.lciSave.Location = new System.Drawing.Point(292, 0);
            this.lciSave.Name = "lciSave";
            this.lciSave.Size = new System.Drawing.Size(82, 26);
            this.lciSave.Text = "lciSave";
            this.lciSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciSave.TextToControlDistance = 0;
            this.lciSave.TextVisible = false;
            // 
            // sbCancel
            // 
            this.sbCancel.Location = new System.Drawing.Point(304, 239);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(78, 22);
            this.sbCancel.StyleController = this.layoutControl1;
            this.sbCancel.TabIndex = 9;
            this.sbCancel.Text = "İptal";
            this.sbCancel.Click += new System.EventHandler(this.sbCancel_Click);
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.sbCancel;
            this.lciCancel.CustomizationFormText = "lciCancel";
            this.lciCancel.Location = new System.Drawing.Point(292, 227);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.Size = new System.Drawing.Size(82, 26);
            this.lciCancel.Text = "lciCancel";
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextToControlDistance = 0;
            this.lciCancel.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(292, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(82, 201);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PatientArchiveEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 273);
            this.Controls.Add(this.layoutControl1);
            this.Name = "PatientArchiveEditForm";
            this.Text = "PatientArchiveEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teYer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciYer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRaf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRaf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teKutu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKutu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.SimpleButton sbSave;
        private DevExpress.XtraEditors.TextEdit teKutu;
        private DevExpress.XtraEditors.TextEdit teRaf;
        private DevExpress.XtraEditors.TextEdit teOda;
        private DevExpress.XtraEditors.TextEdit teYer;
        private DevExpress.XtraLayout.LayoutControlItem lciYer;
        private DevExpress.XtraLayout.LayoutControlItem lciOda;
        private DevExpress.XtraLayout.LayoutControlItem lciRaf;
        private DevExpress.XtraLayout.LayoutControlItem lciKutu;
        private DevExpress.XtraLayout.LayoutControlItem lciSave;
        private DevExpress.XtraLayout.LayoutControlItem lciCancel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}