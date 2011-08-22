using Naz.Hastane.Data.Entities;
namespace Naz.Hastane.Win.MDIChildForms
{
    partial class IDValueBaseEditForm<T>
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
            this.sbSaveAndNew = new DevExpress.XtraEditors.SimpleButton();
            this.sbSaveAndClose = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciValue = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSaveAndClose = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSaveAndNew = new DevExpress.XtraLayout.LayoutControlItem();
            this.teValue = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveAndClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveAndNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbSaveAndNew);
            this.layoutControl1.Controls.Add(this.sbSaveAndClose);
            this.layoutControl1.Controls.Add(this.sbCancel);
            this.layoutControl1.Controls.Add(this.teValue);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(387, 114);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbSaveAndNew
            // 
            this.sbSaveAndNew.Location = new System.Drawing.Point(274, 12);
            this.sbSaveAndNew.Name = "sbSaveAndNew";
            this.sbSaveAndNew.Size = new System.Drawing.Size(101, 22);
            this.sbSaveAndNew.StyleController = this.layoutControl1;
            this.sbSaveAndNew.TabIndex = 13;
            this.sbSaveAndNew.Text = "Sakla ve Yeni Kayıt";
            // 
            // sbSaveAndClose
            // 
            this.sbSaveAndClose.Location = new System.Drawing.Point(274, 38);
            this.sbSaveAndClose.Name = "sbSaveAndClose";
            this.sbSaveAndClose.Size = new System.Drawing.Size(101, 22);
            this.sbSaveAndClose.StyleController = this.layoutControl1;
            this.sbSaveAndClose.TabIndex = 9;
            this.sbSaveAndClose.Text = "Sakla ve Kapat";
            // 
            // sbCancel
            // 
            this.sbCancel.Location = new System.Drawing.Point(274, 64);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(101, 22);
            this.sbCancel.StyleController = this.layoutControl1;
            this.sbCancel.TabIndex = 6;
            this.sbCancel.Text = "Vazgeç";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciValue,
            this.lciSaveAndClose,
            this.lciCancel,
            this.lciSaveAndNew});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(387, 114);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciValue
            // 
            this.lciValue.Control = this.teValue;
            this.lciValue.CustomizationFormText = "Açıklama";
            this.lciValue.Location = new System.Drawing.Point(0, 0);
            this.lciValue.Name = "lciValue";
            this.lciValue.Size = new System.Drawing.Size(262, 94);
            this.lciValue.Text = "Açıklama";
            this.lciValue.TextSize = new System.Drawing.Size(41, 13);
            // 
            // lciSaveAndClose
            // 
            this.lciSaveAndClose.Control = this.sbSaveAndClose;
            this.lciSaveAndClose.CustomizationFormText = "layoutControlItem6";
            this.lciSaveAndClose.Location = new System.Drawing.Point(262, 26);
            this.lciSaveAndClose.Name = "lciSaveAndClose";
            this.lciSaveAndClose.Size = new System.Drawing.Size(105, 26);
            this.lciSaveAndClose.Text = "lciSaveAndClose";
            this.lciSaveAndClose.TextSize = new System.Drawing.Size(0, 0);
            this.lciSaveAndClose.TextToControlDistance = 0;
            this.lciSaveAndClose.TextVisible = false;
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.sbCancel;
            this.lciCancel.CustomizationFormText = "layoutControlItem3";
            this.lciCancel.Location = new System.Drawing.Point(262, 52);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.Size = new System.Drawing.Size(105, 42);
            this.lciCancel.Text = "lciCancel";
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextToControlDistance = 0;
            this.lciCancel.TextVisible = false;
            // 
            // lciSaveAndNew
            // 
            this.lciSaveAndNew.Control = this.sbSaveAndNew;
            this.lciSaveAndNew.CustomizationFormText = "lciSaveAndNew";
            this.lciSaveAndNew.Location = new System.Drawing.Point(262, 0);
            this.lciSaveAndNew.Name = "lciSaveAndNew";
            this.lciSaveAndNew.Size = new System.Drawing.Size(105, 26);
            this.lciSaveAndNew.Text = "lciSaveAndNew";
            this.lciSaveAndNew.TextSize = new System.Drawing.Size(0, 0);
            this.lciSaveAndNew.TextToControlDistance = 0;
            this.lciSaveAndNew.TextVisible = false;
            // 
            // teValue
            // 
            this.teValue.Location = new System.Drawing.Point(57, 12);
            this.teValue.Name = "teValue";
            this.teValue.Size = new System.Drawing.Size(213, 20);
            this.teValue.StyleController = this.layoutControl1;
            this.teValue.TabIndex = 4;
            // 
            // IDValueBaseEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 114);
            this.Controls.Add(this.layoutControl1);
            this.Name = "IDValueBaseEditForm";
            this.Text = "Kayıt Giriş Formu";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveAndClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveAndNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teValue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton sbSaveAndClose;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraLayout.LayoutControlItem lciValue;
        private DevExpress.XtraLayout.LayoutControlItem lciCancel;
        private DevExpress.XtraLayout.LayoutControlItem lciSaveAndClose;
        private DevExpress.XtraEditors.SimpleButton sbSaveAndNew;
        private DevExpress.XtraLayout.LayoutControlItem lciSaveAndNew;
        private DevExpress.XtraEditors.TextEdit teValue;
    }
}