namespace Naz.Hastane.Win.MDIChildForms
{
    partial class SGKPatientForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gvIslemler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSiraNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTANIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colARZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSATISF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKSATISF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoktor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIslemler = new DevExpress.XtraGrid.GridControl();
            this.gvZiyaret = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVisitNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExitDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatientTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsuranceTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIMPF2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisitType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKar_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTakipNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSevkTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvisionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTakipTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTakipDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatientAppNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIliskiliTakipNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatientVisitDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbMedula = new DevExpress.XtraEditors.SimpleButton();
            this.sbMernis = new DevExpress.XtraEditors.SimpleButton();
            this.medulaSorgu = new Naz.Hastane.Win.Controls.MedulaProvisionControl();
            this.sbDetayDok = new DevExpress.XtraEditors.SimpleButton();
            this.sbIslemDetay = new DevExpress.XtraEditors.SimpleButton();
            this.sbBelgeBas = new DevExpress.XtraEditors.SimpleButton();
            this.mernisSorgu = new Naz.Hastane.Win.Controls.MernisSorgu();
            this.sbKurumCarisineIsle = new DevExpress.XtraEditors.SimpleButton();
            this.sbIslemKartiSil = new DevExpress.XtraEditors.SimpleButton();
            this.sbKurumCaridenSil = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit3 = new DevExpress.XtraEditors.MemoEdit();
            this.sbKapat = new DevExpress.XtraEditors.SimpleButton();
            this.sbHastaFatura = new DevExpress.XtraEditors.SimpleButton();
            this.sbIslemler = new DevExpress.XtraEditors.SimpleButton();
            this.sbKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.sbAra = new DevExpress.XtraEditors.SimpleButton();
            this.teEmail = new DevExpress.XtraEditors.TextEdit();
            this.teJobFax = new DevExpress.XtraEditors.TextEdit();
            this.teJobPhone2 = new DevExpress.XtraEditors.TextEdit();
            this.teJobPhone1 = new DevExpress.XtraEditors.TextEdit();
            this.teJobPostCode = new DevExpress.XtraEditors.TextEdit();
            this.lueJobCity = new DevExpress.XtraEditors.LookUpEdit();
            this.meJobAddress = new DevExpress.XtraEditors.MemoEdit();
            this.sbPoliklinik = new DevExpress.XtraEditors.SimpleButton();
            this.teJobNo = new DevExpress.XtraEditors.TextEdit();
            this.teJobName = new DevExpress.XtraEditors.TextEdit();
            this.teSigortaliKartNo = new DevExpress.XtraEditors.TextEdit();
            this.lueSigortaMudurlugu = new DevExpress.XtraEditors.LookUpEdit();
            this.teSevkEdilenYer = new DevExpress.XtraEditors.TextEdit();
            this.teSSKSicilNo = new DevExpress.XtraEditors.TextEdit();
            this.teBAGNO = new DevExpress.XtraEditors.TextEdit();
            this.teProtocolNo = new DevExpress.XtraEditors.TextEdit();
            this.teEMSNo = new DevExpress.XtraEditors.TextEdit();
            this.teProfession = new DevExpress.XtraEditors.TextEdit();
            this.teOfficer = new DevExpress.XtraEditors.TextEdit();
            this.teTCID = new DevExpress.XtraEditors.TextEdit();
            this.lueNationality = new DevExpress.XtraEditors.LookUpEdit();
            this.teHomePostCode = new DevExpress.XtraEditors.TextEdit();
            this.lueHomeCity = new DevExpress.XtraEditors.LookUpEdit();
            this.teHomePhone2 = new DevExpress.XtraEditors.TextEdit();
            this.teHomePhone1 = new DevExpress.XtraEditors.TextEdit();
            this.deIDDate = new DevExpress.XtraEditors.DateEdit();
            this.teIDPlace = new DevExpress.XtraEditors.TextEdit();
            this.teIDNO = new DevExpress.XtraEditors.TextEdit();
            this.rgSex = new DevExpress.XtraEditors.RadioGroup();
            this.lueInsuranceType = new DevExpress.XtraEditors.LookUpEdit();
            this.deBirthDate = new DevExpress.XtraEditors.DateEdit();
            this.rgIDType = new DevExpress.XtraEditors.RadioGroup();
            this.teBirthPlace = new DevExpress.XtraEditors.TextEdit();
            this.rgMaritalStatus = new DevExpress.XtraEditors.RadioGroup();
            this.teMotherName = new DevExpress.XtraEditors.TextEdit();
            this.teFatherName = new DevExpress.XtraEditors.TextEdit();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.teInsuranceCompany = new DevExpress.XtraEditors.TextEdit();
            this.tePatientNo = new DevExpress.XtraEditors.TextEdit();
            this.teHomeDistrict = new DevExpress.XtraEditors.TextEdit();
            this.teHomeTown = new DevExpress.XtraEditors.TextEdit();
            this.teNufusaKayitliIl = new DevExpress.XtraEditors.TextEdit();
            this.teNufusaKayitliIlce = new DevExpress.XtraEditors.TextEdit();
            this.lueStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.teHomeAddress = new DevExpress.XtraEditors.MemoEdit();
            this.lcgHastaIslemleri = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tbcHastaBilgileri = new DevExpress.XtraLayout.TabbedControlGroup();
            this.lcgHastaBilgileri = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciBirthDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBirthPlace = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMotherName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFatherName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciInsuranceCompany = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPatientNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciIDNO = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciIDDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciIDPlace = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNationality = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciIDType = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHomeAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHomeDistrict = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHomeTown = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHomePostCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciInsuranceType = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHomePhone2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHomePhone1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHomeCity = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTCID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSex = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMaritalStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgDigerBilgiler = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgEkBilgiler = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciSigortaliKartNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNufusaKayitliIlce = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNufusaKayitliIl = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSigortaMudurlugu = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSevkEdilenYer = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSSKSicilNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBAGNO = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciProtocolNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEMSNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciProfession = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciOfficer = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgIsYeriBilgileri = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciJobName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciJobNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciJobAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciJobCity = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciJobPostCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciJobPhone1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciJobPhone2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciJobFax = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEMail = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgKurumOzelNot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciKurumOzelNot = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgSagTuslar = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciAra = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciKaydet = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciIslemler = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHastaFatura = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciKapat = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciPoliklinik = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lcgAltTuslar = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciIslemKartiSil = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciKurumCarisineIsle = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciKurumCaridenSil = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBelgeBas = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciIslemDetay = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDetayDok = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciIslemlerGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIslemler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcIslemler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvZiyaret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJobFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJobPhone2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJobPhone1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJobPostCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueJobCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meJobAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJobNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJobName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSigortaliKartNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSigortaMudurlugu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSevkEdilenYer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSSKSicilNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBAGNO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProtocolNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEMSNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProfession.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOfficer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTCID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNationality.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHomePostCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueHomeCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHomePhone2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHomePhone1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deIDDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deIDDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teIDPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teIDNO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInsuranceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIDType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBirthPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgMaritalStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMotherName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFatherName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teInsuranceCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePatientNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHomeDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHomeTown.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNufusaKayitliIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNufusaKayitliIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHomeAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgHastaIslemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcHastaBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgHastaBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBirthDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBirthPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMotherName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFatherName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInsuranceCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIDNO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIDDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIDPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNationality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIDType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHomeAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHomeDistrict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHomeTown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHomePostCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInsuranceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHomePhone2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHomePhone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHomeCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTCID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMaritalStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDigerBilgiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgEkBilgiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSigortaliKartNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNufusaKayitliIlce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNufusaKayitliIl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSigortaMudurlugu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSevkEdilenYer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSSKSicilNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBAGNO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProtocolNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEMSNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProfession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOfficer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgIsYeriBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobPostCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobPhone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobPhone2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobFax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgKurumOzelNot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKurumOzelNot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSagTuslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIslemler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHastaFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPoliklinik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAltTuslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIslemKartiSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKurumCarisineIsle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKurumCaridenSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBelgeBas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIslemDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDetayDok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIslemlerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gvIslemler
            // 
            this.gvIslemler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSiraNo,
            this.colAKOD,
            this.colTANIM,
            this.colGRUP,
            this.colCODE,
            this.colARZT,
            this.colNAME1,
            this.colSATISF,
            this.colKSATISF,
            this.colADET,
            this.colDoktor2});
            this.gvIslemler.DefaultRelationIndex = 1;
            this.gvIslemler.GridControl = this.gcIslemler;
            this.gvIslemler.Name = "gvIslemler";
            this.gvIslemler.OptionsBehavior.Editable = false;
            this.gvIslemler.OptionsBehavior.ReadOnly = true;
            this.gvIslemler.OptionsView.ShowGroupPanel = false;
            this.gvIslemler.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSiraNo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colSiraNo
            // 
            this.colSiraNo.Caption = "Sıra No";
            this.colSiraNo.FieldName = "ID.SIRANO";
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
            // colARZT
            // 
            this.colARZT.Caption = "Doktor";
            this.colARZT.FieldName = "doktor.Aciklama";
            this.colARZT.Name = "colARZT";
            this.colARZT.Visible = true;
            this.colARZT.VisibleIndex = 5;
            // 
            // colNAME1
            // 
            this.colNAME1.Caption = "İşlem";
            this.colNAME1.FieldName = "NAME1";
            this.colNAME1.Name = "colNAME1";
            this.colNAME1.Visible = true;
            this.colNAME1.VisibleIndex = 6;
            // 
            // colSATISF
            // 
            this.colSATISF.Caption = "Tutar";
            this.colSATISF.FieldName = "SATISF";
            this.colSATISF.Name = "colSATISF";
            this.colSATISF.Visible = true;
            this.colSATISF.VisibleIndex = 7;
            // 
            // colKSATISF
            // 
            this.colKSATISF.Caption = "Kurum Tutar";
            this.colKSATISF.FieldName = "KSATISF";
            this.colKSATISF.Name = "colKSATISF";
            this.colKSATISF.Visible = true;
            this.colKSATISF.VisibleIndex = 8;
            // 
            // colADET
            // 
            this.colADET.Caption = "Adet";
            this.colADET.FieldName = "ADET";
            this.colADET.Name = "colADET";
            this.colADET.Visible = true;
            this.colADET.VisibleIndex = 9;
            // 
            // colDoktor2
            // 
            this.colDoktor2.Caption = "Doktor2";
            this.colDoktor2.FieldName = "doktor2.Aciklama";
            this.colDoktor2.Name = "colDoktor2";
            this.colDoktor2.Visible = true;
            this.colDoktor2.VisibleIndex = 10;
            // 
            // gcIslemler
            // 
            this.gcIslemler.DataMember = null;
            gridLevelNode1.LevelTemplate = this.gvIslemler;
            gridLevelNode1.RelationName = "VisitDetails";
            this.gcIslemler.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcIslemler.Location = new System.Drawing.Point(12, 429);
            this.gcIslemler.MainView = this.gvZiyaret;
            this.gcIslemler.Name = "gcIslemler";
            this.gcIslemler.Size = new System.Drawing.Size(910, 199);
            this.gcIslemler.TabIndex = 23;
            this.gcIslemler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvZiyaret,
            this.gridView4,
            this.gridView1,
            this.gvIslemler});
            // 
            // gvZiyaret
            // 
            this.gvZiyaret.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVisitNo,
            this.colVisitDate,
            this.colExitDate,
            this.colPatientTotal,
            this.colInsuranceTotal,
            this.colInvoiceNo,
            this.colInvoiceDate,
            this.colIMPF2,
            this.colVisitType,
            this.colKar_No,
            this.colTakipNo,
            this.colSevkTarihi,
            this.colProvisionNo,
            this.colTakipTuru,
            this.colTakipDurumu,
            this.colPatientAppNo,
            this.colIliskiliTakipNo,
            this.colDoctor,
            this.colPatientVisitDetails});
            this.gvZiyaret.GridControl = this.gcIslemler;
            this.gvZiyaret.Name = "gvZiyaret";
            this.gvZiyaret.OptionsBehavior.Editable = false;
            this.gvZiyaret.OptionsBehavior.ReadOnly = true;
            this.gvZiyaret.OptionsView.ShowGroupPanel = false;
            this.gvZiyaret.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colVisitNo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvZiyaret.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gvZiyaret_MasterRowEmpty);
            this.gvZiyaret.MasterRowGetLevelDefaultView += new DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventHandler(this.gvZiyaret_MasterRowGetLevelDefaultView);
            this.gvZiyaret.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gvZiyaret_MasterRowGetChildList);
            this.gvZiyaret.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gvZiyaret_MasterRowGetRelationName);
            this.gvZiyaret.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gvZiyaret_MasterRowGetRelationCount);
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
            this.colInvoiceNo.VisibleIndex = 5;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.Caption = "Fatura Tarihi";
            this.colInvoiceDate.FieldName = "InvoiceDate";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.Visible = true;
            this.colInvoiceDate.VisibleIndex = 6;
            // 
            // colIMPF2
            // 
            this.colIMPF2.Caption = "K.C.";
            this.colIMPF2.FieldName = "IMPF2";
            this.colIMPF2.Name = "colIMPF2";
            this.colIMPF2.Visible = true;
            this.colIMPF2.VisibleIndex = 7;
            // 
            // colVisitType
            // 
            this.colVisitType.Caption = "Kart Tipi";
            this.colVisitType.FieldName = "VisitType";
            this.colVisitType.Name = "colVisitType";
            this.colVisitType.Visible = true;
            this.colVisitType.VisibleIndex = 8;
            // 
            // colKar_No
            // 
            this.colKar_No.Caption = "Kar.No";
            this.colKar_No.FieldName = "KAR_NO";
            this.colKar_No.Name = "colKar_No";
            this.colKar_No.Visible = true;
            this.colKar_No.VisibleIndex = 9;
            // 
            // colTakipNo
            // 
            this.colTakipNo.Caption = "Takip No";
            this.colTakipNo.FieldName = "TAKIPNO";
            this.colTakipNo.Name = "colTakipNo";
            this.colTakipNo.Visible = true;
            this.colTakipNo.VisibleIndex = 10;
            // 
            // colSevkTarihi
            // 
            this.colSevkTarihi.Caption = "Sevk Tarihi";
            this.colSevkTarihi.Name = "colSevkTarihi";
            this.colSevkTarihi.Visible = true;
            this.colSevkTarihi.VisibleIndex = 11;
            // 
            // colProvisionNo
            // 
            this.colProvisionNo.Caption = "Provizyon No";
            this.colProvisionNo.FieldName = "ProvisionNo";
            this.colProvisionNo.Name = "colProvisionNo";
            this.colProvisionNo.Visible = true;
            this.colProvisionNo.VisibleIndex = 12;
            // 
            // colTakipTuru
            // 
            this.colTakipTuru.Caption = "Takip Türü";
            this.colTakipTuru.FieldName = "TAKIPTURU";
            this.colTakipTuru.Name = "colTakipTuru";
            this.colTakipTuru.Visible = true;
            this.colTakipTuru.VisibleIndex = 13;
            // 
            // colTakipDurumu
            // 
            this.colTakipDurumu.Caption = "Takip Durumu";
            this.colTakipDurumu.Name = "colTakipDurumu";
            this.colTakipDurumu.Visible = true;
            this.colTakipDurumu.VisibleIndex = 14;
            // 
            // colPatientAppNo
            // 
            this.colPatientAppNo.Caption = "Hasta Başvuru No";
            this.colPatientAppNo.FieldName = "PatientAppNo";
            this.colPatientAppNo.Name = "colPatientAppNo";
            this.colPatientAppNo.Visible = true;
            this.colPatientAppNo.VisibleIndex = 15;
            // 
            // colIliskiliTakipNo
            // 
            this.colIliskiliTakipNo.Caption = "İlişkili Takip No";
            this.colIliskiliTakipNo.FieldName = "ILISKILITAKIPNO";
            this.colIliskiliTakipNo.Name = "colIliskiliTakipNo";
            this.colIliskiliTakipNo.Visible = true;
            this.colIliskiliTakipNo.VisibleIndex = 16;
            // 
            // colDoctor
            // 
            this.colDoctor.Caption = "Doktor";
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.Visible = true;
            this.colDoctor.VisibleIndex = 17;
            // 
            // colPatientVisitDetails
            // 
            this.colPatientVisitDetails.FieldName = "PatientVisitDetails";
            this.colPatientVisitDetails.Name = "colPatientVisitDetails";
            this.colPatientVisitDetails.Visible = true;
            this.colPatientVisitDetails.VisibleIndex = 18;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gcIslemler;
            this.gridView4.Name = "gridView4";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17});
            this.gridView1.GridControl = this.gcIslemler;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn8, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Sıra No";
            this.gridColumn8.FieldName = "ID.SIRANO";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "AKod";
            this.gridColumn9.FieldName = "AKOD";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Tanım";
            this.gridColumn10.FieldName = "TANIM";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Grup";
            this.gridColumn11.FieldName = "GRUP";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 3;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Code";
            this.gridColumn12.FieldName = "CODE";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 4;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Doktor";
            this.gridColumn13.FieldName = "ARZT";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 5;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "İşlem";
            this.gridColumn14.FieldName = "NAME1";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 6;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Tutar";
            this.gridColumn15.FieldName = "SATISF";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 7;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Kurum Tutar";
            this.gridColumn16.FieldName = "KSATISF";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 8;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Adet";
            this.gridColumn17.FieldName = "ADET";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 9;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbMedula);
            this.layoutControl1.Controls.Add(this.sbMernis);
            this.layoutControl1.Controls.Add(this.medulaSorgu);
            this.layoutControl1.Controls.Add(this.sbDetayDok);
            this.layoutControl1.Controls.Add(this.sbIslemDetay);
            this.layoutControl1.Controls.Add(this.sbBelgeBas);
            this.layoutControl1.Controls.Add(this.mernisSorgu);
            this.layoutControl1.Controls.Add(this.sbKurumCarisineIsle);
            this.layoutControl1.Controls.Add(this.sbIslemKartiSil);
            this.layoutControl1.Controls.Add(this.sbKurumCaridenSil);
            this.layoutControl1.Controls.Add(this.memoEdit3);
            this.layoutControl1.Controls.Add(this.sbKapat);
            this.layoutControl1.Controls.Add(this.sbHastaFatura);
            this.layoutControl1.Controls.Add(this.sbIslemler);
            this.layoutControl1.Controls.Add(this.sbKaydet);
            this.layoutControl1.Controls.Add(this.sbAra);
            this.layoutControl1.Controls.Add(this.teEmail);
            this.layoutControl1.Controls.Add(this.teJobFax);
            this.layoutControl1.Controls.Add(this.teJobPhone2);
            this.layoutControl1.Controls.Add(this.teJobPhone1);
            this.layoutControl1.Controls.Add(this.teJobPostCode);
            this.layoutControl1.Controls.Add(this.lueJobCity);
            this.layoutControl1.Controls.Add(this.meJobAddress);
            this.layoutControl1.Controls.Add(this.sbPoliklinik);
            this.layoutControl1.Controls.Add(this.teJobNo);
            this.layoutControl1.Controls.Add(this.teJobName);
            this.layoutControl1.Controls.Add(this.teSigortaliKartNo);
            this.layoutControl1.Controls.Add(this.lueSigortaMudurlugu);
            this.layoutControl1.Controls.Add(this.teSevkEdilenYer);
            this.layoutControl1.Controls.Add(this.teSSKSicilNo);
            this.layoutControl1.Controls.Add(this.teBAGNO);
            this.layoutControl1.Controls.Add(this.teProtocolNo);
            this.layoutControl1.Controls.Add(this.teEMSNo);
            this.layoutControl1.Controls.Add(this.teProfession);
            this.layoutControl1.Controls.Add(this.teOfficer);
            this.layoutControl1.Controls.Add(this.teTCID);
            this.layoutControl1.Controls.Add(this.lueNationality);
            this.layoutControl1.Controls.Add(this.teHomePostCode);
            this.layoutControl1.Controls.Add(this.lueHomeCity);
            this.layoutControl1.Controls.Add(this.teHomePhone2);
            this.layoutControl1.Controls.Add(this.teHomePhone1);
            this.layoutControl1.Controls.Add(this.gcIslemler);
            this.layoutControl1.Controls.Add(this.deIDDate);
            this.layoutControl1.Controls.Add(this.teIDPlace);
            this.layoutControl1.Controls.Add(this.teIDNO);
            this.layoutControl1.Controls.Add(this.rgSex);
            this.layoutControl1.Controls.Add(this.lueInsuranceType);
            this.layoutControl1.Controls.Add(this.deBirthDate);
            this.layoutControl1.Controls.Add(this.rgIDType);
            this.layoutControl1.Controls.Add(this.teBirthPlace);
            this.layoutControl1.Controls.Add(this.rgMaritalStatus);
            this.layoutControl1.Controls.Add(this.teMotherName);
            this.layoutControl1.Controls.Add(this.teFatherName);
            this.layoutControl1.Controls.Add(this.teLastName);
            this.layoutControl1.Controls.Add(this.teFirstName);
            this.layoutControl1.Controls.Add(this.teInsuranceCompany);
            this.layoutControl1.Controls.Add(this.tePatientNo);
            this.layoutControl1.Controls.Add(this.teHomeDistrict);
            this.layoutControl1.Controls.Add(this.teHomeTown);
            this.layoutControl1.Controls.Add(this.teNufusaKayitliIl);
            this.layoutControl1.Controls.Add(this.teNufusaKayitliIlce);
            this.layoutControl1.Controls.Add(this.lueStatus);
            this.layoutControl1.Controls.Add(this.teHomeAddress);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1788, -18, 429, 646);
            this.layoutControl1.Root = this.lcgHastaIslemleri;
            this.layoutControl1.Size = new System.Drawing.Size(934, 690);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbMedula
            // 
            this.sbMedula.Location = new System.Drawing.Point(836, 125);
            this.sbMedula.Name = "sbMedula";
            this.sbMedula.Size = new System.Drawing.Size(74, 22);
            this.sbMedula.StyleController = this.layoutControl1;
            this.sbMedula.TabIndex = 112;
            this.sbMedula.Text = "Medula";
            this.sbMedula.Click += new System.EventHandler(this.sbMedula_Click);
            // 
            // sbMernis
            // 
            this.sbMernis.Location = new System.Drawing.Point(836, 99);
            this.sbMernis.Name = "sbMernis";
            this.sbMernis.Size = new System.Drawing.Size(74, 22);
            this.sbMernis.StyleController = this.layoutControl1;
            this.sbMernis.TabIndex = 111;
            this.sbMernis.Text = "Mernis";
            this.sbMernis.Click += new System.EventHandler(this.sbMernis_Click);
            // 
            // medulaSorgu
            // 
            this.medulaSorgu.Location = new System.Drawing.Point(549, 80);
            this.medulaSorgu.Name = "medulaSorgu";
            this.medulaSorgu.Size = new System.Drawing.Size(259, 317);
            this.medulaSorgu.TabIndex = 110;
            this.medulaSorgu.OnMedulaHastaKabulCompleted += new Naz.Hastane.Win.Controls.MedulaProvisionControl.MedulaHastaKabulCompleted(this.medulaSorgu_OnMedulaHastaKabulCompleted);
            // 
            // sbDetayDok
            // 
            this.sbDetayDok.AutoWidthInLayoutControl = true;
            this.sbDetayDok.Location = new System.Drawing.Point(96, 644);
            this.sbDetayDok.Name = "sbDetayDok";
            this.sbDetayDok.Size = new System.Drawing.Size(61, 22);
            this.sbDetayDok.StyleController = this.layoutControl1;
            this.sbDetayDok.TabIndex = 107;
            this.sbDetayDok.Text = "Detay Dök";
            // 
            // sbIslemDetay
            // 
            this.sbIslemDetay.AutoWidthInLayoutControl = true;
            this.sbIslemDetay.Location = new System.Drawing.Point(24, 644);
            this.sbIslemDetay.Name = "sbIslemDetay";
            this.sbIslemDetay.Size = new System.Drawing.Size(68, 22);
            this.sbIslemDetay.StyleController = this.layoutControl1;
            this.sbIslemDetay.TabIndex = 106;
            this.sbIslemDetay.Text = "İşlem Detay";
            // 
            // sbBelgeBas
            // 
            this.sbBelgeBas.AutoWidthInLayoutControl = true;
            this.sbBelgeBas.Location = new System.Drawing.Point(161, 644);
            this.sbBelgeBas.Name = "sbBelgeBas";
            this.sbBelgeBas.Size = new System.Drawing.Size(80, 22);
            this.sbBelgeBas.StyleController = this.layoutControl1;
            this.sbBelgeBas.TabIndex = 104;
            this.sbBelgeBas.Text = "Belge Bas (F4)";
            // 
            // mernisSorgu
            // 
            this.mernisSorgu.Location = new System.Drawing.Point(549, 44);
            this.mernisSorgu.Name = "mernisSorgu";
            this.mernisSorgu.Size = new System.Drawing.Size(259, 32);
            this.mernisSorgu.TabIndex = 109;
            this.mernisSorgu.Visible = false;
            // 
            // sbKurumCarisineIsle
            // 
            this.sbKurumCarisineIsle.AutoWidthInLayoutControl = true;
            this.sbKurumCarisineIsle.Location = new System.Drawing.Point(323, 644);
            this.sbKurumCarisineIsle.Name = "sbKurumCarisineIsle";
            this.sbKurumCarisineIsle.Size = new System.Drawing.Size(102, 22);
            this.sbKurumCarisineIsle.StyleController = this.layoutControl1;
            this.sbKurumCarisineIsle.TabIndex = 95;
            this.sbKurumCarisineIsle.Text = "Kurum Carisine İşle";
            // 
            // sbIslemKartiSil
            // 
            this.sbIslemKartiSil.AutoWidthInLayoutControl = true;
            this.sbIslemKartiSil.Location = new System.Drawing.Point(245, 644);
            this.sbIslemKartiSil.Name = "sbIslemKartiSil";
            this.sbIslemKartiSil.Size = new System.Drawing.Size(74, 22);
            this.sbIslemKartiSil.StyleController = this.layoutControl1;
            this.sbIslemKartiSil.TabIndex = 103;
            this.sbIslemKartiSil.Text = "İşlem Kartı Sil";
            // 
            // sbKurumCaridenSil
            // 
            this.sbKurumCaridenSil.AutoWidthInLayoutControl = true;
            this.sbKurumCaridenSil.Location = new System.Drawing.Point(429, 644);
            this.sbKurumCaridenSil.Name = "sbKurumCaridenSil";
            this.sbKurumCaridenSil.Size = new System.Drawing.Size(94, 22);
            this.sbKurumCaridenSil.StyleController = this.layoutControl1;
            this.sbKurumCaridenSil.TabIndex = 98;
            this.sbKurumCaridenSil.Text = "Kurum Cariden Sil";
            // 
            // memoEdit3
            // 
            this.memoEdit3.Location = new System.Drawing.Point(24, 44);
            this.memoEdit3.Name = "memoEdit3";
            this.memoEdit3.Size = new System.Drawing.Size(784, 353);
            this.memoEdit3.StyleController = this.layoutControl1;
            this.memoEdit3.TabIndex = 79;
            // 
            // sbKapat
            // 
            this.sbKapat.Location = new System.Drawing.Point(836, 375);
            this.sbKapat.Name = "sbKapat";
            this.sbKapat.Size = new System.Drawing.Size(74, 22);
            this.sbKapat.StyleController = this.layoutControl1;
            this.sbKapat.TabIndex = 71;
            this.sbKapat.Text = "Kapat(F3)";
            // 
            // sbHastaFatura
            // 
            this.sbHastaFatura.Location = new System.Drawing.Point(836, 271);
            this.sbHastaFatura.Name = "sbHastaFatura";
            this.sbHastaFatura.Size = new System.Drawing.Size(74, 22);
            this.sbHastaFatura.StyleController = this.layoutControl1;
            this.sbHastaFatura.TabIndex = 70;
            this.sbHastaFatura.Text = "Hasta Fatura";
            // 
            // sbIslemler
            // 
            this.sbIslemler.Location = new System.Drawing.Point(836, 245);
            this.sbIslemler.Name = "sbIslemler";
            this.sbIslemler.Size = new System.Drawing.Size(74, 22);
            this.sbIslemler.StyleController = this.layoutControl1;
            this.sbIslemler.TabIndex = 68;
            this.sbIslemler.Text = "İşlemler";
            // 
            // sbKaydet
            // 
            this.sbKaydet.Location = new System.Drawing.Point(836, 179);
            this.sbKaydet.Name = "sbKaydet";
            this.sbKaydet.Size = new System.Drawing.Size(74, 22);
            this.sbKaydet.StyleController = this.layoutControl1;
            this.sbKaydet.TabIndex = 67;
            this.sbKaydet.Text = "Kaydet(F5)";
            this.sbKaydet.Click += new System.EventHandler(this.sbKaydet_Click);
            // 
            // sbAra
            // 
            this.sbAra.Location = new System.Drawing.Point(836, 43);
            this.sbAra.Name = "sbAra";
            this.sbAra.Size = new System.Drawing.Size(74, 22);
            this.sbAra.StyleController = this.layoutControl1;
            this.sbAra.TabIndex = 63;
            this.sbAra.Text = "&Ara";
            // 
            // teEmail
            // 
            this.teEmail.Location = new System.Drawing.Point(529, 365);
            this.teEmail.Name = "teEmail";
            this.teEmail.Size = new System.Drawing.Size(267, 20);
            this.teEmail.StyleController = this.layoutControl1;
            this.teEmail.TabIndex = 62;
            // 
            // teJobFax
            // 
            this.teJobFax.Location = new System.Drawing.Point(529, 341);
            this.teJobFax.Name = "teJobFax";
            this.teJobFax.Size = new System.Drawing.Size(267, 20);
            this.teJobFax.StyleController = this.layoutControl1;
            this.teJobFax.TabIndex = 61;
            // 
            // teJobPhone2
            // 
            this.teJobPhone2.Location = new System.Drawing.Point(529, 317);
            this.teJobPhone2.Name = "teJobPhone2";
            this.teJobPhone2.Size = new System.Drawing.Size(267, 20);
            this.teJobPhone2.StyleController = this.layoutControl1;
            this.teJobPhone2.TabIndex = 60;
            // 
            // teJobPhone1
            // 
            this.teJobPhone1.Location = new System.Drawing.Point(529, 293);
            this.teJobPhone1.Name = "teJobPhone1";
            this.teJobPhone1.Size = new System.Drawing.Size(267, 20);
            this.teJobPhone1.StyleController = this.layoutControl1;
            this.teJobPhone1.TabIndex = 59;
            // 
            // teJobPostCode
            // 
            this.teJobPostCode.Location = new System.Drawing.Point(529, 269);
            this.teJobPostCode.Name = "teJobPostCode";
            this.teJobPostCode.Size = new System.Drawing.Size(267, 20);
            this.teJobPostCode.StyleController = this.layoutControl1;
            this.teJobPostCode.TabIndex = 58;
            // 
            // lueJobCity
            // 
            this.lueJobCity.Location = new System.Drawing.Point(529, 245);
            this.lueJobCity.Name = "lueJobCity";
            this.lueJobCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueJobCity.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Plaka"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "İl")});
            this.lueJobCity.Properties.DisplayMember = "Value";
            this.lueJobCity.Properties.ValueMember = "Value";
            this.lueJobCity.Size = new System.Drawing.Size(267, 20);
            this.lueJobCity.StyleController = this.layoutControl1;
            this.lueJobCity.TabIndex = 57;
            // 
            // meJobAddress
            // 
            this.meJobAddress.Location = new System.Drawing.Point(529, 124);
            this.meJobAddress.Name = "meJobAddress";
            this.meJobAddress.Size = new System.Drawing.Size(267, 117);
            this.meJobAddress.StyleController = this.layoutControl1;
            this.meJobAddress.TabIndex = 54;
            // 
            // sbPoliklinik
            // 
            this.sbPoliklinik.Location = new System.Drawing.Point(836, 219);
            this.sbPoliklinik.Name = "sbPoliklinik";
            this.sbPoliklinik.Size = new System.Drawing.Size(74, 22);
            this.sbPoliklinik.StyleController = this.layoutControl1;
            this.sbPoliklinik.TabIndex = 65;
            this.sbPoliklinik.Text = "Poliklinik";
            this.sbPoliklinik.Click += new System.EventHandler(this.sbPoliklinik_Click);
            // 
            // teJobNo
            // 
            this.teJobNo.Location = new System.Drawing.Point(529, 100);
            this.teJobNo.Name = "teJobNo";
            this.teJobNo.Size = new System.Drawing.Size(267, 20);
            this.teJobNo.StyleController = this.layoutControl1;
            this.teJobNo.TabIndex = 53;
            // 
            // teJobName
            // 
            this.teJobName.Location = new System.Drawing.Point(529, 76);
            this.teJobName.Name = "teJobName";
            this.teJobName.Size = new System.Drawing.Size(267, 20);
            this.teJobName.StyleController = this.layoutControl1;
            this.teJobName.TabIndex = 52;
            // 
            // teSigortaliKartNo
            // 
            this.teSigortaliKartNo.Location = new System.Drawing.Point(127, 316);
            this.teSigortaliKartNo.Name = "teSigortaliKartNo";
            this.teSigortaliKartNo.Size = new System.Drawing.Size(283, 20);
            this.teSigortaliKartNo.StyleController = this.layoutControl1;
            this.teSigortaliKartNo.TabIndex = 51;
            // 
            // lueSigortaMudurlugu
            // 
            this.lueSigortaMudurlugu.EditValue = "";
            this.lueSigortaMudurlugu.Location = new System.Drawing.Point(127, 244);
            this.lueSigortaMudurlugu.Name = "lueSigortaMudurlugu";
            this.lueSigortaMudurlugu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSigortaMudurlugu.Size = new System.Drawing.Size(283, 20);
            this.lueSigortaMudurlugu.StyleController = this.layoutControl1;
            this.lueSigortaMudurlugu.TabIndex = 48;
            // 
            // teSevkEdilenYer
            // 
            this.teSevkEdilenYer.Location = new System.Drawing.Point(127, 220);
            this.teSevkEdilenYer.Name = "teSevkEdilenYer";
            this.teSevkEdilenYer.Size = new System.Drawing.Size(283, 20);
            this.teSevkEdilenYer.StyleController = this.layoutControl1;
            this.teSevkEdilenYer.TabIndex = 47;
            // 
            // teSSKSicilNo
            // 
            this.teSSKSicilNo.Location = new System.Drawing.Point(127, 196);
            this.teSSKSicilNo.Name = "teSSKSicilNo";
            this.teSSKSicilNo.Size = new System.Drawing.Size(283, 20);
            this.teSSKSicilNo.StyleController = this.layoutControl1;
            this.teSSKSicilNo.TabIndex = 46;
            // 
            // teBAGNO
            // 
            this.teBAGNO.Location = new System.Drawing.Point(127, 172);
            this.teBAGNO.Name = "teBAGNO";
            this.teBAGNO.Size = new System.Drawing.Size(283, 20);
            this.teBAGNO.StyleController = this.layoutControl1;
            this.teBAGNO.TabIndex = 45;
            // 
            // teProtocolNo
            // 
            this.teProtocolNo.Location = new System.Drawing.Point(127, 148);
            this.teProtocolNo.Name = "teProtocolNo";
            this.teProtocolNo.Size = new System.Drawing.Size(283, 20);
            this.teProtocolNo.StyleController = this.layoutControl1;
            this.teProtocolNo.TabIndex = 44;
            // 
            // teEMSNo
            // 
            this.teEMSNo.Location = new System.Drawing.Point(127, 124);
            this.teEMSNo.Name = "teEMSNo";
            this.teEMSNo.Size = new System.Drawing.Size(283, 20);
            this.teEMSNo.StyleController = this.layoutControl1;
            this.teEMSNo.TabIndex = 43;
            // 
            // teProfession
            // 
            this.teProfession.Location = new System.Drawing.Point(127, 100);
            this.teProfession.Name = "teProfession";
            this.teProfession.Size = new System.Drawing.Size(283, 20);
            this.teProfession.StyleController = this.layoutControl1;
            this.teProfession.TabIndex = 42;
            // 
            // teOfficer
            // 
            this.teOfficer.Location = new System.Drawing.Point(127, 76);
            this.teOfficer.Name = "teOfficer";
            this.teOfficer.Size = new System.Drawing.Size(283, 20);
            this.teOfficer.StyleController = this.layoutControl1;
            this.teOfficer.TabIndex = 41;
            // 
            // teTCID
            // 
            this.teTCID.Location = new System.Drawing.Point(115, 92);
            this.teTCID.Name = "teTCID";
            this.teTCID.Size = new System.Drawing.Size(152, 20);
            this.teTCID.StyleController = this.layoutControl1;
            this.teTCID.TabIndex = 32;
            // 
            // lueNationality
            // 
            this.lueNationality.Location = new System.Drawing.Point(362, 206);
            this.lueNationality.Name = "lueNationality";
            this.lueNationality.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNationality.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Ülke")});
            this.lueNationality.Properties.DisplayMember = "Value";
            this.lueNationality.Properties.ValueMember = "ID";
            this.lueNationality.Size = new System.Drawing.Size(183, 20);
            this.lueNationality.StyleController = this.layoutControl1;
            this.lueNationality.TabIndex = 31;
            // 
            // teHomePostCode
            // 
            this.teHomePostCode.Location = new System.Drawing.Point(362, 353);
            this.teHomePostCode.Name = "teHomePostCode";
            this.teHomePostCode.Size = new System.Drawing.Size(183, 20);
            this.teHomePostCode.StyleController = this.layoutControl1;
            this.teHomePostCode.TabIndex = 30;
            // 
            // lueHomeCity
            // 
            this.lueHomeCity.Location = new System.Drawing.Point(362, 377);
            this.lueHomeCity.Name = "lueHomeCity";
            this.lueHomeCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueHomeCity.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Plaka"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "İl")});
            this.lueHomeCity.Properties.DisplayMember = "Value";
            this.lueHomeCity.Properties.ValueMember = "Value";
            this.lueHomeCity.Size = new System.Drawing.Size(183, 20);
            this.lueHomeCity.StyleController = this.layoutControl1;
            this.lueHomeCity.TabIndex = 29;
            // 
            // teHomePhone2
            // 
            this.teHomePhone2.Location = new System.Drawing.Point(115, 353);
            this.teHomePhone2.Name = "teHomePhone2";
            this.teHomePhone2.Size = new System.Drawing.Size(152, 20);
            this.teHomePhone2.StyleController = this.layoutControl1;
            this.teHomePhone2.TabIndex = 25;
            // 
            // teHomePhone1
            // 
            this.teHomePhone1.Location = new System.Drawing.Point(115, 377);
            this.teHomePhone1.Name = "teHomePhone1";
            this.teHomePhone1.Size = new System.Drawing.Size(152, 20);
            this.teHomePhone1.StyleController = this.layoutControl1;
            this.teHomePhone1.TabIndex = 24;
            // 
            // deIDDate
            // 
            this.deIDDate.EditValue = null;
            this.deIDDate.Location = new System.Drawing.Point(362, 158);
            this.deIDDate.Name = "deIDDate";
            this.deIDDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deIDDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deIDDate.Size = new System.Drawing.Size(183, 20);
            this.deIDDate.StyleController = this.layoutControl1;
            this.deIDDate.TabIndex = 22;
            // 
            // teIDPlace
            // 
            this.teIDPlace.Location = new System.Drawing.Point(362, 182);
            this.teIDPlace.Name = "teIDPlace";
            this.teIDPlace.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teIDPlace.Size = new System.Drawing.Size(183, 20);
            this.teIDPlace.StyleController = this.layoutControl1;
            this.teIDPlace.TabIndex = 21;
            // 
            // teIDNO
            // 
            this.teIDNO.Location = new System.Drawing.Point(362, 134);
            this.teIDNO.Name = "teIDNO";
            this.teIDNO.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teIDNO.Size = new System.Drawing.Size(183, 20);
            this.teIDNO.StyleController = this.layoutControl1;
            this.teIDNO.TabIndex = 20;
            // 
            // rgSex
            // 
            this.rgSex.Location = new System.Drawing.Point(24, 180);
            this.rgSex.Name = "rgSex";
            this.rgSex.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Bay"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("2", "Bayan")});
            this.rgSex.Size = new System.Drawing.Size(120, 25);
            this.rgSex.StyleController = this.layoutControl1;
            this.rgSex.TabIndex = 18;
            // 
            // lueInsuranceType
            // 
            this.lueInsuranceType.EditValue = "";
            this.lueInsuranceType.Location = new System.Drawing.Point(115, 329);
            this.lueInsuranceType.Name = "lueInsuranceType";
            this.lueInsuranceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueInsuranceType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Kod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Değer")});
            this.lueInsuranceType.Properties.DisplayMember = "Value";
            this.lueInsuranceType.Properties.ValueMember = "ID";
            this.lueInsuranceType.Size = new System.Drawing.Size(152, 20);
            this.lueInsuranceType.StyleController = this.layoutControl1;
            this.lueInsuranceType.TabIndex = 16;
            // 
            // deBirthDate
            // 
            this.deBirthDate.EditValue = null;
            this.deBirthDate.Location = new System.Drawing.Point(115, 281);
            this.deBirthDate.Name = "deBirthDate";
            this.deBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBirthDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deBirthDate.Size = new System.Drawing.Size(152, 20);
            this.deBirthDate.StyleController = this.layoutControl1;
            this.deBirthDate.TabIndex = 14;
            // 
            // rgIDType
            // 
            this.rgIDType.Location = new System.Drawing.Point(271, 60);
            this.rgIDType.Name = "rgIDType";
            this.rgIDType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem('1', "Nüfus Cüzdanı"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem('2', "Ehliyet"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem('3', "Pasaport")});
            this.rgIDType.Size = new System.Drawing.Size(274, 70);
            this.rgIDType.StyleController = this.layoutControl1;
            this.rgIDType.TabIndex = 19;
            // 
            // teBirthPlace
            // 
            this.teBirthPlace.Location = new System.Drawing.Point(115, 257);
            this.teBirthPlace.Name = "teBirthPlace";
            this.teBirthPlace.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teBirthPlace.Size = new System.Drawing.Size(152, 20);
            this.teBirthPlace.StyleController = this.layoutControl1;
            this.teBirthPlace.TabIndex = 12;
            // 
            // rgMaritalStatus
            // 
            this.rgMaritalStatus.Location = new System.Drawing.Point(148, 180);
            this.rgMaritalStatus.Name = "rgMaritalStatus";
            this.rgMaritalStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("E", "Evli"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("B", "Bekar")});
            this.rgMaritalStatus.Size = new System.Drawing.Size(119, 25);
            this.rgMaritalStatus.StyleController = this.layoutControl1;
            this.rgMaritalStatus.TabIndex = 17;
            // 
            // teMotherName
            // 
            this.teMotherName.Location = new System.Drawing.Point(115, 233);
            this.teMotherName.Name = "teMotherName";
            this.teMotherName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teMotherName.Size = new System.Drawing.Size(152, 20);
            this.teMotherName.StyleController = this.layoutControl1;
            this.teMotherName.TabIndex = 11;
            // 
            // teFatherName
            // 
            this.teFatherName.Location = new System.Drawing.Point(115, 209);
            this.teFatherName.Name = "teFatherName";
            this.teFatherName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teFatherName.Size = new System.Drawing.Size(152, 20);
            this.teFatherName.StyleController = this.layoutControl1;
            this.teFatherName.TabIndex = 10;
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(115, 140);
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teLastName.Size = new System.Drawing.Size(152, 20);
            this.teLastName.StyleController = this.layoutControl1;
            this.teLastName.TabIndex = 9;
            // 
            // teFirstName
            // 
            this.teFirstName.Location = new System.Drawing.Point(115, 116);
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teFirstName.Size = new System.Drawing.Size(152, 20);
            this.teFirstName.StyleController = this.layoutControl1;
            this.teFirstName.TabIndex = 8;
            // 
            // teInsuranceCompany
            // 
            this.teInsuranceCompany.Enabled = false;
            this.teInsuranceCompany.Location = new System.Drawing.Point(115, 68);
            this.teInsuranceCompany.Name = "teInsuranceCompany";
            this.teInsuranceCompany.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teInsuranceCompany.Size = new System.Drawing.Size(152, 20);
            this.teInsuranceCompany.StyleController = this.layoutControl1;
            this.teInsuranceCompany.TabIndex = 7;
            // 
            // tePatientNo
            // 
            this.tePatientNo.Enabled = false;
            this.tePatientNo.Location = new System.Drawing.Point(115, 44);
            this.tePatientNo.Name = "tePatientNo";
            this.tePatientNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tePatientNo.Size = new System.Drawing.Size(152, 20);
            this.tePatientNo.StyleController = this.layoutControl1;
            this.tePatientNo.TabIndex = 4;
            // 
            // teHomeDistrict
            // 
            this.teHomeDistrict.EditValue = "";
            this.teHomeDistrict.Location = new System.Drawing.Point(362, 305);
            this.teHomeDistrict.Name = "teHomeDistrict";
            this.teHomeDistrict.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teHomeDistrict.Properties.NullText = "[EditValue is null]";
            this.teHomeDistrict.Size = new System.Drawing.Size(183, 20);
            this.teHomeDistrict.StyleController = this.layoutControl1;
            this.teHomeDistrict.TabIndex = 27;
            // 
            // teHomeTown
            // 
            this.teHomeTown.EditValue = "";
            this.teHomeTown.Location = new System.Drawing.Point(362, 329);
            this.teHomeTown.Name = "teHomeTown";
            this.teHomeTown.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teHomeTown.Properties.NullText = "[EditValue is null]";
            this.teHomeTown.Size = new System.Drawing.Size(183, 20);
            this.teHomeTown.StyleController = this.layoutControl1;
            this.teHomeTown.TabIndex = 28;
            // 
            // teNufusaKayitliIl
            // 
            this.teNufusaKayitliIl.EditValue = "";
            this.teNufusaKayitliIl.Location = new System.Drawing.Point(127, 268);
            this.teNufusaKayitliIl.Name = "teNufusaKayitliIl";
            this.teNufusaKayitliIl.Properties.NullText = "[EditValue is null]";
            this.teNufusaKayitliIl.Size = new System.Drawing.Size(283, 20);
            this.teNufusaKayitliIl.StyleController = this.layoutControl1;
            this.teNufusaKayitliIl.TabIndex = 49;
            // 
            // teNufusaKayitliIlce
            // 
            this.teNufusaKayitliIlce.EditValue = "";
            this.teNufusaKayitliIlce.Location = new System.Drawing.Point(127, 292);
            this.teNufusaKayitliIlce.Name = "teNufusaKayitliIlce";
            this.teNufusaKayitliIlce.Properties.NullText = "[EditValue is null]";
            this.teNufusaKayitliIlce.Size = new System.Drawing.Size(283, 20);
            this.teNufusaKayitliIlce.StyleController = this.layoutControl1;
            this.teNufusaKayitliIlce.TabIndex = 50;
            // 
            // lueStatus
            // 
            this.lueStatus.Location = new System.Drawing.Point(115, 305);
            this.lueStatus.Name = "lueStatus";
            this.lueStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Kod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Değer")});
            this.lueStatus.Properties.DisplayMember = "Value";
            this.lueStatus.Properties.NullText = "";
            this.lueStatus.Properties.PopupSizeable = false;
            this.lueStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueStatus.Properties.ValueMember = "ID";
            this.lueStatus.Size = new System.Drawing.Size(152, 20);
            this.lueStatus.StyleController = this.layoutControl1;
            this.lueStatus.TabIndex = 33;
            // 
            // teHomeAddress
            // 
            this.teHomeAddress.Location = new System.Drawing.Point(271, 246);
            this.teHomeAddress.Name = "teHomeAddress";
            this.teHomeAddress.Size = new System.Drawing.Size(274, 55);
            this.teHomeAddress.StyleController = this.layoutControl1;
            this.teHomeAddress.TabIndex = 26;
            // 
            // lcgHastaIslemleri
            // 
            this.lcgHastaIslemleri.CustomizationFormText = "Patient İşlemleri";
            this.lcgHastaIslemleri.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgHastaIslemleri.GroupBordersVisible = false;
            this.lcgHastaIslemleri.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tbcHastaBilgileri,
            this.lcgSagTuslar,
            this.lcgAltTuslar,
            this.lciIslemlerGrid});
            this.lcgHastaIslemleri.Location = new System.Drawing.Point(0, 0);
            this.lcgHastaIslemleri.Name = "Root";
            this.lcgHastaIslemleri.Size = new System.Drawing.Size(934, 690);
            this.lcgHastaIslemleri.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgHastaIslemleri.Text = "Patient İşlemleri";
            this.lcgHastaIslemleri.TextVisible = false;
            // 
            // tbcHastaBilgileri
            // 
            this.tbcHastaBilgileri.CustomizationFormText = "Patient Bilgileri";
            this.tbcHastaBilgileri.Location = new System.Drawing.Point(0, 0);
            this.tbcHastaBilgileri.Name = "tbcHastaBilgileri";
            this.tbcHastaBilgileri.SelectedTabPage = this.lcgHastaBilgileri;
            this.tbcHastaBilgileri.SelectedTabPageIndex = 0;
            this.tbcHastaBilgileri.Size = new System.Drawing.Size(812, 401);
            this.tbcHastaBilgileri.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgHastaBilgileri,
            this.lcgDigerBilgiler,
            this.lcgKurumOzelNot});
            this.tbcHastaBilgileri.Text = "Patient Bilgileri";
            // 
            // lcgHastaBilgileri
            // 
            this.lcgHastaBilgileri.CustomizationFormText = "Hasta Bilgileri";
            this.lcgHastaBilgileri.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciBirthDate,
            this.lciBirthPlace,
            this.lciMotherName,
            this.lciFatherName,
            this.lciLastName,
            this.lciFirstName,
            this.lciInsuranceCompany,
            this.lciPatientNo,
            this.lciIDNO,
            this.lciIDDate,
            this.lciIDPlace,
            this.lciStatus,
            this.lciNationality,
            this.lciIDType,
            this.layoutControlItem1,
            this.lciHomeAddress,
            this.lciHomeDistrict,
            this.lciHomeTown,
            this.lciHomePostCode,
            this.layoutControlItem2,
            this.lciInsuranceType,
            this.lciHomePhone2,
            this.lciHomePhone1,
            this.lciHomeCity,
            this.lciTCID,
            this.lciSex,
            this.lciMaritalStatus});
            this.lcgHastaBilgileri.Location = new System.Drawing.Point(0, 0);
            this.lcgHastaBilgileri.Name = "lcgHastaBilgileri";
            this.lcgHastaBilgileri.Size = new System.Drawing.Size(788, 357);
            this.lcgHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // lciBirthDate
            // 
            this.lciBirthDate.Control = this.deBirthDate;
            this.lciBirthDate.CustomizationFormText = "Doğum Tarihi";
            this.lciBirthDate.Location = new System.Drawing.Point(0, 237);
            this.lciBirthDate.Name = "lciBirthDate";
            this.lciBirthDate.Size = new System.Drawing.Size(247, 24);
            this.lciBirthDate.Text = "Doğum Tarihi";
            this.lciBirthDate.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciBirthPlace
            // 
            this.lciBirthPlace.Control = this.teBirthPlace;
            this.lciBirthPlace.CustomizationFormText = "Doğum Yeri";
            this.lciBirthPlace.Location = new System.Drawing.Point(0, 213);
            this.lciBirthPlace.Name = "lciBirthPlace";
            this.lciBirthPlace.Size = new System.Drawing.Size(247, 24);
            this.lciBirthPlace.Text = "Doğum Yeri";
            this.lciBirthPlace.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciMotherName
            // 
            this.lciMotherName.Control = this.teMotherName;
            this.lciMotherName.CustomizationFormText = "Ana Adı";
            this.lciMotherName.Location = new System.Drawing.Point(0, 189);
            this.lciMotherName.Name = "lciMotherName";
            this.lciMotherName.Size = new System.Drawing.Size(247, 24);
            this.lciMotherName.Text = "Ana Adı";
            this.lciMotherName.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciFatherName
            // 
            this.lciFatherName.Control = this.teFatherName;
            this.lciFatherName.CustomizationFormText = "Baba Adı";
            this.lciFatherName.Location = new System.Drawing.Point(0, 165);
            this.lciFatherName.Name = "lciFatherName";
            this.lciFatherName.Size = new System.Drawing.Size(247, 24);
            this.lciFatherName.Text = "Baba Adı";
            this.lciFatherName.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciLastName
            // 
            this.lciLastName.Control = this.teLastName;
            this.lciLastName.CustomizationFormText = "Soyadı";
            this.lciLastName.Location = new System.Drawing.Point(0, 96);
            this.lciLastName.Name = "lciLastName";
            this.lciLastName.Size = new System.Drawing.Size(247, 24);
            this.lciLastName.Text = "Soyadı";
            this.lciLastName.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciFirstName
            // 
            this.lciFirstName.Control = this.teFirstName;
            this.lciFirstName.CustomizationFormText = "Adı";
            this.lciFirstName.Location = new System.Drawing.Point(0, 72);
            this.lciFirstName.Name = "lciFirstName";
            this.lciFirstName.Size = new System.Drawing.Size(247, 24);
            this.lciFirstName.Text = "Adı";
            this.lciFirstName.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciInsuranceCompany
            // 
            this.lciInsuranceCompany.Control = this.teInsuranceCompany;
            this.lciInsuranceCompany.CustomizationFormText = "Kurum Kodu";
            this.lciInsuranceCompany.Location = new System.Drawing.Point(0, 24);
            this.lciInsuranceCompany.Name = "lciInsuranceCompany";
            this.lciInsuranceCompany.Size = new System.Drawing.Size(247, 24);
            this.lciInsuranceCompany.Text = "Kurum";
            this.lciInsuranceCompany.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciPatientNo
            // 
            this.lciPatientNo.Control = this.tePatientNo;
            this.lciPatientNo.CustomizationFormText = "Hasta No";
            this.lciPatientNo.Location = new System.Drawing.Point(0, 0);
            this.lciPatientNo.Name = "lciPatientNo";
            this.lciPatientNo.Size = new System.Drawing.Size(247, 24);
            this.lciPatientNo.Text = "Hasta No";
            this.lciPatientNo.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciIDNO
            // 
            this.lciIDNO.Control = this.teIDNO;
            this.lciIDNO.CustomizationFormText = "Nosu";
            this.lciIDNO.Location = new System.Drawing.Point(247, 90);
            this.lciIDNO.Name = "lciIDNO";
            this.lciIDNO.Size = new System.Drawing.Size(278, 24);
            this.lciIDNO.Text = "Nosu";
            this.lciIDNO.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciIDDate
            // 
            this.lciIDDate.Control = this.deIDDate;
            this.lciIDDate.CustomizationFormText = "Tarihi";
            this.lciIDDate.Location = new System.Drawing.Point(247, 114);
            this.lciIDDate.Name = "lciIDDate";
            this.lciIDDate.Size = new System.Drawing.Size(278, 24);
            this.lciIDDate.Text = "Tarihi";
            this.lciIDDate.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciIDPlace
            // 
            this.lciIDPlace.Control = this.teIDPlace;
            this.lciIDPlace.CustomizationFormText = "Verildiği Yer";
            this.lciIDPlace.Location = new System.Drawing.Point(247, 138);
            this.lciIDPlace.Name = "lciIDPlace";
            this.lciIDPlace.Size = new System.Drawing.Size(278, 24);
            this.lciIDPlace.Text = "Verildiği Yer";
            this.lciIDPlace.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciStatus
            // 
            this.lciStatus.Control = this.lueStatus;
            this.lciStatus.CustomizationFormText = "Yakınlık Kodu";
            this.lciStatus.Location = new System.Drawing.Point(0, 261);
            this.lciStatus.Name = "lciStatus";
            this.lciStatus.Size = new System.Drawing.Size(247, 24);
            this.lciStatus.Text = "Durumu";
            this.lciStatus.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciNationality
            // 
            this.lciNationality.Control = this.lueNationality;
            this.lciNationality.CustomizationFormText = "Uyruğu";
            this.lciNationality.Location = new System.Drawing.Point(247, 162);
            this.lciNationality.Name = "lciNationality";
            this.lciNationality.Size = new System.Drawing.Size(278, 24);
            this.lciNationality.Text = "Uyruğu";
            this.lciNationality.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciIDType
            // 
            this.lciIDType.Control = this.rgIDType;
            this.lciIDType.CustomizationFormText = "Hüviyet";
            this.lciIDType.Location = new System.Drawing.Point(247, 0);
            this.lciIDType.MinSize = new System.Drawing.Size(126, 45);
            this.lciIDType.Name = "lciIDType";
            this.lciIDType.Size = new System.Drawing.Size(278, 90);
            this.lciIDType.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciIDType.Text = "Hüviyet";
            this.lciIDType.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciIDType.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.medulaSorgu;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(525, 36);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(263, 321);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // lciHomeAddress
            // 
            this.lciHomeAddress.Control = this.teHomeAddress;
            this.lciHomeAddress.CustomizationFormText = "Ev Adresi";
            this.lciHomeAddress.Location = new System.Drawing.Point(247, 186);
            this.lciHomeAddress.Name = "lciHomeAddress";
            this.lciHomeAddress.Size = new System.Drawing.Size(278, 75);
            this.lciHomeAddress.Text = "Ev Adresi";
            this.lciHomeAddress.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciHomeAddress.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciHomeDistrict
            // 
            this.lciHomeDistrict.Control = this.teHomeDistrict;
            this.lciHomeDistrict.CustomizationFormText = "Mahalle";
            this.lciHomeDistrict.Location = new System.Drawing.Point(247, 261);
            this.lciHomeDistrict.Name = "lciHomeDistrict";
            this.lciHomeDistrict.Size = new System.Drawing.Size(278, 24);
            this.lciHomeDistrict.Text = "Mahalle";
            this.lciHomeDistrict.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciHomeTown
            // 
            this.lciHomeTown.Control = this.teHomeTown;
            this.lciHomeTown.CustomizationFormText = "İlçe";
            this.lciHomeTown.Location = new System.Drawing.Point(247, 285);
            this.lciHomeTown.Name = "lciHomeTown";
            this.lciHomeTown.Size = new System.Drawing.Size(278, 24);
            this.lciHomeTown.Text = "İlçe";
            this.lciHomeTown.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciHomePostCode
            // 
            this.lciHomePostCode.Control = this.teHomePostCode;
            this.lciHomePostCode.CustomizationFormText = "Posta Kodu";
            this.lciHomePostCode.Location = new System.Drawing.Point(247, 309);
            this.lciHomePostCode.Name = "lciHomePostCode";
            this.lciHomePostCode.Size = new System.Drawing.Size(278, 24);
            this.lciHomePostCode.Text = "Posta Kodu";
            this.lciHomePostCode.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.mernisSorgu;
            this.layoutControlItem2.CustomizationFormText = "Mernis Sorgusu";
            this.layoutControlItem2.Location = new System.Drawing.Point(525, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(263, 36);
            this.layoutControlItem2.Text = "Mernis Sorgusu";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            this.layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciInsuranceType
            // 
            this.lciInsuranceType.Control = this.lueInsuranceType;
            this.lciInsuranceType.CustomizationFormText = "Sigorta Türü";
            this.lciInsuranceType.Location = new System.Drawing.Point(0, 285);
            this.lciInsuranceType.Name = "lciInsuranceType";
            this.lciInsuranceType.Size = new System.Drawing.Size(247, 24);
            this.lciInsuranceType.Text = "Sigorta Türü";
            this.lciInsuranceType.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciHomePhone2
            // 
            this.lciHomePhone2.Control = this.teHomePhone2;
            this.lciHomePhone2.CustomizationFormText = "Cep Telefonu";
            this.lciHomePhone2.Location = new System.Drawing.Point(0, 309);
            this.lciHomePhone2.Name = "lciHomePhone2";
            this.lciHomePhone2.Size = new System.Drawing.Size(247, 24);
            this.lciHomePhone2.Text = "Cep Telefonu";
            this.lciHomePhone2.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciHomePhone1
            // 
            this.lciHomePhone1.Control = this.teHomePhone1;
            this.lciHomePhone1.CustomizationFormText = "Ev Tlf";
            this.lciHomePhone1.Location = new System.Drawing.Point(0, 333);
            this.lciHomePhone1.Name = "lciHomePhone1";
            this.lciHomePhone1.Size = new System.Drawing.Size(247, 24);
            this.lciHomePhone1.Text = "Ev Tlf";
            this.lciHomePhone1.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciHomeCity
            // 
            this.lciHomeCity.Control = this.lueHomeCity;
            this.lciHomeCity.CustomizationFormText = "İl";
            this.lciHomeCity.Location = new System.Drawing.Point(247, 333);
            this.lciHomeCity.Name = "lciHomeCity";
            this.lciHomeCity.Size = new System.Drawing.Size(278, 24);
            this.lciHomeCity.Text = "İl";
            this.lciHomeCity.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciTCID
            // 
            this.lciTCID.Control = this.teTCID;
            this.lciTCID.CustomizationFormText = "T.C. Kimlik No";
            this.lciTCID.Location = new System.Drawing.Point(0, 48);
            this.lciTCID.Name = "lciTCID";
            this.lciTCID.Size = new System.Drawing.Size(247, 24);
            this.lciTCID.Text = "T.C. Kimlik No";
            this.lciTCID.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciSex
            // 
            this.lciSex.Control = this.rgSex;
            this.lciSex.CustomizationFormText = "Cinsiyet";
            this.lciSex.Location = new System.Drawing.Point(0, 120);
            this.lciSex.Name = "lciSex";
            this.lciSex.Size = new System.Drawing.Size(124, 45);
            this.lciSex.Text = "Cinsiyet";
            this.lciSex.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciSex.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciMaritalStatus
            // 
            this.lciMaritalStatus.Control = this.rgMaritalStatus;
            this.lciMaritalStatus.CustomizationFormText = "Medeni Hali";
            this.lciMaritalStatus.Location = new System.Drawing.Point(124, 120);
            this.lciMaritalStatus.Name = "lciMaritalStatus";
            this.lciMaritalStatus.Size = new System.Drawing.Size(123, 45);
            this.lciMaritalStatus.Text = "Medeni Hali";
            this.lciMaritalStatus.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciMaritalStatus.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lcgDigerBilgiler
            // 
            this.lcgDigerBilgiler.CustomizationFormText = "Diğer Bilgileri";
            this.lcgDigerBilgiler.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgEkBilgiler,
            this.lcgIsYeriBilgileri});
            this.lcgDigerBilgiler.Location = new System.Drawing.Point(0, 0);
            this.lcgDigerBilgiler.Name = "lcgDigerBilgiler";
            this.lcgDigerBilgiler.Size = new System.Drawing.Size(788, 357);
            this.lcgDigerBilgiler.Text = "Diğer Bilgileri";
            // 
            // lcgEkBilgiler
            // 
            this.lcgEkBilgiler.CustomizationFormText = "Ek Bilgiler";
            this.lcgEkBilgiler.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSigortaliKartNo,
            this.lciNufusaKayitliIlce,
            this.lciNufusaKayitliIl,
            this.lciSigortaMudurlugu,
            this.lciSevkEdilenYer,
            this.lciSSKSicilNo,
            this.lciBAGNO,
            this.lciProtocolNo,
            this.lciEMSNo,
            this.lciProfession,
            this.lciOfficer});
            this.lcgEkBilgiler.Location = new System.Drawing.Point(0, 0);
            this.lcgEkBilgiler.Name = "lcgEkBilgiler";
            this.lcgEkBilgiler.Size = new System.Drawing.Size(402, 357);
            this.lcgEkBilgiler.Text = "Ek Bilgiler";
            // 
            // lciSigortaliKartNo
            // 
            this.lciSigortaliKartNo.Control = this.teSigortaliKartNo;
            this.lciSigortaliKartNo.CustomizationFormText = "Sigortalı Kart No";
            this.lciSigortaliKartNo.Location = new System.Drawing.Point(0, 240);
            this.lciSigortaliKartNo.Name = "lciSigortaliKartNo";
            this.lciSigortaliKartNo.Size = new System.Drawing.Size(378, 73);
            this.lciSigortaliKartNo.Text = "Sigortalı Kart No";
            this.lciSigortaliKartNo.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciNufusaKayitliIlce
            // 
            this.lciNufusaKayitliIlce.Control = this.teNufusaKayitliIlce;
            this.lciNufusaKayitliIlce.CustomizationFormText = "Nüfusa Kayıtlı Olduğu İlçe";
            this.lciNufusaKayitliIlce.Location = new System.Drawing.Point(0, 216);
            this.lciNufusaKayitliIlce.Name = "lciNufusaKayitliIlce";
            this.lciNufusaKayitliIlce.Size = new System.Drawing.Size(378, 24);
            this.lciNufusaKayitliIlce.Text = "Nüfus İlçe";
            this.lciNufusaKayitliIlce.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciNufusaKayitliIl
            // 
            this.lciNufusaKayitliIl.Control = this.teNufusaKayitliIl;
            this.lciNufusaKayitliIl.CustomizationFormText = "Nüfusa Kayıtlı Olduğu İl";
            this.lciNufusaKayitliIl.Location = new System.Drawing.Point(0, 192);
            this.lciNufusaKayitliIl.Name = "lciNufusaKayitliIl";
            this.lciNufusaKayitliIl.Size = new System.Drawing.Size(378, 24);
            this.lciNufusaKayitliIl.Text = "Nüfus İl";
            this.lciNufusaKayitliIl.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciSigortaMudurlugu
            // 
            this.lciSigortaMudurlugu.Control = this.lueSigortaMudurlugu;
            this.lciSigortaMudurlugu.CustomizationFormText = "Sigorta Müdürlüğü";
            this.lciSigortaMudurlugu.Location = new System.Drawing.Point(0, 168);
            this.lciSigortaMudurlugu.Name = "lciSigortaMudurlugu";
            this.lciSigortaMudurlugu.Size = new System.Drawing.Size(378, 24);
            this.lciSigortaMudurlugu.Text = "Sigorta Müdürlüğü";
            this.lciSigortaMudurlugu.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciSevkEdilenYer
            // 
            this.lciSevkEdilenYer.Control = this.teSevkEdilenYer;
            this.lciSevkEdilenYer.CustomizationFormText = "Sevk Edilen Yer";
            this.lciSevkEdilenYer.Location = new System.Drawing.Point(0, 144);
            this.lciSevkEdilenYer.Name = "lciSevkEdilenYer";
            this.lciSevkEdilenYer.Size = new System.Drawing.Size(378, 24);
            this.lciSevkEdilenYer.Text = "Sevk Edilen Yer";
            this.lciSevkEdilenYer.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciSSKSicilNo
            // 
            this.lciSSKSicilNo.Control = this.teSSKSicilNo;
            this.lciSSKSicilNo.CustomizationFormText = "SSK Sicil No";
            this.lciSSKSicilNo.Location = new System.Drawing.Point(0, 120);
            this.lciSSKSicilNo.Name = "lciSSKSicilNo";
            this.lciSSKSicilNo.Size = new System.Drawing.Size(378, 24);
            this.lciSSKSicilNo.Text = "SSK Sicil No";
            this.lciSSKSicilNo.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciBAGNO
            // 
            this.lciBAGNO.Control = this.teBAGNO;
            this.lciBAGNO.CustomizationFormText = "Bağkur No";
            this.lciBAGNO.Location = new System.Drawing.Point(0, 96);
            this.lciBAGNO.Name = "lciBAGNO";
            this.lciBAGNO.Size = new System.Drawing.Size(378, 24);
            this.lciBAGNO.Text = "Bağkur No";
            this.lciBAGNO.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciProtocolNo
            // 
            this.lciProtocolNo.Control = this.teProtocolNo;
            this.lciProtocolNo.CustomizationFormText = "Protokol No";
            this.lciProtocolNo.Location = new System.Drawing.Point(0, 72);
            this.lciProtocolNo.Name = "lciProtocolNo";
            this.lciProtocolNo.Size = new System.Drawing.Size(378, 24);
            this.lciProtocolNo.Text = "Protokol No";
            this.lciProtocolNo.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciEMSNo
            // 
            this.lciEMSNo.Control = this.teEMSNo;
            this.lciEMSNo.CustomizationFormText = "Memur T.C. No";
            this.lciEMSNo.Location = new System.Drawing.Point(0, 48);
            this.lciEMSNo.Name = "lciEMSNo";
            this.lciEMSNo.Size = new System.Drawing.Size(378, 24);
            this.lciEMSNo.Text = "Memur T.C. No";
            this.lciEMSNo.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciProfession
            // 
            this.lciProfession.Control = this.teProfession;
            this.lciProfession.CustomizationFormText = "Meslek";
            this.lciProfession.Location = new System.Drawing.Point(0, 24);
            this.lciProfession.Name = "lciProfession";
            this.lciProfession.Size = new System.Drawing.Size(378, 24);
            this.lciProfession.Text = "Meslek";
            this.lciProfession.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciOfficer
            // 
            this.lciOfficer.Control = this.teOfficer;
            this.lciOfficer.CustomizationFormText = "Memur";
            this.lciOfficer.Location = new System.Drawing.Point(0, 0);
            this.lciOfficer.Name = "lciOfficer";
            this.lciOfficer.Size = new System.Drawing.Size(378, 24);
            this.lciOfficer.Text = "Memur";
            this.lciOfficer.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lcgIsYeriBilgileri
            // 
            this.lcgIsYeriBilgileri.CustomizationFormText = "İş Yeri Bilgileri";
            this.lcgIsYeriBilgileri.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciJobName,
            this.lciJobNo,
            this.lciJobAddress,
            this.lciJobCity,
            this.lciJobPostCode,
            this.lciJobPhone1,
            this.lciJobPhone2,
            this.lciJobFax,
            this.lciEMail});
            this.lcgIsYeriBilgileri.Location = new System.Drawing.Point(402, 0);
            this.lcgIsYeriBilgileri.Name = "lcgIsYeriBilgileri";
            this.lcgIsYeriBilgileri.Size = new System.Drawing.Size(386, 357);
            this.lcgIsYeriBilgileri.Text = "İş Yeri Bilgileri";
            // 
            // lciJobName
            // 
            this.lciJobName.Control = this.teJobName;
            this.lciJobName.CustomizationFormText = "İş Yeri Adı";
            this.lciJobName.Location = new System.Drawing.Point(0, 0);
            this.lciJobName.Name = "lciJobName";
            this.lciJobName.Size = new System.Drawing.Size(362, 24);
            this.lciJobName.Text = "İş Yeri Adı";
            this.lciJobName.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciJobNo
            // 
            this.lciJobNo.Control = this.teJobNo;
            this.lciJobNo.CustomizationFormText = "İş Yeri No";
            this.lciJobNo.Location = new System.Drawing.Point(0, 24);
            this.lciJobNo.Name = "lciJobNo";
            this.lciJobNo.Size = new System.Drawing.Size(362, 24);
            this.lciJobNo.Text = "İş Yeri No";
            this.lciJobNo.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciJobAddress
            // 
            this.lciJobAddress.Control = this.meJobAddress;
            this.lciJobAddress.CustomizationFormText = "İş Adresi";
            this.lciJobAddress.Location = new System.Drawing.Point(0, 48);
            this.lciJobAddress.Name = "lciJobAddress";
            this.lciJobAddress.Size = new System.Drawing.Size(362, 121);
            this.lciJobAddress.Text = "İş Adresi";
            this.lciJobAddress.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciJobCity
            // 
            this.lciJobCity.Control = this.lueJobCity;
            this.lciJobCity.CustomizationFormText = "İl";
            this.lciJobCity.Location = new System.Drawing.Point(0, 169);
            this.lciJobCity.Name = "lciJobCity";
            this.lciJobCity.Size = new System.Drawing.Size(362, 24);
            this.lciJobCity.Text = "İl";
            this.lciJobCity.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciJobPostCode
            // 
            this.lciJobPostCode.Control = this.teJobPostCode;
            this.lciJobPostCode.CustomizationFormText = "Posta Kodu";
            this.lciJobPostCode.Location = new System.Drawing.Point(0, 193);
            this.lciJobPostCode.Name = "lciJobPostCode";
            this.lciJobPostCode.Size = new System.Drawing.Size(362, 24);
            this.lciJobPostCode.Text = "Posta Kodu";
            this.lciJobPostCode.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciJobPhone1
            // 
            this.lciJobPhone1.Control = this.teJobPhone1;
            this.lciJobPhone1.CustomizationFormText = "Telefon 1";
            this.lciJobPhone1.Location = new System.Drawing.Point(0, 217);
            this.lciJobPhone1.Name = "lciJobPhone1";
            this.lciJobPhone1.Size = new System.Drawing.Size(362, 24);
            this.lciJobPhone1.Text = "Telefon 1";
            this.lciJobPhone1.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciJobPhone2
            // 
            this.lciJobPhone2.Control = this.teJobPhone2;
            this.lciJobPhone2.CustomizationFormText = "Telefon 2";
            this.lciJobPhone2.Location = new System.Drawing.Point(0, 241);
            this.lciJobPhone2.Name = "lciJobPhone2";
            this.lciJobPhone2.Size = new System.Drawing.Size(362, 24);
            this.lciJobPhone2.Text = "Telefon 2";
            this.lciJobPhone2.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciJobFax
            // 
            this.lciJobFax.Control = this.teJobFax;
            this.lciJobFax.CustomizationFormText = "Fax No";
            this.lciJobFax.Location = new System.Drawing.Point(0, 265);
            this.lciJobFax.Name = "lciJobFax";
            this.lciJobFax.Size = new System.Drawing.Size(362, 24);
            this.lciJobFax.Text = "Fax No";
            this.lciJobFax.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciEMail
            // 
            this.lciEMail.Control = this.teEmail;
            this.lciEMail.CustomizationFormText = "Email";
            this.lciEMail.Location = new System.Drawing.Point(0, 289);
            this.lciEMail.Name = "lciEMail";
            this.lciEMail.Size = new System.Drawing.Size(362, 24);
            this.lciEMail.Text = "Email";
            this.lciEMail.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lcgKurumOzelNot
            // 
            this.lcgKurumOzelNot.CustomizationFormText = "Kurum Özel Not";
            this.lcgKurumOzelNot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciKurumOzelNot});
            this.lcgKurumOzelNot.Location = new System.Drawing.Point(0, 0);
            this.lcgKurumOzelNot.Name = "lcgKurumOzelNot";
            this.lcgKurumOzelNot.Size = new System.Drawing.Size(788, 357);
            this.lcgKurumOzelNot.Text = "Kurum Özel Not";
            // 
            // lciKurumOzelNot
            // 
            this.lciKurumOzelNot.Control = this.memoEdit3;
            this.lciKurumOzelNot.CustomizationFormText = "layoutControlItem75";
            this.lciKurumOzelNot.Location = new System.Drawing.Point(0, 0);
            this.lciKurumOzelNot.Name = "lciKurumOzelNot";
            this.lciKurumOzelNot.Size = new System.Drawing.Size(788, 357);
            this.lciKurumOzelNot.Text = "lciKurumOzelNot";
            this.lciKurumOzelNot.TextSize = new System.Drawing.Size(0, 0);
            this.lciKurumOzelNot.TextToControlDistance = 0;
            this.lciKurumOzelNot.TextVisible = false;
            // 
            // lcgSagTuslar
            // 
            this.lcgSagTuslar.CustomizationFormText = "layoutControlGroup7";
            this.lcgSagTuslar.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciAra,
            this.emptySpaceItem1,
            this.lciKaydet,
            this.lciIslemler,
            this.lciHastaFatura,
            this.lciKapat,
            this.emptySpaceItem8,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.lciPoliklinik,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem2});
            this.lcgSagTuslar.Location = new System.Drawing.Point(812, 0);
            this.lcgSagTuslar.Name = "lcgSagTuslar";
            this.lcgSagTuslar.Size = new System.Drawing.Size(102, 401);
            this.lcgSagTuslar.Text = "lcgSagTuslar";
            this.lcgSagTuslar.TextVisible = false;
            // 
            // lciAra
            // 
            this.lciAra.Control = this.sbAra;
            this.lciAra.CustomizationFormText = "Ara";
            this.lciAra.Location = new System.Drawing.Point(0, 19);
            this.lciAra.Name = "lciAra";
            this.lciAra.Size = new System.Drawing.Size(78, 26);
            this.lciAra.Text = "Ara";
            this.lciAra.TextSize = new System.Drawing.Size(0, 0);
            this.lciAra.TextToControlDistance = 0;
            this.lciAra.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 45);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(78, 30);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciKaydet
            // 
            this.lciKaydet.Control = this.sbKaydet;
            this.lciKaydet.CustomizationFormText = "Kaydet";
            this.lciKaydet.Location = new System.Drawing.Point(0, 155);
            this.lciKaydet.Name = "lciKaydet";
            this.lciKaydet.Size = new System.Drawing.Size(78, 26);
            this.lciKaydet.Text = "Kaydet";
            this.lciKaydet.TextSize = new System.Drawing.Size(0, 0);
            this.lciKaydet.TextToControlDistance = 0;
            this.lciKaydet.TextVisible = false;
            // 
            // lciIslemler
            // 
            this.lciIslemler.Control = this.sbIslemler;
            this.lciIslemler.CustomizationFormText = "İşlemler";
            this.lciIslemler.Location = new System.Drawing.Point(0, 221);
            this.lciIslemler.Name = "lciIslemler";
            this.lciIslemler.Size = new System.Drawing.Size(78, 26);
            this.lciIslemler.Text = "İşlemler";
            this.lciIslemler.TextSize = new System.Drawing.Size(0, 0);
            this.lciIslemler.TextToControlDistance = 0;
            this.lciIslemler.TextVisible = false;
            // 
            // lciHastaFatura
            // 
            this.lciHastaFatura.Control = this.sbHastaFatura;
            this.lciHastaFatura.CustomizationFormText = "Patient Fatura";
            this.lciHastaFatura.Location = new System.Drawing.Point(0, 247);
            this.lciHastaFatura.Name = "lciHastaFatura";
            this.lciHastaFatura.Size = new System.Drawing.Size(78, 26);
            this.lciHastaFatura.Text = "Patient Fatura";
            this.lciHastaFatura.TextSize = new System.Drawing.Size(0, 0);
            this.lciHastaFatura.TextToControlDistance = 0;
            this.lciHastaFatura.TextVisible = false;
            // 
            // lciKapat
            // 
            this.lciKapat.Control = this.sbKapat;
            this.lciKapat.CustomizationFormText = "Kapat";
            this.lciKapat.Location = new System.Drawing.Point(0, 351);
            this.lciKapat.Name = "lciKapat";
            this.lciKapat.Size = new System.Drawing.Size(78, 26);
            this.lciKapat.Text = "Kapat";
            this.lciKapat.TextSize = new System.Drawing.Size(0, 0);
            this.lciKapat.TextToControlDistance = 0;
            this.lciKapat.TextVisible = false;
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.CustomizationFormText = "emptySpaceItem8";
            this.emptySpaceItem8.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(78, 19);
            this.emptySpaceItem8.Text = "emptySpaceItem8";
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 273);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(78, 78);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 181);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(78, 14);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciPoliklinik
            // 
            this.lciPoliklinik.Control = this.sbPoliklinik;
            this.lciPoliklinik.CustomizationFormText = "Poliklinik";
            this.lciPoliklinik.Location = new System.Drawing.Point(0, 195);
            this.lciPoliklinik.Name = "lciPoliklinik";
            this.lciPoliklinik.Size = new System.Drawing.Size(78, 26);
            this.lciPoliklinik.Text = "Poliklinik";
            this.lciPoliklinik.TextSize = new System.Drawing.Size(0, 0);
            this.lciPoliklinik.TextToControlDistance = 0;
            this.lciPoliklinik.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbMernis;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 75);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(78, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbMedula;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 101);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(78, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 127);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(78, 28);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lcgAltTuslar
            // 
            this.lcgAltTuslar.CustomizationFormText = "Alt Tuşlar";
            this.lcgAltTuslar.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciIslemKartiSil,
            this.lciKurumCarisineIsle,
            this.lciKurumCaridenSil,
            this.lciBelgeBas,
            this.lciIslemDetay,
            this.lciDetayDok});
            this.lcgAltTuslar.Location = new System.Drawing.Point(0, 620);
            this.lcgAltTuslar.Name = "lcgAltTuslar";
            this.lcgAltTuslar.Size = new System.Drawing.Size(914, 50);
            this.lcgAltTuslar.Text = "Alt Tuşlar";
            this.lcgAltTuslar.TextVisible = false;
            // 
            // lciIslemKartiSil
            // 
            this.lciIslemKartiSil.Control = this.sbIslemKartiSil;
            this.lciIslemKartiSil.CustomizationFormText = "İşlem Kartı Sil";
            this.lciIslemKartiSil.Location = new System.Drawing.Point(221, 0);
            this.lciIslemKartiSil.Name = "lciIslemKartiSil";
            this.lciIslemKartiSil.Size = new System.Drawing.Size(78, 26);
            this.lciIslemKartiSil.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.lciIslemKartiSil.Text = "İşlem Kartı Sil";
            this.lciIslemKartiSil.TextSize = new System.Drawing.Size(0, 0);
            this.lciIslemKartiSil.TextToControlDistance = 0;
            this.lciIslemKartiSil.TextVisible = false;
            // 
            // lciKurumCarisineIsle
            // 
            this.lciKurumCarisineIsle.Control = this.sbKurumCarisineIsle;
            this.lciKurumCarisineIsle.CustomizationFormText = "Kurum Carisine İşle";
            this.lciKurumCarisineIsle.Location = new System.Drawing.Point(299, 0);
            this.lciKurumCarisineIsle.Name = "lciKurumCarisineIsle";
            this.lciKurumCarisineIsle.Size = new System.Drawing.Size(106, 26);
            this.lciKurumCarisineIsle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.lciKurumCarisineIsle.Text = "Kurum Carisine İşle";
            this.lciKurumCarisineIsle.TextSize = new System.Drawing.Size(0, 0);
            this.lciKurumCarisineIsle.TextToControlDistance = 0;
            this.lciKurumCarisineIsle.TextVisible = false;
            // 
            // lciKurumCaridenSil
            // 
            this.lciKurumCaridenSil.Control = this.sbKurumCaridenSil;
            this.lciKurumCaridenSil.CustomizationFormText = "Kurum Cariden Sil";
            this.lciKurumCaridenSil.Location = new System.Drawing.Point(405, 0);
            this.lciKurumCaridenSil.Name = "lciKurumCaridenSil";
            this.lciKurumCaridenSil.Size = new System.Drawing.Size(485, 26);
            this.lciKurumCaridenSil.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.lciKurumCaridenSil.Text = "Kurum Cariden Sil";
            this.lciKurumCaridenSil.TextSize = new System.Drawing.Size(0, 0);
            this.lciKurumCaridenSil.TextToControlDistance = 0;
            this.lciKurumCaridenSil.TextVisible = false;
            // 
            // lciBelgeBas
            // 
            this.lciBelgeBas.Control = this.sbBelgeBas;
            this.lciBelgeBas.CustomizationFormText = "Belge Bas";
            this.lciBelgeBas.Location = new System.Drawing.Point(137, 0);
            this.lciBelgeBas.Name = "lciBelgeBas";
            this.lciBelgeBas.Size = new System.Drawing.Size(84, 26);
            this.lciBelgeBas.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.lciBelgeBas.Text = "Belge Bas";
            this.lciBelgeBas.TextSize = new System.Drawing.Size(0, 0);
            this.lciBelgeBas.TextToControlDistance = 0;
            this.lciBelgeBas.TextVisible = false;
            // 
            // lciIslemDetay
            // 
            this.lciIslemDetay.Control = this.sbIslemDetay;
            this.lciIslemDetay.CustomizationFormText = "İşlem Detay";
            this.lciIslemDetay.Location = new System.Drawing.Point(0, 0);
            this.lciIslemDetay.Name = "lciIslemDetay";
            this.lciIslemDetay.Size = new System.Drawing.Size(72, 26);
            this.lciIslemDetay.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.lciIslemDetay.Text = "İşlem Detay";
            this.lciIslemDetay.TextSize = new System.Drawing.Size(0, 0);
            this.lciIslemDetay.TextToControlDistance = 0;
            this.lciIslemDetay.TextVisible = false;
            // 
            // lciDetayDok
            // 
            this.lciDetayDok.Control = this.sbDetayDok;
            this.lciDetayDok.CustomizationFormText = "Detay Dök";
            this.lciDetayDok.Location = new System.Drawing.Point(72, 0);
            this.lciDetayDok.Name = "lciDetayDok";
            this.lciDetayDok.Size = new System.Drawing.Size(65, 26);
            this.lciDetayDok.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.lciDetayDok.Text = "Detay Dök";
            this.lciDetayDok.TextSize = new System.Drawing.Size(0, 0);
            this.lciDetayDok.TextToControlDistance = 0;
            this.lciDetayDok.TextVisible = false;
            // 
            // lciIslemlerGrid
            // 
            this.lciIslemlerGrid.Control = this.gcIslemler;
            this.lciIslemlerGrid.CustomizationFormText = "İşlemler";
            this.lciIslemlerGrid.Location = new System.Drawing.Point(0, 401);
            this.lciIslemlerGrid.Name = "lciIslemlerGrid";
            this.lciIslemlerGrid.Size = new System.Drawing.Size(914, 219);
            this.lciIslemlerGrid.Text = "İşlemler";
            this.lciIslemlerGrid.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciIslemlerGrid.TextSize = new System.Drawing.Size(87, 13);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.CustomizationFormText = "emptySpaceItem9";
            this.emptySpaceItem9.Location = new System.Drawing.Point(0, 288);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(920, 20);
            this.emptySpaceItem9.Text = "emptySpaceItem9";
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "textEdit1";
            this.textEdit1.Location = new System.Drawing.Point(150, 45);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(50, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 108;
            // 
            // SGKPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 690);
            this.Controls.Add(this.layoutControl1);
            this.Name = "SGKPatientForm";
            this.Text = "HastaIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.gvIslemler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcIslemler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvZiyaret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJobFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJobPhone2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJobPhone1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJobPostCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueJobCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meJobAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJobNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJobName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSigortaliKartNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSigortaMudurlugu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSevkEdilenYer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSSKSicilNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBAGNO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProtocolNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEMSNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProfession.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOfficer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTCID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNationality.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHomePostCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueHomeCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHomePhone2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHomePhone1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deIDDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deIDDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teIDPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teIDNO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInsuranceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgIDType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBirthPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgMaritalStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMotherName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFatherName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teInsuranceCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePatientNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHomeDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHomeTown.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNufusaKayitliIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNufusaKayitliIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHomeAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgHastaIslemleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcHastaBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgHastaBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBirthDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBirthPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMotherName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFatherName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInsuranceCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIDNO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIDDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIDPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNationality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIDType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHomeAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHomeDistrict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHomeTown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHomePostCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInsuranceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHomePhone2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHomePhone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHomeCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTCID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMaritalStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDigerBilgiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgEkBilgiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSigortaliKartNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNufusaKayitliIlce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNufusaKayitliIl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSigortaMudurlugu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSevkEdilenYer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSSKSicilNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBAGNO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProtocolNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEMSNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProfession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOfficer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgIsYeriBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobPostCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobPhone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobPhone2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobFax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgKurumOzelNot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKurumOzelNot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSagTuslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIslemler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHastaFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPoliklinik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAltTuslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIslemKartiSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKurumCarisineIsle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKurumCaridenSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBelgeBas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIslemDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDetayDok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIslemlerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgHastaIslemleri;
        private DevExpress.XtraEditors.TextEdit teInsuranceCompany;
        private DevExpress.XtraEditors.TextEdit tePatientNo;
        private DevExpress.XtraEditors.TextEdit teHomePhone1;
        private DevExpress.XtraGrid.GridControl gcIslemler;
        private DevExpress.XtraGrid.Views.Grid.GridView gvZiyaret;
        private DevExpress.XtraEditors.DateEdit deIDDate;
        private DevExpress.XtraEditors.TextEdit teIDPlace;
        private DevExpress.XtraEditors.TextEdit teIDNO;
        private DevExpress.XtraEditors.RadioGroup rgIDType;
        private DevExpress.XtraEditors.RadioGroup rgSex;
        private DevExpress.XtraEditors.LookUpEdit lueInsuranceType;
        private DevExpress.XtraEditors.DateEdit deBirthDate;
        private DevExpress.XtraEditors.TextEdit teBirthPlace;
        private DevExpress.XtraEditors.RadioGroup rgMaritalStatus;
        private DevExpress.XtraEditors.TextEdit teMotherName;
        private DevExpress.XtraEditors.TextEdit teFatherName;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraLayout.TabbedControlGroup tbcHastaBilgileri;
        private DevExpress.XtraLayout.LayoutControlGroup lcgHastaBilgileri;
        private DevExpress.XtraLayout.LayoutControlItem lciInsuranceType;
        private DevExpress.XtraLayout.LayoutControlItem lciBirthDate;
        private DevExpress.XtraLayout.LayoutControlItem lciBirthPlace;
        private DevExpress.XtraLayout.LayoutControlItem lciMotherName;
        private DevExpress.XtraLayout.LayoutControlItem lciFatherName;
        private DevExpress.XtraLayout.LayoutControlItem lciLastName;
        private DevExpress.XtraLayout.LayoutControlItem lciFirstName;
        private DevExpress.XtraLayout.LayoutControlItem lciInsuranceCompany;
        private DevExpress.XtraLayout.LayoutControlItem lciPatientNo;
        private DevExpress.XtraLayout.LayoutControlItem lciMaritalStatus;
        private DevExpress.XtraLayout.LayoutControlItem lciSex;
        private DevExpress.XtraLayout.LayoutControlItem lciIDType;
        private DevExpress.XtraLayout.LayoutControlItem lciIDNO;
        private DevExpress.XtraLayout.LayoutControlItem lciIDDate;
        private DevExpress.XtraLayout.LayoutControlItem lciIDPlace;
        private DevExpress.XtraLayout.LayoutControlItem lciHomePhone1;
        private DevExpress.XtraEditors.MemoEdit memoEdit3;
        private DevExpress.XtraEditors.SimpleButton sbKapat;
        private DevExpress.XtraEditors.SimpleButton sbHastaFatura;
        private DevExpress.XtraEditors.SimpleButton sbIslemler;
        private DevExpress.XtraEditors.SimpleButton sbKaydet;
        private DevExpress.XtraEditors.SimpleButton sbAra;
        private DevExpress.XtraEditors.TextEdit teEmail;
        private DevExpress.XtraEditors.TextEdit teJobFax;
        private DevExpress.XtraEditors.TextEdit teJobPhone2;
        private DevExpress.XtraEditors.SimpleButton sbPoliklinik;
        private DevExpress.XtraEditors.TextEdit teJobPhone1;
        private DevExpress.XtraEditors.TextEdit teJobPostCode;
        private DevExpress.XtraEditors.LookUpEdit lueJobCity;
        private DevExpress.XtraEditors.MemoEdit meJobAddress;
        private DevExpress.XtraEditors.TextEdit teJobNo;
        private DevExpress.XtraEditors.TextEdit teJobName;
        private DevExpress.XtraEditors.TextEdit teSigortaliKartNo;
        private DevExpress.XtraEditors.LookUpEdit lueSigortaMudurlugu;
        private DevExpress.XtraEditors.TextEdit teSevkEdilenYer;
        private DevExpress.XtraEditors.TextEdit teSSKSicilNo;
        private DevExpress.XtraEditors.TextEdit teBAGNO;
        private DevExpress.XtraEditors.TextEdit teProtocolNo;
        private DevExpress.XtraEditors.TextEdit teEMSNo;
        private DevExpress.XtraEditors.TextEdit teProfession;
        private DevExpress.XtraEditors.TextEdit teOfficer;
        private DevExpress.XtraEditors.TextEdit teTCID;
        private DevExpress.XtraEditors.LookUpEdit lueNationality;
        private DevExpress.XtraEditors.TextEdit teHomePostCode;
        private DevExpress.XtraEditors.LookUpEdit lueHomeCity;
        private DevExpress.XtraEditors.TextEdit teHomePhone2;
        private DevExpress.XtraGrid.Columns.GridColumn colSevkTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colTakipDurumu;
        private DevExpress.XtraLayout.LayoutControlItem lciHomePhone2;
        private DevExpress.XtraLayout.LayoutControlItem lciHomeAddress;
        private DevExpress.XtraLayout.LayoutControlItem lciHomeDistrict;
        private DevExpress.XtraLayout.LayoutControlItem lciHomeTown;
        private DevExpress.XtraLayout.LayoutControlItem lciHomeCity;
        private DevExpress.XtraLayout.LayoutControlItem lciHomePostCode;
        private DevExpress.XtraLayout.LayoutControlItem lciNationality;
        private DevExpress.XtraLayout.LayoutControlItem lciTCID;
        private DevExpress.XtraLayout.LayoutControlItem lciStatus;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDigerBilgiler;
        private DevExpress.XtraLayout.LayoutControlGroup lcgEkBilgiler;
        private DevExpress.XtraLayout.LayoutControlItem lciSigortaliKartNo;
        private DevExpress.XtraLayout.LayoutControlItem lciNufusaKayitliIlce;
        private DevExpress.XtraLayout.LayoutControlItem lciNufusaKayitliIl;
        private DevExpress.XtraLayout.LayoutControlItem lciSigortaMudurlugu;
        private DevExpress.XtraLayout.LayoutControlItem lciSevkEdilenYer;
        private DevExpress.XtraLayout.LayoutControlItem lciSSKSicilNo;
        private DevExpress.XtraLayout.LayoutControlItem lciBAGNO;
        private DevExpress.XtraLayout.LayoutControlItem lciProtocolNo;
        private DevExpress.XtraLayout.LayoutControlItem lciEMSNo;
        private DevExpress.XtraLayout.LayoutControlItem lciProfession;
        private DevExpress.XtraLayout.LayoutControlItem lciOfficer;
        private DevExpress.XtraLayout.LayoutControlGroup lcgIsYeriBilgileri;
        private DevExpress.XtraLayout.LayoutControlItem lciJobName;
        private DevExpress.XtraLayout.LayoutControlItem lciJobNo;
        private DevExpress.XtraLayout.LayoutControlItem lciJobAddress;
        private DevExpress.XtraLayout.LayoutControlItem lciJobCity;
        private DevExpress.XtraLayout.LayoutControlItem lciJobPostCode;
        private DevExpress.XtraLayout.LayoutControlItem lciJobPhone1;
        private DevExpress.XtraLayout.LayoutControlItem lciJobPhone2;
        private DevExpress.XtraLayout.LayoutControlItem lciJobFax;
        private DevExpress.XtraLayout.LayoutControlItem lciEMail;
        private DevExpress.XtraLayout.LayoutControlGroup lcgKurumOzelNot;
        private DevExpress.XtraLayout.LayoutControlItem lciKurumOzelNot;
        private DevExpress.XtraLayout.LayoutControlGroup lcgSagTuslar;
        private DevExpress.XtraLayout.LayoutControlItem lciAra;
        private DevExpress.XtraLayout.LayoutControlItem lciPoliklinik;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciKaydet;
        private DevExpress.XtraLayout.LayoutControlItem lciIslemler;
        private DevExpress.XtraLayout.LayoutControlItem lciHastaFatura;
        private DevExpress.XtraLayout.LayoutControlItem lciKapat;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraEditors.SimpleButton sbIslemKartiSil;
        private DevExpress.XtraEditors.SimpleButton sbKurumCaridenSil;
        private DevExpress.XtraEditors.SimpleButton sbKurumCarisineIsle;
        private DevExpress.XtraLayout.LayoutControlItem lciKurumCarisineIsle;
        private DevExpress.XtraLayout.LayoutControlItem lciKurumCaridenSil;
        private DevExpress.XtraLayout.LayoutControlItem lciIslemKartiSil;
        private DevExpress.XtraLayout.LayoutControlGroup lcgAltTuslar;
        private DevExpress.XtraEditors.SimpleButton sbDetayDok;
        private DevExpress.XtraEditors.SimpleButton sbIslemDetay;
        private DevExpress.XtraEditors.SimpleButton sbBelgeBas;
        private DevExpress.XtraLayout.LayoutControlItem lciBelgeBas;
        private DevExpress.XtraLayout.LayoutControlItem lciIslemDetay;
        private DevExpress.XtraLayout.LayoutControlItem lciDetayDok;
        private DevExpress.XtraEditors.TextEdit teHomeDistrict;
        private DevExpress.XtraEditors.TextEdit teHomeTown;
        private DevExpress.XtraEditors.TextEdit teNufusaKayitliIl;
        private DevExpress.XtraEditors.TextEdit teNufusaKayitliIlce;
        private DevExpress.XtraEditors.MemoEdit teHomeAddress;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem lciIslemlerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitNo;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExitDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colInsuranceTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIMPF2;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitType;
        private DevExpress.XtraGrid.Columns.GridColumn colKar_No;
        private DevExpress.XtraGrid.Columns.GridColumn colTakipNo;
        private DevExpress.XtraGrid.Columns.GridColumn colProvisionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTakipTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientAppNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIliskiliTakipNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIslemler;
        private DevExpress.XtraGrid.Columns.GridColumn colSiraNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colTANIM;
        private DevExpress.XtraGrid.Columns.GridColumn colGRUP;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colARZT;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME1;
        private DevExpress.XtraGrid.Columns.GridColumn colSATISF;
        private DevExpress.XtraGrid.Columns.GridColumn colKSATISF;
        private DevExpress.XtraGrid.Columns.GridColumn colADET;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn colDoctor;
        private DevExpress.XtraEditors.LookUpEdit lueStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDoktor2;
        private Controls.MernisSorgu mernisSorgu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private Controls.MedulaProvisionControl medulaSorgu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientVisitDetails;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.SimpleButton sbMedula;
        private DevExpress.XtraEditors.SimpleButton sbMernis;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}