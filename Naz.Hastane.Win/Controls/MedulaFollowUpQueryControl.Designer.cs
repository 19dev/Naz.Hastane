namespace Naz.Hastane.Win.Controls
{
    partial class MedulaFollowUpQueryControl
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbExcel = new DevExpress.XtraEditors.SimpleButton();
            this.sbPrint = new DevExpress.XtraEditors.SimpleButton();
            this.sbDelete = new DevExpress.XtraEditors.SimpleButton();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.sbQuery = new DevExpress.XtraEditors.SimpleButton();
            this.gcResult = new DevExpress.XtraGrid.GridControl();
            this.gvResult = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTakipNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlkTakipNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTakipTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBransKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonorTCKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHastaBasvuruNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTakipTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTedaviTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTakipDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvizyonTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTedaviTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaTeslimNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSevkDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYeniDoganDogumTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYeniDoganCocukSiraNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueOnlyExternalTransfers = new DevExpress.XtraEditors.LookUpEdit();
            this.deEndDate = new DevExpress.XtraEditors.DateEdit();
            this.deStartDate = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciStartDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEndDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciOnlyExternalTransfers = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciGridResult = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciQuery = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDelete = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPrint = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciExcel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOnlyExternalTransfers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOnlyExternalTransfers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbExcel);
            this.layoutControl1.Controls.Add(this.sbPrint);
            this.layoutControl1.Controls.Add(this.lblStatus);
            this.layoutControl1.Controls.Add(this.sbQuery);
            this.layoutControl1.Controls.Add(this.gcResult);
            this.layoutControl1.Controls.Add(this.lueOnlyExternalTransfers);
            this.layoutControl1.Controls.Add(this.sbDelete);
            this.layoutControl1.Controls.Add(this.deEndDate);
            this.layoutControl1.Controls.Add(this.deStartDate);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(875, 566);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbExcel
            // 
            this.sbExcel.Location = new System.Drawing.Point(7, 537);
            this.sbExcel.Name = "sbExcel";
            this.sbExcel.Size = new System.Drawing.Size(61, 22);
            this.sbExcel.StyleController = this.layoutControl1;
            this.sbExcel.TabIndex = 12;
            this.sbExcel.Text = "Excel";
            this.sbExcel.Click += new System.EventHandler(this.sbExcel_Click);
            // 
            // sbPrint
            // 
            this.sbPrint.Location = new System.Drawing.Point(72, 537);
            this.sbPrint.Name = "sbPrint";
            this.sbPrint.Size = new System.Drawing.Size(79, 22);
            this.sbPrint.StyleController = this.layoutControl1;
            this.sbPrint.TabIndex = 11;
            this.sbPrint.Text = "Yazıcıya";
            this.sbPrint.Click += new System.EventHandler(this.sbPrint_Click);
            // 
            // sbDelete
            // 
            this.sbDelete.Location = new System.Drawing.Point(155, 537);
            this.sbDelete.Name = "sbDelete";
            this.sbDelete.Size = new System.Drawing.Size(65, 22);
            this.sbDelete.StyleController = this.layoutControl1;
            this.sbDelete.TabIndex = 10;
            this.sbDelete.Text = "Sil";
            this.sbDelete.Click += new System.EventHandler(this.sbDelete_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(224, 537);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(532, 13);
            this.lblStatus.StyleController = this.layoutControl1;
            this.lblStatus.TabIndex = 9;
            // 
            // sbQuery
            // 
            this.sbQuery.Location = new System.Drawing.Point(758, 7);
            this.sbQuery.Name = "sbQuery";
            this.sbQuery.Size = new System.Drawing.Size(110, 22);
            this.sbQuery.StyleController = this.layoutControl1;
            this.sbQuery.TabIndex = 8;
            this.sbQuery.Text = "Sorgula";
            this.sbQuery.Click += new System.EventHandler(this.sbQuery_Click);
            // 
            // gcResult
            // 
            this.gcResult.Location = new System.Drawing.Point(5, 47);
            this.gcResult.MainView = this.gvResult;
            this.gcResult.Name = "gcResult";
            this.gcResult.Size = new System.Drawing.Size(865, 488);
            this.gcResult.TabIndex = 7;
            this.gcResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResult});
            // 
            // gvResult
            // 
            this.gvResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTakipNo,
            this.colIlkTakipNo,
            this.colTakipTarihi,
            this.colKayitTarihi,
            this.colBransKodu,
            this.colDonorTCKimlikNo,
            this.colHastaBasvuruNo,
            this.colTakipTipi,
            this.colTedaviTuru,
            this.colTakipDurumu,
            this.colProvizyonTipi,
            this.colTedaviTipi,
            this.colFaturaTeslimNo,
            this.colSevkDurumu,
            this.colYeniDoganDogumTarihi,
            this.colYeniDoganCocukSiraNo});
            this.gvResult.GridControl = this.gcResult;
            this.gvResult.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvResult.Name = "gvResult";
            this.gvResult.OptionsBehavior.Editable = false;
            this.gvResult.OptionsView.ColumnAutoWidth = false;
            this.gvResult.OptionsView.ShowGroupPanel = false;
            // 
            // colTakipNo
            // 
            this.colTakipNo.Caption = "Takip No";
            this.colTakipNo.FieldName = "takipNo";
            this.colTakipNo.Name = "colTakipNo";
            this.colTakipNo.Visible = true;
            this.colTakipNo.VisibleIndex = 1;
            this.colTakipNo.Width = 55;
            // 
            // colIlkTakipNo
            // 
            this.colIlkTakipNo.Caption = "İlk Takip No";
            this.colIlkTakipNo.FieldName = "ilkTakipNo";
            this.colIlkTakipNo.Name = "colIlkTakipNo";
            this.colIlkTakipNo.Visible = true;
            this.colIlkTakipNo.VisibleIndex = 2;
            this.colIlkTakipNo.Width = 68;
            // 
            // colTakipTarihi
            // 
            this.colTakipTarihi.Caption = "Takip Tarihi";
            this.colTakipTarihi.FieldName = "takipTarihi";
            this.colTakipTarihi.Name = "colTakipTarihi";
            this.colTakipTarihi.Visible = true;
            this.colTakipTarihi.VisibleIndex = 3;
            this.colTakipTarihi.Width = 63;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.Caption = "Kayıt Tarihi";
            this.colKayitTarihi.FieldName = "kayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.VisibleIndex = 4;
            this.colKayitTarihi.Width = 62;
            // 
            // colBransKodu
            // 
            this.colBransKodu.Caption = "Branş Kodu";
            this.colBransKodu.FieldName = "bransKodu";
            this.colBransKodu.Name = "colBransKodu";
            this.colBransKodu.Visible = true;
            this.colBransKodu.VisibleIndex = 5;
            this.colBransKodu.Width = 46;
            // 
            // colDonorTCKimlikNo
            // 
            this.colDonorTCKimlikNo.Caption = "Donor T.C. Kimlik No";
            this.colDonorTCKimlikNo.FieldName = "donorTCKimlikNo";
            this.colDonorTCKimlikNo.Name = "colDonorTCKimlikNo";
            this.colDonorTCKimlikNo.Visible = true;
            this.colDonorTCKimlikNo.VisibleIndex = 13;
            this.colDonorTCKimlikNo.Width = 59;
            // 
            // colHastaBasvuruNo
            // 
            this.colHastaBasvuruNo.Caption = "Hasta Başvuru No";
            this.colHastaBasvuruNo.FieldName = "hastaBasvuruNo";
            this.colHastaBasvuruNo.Name = "colHastaBasvuruNo";
            this.colHastaBasvuruNo.Visible = true;
            this.colHastaBasvuruNo.VisibleIndex = 0;
            this.colHastaBasvuruNo.Width = 95;
            // 
            // colTakipTipi
            // 
            this.colTakipTipi.Caption = "Takip Tipi";
            this.colTakipTipi.FieldName = "takipTipi";
            this.colTakipTipi.Name = "colTakipTipi";
            this.colTakipTipi.Visible = true;
            this.colTakipTipi.VisibleIndex = 6;
            this.colTakipTipi.Width = 53;
            // 
            // colTedaviTuru
            // 
            this.colTedaviTuru.Caption = "Tedavi Türü";
            this.colTedaviTuru.FieldName = "tedaviTuru";
            this.colTedaviTuru.Name = "colTedaviTuru";
            this.colTedaviTuru.Visible = true;
            this.colTedaviTuru.VisibleIndex = 7;
            this.colTedaviTuru.Width = 66;
            // 
            // colTakipDurumu
            // 
            this.colTakipDurumu.Caption = "Takip Durumu";
            this.colTakipDurumu.FieldName = "takipDurumu";
            this.colTakipDurumu.Name = "colTakipDurumu";
            this.colTakipDurumu.Visible = true;
            this.colTakipDurumu.VisibleIndex = 8;
            this.colTakipDurumu.Width = 74;
            // 
            // colProvizyonTipi
            // 
            this.colProvizyonTipi.Caption = "Provizyon Tipi";
            this.colProvizyonTipi.FieldName = "provizyonTipi";
            this.colProvizyonTipi.Name = "colProvizyonTipi";
            this.colProvizyonTipi.Visible = true;
            this.colProvizyonTipi.VisibleIndex = 9;
            // 
            // colTedaviTipi
            // 
            this.colTedaviTipi.Caption = "Tedavi Tipi";
            this.colTedaviTipi.FieldName = "tedaviTipi";
            this.colTedaviTipi.Name = "colTedaviTipi";
            this.colTedaviTipi.Visible = true;
            this.colTedaviTipi.VisibleIndex = 10;
            this.colTedaviTipi.Width = 60;
            // 
            // colFaturaTeslimNo
            // 
            this.colFaturaTeslimNo.Caption = "Fatura Teslim No";
            this.colFaturaTeslimNo.FieldName = "faturaTeslimNo";
            this.colFaturaTeslimNo.Name = "colFaturaTeslimNo";
            this.colFaturaTeslimNo.Visible = true;
            this.colFaturaTeslimNo.VisibleIndex = 11;
            this.colFaturaTeslimNo.Width = 89;
            // 
            // colSevkDurumu
            // 
            this.colSevkDurumu.Caption = "Sevk Durumu";
            this.colSevkDurumu.FieldName = "sevkDurumu";
            this.colSevkDurumu.Name = "colSevkDurumu";
            this.colSevkDurumu.Visible = true;
            this.colSevkDurumu.VisibleIndex = 12;
            this.colSevkDurumu.Width = 72;
            // 
            // colYeniDoganDogumTarihi
            // 
            this.colYeniDoganDogumTarihi.Caption = "Yeni Doğan Doğum Tarihi";
            this.colYeniDoganDogumTarihi.FieldName = "yeniDoganDogumTarihi";
            this.colYeniDoganDogumTarihi.Name = "colYeniDoganDogumTarihi";
            this.colYeniDoganDogumTarihi.Visible = true;
            this.colYeniDoganDogumTarihi.VisibleIndex = 14;
            this.colYeniDoganDogumTarihi.Width = 128;
            // 
            // colYeniDoganCocukSiraNo
            // 
            this.colYeniDoganCocukSiraNo.Caption = "Yeni Doğan Çocuk Sıra No";
            this.colYeniDoganCocukSiraNo.FieldName = "yeniDoganCocukSiraNo";
            this.colYeniDoganCocukSiraNo.Name = "colYeniDoganCocukSiraNo";
            this.colYeniDoganCocukSiraNo.Visible = true;
            this.colYeniDoganCocukSiraNo.VisibleIndex = 15;
            this.colYeniDoganCocukSiraNo.Width = 132;
            // 
            // lueOnlyExternalTransfers
            // 
            this.lueOnlyExternalTransfers.Location = new System.Drawing.Point(523, 7);
            this.lueOnlyExternalTransfers.Name = "lueOnlyExternalTransfers";
            this.lueOnlyExternalTransfers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOnlyExternalTransfers.Size = new System.Drawing.Size(82, 20);
            this.lueOnlyExternalTransfers.StyleController = this.layoutControl1;
            this.lueOnlyExternalTransfers.TabIndex = 6;
            // 
            // deEndDate
            // 
            this.deEndDate.EditValue = null;
            this.deEndDate.Location = new System.Drawing.Point(302, 7);
            this.deEndDate.Name = "deEndDate";
            this.deEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deEndDate.Size = new System.Drawing.Size(93, 20);
            this.deEndDate.StyleController = this.layoutControl1;
            this.deEndDate.TabIndex = 5;
            // 
            // deStartDate
            // 
            this.deStartDate.EditValue = null;
            this.deStartDate.Location = new System.Drawing.Point(107, 7);
            this.deStartDate.Name = "deStartDate";
            this.deStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deStartDate.Size = new System.Drawing.Size(91, 20);
            this.deStartDate.StyleController = this.layoutControl1;
            this.deStartDate.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciStartDate,
            this.lciEndDate,
            this.lciOnlyExternalTransfers,
            this.lciGridResult,
            this.lciQuery,
            this.lciPrint,
            this.lciExcel,
            this.lciStatus,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.lciDelete});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(875, 566);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciStartDate
            // 
            this.lciStartDate.Control = this.deStartDate;
            this.lciStartDate.CustomizationFormText = "Başlangıç Tarihi";
            this.lciStartDate.Location = new System.Drawing.Point(0, 0);
            this.lciStartDate.Name = "lciStartDate";
            this.lciStartDate.Size = new System.Drawing.Size(195, 26);
            this.lciStartDate.Text = "Başlangıç Tarihi";
            this.lciStartDate.TextSize = new System.Drawing.Size(96, 13);
            // 
            // lciEndDate
            // 
            this.lciEndDate.Control = this.deEndDate;
            this.lciEndDate.CustomizationFormText = "Bitiş Tarihi";
            this.lciEndDate.Location = new System.Drawing.Point(195, 0);
            this.lciEndDate.Name = "lciEndDate";
            this.lciEndDate.Size = new System.Drawing.Size(197, 26);
            this.lciEndDate.Text = "Bitiş Tarihi";
            this.lciEndDate.TextSize = new System.Drawing.Size(96, 13);
            // 
            // lciOnlyExternalTransfers
            // 
            this.lciOnlyExternalTransfers.Control = this.lueOnlyExternalTransfers;
            this.lciOnlyExternalTransfers.CustomizationFormText = "Sadece Dışa Sevkler";
            this.lciOnlyExternalTransfers.Location = new System.Drawing.Point(416, 0);
            this.lciOnlyExternalTransfers.Name = "lciOnlyExternalTransfers";
            this.lciOnlyExternalTransfers.Size = new System.Drawing.Size(186, 26);
            this.lciOnlyExternalTransfers.Text = "Sadece Dışa Sevkler";
            this.lciOnlyExternalTransfers.TextSize = new System.Drawing.Size(96, 13);
            // 
            // lciGridResult
            // 
            this.lciGridResult.Control = this.gcResult;
            this.lciGridResult.CustomizationFormText = "Takip Listesi";
            this.lciGridResult.Location = new System.Drawing.Point(0, 26);
            this.lciGridResult.Name = "lciGridResult";
            this.lciGridResult.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciGridResult.Size = new System.Drawing.Size(865, 504);
            this.lciGridResult.Text = "Takip Listesi";
            this.lciGridResult.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciGridResult.TextSize = new System.Drawing.Size(96, 13);
            // 
            // lciQuery
            // 
            this.lciQuery.Control = this.sbQuery;
            this.lciQuery.CustomizationFormText = "Sorgula";
            this.lciQuery.Location = new System.Drawing.Point(751, 0);
            this.lciQuery.Name = "lciQuery";
            this.lciQuery.Size = new System.Drawing.Size(114, 26);
            this.lciQuery.Text = "Sorgula";
            this.lciQuery.TextSize = new System.Drawing.Size(0, 0);
            this.lciQuery.TextToControlDistance = 0;
            this.lciQuery.TextVisible = false;
            // 
            // lciDelete
            // 
            this.lciDelete.Control = this.sbDelete;
            this.lciDelete.CustomizationFormText = "lciDelete";
            this.lciDelete.Location = new System.Drawing.Point(148, 530);
            this.lciDelete.Name = "lciDelete";
            this.lciDelete.Size = new System.Drawing.Size(69, 26);
            this.lciDelete.Text = "lciDelete";
            this.lciDelete.TextSize = new System.Drawing.Size(0, 0);
            this.lciDelete.TextToControlDistance = 0;
            this.lciDelete.TextVisible = false;
            // 
            // lciPrint
            // 
            this.lciPrint.Control = this.sbPrint;
            this.lciPrint.CustomizationFormText = "lciPrint";
            this.lciPrint.Location = new System.Drawing.Point(65, 530);
            this.lciPrint.Name = "lciPrint";
            this.lciPrint.Size = new System.Drawing.Size(83, 26);
            this.lciPrint.Text = "lciPrint";
            this.lciPrint.TextSize = new System.Drawing.Size(0, 0);
            this.lciPrint.TextToControlDistance = 0;
            this.lciPrint.TextVisible = false;
            // 
            // lciExcel
            // 
            this.lciExcel.Control = this.sbExcel;
            this.lciExcel.CustomizationFormText = "lciExcel";
            this.lciExcel.Location = new System.Drawing.Point(0, 530);
            this.lciExcel.Name = "lciExcel";
            this.lciExcel.Size = new System.Drawing.Size(65, 26);
            this.lciExcel.Text = "lciExcel";
            this.lciExcel.TextSize = new System.Drawing.Size(0, 0);
            this.lciExcel.TextToControlDistance = 0;
            this.lciExcel.TextVisible = false;
            // 
            // lciStatus
            // 
            this.lciStatus.Control = this.lblStatus;
            this.lciStatus.CustomizationFormText = "lciStatus";
            this.lciStatus.Location = new System.Drawing.Point(217, 530);
            this.lciStatus.Name = "lciStatus";
            this.lciStatus.Size = new System.Drawing.Size(536, 26);
            this.lciStatus.Text = "lciStatus";
            this.lciStatus.TextSize = new System.Drawing.Size(0, 0);
            this.lciStatus.TextToControlDistance = 0;
            this.lciStatus.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(392, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(24, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(602, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(149, 26);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(753, 530);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(112, 26);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // MedulaFollowUpQueryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "MedulaFollowUpQueryControl";
            this.Size = new System.Drawing.Size(875, 566);
            this.Load += new System.EventHandler(this.MedulaFollowUpQueryControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOnlyExternalTransfers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOnlyExternalTransfers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton sbQuery;
        private DevExpress.XtraGrid.GridControl gcResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gvResult;
        private DevExpress.XtraGrid.Columns.GridColumn colTakipNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIlkTakipNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTakipTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colBransKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDonorTCKimlikNo;
        private DevExpress.XtraGrid.Columns.GridColumn colHastaBasvuruNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTakipTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colTedaviTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colTakipDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colProvizyonTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colTedaviTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaTeslimNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSevkDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colYeniDoganDogumTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colYeniDoganCocukSiraNo;
        private DevExpress.XtraEditors.LookUpEdit lueOnlyExternalTransfers;
        private DevExpress.XtraEditors.DateEdit deEndDate;
        private DevExpress.XtraEditors.DateEdit deStartDate;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciStartDate;
        private DevExpress.XtraLayout.LayoutControlItem lciEndDate;
        private DevExpress.XtraLayout.LayoutControlItem lciOnlyExternalTransfers;
        private DevExpress.XtraLayout.LayoutControlItem lciGridResult;
        private DevExpress.XtraLayout.LayoutControlItem lciQuery;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraLayout.LayoutControlItem lciStatus;
        private DevExpress.XtraEditors.SimpleButton sbExcel;
        private DevExpress.XtraEditors.SimpleButton sbPrint;
        private DevExpress.XtraEditors.SimpleButton sbDelete;
        private DevExpress.XtraLayout.LayoutControlItem lciDelete;
        private DevExpress.XtraLayout.LayoutControlItem lciPrint;
        private DevExpress.XtraLayout.LayoutControlItem lciExcel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}
