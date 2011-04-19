using System;
using Naz.Hastane.Data.Entities.Medula;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Medula.HastaKabulIslemleri;

namespace Naz.Hastane.Win.Controls
{
    public partial class MedulaProvisionControl : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void MedulaProvisionControlCompleted(Object sender, MedulaProvisionCompletedEventArgs e);

        public event MedulaProvisionControlCompleted OnMedulaHastaKabulCompleted;
//        public event System.EventHandler<MedulaProvisionCompletedEventArgs> OnMedulaHastaKabulCompleted;

        private HastaKabulIslemleriClient hki;

        private bool _IsWorking = false;
        public bool IsWorking
        {
            get { return _IsWorking; }
            private set { _IsWorking = value; }
        }

        public MedulaProvisionControl()
        {
            InitializeComponent();
        }

        private void MedulaProvisionControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode) LoadLookUps();
            this.teFollowUpNo.Text = "";
            this.tePatientApplicationNo.Text = "";
            this.teRelatedFollowUpNo.Text = "";
        }

        private void LoadLookUps()
        {
            UIUtilities.BindLookUpEdit(this.lueBranchCode, LookUpServices.BranchCodes);
            UIUtilities.BindLookUpEdit(this.lueFollowUpType, LookUpServices.FollowUpTypes);
            UIUtilities.BindLookUpEdit(this.lueInsuranceType, LookUpServices.InsuranceTypes);
            UIUtilities.BindLookUpEdit(this.lueProvisionType, LookUpServices.ProvisionTypes);
            UIUtilities.BindLookUpEdit(this.lueRelationType, LookUpServices.RelationTypes);
            UIUtilities.BindLookUpEdit(this.lueTransferorInstitution, LookUpServices.TransferorInstitutions);
            UIUtilities.BindLookUpEdit(this.lueTreatmentStyle, LookUpServices.TreatmentStyles);
            UIUtilities.BindLookUpEdit(this.lueTreatmentType, LookUpServices.TreatmentTypes);
        }

        public void CallMedula(string TCID)
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
            pgd.provizyonTarihi = DateTime.Now.ToString("dd/MM/yyyy");
            pgd.provizyonTipi = lueProvisionType.EditValue.ToString();
            pgd.saglikTesisKodu = 10343154;
            pgd.sigortaliTuru = lueInsuranceType.EditValue.ToString();
            pgd.takipNo = this.teRelatedFollowUpNo.Text;
            pgd.takipTipi = lueFollowUpType.EditValue.ToString();
            pgd.tedaviTipi = lueTreatmentType.EditValue.ToString();
            pgd.tedaviTuru = lueTreatmentStyle.EditValue.ToString();
            pgd.yakinlikKodu = lueRelationType.EditValue.ToString();
            pgd.yatisBitisTarihi = "";

            this.lblStatus.Text = "Medula Sorgusu Yapılıyor...";
            hki.hastaKabulAsync(pgd);

        }

        void OnHastaKabulCompleted(Object sender, hastaKabulCompletedEventArgs e)
        {
            IsWorking = false;
            MedulaProvisionResult mpr = new MedulaProvisionResult();
            MedulaProvisionResult[] mprs = new MedulaProvisionResult[1];
            mprs[0] = mpr;
            try
            {
                this.lblStatus.Text = e.Result.sonucKodu + ": " + e.Result.sonucMesaji;
                MedulaProvisionCompletedEventArgs mpcea = new MedulaProvisionCompletedEventArgs(mprs, e.Error, e.Cancelled, e.UserState);
                if (e.Result.sonucKodu == "0000")
                {
                    mpr.Ad = e.Result.hastaBilgileri.ad;
                    mpr.Soyad = e.Result.hastaBilgileri.soyad;
                    mpr.Cinsiyet = e.Result.hastaBilgileri.cinsiyet;
                    mpr.DogumTarihi = e.Result.hastaBilgileri.dogumTarihi;
                    mpr.TCKimlikNo = e.Result.hastaBilgileri.tcKimlikNo;
                    mpr.SigortaliTuru = e.Result.hastaBilgileri.sigortaliTuru;

                    mpr.HastaBasvuruNo = e.Result.hastaBasvuruNo;
                    mpr.SonucKodu = e.Result.sonucKodu;
                    mpr.SonucMesaji = e.Result.sonucMesaji;
                    mpr.TakipNo = e.Result.takipNo;

                    mpr.BranchCode = this.lueBranchCode.EditValue.ToString();
                    mpr.RelatedFollowUpNo = this.teRelatedFollowUpNo.EditValue.ToString();
                    mpr.FollowUpType = this.lueFollowUpType.EditValue.ToString();
                    mpr.ProvisionType = this.lueProvisionType.EditValue.ToString();
                    mpr.TreatmentType = this.lueTreatmentType.EditValue.ToString();
                    mpr.TreatmentStyle = this.lueTreatmentStyle.EditValue.ToString();

                    mpr.TransferorInstitution = lueTransferorInstitution.EditValue.ToString();

                    this.teFollowUpNo.Text = e.Result.takipNo;
                    this.tePatientApplicationNo.Text = e.Result.hastaBasvuruNo;
                }
                if (OnMedulaHastaKabulCompleted != null)
                    OnMedulaHastaKabulCompleted(this, mpcea);
            }
            catch
            {
                MedulaProvisionCompletedEventArgs mpcea = new MedulaProvisionCompletedEventArgs(mprs, e.Error, e.Cancelled, e.UserState);
                mpr.SonucKodu = "0000";
                mpr.SonucMesaji = "Medula'dan Sonuç Alınamadı!";

                if (OnMedulaHastaKabulCompleted != null)
                    OnMedulaHastaKabulCompleted(this, mpcea);
            }
            finally
            {
            }
        }
    }
    public class MedulaProvisionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        public MedulaProvisionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        public MedulaProvisionResult Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return ((MedulaProvisionResult)(this.results[0]));
            }
        }
    }

}
