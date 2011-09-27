using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Naz.Hastane.Data.DTO;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Entities.LookUp.MedulaProvision;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Hastane.Data.Entities.Medula;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Win.Controls;
using Naz.Mernis.Service;
using Naz.Utilities.Classes;
using Naz.Hastane.Win.Forms;

///Todo List
///Medula Provizyonsuz karta provizyon isteme ekle
///

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SGKPatientForm : MDIChildForm
    {
        private void RefreshPatientBalance()
        {
            patientBalanceControl.RefreshView();
            if (patientBalanceControl.Balance < 0)
            {
                lcgBorcAlacak.AppearanceTabPage.Header.ForeColor = Color.Red;
                lcgBorcAlacak.AppearanceTabPage.HeaderActive.ForeColor = Color.Red;
                lcgBorcAlacak.AppearanceTabPage.HeaderHotTracked.ForeColor = Color.Red;
            }
            else
            {
                lcgBorcAlacak.AppearanceTabPage.Header.ForeColor = Color.Black;
                lcgBorcAlacak.AppearanceTabPage.HeaderActive.ForeColor = Color.Black;
                lcgBorcAlacak.AppearanceTabPage.HeaderHotTracked.ForeColor = Color.Black;
            }
        }

        private Doctor _Doctor;
        private string _BranchCode;
        private PatientVisit currentPatientVisit;
        private bool _IsWaitingForMedulaProvision;
        private PatientVisitDetail voucherPVD;
        private PatientVisitDetail invoicePVD;
        private PatientVisitDetail currentPVD;
        private string _OldProvisionCode;

        private Patient _Patient;

        public Patient Patient
        {
            get { return _Patient; }
            set
            {
                if (_Patient != value)
                {
                    _Patient = value;

                    InitPatientBindings();
                    RefreshPatientBalance();
                }
            }
        }

        private SGKPatientForm()
        {
            InitializeComponent();
            LoadLookUps();
            AttachMenuHandlers();
        }

        public SGKPatientForm(string aPatientNo) : this()
        {
            Patient patient = PatientServices.GetPatientByID(aPatientNo, Session);
            if (patient == null)
            {
                patient = PatientServices.GetNewSGKPatient(Session);
                //teTCID.Enabled = true;
            }
            else
            {
                //teTCID.Enabled = false;
            }

            Patient = patient;
            if (Patient != null && !String.IsNullOrWhiteSpace(Patient.CV))
                tbcHastaBilgileri.SelectedTabPage = lcgHastaOzgecmis;
            else
                tbcHastaBilgileri.SelectedTabPage = lcgHastaBilgileri;
        }

        private void ReLoadPatient()
        {
            string patientNo = Patient.PatientNo;
            _Patient = null;

            ReOpenSession();
            Patient = PatientServices.GetPatientByID(patientNo, Session);
        }

        public void SetNewTCID(string TCID)
        {
            teTCID.Text = TCID;
            medulaFollowUpQueryControl.TCId = TCID;
            CallMernis();
        }

        private void InitPatientBindings()
        {
            if (Patient.InsuranceCompany != null)
                teInsuranceCompany.Text = Patient.InsuranceCompany.Code;

            UIUtilities.BindControl(tePatientNo, Patient, x => x.PatientNo);
            UIUtilities.BindControl(teSNO, Patient, x => x.SIGORTANO);
            UIUtilities.BindControl(teTCID, Patient, x => x.TCId);
            UIUtilities.BindControl(teFirstName, Patient, x => x.FirstName);
            UIUtilities.BindControl(teLastName, Patient, x => x.LastName);
            UIUtilities.BindControl(rgSex, Patient, x => x.Sex);
            UIUtilities.BindControl(rgMaritalStatus, Patient, x => x.MaritalStatus);
            UIUtilities.BindControl(teFatherName, Patient, x => x.FatherName);
            UIUtilities.BindControl(teMotherName, Patient, x => x.MotherName);
            UIUtilities.BindControl(teBirthPlace, Patient, x => x.BirthPlace);
            UIUtilities.BindControl(deBirthDate, Patient, x => x.BirthDate);
            UIUtilities.BindControl(lueStatus, Patient, x => x.Status);
            UIUtilities.BindControl(lueInsuranceType, Patient, x => x.InsuranceType);
            UIUtilities.BindControl(medulaSorgu.lueInsuranceType, Patient, x => x.InsuranceType);
            UIUtilities.BindControl(teHomePhone2, Patient, x => x.HomePhone2);
            UIUtilities.BindControl(teHomePhone1, Patient, x => x.HomePhone1);

            UIUtilities.BindControl(medulaSorgu.lueTransferorInstitution, Patient, x => x.TransferorInstitution);

            UIUtilities.BindControl(rgIDType, Patient, x => x.IDType);
            UIUtilities.BindControl(teIDNO, Patient, x => x.IDNO);
            UIUtilities.BindControl(deIDDate, Patient, x => x.IDDate);
            UIUtilities.BindControl(teIDPlace, Patient, x => x.IDPlace);
            UIUtilities.BindControl(lueNationality, Patient, x => x.Nationality);
            UIUtilities.BindControl(teHomeAddress, Patient, x => x.HomeAddress);
            UIUtilities.BindControl(teHomeDistrict, Patient, x => x.HomeDistrict);
            UIUtilities.BindControl(teHomeTown, Patient, x => x.HomeTown);
            UIUtilities.BindControl(teHomePostCode, Patient, x => x.HomePostCode);
            UIUtilities.BindControl(lueHomeCity, Patient, x => x.HomeCity);

            UIUtilities.BindControl(teOfficer, Patient, x => x.Officer);
            UIUtilities.BindControl(teProfession, Patient, x => x.Profession);
            UIUtilities.BindControl(teEMSNo, Patient, x => x.EMSNO);
            UIUtilities.BindControl(teProtocolNo, Patient, x => x.ProtocolNo);
            UIUtilities.BindControl(teBAGNO, Patient, x => x.BAGNO);
            UIUtilities.BindControl(teSSKSicilNo, Patient, x => x.YKARTNO);
            UIUtilities.BindControl(teSevkEdilenYer, Patient, x => x.GELHAST);
            UIUtilities.BindControl(lueSigortaMudurlugu, Patient, x => x.SIGMUD);
            UIUtilities.BindControl(teNufusaKayitliIl, Patient, x => x.RegisteredCity);
            UIUtilities.BindControl(teNufusaKayitliIlce, Patient, x => x.RegisteredTown);
            UIUtilities.BindControl(teSigortaliKartNo, Patient, x => x.SIGORTALIKARTNO);

            UIUtilities.BindControl(teJobName, Patient, x => x.JobName);
            UIUtilities.BindControl(teJobNo, Patient, x => x.JobNo);
            UIUtilities.BindControl(meJobAddress, Patient, x => x.JobAddress);
            UIUtilities.BindControl(lueJobCity, Patient, x => x.JobCity);
            UIUtilities.BindControl(teJobPostCode, Patient, x => x.JobPostCode);
            UIUtilities.BindControl(teJobPhone1, Patient, x => x.JobPhone1);
            UIUtilities.BindControl(teJobPhone2, Patient, x => x.JobPhone2);
            UIUtilities.BindControl(teJobFax, Patient, x => x.JobFax);
            UIUtilities.BindControl(teEmail, Patient, x => x.Email);

            UIUtilities.BindControl(meHastaOzgecmis, Patient, x => x.CV);

            IList<PatientVisit> pvs = Patient.PatientVisits;

            PatientVisitControl.gcPatientVisit.DataSource = Patient.PatientVisits;
            PatientVisitControl1.gcPatientVisit.DataSource = Patient.PatientVisits;
            medulaFollowUpQueryControl.TCId = Patient.TCId;
            patientBalanceControl.Patient = Patient;
            invoiceDeleteControl.QueryInvoices(Session, Patient);
        }

        private void LoadLookUps()
        {
            UIUtilities.BindLookUpEdit(lueStatus, LookUpServices.PatientRelations);
            UIUtilities.BindLookUpEdit(lueInsuranceType, LookUpServices.InsuranceTypes);
            UIUtilities.BindLookUpEdit(lueNationality, LookUpServices.Nationalities);
            UIUtilities.BindLookUpEdit(lueHomeCity, LookUpServices.Cities, displayMember: "Value", valueMember: "Value" );
            UIUtilities.BindLookUpEdit(lueJobCity, LookUpServices.Cities);
        }

        private void sbSavePatient_Click(object sender, EventArgs e)
        {
            SavePatient();
        }

        private void SavePatient()
        {
            if (String.IsNullOrWhiteSpace(Patient.FirstName))
            {
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Hastanın Adını Kontrol Ediniz", "Hasta Kayıt Hatası", true);
                return;
            }
            if (String.IsNullOrWhiteSpace(Patient.LastName))
            {
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Hastanın Soyadını Kontrol Ediniz", "Hasta Kayıt Hatası", true);
                return;
            }
            if (Patient.BirthDate == null || Patient.BirthDate < new DateTime(1800,1,1))
            {
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Hastanın Doğum Tarihini Kontrol Ediniz", "Hasta Kayıt Hatası", true);
                return;
            }

            Patient.PatientLimit = 0;

            try
            {
                if (String.IsNullOrWhiteSpace(Patient.PatientNo))
                {
                    teFirstName.Focus();
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
                SimpleMsgBoxForm.ShowMsgBox("Hasta Kayıt Edilemedi:" + error.Message, "Hasta Kayıt Hatası", true);
            }
        }

        private void OpenNewForm()
        {
            (MdiParent as frmMain).OpenSGKPatient(Patient.PatientNo);
            Close();
        }
        #region Mernis

        private void sbMernis_Click(object sender, EventArgs e)
        {
            CallMernis();
        }

        private void CallMernis()
        {
            if (mernisSorgu.IsWorking)
            {
                SimpleMsgBoxForm.ShowMsgBox("Şu anda sürmekte olan Mernis işlemi var. Lütfen bekleyiniz.", "Mernis İşlemleri", true);
            }
            else if (!String.IsNullOrWhiteSpace(teTCID.Text))
            {
                EnableForMernis(false);
                mernisSorgu.CallMernis(teTCID.Text);
            }
        }

        private void EnableForMernis(bool enable)
        {
            sbMernis.Enabled = enable;
            sbSavePatient.Enabled = enable;
            sbMedula.Enabled = enable;
        }

        private void mernisSorgu_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            EnableForMernis(true);
            if (mernisSorgu.IsOK)
            {
                Patient.TCId = mernisSorgu.NufusCuzdani.TCKimlikNo.ToString();
                if (!String.IsNullOrWhiteSpace(mernisSorgu.NufusCuzdani.Ad))
                    Patient.FirstName = mernisSorgu.NufusCuzdani.Ad;
                if (!String.IsNullOrWhiteSpace(mernisSorgu.NufusCuzdani.Soyad))
                    Patient.LastName = mernisSorgu.NufusCuzdani.Soyad;
                if (!String.IsNullOrWhiteSpace(mernisSorgu.NufusCuzdani.AnaAd))
                    Patient.MotherName = mernisSorgu.NufusCuzdani.AnaAd;
                if (!String.IsNullOrWhiteSpace(mernisSorgu.NufusCuzdani.BabaAd))
                    Patient.FatherName = mernisSorgu.NufusCuzdani.BabaAd;
                if (mernisSorgu.KisiBilgisi.TemelBilgisi.Cinsiyet == CinsiyetTipi.Erkek)
                    Patient.Sex = "1";
                else
                    Patient.Sex = "2";

                if (mernisSorgu.NufusCuzdani.DogumTarih.Yil != 0)
                {
                    Patient.BirthDate = new DateTime(mernisSorgu.NufusCuzdani.DogumTarih.Yil,
                        Math.Max(mernisSorgu.NufusCuzdani.DogumTarih.Ay, 1),
                        Math.Max(mernisSorgu.NufusCuzdani.DogumTarih.Gun, 1));
                }
                else
                    SimpleMsgBoxForm.ShowMsgBox("Mernis'ten Geçerli Bir Doğum Tarihi Gelmedi, \r\nLütfen Doğum Tarihini Kontrol Ediniz", "Doğum Tarihi Uyarısı", true);

                if (!String.IsNullOrWhiteSpace(mernisSorgu.NufusCuzdani.DogumYer))
                    Patient.BirthPlace = mernisSorgu.NufusCuzdani.DogumYer;

                if (mernisSorgu.KisiBilgisi.DurumBilgisi.MedeniHal == MedeniHalTipi.Evli)
                    Patient.MaritalStatus = "E";
                else
                    Patient.MaritalStatus = "B";

                if (!String.IsNullOrWhiteSpace(mernisSorgu.TCKimlikResponse.IlAd))
                    Patient.RegisteredCity = mernisSorgu.TCKimlikResponse.IlAd;
                if (!String.IsNullOrWhiteSpace(mernisSorgu.TCKimlikResponse.IlceAd))
                    Patient.RegisteredTown = mernisSorgu.TCKimlikResponse.IlceAd;
                if (!String.IsNullOrWhiteSpace(mernisSorgu.NufusCuzdani.VerildigiIlceAd))
                    Patient.IDPlace = mernisSorgu.NufusCuzdani.VerildigiIlceAd;

                if (mernisSorgu.NufusCuzdani.VerilmeTarih.Yil != 0 &&
                    mernisSorgu.NufusCuzdani.VerilmeTarih.Ay != 0 &&
                    mernisSorgu.NufusCuzdani.VerilmeTarih.Gun != 0)
                {
                    Patient.IDDate = new DateTime(mernisSorgu.NufusCuzdani.VerilmeTarih.Yil,
                       mernisSorgu.NufusCuzdani.VerilmeTarih.Ay,
                       mernisSorgu.NufusCuzdani.VerilmeTarih.Gun).ToString();
                }

                if (!String.IsNullOrWhiteSpace(mernisSorgu.NufusCuzdani.CuzdanSeri) && mernisSorgu.NufusCuzdani.CuzdanNo != 0)
                    Patient.IDNO = String.Format("{0}-{1}", mernisSorgu.NufusCuzdani.CuzdanSeri, mernisSorgu.NufusCuzdani.CuzdanNo);

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
            using (SelectPolyclinicForm frm = new SelectPolyclinicForm(PatientServices.IsSGKSameDay(Patient)) { InsuranceCompany = Patient.InsuranceCompany })
            {
                frm.ShowDialog();
                if (frm.IsSelected && frm.Doctor != null && IsNewPolyclinicOK(frm.Doctor))
                {
                    _BranchCode = frm.BranchCode;
                    if (frm.NewInsuranceCompany != Patient.InsuranceCompany)
                    {
                        PatientServices.ChangeInsuranceCompany(Session, UIUtilities.CurrentUser, Patient, new List<PatientVisit>(), new List<PatientVisitDetailWithProduct>(), frm.NewInsuranceCompany);
                        ReLoadPatient();
                    }
                    _Doctor = frm.Doctor;
                    PatientServices.AddSGKPolyclinic(Session, UIUtilities.CurrentUser, Patient, _Doctor, frm.SameDay);
                    ReLoadPatient();
                    currentPatientVisit = Patient.PatientVisits[0];
                    CallMedulaProvision();
                }
            }
            //SavePatient();
        }

        private bool IsNewPolyclinicOK(Doctor doctor)
        {
            string branchCode = doctor.Service.BranchCode;
            foreach(PatientVisit pv in Patient.PatientVisits)
            {
                if (pv.VisitDate.Date == DateTime.Today && pv.BranchCode == branchCode)
                {
                    if (SimpleMsgBoxForm.ShowYesNo("Aynı Gün İçinde Bu Branştan Kart Açılmış, Yeni Kart Açmak İstiyor musunuz?", "Poliklinik Uyarısı", true) == System.Windows.Forms.DialogResult.Yes)
                        return true;
                    else
                        return false;
                }
            
            }
            return true;
        }
        private void sbMedula_Click(object sender, EventArgs e)
        {
            currentPatientVisit = PatientVisitControl1.gvPatientVisit.GetFocusedRow() as PatientVisit;
            CallMedulaProvision();
        }

        private void EnableForMedula(bool enable)
        {
            _IsWaitingForMedulaProvision = !enable;
            sbMernis.Enabled = enable;
            sbSavePatient.Enabled = enable;
            sbMedula.Enabled = enable;
            sbPoliklinik.Enabled = enable;
            sbInvoice.Enabled = enable;
            sbVoucher.Enabled = enable;
            PatientVisitControl1.gcPatientVisit.Enabled = enable;
            PatientVisitControl.gcPatientVisit.Enabled = enable;
        }

        private void CallMedulaProvision()
        {
            if (LookUpServices.IsNotSGK(Patient.InsuranceCompany.Code)) return;

            if (currentPatientVisit == null)
            {
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Bir Ziyaret Kartı Seçiniz!", "Medula İşlemleri", true);
                return;
            }
            if (!String.IsNullOrWhiteSpace(currentPatientVisit.TAKIPNO))
            {
                SimpleMsgBoxForm.ShowMsgBox("Seçili Kart İçin Provizyon Alınmış!", "Medula İşlemleri", true);
                return;
            }
            _Doctor = currentPatientVisit.Doctor;
            if (_Doctor == null)
            {
                SimpleMsgBoxForm.ShowMsgBox("Seçili Kartta Geçerli Doktor Tanımı Yok!", "Medula İşlemleri", true);
                return;
            }
            if (_IsWaitingForMedulaProvision)
            {
                SimpleMsgBoxForm.ShowMsgBox("Şu anda sürmekte olan Provizyon işlemi var. Lütfen bekleyiniz.", "Medula İşlemleri", true);
                return;
            }
            string TCID = teTCID.Text;
            if (!LookUpServices.IsValidTCID(TCID))
            {
                SimpleMsgBoxForm.ShowMsgBox("T.C. Kimlik No Geçerli Değil!", "Medula İşlemleri", true);
                return;
            }

            EnableForMedula(false);

            if (LookUpServices.IsSGK(Patient.InsuranceCompany.Code))
                medulaSorgu.lueProvisionType.EditValue = ProvisionType.NormalValue;
            else if (LookUpServices.IsSGKAcil(Patient.InsuranceCompany.Code))
                medulaSorgu.lueProvisionType.EditValue = ProvisionType.EmergencyValue;

            medulaSorgu.lueBranchCode.EditValue = _BranchCode;
            
            if (String.IsNullOrWhiteSpace(medulaSorgu.teRelatedFollowUpNo.Text))
                medulaSorgu.teRelatedFollowUpNo.Text = GetRelatedFollowUpNo();

            medulaSorgu.CallMedula(teTCID.Text, currentPatientVisit.VisitDate);

        }

        private string GetRelatedFollowUpNo()
        {
            string result = "";
            
            for (int i = 0; i <= PatientVisitControl1.gvPatientVisit.RowCount; i++)
            {
                PatientVisit pv = PatientVisitControl1.gvPatientVisit.GetRow(i) as PatientVisit;
                if (pv != null && pv.VisitDate.Date == DateTime.Today)
                {
                    if (!LookUpServices.IsNotSGK(pv.PSG) && !String.IsNullOrWhiteSpace(pv.TAKIPNO))
                        result = Patient.PatientVisits[i].TAKIPNO;
                }
            }
            return result;
        }

        private void medulaSorgu_OnMedulaHastaKabulCompleted(object sender, MedulaProvisionCompletedEventArgs e)
        {
            //UserLookAndFeel ulaf = new UserLookAndFeel();

            try
            {
                if (medulaSorgu.IsOK)
                {
                    SimpleMsgBoxForm.ShowMsgBox(String.Format("{0} için {1} Medula Sorgusu Sonucu:{2}: {3}", Patient.FullName, medulaSorgu.lueInsuranceType.Text, e.Result.SonucKodu, e.Result.SonucMesaji), "Medula Sorgu Sonucu");

                    if (e.Result.SonucKodu == "0000" || e.Result.SonucKodu == "9000")
                    {
                        if (currentPatientVisit != null)
                        {
                            PatientServices.UpdatePatientRecordsFromMedula(Session, UIUtilities.CurrentUser, Patient, currentPatientVisit, e.Result);
                            RefreshGrid();

                            // Reset the values to normal
                            medulaSorgu.teRelatedFollowUpNo.Text = "";
                            medulaSorgu.lueTreatmentType.EditValue = TreatmentType.DefaultValue;
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
                if (medulaFollowUpQueryControl.IsOK)
                {
                    if (e.Result.sonucKodu == "0000")
                    {
                        if (currentPatientVisit != null)
                        {
                            MedulaProvisionResult mpr = new MedulaProvisionResult() { BranchCode = e.Result.bransKodu, 
                                                                                        HastaBasvuruNo = e.Result.hastaBasvuruNo, 
                                                                                        Ad = e.Result.hastaBilgileri.ad, 
                                                                                        Cinsiyet = e.Result.hastaBilgileri.cinsiyet, 
                                                                                        DogumTarihi = e.Result.hastaBilgileri.dogumTarihi, 
                                                                                        SigortaliTuru = e.Result.hastaBilgileri.sigortaliTuru, 
                                                                                        Soyad = e.Result.hastaBilgileri.soyad, 
                                                                                        TCKimlikNo = e.Result.hastaBilgileri.tcKimlikNo, 
                                                                                        RelatedFollowUpNo = e.Result.ilkTakipNo, /*mpr.BranchCode                      = e.Result.kayitTarihi;*/
                                                                                        ProvisionType = e.Result.provizyonTipi, /*mpr.BranchCode                      = e.Result.sevkDurumu;*/
                                                                                        SonucKodu = e.Result.sonucKodu, 
                                                                                        SonucMesaji = e.Result.sonucMesaji, /*mpr.BranchCode                      = e.Result.takipDurumu;*/
                                                                                        TakipNo = e.Result.takipNo, /*mpr.BranchCode                      = e.Result.takipTarihi;*/
                                                                                        FollowUpType = e.Result.takipTipi, 
                                                                                        TreatmentType = e.Result.tedaviTipi };
                            //mpr.BranchCode                      = e.Result.tesisKodu;
                            //mpr.BranchCode                      = e.Result.takipDurumu;

                            PatientServices.UpdatePatientRecordsFromMedula(Session, UIUtilities.CurrentUser, Patient, currentPatientVisit, mpr);
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

        private void GenerateInvoice()
        {
            string NewTellerInvoiceNo = teInvoiceNo.Text;
            const string paymentType = "N";
            string POSType = null;

            double ProductTotal = 0;
            double VATTotal = 0;
            double InvoiceTotal = 0;
            double VATPercent = 0;
            //double Payment = 0;

            if (String.IsNullOrWhiteSpace(NewTellerInvoiceNo))
            {
                SimpleMsgBoxForm.ShowMsgBox("Bu Kullanıcıya Vezne Tanımlı Değildir!", "Vezne Uyarısı", true);
                return;
            }

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
                teInvoiceNo.Text = "";
                RefreshPatientBalance();
            }
        }
        private void sbInvoice_Click(object sender, EventArgs e)
        {
            GenerateInvoice();
        }

        private void GenerateVoucher()
        {
            string NewTellerVoucherNo = teVoucherNo.Text;
            string paymentType = "N";
            string POSType = null;

            double ProductTotal = 0;

            if (String.IsNullOrWhiteSpace(NewTellerVoucherNo))
            {
                SimpleMsgBoxForm.ShowMsgBox("Bu Kullanıcıya Vezne Tanımlı Değildir!", "Vezne Uyarısı", true);
                return;
            }

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
                teVoucherNo.Text = "";
                RefreshPatientBalance();
            }
        }
        private void sbVoucher_Click(object sender, EventArgs e)
        {
            GenerateVoucher();
        }

        private void PrintCommitmentLetter()
        {
            UIUtilities.PrintTaahhutname(Patient, true);
        }
        private void sbTaahutname_Click(object sender, EventArgs e)
        {
            PrintCommitmentLetter();
        }

        private void sbDeletePatientVisitDetail_Click(object sender, EventArgs e)
        {
            PatientVisitDetail pvd = currentPVD;
            if (pvd == null)
                return;
            if (!pvd.IsOKForDelete())
            {
                SimpleMsgBoxForm.ShowMsgBox("Fatura veya Makbuz Kesilmiş Kayıtı Silemezsiniz", "İşlem Silme Uyarısı", true);
                return;
            }
            if (SimpleMsgBoxForm.ShowYesNo("Bu İşlem Kaydını Silmek İstiyor Musunuz?", "İşlem Silme Uyarısı", true) == DialogResult.Yes)
            {
                try
                {
                    if (PatientServices.DeletePatientVisitDetail(Session, UIUtilities.CurrentUser, pvd))
                    {
                        SimpleMsgBoxForm.ShowMsgBox("İşlem Kaydı Başarıyla Silindi", "İşlem Silme Uyarısı");
                        RefreshGrid();
                    }
                    else
                    {
                        SimpleMsgBoxForm.ShowMsgBox("İşlem Kaydı Silinemedi", "İşlem Silme Uyarısı", true);
                    }
                }
                catch
                {
                    SimpleMsgBoxForm.ShowMsgBox("İşlem Kaydı Silinemedi", "İşlem Silme Uyarısı", true);
                }
            }
        }

        private void sbDeletePatientVisit_Click(object sender, EventArgs e)
        {
            PatientVisit pv = PatientVisitControl1.gvPatientVisit.GetFocusedRow() as PatientVisit;
            if (pv == null)
                return;
            if (!pv.IsOKForDelete())
            {
                SimpleMsgBoxForm.ShowMsgBox("Bu Ziyaret Kartını Silemezseniz", "Ziyaret Kartı Silme Uyarısı", true);
                return;
            }
            if (SimpleMsgBoxForm.ShowYesNo("Bu Ziyaret Kartını Bütün İşlemleri İle Birlikte Silmek İstiyor Musunuz?", "Ziyaret Kartı Silme Uyarısı", true) == DialogResult.Yes)
            {
                if (!String.IsNullOrWhiteSpace(pv.TAKIPNO))
                    if (SimpleMsgBoxForm.ShowYesNo("Bu Ziyaret Kartının Medula Takip Numarasını Silmek İstiyor Musunuz?", "Ziyaret Kartı Silme Uyarısı", true) == DialogResult.Yes)
                        medulaFollowUpQueryControl.CallMedulaHastaKabulIptal(pv.TAKIPNO);

                try
                {
                    if (PatientServices.DeletePatientVisit(Session, UIUtilities.CurrentUser, pv))
                    {
                        SimpleMsgBoxForm.ShowMsgBox("Ziyaret Kartı Başarıyla Silindi", "Ziyaret Kartı Silme Uyarısı");
                        RefreshGrid();
                    }
                    else
                    {
                        SimpleMsgBoxForm.ShowMsgBox("Ziyaret Kartı Silinemedi", "Ziyaret Kartı Silme Uyarısı", true);
                    }
                }
                catch
                {
                    SimpleMsgBoxForm.ShowMsgBox("Ziyaret Kartı Silinemedi", "Ziyaret Kartı Silme Uyarısı", true);
                }
            }
        }

        private void RefreshGrid()
        {
            PatientVisitControl.gvPatientVisit.BeginDataUpdate();
            PatientVisitControl.gcPatientVisit.RefreshDataSource();
            PatientVisitControl.gvPatientVisit.CollapseAllDetails();
            PatientVisitControl.gvPatientVisit.EndDataUpdate();
            PatientVisitControl1.gvPatientVisit.BeginDataUpdate();
            PatientVisitControl1.gcPatientVisit.RefreshDataSource();
            PatientVisitControl1.gvPatientVisit.CollapseAllDetails();
            PatientVisitControl1.gvPatientVisit.EndDataUpdate();
            RefreshPatientBalance();
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
                        teVoucherNo.Text = LookUpServices.GetNewTellerVoucherNo(UIUtilities.GetVoucherUser(), false);
                    }
                    else
                    {
                        voucherPVD = null;
                        teVoucherNo.Text = "";
                    }
                }
                else
                {
                    if (String.IsNullOrWhiteSpace(pvd.MAKNO))
                    {
                        invoicePVD = pvd;
                        teInvoiceNo.Text = LookUpServices.GetNewTellerInvoiceNo(UIUtilities.GetInvoiceUser(), false);
                    }
                    else
                    {
                        invoicePVD = null;
                        teInvoiceNo.Text = "";
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
            if (medulaFollowUpQueryControl.IsOK)
                UpdatePatientVisitWithMedulaProvisionDelete(e.Result.takipNo);
        }

        private void UpdatePatientVisitWithMedulaProvisionDelete(string takipNo)
        {
            if (PatientServices.UpdatePatientVisitWithMedulaProvisionDelete(Session, UIUtilities.CurrentUser, Patient, takipNo))
                RefreshGrid();
        }

        private void SGKPatientForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                CallMernis();
            else if (e.KeyCode == Keys.F2)
                CallMedulaProvision();
            else if (e.KeyCode == Keys.F3)
                CloseForm();
            else if (e.KeyCode == Keys.F4)
                AddPatientVisitDetail();
            else if (e.KeyCode == Keys.F5)
                SavePatient();
            else if (e.KeyCode == Keys.F6)
                PrintCommitmentLetter();
            else if (e.KeyCode == Keys.F7)
                SearchPatient();
            else if (e.KeyCode == Keys.F8)
                ProcessNewPolyclinic();
            else if (e.KeyCode == Keys.F9)
                AddHospitalizationRecord();
            else if (e.KeyCode == Keys.F10)
                AddEmergencyRecord();
            else if (e.KeyCode == Keys.F11)
                GenerateInvoice();
            else if (e.KeyCode == Keys.F12)
                GenerateVoucher();
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            Close();
        }

        private void sbAddPatientVisitDetail_Click(object sender, EventArgs e)
        {
            AddPatientVisitDetail();
            //SavePatient();
        }

        private void AddPatientVisitDetail()
        {
            currentPatientVisit = PatientVisitControl1.gvPatientVisit.GetFocusedRow() as PatientVisit;
            if (Patient != null && Patient.InsuranceCompany != null && currentPatientVisit != null)
            {
                using (SelectFunctionForm frm = new SelectFunctionForm() { PatientVisit = currentPatientVisit, PriceListCode = Patient.InsuranceCompany.GetPriceList(currentPatientVisit.VisitType) })
                {
                    frm.ShowDialog();
                    if (frm.IsSelected)
                    {
                        PatientServices.AddPatientVisitDetails(Session, UIUtilities.CurrentUser, Patient, currentPatientVisit, frm.SelectedProducts);
                        ReLoadPatient();
                    }
                }
            }
        }

        #region Change Insurance Company
        private void AttachMenuHandlers()
        {
            iSGK.ItemClick += (o, args) => ChangeInsuranceCompany(LookUpServices.GetSGK(Session));
            iSGKAcil.ItemClick += (o, args) => ChangeInsuranceCompany(LookUpServices.GetSGKAcil(Session));
            iNormal.ItemClick += (o, args) => ChangeInsuranceCompany(LookUpServices.GetNormalPatientCode(Session));
            iOzelHasta.ItemClick += (o, args) => ChangeInsuranceCompany(LookUpServices.GetSpecialPatientCode(Session));
            ddbChangeInsuranceCompany.Click += (o, args) => SelectAndChangeInsuranceCompany();

            iSGKFast.ItemClick += (o, args) => ChangeInsuranceCompanyFast(LookUpServices.GetSGK(Session));
            iSGKAcilFast.ItemClick += (o, args) => ChangeInsuranceCompanyFast(LookUpServices.GetSGKAcil(Session));
            iNormalFast.ItemClick += (o, args) => ChangeInsuranceCompanyFast(LookUpServices.GetNormalPatientCode(Session));
            iOzelHastaFast.ItemClick += (o, args) => ChangeInsuranceCompanyFast(LookUpServices.GetSpecialPatientCode(Session));
            ddbChangeInsCompFast.Click += (o, args) => SelectAndChangeInsuranceCompanyFast();
        }

        private void SelectAndChangeInsuranceCompany()
        {
            using (SelectInsuranceCompanyForm frm = new SelectInsuranceCompanyForm())
            {
                frm.ShowDialog();
                if (frm.IsSelected)
                    ChangeInsuranceCompany(frm.InsuranceCompany);
            }
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
                    SimpleMsgBoxForm.ShowMsgBox("Kurum Değiştirme İşlemi Başarılı!", "Kurum Değiştirme İşlemi");
                    ReLoadPatient();
                }
                catch (Exception e)
                {
                    SimpleMsgBoxForm.ShowMsgBox("Kurum Değiştirme İşlemi Başarısız Oldu:" + e.Message, "Kurum Değiştirme İşlemi", true);
                }
            }

        }

        private void SelectAndChangeInsuranceCompanyFast()
        {
            using (SelectInsuranceCompanyForm frm = new SelectInsuranceCompanyForm())
            {
                frm.ShowDialog();
                if (frm.IsSelected)
                    ChangeInsuranceCompanyFast(frm.InsuranceCompany);
            }
        }

        private void ChangeInsuranceCompanyFast(InsuranceCompany newInsuranceCompany)
        {
            if (Patient.InsuranceCompany != newInsuranceCompany)
            {
                Patient.InsuranceCompany = newInsuranceCompany;
                teInsuranceCompany.Text = Patient.InsuranceCompany.Code;
                if (!String.IsNullOrWhiteSpace(Patient.PatientNo))
                    SavePatient();
            }
        }
#endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            timerHastaKabulOku.Enabled = false;
            EnableForMedula(false);
            medulaFollowUpQueryControl.CallMedulaHastaKabulOku(_OldProvisionCode);

        }

        private void sbAra_Click(object sender, EventArgs e)
        {
            SearchPatient();
        }

        private void SearchPatient()
        {
            (MdiParent as frmMain).OpenSearchPatientForm();
        }

        private void sbYatis_Click(object sender, EventArgs e)
        {
            AddHospitalizationRecord();
        }

        private void AddHospitalizationRecord()
        {
        }

        private void sbAcil_Click(object sender, EventArgs e)
        {
            AddEmergencyRecord();
        }

        private void AddEmergencyRecord()
        {
        }

        /// <summary>
        /// TODO Add generalized therapy parameters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbAddTreatmentCard_Click(object sender, EventArgs e)
        {
            //SelectPolyclinicForm frm = new SelectPolyclinicForm(PatientServices.IsSGKSameDay(Patient));
            //frm.ShowDialog();
            PatientVisit pv = GetRelatedPTPatientVisit();

            if (pv != null)
            {
                _Doctor = pv.Doctor;
                _BranchCode = _Doctor.Service.BranchCode;
                currentPatientVisit = PatientServices.AddNewPatientVisit(Session, UIUtilities.CurrentUser, Patient, _Doctor, _Doctor.Service.Code, 0);
                PatientVisitRecord pvr = PatientServices.AddNewPatientVisitRecord(Session, UIUtilities.CurrentUser, currentPatientVisit);
                ReLoadPatient();
                PatientVisitControl1.gvPatientVisit.FocusedRowHandle = 0;
                currentPatientVisit = PatientVisitControl1.gvPatientVisit.GetFocusedRow() as PatientVisit;
                AddPatientVisitDetail();
                medulaSorgu.lueTreatmentType.EditValue = TreatmentType.PhysicalTherapy;
                medulaSorgu.teRelatedFollowUpNo.Text = pv.TAKIPNO;
                CallMedulaProvision();
            }
            else
                SimpleMsgBoxForm.ShowMsgBox("10 Gün İçinde Yapılmış Fizik Tedavi Polikliniği Bulunamadı!", "Fizik Tedavi İşlemleri", true);


        }
        private PatientVisit GetRelatedPTPatientVisit()
        {
            DateTime endDate = DateTime.Today.AddDays(-12);

            for (int i = 0; i <= PatientVisitControl.gvPatientVisit.RowCount; i++)
            {
                PatientVisit pv = PatientVisitControl.gvPatientVisit.GetRow(i) as PatientVisit;
                if (pv != null && pv.VisitDate.Date >= endDate && pv.Servis == "23")
                    //if (pv != null && pv.VisitDate.Date >= endDate && pv.Servis == "5018")
                    return pv;
            }
            return null;
        }

        private void PatientVisitControl1_PatientVisitClick(object sender, EventArgs e)
        {
            currentPatientVisit = PatientVisitControl1.gvPatientVisit.GetFocusedRow() as PatientVisit;
            if (currentPatientVisit != null && currentPatientVisit.Doctor != null && currentPatientVisit.Doctor.Service != null)
                medulaSorgu.lueBranchCode.EditValue = currentPatientVisit.Doctor.Service.BranchCode;
        }

        private void sbRefresh_Click(object sender, EventArgs e)
        {
            ReLoadPatient();
        }

        private void sbAddMedicine_Click(object sender, EventArgs e)
        {
            currentPatientVisit = PatientVisitControl1.gvPatientVisit.GetFocusedRow() as PatientVisit;
            if (Patient != null && Patient.InsuranceCompany != null && currentPatientVisit != null)
            {
                using (SelectMedicineForm frm = new SelectMedicineForm() { PatientVisit = currentPatientVisit, PriceListCode = Patient.InsuranceCompany.GetPriceList(currentPatientVisit.VisitType) })
                {
                    frm.InitForm();
                    frm.ShowDialog();
                    //if (frm.IsSelected)
                    //    ChangeInsuranceCompany(frm.InsuranceCompany);
                }
            }
        }

        private void sbChangeAmount_Click(object sender, EventArgs e)
        {
            PatientVisitDetail pvd = currentPVD;
            if (pvd != null)
            {
                if (!String.IsNullOrWhiteSpace(pvd.MAKNO))
                {
                    SimpleMsgBoxForm.ShowMsgBox("Bu Kayıta Fatura Kesilmiş, Miktarı Değiştiremezsiniz", "Miktar Değiştirme Uyarısı", true);
                    return;
                }

                double Amount = pvd.ADET;
                using (SimpleDialogForm frm = new SimpleDialogForm("Lütfen Adet Giriniz", Amount.ToString()))
                {
                    frm.ShowDialog();
                    if (frm.IsOK)
                    {
                        if (Double.TryParse(frm.TheValue, out Amount))
                        {
                            pvd.ADET = Amount;
                            //this.gcSelectedProducts.RefreshDataSource();
                        }
                    }
                }

            }

        }
    }
}