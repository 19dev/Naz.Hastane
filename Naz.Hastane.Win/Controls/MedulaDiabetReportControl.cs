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
            UIUtilities.BindLookUpEdit(this.lueResidentialType, LookUpServices.ResidentialTypes);
            UIUtilities.BindLookUpEdit(this.lueDMTraining,      LookUpServices.YesNos);
            UIUtilities.BindLookUpEdit(this.lueTBT,             LookUpServices.TBTs);
            UIUtilities.BindLookUpEdit(this.lueExercise,        LookUpServices.Exercises);
            UIUtilities.BindLookUpEdit(this.lueApplicationReason, LookUpServices.ApplicationReasons);
            UIUtilities.BindLookUpEdit(this.lueGlucometre,      LookUpServices.VarYoks);
            UIUtilities.BindLookUpEdit(this.lueAntiGAD,         LookUpServices.PositiveNegatives);
            UIUtilities.BindLookUpEdit(this.lueEKG,             LookUpServices.EKGs);
            UIUtilities.BindLookUpEdit(this.lueMikroAlbumin,    LookUpServices.VarYoks);
            UIUtilities.BindLookUpEdit(this.lueEyeExam,         LookUpServices.EyeExams);
            UIUtilities.BindLookUpEdit(this.luePeriferik,       LookUpServices.VarYoks);
            UIUtilities.BindLookUpEdit(this.lueKoroner,         LookUpServices.VarYoks);
            UIUtilities.BindLookUpEdit(this.lueSerebrovaskuler, LookUpServices.VarYoks);
            UIUtilities.BindLookUpEdit(this.lueFootExam,        LookUpServices.FootExams);
            UIUtilities.BindLookUpEdit(this.lueAcute,           LookUpServices.AcuteComplications);
            UIUtilities.BindLookUpEdit(this.lueHasInsulinePump, LookUpServices.VarYoks);
            UIUtilities.BindLookUpEdit(this.lueHasDMTraining,   LookUpServices.YesNos);
            UIUtilities.BindLookUpEdit(this.lueDiseaseCode,     LookUpServices.DiseaseCodes);
            UIUtilities.BindLookUpEdit(this.lueHabitCode,       LookUpServices.HabitCodes);
        }

    }
}
