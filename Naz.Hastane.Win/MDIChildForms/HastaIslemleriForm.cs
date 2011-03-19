using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using DevExpress.Tutorials.Controls;
using DevExpress.XtraEditors.Controls;
using DevExpress.LookAndFeel;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class HastaIslemleriForm : MDIChildForm
    {
        Patient _patient;

        public HastaIslemleriForm()
        {
            InitializeComponent();
        }
        public HastaIslemleriForm(Patient aPatient)
        {
            _patient = aPatient;
            InitializeComponent();
            InitBindings();
//            this.xpHastaZiyaret.CriteriaString = "ID.KNR = '" + _hasta.KNR + "'";
            //this.gcIslemler.DataSource = _patient.HastaZiyarets;
        }

        private void InitBindings()
        {

            this.teHastaNo.DataBindings.Add("EditValue", _patient, "PatientNo");
            //this.teSNo.DataBindings.Add("EditValue", _patient, "SIGORTANO");
            this.teKurumKodu.DataBindings.Add("EditValue", _patient, "InsuranceCompany");
            this.teAdi.DataBindings.Add("EditValue", _patient, "FirstName");
            this.teSoyadi.DataBindings.Add("EditValue", _patient, "LastName");
            this.teBabaAdi.DataBindings.Add("EditValue", _patient, "FatherName");
            this.teAnaAdi.DataBindings.Add("EditValue", _patient, "MotherName");
            this.teDogumYeri.DataBindings.Add("EditValue", _patient, "BirthPlace");
            this.deDogumTarihi.DataBindings.Add("EditValue", _patient, "BirthDate");
            this.lueDurumu.DataBindings.Add("EditValue", _patient, "Status");
            this.lueSigortaTuru.DataBindings.Add("EditValue", _patient, "InsuranceType");

            this.rgMedeniHali.DataBindings.Add("EditValue", _patient, "MaritalStatus");
            this.rgCinsiyet.DataBindings.Add("EditValue", _patient, "Sex");
            this.rgHuviyet.DataBindings.Add("EditValue", _patient, "IDType");
            this.teHuviyetNosu.DataBindings.Add("EditValue", _patient, "IDNO");
            this.deHuviyetTarihi.DataBindings.Add("EditValue", _patient, "IDDate");
            this.teHuviyetVerildigiYer.DataBindings.Add("EditValue", _patient, "IDPlace");
            this.lueDevredilenKurum.DataBindings.Add("EditValue", _patient, "PrevInsuranceCompany");

            this.teEvTelefonu.DataBindings.Add("EditValue", _patient, "HomePhone1");
            this.teCepTelefonu.DataBindings.Add("EditValue", _patient, "HomePhone2");
            this.teEvAdresi.DataBindings.Add("EditValue", _patient, "HomeAddress");
            this.teMahalle.DataBindings.Add("EditValue", _patient, "HomeDistrict");
            this.teIlce.DataBindings.Add("EditValue", _patient, "HomeTown");
            this.tePostaKodu.DataBindings.Add("EditValue", _patient, "HomePostCode");
            this.lueIl.DataBindings.Add("EditValue", _patient, "HomeCity");
            this.lueUyrugu.DataBindings.Add("EditValue", _patient, "Nationality");
            this.teTCKimlikNo.DataBindings.Add("EditValue", _patient, "TCId");
            this.cbeYakinlikKodu.DataBindings.Add("EditValue", _patient, "Relation");
            //this.teKarneNo.DataBindings.Add("EditValue", _patient, "BAGKARNENO");

            this.teMemur.DataBindings.Add("EditValue", _patient, "Officer");
            this.teMeslek.DataBindings.Add("EditValue", _patient, "Profession");
            this.teEMSNo.DataBindings.Add("EditValue", _patient, "EMSNO");
            this.teProtokolNo.DataBindings.Add("EditValue", _patient, "ProtocolNo");
            this.teBagkurNo.DataBindings.Add("EditValue", _patient, "BAGNO");
            this.teSSKSicilNo.DataBindings.Add("EditValue", _patient, "YKARTNO");
            this.teSevkEdilenYer.DataBindings.Add("EditValue", _patient, "GELHAST");
            this.lueSigortaMudurlugu.DataBindings.Add("EditValue", _patient, "SIGMUD");
            this.teNufusaKayitliIl.DataBindings.Add("EditValue", _patient, "RegisteredCity");
            this.teNufusaKayitliIlce.DataBindings.Add("EditValue", _patient, "RegisteredTown");
            this.teSigortaliKartNo.DataBindings.Add("EditValue", _patient, "SIGORTALIKARTNO");

            this.teIsYeriAdi.DataBindings.Add("EditValue", _patient, "JobName");
            this.teIsYeriNo.DataBindings.Add("EditValue", _patient, "JobNo");
            this.meIsAdresi.DataBindings.Add("EditValue", _patient, "JobAddress");
            //this.teIsMahalle.DataBindings.Add("EditValue", _patient, "MEMUR");
            //this.teIsIlce.DataBindings.Add("EditValue", _patient, "MEMUR");
            this.lueIsIl.DataBindings.Add("EditValue", _patient, "JobCity");
            this.teIsPostaKodu.DataBindings.Add("EditValue", _patient, "JobPostCode");
            this.teIsTelefon1.DataBindings.Add("EditValue", _patient, "JobPhone1");
            this.teIsTelefon2.DataBindings.Add("EditValue", _patient, "JobPhone2");
            this.teIsFaxNo.DataBindings.Add("EditValue", _patient, "JobFax");
            this.teEMail.DataBindings.Add("EditValue", _patient, "Email");

            this.meOzgecmis.DataBindings.Add("EditValue", _patient, "CV");

            this.lueKanGrubu.DataBindings.Add("EditValue", _patient, "BloodType");
            this.ceKanVerebilir.DataBindings.Add("EditValue", _patient, "CanBeBloodDonour");

            this.ceHastaKatilimiVar.DataBindings.Add("EditValue", _patient, "PatientContribution");
            this.teHastaLimiti.DataBindings.Add("EditValue", _patient, "PatientLimit");

        }

        private void sbKaydet_Click(object sender, EventArgs e)
        {
            //_hasta.Save();
        }

     }
}