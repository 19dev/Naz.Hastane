using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class HizmetIciEgitimEditForm : HizmetIciEgitimDetailForm
    {
        public HizmetIciEgitimEditForm()
        {
            InitializeComponent();
            LoadLookUps();
            this.sbSaveAndNew.Click += new System.EventHandler(base.sbSaveAndNew_Click);
            this.sbSaveAndClose.Click += new System.EventHandler(base.sbSaveAndClose_Click);
            this.sbCancel.Click += new System.EventHandler(base.sbCancel_Click);
        }

        protected override void InitBindings()
        {
            UIUtilities.BindControl(cmbHizmetIciEgitimTipi, TheObject, x => x.HizmetIciEgitimTipi, propertyName: "SelectedItem");
            UIUtilities.BindControl(deBaslangicTarihi, TheObject, x => x.BaslangicTarihi);
            UIUtilities.BindControl(deBitisTarihi, TheObject, x => x.BitisTarihi);
            UIUtilities.BindControl(meAciklama, TheObject, x => x.Aciklama);
        }

        protected override void LoadLookUps()
        {
            UIUtilities.BindComboBox(cmbHizmetIciEgitimTipi, LookUpServices.HizmetIciEgitimTipis, displayMember: "Value", valueMember: "ID");
        }

        protected override bool Save()
        {
            if (TheObject.BaslangicTarihi == null || TheObject.BitisTarihi == null || TheObject.BaslangicTarihi > TheObject.BitisTarihi )
            {
                XtraMessageBox.Show("Lütfen Tarihleri Kontrol Ediniz", "Hizmetiçi Eğitimi Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                LookUpServices.SaveOrUpdate(Session, TheObject);
                XtraMessageBox.Show("Hizmetiçi Eğitimi Kayıt Edilmiştir", "Hizmetiçi Eğitimi Kayıt Onayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception error)
            {
                XtraMessageBox.Show("Hizmetiçi Eğitimi Kayıt Edilemedi:" + error.Message, "Hizmetiçi Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

    }
    public class HizmetIciEgitimDetailForm : DetailEditForm<HizmetIciEgitim> { }
}