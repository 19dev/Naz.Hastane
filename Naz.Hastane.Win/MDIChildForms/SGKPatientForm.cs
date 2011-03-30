using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SGKPatientForm : MDIChildForm
    {
        private Patient _Patient;
        private Doctor _Doctor;
        private bool _IsWaitingForPolyclinic = false;

        public SGKPatientForm()
        {
            InitializeComponent();
        }
        public SGKPatientForm(Patient aPatient)
        {
            _Patient = aPatient;
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
            this.lueStatus.Properties.DataSource = LookUpServices.PatientRelations;
            this.lueInsuranceType.Properties.DataSource = LookUpServices.InsuranceTypes;
            this.lueNationality.Properties.DataSource = LookUpServices.Nationalities;
            this.lueHomeCity.Properties.DataSource = LookUpServices.Cities;
            this.lueJobCity.Properties.DataSource = LookUpServices.Cities;
        }

        private void InitBindings()
        {
            LoadLookUps();
            this.tePatientNo.DataBindings.Add("EditValue", _Patient, "PatientNo");
            this.teInsuranceCompany.DataBindings.Add("EditValue", _Patient, "InsuranceCompany");
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
            //_patient.FirstName = "aa";
            //_patient.LastName = "aa";
            //_patient.Sex = "1";
            //_patient.MaritalStatus = "1";
            //_patient.BirthDate = DateTime.Now;
            //_patient.CanBeBloodDonour = '1';
            //_patient.MedControl = '1';
            //_patient.InsuranceCompany = "aa";
            //_patient.PatientContribution = '1';
            //_patient.PatientLimit = 1000;
            //_patient.USER_ID = "aa";
            //_patient.DATE_CREATE = DateTime.Now;
            //_patient.DATE_UPDATE = DateTime.Now;

            PatientServices.SavePatient(_Patient);
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
                CallMedulaProvision();
                PatientServices.AddSGKPolyclinic(this._Patient, this._Doctor);
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

        private void medulaSorgu_OnMedulaHastaKabulCompleted(object sender, Medula.HastaKabulIslemleri.hastaKabulCompletedEventArgs e)
        {
            //MessageBox.Show(e.Result.sonucKodu + ": " + e.Result.sonucMesaji, "Medula Sorgu Sonucu");
            if (_IsWaitingForPolyclinic)
            {
                _IsWaitingForPolyclinic = false;
                if (e.Result.sonucKodu == "0000")
                    PatientServices.AddSGKPolyclinic(this._Patient, this._Doctor);
            }
        }


    }
}