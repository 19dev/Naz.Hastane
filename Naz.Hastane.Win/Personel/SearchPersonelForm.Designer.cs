namespace Naz.Hastane.Win.MDIChildForms
{
    partial class SearchPersonelForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbNew = new DevExpress.XtraEditors.SimpleButton();
            this.lcPersonelAdeti = new DevExpress.XtraEditors.LabelControl();
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.sbClean = new DevExpress.XtraEditors.SimpleButton();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.sbSearch = new DevExpress.XtraEditors.SimpleButton();
            this.gcPersonel = new DevExpress.XtraGrid.GridControl();
            this.gvPersonel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKNR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTCKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tePersonelNo = new DevExpress.XtraEditors.TextEdit();
            this.teTCId = new DevExpress.XtraEditors.TextEdit();
            this.sbSelect = new DevExpress.XtraEditors.SimpleButton();
            this.lcgSayfa = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPersonel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgAramaKriterleri = new DevExpress.XtraLayout.LayoutControlGroup();
            this.grpHastaNo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPersonelNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTCId = new DevExpress.XtraLayout.LayoutControlItem();
            this.grpSNR = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgTuslar = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciClose = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSelect = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciClean = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSearch = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNew = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPersonelAdeti = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePersonelNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTCId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAramaKriterleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpHastaNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPersonelNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTCId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSNR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTuslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPersonelAdeti)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbNew);
            this.layoutControl1.Controls.Add(this.lcPersonelAdeti);
            this.layoutControl1.Controls.Add(this.sbClose);
            this.layoutControl1.Controls.Add(this.sbClean);
            this.layoutControl1.Controls.Add(this.teLastName);
            this.layoutControl1.Controls.Add(this.teFirstName);
            this.layoutControl1.Controls.Add(this.sbSearch);
            this.layoutControl1.Controls.Add(this.gcPersonel);
            this.layoutControl1.Controls.Add(this.tePersonelNo);
            this.layoutControl1.Controls.Add(this.teTCId);
            this.layoutControl1.Controls.Add(this.sbSelect);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1558, -113, 549, 703);
            this.layoutControl1.Root = this.lcgSayfa;
            this.layoutControl1.Size = new System.Drawing.Size(954, 638);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbNew
            // 
            this.sbNew.Location = new System.Drawing.Point(731, 76);
            this.sbNew.Name = "sbNew";
            this.sbNew.Size = new System.Drawing.Size(96, 22);
            this.sbNew.StyleController = this.layoutControl1;
            this.sbNew.TabIndex = 8;
            this.sbNew.Text = "Yeni";
            this.sbNew.Click += new System.EventHandler(this.sbNew_Click);
            // 
            // lcPersonelAdeti
            // 
            this.lcPersonelAdeti.Location = new System.Drawing.Point(894, 613);
            this.lcPersonelAdeti.Name = "lcPersonelAdeti";
            this.lcPersonelAdeti.Size = new System.Drawing.Size(48, 13);
            this.lcPersonelAdeti.StyleController = this.layoutControl1;
            this.lcPersonelAdeti.TabIndex = 21;
            this.lcPersonelAdeti.Text = "Bulunan:0";
            // 
            // sbClose
            // 
            this.sbClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbClose.Location = new System.Drawing.Point(831, 50);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(99, 22);
            this.sbClose.StyleController = this.layoutControl1;
            this.sbClose.TabIndex = 10;
            this.sbClose.Text = "Kapat";
            this.sbClose.Click += new System.EventHandler(this.sbClose_Click);
            // 
            // sbClean
            // 
            this.sbClean.Location = new System.Drawing.Point(831, 24);
            this.sbClean.Name = "sbClean";
            this.sbClean.Size = new System.Drawing.Size(99, 22);
            this.sbClean.StyleController = this.layoutControl1;
            this.sbClean.TabIndex = 9;
            this.sbClean.Text = "Temizle";
            this.sbClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(476, 60);
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teLastName.Size = new System.Drawing.Size(215, 20);
            this.teLastName.StyleController = this.layoutControl1;
            this.teLastName.TabIndex = 4;
            this.teLastName.Tag = "HASTASOYADI";
            // 
            // teFirstName
            // 
            this.teFirstName.Location = new System.Drawing.Point(476, 36);
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teFirstName.Size = new System.Drawing.Size(215, 20);
            this.teFirstName.StyleController = this.layoutControl1;
            this.teFirstName.TabIndex = 3;
            this.teFirstName.Tag = "HASTAADI";
            // 
            // sbSearch
            // 
            this.sbSearch.Location = new System.Drawing.Point(731, 24);
            this.sbSearch.Name = "sbSearch";
            this.sbSearch.Size = new System.Drawing.Size(96, 22);
            this.sbSearch.StyleController = this.layoutControl1;
            this.sbSearch.TabIndex = 6;
            this.sbSearch.Text = "Ara";
            this.sbSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gcPersonel
            // 
            this.gcPersonel.Location = new System.Drawing.Point(12, 130);
            this.gcPersonel.MainView = this.gvPersonel;
            this.gcPersonel.Name = "gcPersonel";
            this.gcPersonel.Size = new System.Drawing.Size(930, 479);
            this.gcPersonel.TabIndex = 11;
            this.gcPersonel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPersonel});
            this.gcPersonel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridPersonelArama_MouseDoubleClick);
            // 
            // gvPersonel
            // 
            this.gvPersonel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colKNR,
            this.colSoyadi,
            this.colAdi,
            this.colTCKimlikNo});
            this.gvPersonel.GridControl = this.gcPersonel;
            this.gvPersonel.Name = "gvPersonel";
            this.gvPersonel.OptionsBehavior.Editable = false;
            this.gvPersonel.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colKNR
            // 
            this.colKNR.Caption = "Personel No";
            this.colKNR.FieldName = "PersonelNo";
            this.colKNR.Name = "colKNR";
            this.colKNR.Visible = true;
            this.colKNR.VisibleIndex = 0;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyad";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 1;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Ad";
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 2;
            // 
            // colTCKimlikNo
            // 
            this.colTCKimlikNo.Caption = "T.C. Kimlik No";
            this.colTCKimlikNo.FieldName = "TCID";
            this.colTCKimlikNo.Name = "colTCKimlikNo";
            this.colTCKimlikNo.Visible = true;
            this.colTCKimlikNo.VisibleIndex = 3;
            // 
            // tePersonelNo
            // 
            this.tePersonelNo.Location = new System.Drawing.Point(122, 60);
            this.tePersonelNo.Name = "tePersonelNo";
            this.tePersonelNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tePersonelNo.Size = new System.Drawing.Size(240, 20);
            this.tePersonelNo.StyleController = this.layoutControl1;
            this.tePersonelNo.TabIndex = 2;
            this.tePersonelNo.Tag = "KNR";
            // 
            // teTCId
            // 
            this.teTCId.Location = new System.Drawing.Point(122, 36);
            this.teTCId.Name = "teTCId";
            this.teTCId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teTCId.Size = new System.Drawing.Size(240, 20);
            this.teTCId.StyleController = this.layoutControl1;
            this.teTCId.TabIndex = 1;
            this.teTCId.Tag = "TCKIMLIKNO";
            // 
            // sbSelect
            // 
            this.sbSelect.Location = new System.Drawing.Point(731, 50);
            this.sbSelect.Name = "sbSelect";
            this.sbSelect.Size = new System.Drawing.Size(96, 22);
            this.sbSelect.StyleController = this.layoutControl1;
            this.sbSelect.TabIndex = 7;
            this.sbSelect.Text = "Seç";
            this.sbSelect.Click += new System.EventHandler(this.bntSelect_Click);
            // 
            // lcgSayfa
            // 
            this.lcgSayfa.CustomizationFormText = "Sayfa";
            this.lcgSayfa.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgSayfa.GroupBordersVisible = false;
            this.lcgSayfa.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPersonel,
            this.lcgAramaKriterleri,
            this.lcgTuslar,
            this.lciPersonelAdeti});
            this.lcgSayfa.Location = new System.Drawing.Point(0, 0);
            this.lcgSayfa.Name = "lcgSayfa";
            this.lcgSayfa.Size = new System.Drawing.Size(954, 638);
            this.lcgSayfa.Text = "Sayfa";
            this.lcgSayfa.TextVisible = false;
            // 
            // lciPersonel
            // 
            this.lciPersonel.Control = this.gcPersonel;
            this.lciPersonel.CustomizationFormText = "Bulunan Personel";
            this.lciPersonel.Location = new System.Drawing.Point(0, 102);
            this.lciPersonel.Name = "lciPersonel";
            this.lciPersonel.Size = new System.Drawing.Size(934, 499);
            this.lciPersonel.Text = "Bulunan Personel";
            this.lciPersonel.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciPersonel.TextSize = new System.Drawing.Size(82, 13);
            // 
            // lcgAramaKriterleri
            // 
            this.lcgAramaKriterleri.CustomizationFormText = "Arama Kriterleri";
            this.lcgAramaKriterleri.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.grpHastaNo,
            this.grpSNR});
            this.lcgAramaKriterleri.Location = new System.Drawing.Point(0, 0);
            this.lcgAramaKriterleri.Name = "lcgAramaKriterleri";
            this.lcgAramaKriterleri.Size = new System.Drawing.Size(707, 102);
            this.lcgAramaKriterleri.Text = "Arama Kriterleri";
            this.lcgAramaKriterleri.TextVisible = false;
            // 
            // grpHastaNo
            // 
            this.grpHastaNo.CustomizationFormText = "Patient No";
            this.grpHastaNo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPersonelNo,
            this.lciTCId});
            this.grpHastaNo.Location = new System.Drawing.Point(0, 0);
            this.grpHastaNo.Name = "grpHastaNo";
            this.grpHastaNo.Size = new System.Drawing.Size(354, 78);
            this.grpHastaNo.Text = "Patient No";
            this.grpHastaNo.TextVisible = false;
            // 
            // lciPersonelNo
            // 
            this.lciPersonelNo.Control = this.tePersonelNo;
            this.lciPersonelNo.CustomizationFormText = "Personel No";
            this.lciPersonelNo.Location = new System.Drawing.Point(0, 24);
            this.lciPersonelNo.Name = "lciPersonelNo";
            this.lciPersonelNo.Size = new System.Drawing.Size(330, 30);
            this.lciPersonelNo.Text = "Personel No";
            this.lciPersonelNo.TextSize = new System.Drawing.Size(82, 13);
            // 
            // lciTCId
            // 
            this.lciTCId.Control = this.teTCId;
            this.lciTCId.CustomizationFormText = "T.C.Kimlik No";
            this.lciTCId.Location = new System.Drawing.Point(0, 0);
            this.lciTCId.Name = "lciTCId";
            this.lciTCId.Size = new System.Drawing.Size(330, 24);
            this.lciTCId.Text = "T.C.Kimlik No";
            this.lciTCId.TextSize = new System.Drawing.Size(82, 13);
            // 
            // grpSNR
            // 
            this.grpSNR.CustomizationFormText = "SNR";
            this.grpSNR.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFirstName,
            this.lciLastName});
            this.grpSNR.Location = new System.Drawing.Point(354, 0);
            this.grpSNR.Name = "grpSNR";
            this.grpSNR.Size = new System.Drawing.Size(329, 78);
            this.grpSNR.Text = "SNR";
            this.grpSNR.TextVisible = false;
            // 
            // lciFirstName
            // 
            this.lciFirstName.Control = this.teFirstName;
            this.lciFirstName.CustomizationFormText = "Adı";
            this.lciFirstName.Location = new System.Drawing.Point(0, 0);
            this.lciFirstName.Name = "lciFirstName";
            this.lciFirstName.Size = new System.Drawing.Size(305, 24);
            this.lciFirstName.Text = "Adı";
            this.lciFirstName.TextSize = new System.Drawing.Size(82, 13);
            // 
            // lciLastName
            // 
            this.lciLastName.Control = this.teLastName;
            this.lciLastName.CustomizationFormText = "Soyadı";
            this.lciLastName.Location = new System.Drawing.Point(0, 24);
            this.lciLastName.Name = "lciLastName";
            this.lciLastName.Size = new System.Drawing.Size(305, 30);
            this.lciLastName.Text = "Soyadı";
            this.lciLastName.TextSize = new System.Drawing.Size(82, 13);
            // 
            // lcgTuslar
            // 
            this.lcgTuslar.CustomizationFormText = "Tuşlar";
            this.lcgTuslar.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciClose,
            this.lciSelect,
            this.lciClean,
            this.lciSearch,
            this.lciNew});
            this.lcgTuslar.Location = new System.Drawing.Point(707, 0);
            this.lcgTuslar.Name = "lcgTuslar";
            this.lcgTuslar.Size = new System.Drawing.Size(227, 102);
            this.lcgTuslar.Text = "Tuşlar";
            this.lcgTuslar.TextVisible = false;
            // 
            // lciClose
            // 
            this.lciClose.Control = this.sbClose;
            this.lciClose.CustomizationFormText = "Çıkış";
            this.lciClose.Location = new System.Drawing.Point(100, 26);
            this.lciClose.Name = "lciClose";
            this.lciClose.Size = new System.Drawing.Size(103, 52);
            this.lciClose.Text = "Çıkış";
            this.lciClose.TextSize = new System.Drawing.Size(0, 0);
            this.lciClose.TextToControlDistance = 0;
            this.lciClose.TextVisible = false;
            // 
            // lciSelect
            // 
            this.lciSelect.Control = this.sbSelect;
            this.lciSelect.CustomizationFormText = "Seç";
            this.lciSelect.Location = new System.Drawing.Point(0, 26);
            this.lciSelect.Name = "lciSelect";
            this.lciSelect.Size = new System.Drawing.Size(100, 26);
            this.lciSelect.Text = "Seç";
            this.lciSelect.TextSize = new System.Drawing.Size(0, 0);
            this.lciSelect.TextToControlDistance = 0;
            this.lciSelect.TextVisible = false;
            // 
            // lciClean
            // 
            this.lciClean.Control = this.sbClean;
            this.lciClean.CustomizationFormText = "Temizle";
            this.lciClean.Location = new System.Drawing.Point(100, 0);
            this.lciClean.Name = "lciClean";
            this.lciClean.Size = new System.Drawing.Size(103, 26);
            this.lciClean.Text = "Temizle";
            this.lciClean.TextSize = new System.Drawing.Size(0, 0);
            this.lciClean.TextToControlDistance = 0;
            this.lciClean.TextVisible = false;
            // 
            // lciSearch
            // 
            this.lciSearch.Control = this.sbSearch;
            this.lciSearch.CustomizationFormText = "Ara";
            this.lciSearch.Location = new System.Drawing.Point(0, 0);
            this.lciSearch.Name = "lciSearch";
            this.lciSearch.Size = new System.Drawing.Size(100, 26);
            this.lciSearch.Text = "Ara";
            this.lciSearch.TextSize = new System.Drawing.Size(0, 0);
            this.lciSearch.TextToControlDistance = 0;
            this.lciSearch.TextVisible = false;
            // 
            // lciNew
            // 
            this.lciNew.Control = this.sbNew;
            this.lciNew.CustomizationFormText = "lciYeni";
            this.lciNew.Location = new System.Drawing.Point(0, 52);
            this.lciNew.Name = "lciNew";
            this.lciNew.Size = new System.Drawing.Size(100, 26);
            this.lciNew.Text = "lciNew";
            this.lciNew.TextSize = new System.Drawing.Size(0, 0);
            this.lciNew.TextToControlDistance = 0;
            this.lciNew.TextVisible = false;
            // 
            // lciPersonelAdeti
            // 
            this.lciPersonelAdeti.Control = this.lcPersonelAdeti;
            this.lciPersonelAdeti.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lciPersonelAdeti.CustomizationFormText = "Personel Adeti";
            this.lciPersonelAdeti.Location = new System.Drawing.Point(0, 601);
            this.lciPersonelAdeti.Name = "lciPersonelAdeti";
            this.lciPersonelAdeti.Size = new System.Drawing.Size(934, 17);
            this.lciPersonelAdeti.Text = "Personel Adeti";
            this.lciPersonelAdeti.TextSize = new System.Drawing.Size(0, 0);
            this.lciPersonelAdeti.TextToControlDistance = 0;
            this.lciPersonelAdeti.TextVisible = false;
            // 
            // PersonelAraForm
            // 
            this.AcceptButton = this.sbSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sbClose;
            this.ClientSize = new System.Drawing.Size(954, 638);
            this.Controls.Add(this.layoutControl1);
            this.Name = "PersonelAraForm";
            this.Text = "Personel Arama Ekranı";
            this.Shown += new System.EventHandler(this.PersonelAraForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePersonelNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTCId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAramaKriterleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpHastaNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPersonelNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTCId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSNR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTuslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPersonelAdeti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcPersonel;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPersonel;
        private DevExpress.XtraEditors.SimpleButton sbSearch;
        private DevExpress.XtraEditors.TextEdit tePersonelNo;
        private DevExpress.XtraEditors.TextEdit teTCId;
        private DevExpress.XtraLayout.LayoutControlGroup lcgSayfa;
        private DevExpress.XtraLayout.LayoutControlItem lciPersonelNo;
        private DevExpress.XtraLayout.LayoutControlItem lciTCId;
        private DevExpress.XtraLayout.LayoutControlItem lciSearch;
        private DevExpress.XtraLayout.LayoutControlItem lciPersonel;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraLayout.LayoutControlGroup grpHastaNo;
        private DevExpress.XtraLayout.LayoutControlGroup lcgAramaKriterleri;
        private DevExpress.XtraLayout.LayoutControlItem lciFirstName;
        private DevExpress.XtraLayout.LayoutControlItem lciLastName;
        private DevExpress.XtraEditors.SimpleButton sbClose;
        private DevExpress.XtraEditors.SimpleButton sbClean;
        private DevExpress.XtraEditors.SimpleButton sbSelect;
        private DevExpress.XtraLayout.LayoutControlGroup grpSNR;
        private DevExpress.XtraLayout.LayoutControlGroup lcgTuslar;
        private DevExpress.XtraLayout.LayoutControlItem lciClose;
        private DevExpress.XtraLayout.LayoutControlItem lciSelect;
        private DevExpress.XtraLayout.LayoutControlItem lciClean;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTCKimlikNo;
        private DevExpress.XtraEditors.LabelControl lcPersonelAdeti;
        private DevExpress.XtraLayout.LayoutControlItem lciPersonelAdeti;
        private DevExpress.XtraEditors.SimpleButton sbNew;
        private DevExpress.XtraLayout.LayoutControlItem lciNew;
        private DevExpress.XtraGrid.Columns.GridColumn colKNR;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}