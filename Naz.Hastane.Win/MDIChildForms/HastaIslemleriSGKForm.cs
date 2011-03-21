using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using DevExpress.Tutorials.Controls;
using DevExpress.XtraEditors.Controls;
using DevExpress.LookAndFeel;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Entities.LookUp;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class HastaIslemleriSGKForm : MDIChildForm
    {
        private Patient _Patient;
        private Doctor _Doctor;
        private bool _IsWaitingForPolyclinic = false;

        public HastaIslemleriSGKForm()
        {
            InitializeComponent();
        }
        public HastaIslemleriSGKForm(Patient aPatient)
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
        private void InitBindings()
        {

            this.tePatientNo.DataBindings.Add("EditValue", _Patient, "PatientNo");
            this.teInsuranceCompany.DataBindings.Add("EditValue", _Patient, "InsuranceCompany");
            this.teTCKimlikNo.DataBindings.Add("EditValue", _Patient, "TCId");
            this.teFirstName.DataBindings.Add("EditValue", _Patient, "FirstName");
            this.teLastName.DataBindings.Add("EditValue", _Patient, "LastName");
            this.rgSex.DataBindings.Add("EditValue", _Patient, "Sex");
            this.rgMaritalStatus.DataBindings.Add("EditValue", _Patient, "MaritalStatus");
            this.teFatherName.DataBindings.Add("EditValue", _Patient, "FatherName");
            this.teMotherName.DataBindings.Add("EditValue", _Patient, "MotherName");
            this.teBirthPlace.DataBindings.Add("EditValue", _Patient, "BirthPlace");
            this.deBirthDate.DataBindings.Add("EditValue", _Patient, "BirthDate");
            BindLookUpEdit(this.lueStatus, _Patient, "Status", LookUpServices.PatientRelations);
            BindLookUpEdit(this.lueInsuranceType, _Patient, "InsuranceType", LookUpServices.InsuranceTypes);
            BindLookUpEdit(this.medulaSorgu.lueInsuranceType, _Patient, "InsuranceType", LookUpServices.InsuranceTypes);
            this.teHomePhone2.DataBindings.Add("EditValue", _Patient, "HomePhone2");
            this.teHomePhone1.DataBindings.Add("EditValue", _Patient, "HomePhone1");

            this.rgIDType.DataBindings.Add("EditValue", _Patient, "IDType");
            this.teIDNO.DataBindings.Add("EditValue", _Patient, "IDNO");
            this.deIDDate.DataBindings.Add("EditValue", _Patient, "IDDate");
            this.teIDPlace.DataBindings.Add("EditValue", _Patient, "IDPlace");
            BindLookUpEdit(this.lueNationality, _Patient, "Nationality", LookUpServices.Nationalities);
            this.teHomeAddress.DataBindings.Add("EditValue", _Patient, "HomeAddress");
            this.teHomeDistrict.DataBindings.Add("EditValue", _Patient, "HomeDistrict");
            this.teHomeTown.DataBindings.Add("EditValue", _Patient, "HomeTown");
            this.teHomePostCode.DataBindings.Add("EditValue", _Patient, "HomePostCode");
            BindLookUpEdit(this.lueHomeCity, _Patient, "HomeCity", LookUpServices.Cities, "Value", "Value");

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
            BindLookUpEdit(this.lueJobCity, _Patient, "JobCity", LookUpServices.Cities, "Value", "Value");
            this.teJobPostCode.DataBindings.Add("EditValue", _Patient, "JobPostCode");
            this.teJobPhone1.DataBindings.Add("EditValue", _Patient, "JobPhone1");
            this.teJobPhone2.DataBindings.Add("EditValue", _Patient, "JobPhone2");
            this.teJobFax.DataBindings.Add("EditValue", _Patient, "JobFax");
            this.teEmail.DataBindings.Add("EditValue", _Patient, "Email");

        }
        private void BindLookUpEdit(LookUpEdit lue, Object dataSource, string property, Object dataSourceList,
            string displayMember = "Value", string valueMember = "ID")
        {
            lue.Properties.DisplayMember = displayMember;
            lue.Properties.ValueMember = valueMember;
            lue.Properties.DataSource = dataSourceList;
            lue.DataBindings.Add("EditValue", dataSource, property);
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
            e.IsEmpty = pv.PatientVisitDetails.Count == 0;
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
            //frmMain frm = (frmMain)(this.MdiParent);
            //frm.ShowNewDocument<SelectPolyclinicForm>();

            SelectPolyclinicForm frm = new SelectPolyclinicForm();
            frm.ShowDialog();
            if (frm.IsSelected)
            {
                if (_IsWaitingForPolyclinic)
                {
                    // Should cancel the previous request?
                }
                _IsWaitingForPolyclinic = true;
                _Doctor = frm.Doctor;
                CallMedulaProvision();
            }

        }

        private void sbMernis_Click(object sender, EventArgs e)
        {
            this.mernisSorgu.CallMernis(this.teTCKimlikNo.Text);
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
            this.medulaSorgu.CallMedula(this.teTCKimlikNo.Text);
        }

        private void medulaSorgu_OnMedulaHastaKabulCompleted(object sender, Medula.HastaKabulIslemleri.hastaKabulCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.sonucKodu + ": " + e.Result.sonucMesaji, "Medula Sorgu Sonucu");
            if (_IsWaitingForPolyclinic)
            {
                _IsWaitingForPolyclinic = false;
                if (e.Result.sonucKodu == "0000")
                    PatientServices.AddSGKPolyclinic(this._Patient, this._Doctor, e.Result);
            }
        }

//        private void button1_Click(object sender, EventArgs e) {
//    ReportPrintTool pt = new ReportPrintTool(new XtraReport1());
//    pt.PrintingSystem.StartPrint += 
//        new PrintDocumentEventHandler(printingSystem_StartPrint);
//    pt.PrintDialog();
//}

//        private void printingSystem_StartPrint(object sender, PrintDocumentEventArgs e) {
//            for (int i = 0; i < e.PrintDocument.PrinterSettings.PaperSources.Count; i++)
//                if (e.PrintDocument.PrinterSettings.PaperSources[i].Kind == 
//                    PaperSourceKind.TractorFeed) {
//                    e.PrintDocument.DefaultPageSettings.PaperSource = 
//                        e.PrintDocument.PrinterSettings.PaperSources[i];
//                    break;
//                }

//            for (int i = 0; i < e.PrintDocument.PrinterSettings.PrinterResolutions.Count; i++)
//                if (e.PrintDocument.PrinterSettings.PrinterResolutions[i].Kind == 
//                    PrinterResolutionKind.High) {
//                    e.PrintDocument.DefaultPageSettings.PrinterResolution = 
//                        e.PrintDocument.PrinterSettings.PrinterResolutions[i];
//                    break;
//                }
//        }

    }
}