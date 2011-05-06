namespace Naz.Hastane.Win.Controls
{
    partial class PatientVisitControl
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gvPatientVisitDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSiraNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTANIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitDetailAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSATISF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKSATISF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitDetailDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitDetailDoctor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPatientVisit = new DevExpress.XtraGrid.GridControl();
            this.gvPatientVisitRecord = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVisitRecordDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitRecordService = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitRecordDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitRecordQueueNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitRecordVisitType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitRecordUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedulaExitDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitRecordControl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitRecordExceptionalStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitRecordAddQuery = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvPatientVisit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVisitNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExitDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatientTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsuranceTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatientAppNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTakipNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIMPF2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKar_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSevkTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvisionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTakipTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTakipDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIliskiliTakipNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPatientVisitControl = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisitDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisitRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientVisitControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPatientVisitDetail
            // 
            this.gvPatientVisitDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSiraNo,
            this.colAKOD,
            this.colTANIM,
            this.colGRUP,
            this.colCODE,
            this.colNAME1,
            this.colVisitDetailAmount,
            this.colSATISF,
            this.colKSATISF,
            this.colVisitDetailDoctor,
            this.colVisitDetailDoctor2});
            this.gvPatientVisitDetail.DefaultRelationIndex = 1;
            this.gvPatientVisitDetail.GridControl = this.gcPatientVisit;
            this.gvPatientVisitDetail.Name = "gvPatientVisitDetail";
            this.gvPatientVisitDetail.OptionsBehavior.Editable = false;
            this.gvPatientVisitDetail.OptionsBehavior.ReadOnly = true;
            this.gvPatientVisitDetail.OptionsView.ColumnAutoWidth = false;
            this.gvPatientVisitDetail.OptionsView.ShowGroupPanel = false;
            this.gvPatientVisitDetail.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSiraNo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvPatientVisitDetail.Click += new System.EventHandler(this.gvPatientVisitDetail_Click);
            // 
            // colSiraNo
            // 
            this.colSiraNo.Caption = "Sıra No";
            this.colSiraNo.FieldName = "DetailNo";
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.Visible = true;
            this.colSiraNo.VisibleIndex = 0;
            // 
            // colAKOD
            // 
            this.colAKOD.Caption = "AKod";
            this.colAKOD.FieldName = "AKOD";
            this.colAKOD.Name = "colAKOD";
            this.colAKOD.Visible = true;
            this.colAKOD.VisibleIndex = 1;
            // 
            // colTANIM
            // 
            this.colTANIM.Caption = "Tanım";
            this.colTANIM.FieldName = "TANIM";
            this.colTANIM.Name = "colTANIM";
            this.colTANIM.Visible = true;
            this.colTANIM.VisibleIndex = 2;
            // 
            // colGRUP
            // 
            this.colGRUP.Caption = "Grup";
            this.colGRUP.FieldName = "GRUP";
            this.colGRUP.Name = "colGRUP";
            this.colGRUP.Visible = true;
            this.colGRUP.VisibleIndex = 3;
            // 
            // colCODE
            // 
            this.colCODE.Caption = "Code";
            this.colCODE.FieldName = "CODE";
            this.colCODE.Name = "colCODE";
            this.colCODE.Visible = true;
            this.colCODE.VisibleIndex = 4;
            // 
            // colNAME1
            // 
            this.colNAME1.Caption = "İşlem";
            this.colNAME1.FieldName = "NAME1";
            this.colNAME1.Name = "colNAME1";
            this.colNAME1.Visible = true;
            this.colNAME1.VisibleIndex = 5;
            // 
            // colVisitDetailAmount
            // 
            this.colVisitDetailAmount.Caption = "Adet";
            this.colVisitDetailAmount.FieldName = "ADET";
            this.colVisitDetailAmount.Name = "colVisitDetailAmount";
            this.colVisitDetailAmount.Visible = true;
            this.colVisitDetailAmount.VisibleIndex = 7;
            // 
            // colSATISF
            // 
            this.colSATISF.Caption = "Hasta Fiyatı";
            this.colSATISF.FieldName = "PatientPrice";
            this.colSATISF.Name = "colSATISF";
            this.colSATISF.Visible = true;
            this.colSATISF.VisibleIndex = 8;
            // 
            // colKSATISF
            // 
            this.colKSATISF.Caption = "Kurum Fiyatı";
            this.colKSATISF.FieldName = "CompanyPrice";
            this.colKSATISF.Name = "colKSATISF";
            this.colKSATISF.Visible = true;
            this.colKSATISF.VisibleIndex = 9;
            // 
            // colVisitDetailDoctor
            // 
            this.colVisitDetailDoctor.Caption = "Doktor";
            this.colVisitDetailDoctor.FieldName = "DoctorName";
            this.colVisitDetailDoctor.Name = "colVisitDetailDoctor";
            this.colVisitDetailDoctor.Visible = true;
            this.colVisitDetailDoctor.VisibleIndex = 6;
            // 
            // colVisitDetailDoctor2
            // 
            this.colVisitDetailDoctor2.Caption = "Yap.Dr.";
            this.colVisitDetailDoctor2.FieldName = "Doctor2Name";
            this.colVisitDetailDoctor2.Name = "colVisitDetailDoctor2";
            this.colVisitDetailDoctor2.Visible = true;
            this.colVisitDetailDoctor2.VisibleIndex = 10;
            // 
            // gcPatientVisit
            // 
            this.gcPatientVisit.DataMember = null;
            gridLevelNode1.LevelTemplate = this.gvPatientVisitDetail;
            gridLevelNode1.RelationName = "PatientVisitDetails";
            gridLevelNode2.LevelTemplate = this.gvPatientVisitRecord;
            gridLevelNode2.RelationName = "PatientVisitRecords";
            this.gcPatientVisit.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gcPatientVisit.Location = new System.Drawing.Point(4, 4);
            this.gcPatientVisit.MainView = this.gvPatientVisit;
            this.gcPatientVisit.Name = "gcPatientVisit";
            this.gcPatientVisit.Size = new System.Drawing.Size(749, 497);
            this.gcPatientVisit.TabIndex = 24;
            this.gcPatientVisit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatientVisitRecord,
            this.gvPatientVisit,
            this.gvPatientVisitDetail});
            // 
            // gvPatientVisitRecord
            // 
            this.gvPatientVisitRecord.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVisitRecordDate,
            this.colVisitRecordService,
            this.colVisitRecordDoctor,
            this.colVisitRecordQueueNo,
            this.colVisitRecordVisitType,
            this.colVisitRecordUserID,
            this.colMedulaExitDate,
            this.colVisitRecordControl,
            this.colVisitRecordExceptionalStatus,
            this.colVisitRecordAddQuery});
            this.gvPatientVisitRecord.GridControl = this.gcPatientVisit;
            this.gvPatientVisitRecord.Name = "gvPatientVisitRecord";
            this.gvPatientVisitRecord.OptionsBehavior.Editable = false;
            this.gvPatientVisitRecord.OptionsBehavior.ReadOnly = true;
            this.gvPatientVisitRecord.OptionsView.ColumnAutoWidth = false;
            this.gvPatientVisitRecord.OptionsView.ShowGroupPanel = false;
            // 
            // colVisitRecordDate
            // 
            this.colVisitRecordDate.Caption = "Tarih";
            this.colVisitRecordDate.FieldName = "VisitDate";
            this.colVisitRecordDate.Name = "colVisitRecordDate";
            this.colVisitRecordDate.Visible = true;
            this.colVisitRecordDate.VisibleIndex = 0;
            // 
            // colVisitRecordService
            // 
            this.colVisitRecordService.Caption = "Servis";
            this.colVisitRecordService.FieldName = "Servis";
            this.colVisitRecordService.Name = "colVisitRecordService";
            this.colVisitRecordService.Visible = true;
            this.colVisitRecordService.VisibleIndex = 1;
            // 
            // colVisitRecordDoctor
            // 
            this.colVisitRecordDoctor.Caption = "Doktor";
            this.colVisitRecordDoctor.FieldName = "DoctorName";
            this.colVisitRecordDoctor.Name = "colVisitRecordDoctor";
            this.colVisitRecordDoctor.Visible = true;
            this.colVisitRecordDoctor.VisibleIndex = 2;
            // 
            // colVisitRecordQueueNo
            // 
            this.colVisitRecordQueueNo.Caption = "Sıra No";
            this.colVisitRecordQueueNo.FieldName = "QueueNo";
            this.colVisitRecordQueueNo.Name = "colVisitRecordQueueNo";
            this.colVisitRecordQueueNo.Visible = true;
            this.colVisitRecordQueueNo.VisibleIndex = 3;
            // 
            // colVisitRecordVisitType
            // 
            this.colVisitRecordVisitType.Caption = "Tip";
            this.colVisitRecordVisitType.FieldName = "VisitType";
            this.colVisitRecordVisitType.Name = "colVisitRecordVisitType";
            this.colVisitRecordVisitType.Visible = true;
            this.colVisitRecordVisitType.VisibleIndex = 4;
            // 
            // colVisitRecordUserID
            // 
            this.colVisitRecordUserID.Caption = "Op";
            this.colVisitRecordUserID.FieldName = "USER_ID";
            this.colVisitRecordUserID.Name = "colVisitRecordUserID";
            this.colVisitRecordUserID.Visible = true;
            this.colVisitRecordUserID.VisibleIndex = 5;
            // 
            // colMedulaExitDate
            // 
            this.colMedulaExitDate.Caption = "Med.Çık.";
            this.colMedulaExitDate.FieldName = "MCIKISTARIHI";
            this.colMedulaExitDate.Name = "colMedulaExitDate";
            this.colMedulaExitDate.Visible = true;
            this.colMedulaExitDate.VisibleIndex = 6;
            // 
            // colVisitRecordControl
            // 
            this.colVisitRecordControl.Caption = "Kont.";
            this.colVisitRecordControl.FieldName = "KONT";
            this.colVisitRecordControl.Name = "colVisitRecordControl";
            this.colVisitRecordControl.Visible = true;
            this.colVisitRecordControl.VisibleIndex = 7;
            // 
            // colVisitRecordExceptionalStatus
            // 
            this.colVisitRecordExceptionalStatus.Caption = "İstisnai Durum";
            this.colVisitRecordExceptionalStatus.FieldName = "ISTISNAIDURUM";
            this.colVisitRecordExceptionalStatus.Name = "colVisitRecordExceptionalStatus";
            this.colVisitRecordExceptionalStatus.Visible = true;
            this.colVisitRecordExceptionalStatus.VisibleIndex = 8;
            // 
            // colVisitRecordAddQuery
            // 
            this.colVisitRecordAddQuery.Caption = "Ek Sorgu";
            this.colVisitRecordAddQuery.FieldName = "EKSORGU";
            this.colVisitRecordAddQuery.Name = "colVisitRecordAddQuery";
            this.colVisitRecordAddQuery.Visible = true;
            this.colVisitRecordAddQuery.VisibleIndex = 9;
            // 
            // gvPatientVisit
            // 
            this.gvPatientVisit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVisitNo,
            this.colVisitDate,
            this.colExitDate,
            this.colPatientTotal,
            this.colInsuranceTotal,
            this.colInvoiceNo,
            this.colInvoiceDate,
            this.colVisitType,
            this.colPatientAppNo,
            this.colTakipNo,
            this.colIMPF2,
            this.colKar_No,
            this.colSevkTarihi,
            this.colProvisionNo,
            this.colTakipTuru,
            this.colTakipDurumu,
            this.colIliskiliTakipNo,
            this.colDoctor});
            this.gvPatientVisit.GridControl = this.gcPatientVisit;
            this.gvPatientVisit.Name = "gvPatientVisit";
            this.gvPatientVisit.OptionsBehavior.Editable = false;
            this.gvPatientVisit.OptionsBehavior.ReadOnly = true;
            this.gvPatientVisit.OptionsView.ColumnAutoWidth = false;
            this.gvPatientVisit.OptionsView.ShowGroupPanel = false;
            this.gvPatientVisit.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colVisitNo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvPatientVisit.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gvPatientVisit_MasterRowEmpty);
            this.gvPatientVisit.MasterRowGetLevelDefaultView += new DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventHandler(this.gvPatientVisit_MasterRowGetLevelDefaultView);
            this.gvPatientVisit.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gvPatientVisit_MasterRowGetChildList);
            this.gvPatientVisit.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gvPatientVisit_MasterRowGetRelationName);
            this.gvPatientVisit.MasterRowGetRelationDisplayCaption += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gvPatientVisit_MasterRowGetRelationDisplayCaption);
            this.gvPatientVisit.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gvPatientVisit_MasterRowGetRelationCount);
            this.gvPatientVisit.Click += new System.EventHandler(this.gvPatientVisit_Click);
            this.gvPatientVisit.DoubleClick += new System.EventHandler(this.gvPatientVisit_DoubleClick);
            // 
            // colVisitNo
            // 
            this.colVisitNo.Caption = "SNR";
            this.colVisitNo.FieldName = "VisitNo";
            this.colVisitNo.Name = "colVisitNo";
            this.colVisitNo.Visible = true;
            this.colVisitNo.VisibleIndex = 0;
            // 
            // colVisitDate
            // 
            this.colVisitDate.Caption = "Giriş Tarihi";
            this.colVisitDate.FieldName = "VisitDate";
            this.colVisitDate.Name = "colVisitDate";
            this.colVisitDate.Visible = true;
            this.colVisitDate.VisibleIndex = 1;
            // 
            // colExitDate
            // 
            this.colExitDate.Caption = "Çıkış Tarihi";
            this.colExitDate.FieldName = "ExitDate";
            this.colExitDate.Name = "colExitDate";
            this.colExitDate.Visible = true;
            this.colExitDate.VisibleIndex = 2;
            // 
            // colPatientTotal
            // 
            this.colPatientTotal.Caption = "Hasta Tutarı";
            this.colPatientTotal.FieldName = "PatientTotal";
            this.colPatientTotal.Name = "colPatientTotal";
            this.colPatientTotal.Visible = true;
            this.colPatientTotal.VisibleIndex = 3;
            // 
            // colInsuranceTotal
            // 
            this.colInsuranceTotal.Caption = "Kurum Tutarı";
            this.colInsuranceTotal.FieldName = "InsuranceTotal";
            this.colInsuranceTotal.Name = "colInsuranceTotal";
            this.colInsuranceTotal.Visible = true;
            this.colInsuranceTotal.VisibleIndex = 4;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.Caption = "Fatura No";
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 6;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.Caption = "Fatura Tarihi";
            this.colInvoiceDate.FieldName = "InvoiceDate";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.Visible = true;
            this.colInvoiceDate.VisibleIndex = 7;
            // 
            // colVisitType
            // 
            this.colVisitType.Caption = "Kart Tipi";
            this.colVisitType.FieldName = "VisitType";
            this.colVisitType.Name = "colVisitType";
            this.colVisitType.Visible = true;
            this.colVisitType.VisibleIndex = 8;
            // 
            // colPatientAppNo
            // 
            this.colPatientAppNo.Caption = "Hasta Başvuru No";
            this.colPatientAppNo.FieldName = "HASTABASNO";
            this.colPatientAppNo.Name = "colPatientAppNo";
            this.colPatientAppNo.Visible = true;
            this.colPatientAppNo.VisibleIndex = 9;
            // 
            // colTakipNo
            // 
            this.colTakipNo.Caption = "Takip No";
            this.colTakipNo.FieldName = "TAKIPNO";
            this.colTakipNo.Name = "colTakipNo";
            this.colTakipNo.Visible = true;
            this.colTakipNo.VisibleIndex = 10;
            // 
            // colIMPF2
            // 
            this.colIMPF2.Caption = "K.C.";
            this.colIMPF2.FieldName = "IMPF2";
            this.colIMPF2.Name = "colIMPF2";
            this.colIMPF2.Visible = true;
            this.colIMPF2.VisibleIndex = 14;
            // 
            // colKar_No
            // 
            this.colKar_No.Caption = "Kar.No";
            this.colKar_No.FieldName = "KAR_NO";
            this.colKar_No.Name = "colKar_No";
            this.colKar_No.Visible = true;
            this.colKar_No.VisibleIndex = 17;
            // 
            // colSevkTarihi
            // 
            this.colSevkTarihi.Caption = "Sevk Tarihi";
            this.colSevkTarihi.Name = "colSevkTarihi";
            this.colSevkTarihi.Visible = true;
            this.colSevkTarihi.VisibleIndex = 12;
            // 
            // colProvisionNo
            // 
            this.colProvisionNo.Caption = "Provizyon No";
            this.colProvisionNo.FieldName = "ProvisionNo";
            this.colProvisionNo.Name = "colProvisionNo";
            this.colProvisionNo.Visible = true;
            this.colProvisionNo.VisibleIndex = 13;
            // 
            // colTakipTuru
            // 
            this.colTakipTuru.Caption = "Takip Türü";
            this.colTakipTuru.FieldName = "TAKIPTURU";
            this.colTakipTuru.Name = "colTakipTuru";
            this.colTakipTuru.Visible = true;
            this.colTakipTuru.VisibleIndex = 15;
            // 
            // colTakipDurumu
            // 
            this.colTakipDurumu.Caption = "Takip Durumu";
            this.colTakipDurumu.Name = "colTakipDurumu";
            this.colTakipDurumu.Visible = true;
            this.colTakipDurumu.VisibleIndex = 16;
            // 
            // colIliskiliTakipNo
            // 
            this.colIliskiliTakipNo.Caption = "İlişkili Takip No";
            this.colIliskiliTakipNo.FieldName = "ILISKILITAKIPNO";
            this.colIliskiliTakipNo.Name = "colIliskiliTakipNo";
            this.colIliskiliTakipNo.Visible = true;
            this.colIliskiliTakipNo.VisibleIndex = 11;
            // 
            // colDoctor
            // 
            this.colDoctor.Caption = "Doktor";
            this.colDoctor.FieldName = "DoctorName";
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.Visible = true;
            this.colDoctor.VisibleIndex = 5;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcPatientVisit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(757, 505);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPatientVisitControl});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(757, 505);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciPatientVisitControl
            // 
            this.lciPatientVisitControl.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lciPatientVisitControl.AppearanceItemCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lciPatientVisitControl.AppearanceItemCaption.Options.UseBackColor = true;
            this.lciPatientVisitControl.Control = this.gcPatientVisit;
            this.lciPatientVisitControl.CustomizationFormText = "layoutControlItem1";
            this.lciPatientVisitControl.Location = new System.Drawing.Point(0, 0);
            this.lciPatientVisitControl.Name = "lciPatientVisitControl";
            this.lciPatientVisitControl.Size = new System.Drawing.Size(753, 501);
            this.lciPatientVisitControl.Text = "Ziyaretler";
            this.lciPatientVisitControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciPatientVisitControl.TextSize = new System.Drawing.Size(0, 0);
            this.lciPatientVisitControl.TextToControlDistance = 0;
            this.lciPatientVisitControl.TextVisible = false;
            // 
            // PatientVisitControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "PatientVisitControl";
            this.Size = new System.Drawing.Size(757, 505);
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisitDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisitRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientVisitControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn colSiraNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colTANIM;
        private DevExpress.XtraGrid.Columns.GridColumn colGRUP;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME1;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitDetailAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSATISF;
        private DevExpress.XtraGrid.Columns.GridColumn colKSATISF;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitDetailDoctor;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitDetailDoctor2;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitRecordDate;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitRecordService;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitRecordDoctor;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitRecordQueueNo;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitRecordVisitType;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitRecordUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedulaExitDate;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitRecordControl;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitRecordExceptionalStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitRecordAddQuery;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitNo;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExitDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colInsuranceTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitType;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientAppNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTakipNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIMPF2;
        private DevExpress.XtraGrid.Columns.GridColumn colKar_No;
        private DevExpress.XtraGrid.Columns.GridColumn colSevkTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colProvisionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTakipTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colTakipDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colIliskiliTakipNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDoctor;
        private DevExpress.XtraLayout.LayoutControlItem lciPatientVisitControl;
        public DevExpress.XtraGrid.GridControl gcPatientVisit;
        public DevExpress.XtraGrid.Views.Grid.GridView gvPatientVisitDetail;
        public DevExpress.XtraGrid.Views.Grid.GridView gvPatientVisitRecord;
        public DevExpress.XtraGrid.Views.Grid.GridView gvPatientVisit;
    }
}
