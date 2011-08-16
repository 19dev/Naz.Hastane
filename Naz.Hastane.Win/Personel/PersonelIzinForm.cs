using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PersonelIzinForm : PersonelDetailIzinForm
    {
        public PersonelIzinForm()
        {
            InitializeComponent();
            LoadLookUps();
            this.sbSaveAndNew.Click += new System.EventHandler(base.sbSaveAndNew_Click);
            this.sbSaveAndClose.Click += new System.EventHandler(base.sbSaveAndClose_Click);
            this.sbCancel.Click += new System.EventHandler(base.sbCancel_Click);
        }

        protected override void InitBindings()
        {
            UIUtilities.BindControl(deBaslangicTarihi, TheObject, x => x.BaslangicTarihi);
            UIUtilities.BindControl(deBitisTarihi, TheObject, x => x.BitisTarihi);
            UIUtilities.BindControl(meAciklama, TheObject, x => x.Aciklama);
        }

        protected override bool Save()
        {
            if (TheObject.BaslangicTarihi == null || TheObject.BitisTarihi == null || TheObject.BaslangicTarihi >= TheObject.BitisTarihi)
            {
                XtraMessageBox.Show("Lütfen Tarihleri Kontrol Ediniz", "Personel İzni Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                LookUpServices.SaveOrUpdate(Session, TheObject);
                XtraMessageBox.Show("Personel İzni Kayıt Edilmiştir", "Personel İzni Kayıt Onayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception error)
            {
                XtraMessageBox.Show("Personel İzni Kayıt Edilemedi:" + error.Message, "Personel İzni Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}