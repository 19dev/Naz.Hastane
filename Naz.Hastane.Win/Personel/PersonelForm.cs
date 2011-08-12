using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data.Entities.Medula;
using Naz.Hastane.Win.Controls;
using Naz.Hastane.Reports;
using Naz.Utilities.Classes;
using System.Collections.Generic;
using Naz.Mernis.Service;
using DevExpress.XtraGrid.Views.Grid;
using Naz.Hastane.Reports.Classes;
using Naz.Hastane.Data.Entities.LookUp.MedulaProvision;
using System.Drawing;
using NHibernate;
using Naz.Hastane.Data.DTO;
using Naz.Hastane.Win.Utilities;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PersonelForm : MDIChildForm
    {
        private Personel _Personel = null;

        public Personel Personel
        {
            get { return _Personel; }
            set
            {
                if (_Personel != value) 
                {
                    _Personel = value;
                    //LoadSubLists();
                }
            }
        }

        private PersonelForm()
        {
            InitializeComponent();
        }

        public PersonelForm(int ID) : this()
        {
            Personel = PersonelServices.GetPersonelByID(ID, Session);
            if (Personel == null)
                Personel = PersonelServices.CreateNewPersonel();
            InitBindings();            
        }

        private void InitBindings()
        {
            LoadLookUps();

            UIUtilities.BindControl(tePersonelNo, Personel, x => x.PersonelNo);
            UIUtilities.BindControl(teTCID, Personel, x => x.TCID);
            UIUtilities.BindControl(teFirstName, Personel, x => x.Ad);
            UIUtilities.BindControl(teSurname, Personel, x => x.Soyad);
            UIUtilities.BindControl(ceEmekli, Personel, x => x.IsRetired);
            UIUtilities.BindControl(ceSendikali, Personel, x => x.HasUnion);
            UIUtilities.BindControl(lueNationality, Personel, x => x.Uyrugu);
            UIUtilities.BindControl(rgSex, Personel, x => x.Cinsiyeti);
            UIUtilities.BindControl(rgMaritalStatus, Personel, x => x.MedeniHali);
            UIUtilities.BindControl(tePhone, Personel, x => x.Telefon);
            UIUtilities.BindControl(teHomeTown, Personel, x => x.Ilce);
            UIUtilities.BindControl(lueHomeCity, Personel, x => x.Il);
            //UIUtilities.BindControl(lueBloodType, Personel, x => x.KanGrubu);
            
            UIUtilities.BindControl(cmbBloodType, Personel, x => x.KanGrubu, propertyName: "SelectedItem");
            UIUtilities.BindControl(cmbHastaneBolumu, Personel, x => x.HastaneBolumu, propertyName: "SelectedItem");
            UIUtilities.BindControl(cmbPersonelUnvani, Personel, x => x.PersonelUnvani, propertyName: "SelectedItem");
            
            UIUtilities.BindControl(deEntryDate, Personel, x => x.IseGirisTarihi);
            UIUtilities.BindControl(deExitDate, Personel, x => x.AyrilisTarihi);
            UIUtilities.BindControl(teInsuranceNo, Personel, x => x.SigortaNo);
            UIUtilities.BindControl(teTaxNo, Personel, x => x.VergiNo);
            
            UIUtilities.BindControl(rgIDType, Personel, x => x.KimlikTuru);
            UIUtilities.BindControl(teIDNo, Personel, x => x.KimlikNo);
            UIUtilities.BindControl(teFatherName, Personel, x => x.BabaAdi);
            UIUtilities.BindControl(teMotherName, Personel, x => x.AnaAdi);
            UIUtilities.BindControl(teBirthPlace, Personel, x => x.DogumYeri);
            UIUtilities.BindControl(deBirthDate, Personel, x => x.DogumTarihi);
            UIUtilities.BindControl(lueBirthCity, Personel, x => x.DogumIli);
            UIUtilities.BindControl(teBirthTown, Personel, x => x.DogumIlcesi);
            UIUtilities.BindControl(teBirthDistrict, Personel, x => x.DogumMahalleKoy);
            UIUtilities.BindControl(teCilt, Personel, x => x.DogumCilt);
            UIUtilities.BindControl(teAileSiraNo, Personel, x => x.DogumAileSiraNo);
            UIUtilities.BindControl(teSiraNo, Personel, x => x.DogumSiraNo);

            UIUtilities.BindControl(meExplanation, Personel, x => x.Aciklama);
            
        }

        private void LoadLookUps()
        {            
            UIUtilities.BindLookUpEdit(this.lueHomeCity, LookUpServices.Cities, displayMember: "Value", valueMember: "Code");
            UIUtilities.BindLookUpEdit(this.lueBirthCity, LookUpServices.Cities, displayMember: "Value", valueMember: "Code");
            UIUtilities.BindLookUpEdit(this.lueNationality, LookUpServices.Nationalities);

            UIUtilities.BindComboBox(cmbBloodType, LookUpServices.BloodTypes, displayMember: "Value", valueMember: "ID");
            UIUtilities.BindComboBox(cmbHastaneBolumu, LookUpServices.HastaneBolumus, displayMember: "Value", valueMember: "ID");
            UIUtilities.BindComboBox(cmbPersonelUnvani, LookUpServices.PersonelUnvanis, displayMember: "Value", valueMember: "ID");
            //UIUtilities.BindComboBox(this.comboBox1, LookUpServices.BloodTypes, displayMember: "Value", valueMember: "ID");
        }

        private void sbSavePersonel_Click(object sender, EventArgs e)
        {
            SavePersonel();
        }

        private void SavePersonel()
        {
            if (String.IsNullOrWhiteSpace(Personel.Ad))
            {
                XtraMessageBox.Show("Lütfen Personelin Adını Kontrol Ediniz", "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(Personel.Soyad))
            {
                XtraMessageBox.Show("Lütfen Personelin Soyadını Kontrol Ediniz", "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                Personel.IsRetired = ceEmekli.EditValue.ToString();
                Personel.HasUnion = ceSendikali.EditValue.ToString();
                PersonelServices.SavePersonel(Session, Personel);
                XtraMessageBox.Show("Personel Kayıt Edilmiştir", "Personel Kayıt Onayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                XtraMessageBox.Show("Personel Kayıt Edilemedi:" + error.Message, "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenNewForm()
        {
            //(this.MdiParent as frmMain).OpenPersonel(Personel.PersonelNo);
            this.Close();
        }      

        private void sbClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            this.Close();
        }                  

        private void PersonelForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
                CloseForm();
            else if (e.KeyCode == Keys.F5)
                SavePersonel();
        }

        public void SetNewTCID(string TCID)
        {
            this.teTCID.Text = TCID;
        }

    }
}