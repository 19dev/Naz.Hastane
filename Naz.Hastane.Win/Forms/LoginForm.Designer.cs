namespace Naz.Hastane.Win.Forms
{
    partial class LoginForm
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
            this.sbChangePassword = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbOK = new DevExpress.XtraEditors.SimpleButton();
            this.teUserPassword = new DevExpress.XtraEditors.TextEdit();
            this.teUserName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciUserPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teUserPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbChangePassword);
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
            // sbChangePassword
            // 
            this.sbChangePassword.Location = new System.Drawing.Point(12, 126);
            this.sbChangePassword.Name = "sbChangePassword";
            this.sbChangePassword.Size = new System.Drawing.Size(280, 22);
            this.sbChangePassword.StyleController = this.layoutControl1;
            this.sbChangePassword.TabIndex = 8;
            this.sbChangePassword.Text = "Şifre Değiştir";
            this.sbChangePassword.Click += new System.EventHandler(this.sbChangePassword_Click);
            // 
            // sbCancel
            // 
            this.sbCancel.Location = new System.Drawing.Point(154, 83);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(138, 22);
            this.sbCancel.StyleController = this.layoutControl1;
            this.sbCancel.TabIndex = 7;
            this.sbCancel.Text = "İptal";
            this.sbCancel.Click += new System.EventHandler(this.sbCancel_Click);
            // 
            // sbOK
            // 
            this.sbOK.Location = new System.Drawing.Point(12, 83);
            this.sbOK.Name = "sbOK";
            this.sbOK.Size = new System.Drawing.Size(138, 22);
            this.sbOK.StyleController = this.layoutControl1;
            this.sbOK.TabIndex = 6;
            this.sbOK.Text = "Tamam";
            this.sbOK.Click += new System.EventHandler(this.sbOK_Click);
            // 
            // teUserPassword
            // 
            this.teUserPassword.Location = new System.Drawing.Point(85, 36);
            this.teUserPassword.Name = "teUserPassword";
            this.teUserPassword.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teUserPassword.Properties.PasswordChar = '*';
            this.teUserPassword.Size = new System.Drawing.Size(207, 20);
            this.teUserPassword.StyleController = this.layoutControl1;
            this.teUserPassword.TabIndex = 5;
            // 
            // teUserName
            // 
            this.teUserName.EnterMoveNextControl = true;
            this.teUserName.Location = new System.Drawing.Point(85, 12);
            this.teUserName.Name = "teUserName";
            this.teUserName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teUserName.Size = new System.Drawing.Size(207, 20);
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
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.emptySpaceItem3,
            this.emptySpaceItem2});
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
            this.lciUserName.TextSize = new System.Drawing.Size(69, 13);
            // 
            // lciUserPassword
            // 
            this.lciUserPassword.Control = this.teUserPassword;
            this.lciUserPassword.CustomizationFormText = "Kullanıcı Şifresi";
            this.lciUserPassword.Location = new System.Drawing.Point(0, 24);
            this.lciUserPassword.Name = "lciUserPassword";
            this.lciUserPassword.Size = new System.Drawing.Size(284, 24);
            this.lciUserPassword.Text = "Kullanıcı Şifresi";
            this.lciUserPassword.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbOK;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 71);
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
            this.layoutControlItem4.Location = new System.Drawing.Point(142, 71);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(142, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbChangePassword;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 114);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(284, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(284, 23);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 140);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(284, 12);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 97);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(284, 17);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.sbOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 172);
            this.Controls.Add(this.layoutControl1);
            this.Name = "LoginForm";
            this.Text = "Kullanıcı Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teUserPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton sbChangePassword;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.SimpleButton sbOK;
        private DevExpress.XtraEditors.TextEdit teUserPassword;
        private DevExpress.XtraEditors.TextEdit teUserName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciUserName;
        private DevExpress.XtraLayout.LayoutControlItem lciUserPassword;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}