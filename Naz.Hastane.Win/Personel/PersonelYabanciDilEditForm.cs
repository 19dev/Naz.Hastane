using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Naz.Hastane.Win.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PersonelYabanciDilEditForm : PersonelDetailYabanciDilForm
    {
        public PersonelYabanciDilEditForm()
        {
            InitializeComponent();
            LoadLookUps();
            this.sbSaveAndNew.Click += new System.EventHandler(base.sbSaveAndNew_Click);
            this.sbSaveAndClose.Click += new System.EventHandler(base.sbSaveAndClose_Click);
            this.sbCancel.Click += new System.EventHandler(base.sbCancel_Click);
        }

        protected override void InitBindings()
        {
            UIUtilities.BindControl(cmbYabanciDil, TheObject, x => x.YabanciDil, propertyName: "SelectedItem");
            UIUtilities.BindControl(cmbKonusmaDerecesi, TheObject, x => x.KonusmaDerecesi, propertyName: "SelectedItem");
            UIUtilities.BindControl(cmbOkumaDerecesi, TheObject, x => x.OkumaDerecesi, propertyName: "SelectedItem");
            UIUtilities.BindControl(cmbYazmaDerecesi, TheObject, x => x.YazmaDerecesi, propertyName: "SelectedItem");
            UIUtilities.BindControl(meAciklama, TheObject, x => x.Aciklama);
        }

        protected override void LoadLookUps()
        {
            UIUtilities.BindComboBox(cmbYabanciDil, LookUpServices.YabanciDils, x => x.Value, x => x.ID);
            UIUtilities.BindComboBox(cmbKonusmaDerecesi, LookUpServices.YabanciDilDerecesis, x => x.Value, x => x.ID);
            UIUtilities.BindComboBox(cmbOkumaDerecesi, LookUpServices.YabanciDilDerecesis, x => x.Value, x => x.ID);
            UIUtilities.BindComboBox(cmbYazmaDerecesi, LookUpServices.YabanciDilDerecesis, x => x.Value, x => x.ID);
        }

        protected override bool Save()
        {
            try
            {
                LookUpServices.SaveOrUpdate(Session, TheObject);
                SimpleMsgBoxForm.ShowMsgBox("Personel Yabancı Dil Bilgisi Kayıt Edilmiştir", "Personel Yabancı Dil Bilgisi Kayıt Onayı");
                return true;
            }
            catch (Exception error)
            {
                SimpleMsgBoxForm.ShowMsgBox("Personel Yabancı Dil Bilgisi Kayıt Edilemedi:" + error.Message, "Personel Yabancı Dil Bilgisi Kayıt Hatası", true);
                return false;
            }

        }

    }
    public class PersonelDetailYabanciDilForm : PersonelDetailEditForm<PersonelYabanciDil> { }
}