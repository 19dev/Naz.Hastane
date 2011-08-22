using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class IDValueBaseEditForm<T> : DetailEditForm<T> where T: IDValueBase, new()
    {
        public IDValueBaseEditForm()
        {
            InitializeComponent();
            this.sbSaveAndNew.Click += new System.EventHandler(base.sbSaveAndNew_Click);
            this.sbSaveAndClose.Click += new System.EventHandler(base.sbSaveAndClose_Click);
            this.sbCancel.Click += new System.EventHandler(base.sbCancel_Click);
        }

        protected override void InitBindings()
        {
            UIUtilities.BindControl(teValue, TheObject, x => x.Value);
        }

        protected override bool Save()
        {
            if (String.IsNullOrWhiteSpace(TheObject.Value))
            {
                XtraMessageBox.Show("Lütfen Girdiğiniz Kayıtı Ediniz", "Kayıt Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                LookUpServices.SaveOrUpdate(Session, TheObject);
                XtraMessageBox.Show("Kayıt Saklanmıştır Edilmiştir", "Kayıt Giriş Onayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception error)
            {
                XtraMessageBox.Show("Kayıt Saklanamadı:" + error.Message, "Kayıt Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

    }
    //public class IDValueBaseDetailForm : DetailEditForm<T> { }
}