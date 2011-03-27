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
    public partial class MedulaReportControl : DevExpress.XtraEditors.XtraUserControl
    {
        public MedulaReportControl()
        {
            InitializeComponent();
            LoadLookUps();
        }
        private void LoadLookUps()
        {
            UIUtilities.BindLookUpEdit(this.lueDoctorBranch, LookUpServices.ServiceBranchCodes);
            UIUtilities.BindLookUpEdit(this.lueDoctorRegistrationNo, LookUpServices.SGKLicensedDoctors);
            UIUtilities.BindLookUpEdit(this.lueDoctorType, LookUpServices.DoctorTypes);
            UIUtilities.BindLookUpEdit(this.lueEditingType, LookUpServices.EditingTypes);
            UIUtilities.BindLookUpEdit(this.lueESWTBodyPartCode, LookUpServices.ESWTBodyParts);
            UIUtilities.BindLookUpEdit(this.lueFTRBodyPartCode, LookUpServices.FTRBodyParts);
            UIUtilities.BindLookUpEdit(this.lueInsuranceType, LookUpServices.InsuranceTypes);
            UIUtilities.BindLookUpEdit(this.lueKidneyInfo, LookUpServices.KidneyTypes);
            UIUtilities.BindLookUpEdit(this.lueProvisionType, LookUpServices.ProvisionTypes);
            UIUtilities.BindLookUpEdit(this.lueReportType, LookUpServices.MedulaReportTypes);
            UIUtilities.BindLookUpEdit(this.lueStatus, LookUpServices.TreatmentTypes);
            UIUtilities.BindLookUpEdit(this.lueKidneyStoneLocalisationCode, LookUpServices.KidneyStoneLocalisationCodes);
            UIUtilities.BindLookUpEdit(this.lueTransferorInstitution, LookUpServices.TransferorInstitutions);
            UIUtilities.BindLookUpEdit(this.lueTreatmentReportType, LookUpServices.MedulaReportTreatmentTypes);
        }
    }
}
