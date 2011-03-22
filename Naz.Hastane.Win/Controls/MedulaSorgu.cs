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
    public partial class MedulaSorgu : DevExpress.XtraEditors.XtraUserControl
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

        public MedulaSorgu()
        {
            InitializeComponent();
        }

        private void MedulaSorgu_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                this.lueBranchCode.Properties.DataSource = LookUpServices.BranchCodes;
                this.lueFollowUpType.Properties.DataSource = LookUpServices.FollowUpTypes;
                this.lueInsuranceType.Properties.DataSource = LookUpServices.InsuranceTypes;
                this.lueProvisionType.Properties.DataSource = LookUpServices.ProvisionTypes;
                this.lueRelationType.Properties.DataSource = LookUpServices.RelationTypes;
                this.lueTransferorInstitution.Properties.DataSource = LookUpServices.TransferorInstitutions;
                this.lueTreatmentStyle.Properties.DataSource = LookUpServices.TreatmentStyles;
                this.lueTreatmentType.Properties.DataSource = LookUpServices.TreatmentTypes;
            }
        }

        public void CallMedula(string TCID)
        {
            if (IsWorking) return;

            IsWorking = true;

            hki = new HastaKabulIslemleriClient();
            System.Net.ServicePointManager.Expect100Continue = false;

            hki.ClientCredentials.UserName.UserName = "10343154";
            hki.ClientCredentials.UserName.Password = "19031903";
            //hki.ClientCredentials.UserName.Password = "123456";

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
            //pgd.yeniDoganBilgisi = new YeniDoganBilgisiDVO();

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
