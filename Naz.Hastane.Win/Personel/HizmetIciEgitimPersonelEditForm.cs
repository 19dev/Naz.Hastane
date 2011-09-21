using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Naz.Hastane.Win.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class HizmetIciEgitimPersonelEditForm : HizmetIciEgitimPersonelDetailForm
    {
        protected HizmetIciEgitim _HizmetIciEgitim;

        public HizmetIciEgitimPersonelEditForm()
        {
            InitializeComponent();
            LoadLookUps();
            this.sbSaveAndNew.Click += new System.EventHandler(base.sbSaveAndNew_Click);
            this.sbSaveAndClose.Click += new System.EventHandler(base.sbSaveAndClose_Click);
            this.sbCancel.Click += new System.EventHandler(base.sbCancel_Click);
        }

        public virtual void DetailFormParams(HizmetIciEgitim hizmetIciEgitim, int detailID)
        {
            if (hizmetIciEgitim == null)
                Close();

            _HizmetIciEgitim = hizmetIciEgitim;

            base.DetailFormParams(detailID);

        }

        protected override PersonelHizmetIciEgitim CreateNewObject()
        {
            PersonelHizmetIciEgitim o = base.CreateNewObject();
            o.HizmetIciEgitim = _HizmetIciEgitim;
            return o;
        }

        protected override void InitBindings()
        {
            UIUtilities.BindControl(cmbPersonel, TheObject, x => x.Personel, propertyName: "SelectedItem");
            UIUtilities.BindControl(meAciklama, TheObject, x => x.Aciklama);
        }

        protected override void LoadLookUps()
        {
            UIUtilities.BindComboBox(cmbPersonel, LookUpServices.GetAll<Personel>(), x => x.FullName, x => x.ID);
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
    public class HizmetIciEgitimPersonelDetailForm : DetailEditForm<PersonelHizmetIciEgitim> { }
}