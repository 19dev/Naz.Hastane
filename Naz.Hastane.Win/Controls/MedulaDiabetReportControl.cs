using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Win.Controls
{
    public partial class MedulaDiabetReportControl : DevExpress.XtraEditors.XtraUserControl
    {
        public MedulaDiabetReportControl()
        {
            InitializeComponent();
        }

        private void MedulaDiabetReportControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode) LoadLookUps();
        }

        private void LoadLookUps()
        {
            this.lueResidentialType.Properties.DataSource = LookUpServices.ResidentialTypes;
            //this.lueDMTraining.Properties.DataSource = LookUpServices.VarYoks;
            this.lueTBT.Properties.DataSource = LookUpServices.TBTs;
            this.lueExercise.Properties.DataSource = LookUpServices.Exercises;
            this.lueApplicationReason.Properties.DataSource = LookUpServices.ApplicationReasons;
            this.lueGlucometre.Properties.DataSource = LookUpServices.VarYoks;
            this.lueAntiGAD.Properties.DataSource = LookUpServices.PositiveNegatives;
            this.lueEKG.Properties.DataSource = LookUpServices.EKGs;
            this.lueEyeExam.Properties.DataSource = LookUpServices.EyeExams;
            this.luePeriferik.Properties.DataSource = LookUpServices.VarYoks;
            this.lueKoroner.Properties.DataSource = LookUpServices.VarYoks;
            this.lueSerebrovaskuler.Properties.DataSource = LookUpServices.VarYoks;
            this.lueFootExam.Properties.DataSource = LookUpServices.FootExams;
            this.lueAcute.Properties.DataSource = LookUpServices.AcuteComplications;
            this.lueHasInsulinePump.Properties.DataSource = LookUpServices.VarYoks;
            //this.lueHasDMTraining.Properties.DataSource = LookUpServices.VarYoks;
            this.lueDiseaseCode.Properties.DataSource = LookUpServices.DiseaseCodes;
            this.lueHasInsulinePump.Properties.DataSource = LookUpServices.VarYoks;
        }

    }
}
