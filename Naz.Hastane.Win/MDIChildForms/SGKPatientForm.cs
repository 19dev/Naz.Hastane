﻿using System;
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

///Todo List
///Medula Provizyonsuz karta provizyon isteme ekle
///

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SGKPatientForm : MDIChildForm
    {
        private Patient _Patient = null;

        public Patient Patient
        {
            get { return _Patient; }
            set
            {
                if (_Patient != value)
                {
                    _Patient = value;
                    this.patientBalanceControl.Patient = _Patient;
                    if (this.patientBalanceControl.Balance < 0)
                    {
                        this.lcgBorcAlacak.AppearanceTabPage.Header.ForeColor = Color.Red;
                        this.lcgBorcAlacak.AppearanceTabPage.HeaderActive.ForeColor = Color.Red;
                        this.lcgBorcAlacak.AppearanceTabPage.HeaderHotTracked.ForeColor = Color.Red;
                    }
                    else
                    {
                        this.lcgBorcAlacak.AppearanceTabPage.Header.ForeColor = Color.Black;
                        this.lcgBorcAlacak.AppearanceTabPage.HeaderActive.ForeColor = Color.Black;
                        this.lcgBorcAlacak.AppearanceTabPage.HeaderHotTracked.ForeColor = Color.Black;
                    }
                }
            }
        }
        private Doctor _Doctor = null;
        private PatientVisit currentPatientVisit = null;
        private bool _IsWaitingForMedulaProvision = false;
        private PatientVisitDetail voucherPVD = null;
        private PatientVisitDetail invoicePVD = null;
        private PatientVisitDetail currentPVD = null;
        private string _OldProvisionCode;

        private SGKPatientForm()
        {
            InitializeComponent();
        }

        public SGKPatientForm(string aPatientNo) : this()
        {
            Patient = PatientServices.GetPatientByID(aPatientNo, Session);
            if (Patient == null)
            {
                Patient = PatientServices.GetNewSGKPatient(Session);
                //this.teTCID.Enabled = true;
            }
            else
            {
                //this.teTCID.Enabled = false;
            }
            InitBindings();

            this.PatientVisitControl.gcPatientVisit.DataSource = Patient.PatientVisits;
            this.medulaSorgu.lueProvisionType.EditValue = ProvisionType.DefaultValue;
            this.medulaSorgu.lueInsuranceType.EditValue = InsuranceType.DefaultValue;
            this.medulaSorgu.lueTransferorInstitution.EditValue = TransferorInstitution.DefaultValue;
            this.medulaSorgu.lueBranchCode.EditValue = BranchCode.DefaultValue;
            this.medulaSorgu.lueTreatmentType.EditValue = TreatmentType.DefaultValue;
            this.medulaSorgu.lueRelationType.EditValue = RelationType.DefaultValue;
            this.medulaSorgu.lueFollowUpType.EditValue = FollowUpType.DefaultValue;
            this.medulaSorgu.lueTreatmentStyle.EditValue = TreatmentStyle.DefaultValue;

            this.medulaFollowUpQueryControl.TCId = Patient.TCId;
        }

        public void SetNewTCID(string TCID)
        {
            this.teTCID.Text = TCID;
            this.medulaFollowUpQueryControl.TCId = TCID;
            CallMernis();
        }

        private void InitBindings()
        {
            LoadLookUps();
            this.tePatientNo.DataBindings.Add("EditValue", Patient, "PatientNo");
            //this.teInsuranceCompany.DataBindings.Add("EditValue", Patient, "InsuranceCompany.Name");
            if (this.Patient.InsuranceCompany != null)
                this.teInsuranceCompany.Text = this.Patient.InsuranceCompany.Code;

            this.teTCID.DataBindings.Add("EditValue", Patient, "TCId");
            this.teFirstName.DataBindings.Add("EditValue", Patient, "FirstName");
            this.teLastName.DataBindings.Add("EditValue", Patient, "LastName");
            this.rgSex.DataBindings.Add("EditValue", Patient, "Sex");
            this.rgMaritalStatus.DataBindings.Add("EditValue", Patient, "MaritalStatus");
            this.teFatherName.DataBindings.Add("EditValue", Patient, "FatherName");
            this.teMotherName.DataBindings.Add("EditValue", Patient, "MotherName");
            this.teBirthPlace.DataBindings.Add("EditValue", Patient, "BirthPlace");
            this.deBirthDate.DataBindings.Add("EditValue", Patient, "BirthDate");
            this.lueStatus.DataBindings.Add("EditValue", Patient, "Status");
            this.lueInsuranceType.DataBindings.Add("EditValue", Patient, "InsuranceType");
            this.medulaSorgu.lueInsuranceType.DataBindings.Add("EditValue", Patient, "InsuranceType");
            this.teHomePhone2.DataBindings.Add("EditValue", Patient, "HomePhone2");
            this.teHomePhone1.DataBindings.Add("EditValue", Patient, "HomePhone1");

            this.medulaSorgu.lueTransferorInstitution.DataBindings.Add("EditValue", Patient, "TransferorInstitution");
            
            this.rgIDType.DataBindings.Add("EditValue", Patient, "IDType");
            this.teIDNO.DataBindings.Add("EditValue", Patient, "IDNO");
            this.deIDDate.DataBindings.Add("EditValue", Patient, "IDDate");
            this.teIDPlace.DataBindings.Add("EditValue", Patient, "IDPlace");
            this.lueNationality.DataBindings.Add("EditValue", Patient, "Nationality");
            this.teHomeAddress.DataBindings.Add("EditValue", Patient, "HomeAddress");
            this.teHomeDistrict.DataBindings.Add("EditValue", Patient, "HomeDistrict");
            this.teHomeTown.DataBindings.Add("EditValue", Patient, "HomeTown");
            this.teHomePostCode.DataBindings.Add("EditValue", Patient, "HomePostCode");
            this.lueHomeCity.DataBindings.Add("EditValue", Patient, "HomeCity");

            this.teOfficer.DataBindings.Add("EditValue", Patient, "Officer");
            this.teProfession.DataBindings.Add("EditValue", Patient, "Profession");
            this.teEMSNo.DataBindings.Add("EditValue", Patient, "EMSNO");
            this.teProtocolNo.DataBindings.Add("EditValue", Patient, "ProtocolNo");
            this.teBAGNO.DataBindings.Add("EditValue", Patient, "BAGNO");
            this.teSSKSicilNo.DataBindings.Add("EditValue", Patient, "YKARTNO");
            this.teSevkEdilenYer.DataBindings.Add("EditValue", Patient, "GELHAST");
            this.lueSigortaMudurlugu.DataBindings.Add("EditValue", Patient, "SIGMUD");
            this.teNufusaKayitliIl.DataBindings.Add("EditValue", Patient, "RegisteredCity");
            this.teNufusaKayitliIlce.DataBindings.Add("EditValue", Patient, "RegisteredTown");
            this.teSigortaliKartNo.DataBindings.Add("EditValue", Patient, "SIGORTALIKARTNO");

            this.teJobName.DataBindings.Add("EditValue", Patient, "JobName");
            this.teJobNo.DataBindings.Add("EditValue", Patient, "JobNo");
            this.meJobAddress.DataBindings.Add("EditValue", Patient, "JobAddress");
            this.lueJobCity.DataBindings.Add("EditValue", Patient, "JobCity");
            this.teJobPostCode.DataBindings.Add("EditValue", Patient, "JobPostCode");
            this.teJobPhone1.DataBindings.Add("EditValue", Patient, "JobPhone1");
            this.teJobPhone2.DataBindings.Add("EditValue", Patient, "JobPhone2");
            this.teJobFax.DataBindings.Add("EditValue", Patient, "JobFax");
            this.teEmail.DataBindings.Add("EditValue", Patient, "Email");
        }

        private void LoadLookUps()
        {
            UIUtilities.BindLookUpEdit(this.lueStatus, LookUpServices.PatientRelations);
            UIUtilities.BindLookUpEdit(this.lueInsuranceType, LookUpServices.InsuranceTypes);
            UIUtilities.BindLookUpEdit(this.lueNationality, LookUpServices.Nationalities);
            UIUtilities.BindLookUpEdit(this.lueHomeCity, LookUpServices.Cities, displayMember: "Value", valueMember: "Value" );
            UIUtilities.BindLookUpEdit(this.lueJobCity, LookUpServices.Cities);
        }

        private void sbSavePatient_Click(object sender, EventArgs e)
        {
            SavePatient();
        }

        private void SavePatient()
        {
            if (String.IsNullOrWhiteSpace(Patient.FirstName))
            {
                XtraMessageBox.Show("Lütfen Hastanın Adını Kontrol Ediniz", "Hasta Kayıt Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(Patient.LastName))
            {
                XtraMessageBox.Show("Lütfen Hastanın Soyadını Kontrol Ediniz", "Hasta Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Patient.BirthDate == null)
            {
                XtraMessageBox.Show("Lütfen Hastanın Doğum Tarihini Kontrol Ediniz", "Hasta Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Patient.PatientLimit = 0;

            try
            {
                if (String.IsNullOrWhiteSpace(Patient.PatientNo))
                {
                    this.teFirstName.Focus();
                    Patient.USER_ID = UIUtilities.CurrentUser.USER_ID;
                    Patient.DATE_CREATE = DateTime.Now;
                    PatientServices.SavePatient(Session, Patient, UIUtilities.CurrentUser);
                    OpenNewForm();
                }
                else
                {
                    Patient.USER_ID_UPDATE = UIUtilities.CurrentUser.USER_ID;
                    Patient.DATE_UPDATE = DateTime.Now;
                    PatientServices.SavePatient(Session, Patient, UIUtilities.CurrentUser);
                }
            }
            catch (Exception error)
            {
                XtraMessageBox.Show("Hasta Kayıt Edilemedi:" + error.Message, "Hasta Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenNewForm()
        {
            (this.MdiParent as frmMain).OpenSGKPatient(Patient.PatientNo);
            this.Close();
        }
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
            else if (!String.IsNullOrWhiteSpace(this.teTCID.Text))
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
                Patient.TCId = this.mernisSorgu.NufusCuzdani.TCKimlikNo.ToString();
                Patient.FirstName = this.mernisSorgu.NufusCuzdani.Ad;
                Patient.LastName = this.mernisSorgu.NufusCuzdani.Soyad;
                Patient.MotherName = this.mernisSorgu.NufusCuzdani.AnaAd;
                Patient.FatherName = this.mernisSorgu.NufusCuzdani.BabaAd;
                if (this.mernisSorgu.KisiBilgisi.TemelBilgisi.Cinsiyet == CinsiyetTipi.Erkek)
                    Patient.Sex = "1";
                else
                    Patient.Sex = "2";
                Patient.BirthDate = new DateTime(this.mernisSorgu.NufusCuzdani.DogumTarih.Yil,
                    Math.Max(this.mernisSorgu.NufusCuzdani.DogumTarih.Ay, 1),
                    Math.Max(this.mernisSorgu.NufusCuzdani.DogumTarih.Gun, 1));
                Patient.BirthPlace = this.mernisSorgu.NufusCuzdani.DogumYer;

                if (this.mernisSorgu.KisiBilgisi.DurumBilgisi.MedeniHal == MedeniHalTipi.Evli)
                    Patient.MaritalStatus = "E";
                else
                    Patient.MaritalStatus = "B";

                Patient.RegisteredCity = this.mernisSorgu.TCKimlikResponse.IlAd;
                Patient.RegisteredTown = this.mernisSorgu.TCKimlikResponse.IlceAd;
                Patient.IDPlace = this.mernisSorgu.NufusCuzdani.VerildigiIlceAd;
                Patient.IDDate = new DateTime(this.mernisSorgu.NufusCuzdani.VerilmeTarih.Yil,
                    this.mernisSorgu.NufusCuzdani.VerilmeTarih.Ay,
                    this.mernisSorgu.NufusCuzdani.VerilmeTarih.Gun).ToString();
                Patient.IDNO = this.mernisSorgu.NufusCuzdani.CuzdanSeri + "-" + this.mernisSorgu.NufusCuzdani.CuzdanNo;

                SavePatient(); 
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
            SelectPolyclinicForm frm = new SelectPolyclinicForm(PatientServices.IsSGKSameDay(Patient));
            frm.ShowDialog();
            if (frm.IsSelected && frm.Doctor != null && IsNewPolyclinicOK(frm.Doctor))
            {
                _Doctor = frm.Doctor;
                currentPatientVisit = PatientServices.AddSGKPolyclinic(Session, UIUtilities.CurrentUser, this.Patient, _Doctor, frm.SameDay);
                RefreshGrid();
                //XtraMessageBox.Show("Kurum Değiştirme İşlemi Başarılı!", "Kurum Değiştirme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CallMedulaProvision();
            }
        }

        private bool IsNewPolyclinicOK(Doctor doctor)
        {
            string branchCode = doctor.Service.BranchCode;
            foreach(PatientVisit pv in Patient.PatientVisits)
            {
                if (pv.VisitDate.Date == DateTime.Today && pv.BranchCode == branchCode)
                {
                    if (XtraMessageBox.Show("Aynı Gün İçinde Bu Branştan Kart Açılmış, Yeni Kart Açmak İstiyor musunuz?", "Poliklinik Uyarısı", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        return true;
                    else
                        return false;
                }
            
            }
            return true;
        }
        private void sbMedula_Click(object sender, EventArgs e)
        {
            currentPatientVisit = this.PatientVisitControl.gvPatientVisit.GetFocusedRow() as PatientVisit;
            CallMedulaProvision();
        }

        private void EnableForMedula(bool enable)
        {
            _IsWaitingForMedulaProvision = !enable;
            this.sbMernis.Enabled = enable;
            this.sbSavePatient.Enabled = enable;
            this.sbMedula.Enabled = enable;
            this.sbPoliklinik.Enabled = enable;
            this.sbInvoice.Enabled = enable;
            this.sbVoucher.Enabled = enable;
            this.PatientVisitControl.gcPatientVisit.Enabled = enable;
        }

        private void CallMedulaProvision()
        {
            if (!(Patient.InsuranceCompany.IsSGK() || Patient.InsuranceCompany.IsSGKAcil())) return;

            if (currentPatientVisit == null)
            {
                XtraMessageBox.Show("Lütfen Bir Ziytaret Kartı Seçiniz!", "Medula İşlemleri");
                return;
            }
            if (!String.IsNullOrWhiteSpace(this.currentPatientVisit.TAKIPNO))
            {
                XtraMessageBox.Show("Seçili Kart İçin Provizyon Alınmış!", "Medula İşlemleri");
                return;
            }
            _Doctor = currentPatientVisit.Doctor;
            if (this._Doctor == null)
            {
                XtraMessageBox.Show("Seçili Kartta Geçerli Doktor Tanımı Yok!", "Medula İşlemleri");
                return;
            }
            if (_IsWaitingForMedulaProvision)
            {
                XtraMessageBox.Show("Şu anda sürmekte olan Provizyon işlemi var. Lütfen bekleyiniz.", "Medula İşlemleri");
                return;
            }
            string TCID = this.teTCID.Text;
            if (!PatientServices.IsValidTCID(TCID))
            {
                XtraMessageBox.Show("T.C. Kimlik No Geçerli Değil!", "Medula İşlemleri");
                return;
            }

            EnableForMedula(false);

            if (this.Patient.InsuranceCompany.IsSGK())
                this.medulaSorgu.lueProvisionType.EditValue = ProvisionType.NormalValue;
            else if (this.Patient.InsuranceCompany.IsSGKAcil())
                this.medulaSorgu.lueProvisionType.EditValue = ProvisionType.EmergencyValue;

            this.medulaSorgu.lueBranchCode.EditValue = _Doctor.Service.BranchCode;
            
            if (String.IsNullOrWhiteSpace(this.medulaSorgu.teRelatedFollowUpNo.Text))
                this.medulaSorgu.teRelatedFollowUpNo.Text = GetRelatedFollowUpNo();

            this.medulaSorgu.CallMedula(this.teTCID.Text);

        }

        private string GetRelatedFollowUpNo()
        {
            string result = "";
            
            for (int i = 0; i <= this.PatientVisitControl.gvPatientVisit.RowCount; i++)
            {
                PatientVisit pv = this.PatientVisitControl.gvPatientVisit.GetRow(i) as PatientVisit;
                if (pv != null && pv.VisitDate.Date == DateTime.Today)
                {
                    if (!String.IsNullOrWhiteSpace(pv.TAKIPNO))
                        result = this.Patient.PatientVisits[i].TAKIPNO;
                }
                else
                    break;
            }
            return result;
        }

        private void medulaSorgu_OnMedulaHastaKabulCompleted(object sender, MedulaProvisionCompletedEventArgs e)
        {
            try
            {
                if (this.medulaSorgu.IsOK)
                {
                    XtraMessageBox.Show(Patient.FullName + " için " + this.medulaSorgu.lueInsuranceType.Text + 
                        " Medula Sorgusu Sonucu:" + e.Result.SonucKodu + ": " + e.Result.SonucMesaji, "Medula Sorgu Sonucu");

                    if (e.Result.SonucKodu == "0000" || e.Result.SonucKodu == "9000")
                    {
                        if (currentPatientVisit != null)
                        {
                            PatientServices.UpdatePatientRecordsFromMedula(Session, UIUtilities.CurrentUser, this.Patient, currentPatientVisit, e.Result);
                            RefreshGrid();
                        }
                    }
                    else if (e.Result.SonucKodu == "1163")
                    {
                        string oldProvision = Helpers.GetSubString(e.Result.SonucMesaji, "[", "]");

                        if (!String.IsNullOrWhiteSpace(oldProvision))
                        {
                            _OldProvisionCode = oldProvision;
                            timerHastaKabulOku.Interval = 400;
                            timerHastaKabulOku.Enabled = true;
                        }

                    }
                }

            }
            finally
            {
                EnableForMedula(true);
            }
        }

        private void medulaFollowUpQueryControl_OnHastaKabulOkuCompleted(object sender, Medula.HastaKabulIslemleri.hastaKabulOkuCompletedEventArgs e)
        {
            try
            {
                if (this.medulaFollowUpQueryControl.IsOK)
                {
                    if (e.Result.sonucKodu == "0000")
                    {
                        if (currentPatientVisit != null)
                        {
                            MedulaProvisionResult mpr = new MedulaProvisionResult();
                            mpr.BranchCode = e.Result.bransKodu;
                            mpr.HastaBasvuruNo = e.Result.hastaBasvuruNo;
                            mpr.Ad = e.Result.hastaBilgileri.ad;
                            mpr.Cinsiyet = e.Result.hastaBilgileri.cinsiyet;
                            mpr.DogumTarihi = e.Result.hastaBilgileri.dogumTarihi;
                            mpr.SigortaliTuru = e.Result.hastaBilgileri.sigortaliTuru;
                            mpr.Soyad = e.Result.hastaBilgileri.soyad;
                            mpr.TCKimlikNo = e.Result.hastaBilgileri.tcKimlikNo;
                            mpr.RelatedFollowUpNo = e.Result.ilkTakipNo;
                            //mpr.BranchCode                      = e.Result.kayitTarihi;
                            mpr.ProvisionType = e.Result.provizyonTipi;
                            //mpr.BranchCode                      = e.Result.sevkDurumu;
                            mpr.SonucKodu = e.Result.sonucKodu;
                            mpr.SonucMesaji = e.Result.sonucMesaji;
                            //mpr.BranchCode                      = e.Result.takipDurumu;
                            mpr.TakipNo = e.Result.takipNo;
                            //mpr.BranchCode                      = e.Result.takipTarihi;
                            mpr.FollowUpType = e.Result.takipTipi;
                            mpr.TreatmentType = e.Result.tedaviTipi;
                            //mpr.BranchCode                      = e.Result.tesisKodu;
                            //mpr.BranchCode                      = e.Result.takipDurumu;

                            PatientServices.UpdatePatientRecordsFromMedula(Session, UIUtilities.CurrentUser, this.Patient, currentPatientVisit, mpr);
                            RefreshGrid();
                        }
                    }
                }

            }
            finally
            {
                EnableForMedula(true);
            }
        }

        #endregion

        private void sbInvoice_Click(object sender, EventArgs e)
        {
            string NewTellerInvoiceNo = this.teInvoiceNo.Text;
            const string paymentType = "N";
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
                ProductTotal += pvd.ADET * pvd.PatientPrice;
                VATPercent = pvd.KDV;
                VATPercent = Math.Round(VATPercent, 2);
                VATTotal = Math.Round(ProductTotal * VATPercent / 100.0, 2);
                InvoiceTotal = Math.Round(ProductTotal * (1 + VATPercent / 100.0), 2);

                UIUtilities.PrintInvoice(Session, Patient, pvds,
                    paymentType, POSType,
                    ProductTotal,
                    VATTotal,
                    InvoiceTotal,
                    0,
                    VATPercent,
                    InvoiceTotal,
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
                ProductTotal = pvd.ADET * pvd.PatientPrice;

                UIUtilities.PrintVoucher(Session, Patient, pvds,
                    paymentType, POSType,
                    ProductTotal,
                    NewTellerVoucherNo,
                    true
                    );
                voucherPVD = null;
                this.teVoucherNo.Text = "";
            }
        }

        private void sbTaahutname_Click(object sender, EventArgs e)
        {
            UIUtilities.PrintTaahhutname(Patient, true);
        }

        private void sbDeletePatientVisitDetail_Click(object sender, EventArgs e)
        {
            PatientVisitDetail pvd = currentPVD;
            if (pvd == null)
                return;
            if (!pvd.IsOKForDelete())
            {
                XtraMessageBox.Show("Fatura veya Makbuz Kesilmiş Kayıtı Silemezsiniz", "İşlem Silme Uyarısı", MessageBoxButtons.OK);
                return;
            }
            if (XtraMessageBox.Show("Bu İşlem Kaydını Silmek İstiyor Musunuz?", "İşlem Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (PatientServices.DeletePatientVisitDetail(Session, UIUtilities.CurrentUser, pvd))
                    {
                        XtraMessageBox.Show("İşlem Kaydı Başarıyla Silindi", "İşlem Silme Uyarısı", MessageBoxButtons.OK);
                        RefreshGrid();
                    }
                    else
                    {
                        XtraMessageBox.Show("İşlem Kaydı Silinemedi", "İşlem Silme Uyarısı", MessageBoxButtons.OK);
                    }
                }
                catch
                {
                    XtraMessageBox.Show("İşlem Kaydı Silinemedi", "İşlem Silme Uyarısı", MessageBoxButtons.OK);
                }
            }
        }

        private void sbDeletePatientVisit_Click(object sender, EventArgs e)
        {
            PatientVisit pv = this.PatientVisitControl.gvPatientVisit.GetFocusedRow() as PatientVisit;
            if (pv == null)
                return;
            if (!pv.IsOKForDelete())
            {
                XtraMessageBox.Show("Bu Ziyaret Kartını Silemezseniz", "Ziyaret Kartı Silme Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (XtraMessageBox.Show("Bu Ziyaret Kartını Bütün İşlemleri İle Birlikte Silmek İstiyor Musunuz?", "Ziyaret Kartı Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (!String.IsNullOrWhiteSpace(pv.TAKIPNO))
                    if (XtraMessageBox.Show("Bu Ziyaret Kartını Medula Takip Numarasını Silmek İstiyor Musunuz?", "Ziyaret Kartı Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        this.medulaFollowUpQueryControl.CallMedulaHastaKabulIptal(pv.TAKIPNO);

                try
                {
                    if (PatientServices.DeletePatientVisit(Session, UIUtilities.CurrentUser, pv))
                    {
                        XtraMessageBox.Show("Ziyaret Kartı Başarıyla Silindi", "Ziyaret Kartı Silme Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ziyaret Kartı Silinemedi", "Ziyaret Kartı Silme Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    XtraMessageBox.Show("Ziyaret Kartı Silinemedi", "Ziyaret Kartı Silme Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RefreshGrid()
        {
            this.PatientVisitControl.gvPatientVisit.BeginDataUpdate();
            this.PatientVisitControl.gcPatientVisit.RefreshDataSource();
            this.PatientVisitControl.gvPatientVisit.CollapseAllDetails();
            this.PatientVisitControl.gvPatientVisit.EndDataUpdate();
        }

        private void gvPatientVisitDetail_Click(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            PatientVisitDetail pvd = (PatientVisitDetail)view.GetFocusedRow();
            if (pvd != null)
            {
                currentPVD = pvd;
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

        private void gvPatientVisit_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedRowHandle >= 0)
                view.SetMasterRowExpanded(view.FocusedRowHandle, !view.GetMasterRowExpanded(view.FocusedRowHandle));

        }

        private void medulaFollowUpQueryControl_OnHastaKabulIptalCompleted(object sender, Medula.HastaKabulIslemleri.hastaKabulIptalCompletedEventArgs e)
        {
            if (this.medulaFollowUpQueryControl.IsOK)
                UpdatePatientVisitWithMedulaProvisionDelete(e.Result.takipNo);
        }

        private void UpdatePatientVisitWithMedulaProvisionDelete(string takipNo)
        {
            if (PatientServices.UpdatePatientVisitWithMedulaProvisionDelete(Session, UIUtilities.CurrentUser, Patient, takipNo))
                RefreshGrid();
        }

        private void SGKPatientForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
                CloseForm();
            else if (e.KeyCode == Keys.F5)
                SavePatient();
            else if (e.KeyCode == Keys.F8)
                ProcessNewPolyclinic();
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void sbAddPatientVisitDetail_Click(object sender, EventArgs e)
        {
            currentPatientVisit = this.PatientVisitControl.gvPatientVisit.GetFocusedRow() as PatientVisit;
            if (Patient != null && Patient.InsuranceCompany != null && currentPatientVisit != null)
            {
                SelectFunctionForm frm = new SelectFunctionForm();
                frm.PatientVisit = currentPatientVisit;
                frm.PriceListCode = Patient.InsuranceCompany.YFIYLIST;
                frm.ShowDialog();

                if (frm.IsSelected)
                {
                    PatientServices.AddPatientVisitDetails(Session, UIUtilities.CurrentUser, Patient, currentPatientVisit, frm.SelectedProducts);
                    RefreshGrid();
                }
            }

        }

        #region Change Insurance Company
        private void ddbChangeInsuranceCompany_Click(object sender, EventArgs e)
        {
            SelectInsuranceCompanyForm frm = new SelectInsuranceCompanyForm();
            frm.ShowDialog();
            if (frm.IsSelected)
                ChangeInsuranceCompany(frm.InsuranceCompany);
        }

        private void iSGK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeInsuranceCompany(LookUpServices.GetSGK(Session));
        }

        private void iSGKAcil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeInsuranceCompany(LookUpServices.GetSGKAcil(Session));
        }

        private void iNormal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeInsuranceCompany(LookUpServices.GetNormalPatientCode(Session));
        }

        private void iOzelHasta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeInsuranceCompany(LookUpServices.GetSpecialPatientCode(Session));
        }

        private void ChangeInsuranceCompany(InsuranceCompany newInsuranceCompany)
        {
            if (Patient.InsuranceCompany == newInsuranceCompany) return;

            bool isOK = false;
            IList<PatientVisit> pvs = PatientServices.GetPatientVisitsForInsuranceCompanyChange(Session, Patient);
            IList<PatientVisitDetailWithProduct> pvdwps = new List<PatientVisitDetailWithProduct>();

            if (pvs.Count > 0)
            {
                ChangeInsuranceCompanyForm frm = new ChangeInsuranceCompanyForm(Session, Patient, newInsuranceCompany, pvs);
                frm.ShowDialog();
                isOK = frm.IsOK;
                pvdwps = frm.PatientVisitDetailWithProducts;
                pvs = frm.GetSelectedVisits();
            }
            else
                isOK = true;

            if (isOK)
            {
                try
                {
                    PatientServices.ChangeInsuranceCompany(Session, UIUtilities.CurrentUser, Patient, pvs, pvdwps, newInsuranceCompany);
                    XtraMessageBox.Show("Kurum Değiştirme İşlemi Başarılı!", "Kurum Değiştirme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenNewForm();
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show("Kurum Değiştirme İşlemi Başarısız Oldu:" + e.Message, "Kurum Değiştirme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            timerHastaKabulOku.Enabled = false;
            EnableForMedula(false);
            this.medulaFollowUpQueryControl.CallMedulaHastaKabulOku(_OldProvisionCode);

        }

    }
}