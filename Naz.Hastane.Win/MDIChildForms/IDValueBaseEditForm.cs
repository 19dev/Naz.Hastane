using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Naz.Hastane.Win.Forms;

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
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Girdiğiniz Kayıtı Ediniz", "Kayıt Giriş Hatası", true);
                return false;
            }
            try
            {
                LookUpServices.SaveOrUpdate(Session, TheObject);
                SimpleMsgBoxForm.ShowMsgBox("Kayıt Saklanmıştır", "Kayıt Giriş Onayı", false);
                return true;
            }
            catch (Exception error)
            {
                SimpleMsgBoxForm.ShowMsgBox("Kayıt Saklanamadı:" + error.Message, "Kayıt Giriş Hatası", true);
                return false;
            }

        }

    }
    //public class IDValueBaseDetailForm : DetailEditForm<T> { }
}