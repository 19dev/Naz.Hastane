using Naz.Hastane.Data.Entities;
namespace Naz.Hastane.Win.MDIChildForms
{
    partial class AmeliyatListeEditForm
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
            this.teBitisSaati = new DevExpress.XtraEditors.TimeEdit();
            this.teBaslangicSaati = new DevExpress.XtraEditors.TimeEdit();
            this.teAmeliyatAdi = new DevExpress.XtraEditors.TextEdit();
            this.teDoktor = new DevExpress.XtraEditors.TextEdit();
            this.teHasta = new DevExpress.XtraEditors.TextEdit();
            this.teOda = new DevExpress.XtraEditors.TextEdit();
            this.sbSaveAndNew = new DevExpress.XtraEditors.SimpleButton();
            this.deTarih = new DevExpress.XtraEditors.DateEdit();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.sbSaveAndClose = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciSaveAndClose = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciDurum = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSaveAndNew = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciOda = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHasta = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDoktor = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAmeliyatAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTarih = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBaslangicSaati = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBitisSaati = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teBitisSaati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBaslangicSaati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAmeliyatAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDoktor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTarih.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveAndClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveAndNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAmeliyatAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBaslangicSaati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBitisSaati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.teBitisSaati);
            this.layoutControl1.Controls.Add(this.teBaslangicSaati);
            this.layoutControl1.Controls.Add(this.teAmeliyatAdi);
            this.layoutControl1.Controls.Add(this.teDoktor);
            this.layoutControl1.Controls.Add(this.teHasta);
            this.layoutControl1.Controls.Add(this.teOda);
            this.layoutControl1.Controls.Add(this.sbSaveAndNew);
            this.layoutControl1.Controls.Add(this.deTarih);
            this.layoutControl1.Controls.Add(this.cmbDurum);
            this.layoutControl1.Controls.Add(this.sbSaveAndClose);
            this.layoutControl1.Controls.Add(this.sbCancel);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(395, 233);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // teBitisSaati
            // 
            this.teBitisSaati.EditValue = new System.DateTime(2011, 10, 11, 0, 0, 0, 0);
            this.teBitisSaati.Location = new System.Drawing.Point(87, 181);
            this.teBitisSaati.Name = "teBitisSaati";
            this.teBitisSaati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.teBitisSaati.Size = new System.Drawing.Size(150, 20);
            this.teBitisSaati.StyleController = this.layoutControl1;
            this.teBitisSaati.TabIndex = 19;
            // 
            // teBaslangicSaati
            // 
            this.teBaslangicSaati.EditValue = new System.DateTime(2011, 10, 11, 0, 0, 0, 0);
            this.teBaslangicSaati.Location = new System.Drawing.Point(87, 157);
            this.teBaslangicSaati.Name = "teBaslangicSaati";
            this.teBaslangicSaati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.teBaslangicSaati.Size = new System.Drawing.Size(150, 20);
            this.teBaslangicSaati.StyleController = this.layoutControl1;
            this.teBaslangicSaati.TabIndex = 18;
            // 
            // teAmeliyatAdi
            // 
            this.teAmeliyatAdi.Location = new System.Drawing.Point(87, 108);
            this.teAmeliyatAdi.Name = "teAmeliyatAdi";
            this.teAmeliyatAdi.Size = new System.Drawing.Size(150, 20);
            this.teAmeliyatAdi.StyleController = this.layoutControl1;
            this.teAmeliyatAdi.TabIndex = 17;
            // 
            // teDoktor
            // 
            this.teDoktor.Location = new System.Drawing.Point(87, 84);
            this.teDoktor.Name = "teDoktor";
            this.teDoktor.Size = new System.Drawing.Size(150, 20);
            this.teDoktor.StyleController = this.layoutControl1;
            this.teDoktor.TabIndex = 16;
            // 
            // teHasta
            // 
            this.teHasta.Location = new System.Drawing.Point(87, 60);
            this.teHasta.Name = "teHasta";
            this.teHasta.Size = new System.Drawing.Size(150, 20);
            this.teHasta.StyleController = this.layoutControl1;
            this.teHasta.TabIndex = 15;
            // 
            // teOda
            // 
            this.teOda.Location = new System.Drawing.Point(87, 36);
            this.teOda.Name = "teOda";
            this.teOda.Size = new System.Drawing.Size(150, 20);
            this.teOda.StyleController = this.layoutControl1;
            this.teOda.TabIndex = 14;
            // 
            // sbSaveAndNew
            // 
            this.sbSaveAndNew.Location = new System.Drawing.Point(241, 49);
            this.sbSaveAndNew.Name = "sbSaveAndNew";
            this.sbSaveAndNew.Size = new System.Drawing.Size(142, 22);
            this.sbSaveAndNew.StyleController = this.layoutControl1;
            this.sbSaveAndNew.TabIndex = 13;
            this.sbSaveAndNew.Text = "Sakla ve Yeni Kayıt";
            // 
            // deTarih
            // 
            this.deTarih.EditValue = null;
            this.deTarih.Location = new System.Drawing.Point(87, 12);
            this.deTarih.Name = "deTarih";
            this.deTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTarih.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deTarih.Size = new System.Drawing.Size(150, 20);
            this.deTarih.StyleController = this.layoutControl1;
            this.deTarih.TabIndex = 11;
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(87, 132);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(150, 21);
            this.cmbDurum.Sorted = true;
            this.cmbDurum.TabIndex = 10;
            // 
            // sbSaveAndClose
            // 
            this.sbSaveAndClose.Location = new System.Drawing.Point(241, 93);
            this.sbSaveAndClose.Name = "sbSaveAndClose";
            this.sbSaveAndClose.Size = new System.Drawing.Size(142, 22);
            this.sbSaveAndClose.StyleController = this.layoutControl1;
            this.sbSaveAndClose.TabIndex = 9;
            this.sbSaveAndClose.Text = "Sakla ve Kapat";
            // 
            // sbCancel
            // 
            this.sbCancel.Location = new System.Drawing.Point(241, 199);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(142, 22);
            this.sbCancel.StyleController = this.layoutControl1;
            this.sbCancel.TabIndex = 6;
            this.sbCancel.Text = "Vazgeç";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSaveAndClose,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.lciDurum,
            this.lciCancel,
            this.lciSaveAndNew,
            this.lciOda,
            this.lciHasta,
            this.lciDoktor,
            this.lciAmeliyatAdi,
            this.lciTarih,
            this.lciBaslangicSaati,
            this.lciBitisSaati,
            this.emptySpaceItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(395, 233);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciSaveAndClose
            // 
            this.lciSaveAndClose.Control = this.sbSaveAndClose;
            this.lciSaveAndClose.CustomizationFormText = "layoutControlItem6";
            this.lciSaveAndClose.Location = new System.Drawing.Point(229, 81);
            this.lciSaveAndClose.Name = "lciSaveAndClose";
            this.lciSaveAndClose.Size = new System.Drawing.Size(146, 26);
            this.lciSaveAndClose.Text = "lciSaveAndClose";
            this.lciSaveAndClose.TextSize = new System.Drawing.Size(0, 0);
            this.lciSaveAndClose.TextToControlDistance = 0;
            this.lciSaveAndClose.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(229, 63);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(146, 18);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(229, 107);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(146, 80);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(229, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(146, 37);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciDurum
            // 
            this.lciDurum.Control = this.cmbDurum;
            this.lciDurum.CustomizationFormText = "Durum";
            this.lciDurum.Location = new System.Drawing.Point(0, 120);
            this.lciDurum.Name = "lciDurum";
            this.lciDurum.Size = new System.Drawing.Size(229, 25);
            this.lciDurum.Text = "Durum";
            this.lciDurum.TextSize = new System.Drawing.Size(71, 13);
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.sbCancel;
            this.lciCancel.CustomizationFormText = "layoutControlItem3";
            this.lciCancel.Location = new System.Drawing.Point(229, 187);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.Size = new System.Drawing.Size(146, 26);
            this.lciCancel.Text = "lciCancel";
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextToControlDistance = 0;
            this.lciCancel.TextVisible = false;
            // 
            // lciSaveAndNew
            // 
            this.lciSaveAndNew.Control = this.sbSaveAndNew;
            this.lciSaveAndNew.CustomizationFormText = "lciSaveAndNew";
            this.lciSaveAndNew.Location = new System.Drawing.Point(229, 37);
            this.lciSaveAndNew.Name = "lciSaveAndNew";
            this.lciSaveAndNew.Size = new System.Drawing.Size(146, 26);
            this.lciSaveAndNew.Text = "lciSaveAndNew";
            this.lciSaveAndNew.TextSize = new System.Drawing.Size(0, 0);
            this.lciSaveAndNew.TextToControlDistance = 0;
            this.lciSaveAndNew.TextVisible = false;
            // 
            // lciOda
            // 
            this.lciOda.Control = this.teOda;
            this.lciOda.CustomizationFormText = "layoutControlItem1";
            this.lciOda.Location = new System.Drawing.Point(0, 24);
            this.lciOda.Name = "lciOda";
            this.lciOda.Size = new System.Drawing.Size(229, 24);
            this.lciOda.Text = "Oda";
            this.lciOda.TextSize = new System.Drawing.Size(71, 13);
            // 
            // lciHasta
            // 
            this.lciHasta.Control = this.teHasta;
            this.lciHasta.CustomizationFormText = "Hasta";
            this.lciHasta.Location = new System.Drawing.Point(0, 48);
            this.lciHasta.Name = "lciHasta";
            this.lciHasta.Size = new System.Drawing.Size(229, 24);
            this.lciHasta.Text = "Hasta";
            this.lciHasta.TextSize = new System.Drawing.Size(71, 13);
            // 
            // lciDoktor
            // 
            this.lciDoktor.Control = this.teDoktor;
            this.lciDoktor.CustomizationFormText = "Doktor";
            this.lciDoktor.Location = new System.Drawing.Point(0, 72);
            this.lciDoktor.Name = "lciDoktor";
            this.lciDoktor.Size = new System.Drawing.Size(229, 24);
            this.lciDoktor.Text = "Doktor";
            this.lciDoktor.TextSize = new System.Drawing.Size(71, 13);
            // 
            // lciAmeliyatAdi
            // 
            this.lciAmeliyatAdi.Control = this.teAmeliyatAdi;
            this.lciAmeliyatAdi.CustomizationFormText = "Ameliyat Adı";
            this.lciAmeliyatAdi.Location = new System.Drawing.Point(0, 96);
            this.lciAmeliyatAdi.Name = "lciAmeliyatAdi";
            this.lciAmeliyatAdi.Size = new System.Drawing.Size(229, 24);
            this.lciAmeliyatAdi.Text = "Ameliyat Adı";
            this.lciAmeliyatAdi.TextSize = new System.Drawing.Size(71, 13);
            // 
            // lciTarih
            // 
            this.lciTarih.Control = this.deTarih;
            this.lciTarih.CustomizationFormText = "Tarih";
            this.lciTarih.Location = new System.Drawing.Point(0, 0);
            this.lciTarih.Name = "lciTarih";
            this.lciTarih.Size = new System.Drawing.Size(229, 24);
            this.lciTarih.Text = "Tarih";
            this.lciTarih.TextSize = new System.Drawing.Size(71, 13);
            // 
            // lciBaslangicSaati
            // 
            this.lciBaslangicSaati.Control = this.teBaslangicSaati;
            this.lciBaslangicSaati.CustomizationFormText = "Başlangıç Saati";
            this.lciBaslangicSaati.Location = new System.Drawing.Point(0, 145);
            this.lciBaslangicSaati.Name = "lciBaslangicSaati";
            this.lciBaslangicSaati.Size = new System.Drawing.Size(229, 24);
            this.lciBaslangicSaati.Text = "Başlangıç Saati";
            this.lciBaslangicSaati.TextSize = new System.Drawing.Size(71, 13);
            // 
            // lciBitisSaati
            // 
            this.lciBitisSaati.Control = this.teBitisSaati;
            this.lciBitisSaati.CustomizationFormText = "Bitiş Saati";
            this.lciBitisSaati.Location = new System.Drawing.Point(0, 169);
            this.lciBitisSaati.Name = "lciBitisSaati";
            this.lciBitisSaati.Size = new System.Drawing.Size(229, 24);
            this.lciBitisSaati.Text = "Bitiş Saati";
            this.lciBitisSaati.TextSize = new System.Drawing.Size(71, 13);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 193);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(229, 20);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // AmeliyatListeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 233);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AmeliyatListeEditForm";
            this.Text = "Personel Ünvan Giriş Formu";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teBitisSaati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBaslangicSaati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAmeliyatAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDoktor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTarih.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveAndClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveAndNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAmeliyatAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBaslangicSaati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBitisSaati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton sbSaveAndClose;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraLayout.LayoutControlItem lciCancel;
        private DevExpress.XtraLayout.LayoutControlItem lciSaveAndClose;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.DateEdit deTarih;
        private DevExpress.XtraLayout.LayoutControlItem lciTarih;
        private DevExpress.XtraEditors.SimpleButton sbSaveAndNew;
        private DevExpress.XtraLayout.LayoutControlItem lciSaveAndNew;
        private DevExpress.XtraEditors.TimeEdit teBitisSaati;
        private DevExpress.XtraEditors.TimeEdit teBaslangicSaati;
        private DevExpress.XtraEditors.TextEdit teAmeliyatAdi;
        private DevExpress.XtraEditors.TextEdit teDoktor;
        private DevExpress.XtraEditors.TextEdit teHasta;
        private DevExpress.XtraEditors.TextEdit teOda;
        private System.Windows.Forms.ComboBox cmbDurum;
        private DevExpress.XtraLayout.LayoutControlItem lciDurum;
        private DevExpress.XtraLayout.LayoutControlItem lciOda;
        private DevExpress.XtraLayout.LayoutControlItem lciHasta;
        private DevExpress.XtraLayout.LayoutControlItem lciDoktor;
        private DevExpress.XtraLayout.LayoutControlItem lciAmeliyatAdi;
        private DevExpress.XtraLayout.LayoutControlItem lciBaslangicSaati;
        private DevExpress.XtraLayout.LayoutControlItem lciBitisSaati;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
    }
}