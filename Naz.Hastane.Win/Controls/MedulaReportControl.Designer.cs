namespace Naz.Hastane.Win.Controls
{
    partial class MedulaReportControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lcMedulaReport = new DevExpress.XtraLayout.LayoutControl();
            this.sbSyncDiagnosis = new DevExpress.XtraEditors.SimpleButton();
            this.sbAddDiagnosis = new DevExpress.XtraEditors.SimpleButton();
            this.sbDeleteDiagnosis = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.sbPrint = new DevExpress.XtraEditors.SimpleButton();
            this.gcICD = new DevExpress.XtraGrid.GridControl();
            this.gvICD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colICD10Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colICD10DiagnosisName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDiagnosis = new DevExpress.XtraGrid.GridControl();
            this.gvDiagnosis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDiagnosisCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiagnosisName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbAddEffectiveSubsance = new DevExpress.XtraEditors.SimpleButton();
            this.gcEffectiveSubsance = new DevExpress.XtraGrid.GridControl();
            this.gvEffectiveSubsance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEffectiveSubsanceCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveSubsanceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.teProtocolNo = new DevExpress.XtraEditors.TextEdit();
            this.lueEditingType = new DevExpress.XtraEditors.LookUpEdit();
            this.sbDeleteEffectiveSubsance = new DevExpress.XtraEditors.SimpleButton();
            this.lueReportType = new DevExpress.XtraEditors.LookUpEdit();
            this.deReportDate = new DevExpress.XtraEditors.DateEdit();
            this.teReportNo = new DevExpress.XtraEditors.TextEdit();
            this.deEndDate = new DevExpress.XtraEditors.DateEdit();
            this.deStartDate = new DevExpress.XtraEditors.DateEdit();
            this.gcDoctors = new DevExpress.XtraGrid.GridControl();
            this.gvDoctors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lueDoctorType = new DevExpress.XtraEditors.LookUpEdit();
            this.teDoctorLastName = new DevExpress.XtraEditors.TextEdit();
            this.teDoctorFirstName = new DevExpress.XtraEditors.TextEdit();
            this.lueDoctorBranch = new DevExpress.XtraEditors.LookUpEdit();
            this.sbAddDoctor = new DevExpress.XtraEditors.SimpleButton();
            this.lueDoctorRegistrationNo = new DevExpress.XtraEditors.LookUpEdit();
            this.lueInsuranceType = new DevExpress.XtraEditors.LookUpEdit();
            this.lueProvisionType = new DevExpress.XtraEditors.LookUpEdit();
            this.teRelationCode = new DevExpress.XtraEditors.TextEdit();
            this.lueTransferorInstitution = new DevExpress.XtraEditors.LookUpEdit();
            this.teCardNo = new DevExpress.XtraEditors.TextEdit();
            this.teSocialSecurityNo = new DevExpress.XtraEditors.TextEdit();
            this.teTCID = new DevExpress.XtraEditors.TextEdit();
            this.gcESWLStoneInfo = new DevExpress.XtraGrid.GridControl();
            this.gvESWLStoneInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStoneDimension = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStoneLocalisationCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbAddESWLStoneInfo = new DevExpress.XtraEditors.SimpleButton();
            this.lcStoneDimensionComment = new DevExpress.XtraEditors.LabelControl();
            this.lueKidneyStoneLocalisationCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lueKidneyInfo = new DevExpress.XtraEditors.LookUpEdit();
            this.teESWLReportSessionCount = new DevExpress.XtraEditors.TextEdit();
            this.teESWLReportStoneCount = new DevExpress.XtraEditors.TextEdit();
            this.teESWLBUTCode = new DevExpress.XtraEditors.TextEdit();
            this.teStoneDimension = new DevExpress.XtraEditors.TextEdit();
            this.teBUTCode = new DevExpress.XtraEditors.TextEdit();
            this.teFTRSessionCount = new DevExpress.XtraEditors.TextEdit();
            this.teFTRSessionDays = new DevExpress.XtraEditors.TextEdit();
            this.lueFTRBodyPartCode = new DevExpress.XtraEditors.LookUpEdit();
            this.teESWTBUTCode = new DevExpress.XtraEditors.TextEdit();
            this.teESWTSessionCount = new DevExpress.XtraEditors.TextEdit();
            this.teESWTSessionDays = new DevExpress.XtraEditors.TextEdit();
            this.lueESWTBodyPartCode = new DevExpress.XtraEditors.LookUpEdit();
            this.teInstitutionNo = new DevExpress.XtraEditors.TextEdit();
            this.tePatientName = new DevExpress.XtraEditors.TextEdit();
            this.teFollowUpNo = new DevExpress.XtraEditors.TextEdit();
            this.lueTreatmentReportType = new DevExpress.XtraEditors.LookUpEdit();
            this.rgReportMainType = new DevExpress.XtraEditors.RadioGroup();
            this.deReportStartDate = new DevExpress.XtraEditors.DateEdit();
            this.deReportEndDate = new DevExpress.XtraEditors.DateEdit();
            this.deProtocolDate = new DevExpress.XtraEditors.DateEdit();
            this.meClinicalDiagnosis = new DevExpress.XtraEditors.MemoEdit();
            this.meDescription = new DevExpress.XtraEditors.MemoEdit();
            this.deProvisionDate = new DevExpress.XtraEditors.DateEdit();
            this.lcgMedulaReport = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tcgMedulaReport = new DevExpress.XtraLayout.TabbedControlGroup();
            this.lcgReportDetailInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgReportType = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciReportMainType = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTreatmentReportType = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lcgPatientInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPatientName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFollowUpNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciInstitutionNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTCID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSocialSecurityNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCardNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTransferorInstitution = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRelationCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciProvisionType = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciProvisionDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciInsuranceType = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgDoctorInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciAddDoctor = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDoctorType = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDoctorBranch = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDoctorRegistrationNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDoctorFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDoctorLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDoctors = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lcgReportInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciReportDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciReportNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgReport = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciReportType = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciReportStartDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciReportEndDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEditingType = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciProtocolNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciProtocolDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgClinicalDiagnosis = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciClinicalDiagnosis = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgDescription = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPrint = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgEffectiveSubsance = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciEffectiveSubsance = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDeleteEffectiveSubsance = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAddEffectiveSubsance = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgDiagnosisInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciStartDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEndDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDiagnosisGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciICDGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciDeleteDiagnosis = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAddDiagnosis = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSyncDiagnosis = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgESWTFTRESWLReportInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgESWTReportInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciESWTBUTCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciESWTSessionCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciESWTSessionDays = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciESWTBodyPartCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgFTRReportInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciBUTCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFTRSessionCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFTRSessionDays = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFTRBodyPartCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgESWLReportInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciESWLBUTCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciESWLReportStoneCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciESWLReportSessionCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciKidneyInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgESWLStoneInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciKidneyStoneLocalisationCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciStoneDimension = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciStoneDimensionComment = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciAddESWLStoneInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciESWLStoneInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMedulaReport)).BeginInit();
            this.lcMedulaReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcICD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvICD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEffectiveSubsance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEffectiveSubsance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProtocolNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEditingType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueReportType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deReportDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deReportDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teReportNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDoctorType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDoctorLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDoctorFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDoctorBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDoctorRegistrationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInsuranceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProvisionType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRelationCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTransferorInstitution.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCardNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSocialSecurityNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTCID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcESWLStoneInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvESWLStoneInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueKidneyStoneLocalisationCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueKidneyInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teESWLReportSessionCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teESWLReportStoneCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teESWLBUTCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teStoneDimension.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBUTCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFTRSessionCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFTRSessionDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFTRBodyPartCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teESWTBUTCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teESWTSessionCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teESWTSessionDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueESWTBodyPartCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teInstitutionNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePatientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFollowUpNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTreatmentReportType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgReportMainType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deReportStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deReportStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deReportEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deReportEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deProtocolDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deProtocolDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meClinicalDiagnosis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deProvisionDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deProvisionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMedulaReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcgMedulaReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReportDetailInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReportType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReportMainType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreatmentReportType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPatientInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFollowUpNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInstitutionNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTCID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSocialSecurityNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCardNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTransferorInstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRelationCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProvisionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProvisionDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInsuranceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDoctorInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctorBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctorRegistrationNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctorFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctorLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReportInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReportDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReportNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReportType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReportStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReportEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEditingType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProtocolNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProtocolDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgClinicalDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClinicalDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgEffectiveSubsance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEffectiveSubsance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDeleteEffectiveSubsance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddEffectiveSubsance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDiagnosisInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDiagnosisGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciICDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDeleteDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSyncDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgESWTFTRESWLReportInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgESWTReportInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWTBUTCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWTSessionCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWTSessionDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWTBodyPartCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgFTRReportInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBUTCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFTRSessionCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFTRSessionDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFTRBodyPartCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgESWLReportInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWLBUTCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWLReportStoneCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWLReportSessionCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKidneyInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgESWLStoneInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKidneyStoneLocalisationCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStoneDimension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStoneDimensionComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddESWLStoneInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWLStoneInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMedulaReport
            // 
            this.lcMedulaReport.Controls.Add(this.sbSyncDiagnosis);
            this.lcMedulaReport.Controls.Add(this.sbAddDiagnosis);
            this.lcMedulaReport.Controls.Add(this.sbDeleteDiagnosis);
            this.lcMedulaReport.Controls.Add(this.sbCancel);
            this.lcMedulaReport.Controls.Add(this.sbSave);
            this.lcMedulaReport.Controls.Add(this.sbPrint);
            this.lcMedulaReport.Controls.Add(this.gcICD);
            this.lcMedulaReport.Controls.Add(this.gcDiagnosis);
            this.lcMedulaReport.Controls.Add(this.sbAddEffectiveSubsance);
            this.lcMedulaReport.Controls.Add(this.gcEffectiveSubsance);
            this.lcMedulaReport.Controls.Add(this.lueStatus);
            this.lcMedulaReport.Controls.Add(this.teProtocolNo);
            this.lcMedulaReport.Controls.Add(this.lueEditingType);
            this.lcMedulaReport.Controls.Add(this.sbDeleteEffectiveSubsance);
            this.lcMedulaReport.Controls.Add(this.lueReportType);
            this.lcMedulaReport.Controls.Add(this.deReportDate);
            this.lcMedulaReport.Controls.Add(this.teReportNo);
            this.lcMedulaReport.Controls.Add(this.deEndDate);
            this.lcMedulaReport.Controls.Add(this.deStartDate);
            this.lcMedulaReport.Controls.Add(this.gcDoctors);
            this.lcMedulaReport.Controls.Add(this.lueDoctorType);
            this.lcMedulaReport.Controls.Add(this.teDoctorLastName);
            this.lcMedulaReport.Controls.Add(this.teDoctorFirstName);
            this.lcMedulaReport.Controls.Add(this.lueDoctorBranch);
            this.lcMedulaReport.Controls.Add(this.sbAddDoctor);
            this.lcMedulaReport.Controls.Add(this.lueDoctorRegistrationNo);
            this.lcMedulaReport.Controls.Add(this.lueInsuranceType);
            this.lcMedulaReport.Controls.Add(this.lueProvisionType);
            this.lcMedulaReport.Controls.Add(this.teRelationCode);
            this.lcMedulaReport.Controls.Add(this.lueTransferorInstitution);
            this.lcMedulaReport.Controls.Add(this.teCardNo);
            this.lcMedulaReport.Controls.Add(this.teSocialSecurityNo);
            this.lcMedulaReport.Controls.Add(this.teTCID);
            this.lcMedulaReport.Controls.Add(this.gcESWLStoneInfo);
            this.lcMedulaReport.Controls.Add(this.sbAddESWLStoneInfo);
            this.lcMedulaReport.Controls.Add(this.lcStoneDimensionComment);
            this.lcMedulaReport.Controls.Add(this.lueKidneyStoneLocalisationCode);
            this.lcMedulaReport.Controls.Add(this.lueKidneyInfo);
            this.lcMedulaReport.Controls.Add(this.teESWLReportSessionCount);
            this.lcMedulaReport.Controls.Add(this.teESWLReportStoneCount);
            this.lcMedulaReport.Controls.Add(this.teESWLBUTCode);
            this.lcMedulaReport.Controls.Add(this.teStoneDimension);
            this.lcMedulaReport.Controls.Add(this.teBUTCode);
            this.lcMedulaReport.Controls.Add(this.teFTRSessionCount);
            this.lcMedulaReport.Controls.Add(this.teFTRSessionDays);
            this.lcMedulaReport.Controls.Add(this.lueFTRBodyPartCode);
            this.lcMedulaReport.Controls.Add(this.teESWTBUTCode);
            this.lcMedulaReport.Controls.Add(this.teESWTSessionCount);
            this.lcMedulaReport.Controls.Add(this.teESWTSessionDays);
            this.lcMedulaReport.Controls.Add(this.lueESWTBodyPartCode);
            this.lcMedulaReport.Controls.Add(this.teInstitutionNo);
            this.lcMedulaReport.Controls.Add(this.tePatientName);
            this.lcMedulaReport.Controls.Add(this.teFollowUpNo);
            this.lcMedulaReport.Controls.Add(this.lueTreatmentReportType);
            this.lcMedulaReport.Controls.Add(this.rgReportMainType);
            this.lcMedulaReport.Controls.Add(this.deReportStartDate);
            this.lcMedulaReport.Controls.Add(this.deReportEndDate);
            this.lcMedulaReport.Controls.Add(this.deProtocolDate);
            this.lcMedulaReport.Controls.Add(this.meClinicalDiagnosis);
            this.lcMedulaReport.Controls.Add(this.meDescription);
            this.lcMedulaReport.Controls.Add(this.deProvisionDate);
            this.lcMedulaReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMedulaReport.Location = new System.Drawing.Point(0, 0);
            this.lcMedulaReport.Name = "lcMedulaReport";
            this.lcMedulaReport.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(445, 81, 397, 619);
            this.lcMedulaReport.Root = this.lcgMedulaReport;
            this.lcMedulaReport.Size = new System.Drawing.Size(921, 746);
            this.lcMedulaReport.TabIndex = 0;
            this.lcMedulaReport.Text = "layoutControl1";
            // 
            // sbSyncDiagnosis
            // 
            this.sbSyncDiagnosis.Location = new System.Drawing.Point(301, 688);
            this.sbSyncDiagnosis.Name = "sbSyncDiagnosis";
            this.sbSyncDiagnosis.Size = new System.Drawing.Size(140, 22);
            this.sbSyncDiagnosis.StyleController = this.lcMedulaReport;
            this.sbSyncDiagnosis.TabIndex = 64;
            this.sbSyncDiagnosis.Text = "<- Tanıyı Teşhisle Eşleştir";
            // 
            // sbAddDiagnosis
            // 
            this.sbAddDiagnosis.Location = new System.Drawing.Point(188, 688);
            this.sbAddDiagnosis.Name = "sbAddDiagnosis";
            this.sbAddDiagnosis.Size = new System.Drawing.Size(109, 22);
            this.sbAddDiagnosis.StyleController = this.lcMedulaReport;
            this.sbAddDiagnosis.TabIndex = 63;
            this.sbAddDiagnosis.Text = "Rapor Teşhis Ekle";
            // 
            // sbDeleteDiagnosis
            // 
            this.sbDeleteDiagnosis.Location = new System.Drawing.Point(36, 688);
            this.sbDeleteDiagnosis.Name = "sbDeleteDiagnosis";
            this.sbDeleteDiagnosis.Size = new System.Drawing.Size(148, 22);
            this.sbDeleteDiagnosis.StyleController = this.lcMedulaReport;
            this.sbDeleteDiagnosis.TabIndex = 62;
            this.sbDeleteDiagnosis.Text = "Teşhis Sil";
            // 
            // sbCancel
            // 
            this.sbCancel.Location = new System.Drawing.Point(721, 688);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(164, 22);
            this.sbCancel.StyleController = this.lcMedulaReport;
            this.sbCancel.TabIndex = 61;
            this.sbCancel.Text = "Vazgeç";
            // 
            // sbSave
            // 
            this.sbSave.Location = new System.Drawing.Point(611, 688);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(106, 22);
            this.sbSave.StyleController = this.lcMedulaReport;
            this.sbSave.TabIndex = 60;
            this.sbSave.Text = "Kaydet";
            // 
            // sbPrint
            // 
            this.sbPrint.Location = new System.Drawing.Point(469, 688);
            this.sbPrint.Name = "sbPrint";
            this.sbPrint.Size = new System.Drawing.Size(138, 22);
            this.sbPrint.StyleController = this.lcMedulaReport;
            this.sbPrint.TabIndex = 59;
            this.sbPrint.Text = "Yazdır";
            // 
            // gcICD
            // 
            this.gcICD.Location = new System.Drawing.Point(241, 610);
            this.gcICD.MainView = this.gvICD;
            this.gcICD.Name = "gcICD";
            this.gcICD.Size = new System.Drawing.Size(200, 74);
            this.gcICD.TabIndex = 58;
            this.gcICD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvICD});
            // 
            // gvICD
            // 
            this.gvICD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colICD10Code,
            this.colICD10DiagnosisName});
            this.gvICD.GridControl = this.gcICD;
            this.gvICD.Name = "gvICD";
            this.gvICD.OptionsView.ShowGroupPanel = false;
            // 
            // colICD10Code
            // 
            this.colICD10Code.Caption = "ICD10 Kodu";
            this.colICD10Code.Name = "colICD10Code";
            this.colICD10Code.Visible = true;
            this.colICD10Code.VisibleIndex = 0;
            // 
            // colICD10DiagnosisName
            // 
            this.colICD10DiagnosisName.Caption = "Teşhis Adı";
            this.colICD10DiagnosisName.Name = "colICD10DiagnosisName";
            this.colICD10DiagnosisName.Visible = true;
            this.colICD10DiagnosisName.VisibleIndex = 1;
            // 
            // gcDiagnosis
            // 
            this.gcDiagnosis.Location = new System.Drawing.Point(36, 610);
            this.gcDiagnosis.MainView = this.gvDiagnosis;
            this.gcDiagnosis.Name = "gcDiagnosis";
            this.gcDiagnosis.Size = new System.Drawing.Size(201, 74);
            this.gcDiagnosis.TabIndex = 57;
            this.gcDiagnosis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDiagnosis});
            // 
            // gvDiagnosis
            // 
            this.gvDiagnosis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDiagnosisCode,
            this.colDiagnosisName});
            this.gvDiagnosis.GridControl = this.gcDiagnosis;
            this.gvDiagnosis.Name = "gvDiagnosis";
            this.gvDiagnosis.OptionsView.ShowGroupPanel = false;
            // 
            // colDiagnosisCode
            // 
            this.colDiagnosisCode.Caption = "Teşhis Kodu";
            this.colDiagnosisCode.Name = "colDiagnosisCode";
            this.colDiagnosisCode.Visible = true;
            this.colDiagnosisCode.VisibleIndex = 0;
            // 
            // colDiagnosisName
            // 
            this.colDiagnosisName.Caption = "Teşhis Adı";
            this.colDiagnosisName.Name = "colDiagnosisName";
            this.colDiagnosisName.Visible = true;
            this.colDiagnosisName.VisibleIndex = 1;
            // 
            // sbAddEffectiveSubsance
            // 
            this.sbAddEffectiveSubsance.Location = new System.Drawing.Point(662, 650);
            this.sbAddEffectiveSubsance.Name = "sbAddEffectiveSubsance";
            this.sbAddEffectiveSubsance.Size = new System.Drawing.Size(211, 22);
            this.sbAddEffectiveSubsance.StyleController = this.lcMedulaReport;
            this.sbAddEffectiveSubsance.TabIndex = 56;
            this.sbAddEffectiveSubsance.Text = "Rapor Etkin Madde Ekle";
            // 
            // gcEffectiveSubsance
            // 
            this.gcEffectiveSubsance.Location = new System.Drawing.Point(481, 557);
            this.gcEffectiveSubsance.MainView = this.gvEffectiveSubsance;
            this.gcEffectiveSubsance.Name = "gcEffectiveSubsance";
            this.gcEffectiveSubsance.Size = new System.Drawing.Size(392, 89);
            this.gcEffectiveSubsance.TabIndex = 54;
            this.gcEffectiveSubsance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEffectiveSubsance});
            // 
            // gvEffectiveSubsance
            // 
            this.gvEffectiveSubsance.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEffectiveSubsanceCode,
            this.colEffectiveSubsanceName});
            this.gvEffectiveSubsance.GridControl = this.gcEffectiveSubsance;
            this.gvEffectiveSubsance.Name = "gvEffectiveSubsance";
            this.gvEffectiveSubsance.OptionsView.ShowGroupPanel = false;
            // 
            // colEffectiveSubsanceCode
            // 
            this.colEffectiveSubsanceCode.Caption = "Etkin Madde Kodu";
            this.colEffectiveSubsanceCode.Name = "colEffectiveSubsanceCode";
            this.colEffectiveSubsanceCode.Visible = true;
            this.colEffectiveSubsanceCode.VisibleIndex = 0;
            // 
            // colEffectiveSubsanceName
            // 
            this.colEffectiveSubsanceName.Caption = "Etkin Madde Adı";
            this.colEffectiveSubsanceName.Name = "colEffectiveSubsanceName";
            this.colEffectiveSubsanceName.Visible = true;
            this.colEffectiveSubsanceName.VisibleIndex = 1;
            // 
            // lueStatus
            // 
            this.lueStatus.EditValue = "";
            this.lueStatus.Enabled = false;
            this.lueStatus.Location = new System.Drawing.Point(603, 312);
            this.lueStatus.Name = "lueStatus";
            this.lueStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueStatus.Size = new System.Drawing.Size(282, 20);
            this.lueStatus.StyleController = this.lcMedulaReport;
            this.lueStatus.TabIndex = 51;
            // 
            // teProtocolNo
            // 
            this.teProtocolNo.Location = new System.Drawing.Point(603, 264);
            this.teProtocolNo.Name = "teProtocolNo";
            this.teProtocolNo.Size = new System.Drawing.Size(282, 20);
            this.teProtocolNo.StyleController = this.lcMedulaReport;
            this.teProtocolNo.TabIndex = 49;
            // 
            // lueEditingType
            // 
            this.lueEditingType.Location = new System.Drawing.Point(603, 240);
            this.lueEditingType.Name = "lueEditingType";
            this.lueEditingType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEditingType.Size = new System.Drawing.Size(282, 20);
            this.lueEditingType.StyleController = this.lcMedulaReport;
            this.lueEditingType.TabIndex = 48;
            // 
            // sbDeleteEffectiveSubsance
            // 
            this.sbDeleteEffectiveSubsance.Location = new System.Drawing.Point(481, 650);
            this.sbDeleteEffectiveSubsance.Name = "sbDeleteEffectiveSubsance";
            this.sbDeleteEffectiveSubsance.Size = new System.Drawing.Size(177, 22);
            this.sbDeleteEffectiveSubsance.StyleController = this.lcMedulaReport;
            this.sbDeleteEffectiveSubsance.TabIndex = 55;
            this.sbDeleteEffectiveSubsance.Text = "Etkin Madde Sil";
            // 
            // lueReportType
            // 
            this.lueReportType.Location = new System.Drawing.Point(603, 168);
            this.lueReportType.Name = "lueReportType";
            this.lueReportType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueReportType.Size = new System.Drawing.Size(282, 20);
            this.lueReportType.StyleController = this.lcMedulaReport;
            this.lueReportType.TabIndex = 45;
            // 
            // deReportDate
            // 
            this.deReportDate.EditValue = null;
            this.deReportDate.Location = new System.Drawing.Point(603, 100);
            this.deReportDate.Name = "deReportDate";
            this.deReportDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deReportDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deReportDate.Size = new System.Drawing.Size(282, 20);
            this.deReportDate.StyleController = this.lcMedulaReport;
            this.deReportDate.TabIndex = 44;
            // 
            // teReportNo
            // 
            this.teReportNo.Location = new System.Drawing.Point(603, 76);
            this.teReportNo.Name = "teReportNo";
            this.teReportNo.Size = new System.Drawing.Size(282, 20);
            this.teReportNo.StyleController = this.lcMedulaReport;
            this.teReportNo.TabIndex = 43;
            // 
            // deEndDate
            // 
            this.deEndDate.EditValue = null;
            this.deEndDate.Location = new System.Drawing.Point(250, 586);
            this.deEndDate.Name = "deEndDate";
            this.deEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deEndDate.Size = new System.Drawing.Size(137, 20);
            this.deEndDate.StyleController = this.lcMedulaReport;
            this.deEndDate.TabIndex = 42;
            // 
            // deStartDate
            // 
            this.deStartDate.EditValue = null;
            this.deStartDate.Location = new System.Drawing.Point(36, 586);
            this.deStartDate.Name = "deStartDate";
            this.deStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deStartDate.Size = new System.Drawing.Size(136, 20);
            this.deStartDate.StyleController = this.lcMedulaReport;
            this.deStartDate.TabIndex = 41;
            // 
            // gcDoctors
            // 
            this.gcDoctors.Location = new System.Drawing.Point(36, 442);
            this.gcDoctors.MainView = this.gvDoctors;
            this.gcDoctors.Name = "gcDoctors";
            this.gcDoctors.Size = new System.Drawing.Size(405, 80);
            this.gcDoctors.TabIndex = 40;
            this.gcDoctors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDoctors});
            // 
            // gvDoctors
            // 
            this.gvDoctors.GridControl = this.gcDoctors;
            this.gvDoctors.Name = "gvDoctors";
            this.gvDoctors.OptionsView.ShowGroupPanel = false;
            // 
            // lueDoctorType
            // 
            this.lueDoctorType.Location = new System.Drawing.Point(391, 376);
            this.lueDoctorType.Name = "lueDoctorType";
            this.lueDoctorType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDoctorType.Size = new System.Drawing.Size(50, 20);
            this.lueDoctorType.StyleController = this.lcMedulaReport;
            this.lueDoctorType.TabIndex = 38;
            // 
            // teDoctorLastName
            // 
            this.teDoctorLastName.Location = new System.Drawing.Point(170, 400);
            this.teDoctorLastName.Name = "teDoctorLastName";
            this.teDoctorLastName.Size = new System.Drawing.Size(89, 20);
            this.teDoctorLastName.StyleController = this.lcMedulaReport;
            this.teDoctorLastName.TabIndex = 37;
            // 
            // teDoctorFirstName
            // 
            this.teDoctorFirstName.Location = new System.Drawing.Point(170, 376);
            this.teDoctorFirstName.Name = "teDoctorFirstName";
            this.teDoctorFirstName.Size = new System.Drawing.Size(83, 20);
            this.teDoctorFirstName.StyleController = this.lcMedulaReport;
            this.teDoctorFirstName.TabIndex = 36;
            // 
            // lueDoctorBranch
            // 
            this.lueDoctorBranch.Location = new System.Drawing.Point(391, 352);
            this.lueDoctorBranch.Name = "lueDoctorBranch";
            this.lueDoctorBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDoctorBranch.Size = new System.Drawing.Size(50, 20);
            this.lueDoctorBranch.StyleController = this.lcMedulaReport;
            this.lueDoctorBranch.TabIndex = 35;
            // 
            // sbAddDoctor
            // 
            this.sbAddDoctor.Location = new System.Drawing.Point(263, 400);
            this.sbAddDoctor.Name = "sbAddDoctor";
            this.sbAddDoctor.Size = new System.Drawing.Size(81, 22);
            this.sbAddDoctor.StyleController = this.lcMedulaReport;
            this.sbAddDoctor.TabIndex = 39;
            this.sbAddDoctor.Text = "Dr. Ekle";
            // 
            // lueDoctorRegistrationNo
            // 
            this.lueDoctorRegistrationNo.Location = new System.Drawing.Point(170, 352);
            this.lueDoctorRegistrationNo.Name = "lueDoctorRegistrationNo";
            this.lueDoctorRegistrationNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDoctorRegistrationNo.Size = new System.Drawing.Size(83, 20);
            this.lueDoctorRegistrationNo.StyleController = this.lcMedulaReport;
            this.lueDoctorRegistrationNo.TabIndex = 34;
            // 
            // lueInsuranceType
            // 
            this.lueInsuranceType.Location = new System.Drawing.Point(391, 284);
            this.lueInsuranceType.Name = "lueInsuranceType";
            this.lueInsuranceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueInsuranceType.Size = new System.Drawing.Size(50, 20);
            this.lueInsuranceType.StyleController = this.lcMedulaReport;
            this.lueInsuranceType.TabIndex = 33;
            // 
            // lueProvisionType
            // 
            this.lueProvisionType.Location = new System.Drawing.Point(391, 236);
            this.lueProvisionType.Name = "lueProvisionType";
            this.lueProvisionType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProvisionType.Size = new System.Drawing.Size(50, 20);
            this.lueProvisionType.StyleController = this.lcMedulaReport;
            this.lueProvisionType.TabIndex = 31;
            // 
            // teRelationCode
            // 
            this.teRelationCode.Location = new System.Drawing.Point(391, 212);
            this.teRelationCode.Name = "teRelationCode";
            this.teRelationCode.Size = new System.Drawing.Size(50, 20);
            this.teRelationCode.StyleController = this.lcMedulaReport;
            this.teRelationCode.TabIndex = 30;
            // 
            // lueTransferorInstitution
            // 
            this.lueTransferorInstitution.Location = new System.Drawing.Point(170, 284);
            this.lueTransferorInstitution.Name = "lueTransferorInstitution";
            this.lueTransferorInstitution.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTransferorInstitution.Size = new System.Drawing.Size(83, 20);
            this.lueTransferorInstitution.StyleController = this.lcMedulaReport;
            this.lueTransferorInstitution.TabIndex = 29;
            // 
            // teCardNo
            // 
            this.teCardNo.Location = new System.Drawing.Point(170, 260);
            this.teCardNo.Name = "teCardNo";
            this.teCardNo.Size = new System.Drawing.Size(83, 20);
            this.teCardNo.StyleController = this.lcMedulaReport;
            this.teCardNo.TabIndex = 28;
            // 
            // teSocialSecurityNo
            // 
            this.teSocialSecurityNo.Location = new System.Drawing.Point(170, 236);
            this.teSocialSecurityNo.Name = "teSocialSecurityNo";
            this.teSocialSecurityNo.Size = new System.Drawing.Size(83, 20);
            this.teSocialSecurityNo.StyleController = this.lcMedulaReport;
            this.teSocialSecurityNo.TabIndex = 27;
            // 
            // teTCID
            // 
            this.teTCID.Location = new System.Drawing.Point(170, 212);
            this.teTCID.Name = "teTCID";
            this.teTCID.Size = new System.Drawing.Size(83, 20);
            this.teTCID.StyleController = this.lcMedulaReport;
            this.teTCID.TabIndex = 26;
            // 
            // gcESWLStoneInfo
            // 
            this.gcESWLStoneInfo.Location = new System.Drawing.Point(48, 534);
            this.gcESWLStoneInfo.MainView = this.gvESWLStoneInfo;
            this.gcESWLStoneInfo.Name = "gcESWLStoneInfo";
            this.gcESWLStoneInfo.Size = new System.Drawing.Size(525, 164);
            this.gcESWLStoneInfo.TabIndex = 25;
            this.gcESWLStoneInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvESWLStoneInfo});
            // 
            // gvESWLStoneInfo
            // 
            this.gvESWLStoneInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStoneDimension,
            this.colStoneLocalisationCode});
            this.gvESWLStoneInfo.GridControl = this.gcESWLStoneInfo;
            this.gvESWLStoneInfo.Name = "gvESWLStoneInfo";
            this.gvESWLStoneInfo.OptionsView.ShowGroupPanel = false;
            // 
            // colStoneDimension
            // 
            this.colStoneDimension.Caption = "Taş Boyutu";
            this.colStoneDimension.Name = "colStoneDimension";
            this.colStoneDimension.Visible = true;
            this.colStoneDimension.VisibleIndex = 1;
            // 
            // colStoneLocalisationCode
            // 
            this.colStoneLocalisationCode.Caption = "Taş Lokalizasyon Kodu";
            this.colStoneLocalisationCode.Name = "colStoneLocalisationCode";
            this.colStoneLocalisationCode.Visible = true;
            this.colStoneLocalisationCode.VisibleIndex = 0;
            // 
            // sbAddESWLStoneInfo
            // 
            this.sbAddESWLStoneInfo.Location = new System.Drawing.Point(311, 508);
            this.sbAddESWLStoneInfo.Name = "sbAddESWLStoneInfo";
            this.sbAddESWLStoneInfo.Size = new System.Drawing.Size(123, 22);
            this.sbAddESWLStoneInfo.StyleController = this.lcMedulaReport;
            this.sbAddESWLStoneInfo.TabIndex = 24;
            this.sbAddESWLStoneInfo.Text = "Ekle";
            // 
            // lcStoneDimensionComment
            // 
            this.lcStoneDimensionComment.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lcStoneDimensionComment.Location = new System.Drawing.Point(309, 484);
            this.lcStoneDimensionComment.Name = "lcStoneDimensionComment";
            this.lcStoneDimensionComment.Size = new System.Drawing.Size(122, 13);
            this.lcStoneDimensionComment.StyleController = this.lcMedulaReport;
            this.lcStoneDimensionComment.TabIndex = 23;
            this.lcStoneDimensionComment.Text = "mm cinsinden (örnek 2X5)";
            // 
            // lueKidneyStoneLocalisationCode
            // 
            this.lueKidneyStoneLocalisationCode.Location = new System.Drawing.Point(182, 508);
            this.lueKidneyStoneLocalisationCode.Name = "lueKidneyStoneLocalisationCode";
            this.lueKidneyStoneLocalisationCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueKidneyStoneLocalisationCode.Size = new System.Drawing.Size(125, 20);
            this.lueKidneyStoneLocalisationCode.StyleController = this.lcMedulaReport;
            this.lueKidneyStoneLocalisationCode.TabIndex = 22;
            // 
            // lueKidneyInfo
            // 
            this.lueKidneyInfo.Location = new System.Drawing.Point(170, 428);
            this.lueKidneyInfo.Name = "lueKidneyInfo";
            this.lueKidneyInfo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueKidneyInfo.Size = new System.Drawing.Size(415, 20);
            this.lueKidneyInfo.StyleController = this.lcMedulaReport;
            this.lueKidneyInfo.TabIndex = 20;
            // 
            // teESWLReportSessionCount
            // 
            this.teESWLReportSessionCount.Location = new System.Drawing.Point(170, 404);
            this.teESWLReportSessionCount.Name = "teESWLReportSessionCount";
            this.teESWLReportSessionCount.Size = new System.Drawing.Size(415, 20);
            this.teESWLReportSessionCount.StyleController = this.lcMedulaReport;
            this.teESWLReportSessionCount.TabIndex = 19;
            // 
            // teESWLReportStoneCount
            // 
            this.teESWLReportStoneCount.Location = new System.Drawing.Point(170, 380);
            this.teESWLReportStoneCount.Name = "teESWLReportStoneCount";
            this.teESWLReportStoneCount.Size = new System.Drawing.Size(415, 20);
            this.teESWLReportStoneCount.StyleController = this.lcMedulaReport;
            this.teESWLReportStoneCount.TabIndex = 18;
            // 
            // teESWLBUTCode
            // 
            this.teESWLBUTCode.Location = new System.Drawing.Point(170, 356);
            this.teESWLBUTCode.Name = "teESWLBUTCode";
            this.teESWLBUTCode.Size = new System.Drawing.Size(415, 20);
            this.teESWLBUTCode.StyleController = this.lcMedulaReport;
            this.teESWLBUTCode.TabIndex = 17;
            // 
            // teStoneDimension
            // 
            this.teStoneDimension.Location = new System.Drawing.Point(182, 484);
            this.teStoneDimension.Name = "teStoneDimension";
            this.teStoneDimension.Size = new System.Drawing.Size(123, 20);
            this.teStoneDimension.StyleController = this.lcMedulaReport;
            this.teStoneDimension.TabIndex = 21;
            // 
            // teBUTCode
            // 
            this.teBUTCode.Location = new System.Drawing.Point(170, 288);
            this.teBUTCode.Name = "teBUTCode";
            this.teBUTCode.Size = new System.Drawing.Size(414, 20);
            this.teBUTCode.StyleController = this.lcMedulaReport;
            this.teBUTCode.TabIndex = 16;
            // 
            // teFTRSessionCount
            // 
            this.teFTRSessionCount.Location = new System.Drawing.Point(170, 264);
            this.teFTRSessionCount.Name = "teFTRSessionCount";
            this.teFTRSessionCount.Size = new System.Drawing.Size(414, 20);
            this.teFTRSessionCount.StyleController = this.lcMedulaReport;
            this.teFTRSessionCount.TabIndex = 15;
            // 
            // teFTRSessionDays
            // 
            this.teFTRSessionDays.Location = new System.Drawing.Point(170, 240);
            this.teFTRSessionDays.Name = "teFTRSessionDays";
            this.teFTRSessionDays.Size = new System.Drawing.Size(414, 20);
            this.teFTRSessionDays.StyleController = this.lcMedulaReport;
            this.teFTRSessionDays.TabIndex = 14;
            // 
            // lueFTRBodyPartCode
            // 
            this.lueFTRBodyPartCode.Location = new System.Drawing.Point(170, 216);
            this.lueFTRBodyPartCode.Name = "lueFTRBodyPartCode";
            this.lueFTRBodyPartCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueFTRBodyPartCode.Size = new System.Drawing.Size(414, 20);
            this.lueFTRBodyPartCode.StyleController = this.lcMedulaReport;
            this.lueFTRBodyPartCode.TabIndex = 13;
            // 
            // teESWTBUTCode
            // 
            this.teESWTBUTCode.Location = new System.Drawing.Point(170, 148);
            this.teESWTBUTCode.Name = "teESWTBUTCode";
            this.teESWTBUTCode.Size = new System.Drawing.Size(414, 20);
            this.teESWTBUTCode.StyleController = this.lcMedulaReport;
            this.teESWTBUTCode.TabIndex = 12;
            // 
            // teESWTSessionCount
            // 
            this.teESWTSessionCount.Location = new System.Drawing.Point(170, 124);
            this.teESWTSessionCount.Name = "teESWTSessionCount";
            this.teESWTSessionCount.Size = new System.Drawing.Size(414, 20);
            this.teESWTSessionCount.StyleController = this.lcMedulaReport;
            this.teESWTSessionCount.TabIndex = 11;
            // 
            // teESWTSessionDays
            // 
            this.teESWTSessionDays.Location = new System.Drawing.Point(170, 100);
            this.teESWTSessionDays.Name = "teESWTSessionDays";
            this.teESWTSessionDays.Size = new System.Drawing.Size(414, 20);
            this.teESWTSessionDays.StyleController = this.lcMedulaReport;
            this.teESWTSessionDays.TabIndex = 10;
            // 
            // lueESWTBodyPartCode
            // 
            this.lueESWTBodyPartCode.Location = new System.Drawing.Point(170, 76);
            this.lueESWTBodyPartCode.Name = "lueESWTBodyPartCode";
            this.lueESWTBodyPartCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueESWTBodyPartCode.Size = new System.Drawing.Size(414, 20);
            this.lueESWTBodyPartCode.StyleController = this.lcMedulaReport;
            this.lueESWTBodyPartCode.TabIndex = 9;
            // 
            // teInstitutionNo
            // 
            this.teInstitutionNo.Location = new System.Drawing.Point(391, 164);
            this.teInstitutionNo.Name = "teInstitutionNo";
            this.teInstitutionNo.Size = new System.Drawing.Size(50, 20);
            this.teInstitutionNo.StyleController = this.lcMedulaReport;
            this.teInstitutionNo.TabIndex = 8;
            // 
            // tePatientName
            // 
            this.tePatientName.Location = new System.Drawing.Point(170, 188);
            this.tePatientName.Name = "tePatientName";
            this.tePatientName.Size = new System.Drawing.Size(271, 20);
            this.tePatientName.StyleController = this.lcMedulaReport;
            this.tePatientName.TabIndex = 7;
            // 
            // teFollowUpNo
            // 
            this.teFollowUpNo.Location = new System.Drawing.Point(170, 164);
            this.teFollowUpNo.Name = "teFollowUpNo";
            this.teFollowUpNo.Size = new System.Drawing.Size(83, 20);
            this.teFollowUpNo.StyleController = this.lcMedulaReport;
            this.teFollowUpNo.TabIndex = 6;
            // 
            // lueTreatmentReportType
            // 
            this.lueTreatmentReportType.Location = new System.Drawing.Point(272, 96);
            this.lueTreatmentReportType.Name = "lueTreatmentReportType";
            this.lueTreatmentReportType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTreatmentReportType.Size = new System.Drawing.Size(112, 20);
            this.lueTreatmentReportType.StyleController = this.lcMedulaReport;
            this.lueTreatmentReportType.TabIndex = 5;
            // 
            // rgReportMainType
            // 
            this.rgReportMainType.Location = new System.Drawing.Point(36, 76);
            this.rgReportMainType.Name = "rgReportMainType";
            this.rgReportMainType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "İlaç Raporu"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Tedavi Raporu ->")});
            this.rgReportMainType.Size = new System.Drawing.Size(98, 40);
            this.rgReportMainType.StyleController = this.lcMedulaReport;
            this.rgReportMainType.TabIndex = 4;
            // 
            // deReportStartDate
            // 
            this.deReportStartDate.EditValue = null;
            this.deReportStartDate.Location = new System.Drawing.Point(603, 192);
            this.deReportStartDate.Name = "deReportStartDate";
            this.deReportStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deReportStartDate.Properties.Mask.EditMask = "";
            this.deReportStartDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.deReportStartDate.Properties.NullText = "[EditValue is null]";
            this.deReportStartDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deReportStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deReportStartDate.Size = new System.Drawing.Size(282, 20);
            this.deReportStartDate.StyleController = this.lcMedulaReport;
            this.deReportStartDate.TabIndex = 46;
            // 
            // deReportEndDate
            // 
            this.deReportEndDate.EditValue = null;
            this.deReportEndDate.Location = new System.Drawing.Point(603, 216);
            this.deReportEndDate.Name = "deReportEndDate";
            this.deReportEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deReportEndDate.Properties.Mask.EditMask = "";
            this.deReportEndDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.deReportEndDate.Properties.NullText = "[EditValue is null]";
            this.deReportEndDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deReportEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deReportEndDate.Size = new System.Drawing.Size(282, 20);
            this.deReportEndDate.StyleController = this.lcMedulaReport;
            this.deReportEndDate.TabIndex = 47;
            // 
            // deProtocolDate
            // 
            this.deProtocolDate.EditValue = null;
            this.deProtocolDate.Location = new System.Drawing.Point(603, 288);
            this.deProtocolDate.Name = "deProtocolDate";
            this.deProtocolDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deProtocolDate.Properties.Mask.EditMask = "";
            this.deProtocolDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.deProtocolDate.Properties.NullText = "[EditValue is null]";
            this.deProtocolDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deProtocolDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deProtocolDate.Size = new System.Drawing.Size(282, 20);
            this.deProtocolDate.StyleController = this.lcMedulaReport;
            this.deProtocolDate.TabIndex = 50;
            // 
            // meClinicalDiagnosis
            // 
            this.meClinicalDiagnosis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.meClinicalDiagnosis.Location = new System.Drawing.Point(481, 368);
            this.meClinicalDiagnosis.Name = "meClinicalDiagnosis";
            this.meClinicalDiagnosis.Size = new System.Drawing.Size(392, 49);
            this.meClinicalDiagnosis.StyleController = this.lcMedulaReport;
            this.meClinicalDiagnosis.TabIndex = 52;
            // 
            // meDescription
            // 
            this.meDescription.Location = new System.Drawing.Point(481, 465);
            this.meDescription.Name = "meDescription";
            this.meDescription.Size = new System.Drawing.Size(392, 44);
            this.meDescription.StyleController = this.lcMedulaReport;
            this.meDescription.TabIndex = 53;
            // 
            // deProvisionDate
            // 
            this.deProvisionDate.EditValue = null;
            this.deProvisionDate.Location = new System.Drawing.Point(391, 260);
            this.deProvisionDate.Name = "deProvisionDate";
            this.deProvisionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deProvisionDate.Properties.Mask.EditMask = "";
            this.deProvisionDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.deProvisionDate.Properties.NullText = "[EditValue is null]";
            this.deProvisionDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deProvisionDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deProvisionDate.Size = new System.Drawing.Size(50, 20);
            this.deProvisionDate.StyleController = this.lcMedulaReport;
            this.deProvisionDate.TabIndex = 32;
            // 
            // lcgMedulaReport
            // 
            this.lcgMedulaReport.CustomizationFormText = "layoutControlGroup1";
            this.lcgMedulaReport.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMedulaReport.GroupBordersVisible = false;
            this.lcgMedulaReport.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tcgMedulaReport});
            this.lcgMedulaReport.Location = new System.Drawing.Point(0, 0);
            this.lcgMedulaReport.Name = "lcgMedulaReport";
            this.lcgMedulaReport.Size = new System.Drawing.Size(921, 746);
            this.lcgMedulaReport.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMedulaReport.Text = "lcgMedulaReport";
            this.lcgMedulaReport.TextVisible = false;
            // 
            // tcgMedulaReport
            // 
            this.tcgMedulaReport.CustomizationFormText = "tabbedControlGroup1";
            this.tcgMedulaReport.Location = new System.Drawing.Point(0, 0);
            this.tcgMedulaReport.Name = "tcgMedulaReport";
            this.tcgMedulaReport.SelectedTabPage = this.lcgReportDetailInfo;
            this.tcgMedulaReport.SelectedTabPageIndex = 0;
            this.tcgMedulaReport.Size = new System.Drawing.Size(901, 726);
            this.tcgMedulaReport.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgReportDetailInfo,
            this.lcgESWTFTRESWLReportInfo});
            this.tcgMedulaReport.Text = "tcgMedulaReport";
            // 
            // lcgReportDetailInfo
            // 
            this.lcgReportDetailInfo.CustomizationFormText = "Rapor Detay Bilgileri";
            this.lcgReportDetailInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgReportType,
            this.lcgPatientInfo,
            this.lcgDoctorInfo,
            this.lcgReportInfo,
            this.lcgReport,
            this.lcgDiagnosisInfo});
            this.lcgReportDetailInfo.Location = new System.Drawing.Point(0, 0);
            this.lcgReportDetailInfo.Name = "lcgReportDetailInfo";
            this.lcgReportDetailInfo.Size = new System.Drawing.Size(877, 682);
            this.lcgReportDetailInfo.Text = "Rapor Detay Bilgileri";
            // 
            // lcgReportType
            // 
            this.lcgReportType.CustomizationFormText = "Rapor Türü";
            this.lcgReportType.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciReportMainType,
            this.lciTreatmentReportType,
            this.emptySpaceItem5,
            this.emptySpaceItem6});
            this.lcgReportType.Location = new System.Drawing.Point(0, 0);
            this.lcgReportType.Name = "lcgReportType";
            this.lcgReportType.Size = new System.Drawing.Size(433, 88);
            this.lcgReportType.Text = "Rapor Türü";
            // 
            // lciReportMainType
            // 
            this.lciReportMainType.Control = this.rgReportMainType;
            this.lciReportMainType.CustomizationFormText = "Rapor Türü";
            this.lciReportMainType.Location = new System.Drawing.Point(0, 0);
            this.lciReportMainType.Name = "lciReportMainType";
            this.lciReportMainType.Size = new System.Drawing.Size(102, 44);
            this.lciReportMainType.Text = "lciReportMainType";
            this.lciReportMainType.TextSize = new System.Drawing.Size(0, 0);
            this.lciReportMainType.TextToControlDistance = 0;
            this.lciReportMainType.TextVisible = false;
            // 
            // lciTreatmentReportType
            // 
            this.lciTreatmentReportType.Control = this.lueTreatmentReportType;
            this.lciTreatmentReportType.CustomizationFormText = "Tedavi Rapor Türü";
            this.lciTreatmentReportType.Location = new System.Drawing.Point(102, 20);
            this.lciTreatmentReportType.Name = "lciTreatmentReportType";
            this.lciTreatmentReportType.Size = new System.Drawing.Size(250, 24);
            this.lciTreatmentReportType.Text = "Tedavi Rapor Türü";
            this.lciTreatmentReportType.TextSize = new System.Drawing.Size(130, 13);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5";
            this.emptySpaceItem5.Location = new System.Drawing.Point(102, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(307, 20);
            this.emptySpaceItem5.Text = "emptySpaceItem5";
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.CustomizationFormText = "emptySpaceItem6";
            this.emptySpaceItem6.Location = new System.Drawing.Point(352, 20);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(57, 24);
            this.emptySpaceItem6.Text = "emptySpaceItem6";
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lcgPatientInfo
            // 
            this.lcgPatientInfo.CustomizationFormText = "Hasta Bilgileri";
            this.lcgPatientInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPatientName,
            this.lciFollowUpNo,
            this.lciInstitutionNo,
            this.lciTCID,
            this.lciSocialSecurityNo,
            this.lciCardNo,
            this.lciTransferorInstitution,
            this.lciRelationCode,
            this.lciProvisionType,
            this.lciProvisionDate,
            this.lciInsuranceType});
            this.lcgPatientInfo.Location = new System.Drawing.Point(0, 88);
            this.lcgPatientInfo.Name = "lcgPatientInfo";
            this.lcgPatientInfo.Size = new System.Drawing.Size(433, 188);
            this.lcgPatientInfo.Text = "Hasta Bilgileri";
            // 
            // lciPatientName
            // 
            this.lciPatientName.Control = this.tePatientName;
            this.lciPatientName.CustomizationFormText = "Hasta Adı Soyadı";
            this.lciPatientName.Location = new System.Drawing.Point(0, 24);
            this.lciPatientName.Name = "lciPatientName";
            this.lciPatientName.Size = new System.Drawing.Size(409, 24);
            this.lciPatientName.Text = "Hasta Adı Soyadı";
            this.lciPatientName.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciFollowUpNo
            // 
            this.lciFollowUpNo.Control = this.teFollowUpNo;
            this.lciFollowUpNo.CustomizationFormText = "Takip No";
            this.lciFollowUpNo.Location = new System.Drawing.Point(0, 0);
            this.lciFollowUpNo.Name = "lciFollowUpNo";
            this.lciFollowUpNo.Size = new System.Drawing.Size(221, 24);
            this.lciFollowUpNo.Text = "Takip No";
            this.lciFollowUpNo.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciInstitutionNo
            // 
            this.lciInstitutionNo.Control = this.teInstitutionNo;
            this.lciInstitutionNo.CustomizationFormText = "Tesis Kodu";
            this.lciInstitutionNo.Location = new System.Drawing.Point(221, 0);
            this.lciInstitutionNo.Name = "lciInstitutionNo";
            this.lciInstitutionNo.Size = new System.Drawing.Size(188, 24);
            this.lciInstitutionNo.Text = "Tesis Kodu";
            this.lciInstitutionNo.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciTCID
            // 
            this.lciTCID.Control = this.teTCID;
            this.lciTCID.CustomizationFormText = "T.C. Kimlik No";
            this.lciTCID.Location = new System.Drawing.Point(0, 48);
            this.lciTCID.Name = "lciTCID";
            this.lciTCID.Size = new System.Drawing.Size(221, 24);
            this.lciTCID.Text = "T.C. Kimlik No";
            this.lciTCID.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciSocialSecurityNo
            // 
            this.lciSocialSecurityNo.Control = this.teSocialSecurityNo;
            this.lciSocialSecurityNo.CustomizationFormText = "Sosyal Güvenlik No";
            this.lciSocialSecurityNo.Location = new System.Drawing.Point(0, 72);
            this.lciSocialSecurityNo.Name = "lciSocialSecurityNo";
            this.lciSocialSecurityNo.Size = new System.Drawing.Size(221, 24);
            this.lciSocialSecurityNo.Text = "Sosyal Güvenlik No";
            this.lciSocialSecurityNo.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciCardNo
            // 
            this.lciCardNo.Control = this.teCardNo;
            this.lciCardNo.CustomizationFormText = "Karne No";
            this.lciCardNo.Location = new System.Drawing.Point(0, 96);
            this.lciCardNo.Name = "lciCardNo";
            this.lciCardNo.Size = new System.Drawing.Size(221, 24);
            this.lciCardNo.Text = "Karne No";
            this.lciCardNo.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciTransferorInstitution
            // 
            this.lciTransferorInstitution.Control = this.lueTransferorInstitution;
            this.lciTransferorInstitution.CustomizationFormText = "Devredilen Kurum";
            this.lciTransferorInstitution.Location = new System.Drawing.Point(0, 120);
            this.lciTransferorInstitution.Name = "lciTransferorInstitution";
            this.lciTransferorInstitution.Size = new System.Drawing.Size(221, 24);
            this.lciTransferorInstitution.Text = "Devredilen Kurum";
            this.lciTransferorInstitution.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciRelationCode
            // 
            this.lciRelationCode.Control = this.teRelationCode;
            this.lciRelationCode.CustomizationFormText = "Yakınlık Kodu";
            this.lciRelationCode.Location = new System.Drawing.Point(221, 48);
            this.lciRelationCode.Name = "lciRelationCode";
            this.lciRelationCode.Size = new System.Drawing.Size(188, 24);
            this.lciRelationCode.Text = "Yakınlık Kodu";
            this.lciRelationCode.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciProvisionType
            // 
            this.lciProvisionType.Control = this.lueProvisionType;
            this.lciProvisionType.CustomizationFormText = "Provizyon Tipi";
            this.lciProvisionType.Location = new System.Drawing.Point(221, 72);
            this.lciProvisionType.Name = "lciProvisionType";
            this.lciProvisionType.Size = new System.Drawing.Size(188, 24);
            this.lciProvisionType.Text = "Provizyon Tipi";
            this.lciProvisionType.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciProvisionDate
            // 
            this.lciProvisionDate.Control = this.deProvisionDate;
            this.lciProvisionDate.CustomizationFormText = "Provizyon Tarihi";
            this.lciProvisionDate.Location = new System.Drawing.Point(221, 96);
            this.lciProvisionDate.Name = "lciProvisionDate";
            this.lciProvisionDate.Size = new System.Drawing.Size(188, 24);
            this.lciProvisionDate.Text = "Provizyon Tarihi";
            this.lciProvisionDate.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciInsuranceType
            // 
            this.lciInsuranceType.Control = this.lueInsuranceType;
            this.lciInsuranceType.CustomizationFormText = "Sigortalı Türü";
            this.lciInsuranceType.Location = new System.Drawing.Point(221, 120);
            this.lciInsuranceType.Name = "lciInsuranceType";
            this.lciInsuranceType.Size = new System.Drawing.Size(188, 24);
            this.lciInsuranceType.Text = "Sigortalı Türü";
            this.lciInsuranceType.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lcgDoctorInfo
            // 
            this.lcgDoctorInfo.CustomizationFormText = "Doktor Bilgisi";
            this.lcgDoctorInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciAddDoctor,
            this.lciDoctorType,
            this.lciDoctorBranch,
            this.lciDoctorRegistrationNo,
            this.lciDoctorFirstName,
            this.lciDoctorLastName,
            this.lciDoctors,
            this.emptySpaceItem10});
            this.lcgDoctorInfo.Location = new System.Drawing.Point(0, 276);
            this.lcgDoctorInfo.Name = "lcgDoctorInfo";
            this.lcgDoctorInfo.Size = new System.Drawing.Size(433, 218);
            this.lcgDoctorInfo.Text = "Doktor Bilgisi";
            // 
            // lciAddDoctor
            // 
            this.lciAddDoctor.Control = this.sbAddDoctor;
            this.lciAddDoctor.CustomizationFormText = "Doktor Ekle";
            this.lciAddDoctor.Location = new System.Drawing.Point(227, 48);
            this.lciAddDoctor.Name = "lciAddDoctor";
            this.lciAddDoctor.Size = new System.Drawing.Size(85, 26);
            this.lciAddDoctor.Text = "lciAddDoctor";
            this.lciAddDoctor.TextSize = new System.Drawing.Size(0, 0);
            this.lciAddDoctor.TextToControlDistance = 0;
            this.lciAddDoctor.TextVisible = false;
            // 
            // lciDoctorType
            // 
            this.lciDoctorType.Control = this.lueDoctorType;
            this.lciDoctorType.CustomizationFormText = "Tipi";
            this.lciDoctorType.Location = new System.Drawing.Point(221, 24);
            this.lciDoctorType.Name = "lciDoctorType";
            this.lciDoctorType.Size = new System.Drawing.Size(188, 24);
            this.lciDoctorType.Text = "Tipi";
            this.lciDoctorType.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciDoctorBranch
            // 
            this.lciDoctorBranch.Control = this.lueDoctorBranch;
            this.lciDoctorBranch.CustomizationFormText = "Dr. Branş Kodu";
            this.lciDoctorBranch.Location = new System.Drawing.Point(221, 0);
            this.lciDoctorBranch.Name = "lciDoctorBranch";
            this.lciDoctorBranch.Size = new System.Drawing.Size(188, 24);
            this.lciDoctorBranch.Text = "Dr. Branş Kodu";
            this.lciDoctorBranch.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciDoctorRegistrationNo
            // 
            this.lciDoctorRegistrationNo.Control = this.lueDoctorRegistrationNo;
            this.lciDoctorRegistrationNo.CustomizationFormText = "Dr. Tescil No";
            this.lciDoctorRegistrationNo.Location = new System.Drawing.Point(0, 0);
            this.lciDoctorRegistrationNo.Name = "lciDoctorRegistrationNo";
            this.lciDoctorRegistrationNo.Size = new System.Drawing.Size(221, 24);
            this.lciDoctorRegistrationNo.Text = "Dr. Tescil No";
            this.lciDoctorRegistrationNo.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciDoctorFirstName
            // 
            this.lciDoctorFirstName.Control = this.teDoctorFirstName;
            this.lciDoctorFirstName.CustomizationFormText = "Dr. Adı";
            this.lciDoctorFirstName.Location = new System.Drawing.Point(0, 24);
            this.lciDoctorFirstName.Name = "lciDoctorFirstName";
            this.lciDoctorFirstName.Size = new System.Drawing.Size(221, 24);
            this.lciDoctorFirstName.Text = "Dr. Adı";
            this.lciDoctorFirstName.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciDoctorLastName
            // 
            this.lciDoctorLastName.Control = this.teDoctorLastName;
            this.lciDoctorLastName.CustomizationFormText = "Dr. Soyadı";
            this.lciDoctorLastName.Location = new System.Drawing.Point(0, 48);
            this.lciDoctorLastName.Name = "lciDoctorLastName";
            this.lciDoctorLastName.Size = new System.Drawing.Size(227, 26);
            this.lciDoctorLastName.Text = "Dr. Soyadı";
            this.lciDoctorLastName.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciDoctors
            // 
            this.lciDoctors.Control = this.gcDoctors;
            this.lciDoctors.CustomizationFormText = "Doktorlar";
            this.lciDoctors.Location = new System.Drawing.Point(0, 74);
            this.lciDoctors.Name = "lciDoctors";
            this.lciDoctors.Size = new System.Drawing.Size(409, 100);
            this.lciDoctors.Text = "Doktorlar";
            this.lciDoctors.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciDoctors.TextSize = new System.Drawing.Size(130, 13);
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.CustomizationFormText = "emptySpaceItem10";
            this.emptySpaceItem10.Location = new System.Drawing.Point(312, 48);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(97, 26);
            this.emptySpaceItem10.Text = "emptySpaceItem10";
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lcgReportInfo
            // 
            this.lcgReportInfo.CustomizationFormText = "Rapor Bilgisi";
            this.lcgReportInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciReportDate,
            this.lciReportNo});
            this.lcgReportInfo.Location = new System.Drawing.Point(433, 0);
            this.lcgReportInfo.Name = "lcgReportInfo";
            this.lcgReportInfo.Size = new System.Drawing.Size(444, 92);
            this.lcgReportInfo.Text = "Rapor Bilgisi";
            // 
            // lciReportDate
            // 
            this.lciReportDate.Control = this.deReportDate;
            this.lciReportDate.CustomizationFormText = "Rapor Tarihi";
            this.lciReportDate.Location = new System.Drawing.Point(0, 24);
            this.lciReportDate.Name = "lciReportDate";
            this.lciReportDate.Size = new System.Drawing.Size(420, 24);
            this.lciReportDate.Text = "Rapor Tarihi";
            this.lciReportDate.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciReportNo
            // 
            this.lciReportNo.Control = this.teReportNo;
            this.lciReportNo.CustomizationFormText = "Rapor No";
            this.lciReportNo.Location = new System.Drawing.Point(0, 0);
            this.lciReportNo.Name = "lciReportNo";
            this.lciReportNo.Size = new System.Drawing.Size(420, 24);
            this.lciReportNo.Text = "Rapor No";
            this.lciReportNo.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lcgReport
            // 
            this.lcgReport.CustomizationFormText = "Rapor";
            this.lcgReport.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciReportType,
            this.lciReportStartDate,
            this.lciReportEndDate,
            this.lciEditingType,
            this.lciProtocolNo,
            this.lciProtocolDate,
            this.lciStatus,
            this.lcgClinicalDiagnosis,
            this.lcgDescription,
            this.lciPrint,
            this.lciSave,
            this.lciCancel,
            this.lcgEffectiveSubsance});
            this.lcgReport.Location = new System.Drawing.Point(433, 92);
            this.lcgReport.Name = "lcgReport";
            this.lcgReport.Size = new System.Drawing.Size(444, 590);
            this.lcgReport.Text = "Rapor";
            // 
            // lciReportType
            // 
            this.lciReportType.Control = this.lueReportType;
            this.lciReportType.CustomizationFormText = "Rapor Türü";
            this.lciReportType.Location = new System.Drawing.Point(0, 0);
            this.lciReportType.Name = "lciReportType";
            this.lciReportType.Size = new System.Drawing.Size(420, 24);
            this.lciReportType.Text = "Rapor Türü";
            this.lciReportType.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciReportStartDate
            // 
            this.lciReportStartDate.Control = this.deReportStartDate;
            this.lciReportStartDate.CustomizationFormText = "Rapor Başlangıç Tarihi";
            this.lciReportStartDate.Location = new System.Drawing.Point(0, 24);
            this.lciReportStartDate.Name = "lciReportStartDate";
            this.lciReportStartDate.Size = new System.Drawing.Size(420, 24);
            this.lciReportStartDate.Text = "Rapor Başlangıç Tarihi";
            this.lciReportStartDate.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciReportEndDate
            // 
            this.lciReportEndDate.Control = this.deReportEndDate;
            this.lciReportEndDate.CustomizationFormText = "Rapor Bitiş Tarihi";
            this.lciReportEndDate.Location = new System.Drawing.Point(0, 48);
            this.lciReportEndDate.Name = "lciReportEndDate";
            this.lciReportEndDate.Size = new System.Drawing.Size(420, 24);
            this.lciReportEndDate.Text = "Rapor Bitiş Tarihi";
            this.lciReportEndDate.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciEditingType
            // 
            this.lciEditingType.Control = this.lueEditingType;
            this.lciEditingType.CustomizationFormText = "Düzenleme Türü";
            this.lciEditingType.Location = new System.Drawing.Point(0, 72);
            this.lciEditingType.Name = "lciEditingType";
            this.lciEditingType.Size = new System.Drawing.Size(420, 24);
            this.lciEditingType.Text = "Düzenleme Türü";
            this.lciEditingType.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciProtocolNo
            // 
            this.lciProtocolNo.Control = this.teProtocolNo;
            this.lciProtocolNo.CustomizationFormText = "Protokol No";
            this.lciProtocolNo.Location = new System.Drawing.Point(0, 96);
            this.lciProtocolNo.Name = "lciProtocolNo";
            this.lciProtocolNo.Size = new System.Drawing.Size(420, 24);
            this.lciProtocolNo.Text = "Protokol No";
            this.lciProtocolNo.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciProtocolDate
            // 
            this.lciProtocolDate.Control = this.deProtocolDate;
            this.lciProtocolDate.CustomizationFormText = "Protokol Tarihi";
            this.lciProtocolDate.Location = new System.Drawing.Point(0, 120);
            this.lciProtocolDate.Name = "lciProtocolDate";
            this.lciProtocolDate.Size = new System.Drawing.Size(420, 24);
            this.lciProtocolDate.Text = "Protokol Tarihi";
            this.lciProtocolDate.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciStatus
            // 
            this.lciStatus.Control = this.lueStatus;
            this.lciStatus.CustomizationFormText = "Durum";
            this.lciStatus.Location = new System.Drawing.Point(0, 144);
            this.lciStatus.Name = "lciStatus";
            this.lciStatus.Size = new System.Drawing.Size(420, 24);
            this.lciStatus.Text = "Durum";
            this.lciStatus.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lcgClinicalDiagnosis
            // 
            this.lcgClinicalDiagnosis.CustomizationFormText = "Klinik Tanı";
            this.lcgClinicalDiagnosis.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciClinicalDiagnosis});
            this.lcgClinicalDiagnosis.Location = new System.Drawing.Point(0, 168);
            this.lcgClinicalDiagnosis.Name = "lcgClinicalDiagnosis";
            this.lcgClinicalDiagnosis.Size = new System.Drawing.Size(420, 97);
            this.lcgClinicalDiagnosis.Text = "Klinik Tanı";
            // 
            // lciClinicalDiagnosis
            // 
            this.lciClinicalDiagnosis.Control = this.meClinicalDiagnosis;
            this.lciClinicalDiagnosis.CustomizationFormText = "Klinik Tanı";
            this.lciClinicalDiagnosis.Location = new System.Drawing.Point(0, 0);
            this.lciClinicalDiagnosis.Name = "lciClinicalDiagnosis";
            this.lciClinicalDiagnosis.Size = new System.Drawing.Size(396, 53);
            this.lciClinicalDiagnosis.Text = "Klinik Tanı";
            this.lciClinicalDiagnosis.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciClinicalDiagnosis.TextSize = new System.Drawing.Size(0, 0);
            this.lciClinicalDiagnosis.TextToControlDistance = 0;
            this.lciClinicalDiagnosis.TextVisible = false;
            // 
            // lcgDescription
            // 
            this.lcgDescription.CustomizationFormText = "Açıklama";
            this.lcgDescription.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDescription});
            this.lcgDescription.Location = new System.Drawing.Point(0, 265);
            this.lcgDescription.Name = "lcgDescription";
            this.lcgDescription.Size = new System.Drawing.Size(420, 92);
            this.lcgDescription.Text = "Açıklama";
            // 
            // lciDescription
            // 
            this.lciDescription.Control = this.meDescription;
            this.lciDescription.CustomizationFormText = "Açıklama";
            this.lciDescription.Location = new System.Drawing.Point(0, 0);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.Size = new System.Drawing.Size(396, 48);
            this.lciDescription.Text = "lciDescription";
            this.lciDescription.TextSize = new System.Drawing.Size(0, 0);
            this.lciDescription.TextToControlDistance = 0;
            this.lciDescription.TextVisible = false;
            // 
            // lciPrint
            // 
            this.lciPrint.Control = this.sbPrint;
            this.lciPrint.CustomizationFormText = "Yazdır";
            this.lciPrint.Location = new System.Drawing.Point(0, 520);
            this.lciPrint.Name = "lciPrint";
            this.lciPrint.Size = new System.Drawing.Size(142, 26);
            this.lciPrint.Text = "lciPrint";
            this.lciPrint.TextSize = new System.Drawing.Size(0, 0);
            this.lciPrint.TextToControlDistance = 0;
            this.lciPrint.TextVisible = false;
            // 
            // lciSave
            // 
            this.lciSave.Control = this.sbSave;
            this.lciSave.CustomizationFormText = "Kaydet";
            this.lciSave.Location = new System.Drawing.Point(142, 520);
            this.lciSave.Name = "lciSave";
            this.lciSave.Size = new System.Drawing.Size(110, 26);
            this.lciSave.Text = "lciSave";
            this.lciSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciSave.TextToControlDistance = 0;
            this.lciSave.TextVisible = false;
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.sbCancel;
            this.lciCancel.CustomizationFormText = "Vazgeç";
            this.lciCancel.Location = new System.Drawing.Point(252, 520);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.Size = new System.Drawing.Size(168, 26);
            this.lciCancel.Text = "lciCancel";
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextToControlDistance = 0;
            this.lciCancel.TextVisible = false;
            // 
            // lcgEffectiveSubsance
            // 
            this.lcgEffectiveSubsance.CustomizationFormText = "Etkin Madde";
            this.lcgEffectiveSubsance.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciEffectiveSubsance,
            this.lciDeleteEffectiveSubsance,
            this.lciAddEffectiveSubsance});
            this.lcgEffectiveSubsance.Location = new System.Drawing.Point(0, 357);
            this.lcgEffectiveSubsance.Name = "lcgEffectiveSubsance";
            this.lcgEffectiveSubsance.Size = new System.Drawing.Size(420, 163);
            this.lcgEffectiveSubsance.Text = "Etkin Madde";
            // 
            // lciEffectiveSubsance
            // 
            this.lciEffectiveSubsance.Control = this.gcEffectiveSubsance;
            this.lciEffectiveSubsance.CustomizationFormText = "Etkin Madde Grid";
            this.lciEffectiveSubsance.Location = new System.Drawing.Point(0, 0);
            this.lciEffectiveSubsance.Name = "lciEffectiveSubsance";
            this.lciEffectiveSubsance.Size = new System.Drawing.Size(396, 93);
            this.lciEffectiveSubsance.Text = "lciEffectiveSubsance";
            this.lciEffectiveSubsance.TextSize = new System.Drawing.Size(0, 0);
            this.lciEffectiveSubsance.TextToControlDistance = 0;
            this.lciEffectiveSubsance.TextVisible = false;
            // 
            // lciDeleteEffectiveSubsance
            // 
            this.lciDeleteEffectiveSubsance.Control = this.sbDeleteEffectiveSubsance;
            this.lciDeleteEffectiveSubsance.CustomizationFormText = "Etkin Madde Ekle";
            this.lciDeleteEffectiveSubsance.Location = new System.Drawing.Point(0, 93);
            this.lciDeleteEffectiveSubsance.Name = "lciDeleteEffectiveSubsance";
            this.lciDeleteEffectiveSubsance.Size = new System.Drawing.Size(181, 26);
            this.lciDeleteEffectiveSubsance.Text = "lciDeleteEffectiveSubsance";
            this.lciDeleteEffectiveSubsance.TextSize = new System.Drawing.Size(0, 0);
            this.lciDeleteEffectiveSubsance.TextToControlDistance = 0;
            this.lciDeleteEffectiveSubsance.TextVisible = false;
            // 
            // lciAddEffectiveSubsance
            // 
            this.lciAddEffectiveSubsance.Control = this.sbAddEffectiveSubsance;
            this.lciAddEffectiveSubsance.CustomizationFormText = "Etkin Madde Sil";
            this.lciAddEffectiveSubsance.Location = new System.Drawing.Point(181, 93);
            this.lciAddEffectiveSubsance.Name = "lciAddEffectiveSubsance";
            this.lciAddEffectiveSubsance.Size = new System.Drawing.Size(215, 26);
            this.lciAddEffectiveSubsance.Text = "lciAddEffectiveSubsance";
            this.lciAddEffectiveSubsance.TextSize = new System.Drawing.Size(0, 0);
            this.lciAddEffectiveSubsance.TextToControlDistance = 0;
            this.lciAddEffectiveSubsance.TextVisible = false;
            // 
            // lcgDiagnosisInfo
            // 
            this.lcgDiagnosisInfo.CustomizationFormText = "Teşhis Bilgisi";
            this.lcgDiagnosisInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciStartDate,
            this.lciEndDate,
            this.lciDiagnosisGrid,
            this.lciICDGrid,
            this.emptySpaceItem7,
            this.emptySpaceItem9,
            this.lciDeleteDiagnosis,
            this.lciAddDiagnosis,
            this.lciSyncDiagnosis});
            this.lcgDiagnosisInfo.Location = new System.Drawing.Point(0, 494);
            this.lcgDiagnosisInfo.Name = "lcgDiagnosisInfo";
            this.lcgDiagnosisInfo.Size = new System.Drawing.Size(433, 188);
            this.lcgDiagnosisInfo.Text = "Teşhis Bilgisi";
            // 
            // lciStartDate
            // 
            this.lciStartDate.Control = this.deStartDate;
            this.lciStartDate.CustomizationFormText = "Başlangıç Tarihi";
            this.lciStartDate.Location = new System.Drawing.Point(0, 0);
            this.lciStartDate.Name = "lciStartDate";
            this.lciStartDate.Size = new System.Drawing.Size(140, 40);
            this.lciStartDate.Text = "Başlangıç Tarihi";
            this.lciStartDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciStartDate.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciEndDate
            // 
            this.lciEndDate.Control = this.deEndDate;
            this.lciEndDate.CustomizationFormText = "Bitiş Tarihi";
            this.lciEndDate.Location = new System.Drawing.Point(214, 0);
            this.lciEndDate.Name = "lciEndDate";
            this.lciEndDate.Size = new System.Drawing.Size(141, 40);
            this.lciEndDate.Text = "Bitiş Tarihi";
            this.lciEndDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciEndDate.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciDiagnosisGrid
            // 
            this.lciDiagnosisGrid.Control = this.gcDiagnosis;
            this.lciDiagnosisGrid.CustomizationFormText = "Teşhis Grid";
            this.lciDiagnosisGrid.Location = new System.Drawing.Point(0, 40);
            this.lciDiagnosisGrid.Name = "lciDiagnosisGrid";
            this.lciDiagnosisGrid.Size = new System.Drawing.Size(205, 78);
            this.lciDiagnosisGrid.Text = "lciDiagnosisGrid";
            this.lciDiagnosisGrid.TextSize = new System.Drawing.Size(0, 0);
            this.lciDiagnosisGrid.TextToControlDistance = 0;
            this.lciDiagnosisGrid.TextVisible = false;
            // 
            // lciICDGrid
            // 
            this.lciICDGrid.Control = this.gcICD;
            this.lciICDGrid.CustomizationFormText = "ICD10 Grid";
            this.lciICDGrid.Location = new System.Drawing.Point(205, 40);
            this.lciICDGrid.Name = "lciICDGrid";
            this.lciICDGrid.Size = new System.Drawing.Size(204, 78);
            this.lciICDGrid.Text = "lciICDGrid";
            this.lciICDGrid.TextSize = new System.Drawing.Size(0, 0);
            this.lciICDGrid.TextToControlDistance = 0;
            this.lciICDGrid.TextVisible = false;
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.CustomizationFormText = "emptySpaceItem7";
            this.emptySpaceItem7.Location = new System.Drawing.Point(355, 0);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(54, 40);
            this.emptySpaceItem7.Text = "emptySpaceItem7";
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.CustomizationFormText = "emptySpaceItem9";
            this.emptySpaceItem9.Location = new System.Drawing.Point(140, 0);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(74, 40);
            this.emptySpaceItem9.Text = "emptySpaceItem9";
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciDeleteDiagnosis
            // 
            this.lciDeleteDiagnosis.Control = this.sbDeleteDiagnosis;
            this.lciDeleteDiagnosis.CustomizationFormText = "Teşhis Sil";
            this.lciDeleteDiagnosis.Location = new System.Drawing.Point(0, 118);
            this.lciDeleteDiagnosis.Name = "lciDeleteDiagnosis";
            this.lciDeleteDiagnosis.Size = new System.Drawing.Size(152, 26);
            this.lciDeleteDiagnosis.Text = "lciDeleteDiagnosis";
            this.lciDeleteDiagnosis.TextSize = new System.Drawing.Size(0, 0);
            this.lciDeleteDiagnosis.TextToControlDistance = 0;
            this.lciDeleteDiagnosis.TextVisible = false;
            // 
            // lciAddDiagnosis
            // 
            this.lciAddDiagnosis.Control = this.sbAddDiagnosis;
            this.lciAddDiagnosis.CustomizationFormText = "Teşhis Ekle";
            this.lciAddDiagnosis.Location = new System.Drawing.Point(152, 118);
            this.lciAddDiagnosis.Name = "lciAddDiagnosis";
            this.lciAddDiagnosis.Size = new System.Drawing.Size(113, 26);
            this.lciAddDiagnosis.Text = "lciAddDiagnosis";
            this.lciAddDiagnosis.TextSize = new System.Drawing.Size(0, 0);
            this.lciAddDiagnosis.TextToControlDistance = 0;
            this.lciAddDiagnosis.TextVisible = false;
            // 
            // lciSyncDiagnosis
            // 
            this.lciSyncDiagnosis.Control = this.sbSyncDiagnosis;
            this.lciSyncDiagnosis.CustomizationFormText = "Tanıyı Teşhisle Eşleştir";
            this.lciSyncDiagnosis.Location = new System.Drawing.Point(265, 118);
            this.lciSyncDiagnosis.Name = "lciSyncDiagnosis";
            this.lciSyncDiagnosis.Size = new System.Drawing.Size(144, 26);
            this.lciSyncDiagnosis.Text = "lciSyncDiagnosis";
            this.lciSyncDiagnosis.TextSize = new System.Drawing.Size(0, 0);
            this.lciSyncDiagnosis.TextToControlDistance = 0;
            this.lciSyncDiagnosis.TextVisible = false;
            // 
            // lcgESWTFTRESWLReportInfo
            // 
            this.lcgESWTFTRESWLReportInfo.CustomizationFormText = "layoutControlGroup5";
            this.lcgESWTFTRESWLReportInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgESWTReportInfo,
            this.lcgFTRReportInfo,
            this.lcgESWLReportInfo,
            this.emptySpaceItem3,
            this.emptySpaceItem4});
            this.lcgESWTFTRESWLReportInfo.Location = new System.Drawing.Point(0, 0);
            this.lcgESWTFTRESWLReportInfo.Name = "lcgESWTFTRESWLReportInfo";
            this.lcgESWTFTRESWLReportInfo.Size = new System.Drawing.Size(877, 682);
            this.lcgESWTFTRESWLReportInfo.Text = "ESWT-FTR-ESWL Rapor Bilgileri";
            // 
            // lcgESWTReportInfo
            // 
            this.lcgESWTReportInfo.CustomizationFormText = "ESWT Rapor Bilgileri";
            this.lcgESWTReportInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciESWTBUTCode,
            this.lciESWTSessionCount,
            this.lciESWTSessionDays,
            this.lciESWTBodyPartCode});
            this.lcgESWTReportInfo.Location = new System.Drawing.Point(0, 0);
            this.lcgESWTReportInfo.Name = "lcgESWTReportInfo";
            this.lcgESWTReportInfo.Size = new System.Drawing.Size(576, 140);
            this.lcgESWTReportInfo.Text = "ESWT Rapor Bilgileri";
            // 
            // lciESWTBUTCode
            // 
            this.lciESWTBUTCode.Control = this.teESWTBUTCode;
            this.lciESWTBUTCode.CustomizationFormText = "But Kodu *";
            this.lciESWTBUTCode.Location = new System.Drawing.Point(0, 72);
            this.lciESWTBUTCode.Name = "lciESWTBUTCode";
            this.lciESWTBUTCode.Size = new System.Drawing.Size(552, 24);
            this.lciESWTBUTCode.Text = "But Kodu *";
            this.lciESWTBUTCode.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciESWTSessionCount
            // 
            this.lciESWTSessionCount.Control = this.teESWTSessionCount;
            this.lciESWTSessionCount.CustomizationFormText = "Seans Sayısı *";
            this.lciESWTSessionCount.Location = new System.Drawing.Point(0, 48);
            this.lciESWTSessionCount.Name = "lciESWTSessionCount";
            this.lciESWTSessionCount.Size = new System.Drawing.Size(552, 24);
            this.lciESWTSessionCount.Text = "Seans Sayısı *";
            this.lciESWTSessionCount.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciESWTSessionDays
            // 
            this.lciESWTSessionDays.Control = this.teESWTSessionDays;
            this.lciESWTSessionDays.CustomizationFormText = "Seans Gün *";
            this.lciESWTSessionDays.Location = new System.Drawing.Point(0, 24);
            this.lciESWTSessionDays.Name = "lciESWTSessionDays";
            this.lciESWTSessionDays.Size = new System.Drawing.Size(552, 24);
            this.lciESWTSessionDays.Text = "Seans Gün *";
            this.lciESWTSessionDays.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciESWTBodyPartCode
            // 
            this.lciESWTBodyPartCode.Control = this.lueESWTBodyPartCode;
            this.lciESWTBodyPartCode.CustomizationFormText = "ESWT Vücut Bölgesi Kodu";
            this.lciESWTBodyPartCode.Location = new System.Drawing.Point(0, 0);
            this.lciESWTBodyPartCode.Name = "lciESWTBodyPartCode";
            this.lciESWTBodyPartCode.Size = new System.Drawing.Size(552, 24);
            this.lciESWTBodyPartCode.Text = "ESWT Vücut Bölgesi Kodu *";
            this.lciESWTBodyPartCode.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lcgFTRReportInfo
            // 
            this.lcgFTRReportInfo.CustomizationFormText = "FTR Rapor Bilgileri";
            this.lcgFTRReportInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciBUTCode,
            this.lciFTRSessionCount,
            this.lciFTRSessionDays,
            this.lciFTRBodyPartCode});
            this.lcgFTRReportInfo.Location = new System.Drawing.Point(0, 140);
            this.lcgFTRReportInfo.Name = "lcgFTRReportInfo";
            this.lcgFTRReportInfo.Size = new System.Drawing.Size(576, 140);
            this.lcgFTRReportInfo.Text = "FTR Rapor Bilgileri";
            // 
            // lciBUTCode
            // 
            this.lciBUTCode.Control = this.teBUTCode;
            this.lciBUTCode.CustomizationFormText = "But Kodu *";
            this.lciBUTCode.Location = new System.Drawing.Point(0, 72);
            this.lciBUTCode.Name = "lciBUTCode";
            this.lciBUTCode.Size = new System.Drawing.Size(552, 24);
            this.lciBUTCode.Text = "But Kodu *";
            this.lciBUTCode.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciFTRSessionCount
            // 
            this.lciFTRSessionCount.Control = this.teFTRSessionCount;
            this.lciFTRSessionCount.CustomizationFormText = "Seans Sayısı *";
            this.lciFTRSessionCount.Location = new System.Drawing.Point(0, 48);
            this.lciFTRSessionCount.Name = "lciFTRSessionCount";
            this.lciFTRSessionCount.Size = new System.Drawing.Size(552, 24);
            this.lciFTRSessionCount.Text = "Seans Sayısı *";
            this.lciFTRSessionCount.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciFTRSessionDays
            // 
            this.lciFTRSessionDays.Control = this.teFTRSessionDays;
            this.lciFTRSessionDays.CustomizationFormText = "Seans Gün *";
            this.lciFTRSessionDays.Location = new System.Drawing.Point(0, 24);
            this.lciFTRSessionDays.Name = "lciFTRSessionDays";
            this.lciFTRSessionDays.Size = new System.Drawing.Size(552, 24);
            this.lciFTRSessionDays.Text = "Seans Gün *";
            this.lciFTRSessionDays.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciFTRBodyPartCode
            // 
            this.lciFTRBodyPartCode.Control = this.lueFTRBodyPartCode;
            this.lciFTRBodyPartCode.CustomizationFormText = "FTR Vücut Bilgisi Kodu *";
            this.lciFTRBodyPartCode.Location = new System.Drawing.Point(0, 0);
            this.lciFTRBodyPartCode.Name = "lciFTRBodyPartCode";
            this.lciFTRBodyPartCode.Size = new System.Drawing.Size(552, 24);
            this.lciFTRBodyPartCode.Text = "FTR Vücut Bilgisi Kodu *";
            this.lciFTRBodyPartCode.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lcgESWLReportInfo
            // 
            this.lcgESWLReportInfo.CustomizationFormText = "ESWL Rapor Bilgileri";
            this.lcgESWLReportInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciESWLBUTCode,
            this.lciESWLReportStoneCount,
            this.lciESWLReportSessionCount,
            this.lciKidneyInfo,
            this.lcgESWLStoneInfo});
            this.lcgESWLReportInfo.Location = new System.Drawing.Point(0, 280);
            this.lcgESWLReportInfo.Name = "lcgESWLReportInfo";
            this.lcgESWLReportInfo.Size = new System.Drawing.Size(577, 402);
            this.lcgESWLReportInfo.Text = "ESWL Rapor Bilgileri";
            // 
            // lciESWLBUTCode
            // 
            this.lciESWLBUTCode.Control = this.teESWLBUTCode;
            this.lciESWLBUTCode.CustomizationFormText = "But Kodu";
            this.lciESWLBUTCode.Location = new System.Drawing.Point(0, 0);
            this.lciESWLBUTCode.Name = "lciESWLBUTCode";
            this.lciESWLBUTCode.Size = new System.Drawing.Size(553, 24);
            this.lciESWLBUTCode.Text = "But Kodu";
            this.lciESWLBUTCode.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciESWLReportStoneCount
            // 
            this.lciESWLReportStoneCount.Control = this.teESWLReportStoneCount;
            this.lciESWLReportStoneCount.CustomizationFormText = "ESWL Raporu Taş Sayısı";
            this.lciESWLReportStoneCount.Location = new System.Drawing.Point(0, 24);
            this.lciESWLReportStoneCount.Name = "lciESWLReportStoneCount";
            this.lciESWLReportStoneCount.Size = new System.Drawing.Size(553, 24);
            this.lciESWLReportStoneCount.Text = "ESWL Raporu Taş Sayısı";
            this.lciESWLReportStoneCount.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciESWLReportSessionCount
            // 
            this.lciESWLReportSessionCount.Control = this.teESWLReportSessionCount;
            this.lciESWLReportSessionCount.CustomizationFormText = "ESWL Raporu Seans Sayısı";
            this.lciESWLReportSessionCount.Location = new System.Drawing.Point(0, 48);
            this.lciESWLReportSessionCount.Name = "lciESWLReportSessionCount";
            this.lciESWLReportSessionCount.Size = new System.Drawing.Size(553, 24);
            this.lciESWLReportSessionCount.Text = "ESWL Raporu Seans Sayısı";
            this.lciESWLReportSessionCount.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciKidneyInfo
            // 
            this.lciKidneyInfo.Control = this.lueKidneyInfo;
            this.lciKidneyInfo.CustomizationFormText = "Böbrek Bilgisi";
            this.lciKidneyInfo.Location = new System.Drawing.Point(0, 72);
            this.lciKidneyInfo.Name = "lciKidneyInfo";
            this.lciKidneyInfo.Size = new System.Drawing.Size(553, 24);
            this.lciKidneyInfo.Text = "Böbrek Bilgisi";
            this.lciKidneyInfo.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lcgESWLStoneInfo
            // 
            this.lcgESWLStoneInfo.CustomizationFormText = "ESWL Taş Bilgisi";
            this.lcgESWLStoneInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciKidneyStoneLocalisationCode,
            this.lciStoneDimension,
            this.lciStoneDimensionComment,
            this.emptySpaceItem1,
            this.lciAddESWLStoneInfo,
            this.emptySpaceItem2,
            this.lciESWLStoneInfo});
            this.lcgESWLStoneInfo.Location = new System.Drawing.Point(0, 96);
            this.lcgESWLStoneInfo.Name = "lcgESWLStoneInfo";
            this.lcgESWLStoneInfo.Size = new System.Drawing.Size(553, 262);
            this.lcgESWLStoneInfo.Text = "ESWL Taş Bilgisi";
            // 
            // lciKidneyStoneLocalisationCode
            // 
            this.lciKidneyStoneLocalisationCode.Control = this.lueKidneyStoneLocalisationCode;
            this.lciKidneyStoneLocalisationCode.CustomizationFormText = "Taş Lokalizasyon Kodu";
            this.lciKidneyStoneLocalisationCode.Location = new System.Drawing.Point(0, 24);
            this.lciKidneyStoneLocalisationCode.Name = "lciKidneyStoneLocalisationCode";
            this.lciKidneyStoneLocalisationCode.Size = new System.Drawing.Size(263, 26);
            this.lciKidneyStoneLocalisationCode.Text = "Taş Lokalizasyon Kodu";
            this.lciKidneyStoneLocalisationCode.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciStoneDimension
            // 
            this.lciStoneDimension.Control = this.teStoneDimension;
            this.lciStoneDimension.CustomizationFormText = "Taş Boyutu";
            this.lciStoneDimension.Location = new System.Drawing.Point(0, 0);
            this.lciStoneDimension.Name = "lciStoneDimension";
            this.lciStoneDimension.Size = new System.Drawing.Size(261, 24);
            this.lciStoneDimension.Text = "Taş Boyutu";
            this.lciStoneDimension.TextSize = new System.Drawing.Size(130, 13);
            // 
            // lciStoneDimensionComment
            // 
            this.lciStoneDimensionComment.Control = this.lcStoneDimensionComment;
            this.lciStoneDimensionComment.CustomizationFormText = "Taş Boyutu Açıklaması";
            this.lciStoneDimensionComment.Location = new System.Drawing.Point(261, 0);
            this.lciStoneDimensionComment.Name = "lciStoneDimensionComment";
            this.lciStoneDimensionComment.Size = new System.Drawing.Size(126, 24);
            this.lciStoneDimensionComment.Text = "lciStoneDimensionComment";
            this.lciStoneDimensionComment.TextSize = new System.Drawing.Size(0, 0);
            this.lciStoneDimensionComment.TextToControlDistance = 0;
            this.lciStoneDimensionComment.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(387, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(142, 24);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciAddESWLStoneInfo
            // 
            this.lciAddESWLStoneInfo.Control = this.sbAddESWLStoneInfo;
            this.lciAddESWLStoneInfo.CustomizationFormText = "ESWL Taş Bilgisi Ekle";
            this.lciAddESWLStoneInfo.Location = new System.Drawing.Point(263, 24);
            this.lciAddESWLStoneInfo.Name = "lciAddESWLStoneInfo";
            this.lciAddESWLStoneInfo.Size = new System.Drawing.Size(127, 26);
            this.lciAddESWLStoneInfo.Text = "ESWL Taş Bilgisi Ekle";
            this.lciAddESWLStoneInfo.TextSize = new System.Drawing.Size(0, 0);
            this.lciAddESWLStoneInfo.TextToControlDistance = 0;
            this.lciAddESWLStoneInfo.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(390, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(139, 26);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciESWLStoneInfo
            // 
            this.lciESWLStoneInfo.Control = this.gcESWLStoneInfo;
            this.lciESWLStoneInfo.CustomizationFormText = "ESWL Taş Bilgisi Grid";
            this.lciESWLStoneInfo.Location = new System.Drawing.Point(0, 50);
            this.lciESWLStoneInfo.Name = "lciESWLStoneInfo";
            this.lciESWLStoneInfo.Size = new System.Drawing.Size(529, 168);
            this.lciESWLStoneInfo.Text = "ESWL Taş Bilgisi Grid";
            this.lciESWLStoneInfo.TextSize = new System.Drawing.Size(0, 0);
            this.lciESWLStoneInfo.TextToControlDistance = 0;
            this.lciESWLStoneInfo.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(576, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(301, 280);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(577, 280);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(300, 402);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.teESWTBUTCode;
            this.layoutControlItem9.CustomizationFormText = "But Kodu *";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(214, 574);
            this.layoutControlItem9.Text = "But Kodu *";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(119, 13);
            this.layoutControlItem9.TextToControlDistance = 5;
            // 
            // MedulaReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcMedulaReport);
            this.Name = "MedulaReportControl";
            this.Size = new System.Drawing.Size(921, 746);
            ((System.ComponentModel.ISupportInitialize)(this.lcMedulaReport)).EndInit();
            this.lcMedulaReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcICD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvICD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEffectiveSubsance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEffectiveSubsance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProtocolNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEditingType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueReportType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deReportDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deReportDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teReportNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDoctorType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDoctorLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDoctorFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDoctorBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDoctorRegistrationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInsuranceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProvisionType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRelationCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTransferorInstitution.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCardNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSocialSecurityNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTCID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcESWLStoneInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvESWLStoneInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueKidneyStoneLocalisationCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueKidneyInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teESWLReportSessionCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teESWLReportStoneCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teESWLBUTCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teStoneDimension.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBUTCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFTRSessionCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFTRSessionDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFTRBodyPartCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teESWTBUTCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teESWTSessionCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teESWTSessionDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueESWTBodyPartCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teInstitutionNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePatientName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFollowUpNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTreatmentReportType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgReportMainType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deReportStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deReportStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deReportEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deReportEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deProtocolDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deProtocolDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meClinicalDiagnosis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deProvisionDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deProvisionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMedulaReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcgMedulaReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReportDetailInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReportType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReportMainType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreatmentReportType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPatientInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFollowUpNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInstitutionNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTCID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSocialSecurityNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCardNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTransferorInstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRelationCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProvisionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProvisionDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInsuranceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDoctorInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctorBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctorRegistrationNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctorFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctorLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReportInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReportDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReportNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReportType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReportStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReportEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEditingType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProtocolNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProtocolDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgClinicalDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClinicalDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgEffectiveSubsance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEffectiveSubsance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDeleteEffectiveSubsance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddEffectiveSubsance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDiagnosisInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDiagnosisGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciICDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDeleteDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSyncDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgESWTFTRESWLReportInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgESWTReportInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWTBUTCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWTSessionCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWTSessionDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWTBodyPartCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgFTRReportInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBUTCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFTRSessionCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFTRSessionDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFTRBodyPartCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgESWLReportInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWLBUTCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWLReportStoneCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWLReportSessionCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKidneyInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgESWLStoneInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKidneyStoneLocalisationCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStoneDimension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStoneDimensionComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddESWLStoneInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciESWLStoneInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMedulaReport;
        private DevExpress.XtraGrid.GridControl gcESWLStoneInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvESWLStoneInfo;
        private DevExpress.XtraEditors.SimpleButton sbAddESWLStoneInfo;
        private DevExpress.XtraEditors.LabelControl lcStoneDimensionComment;
        private DevExpress.XtraEditors.LookUpEdit lueKidneyStoneLocalisationCode;
        private DevExpress.XtraEditors.LookUpEdit lueKidneyInfo;
        private DevExpress.XtraEditors.TextEdit teESWLReportSessionCount;
        private DevExpress.XtraEditors.TextEdit teESWLReportStoneCount;
        private DevExpress.XtraEditors.TextEdit teESWLBUTCode;
        private DevExpress.XtraEditors.TextEdit teStoneDimension;
        private DevExpress.XtraEditors.TextEdit teBUTCode;
        private DevExpress.XtraEditors.TextEdit teFTRSessionCount;
        private DevExpress.XtraEditors.TextEdit teFTRSessionDays;
        private DevExpress.XtraEditors.LookUpEdit lueFTRBodyPartCode;
        private DevExpress.XtraEditors.TextEdit teESWTBUTCode;
        private DevExpress.XtraEditors.TextEdit teESWTSessionCount;
        private DevExpress.XtraEditors.TextEdit teESWTSessionDays;
        private DevExpress.XtraEditors.LookUpEdit lueESWTBodyPartCode;
        private DevExpress.XtraEditors.TextEdit teInstitutionNo;
        private DevExpress.XtraEditors.TextEdit tePatientName;
        private DevExpress.XtraEditors.TextEdit teFollowUpNo;
        private DevExpress.XtraEditors.LookUpEdit lueTreatmentReportType;
        private DevExpress.XtraEditors.RadioGroup rgReportMainType;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMedulaReport;
        private DevExpress.XtraLayout.TabbedControlGroup tcgMedulaReport;
        private DevExpress.XtraLayout.LayoutControlGroup lcgReportDetailInfo;
        private DevExpress.XtraLayout.LayoutControlGroup lcgReportType;
        private DevExpress.XtraLayout.LayoutControlItem lciReportMainType;
        private DevExpress.XtraLayout.LayoutControlItem lciTreatmentReportType;
        private DevExpress.XtraLayout.LayoutControlGroup lcgPatientInfo;
        private DevExpress.XtraLayout.LayoutControlItem lciPatientName;
        private DevExpress.XtraLayout.LayoutControlItem lciFollowUpNo;
        private DevExpress.XtraLayout.LayoutControlItem lciInstitutionNo;
        private DevExpress.XtraLayout.LayoutControlGroup lcgESWTFTRESWLReportInfo;
        private DevExpress.XtraLayout.LayoutControlGroup lcgESWTReportInfo;
        private DevExpress.XtraLayout.LayoutControlItem lciESWTBUTCode;
        private DevExpress.XtraLayout.LayoutControlItem lciESWTSessionCount;
        private DevExpress.XtraLayout.LayoutControlItem lciESWTSessionDays;
        private DevExpress.XtraLayout.LayoutControlItem lciESWTBodyPartCode;
        private DevExpress.XtraLayout.LayoutControlGroup lcgFTRReportInfo;
        private DevExpress.XtraLayout.LayoutControlItem lciBUTCode;
        private DevExpress.XtraLayout.LayoutControlItem lciFTRSessionCount;
        private DevExpress.XtraLayout.LayoutControlItem lciFTRSessionDays;
        private DevExpress.XtraLayout.LayoutControlItem lciFTRBodyPartCode;
        private DevExpress.XtraLayout.LayoutControlGroup lcgESWLReportInfo;
        private DevExpress.XtraLayout.LayoutControlItem lciESWLBUTCode;
        private DevExpress.XtraLayout.LayoutControlItem lciESWLReportStoneCount;
        private DevExpress.XtraLayout.LayoutControlItem lciESWLReportSessionCount;
        private DevExpress.XtraLayout.LayoutControlItem lciKidneyInfo;
        private DevExpress.XtraLayout.LayoutControlGroup lcgESWLStoneInfo;
        private DevExpress.XtraLayout.LayoutControlItem lciKidneyStoneLocalisationCode;
        private DevExpress.XtraLayout.LayoutControlItem lciStoneDimension;
        private DevExpress.XtraLayout.LayoutControlItem lciStoneDimensionComment;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciAddESWLStoneInfo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem lciESWLStoneInfo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.LookUpEdit lueStatus;
        private DevExpress.XtraEditors.TextEdit teProtocolNo;
        private DevExpress.XtraEditors.LookUpEdit lueEditingType;
        private DevExpress.XtraEditors.LookUpEdit lueReportType;
        private DevExpress.XtraEditors.DateEdit deReportDate;
        private DevExpress.XtraEditors.TextEdit teReportNo;
        private DevExpress.XtraEditors.DateEdit deEndDate;
        private DevExpress.XtraEditors.DateEdit deStartDate;
        private DevExpress.XtraGrid.GridControl gcDoctors;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDoctors;
        private DevExpress.XtraEditors.LookUpEdit lueDoctorType;
        private DevExpress.XtraEditors.TextEdit teDoctorLastName;
        private DevExpress.XtraEditors.TextEdit teDoctorFirstName;
        private DevExpress.XtraEditors.LookUpEdit lueDoctorBranch;
        private DevExpress.XtraEditors.SimpleButton sbAddDoctor;
        private DevExpress.XtraEditors.LookUpEdit lueDoctorRegistrationNo;
        private DevExpress.XtraEditors.LookUpEdit lueInsuranceType;
        private DevExpress.XtraEditors.LookUpEdit lueProvisionType;
        private DevExpress.XtraEditors.TextEdit teRelationCode;
        private DevExpress.XtraEditors.LookUpEdit lueTransferorInstitution;
        private DevExpress.XtraEditors.TextEdit teCardNo;
        private DevExpress.XtraEditors.TextEdit teSocialSecurityNo;
        private DevExpress.XtraEditors.TextEdit teTCID;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.LayoutControlItem lciTCID;
        private DevExpress.XtraLayout.LayoutControlItem lciSocialSecurityNo;
        private DevExpress.XtraLayout.LayoutControlItem lciCardNo;
        private DevExpress.XtraLayout.LayoutControlItem lciTransferorInstitution;
        private DevExpress.XtraLayout.LayoutControlItem lciRelationCode;
        private DevExpress.XtraLayout.LayoutControlItem lciProvisionType;
        private DevExpress.XtraLayout.LayoutControlItem lciProvisionDate;
        private DevExpress.XtraLayout.LayoutControlItem lciInsuranceType;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDoctorInfo;
        private DevExpress.XtraLayout.LayoutControlItem lciAddDoctor;
        private DevExpress.XtraLayout.LayoutControlItem lciDoctorType;
        private DevExpress.XtraLayout.LayoutControlItem lciDoctorBranch;
        private DevExpress.XtraLayout.LayoutControlItem lciDoctorRegistrationNo;
        private DevExpress.XtraLayout.LayoutControlItem lciDoctorFirstName;
        private DevExpress.XtraLayout.LayoutControlItem lciDoctorLastName;
        private DevExpress.XtraLayout.LayoutControlItem lciDoctors;
        private DevExpress.XtraLayout.LayoutControlItem lciStartDate;
        private DevExpress.XtraLayout.LayoutControlItem lciEndDate;
        private DevExpress.XtraLayout.LayoutControlGroup lcgReportInfo;
        private DevExpress.XtraLayout.LayoutControlItem lciReportDate;
        private DevExpress.XtraLayout.LayoutControlItem lciReportNo;
        private DevExpress.XtraLayout.LayoutControlGroup lcgReport;
        private DevExpress.XtraLayout.LayoutControlItem lciReportType;
        private DevExpress.XtraLayout.LayoutControlItem lciReportStartDate;
        private DevExpress.XtraLayout.LayoutControlItem lciReportEndDate;
        private DevExpress.XtraLayout.LayoutControlItem lciEditingType;
        private DevExpress.XtraLayout.LayoutControlItem lciProtocolNo;
        private DevExpress.XtraLayout.LayoutControlItem lciProtocolDate;
        private DevExpress.XtraLayout.LayoutControlItem lciStatus;
        private DevExpress.XtraGrid.GridControl gcICD;
        private DevExpress.XtraGrid.Views.Grid.GridView gvICD;
        private DevExpress.XtraGrid.Columns.GridColumn colICD10Code;
        private DevExpress.XtraGrid.Columns.GridColumn colICD10DiagnosisName;
        private DevExpress.XtraGrid.GridControl gcDiagnosis;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDiagnosis;
        private DevExpress.XtraGrid.Columns.GridColumn colDiagnosisCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDiagnosisName;
        private DevExpress.XtraEditors.SimpleButton sbAddEffectiveSubsance;
        private DevExpress.XtraEditors.SimpleButton sbDeleteEffectiveSubsance;
        private DevExpress.XtraGrid.GridControl gcEffectiveSubsance;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEffectiveSubsance;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveSubsanceCode;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveSubsanceName;
        private DevExpress.XtraEditors.DateEdit deReportStartDate;
        private DevExpress.XtraEditors.DateEdit deReportEndDate;
        private DevExpress.XtraEditors.DateEdit deProtocolDate;
        private DevExpress.XtraEditors.MemoEdit meClinicalDiagnosis;
        private DevExpress.XtraEditors.MemoEdit meDescription;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDiagnosisInfo;
        private DevExpress.XtraLayout.LayoutControlItem lciDiagnosisGrid;
        private DevExpress.XtraLayout.LayoutControlItem lciICDGrid;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraLayout.LayoutControlGroup lcgClinicalDiagnosis;
        private DevExpress.XtraLayout.LayoutControlItem lciClinicalDiagnosis;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDescription;
        private DevExpress.XtraLayout.LayoutControlItem lciDescription;
        private DevExpress.XtraLayout.LayoutControlItem lciEffectiveSubsance;
        private DevExpress.XtraLayout.LayoutControlItem lciDeleteEffectiveSubsance;
        private DevExpress.XtraLayout.LayoutControlItem lciAddEffectiveSubsance;
        private DevExpress.XtraEditors.SimpleButton sbSyncDiagnosis;
        private DevExpress.XtraEditors.SimpleButton sbAddDiagnosis;
        private DevExpress.XtraEditors.SimpleButton sbDeleteDiagnosis;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.SimpleButton sbSave;
        private DevExpress.XtraEditors.SimpleButton sbPrint;
        private DevExpress.XtraLayout.LayoutControlItem lciDeleteDiagnosis;
        private DevExpress.XtraLayout.LayoutControlItem lciAddDiagnosis;
        private DevExpress.XtraLayout.LayoutControlItem lciSyncDiagnosis;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private DevExpress.XtraLayout.LayoutControlItem lciPrint;
        private DevExpress.XtraLayout.LayoutControlItem lciSave;
        private DevExpress.XtraLayout.LayoutControlItem lciCancel;
        private DevExpress.XtraLayout.LayoutControlGroup lcgEffectiveSubsance;
        private DevExpress.XtraEditors.DateEdit deProvisionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStoneDimension;
        private DevExpress.XtraGrid.Columns.GridColumn colStoneLocalisationCode;
    }
}
