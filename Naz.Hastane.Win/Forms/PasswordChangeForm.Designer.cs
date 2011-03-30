namespace Naz.Hastane.Win.Forms
{
    partial class PasswordChangeForm
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
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbOK = new DevExpress.XtraEditors.SimpleButton();
            this.teUserPassword = new DevExpress.XtraEditors.TextEdit();
            this.teUserName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciUserPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.teNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.lciNewPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.teRepeatNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.lciRepeatNewPassword = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teUserPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRepeatNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRepeatNewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.teRepeatNewPassword);
            this.layoutControl1.Controls.Add(this.teNewPassword);
            this.layoutControl1.Controls.Add(this.sbCancel);
            this.layoutControl1.Controls.Add(this.sbOK);
            this.layoutControl1.Controls.Add(this.teUserPassword);
            this.layoutControl1.Controls.Add(this.teUserName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(304, 172);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbCancel
            // 
            this.sbCancel.Location = new System.Drawing.Point(154, 120);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(138, 22);
            this.sbCancel.StyleController = this.layoutControl1;
            this.sbCancel.TabIndex = 7;
            this.sbCancel.Text = "İptal";
            this.sbCancel.Click += new System.EventHandler(this.sbCancel_Click);
            // 
            // sbOK
            // 
            this.sbOK.Location = new System.Drawing.Point(12, 120);
            this.sbOK.Name = "sbOK";
            this.sbOK.Size = new System.Drawing.Size(138, 22);
            this.sbOK.StyleController = this.layoutControl1;
            this.sbOK.TabIndex = 6;
            this.sbOK.Text = "Tamam";
            this.sbOK.Click += new System.EventHandler(this.sbOK_Click);
            // 
            // teUserPassword
            // 
            this.teUserPassword.Location = new System.Drawing.Point(74, 36);
            this.teUserPassword.Name = "teUserPassword";
            this.teUserPassword.Properties.PasswordChar = '*';
            this.teUserPassword.Size = new System.Drawing.Size(218, 20);
            this.teUserPassword.StyleController = this.layoutControl1;
            this.teUserPassword.TabIndex = 5;
            // 
            // teUserName
            // 
            this.teUserName.Location = new System.Drawing.Point(74, 12);
            this.teUserName.Name = "teUserName";
            this.teUserName.Size = new System.Drawing.Size(218, 20);
            this.teUserName.StyleController = this.layoutControl1;
            this.teUserName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciUserName,
            this.lciUserPassword,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem2,
            this.lciNewPassword,
            this.emptySpaceItem1,
            this.lciRepeatNewPassword});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(304, 172);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciUserName
            // 
            this.lciUserName.Control = this.teUserName;
            this.lciUserName.CustomizationFormText = "Kullanıcı Adı";
            this.lciUserName.Location = new System.Drawing.Point(0, 0);
            this.lciUserName.Name = "lciUserName";
            this.lciUserName.Size = new System.Drawing.Size(284, 24);
            this.lciUserName.Text = "Kullanıcı Adı";
            this.lciUserName.TextSize = new System.Drawing.Size(58, 13);
            // 
            // lciUserPassword
            // 
            this.lciUserPassword.Control = this.teUserPassword;
            this.lciUserPassword.CustomizationFormText = "Eski Şifresi";
            this.lciUserPassword.Location = new System.Drawing.Point(0, 24);
            this.lciUserPassword.Name = "lciUserPassword";
            this.lciUserPassword.Size = new System.Drawing.Size(284, 24);
            this.lciUserPassword.Text = "Eski Şifresi";
            this.lciUserPassword.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbOK;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(142, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbCancel;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(142, 108);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(142, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(284, 12);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 134);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(284, 18);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // teNewPassword
            // 
            this.teNewPassword.Location = new System.Drawing.Point(74, 60);
            this.teNewPassword.Name = "teNewPassword";
            this.teNewPassword.Properties.PasswordChar = '*';
            this.teNewPassword.Size = new System.Drawing.Size(218, 20);
            this.teNewPassword.StyleController = this.layoutControl1;
            this.teNewPassword.TabIndex = 8;
            // 
            // lciNewPassword
            // 
            this.lciNewPassword.Control = this.teNewPassword;
            this.lciNewPassword.CustomizationFormText = "Yeni Şifresi";
            this.lciNewPassword.Location = new System.Drawing.Point(0, 48);
            this.lciNewPassword.Name = "lciNewPassword";
            this.lciNewPassword.Size = new System.Drawing.Size(284, 24);
            this.lciNewPassword.Text = "Yeni Şifresi";
            this.lciNewPassword.TextSize = new System.Drawing.Size(58, 13);
            // 
            // teRepeatNewPassword
            // 
            this.teRepeatNewPassword.Location = new System.Drawing.Point(74, 84);
            this.teRepeatNewPassword.Name = "teRepeatNewPassword";
            this.teRepeatNewPassword.Properties.PasswordChar = '*';
            this.teRepeatNewPassword.Size = new System.Drawing.Size(218, 20);
            this.teRepeatNewPassword.StyleController = this.layoutControl1;
            this.teRepeatNewPassword.TabIndex = 9;
            // 
            // lciRepeatNewPassword
            // 
            this.lciRepeatNewPassword.Control = this.teRepeatNewPassword;
            this.lciRepeatNewPassword.CustomizationFormText = "Şifre Tekrarı";
            this.lciRepeatNewPassword.Location = new System.Drawing.Point(0, 72);
            this.lciRepeatNewPassword.Name = "lciRepeatNewPassword";
            this.lciRepeatNewPassword.Size = new System.Drawing.Size(284, 24);
            this.lciRepeatNewPassword.Text = "Şifre Tekrarı";
            this.lciRepeatNewPassword.TextSize = new System.Drawing.Size(58, 13);
            // 
            // PasswordChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 172);
            this.Controls.Add(this.layoutControl1);
            this.Name = "PasswordChangeForm";
            this.Text = "Şifre Değiştirme Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teUserPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRepeatNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRepeatNewPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.SimpleButton sbOK;
        private DevExpress.XtraEditors.TextEdit teUserPassword;
        private DevExpress.XtraEditors.TextEdit teUserName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciUserName;
        private DevExpress.XtraLayout.LayoutControlItem lciUserPassword;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.TextEdit teRepeatNewPassword;
        private DevExpress.XtraEditors.TextEdit teNewPassword;
        private DevExpress.XtraLayout.LayoutControlItem lciNewPassword;
        private DevExpress.XtraLayout.LayoutControlItem lciRepeatNewPassword;
    }
}