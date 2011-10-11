using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Naz.Hastane.Win.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class AmeliyatListeEditForm : AmeliyatListeDetailEditForm
    {
        protected AmeliyatListe _AmeliyatListe;

        public AmeliyatListeEditForm()
        {
            InitializeComponent();
            LoadLookUps();
            this.sbSaveAndNew.Click += new System.EventHandler(base.sbSaveAndNew_Click);
            this.sbSaveAndClose.Click += new System.EventHandler(base.sbSaveAndClose_Click);
            this.sbCancel.Click += new System.EventHandler(base.sbCancel_Click);

            deTarih.DateTime = DateTime.Today;
        }

        protected override void InitBindings()
        {
            UIUtilities.BindControl(deTarih, TheObject, x => x.Tarih);
            UIUtilities.BindControl(teOda, TheObject, x => x.Oda);
            UIUtilities.BindControl(teHasta, TheObject, x => x.Hasta);
            UIUtilities.BindControl(teDoktor, TheObject, x => x.Doktor);
            UIUtilities.BindControl(teAmeliyatAdi, TheObject, x => x.AmeliyatAdi);
            UIUtilities.BindControl(cmbDurum, TheObject, x => x.Durum, propertyName: "SelectedItem");
            cmbDurum.SelectedIndex = 0;
            UIUtilities.BindControl(teBaslangicSaati, TheObject, x => x.BaslangicSaati);
            UIUtilities.BindControl(teBitisSaati, TheObject, x => x.BitisSaati);
        }

        protected override void LoadLookUps()
        {
            UIUtilities.BindComboBox(cmbDurum, LookUpServices.AmeliyatDurumTipis, x => x.Value, x => x.ID);
        }

        protected override bool Save()
        {
            if (String.IsNullOrWhiteSpace(TheObject.Oda))
            {
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Oda No Giriniz", "Ameliyat Listesi Kayıt Hatası", true);
                return false;
            }
            if (String.IsNullOrWhiteSpace(TheObject.Hasta))
            {
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Hasta Giriniz", "Ameliyat Listesi Kayıt Hatası", true);
                return false;
            }
            if (String.IsNullOrWhiteSpace(TheObject.Doktor))
            {
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Doktor Giriniz", "Ameliyat Listesi Kayıt Hatası", true);
                return false;
            }
            if (String.IsNullOrWhiteSpace(TheObject.AmeliyatAdi))
            {
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Ameliyat Adı Giriniz", "Ameliyat Listesi Kayıt Hatası", true);
                return false;
            }
            if (TheObject.BaslangicSaati == null)
            {
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Başlangıç Saatini Kontrol Ediniz", "Ameliyat Listesi Kayıt Hatası", true);
                return false;
            }
            if (TheObject.BitisSaati == null)
            {
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Bitiş Saatini Kontrol Ediniz", "Ameliyat Listesi Kayıt Hatası", true);
                return false;
            }
            try
            {
                LookUpServices.SaveOrUpdate(Session, TheObject);
                SimpleMsgBoxForm.ShowMsgBox("Ameliyat Listesi Kayıt Edilmiştir", "Ameliyat Listesi Kayıt Onayı");
                return true;
            }
            catch (Exception error)
            {
                SimpleMsgBoxForm.ShowMsgBox("Ameliyat Listesi Kayıt Edilemedi:" + error.Message, "Ameliyat Listesi Kayıt Hatası", true);
                return false;
            }

        }
    }
    public class AmeliyatListeDetailEditForm : DetailEditForm<AmeliyatListe> {}

}