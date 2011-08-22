using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PersonelForm : MDIChildForm
    {
        private PersonelForm()
        {
            InitializeComponent();
            LoadLookUps();
            AttachEventHandlers();
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

        protected override void ReLoadForm()
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
            UIUtilities.BindControl(teHomePhone, Personel, x => x.EvTelefonu);
            UIUtilities.BindControl(teMobilePhone, Personel, x => x.CepTelefonu);
            UIUtilities.BindControl(teHomeAddress, Personel, x => x.EvAdresi);
            UIUtilities.BindControl(teHomeDistrict, Personel, x => x.Mahalle);
            UIUtilities.BindControl(teHomeTown, Personel, x => x.Ilce);
            UIUtilities.BindControl(lueHomeCity, Personel, x => x.Il);
            UIUtilities.BindControl(teEmail, Personel, x => x.Email);

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

            gcHastaneBolumu.DataSource = Personel.PersonelHastaneBolumus;
            gcUnvanlar.DataSource = Personel.PersonelUnvans;
            gcPersonelEgitim.DataSource = Personel.PersonelEgitims;
            gcHizmetIciEgitim.DataSource = Personel.PersonelHizmetIciEgitims;
            gcRaporlar.DataSource = Personel.PersonelRapors;
            gcIzinler.DataSource = Personel.PersonelIzins;
            gcYabanciDil.DataSource = Personel.PersonelYabanciDils;
            gcSertifikalar.DataSource = Personel.PersonelSertifikas;
            
        }

        private void LoadLookUps()
        {
            UIUtilities.BindLookUpEdit(this.lueHomeCity, LookUpServices.Cities, displayMember: "Value", valueMember: "Code");
            UIUtilities.BindLookUpEdit(this.lueBirthCity, LookUpServices.Cities, displayMember: "Value", valueMember: "Code");
            UIUtilities.BindLookUpEdit(this.lueNationality, LookUpServices.Nationalities);

            UIUtilities.BindComboBox(cmbBloodType, LookUpServices.BloodTypes, x => x.Value, x => x.ID);
            UIUtilities.BindComboBox(cmbHastaneBolumu, LookUpServices.HastaneBolumus, x => x.Value, x => x.ID);
            UIUtilities.BindComboBox(cmbPersonelUnvani, LookUpServices.Unvans, x => x.Value, x => x.ID);
        }

        public void SetNewTCID(string TCID)
        {
            Personel.TCID = TCID;
            //this.teTCID.Text = TCID;
        }

        private void sbSavePersonel_Click(object sender, EventArgs e)
        {
            SavePersonel();
        }

        private void SavePersonel()
        {
            if (String.IsNullOrWhiteSpace(Personel.TCID))
            {
                XtraMessageBox.Show("Lütfen Personelin T.C. Kimlik Numarasını Kontrol Ediniz", "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(Personel.PersonelNo))
            {
                XtraMessageBox.Show("Lütfen Personel Numarasını Kontrol Ediniz", "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            if (Personel.KanGrubu == null)
            {
                XtraMessageBox.Show("Lütfen Personelin Kan Grubunu Kontrol Ediniz", "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Personel.HastaneBolumu == null)
            {
                XtraMessageBox.Show("Lütfen Personelin Çalıştığı Bölümü Kontrol Ediniz", "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Personel.PersonelUnvani == null)
            {
                XtraMessageBox.Show("Lütfen Personelin Ünvanını Kontrol Ediniz", "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PersonelServices.GetPersonelByPersonelNo(Personel.PersonelNo).Count > 0)
            {
                XtraMessageBox.Show("Bu Personel No İle Kayıtlı Bir Personel Var! ", "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PersonelServices.GetPersonelByTCId(Personel.TCID).Count > 0)
            {
                XtraMessageBox.Show("Bu TC Kimlik No İle Kayıtlı Bir Personel Var! ", "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Personel.IsRetired = ceEmekli.EditValue.ToString();
                Personel.HasUnion = ceSendikali.EditValue.ToString();
                LookUpServices.SaveOrUpdate(Session, Personel);
                ReLoadForm();
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

        private void AttachEventHandlers()
        {
            sbAddPersonelHastaneBolumu.Click += (o, args) => AddDetail<PersonelHastaneBolumuEditForm, PersonelHastaneBolumu>();
            sbChangePersonelHastaneBolumu.Click += (o, args) => ChangeDetail<PersonelHastaneBolumuEditForm, PersonelHastaneBolumu>(gvHastaneBolumu);
            sbDeletePersonelHastaneBolumu.Click += (o, args) => DeleteDetail<PersonelHastaneBolumu>(gvHastaneBolumu, "Personel Hastane Bölümü Kaydı Silinmiştir.", 
                "Personel Hastane Bölümü Kaydı Silinemedi:", "Personel Hastane Bölümü Kaydı Silme İşlemi");

            sbAddPersonelUnvan.Click += (o, args) => AddDetail<PersonelUnvanEditForm, PersonelUnvan>();
            sbChangePersonelUnvan.Click += (o, args) => ChangeDetail<PersonelUnvanEditForm, PersonelUnvan>(gvUnvanlar);
            sbDeletePersonelUnvan.Click += (o, args) => DeleteDetail<PersonelUnvan>(gvUnvanlar, "Personel Ünvan Kaydı Silinmiştir.",
                "Personel Ünvan Kaydı Silinemedi:", "Personel Ünvan Kaydı Silme İşlemi");

            sbAddPersonelEgitim.Click += (o, args) => AddDetail<PersonelEgitimEditForm, PersonelEgitim>();
            sbChangePersonelEgitim.Click += (o, args) => ChangeDetail<PersonelEgitimEditForm, PersonelEgitim>(gvPersonelEgitim);
            sbDeletePersonelEgitim.Click += (o, args) => DeleteDetail<PersonelEgitim>(gvPersonelEgitim, "Personel Eğitimi Silinmiştir.",
                "Personel Eğitimi Silinemedi:", "Personel Eğitimi Silme İşlemi");

            sbAddPersonelHizmetIciEgitim.Click += (o, args) => AddDetail<PersonelHizmetIciEgitimEditForm, PersonelHizmetIciEgitim>();
            sbChangePersonelHizmetIciEgitim.Click += (o, args) => ChangeDetail<PersonelHizmetIciEgitimEditForm, PersonelHizmetIciEgitim>(gvHizmetIciEgitim);
            sbDeletePersonelHizmetIciEgitim.Click += (o, args) => DeleteDetail<PersonelHizmetIciEgitim>(gvHizmetIciEgitim, "Personel Hizmet İçi Eğitim Kaydı Silinmiştir.",
                "Personel Hizmet İçi Eğitim Kaydı Silinemedi:", "Personel Hizmet İçi Eğitim Kaydı Silme İşlemi");

            sbAddPersonelRapor.Click += (o, args) => AddDetail<PersonelRaporEditForm, PersonelRapor>();
            sbChangePersonelRapor.Click += (o, args) => ChangeDetail<PersonelRaporEditForm, PersonelRapor>(gvRaporlar);
            sbDeletePersonelRapor.Click += (o, args) => DeleteDetail<PersonelRapor>(gvRaporlar, "Personel Rapor Kaydı Silinmiştir.",
                "Personel Rapor Kaydı Silinemedi:", "Personel Rapor Kaydı Silme İşlemi");

            sbAddPersonelIzin.Click += (o, args) => AddDetail<PersonelIzinEditForm, PersonelIzin>();
            sbChangePersonelIzin.Click += (o, args) => ChangeDetail<PersonelIzinEditForm, PersonelIzin>(gvIzinler);
            sbDeletePersonelIzin.Click += (o, args) => DeleteDetail<PersonelIzin>(gvIzinler, "Personel İzin Kaydı Silinmiştir.",
                "Personel İzin Kaydı Silinemedi:", "Personel İzin Kaydı Silme İşlemi");

            sbAddPersonelYabanciDil.Click += (o, args) => AddDetail<PersonelYabanciDilEditForm, PersonelYabanciDil>();
            sbChangePersonelYabanciDil.Click += (o, args) => ChangeDetail<PersonelYabanciDilEditForm, PersonelYabanciDil>(gvYabanciDil);
            sbDeletePersonelYabanciDil.Click += (o, args) => DeleteDetail<PersonelYabanciDil>(gvYabanciDil, "Personel Yabancı Dil Kaydı Silinmiştir.",
                "Personel Yabancı Dil Kaydı Silinemedi:", "Personel Yabancı Dil Kaydı Silme İşlemi");

            sbAddPersonelSertifika.Click += (o, args) => AddDetail<PersonelSertifikaEditForm, PersonelSertifika>();
            sbChangePersonelSertifika.Click += (o, args) => ChangeDetail<PersonelSertifikaEditForm, PersonelSertifika>(gvSertifikalar);
            sbDeletePersonelSertifika.Click += (o, args) => DeleteDetail<PersonelSertifika>(gvSertifikalar, "Personel Sertifika Kaydı Silinmiştir.",
                "Personel Sertifika Kaydı Silinemedi:", "Personel Sertifika Kaydı Silme İşlemi");

        }

        #region DetailTemplates
        private new void AddDetail<TForm, T>()
            where TForm : PersonelDetailEditForm<T>, new()
            where T : PersonelDetail, new()
        {
            using (TForm frm = new TForm())
            {
                frm.DetailFormParams(Personel, 0);
                frm.ShowDialog();
                if (frm.IsOK)
                    ReLoadForm();
            }
        }

        private new void ChangeDetail<TForm, T>(GridView gv)
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
                        ReLoadForm();
                }
        }

        private new void DeleteDetail<TObject>(GridView gv, string deleteSuccesful, string deleteFail, string msgCaption) where TObject : IDBase
        {
            TObject o = gv.GetFocusedRow() as TObject;
            if (o != null)
            {
                try
                {
                    LookUpServices.Delete(Session, o);
                    ReLoadForm();
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