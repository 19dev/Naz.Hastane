using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Naz.Hastane.Win.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PersonelEgitimEditForm : PersonelDetailEgitimForm
    {
        public PersonelEgitimEditForm()
        {
            InitializeComponent();
            LoadLookUps();
            this.sbSaveAndNew.Click += new System.EventHandler(base.sbSaveAndNew_Click);
            this.sbSaveAndClose.Click += new System.EventHandler(base.sbSaveAndClose_Click);
            this.sbCancel.Click += new System.EventHandler(base.sbCancel_Click);
        }

        protected override void InitBindings()
        {
            UIUtilities.BindControl(cmbOkulTipi, TheObject, x => x.OkulTipi, propertyName: "SelectedItem");
            UIUtilities.BindControl(teOkulAdi, TheObject, x => x.OkulAdi);
            UIUtilities.BindControl(deBaslangicTarihi, TheObject, x => x.BaslangicTarihi);
            UIUtilities.BindControl(deBitisTarihi, TheObject, x => x.BitisTarihi);
            UIUtilities.BindControl(meAciklama, TheObject, x => x.Aciklama);
        }

        protected override void LoadLookUps()
        {
            UIUtilities.BindComboBox(cmbOkulTipi, LookUpServices.OkulTipis, x => x.Value, x => x.ID);
        }

        protected override bool Save()
        {
            if (String.IsNullOrWhiteSpace(TheObject.OkulAdi))
            {
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Okul Adını Kontrol Ediniz", "Personel Eğitimi Kayıt Hatası", true);
                return false;
            }
            if (TheObject.BaslangicTarihi == null || TheObject.BitisTarihi == null || TheObject.BaslangicTarihi > TheObject.BitisTarihi )
            {
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Tarihleri Kontrol Ediniz", "Personel Eğitimi Kayıt Hatası", true);
                return false;
            }
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
    public class PersonelDetailEgitimForm : PersonelDetailEditForm<PersonelEgitim> { }
}