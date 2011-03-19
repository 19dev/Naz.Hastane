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
        public event RunWorkerCompletedEventHandler RunWorkerCompleted;

        private HastaKabulIslemleriClient hki = new HastaKabulIslemleriClient();

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
                this.lueBranchCode.Properties.DataSource = LookUpServices.ProvisionTypes;
                this.lueFollowUpType.Properties.DataSource = LookUpServices.FollowUpTypes;
                this.lueInsuranceType.Properties.DataSource = LookUpServices.InsuranceTypes;
                this.lueProvisionType.Properties.DataSource = LookUpServices.ProvisionTypes;
                this.lueRelationType.Properties.DataSource = LookUpServices.RelationTypes;
                this.lueTransferorInstitution.Properties.DataSource = LookUpServices.TransferorInstitutions;
                this.lueTreatmentStyle.Properties.DataSource = LookUpServices.TreatmentStyles;
                this.lueTreatmentType.Properties.DataSource = LookUpServices.TreatmentTypes;
            }
        }

        public void CallMedula(int TCID)
        {
            if (IsWorking) return;

            IsWorking = true;

            hki.hastaKabulCompleted += new EventHandler<hastaKabulCompletedEventArgs>(OnHastaKabulCompleted);
            
            ProvizyonGirisDVO pgd = new ProvizyonGirisDVO();
            pgd.bransKodu = lueBranchCode.EditValue.ToString();
            pgd.devredilenKurum = lueTransferorInstitution.EditValue.ToString();
            pgd.donorTCKimlikNo = "";
            pgd.hastaTCKimlikNo = "";
            pgd.provizyonTarihi = DateTime.Now.ToString("dd/MM/yyyy");
            pgd.provizyonTipi = lueProvisionType.EditValue.ToString();
            pgd.saglikTesisKodu = 0;
            pgd.sigortaliTuru = lueInsuranceType.EditValue.ToString();
            pgd.takipNo = "";
            pgd.takipTipi = lueFollowUpType.EditValue.ToString();
            pgd.tedaviTipi = lueTreatmentType.EditValue.ToString();
            pgd.tedaviTuru = lueTreatmentStyle.EditValue.ToString();
            pgd.yakinlikKodu = lueRelationType.EditValue.ToString();
            pgd.yatisBitisTarihi = "";
            pgd.yeniDoganBilgisi = new YeniDoganBilgisiDVO();

            hki.hastaKabulAsync(pgd);

        }

        void OnHastaKabulCompleted(Object sender, hastaKabulCompletedEventArgs e)
        {
           //hki.end
        }


    }
}
