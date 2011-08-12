using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PersonelEgitimForm : MDIChildForm
    {
        public PersonelEgitim PersonelEgitim { get; set; }

        public bool IsOK { get; set; }

        private Personel _Personel;

        private PersonelEgitimForm()
        {
            InitializeComponent();
        }

        public PersonelEgitimForm(Personel personel, int personelEgitimID) : this()
        {
            if (personel == null)
            {
                IsOK = false;
                Close();
            }
            _Personel = personel;

            LoadLookUps();
            LoadRecord(personelEgitimID);
        }

        private void LoadRecord(int recordID)
        {
            if (recordID == 0)
            {
                PersonelEgitim = PersonelServices.CreateNewPersonelEgitim();
                PersonelEgitim.Personel = _Personel;
            }
            else
                PersonelEgitim = LookUpServices.GetByID<PersonelEgitim>(Session, recordID);

            InitBindings();
        }

        private void InitBindings()
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

        private void Save()
        {

        }

        private void sbCancel_Click(object sender, System.EventArgs e)
        {
            IsOK = false;
            Close();
        }

    }
}