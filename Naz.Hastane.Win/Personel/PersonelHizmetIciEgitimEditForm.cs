using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Naz.Hastane.Win.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PersonelHizmetIciEgitimEditForm : PersonelHizmetIciEgitimDetailForm
    {
        public PersonelHizmetIciEgitimEditForm()
        {
            InitializeComponent();
            LoadLookUps();
            this.sbSaveAndNew.Click += new System.EventHandler(base.sbSaveAndNew_Click);
            this.sbSaveAndClose.Click += new System.EventHandler(base.sbSaveAndClose_Click);
            this.sbCancel.Click += new System.EventHandler(base.sbCancel_Click);
        }

        protected override void InitBindings()
        {
            UIUtilities.BindControl(cmbHizmetIciEgitim, TheObject, x => x.HizmetIciEgitim, propertyName: "SelectedItem");
            UIUtilities.BindControl(meAciklama, TheObject, x => x.Aciklama);
        }

        protected override void LoadLookUps()
        {
            UIUtilities.BindComboBox(cmbHizmetIciEgitim, LookUpServices.GetAll<HizmetIciEgitim>(Session), x => x.FullName, x => x.ID);
        }

        protected override bool Save()
        {
            try
            {
                LookUpServices.SaveOrUpdate(Session, TheObject);
                SimpleMsgBoxForm.ShowMsgBox("Personel Eğitimi Kayıt Edilmiştir", "Personel Eğitimi Kayıt Onayı");
                return true;
            }
            catch (Exception error)
            {
                SimpleMsgBoxForm.ShowMsgBox("Personel Eğitimi Kayıt Edilemedi:" + error.Message, "Personel Kayıt Hatası", true);
                return false;
            }

        }
    }
    public class PersonelHizmetIciEgitimDetailForm : PersonelDetailEditForm<PersonelHizmetIciEgitim> { }
}