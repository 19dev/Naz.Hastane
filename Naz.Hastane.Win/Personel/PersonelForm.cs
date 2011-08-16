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
        private PersonelForm()
        {
            InitializeComponent();
            LoadLookUps();
        }

        public PersonelForm(int ID) : this()
        {
            Personel personel = PersonelServices.GetPersonelByID(ID, Session);
            if (personel == null)
                personel = PersonelServices.CreateNewPersonel();

            Personel = personel;
        }

        #region Personel
        private Personel _Personel = null;

        public Personel Personel
        {
            get { return _Personel; }
            set
            {
                if (_Personel != value)
                {
                    _Personel = value;
                    InitPersonelBindings();
                }
            }
        }

        private void ReLoadPersonel()
        {
            int id = Personel.ID;
            _Personel = null;

            ReOpenSession();
            Personel = PersonelServices.GetPersonelByID(id, Session);
        }

        private void InitPersonelBindings()
        {
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

            gcPersonelEgitim.DataSource = Personel.PersonelEgitims;
            gcHastaneBolumu.DataSource = Personel.PersonelHastaneBolumus;
            gcIzinler.DataSource = Personel.PersonelIzins;
            gcRaporlar.DataSource = Personel.PersonelRapors;
            gcSertifikalar.DataSource = Personel.PersonelSertifikas;
            gcYabanciDil.DataSource = Personel.PersonelYabanciDils;
            
        }

        private void LoadLookUps()
        {
            UIUtilities.BindLookUpEdit(this.lueHomeCity, LookUpServices.Cities, displayMember: "Value", valueMember: "Code");
            UIUtilities.BindLookUpEdit(this.lueBirthCity, LookUpServices.Cities, displayMember: "Value", valueMember: "Code");
            UIUtilities.BindLookUpEdit(this.lueNationality, LookUpServices.Nationalities);

            UIUtilities.BindComboBox(cmbBloodType, LookUpServices.BloodTypes, displayMember: "Value", valueMember: "ID");
            UIUtilities.BindComboBox(cmbHastaneBolumu, LookUpServices.HastaneBolumus, displayMember: "Value", valueMember: "ID");
            UIUtilities.BindComboBox(cmbPersonelUnvani, LookUpServices.PersonelUnvanis, displayMember: "Value", valueMember: "ID");
        }

        public void SetNewTCID(string TCID)
        {
            this.teTCID.Text = TCID;
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
                LookUpServices.SaveOrUpdate(Session, Personel);
                ReLoadPersonel();
                XtraMessageBox.Show("Personel Kayıt Edilmiştir", "Personel Kayıt Onayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                XtraMessageBox.Show("Personel Kayıt Edilemedi:" + error.Message, "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void sbClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            Close();
        }                  

        private void PersonelForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
                CloseForm();
            else if (e.KeyCode == Keys.F5)
                SavePersonel();
        }

        #region PersonelEgitim
        private void sbAddPersonelEgitim_Click(object sender, EventArgs e)
        {
            Add<PersonelEgitimEditForm, PersonelEgitim>();
        }

        private void sbChangePersonelEgitim_Click(object sender, EventArgs e)
        {
            Change<PersonelEgitimEditForm, PersonelEgitim>(gvPersonelEgitim);
        }

        private void sbDeletePersonelEgitim_Click(object sender, EventArgs e)
        {
            Delete<PersonelEgitim>(gvPersonelEgitim, "Personel Eğitimi Silinmiştir.",
                "Personel Eğitimi Silinemedi:", "Personel Eğitimi Silme İşlemi");
        }

        #endregion

        #region HastaneBolumu
        private void sbAddHastaneBolumu_Click(object sender, EventArgs e)
        {
            Add<PersonelHastaneBolumuEditForm, PersonelHastaneBolumu>();
        }

        private void sbChangeHastaneBolumu_Click(object sender, EventArgs e)
        {
            Change<PersonelHastaneBolumuEditForm, PersonelHastaneBolumu>(gvHastaneBolumu);
        }

        private void sbDeleteHastaneBolumu_Click(object sender, EventArgs e)
        {
            Delete<PersonelHastaneBolumu>(gvHastaneBolumu, "Personel Hastane Bölümü Kaydı Silinmiştir.", 
                "Personel Hastane Bölümü Kaydı Silinemedi:", "Personel Hastane Bölümü Kaydı Silme İşlemi");
        }
        #endregion

        #region Personelİzin
        private void sbAddPersonelIzin_Click(object sender, EventArgs e)
        {
            Add<PersonelIzinEditForm, PersonelIzin>();
        }

        private void sbChangePersonelIzin_Click(object sender, EventArgs e)
        {
            Change<PersonelIzinEditForm, PersonelIzin>(gvIzinler);
        }

        private void sbDeletePersonelIzin_Click(object sender, EventArgs e)
        {
            Delete<PersonelIzin>(gvIzinler, "Personel İzni Silinmiştir.",
                "Personel İzni Silinemedi:", "Personel İzni Silme İşlemi");
        }
        #endregion

        #region PersonelRapor
        private void sbAddPersonelRapor_Click(object sender, EventArgs e)
        {
            Add<PersonelRaporEditForm, PersonelRapor>();
        }

        private void sbChangePersonelRapor_Click(object sender, EventArgs e)
        {
            Change<PersonelRaporEditForm, PersonelRapor>(gvRaporlar);
        }

        private void sbDeletePersonelRapor_Click(object sender, EventArgs e)
        {
            Delete<PersonelRapor>(gvHastaneBolumu, "Personel Raporu Silinmiştir.",
                "Personel Raporu Silinemedi:", "Personel Raporu Silme İşlemi");
        }
        #endregion

        #region PersonelSertifika
        private void sbAddPersonelSertifika_Click(object sender, EventArgs e)
        {
            Add<PersonelSertifikaEditForm, PersonelSertifika>();
        }

        private void sbChangePersonelSertifika_Click(object sender, EventArgs e)
        {
            Change<PersonelSertifikaEditForm, PersonelSertifika>(gvSertifikalar);
        }

        private void sbDeletePersonelSertifika_Click(object sender, EventArgs e)
        {
            Delete<PersonelSertifika>(gvHastaneBolumu, "Personel Sertifika Kaydı Silinmiştir.",
                "Personel Sertifika Kaydı Silinemedi:", "Personel Sertifika Kaydı Silme İşlemi");
        }
        #endregion

        #region Yabancı Dil
        private void sbAddPersonelYabanciDil_Click(object sender, EventArgs e)
        {
            Add<PersonelYabanciDilEditForm, PersonelYabanciDil>();
        }

        private void sbChangePersonelYabanciDil_Click(object sender, EventArgs e)
        {
            Change<PersonelYabanciDilEditForm, PersonelYabanciDil>(gvYabanciDil);
        }

        private void sbDeletePersonelYabanciDil_Click(object sender, EventArgs e)
        {
            Delete<PersonelYabanciDil>(gvYabanciDil, "Personel Yabancı Dil Kaydı Silinmiştir.",
                "Personel Yabancı Dil Kaydı Silinemedi:", "Personel Yabancı Dil Kaydı Silme İşlemi");
        }

        #endregion

        #region DetailTemplates
        private void Add<TForm, T>()
            where TForm : PersonelDetailEditForm<T>, new()
            where T : PersonelDetail, new()
        {
            using (TForm frm = new TForm())
            {
                frm.DetailFormParams(Personel, 0);
                frm.ShowDialog();
                if (frm.IsOK)
                    ReLoadPersonel();
            }
        }

        private void Change<TForm, T>(GridView gv)
            where TForm : PersonelDetailEditForm<T>, new()
            where T : PersonelDetail, new()
        {
            T o = gv.GetFocusedRow() as T;
            if (o != null)
                using (TForm frm = new TForm())
                {
                    frm.DetailFormParams(Personel, o.ID);
                    frm.ShowDialog();
                    if (frm.IsOK)
                        ReLoadPersonel();
                }
        }

        private void Delete<TObject>(GridView gv, string deleteSuccesful, string deleteFail, string msgCaption) where TObject : IDBase
        {
            TObject o = gv.GetFocusedRow() as TObject;
            if (o != null)
            {
                try
                {
                    LookUpServices.Delete(Session, o);
                    ReLoadPersonel();
                    XtraMessageBox.Show(deleteSuccesful, msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    XtraMessageBox.Show(deleteFail + error.Message, msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

    }
}