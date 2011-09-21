using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Naz.Classes;
using Naz.Hastane.Win.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PersonelHastaneBolumuEditForm : PersonelDetailHastaneBolumuForm
    {
        public PersonelHastaneBolumuEditForm()
        {
            InitializeComponent();
            LoadLookUps();
            this.sbSaveAndNew.Click += new System.EventHandler(base.sbSaveAndNew_Click);
            this.sbSaveAndClose.Click += new System.EventHandler(base.sbSaveAndClose_Click);
            this.sbCancel.Click += new System.EventHandler(base.sbCancel_Click);
        }

        protected override void InitBindings()
        {
            UIUtilities.BindControl(cmbHastaneBolumu, TheObject, x => x.HastaneBolumu, propertyName: "SelectedItem");
            UIUtilities.BindControl(deBaslangicTarihi, TheObject, x => x.BaslangicTarihi);
            UIUtilities.BindControl(meAciklama, TheObject, x => x.Aciklama);
        }

        protected override void LoadLookUps()
        {
            UIUtilities.BindComboBox(cmbHastaneBolumu, LookUpServices.HastaneBolumus, x => x.Value, x => x.ID);
        }

        protected override bool Save()
        {
            if (TheObject.BaslangicTarihi == null)
            {
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Başlangıç Tarihini Kontrol Ediniz", "Personel Hastane Bölümü Kayıt Hatası", true);
                return false;
            }
            try
            {
                LookUpServices.SaveOrUpdate(Session, TheObject);
                SimpleMsgBoxForm.ShowMsgBox("Personel Hastane Bölümü Kayıt Edilmiştir", "Personel Hastane Bölümü Kayıt Onayı");
                return true;
            }
            catch (Exception error)
            {
                SimpleMsgBoxForm.ShowMsgBox("Personel Hastane Bölümü Kayıt Edilemedi:" + error.Message, "Personel Kayıt Hatası", true);
                return false;
            }

        }
    }
    public class PersonelDetailHastaneBolumuForm : PersonelDetailEditForm<PersonelHastaneBolumu> { }
}