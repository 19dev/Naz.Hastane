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
using Naz.Hastane.Data;
using NHibernate;

namespace Naz.Hastane.Win.Forms
{
    public partial class PasswordChangeForm : DevExpress.XtraEditors.XtraForm
    {
        private bool _IsOK = false;
        public bool IsOK { get { return _IsOK; } }

        public User User = null;

        public PasswordChangeForm()
        {
            InitializeComponent();
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbOK_Click(object sender, EventArgs e)
        {
            Encrypter encrypter = new Encrypter();
            encrypter.CodeWord = this.teUserName.Text;

            using (var session = NHibernateSessionManager.Instance.GetSessionFactory().OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                Cursor.Current = Cursors.WaitCursor;

                try
                {
                    User = session.Get<User>(this.teUserName.Text);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
                if (User == null || User.USER_PASS != encrypter.Encrypt(this.teUserPassword.Text))
                {
                    XtraMessageBox.Show("Eski Şifreniz Doğru Değil, Lütfen Tekrar Deneyiniz.", "Şifre Değiştirme Uyarısı");
                    return;
                }
                else if (this.teNewPassword.Text != this.teRepeatNewPassword.Text)
                {
                    XtraMessageBox.Show("Yeni Şifre Tekrarı Tutmuyor, Lütfen Tekrar Deneyiniz.", "Şifre Değiştirme Uyarısı");
                    return;
                }
                User.USER_PASS = encrypter.Encrypt(this.teNewPassword.Text);
                try
                {
                    session.Save(User);
                    transaction.Commit();
                    _IsOK = true;
                }
                finally
                { 
                }
                this.Close();
            }
        }

    }
}
