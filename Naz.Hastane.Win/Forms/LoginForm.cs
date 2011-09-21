using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Utilities.Classes;

namespace Naz.Hastane.Win.Forms
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private bool _IsOK = false;
        public bool IsOK { get { return _IsOK; } }

        public User User = null;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbOK_Click(object sender, EventArgs e)
        {
            if (IsLoginOK())
            {
                _IsOK = true;
                this.Close();
            }

        }

        private bool IsLoginOK()
        {
            Cursor.Current = Cursors.WaitCursor;

            Encrypter encrypter = new Encrypter();
            encrypter.CodeWord = this.teUserName.Text;
            try
            {
                User = LookUpServices.GetByID<User>(this.teUserName.Text);
            }
            catch(Exception e)
            {
                SimpleMsgBoxForm.ShowMsgBox("Veritabanı Hatası: " + e.Message, "Uyarı", true);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            if (User == null || User.USER_PASS != encrypter.Encrypt(this.teUserPassword.Text))
            {
                SimpleMsgBoxForm.ShowMsgBox("Bu Kullanıcı Geçerli Değil", "Kullanıcı Girişi Uyarısı", true);
                return false;
            }
            else
                return true;

        }

        private void sbChangePassword_Click(object sender, EventArgs e)
        {
            PasswordChangeForm form = new PasswordChangeForm();
            form.ShowDialog();
            if (form.IsOK)
            {
                User = form.User;
                _IsOK = true;
                this.Close();
            }
        }

    }
}
