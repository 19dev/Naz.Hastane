using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Naz.Hastane.Win.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PersonelSertifikaEditForm : PersonelDetailSertifikaForm
    {
        public PersonelSertifikaEditForm()
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
            if (TheObject.BaslangicTarihi == null || TheObject.BitisTarihi == null || TheObject.BaslangicTarihi > TheObject.BitisTarihi)
            {
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Tarihleri Kontrol Ediniz", "Personel Sertifikası Kayıt Hatası", true);
                return false;
            }
            try
            {
                LookUpServices.SaveOrUpdate(Session, TheObject);
                SimpleMsgBoxForm.ShowMsgBox("Personel Sertifikası Kayıt Edilmiştir", "Personel Sertifikası Kayıt Onayı");
                return true;
            }
            catch (Exception error)
            {
                SimpleMsgBoxForm.ShowMsgBox("Personel Sertifikası Kayıt Edilemedi:" + error.Message, "Personel Sertifikası Kayıt Hatası", true);
                return false;
            }

        }

    }
    public class PersonelDetailSertifikaForm : PersonelDetailEditForm<PersonelSertifika> { }
}