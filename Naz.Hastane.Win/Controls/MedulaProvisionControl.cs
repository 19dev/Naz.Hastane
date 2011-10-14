using System;
using Naz.Hastane.Data.Entities.Medula;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Medula.HastaKabulIslemleri;
using System.Windows.Forms;
using Naz.Hastane.Data.Entities.LookUp.MedulaProvision;

namespace Naz.Hastane.Win.Controls
{
    public partial class MedulaProvisionControl : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void MedulaProvisionControlCompleted(Object sender, MedulaProvisionCompletedEventArgs e);

        public event MedulaProvisionControlCompleted OnMedulaHastaKabulCompleted;
//        public event System.EventHandler<MedulaProvisionCompletedEventArgs> OnMedulaHastaKabulCompleted;

        private HastaKabulIslemleriClient hki;

        private bool _IsWorking;
        public bool IsWorking 
        { 
            get{ return _IsWorking;}
            set
            {
                _IsWorking = value;
                EnableControls(!_IsWorking);
            }
        }
        public bool IsOK { get; set; }

        public MedulaProvisionControl()
        {
            InitializeComponent();
        }

        private void MedulaProvisionControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode) LoadLookUps();
            teFollowUpNo.Text = "";
            tePatientApplicationNo.Text = "";
            teRelatedFollowUpNo.Text = "";
        }

        private void LoadLookUps()
        {
            UIUtilities.BindLookUpEdit(lueBranchCode, LookUpServices.BranchCodes, initialValue: BranchCode.DefaultValue);
            UIUtilities.BindLookUpEdit(lueFollowUpType, LookUpServices.FollowUpTypes, initialValue: FollowUpType.DefaultValue);
            UIUtilities.BindLookUpEdit(lueInsuranceType, LookUpServices.InsuranceTypes, initialValue: InsuranceType.DefaultValue);
            UIUtilities.BindLookUpEdit(lueProvisionType, LookUpServices.ProvisionTypes, initialValue: ProvisionType.DefaultValue);
            UIUtilities.BindLookUpEdit(lueRelationType, LookUpServices.RelationTypes, initialValue: RelationType.DefaultValue);
            UIUtilities.BindLookUpEdit(lueTransferorInstitution, LookUpServices.TransferorInstitutions, initialValue: TransferorInstitution.DefaultValue);
            UIUtilities.BindLookUpEdit(lueTreatmentStyle, LookUpServices.TreatmentStyles, initialValue: TreatmentStyle.DefaultValue);
            UIUtilities.BindLookUpEdit(lueTreatmentType, LookUpServices.TreatmentTypes, initialValue: TreatmentType.DefaultValue);

            //medulaSorgu.lueInsuranceType.EditValue = InsuranceType.DefaultValue; // Hasta'dan alıyor
            //medulaSorgu.lueTransferorInstitution.EditValue = TransferorInstitution.DefaultValue; // Hasta'dan alıyor
        }

        public void CallMedula(string TCID, DateTime date)
        {
            if (IsWorking) return;

            IsWorking = true;

            hki = new HastaKabulIslemleriClient();
            System.Net.ServicePointManager.Expect100Continue = false;

            hki.ClientCredentials.UserName.UserName = "10343154";
            hki.ClientCredentials.UserName.Password = "19031903";
            //hki.ClientCredentials.UserName.Password = "123456"; for Test site

            hki.hastaKabulCompleted += new EventHandler<hastaKabulCompletedEventArgs>(OnHastaKabulCompleted);
            
            ProvizyonGirisDVO pgd = new ProvizyonGirisDVO();
            pgd.bransKodu = lueBranchCode.EditValue.ToString();
            pgd.devredilenKurum = lueTransferorInstitution.EditValue.ToString();
            pgd.donorTCKimlikNo = "";
            pgd.hastaTCKimlikNo = TCID;
            pgd.provizyonTarihi = date.ToString("dd/MM/yyyy");
            pgd.provizyonTipi = lueProvisionType.EditValue.ToString();
            pgd.saglikTesisKodu = 10343154;
            pgd.sigortaliTuru = lueInsuranceType.EditValue.ToString();
            pgd.takipNo = teRelatedFollowUpNo.Text;
            pgd.takipTipi = lueFollowUpType.EditValue.ToString();
            pgd.tedaviTipi = lueTreatmentType.EditValue.ToString();
            pgd.tedaviTuru = lueTreatmentStyle.EditValue.ToString();
            pgd.yakinlikKodu = lueRelationType.EditValue.ToString();
            pgd.yatisBitisTarihi = "";

            lblStatus.Text = "Medula Sorgusu Yapılıyor...";
            IsOK = false;

            hki.hastaKabulAsync(pgd);

        }

        private void EnableControls(bool enable)
        {
            foreach (Control c in layoutControl1.Controls)
                c.Enabled = enable;
        }

        void OnHastaKabulCompleted(Object sender, hastaKabulCompletedEventArgs e)
        {
            IsWorking = false;
            MedulaProvisionResult mpr = new MedulaProvisionResult();
            MedulaProvisionResult[] mprs = new MedulaProvisionResult[1];
            mprs[0] = mpr;
            try
            {
                lblStatus.Text = e.Result.sonucKodu + ": " + e.Result.sonucMesaji;
                mpr.SonucKodu = e.Result.sonucKodu;
                mpr.SonucMesaji = e.Result.sonucMesaji;

                if (e.Result.sonucKodu == "0000" || e.Result.sonucKodu == "9000")
                {
                    if (e.Result.hastaBilgileri != null && !String.IsNullOrWhiteSpace(e.Result.hastaBilgileri.ad))
                    {
                        mpr.Ad = e.Result.hastaBilgileri.ad;
                        mpr.Soyad = e.Result.hastaBilgileri.soyad;
                        mpr.Cinsiyet = e.Result.hastaBilgileri.cinsiyet;
                        mpr.DogumTarihi = e.Result.hastaBilgileri.dogumTarihi;
                        mpr.TCKimlikNo = e.Result.hastaBilgileri.tcKimlikNo;
                        mpr.SigortaliTuru = e.Result.hastaBilgileri.sigortaliTuru;
                        lueInsuranceType.EditValue = e.Result.hastaBilgileri.sigortaliTuru;
                    }

                    mpr.HastaBasvuruNo = e.Result.hastaBasvuruNo;
                    mpr.TakipNo = e.Result.takipNo;

                    mpr.BranchCode = lueBranchCode.EditValue.ToString();
                    mpr.RelatedFollowUpNo = teRelatedFollowUpNo.Text;
                    mpr.FollowUpType = lueFollowUpType.EditValue.ToString();
                    mpr.ProvisionType = lueProvisionType.EditValue.ToString();
                    mpr.TreatmentType = lueTreatmentType.EditValue.ToString();
                    mpr.TreatmentStyle = lueTreatmentStyle.EditValue.ToString();

                    mpr.TransferorInstitution = lueTransferorInstitution.EditValue.ToString();

                    teFollowUpNo.Text = e.Result.takipNo;
                    tePatientApplicationNo.Text = e.Result.hastaBasvuruNo;
                }
                IsOK = true;
            }
            catch
            {
                mpr.SonucKodu = "xxxx";
                mpr.SonucMesaji = "Medula'dan Sonuç Alınamadı!";

                IsOK = false;
            }
            finally
            {
                MedulaProvisionCompletedEventArgs mpcea = new MedulaProvisionCompletedEventArgs(mprs, e.Error, e.Cancelled, e.UserState);
                if (OnMedulaHastaKabulCompleted != null)
                    OnMedulaHastaKabulCompleted(this, mpcea);
                hki = null;
            }
        }
    }
    public class MedulaProvisionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] _results;

        public MedulaProvisionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            _results = results;
        }

        public MedulaProvisionResult Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return ((MedulaProvisionResult)(_results[0]));
            }
        }
    }

}
