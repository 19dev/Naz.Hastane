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

///Todo List
///Medula Provizyonsuz karta provizyon isteme ekle
///

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SGKPatientForm : MDIChildForm
    {
        private Patient _Patient;
        private Doctor _Doctor;
        private bool _IsWaitingForPolyclinic = false;
        private PatientVisitDetail voucherPVD = null;
        private PatientVisitDetail invoicePVD = null;

        private SGKPatientForm()
        {
            InitializeComponent();
        }

        public SGKPatientForm(string aPatientID) : this()
        {
            _Patient = PatientServices.GetPatientByID(aPatientID, Session);
            if (_Patient == null)
            {
                _Patient = PatientServices.GetNewSGKPatient(Session);
                this.teTCID.Enabled = true;
            }
            else
            {
                this.teTCID.Enabled = false;
            }
            InitBindings();

            this.gcIslemler.DataSource = _Patient.PatientVisits;
            this.medulaSorgu.lueProvisionType.EditValue = ProvisionType.DefaultValue;
            this.medulaSorgu.lueInsuranceType.EditValue = InsuranceType.DefaultValue;
            this.medulaSorgu.lueTransferorInstitution.EditValue = TransferorInstitution.DefaultValue;
            this.medulaSorgu.lueBranchCode.EditValue = BranchCode.DefaultValue;
            this.medulaSorgu.lueTreatmentType.EditValue = TreatmentType.DefaultValue;
            this.medulaSorgu.lueRelationType.EditValue = RelationType.DefaultValue;
            this.medulaSorgu.lueFollowUpType.EditValue = FollowUpType.DeafultValue;
            this.medulaSorgu.lueTreatmentStyle.EditValue = TreatmentStyle.DefaultValue;
        }

        public void SetNewTCID(string TCID)
        {
            this.teTCID.Text = TCID;
            CallMernis();
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

        private void LoadLookUps()
        {
            UIUtilities.BindLookUpEdit(this.lueStatus, LookUpServices.PatientRelations);
            UIUtilities.BindLookUpEdit(this.lueInsuranceType, LookUpServices.InsuranceTypes);
            UIUtilities.BindLookUpEdit(this.lueNationality, LookUpServices.Nationalities);
            UIUtilities.BindLookUpEdit(this.lueHomeCity, LookUpServices.Cities);
            UIUtilities.BindLookUpEdit(this.lueJobCity, LookUpServices.Cities);
        }

        private void sbKaydet_Click(object sender, EventArgs e)
        {
            SavePatient();
        }

        private void SavePatient()
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
            _Patient.USER_ID = UIUtilities.CurrentUser.USER_ID;
            _Patient.DATE_CREATE = DateTime.Now;
            _Patient.DATE_UPDATE = DateTime.Now;

            try
            {
                PatientServices.SavePatient(Session, _Patient, UIUtilities.CurrentUser);
            }
            catch (Exception error)
            {
                XtraMessageBox.Show("Hasta Kayıt Edilemedi:" + error.Message, "Hasta Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #region GridBindings
        private void gvZiyaret_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            PatientVisit pv = (PatientVisit)gvPatientVisit.GetRow(e.RowHandle);
            if (e.RelationIndex == 0)
                e.IsEmpty = pv.PatientVisitDetails.Count == 0;
            else
                e.IsEmpty = pv.PatientVisitRecords.Count == 0;
        }

        private void gvZiyaret_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 2;
        }

        private void gvZiyaret_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            if (e.RelationIndex == 0)
                e.RelationName = "PatientVisitDetails";
            else
                e.RelationName = "PatientVisitRecords";
        }

        private void gvZiyaret_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            PatientVisit pv = (PatientVisit)gvPatientVisit.GetRow(e.RowHandle);
            if (e.RelationIndex == 0)
                e.ChildList = new BindingSource(pv, "PatientVisitDetails");
            else
                e.ChildList = new BindingSource(pv, "PatientVisitRecords");

        }

        private void gvZiyaret_MasterRowGetLevelDefaultView(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs e)
        {
            if (e.RelationIndex == 0)
                e.DefaultView = gvPatientVisitDetail;
            else
                e.DefaultView = gvPatientVisitRecord;
        }

        private void gvPatientVisit_MasterRowGetRelationDisplayCaption(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            if (e.RelationIndex == 0)
                e.RelationName = "İşlemler";
            else
                e.RelationName = "Kayıtlar";
        }

        #endregion

        #region Mernis

        private void sbMernis_Click(object sender, EventArgs e)
        {
            CallMernis();
        }

        private void CallMernis()
        {
            if (this.mernisSorgu.IsWorking)
            {
                XtraMessageBox.Show("Şu anda sürmekte olan Mernis işlemi var. Lütfen bekleyiniz.", "Mernis İşlemleri");
            }
            else
            {
                EnableForMernis(false);
                this.mernisSorgu.CallMernis(this.teTCID.Text);
            }
        }

        private void EnableForMernis(bool enable)
        {
            this.sbMernis.Enabled = enable;
            this.sbSavePatient.Enabled = enable;
            this.sbMedula.Enabled = enable;
        }

        private void mernisSorgu_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            EnableForMernis(true);
            if (this.mernisSorgu.IsOK)
            {
                _Patient.TCId = this.mernisSorgu.NufusCuzdani.TCKimlikNo.ToString();
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

                if (String.IsNullOrWhiteSpace(_Patient.PatientNo))
                {
                    SavePatient();
                    (this.MdiParent as frmMain).OpenSGKPatient(_Patient.PatientNo);
                    this.Close();
                }
                else
                { 
                    SavePatient(); 
                }
            }
        }
        #endregion

        #region Poliklinik & Medula
        private void sbPoliklinik_Click(object sender, EventArgs e)
        {
            ProcessNewPolyclinic();
        }

        private void ProcessNewPolyclinic()
        {
            SelectPolyclinicForm frm = new SelectPolyclinicForm();
            frm.ShowDialog();
            if (frm.IsSelected && frm.Doctor != null)
            {
                if (_IsWaitingForPolyclinic)
                {
                    XtraMessageBox.Show("Şu anda sürmekte olan Provizyon işlemi var. Lütfen bekleyiniz.", "Poliklinik İşlemleri");
                    // Should cancel the previous request?
                }
                else
                {
                    _IsWaitingForPolyclinic = true;
                    _Doctor = frm.Doctor;
                    CallMedulaProvision();
                    //PatientServices.AddSGKPolyclinic(Session, UIUtilities.CurrentUser, this._Patient, this._Doctor);
                }
            }
        }

        private void sbMedula_Click(object sender, EventArgs e)
        {
            CallMedulaProvision();
        }

        private void EnableForMedula(bool enable)
        {
            this.sbMernis.Enabled = enable;
            this.sbSavePatient.Enabled = enable;
            this.sbMedula.Enabled = enable;
            this.sbPoliklinik.Enabled = enable;
            this.sbInvoice.Enabled = enable;
            this.sbVoucher.Enabled = enable;
        }

        private void CallMedulaProvision()
        {
            if (this._Doctor == null)
                return;
            EnableForMedula(false);
            this.medulaSorgu.lueBranchCode.EditValue = _Doctor.Service.BranchCode;

            this.medulaSorgu.teRelatedFollowUpNo.Text = GetRelatedFollowUpNo();

            this.medulaSorgu.CallMedula(this.teTCID.Text);
        }

        private string GetRelatedFollowUpNo()
        {
            string result = "";
            for (int i = 0; i < this._Patient.PatientVisits.Count; i++)
            {
                if (this._Patient.PatientVisits[i].VisitDate.Date == DateTime.Today)
                    result = this._Patient.PatientVisits[i].TAKIPNO;
                else
                    break;
            }
            return result;
        }

        private void medulaSorgu_OnMedulaHastaKabulCompleted(object sender, MedulaProvisionCompletedEventArgs e)
        {
            EnableForMedula(true);
            _IsWaitingForPolyclinic = false;

            if (this.medulaSorgu.IsOK)
            {
                XtraMessageBox.Show(e.Result.SonucKodu + ": " + e.Result.SonucMesaji, "Medula Sorgu Sonucu");
                if (e.Result.SonucKodu == "0000")
                {
                    PatientServices.AddSGKPolyclinic(Session, UIUtilities.CurrentUser, this._Patient, this._Doctor);
                    PatientServices.UpdatePatientRecordsFromMedula(Session, UIUtilities.CurrentUser, this._Patient, e.Result);
                    RefreshGrid();
                }
            }
            else
            {
                if (XtraMessageBox.Show("Medula'dan Onay Alınamadı, Poliklinik Kaydı Oluşturmak İstiyor Musunuz?", "Medula Sorgu Sonucu",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    PatientServices.AddSGKPolyclinic(Session, UIUtilities.CurrentUser, this._Patient, this._Doctor);
            }

        }
        #endregion

        private void sbInvoice_Click(object sender, EventArgs e)
        {
            string NewTellerInvoiceNo = this.teInvoiceNo.Text;
            string paymentType = "N";
            string POSType = null;

            double ProductTotal = 0;
            double VATTotal = 0;
            double InvoiceTotal = 0;
            double VATPercent = 0;
            double Payment = 0;

            IList<PatientVisitDetail> pvds = new List<PatientVisitDetail>();
            PatientVisitDetail pvd = invoicePVD;
            if (pvd != null)
            {
                pvds.Add(pvd);
                ProductTotal += pvd.ADET * pvd.SATISF;
                VATPercent = pvd.KDV;
                VATPercent = Math.Round(VATPercent, 2);
                VATTotal = Math.Round(ProductTotal * VATPercent / 100.0, 2);
                InvoiceTotal = Math.Round(ProductTotal * (1 + VATPercent / 100.0), 2);

                UIUtilities.PrintInvoice(Session, _Patient, pvds,
                    paymentType, POSType,
                    ProductTotal,
                    VATTotal,
                    InvoiceTotal,
                    0,
                    VATPercent,
                    Payment,
                    0,
                    NewTellerInvoiceNo,
                    true
                    );
                invoicePVD = null;
                this.teInvoiceNo.Text = "";
            }
        }

        private void sbVoucher_Click(object sender, EventArgs e)
        {
            string NewTellerVoucherNo = this.teVoucherNo.Text;
            string paymentType = "N";
            string POSType = null;

            double ProductTotal = 0;

            IList<PatientVisitDetail> pvds = new List<PatientVisitDetail>();
            PatientVisitDetail pvd = voucherPVD;
            if (pvd != null)
            {
                pvds.Add(pvd);
                ProductTotal = pvd.ADET * pvd.SATISF;

                UIUtilities.PrintVoucher(Session, _Patient, pvds,
                    paymentType, POSType,
                    ProductTotal,
                    NewTellerVoucherNo,
                    true
                    );
                voucherPVD = null;
                this.teVoucherNo.Text = "";
            }
        }

        private void RefreshGrid()
        {
            this.gvPatientVisit.CollapseAllDetails();
            this.gcIslemler.RefreshDataSource();
            if (this.gvPatientVisit.RowCount > 0)
                this.gvPatientVisit.ExpandMasterRow(0);
        }

        private void gvPatientVisitDetail_Click(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            PatientVisitDetail pvd = (PatientVisitDetail)view.GetFocusedRow();
            if (pvd != null)
            {
                if (pvd.CODE == "SGKKATILIM")
                {
                    if (String.IsNullOrWhiteSpace(pvd.MAKNO))
                    {
                        voucherPVD = pvd;
                        this.teVoucherNo.Text = LookUpServices.GetNewTellerVoucherNo(UIUtilities.CurrentUser, false);
                    }
                    else
                    {
                        voucherPVD = null;
                        this.teVoucherNo.Text = "";
                    }
                }
                else
                {
                    if (String.IsNullOrWhiteSpace(pvd.MAKNO))
                    {
                        invoicePVD = pvd;
                        this.teInvoiceNo.Text = LookUpServices.GetNewTellerInvoiceNo(UIUtilities.CurrentUser, false);
                    }
                    else
                    {
                        invoicePVD = null;
                        this.teInvoiceNo.Text = "";
                    }
                }
            }
        }

        private void sbTaahutname_Click(object sender, EventArgs e)
        {
            UIUtilities.PrintTaahhutname(_Patient, true);
        }
    }
}