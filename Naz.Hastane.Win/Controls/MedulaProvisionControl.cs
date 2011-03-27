using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Mernis.Utilities.WCF;
using Naz.Mernis.Service;
using Naz.Hastane.Medula.HastaKabulIslemleri;
using Naz.Utilities.Classes;
using Naz.Mernis.Utilities;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Win.Controls
{
    public partial class MedulaProvisionControl : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void MedulaHastaKabulCompleted(Object sender, hastaKabulCompletedEventArgs e);
        public event MedulaHastaKabulCompleted OnMedulaHastaKabulCompleted;

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
            pgd.takipNo = "";
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
            this.lblStatus.Text = e.Result.sonucKodu + ": " + e.Result.sonucMesaji;
            if (OnMedulaHastaKabulCompleted != null)
                OnMedulaHastaKabulCompleted(this, e);
        }


    }
}
