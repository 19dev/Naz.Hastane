using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PersonelEgitimForm : MDIChildForm
    {
        public bool IsOK { get; set; }
        private Personel _Personel;

        private PersonelEgitim _PersonelEgitim = null;

        public PersonelEgitim PersonelEgitim
        {
            get { return _PersonelEgitim; }
            set
            {
                if (_PersonelEgitim != value)
                {
                    _PersonelEgitim = value;
                    InitPersonelEgitimBindings();
                }
            }
        }

        private PersonelEgitimForm()
        {
            InitializeComponent();
            LoadLookUps();
        }

        public PersonelEgitimForm(Personel personel, int personelEgitimID) : this()
        {
            IsOK = false;
            if (personel == null)
                Close();

            _Personel = personel;

            PersonelEgitim personelEgitim = LookUpServices.GetByID<PersonelEgitim>(Session, personelEgitimID);
            if (personelEgitim == null)
            {
                personelEgitim = PersonelServices.CreateNewPersonelEgitim();
                personelEgitim.Personel = _Personel;
            }

            PersonelEgitim = personelEgitim;
        }

        private void InitPersonelEgitimBindings()
        {
            UIUtilities.BindControl(cmbOkulTipi, PersonelEgitim, x => x.OkulTipi, propertyName: "SelectedItem");
            UIUtilities.BindControl(teOkulAdi, PersonelEgitim, x => x.OkulAdi);
            UIUtilities.BindControl(deBaslangicTarihi, PersonelEgitim, x => x.BaslangicTarihi);
            UIUtilities.BindControl(deBitisTarihi, PersonelEgitim, x => x.BitisTarihi);
            UIUtilities.BindControl(meAciklama, PersonelEgitim, x => x.Aciklama);
        }

        private void LoadLookUps()
        {
            UIUtilities.BindComboBox(cmbOkulTipi, LookUpServices.OkulTipis, displayMember: "Value", valueMember: "ID");
        }

        private bool Save()
        {
            if (String.IsNullOrWhiteSpace(PersonelEgitim.OkulAdi))
            {
                XtraMessageBox.Show("Lütfen Okul Adını Kontrol Ediniz", "Personel Eğitimi Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PersonelEgitim.BaslangicTarihi == null || PersonelEgitim.BitisTarihi == null || PersonelEgitim.BaslangicTarihi >= PersonelEgitim.BitisTarihi )
            {
                XtraMessageBox.Show("Lütfen Tarihleri Kontrol Ediniz", "Personel Eğitimi Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                LookUpServices.SaveOrUpdate(Session, PersonelEgitim);
                XtraMessageBox.Show("Personel Eğitimi Kayıt Edilmiştir", "Personel Eğitimi Kayıt Onayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception error)
            {
                XtraMessageBox.Show("Personel Eğitimi Kayıt Edilemedi:" + error.Message, "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void sbCancel_Click(object sender, System.EventArgs e)
        {
            IsOK = false;
            Close();
        }

        private void sbSaveAndClose_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                IsOK = true;
                Close();
            }
        }

        private void sbSaveAndNew_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                IsOK = true;
                PersonelEgitim personelEgitim = PersonelServices.CreateNewPersonelEgitim();
                personelEgitim.Personel = _Personel;

                PersonelEgitim = personelEgitim;
            }
        }

    }
}