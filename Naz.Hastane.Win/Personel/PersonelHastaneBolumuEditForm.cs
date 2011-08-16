using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

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
            UIUtilities.BindComboBox(cmbHastaneBolumu, LookUpServices.HastaneBolumus, displayMember: "Value", valueMember: "ID");
        }

        protected override bool Save()
        {
            if (TheObject.BaslangicTarihi == null)
            {
                XtraMessageBox.Show("Lütfen Başlangıç Tarihini Kontrol Ediniz", "Personel Hastane Bölümü Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                LookUpServices.SaveOrUpdate(Session, TheObject);
                XtraMessageBox.Show("Personel Hastane Bölümü Kayıt Edilmiştir", "Personel Hastane Bölümü Kayıt Onayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception error)
            {
                XtraMessageBox.Show("Personel Hastane Bölümü Kayıt Edilemedi:" + error.Message, "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
    public class PersonelDetailHastaneBolumuForm : PersonelDetailEditForm<PersonelHastaneBolumu> { }

}