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

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SGKPatientForm : MDIChildForm
    {
        private Patient _Patient;
        private Doctor _Doctor;
        private bool _IsWaitingForPolyclinic = false;
        private frmMain theMainForm;

        public SGKPatientForm()
        {
            InitializeComponent();
            theMainForm = (frmMain)this.MdiParent;
        }

        public SGKPatientForm(string aPatientID)
        {
            if (String.IsNullOrEmpty(aPatientID))
                _Patient = PatientServices.GetNewSGKPatient(Session);
            else
                _Patient = PatientServices.GetPatientByID(aPatientID, Session);

            InitializeComponent();

            //insuranceTypes = LookUpServices.GetAll<InsuranceType>();

            InitBindings();

            this.gcIslemler.DataSource = _Patient.PatientVisits;

            this.medulaSorgu.lueProvisionType.EditValue = "N";
            this.medulaSorgu.lueInsuranceType.EditValue = "1";
            this.medulaSorgu.lueTransferorInstitution.EditValue = "1";
            this.medulaSorgu.lueBranchCode.EditValue = "N";
            this.medulaSorgu.lueTreatmentType.EditValue = "0";
            this.medulaSorgu.lueRelationType.EditValue = "0";
            this.medulaSorgu.lueFollowUpType.EditValue = "N";
            this.medulaSorgu.lueTreatmentStyle.EditValue = "A";

        }

        private void LoadLookUps()
        {
            UIUtilities.BindLookUpEdit(this.lueStatus, LookUpServices.PatientRelations);
            UIUtilities.BindLookUpEdit(this.lueInsuranceType, LookUpServices.InsuranceTypes);
            UIUtilities.BindLookUpEdit(this.lueNationality, LookUpServices.Nationalities);
            UIUtilities.BindLookUpEdit(this.lueHomeCity, LookUpServices.Cities);
            UIUtilities.BindLookUpEdit(this.lueJobCity, LookUpServices.Cities);
        }

        private void InitBindings()
        {
            LoadLookUps();
            this.tePatientNo.DataBindings.Add("EditValue", _Patient, "PatientNo");
            //this.teInsuranceCompany.DataBindings.Add("EditValue", _Patient, "InsuranceCompany.Name");
            if (this._Patient.InsuranceCompany != null)
                this.teInsuranceCompany.Text = this._Patient.InsuranceCompany.Name;

            this.teTCID.DataBindings.Add("EditValue", _Patient, "TCId");
            this.teFirstName.DataBindings.Add("EditValue", _Patient, "FirstName");
            this.teLastName.DataBindings.Add("EditValue", _Patient, "LastName");
            this.rgSex.DataBindings.Add("EditValue", _Patient, "Sex");
            this.rgMaritalStatus.DataBindings.Add("EditValue", _Patient, "MaritalStatus");
            this.teFatherName.DataBindings.Add("EditValue", _Patient, "FatherName");
            this.teMotherName.DataBindings.Add("EditValue", _Patient, "MotherName");
            this.teBirthPlace.DataBindings.Add("EditValue", _Patient, "BirthPlace");
            this.deBirthDate.DataBindings.Add("EditValue", _Patient, "BirthDate");
            this.lueStatus.DataBindings.Add("EditValue", _Patient, "Status");
            this.lueInsuranceType.DataBindings.Add("EditValue", _Patient, "InsuranceType");
            this.medulaSorgu.lueInsuranceType.DataBindings.Add("EditValue", _Patient, "InsuranceType");
            this.teHomePhone2.DataBindings.Add("EditValue", _Patient, "HomePhone2");
            this.teHomePhone1.DataBindings.Add("EditValue", _Patient, "HomePhone1");

            this.rgIDType.DataBindings.Add("EditValue", _Patient, "IDType");
            this.teIDNO.DataBindings.Add("EditValue", _Patient, "IDNO");
            this.deIDDate.DataBindings.Add("EditValue", _Patient, "IDDate");
            this.teIDPlace.DataBindings.Add("EditValue", _Patient, "IDPlace");
            this.lueNationality.DataBindings.Add("EditValue", _Patient, "Nationality");
            this.teHomeAddress.DataBindings.Add("EditValue", _Patient, "HomeAddress");
            this.teHomeDistrict.DataBindings.Add("EditValue", _Patient, "HomeDistrict");
            this.teHomeTown.DataBindings.Add("EditValue", _Patient, "HomeTown");
            this.teHomePostCode.DataBindings.Add("EditValue", _Patient, "HomePostCode");
            this.lueHomeCity.DataBindings.Add("EditValue", _Patient, "HomeCity");

            this.teOfficer.DataBindings.Add("EditValue", _Patient, "Officer");
            this.teProfession.DataBindings.Add("EditValue", _Patient, "Profession");
            this.teEMSNo.DataBindings.Add("EditValue", _Patient, "EMSNO");
            this.teProtocolNo.DataBindings.Add("EditValue", _Patient, "ProtocolNo");
            this.teBAGNO.DataBindings.Add("EditValue", _Patient, "BAGNO");
            this.teSSKSicilNo.DataBindings.Add("EditValue", _Patient, "YKARTNO");
            this.teSevkEdilenYer.DataBindings.Add("EditValue", _Patient, "GELHAST");
            this.lueSigortaMudurlugu.DataBindings.Add("EditValue", _Patient, "SIGMUD");
            this.teNufusaKayitliIl.DataBindings.Add("EditValue", _Patient, "RegisteredCity");
            this.teNufusaKayitliIlce.DataBindings.Add("EditValue", _Patient, "RegisteredTown");
            this.teSigortaliKartNo.DataBindings.Add("EditValue", _Patient, "SIGORTALIKARTNO");

            this.teJobName.DataBindings.Add("EditValue", _Patient, "JobName");
            this.teJobNo.DataBindings.Add("EditValue", _Patient, "JobNo");
            this.meJobAddress.DataBindings.Add("EditValue", _Patient, "JobAddress");
            this.lueJobCity.DataBindings.Add("EditValue", _Patient, "JobCity");
            this.teJobPostCode.DataBindings.Add("EditValue", _Patient, "JobPostCode");
            this.teJobPhone1.DataBindings.Add("EditValue", _Patient, "JobPhone1");
            this.teJobPhone2.DataBindings.Add("EditValue", _Patient, "JobPhone2");
            this.teJobFax.DataBindings.Add("EditValue", _Patient, "JobFax");
            this.teEmail.DataBindings.Add("EditValue", _Patient, "Email");

        }

        private void sbKaydet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(_Patient.FirstName))
            {
                XtraMessageBox.Show("Lütfen Hastanın Adını Kontrol Ediniz", "Hasta Kayıt Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(_Patient.LastName))
            {
                XtraMessageBox.Show("Lütfen Hastanın Soyadını Kontrol Ediniz", "Hasta Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_Patient.BirthDate == null)
            {
                XtraMessageBox.Show("Lütfen Hastanın Doğum Tarihini Kontrol Ediniz", "Hasta Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Patient.PatientLimit = 0;
            _Patient.USER_ID = "aa";
            _Patient.DATE_CREATE = DateTime.Now;
            _Patient.DATE_UPDATE = DateTime.Now;

            try
            {
                PatientServices.SavePatient(_Patient);
            }
            catch (Exception error)
            {
                XtraMessageBox.Show("Hasta Kayıt Edilemedi:" + error.Message, "Hasta Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region GridBindings
        private void gvZiyaret_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            PatientVisit pv = (PatientVisit)gvZiyaret.GetRow(e.RowHandle);
            //e.IsEmpty = pv.PatientVisitDetails.Count == 0;
        }

        private void gvZiyaret_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gvZiyaret_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "PatientVisitDetails";
        }

        private void gvZiyaret_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            PatientVisit pv = (PatientVisit)gvZiyaret.GetRow(e.RowHandle);
            e.ChildList = new BindingSource(pv, "PatientVisitDetails");
        }

        private void gvZiyaret_MasterRowGetLevelDefaultView(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs e)
        {
            e.DefaultView = gvIslemler;
        }
        #endregion

        private void sbPoliklinik_Click(object sender, EventArgs e)
        {
            SelectPolyclinicForm frm = new SelectPolyclinicForm();
            frm.ShowDialog();
            if (frm.IsSelected && frm.Doctor != null)
                ProcessNewPolyclinic(frm.Doctor);
        }

        private void ProcessNewPolyclinic(Doctor doctor)
        {
            if (_IsWaitingForPolyclinic)
            {
                XtraMessageBox.Show("Şu anda sürmekte olan Provizyon işlemi var. Lütfen bekleyiniz.", "Poliklinik İşlemleri");
                // Should cancel the previous request?
            }
            else
            {
                _IsWaitingForPolyclinic = true;
                _Doctor = doctor;
                //CallMedulaProvision();
                PatientServices.AddSGKPolyclinic(Session, UIUtilities.CurrentUser, this._Patient, this._Doctor);
            }

        }

        private void sbMernis_Click(object sender, EventArgs e)
        {
            this.mernisSorgu.CallMernis(this.teTCID.Text);
        }

        private void sbMedula_Click(object sender, EventArgs e)
        {
            CallMedulaProvision();
        }

        private void CallMedulaProvision()
        {
            if (this._Doctor == null)
                return;
            this.medulaSorgu.lueBranchCode.EditValue = _Doctor.Service.BranchCode;
            this.medulaSorgu.CallMedula(this.teTCID.Text);
        }

        private void medulaSorgu_OnMedulaHastaKabulCompleted(object sender, MedulaProvisionCompletedEventArgs e)
        {
            XtraMessageBox.Show(e.Result.SonucKodu + ": " + e.Result.SonucMesaji, "Medula Sorgu Sonucu");
            
            _IsWaitingForPolyclinic = false;

            if (e.Result.SonucKodu == "0000")
            {
                PatientServices.AddSGKPolyclinic(Session, UIUtilities.CurrentUser, this._Patient, this._Doctor);
                PatientServices.UpdatePatientRecordsFromMedula(Session, UIUtilities.CurrentUser, this._Patient, e.Result);
            }
            else
            {
                if (XtraMessageBox.Show("Medula'dan Cevap Alınamadı, Poliklinik Kaydı Oluşturmak İstiyor Musunuz?", "Medula Sorgu Sonucu",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    PatientServices.AddSGKPolyclinic(Session, UIUtilities.CurrentUser, this._Patient, this._Doctor);
            }

        }

        private void sbInvoice_Click(object sender, EventArgs e)
        {
            string NewTellerInvoiceNo = LookUpServices.GetNewTellerInvoiceNo(UIUtilities.CurrentUser, false);
            string paymentType = "N";
            string POSType = null;

            double ProductTotal = 0;
            double VATTotal = 0;
            double InvoiceTotal = 0;
            double VATPercent = 0;
            double Payment = 0;

            IList<PatientVisit> pvs = _Patient.PatientVisits;
            PatientVisit pv = null;
            IList<PatientVisitDetail> pvds = new List<PatientVisitDetail>();
            if (pvs.Count > 0)
            {
                pv = pvs[0];
            }
            foreach(PatientVisitDetail pvd in pv.PatientVisitDetails)
            {
                if (pvd.CODE != "SGKKATILIM")
                {
                    pvds.Add(pvd);
                    ProductTotal += pvd.ADET * pvd.SATISF;
                    VATPercent = pvd.KDV;
                }
            }
            VATPercent = Math.Round(VATPercent, 2);
            VATTotal = Math.Round(ProductTotal * VATPercent / 100.0, 2);
            InvoiceTotal = Math.Round(ProductTotal * (1 + VATPercent / 100.0), 2);

            if (pv != null && pvds != null && pvds.Count > 0 && theMainForm != null)
            {
                theMainForm.PrintInvoice(Session, _Patient, pv, pvds,
                    paymentType, POSType,
                    ProductTotal,
                    VATTotal,
                    InvoiceTotal,
                    0,
                    VATPercent,
                    Payment,
                    0,
                    NewTellerInvoiceNo
                    );
            }
        }

        private void sbVoucher_Click(object sender, EventArgs e)
        {
            string NewTellerVoucherNo = LookUpServices.GetNewTellerVoucherNo(UIUtilities.CurrentUser, false);
            string paymentType = "N";
            string POSType = null;

            double ProductTotal = 0;
            double VATTotal = 0;
            double InvoiceTotal = 0;
            double VATPercent = 0;
            double Payment = 0;

            IList<PatientVisit> pvs = _Patient.PatientVisits;
            PatientVisit pv = null;
            IList<PatientVisitDetail> pvds = new List<PatientVisitDetail>();
            if (pvs.Count > 0)
            {
                pv = pvs[0];
            }
            foreach (PatientVisitDetail pvd in pv.PatientVisitDetails)
            {
                if (pvd.CODE == "SGKKATILIM")
                {
                    pvds.Add(pvd);
                    ProductTotal += pvd.ADET * pvd.SATISF;
                    VATPercent = pvd.KDV;
                }
            }
            VATPercent = Math.Round(VATPercent, 2);
            VATTotal = Math.Round(ProductTotal * VATPercent / 100.0, 2);
            InvoiceTotal = Math.Round(ProductTotal * (1 + VATPercent / 100.0), 2);

            if (pv != null && pvds != null && pvds.Count > 0 && theMainForm != null)
            {
                theMainForm.PrintVoucher(Session, _Patient, pvds,
                    paymentType, POSType,
                    InvoiceTotal,
                    NewTellerVoucherNo
                    );
            }
        }

        private void mernisSorgu_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (this.mernisSorgu.IsOK)
            {
                _Patient.FirstName = this.mernisSorgu.NufusCuzdani.Ad;
                _Patient.LastName = this.mernisSorgu.NufusCuzdani.Soyad;
                _Patient.MotherName = this.mernisSorgu.NufusCuzdani.AnaAd;
                _Patient.FatherName = this.mernisSorgu.NufusCuzdani.BabaAd;
                if (this.mernisSorgu.KisiBilgisi.TemelBilgisi.Cinsiyet == CinsiyetTipi.Erkek)
                    _Patient.Sex = "1";
                else 
                    _Patient.Sex = "2";
                _Patient.BirthDate = new DateTime(this.mernisSorgu.NufusCuzdani.DogumTarih.Yil,
                    this.mernisSorgu.NufusCuzdani.DogumTarih.Ay,
                    this.mernisSorgu.NufusCuzdani.DogumTarih.Gun);
                _Patient.BirthPlace = this.mernisSorgu.NufusCuzdani.DogumYer;

                if (this.mernisSorgu.KisiBilgisi.DurumBilgisi.MedeniHal == MedeniHalTipi.Evli)
                    _Patient.MaritalStatus = "E";
                else
                    _Patient.MaritalStatus = "B";

                _Patient.RegisteredCity = this.mernisSorgu.TCKimlikResponse.IlAd;
                _Patient.RegisteredTown = this.mernisSorgu.TCKimlikResponse.IlceAd;
                _Patient.IDPlace = this.mernisSorgu.NufusCuzdani.VerildigiIlceAd;
                _Patient.IDDate = new DateTime(this.mernisSorgu.NufusCuzdani.VerilmeTarih.Yil,
                    this.mernisSorgu.NufusCuzdani.VerilmeTarih.Ay,
                    this.mernisSorgu.NufusCuzdani.VerilmeTarih.Gun).ToString();
                _Patient.IDNO = this.mernisSorgu.NufusCuzdani.CuzdanSeri + "-" + this.mernisSorgu.NufusCuzdani.CuzdanNo;
            }
        }

    }
}