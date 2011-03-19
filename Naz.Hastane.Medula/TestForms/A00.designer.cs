namespace Naz.Hastane.Medula.TestForms
{
    partial class A00
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A00));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.provizyonTarihi = new System.Windows.Forms.DateTimePicker();
            this.takipNo = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.takipTuru = new System.Windows.Forms.ComboBox();
            this.provizyonTipi = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.devredilenKurum = new System.Windows.Forms.ComboBox();
            this.sigortaliTuru = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.yakinlikKodu = new System.Windows.Forms.TextBox();
            this.hastaKarneNo = new System.Windows.Forms.TextBox();
            this.hastaSosyalGuvNo = new System.Windows.Forms.TextBox();
            this.saglikTesisKodu = new System.Windows.Forms.TextBox();
            this.hastaTCKimlikNo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.wS_Result1 = new Naz.Hastane.Medula.TestForms.WS_Result();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(502, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.wS_Result1);
            this.tabPage3.Controls.Add(this.provizyonTarihi);
            this.tabPage3.Controls.Add(this.takipNo);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.takipTuru);
            this.tabPage3.Controls.Add(this.provizyonTipi);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.devredilenKurum);
            this.tabPage3.Controls.Add(this.sigortaliTuru);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.yakinlikKodu);
            this.tabPage3.Controls.Add(this.hastaKarneNo);
            this.tabPage3.Controls.Add(this.hastaSosyalGuvNo);
            this.tabPage3.Controls.Add(this.saglikTesisKodu);
            this.tabPage3.Controls.Add(this.hastaTCKimlikNo);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(494, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hasta Kabul";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Hasta T.C. Kimlik";
            this.toolTip1.SetToolTip(this.label1, "Hasta bilgilerini göndermek için ya TC Kimlik Numarasý yada hasta\r\nSosyal Güvenli" +
                    "k numarasý ve karne numarasý gönderilmelidir.");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(8, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 2);
            this.panel1.TabIndex = 32;
            // 
            // provizyonTarihi
            // 
            this.provizyonTarihi.CustomFormat = "dd.MM.yyyy";
            this.provizyonTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.provizyonTarihi.Location = new System.Drawing.Point(353, 34);
            this.provizyonTarihi.Name = "provizyonTarihi";
            this.provizyonTarihi.Size = new System.Drawing.Size(84, 20);
            this.provizyonTarihi.TabIndex = 7;
            // 
            // takipNo
            // 
            this.takipNo.Location = new System.Drawing.Point(353, 105);
            this.takipNo.MaxLength = 8;
            this.takipNo.Name = "takipNo";
            this.takipNo.Size = new System.Drawing.Size(133, 20);
            this.takipNo.TabIndex = 10;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(256, 109);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 13);
            this.label24.TabIndex = 28;
            this.label24.Text = "Takip No";
            this.toolTip1.SetToolTip(this.label24, "Sevk kabulünde, GSS sistemi tarafýndan üretilmiþ olan takip numarasý\r\nkullanýlmal" +
                    "ýdýr.\r\n* Muayene açýlýþ ve rapor ile sevk kabul’de boþ býrakýlmalýdýr. Sevk\r\nkab" +
                    "ulde mutlaka dolu olmalýdýr.");
            // 
            // takipTuru
            // 
            this.takipTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.takipTuru.FormattingEnabled = true;
            this.takipTuru.Items.AddRange(new object[] {
            "Muayene Açýlýþ",
            "Sevk Kabul"});
            this.takipTuru.Location = new System.Drawing.Point(353, 81);
            this.takipTuru.Name = "takipTuru";
            this.takipTuru.Size = new System.Drawing.Size(133, 21);
            this.takipTuru.TabIndex = 9;
            // 
            // provizyonTipi
            // 
            this.provizyonTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provizyonTipi.FormattingEnabled = true;
            this.provizyonTipi.Items.AddRange(new object[] {
            "N-Normal",
            "I-Ýþ Kazasý",
            "A-Acil"});
            this.provizyonTipi.Location = new System.Drawing.Point(353, 57);
            this.provizyonTipi.Name = "provizyonTipi";
            this.provizyonTipi.Size = new System.Drawing.Size(133, 21);
            this.provizyonTipi.TabIndex = 8;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(256, 61);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(78, 13);
            this.label32.TabIndex = 25;
            this.label32.Text = "Provizyon Türü";
            // 
            // devredilenKurum
            // 
            this.devredilenKurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.devredilenKurum.FormattingEnabled = true;
            this.devredilenKurum.Items.AddRange(new object[] {
            "",
            "SSK",
            "Baðkur",
            "emekli Sandýðý",
            "Yeþil Kart",
            "18 yaþ altý ve sosyal güvencesi olmayan",
            "Muhasebat (Çalýþan devlet memurlarý için)",
            "Diðer"});
            this.devredilenKurum.Location = new System.Drawing.Point(353, 10);
            this.devredilenKurum.Name = "devredilenKurum";
            this.devredilenKurum.Size = new System.Drawing.Size(133, 21);
            this.devredilenKurum.TabIndex = 6;
            // 
            // sigortaliTuru
            // 
            this.sigortaliTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sigortaliTuru.FormattingEnabled = true;
            this.sigortaliTuru.Items.AddRange(new object[] {
            "Çalýþan",
            "Emekli",
            "SSK Kurum Personeli",
            "Diðer"});
            this.sigortaliTuru.Location = new System.Drawing.Point(119, 106);
            this.sigortaliTuru.Name = "sigortaliTuru";
            this.sigortaliTuru.Size = new System.Drawing.Size(127, 21);
            this.sigortaliTuru.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(119, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Hasta Kabul";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // yakinlikKodu
            // 
            this.yakinlikKodu.Location = new System.Drawing.Point(119, 130);
            this.yakinlikKodu.MaxLength = 4;
            this.yakinlikKodu.Name = "yakinlikKodu";
            this.yakinlikKodu.Size = new System.Drawing.Size(127, 20);
            this.yakinlikKodu.TabIndex = 5;
            // 
            // hastaKarneNo
            // 
            this.hastaKarneNo.Location = new System.Drawing.Point(119, 83);
            this.hastaKarneNo.MaxLength = 10;
            this.hastaKarneNo.Name = "hastaKarneNo";
            this.hastaKarneNo.Size = new System.Drawing.Size(127, 20);
            this.hastaKarneNo.TabIndex = 3;
            // 
            // hastaSosyalGuvNo
            // 
            this.hastaSosyalGuvNo.Location = new System.Drawing.Point(119, 60);
            this.hastaSosyalGuvNo.MaxLength = 13;
            this.hastaSosyalGuvNo.Name = "hastaSosyalGuvNo";
            this.hastaSosyalGuvNo.Size = new System.Drawing.Size(127, 20);
            this.hastaSosyalGuvNo.TabIndex = 2;
            // 
            // saglikTesisKodu
            // 
            this.saglikTesisKodu.Location = new System.Drawing.Point(119, 37);
            this.saglikTesisKodu.Name = "saglikTesisKodu";
            this.saglikTesisKodu.Size = new System.Drawing.Size(127, 20);
            this.saglikTesisKodu.TabIndex = 1;
            // 
            // hastaTCKimlikNo
            // 
            this.hastaTCKimlikNo.Location = new System.Drawing.Point(119, 14);
            this.hastaTCKimlikNo.MaxLength = 11;
            this.hastaTCKimlikNo.Name = "hastaTCKimlikNo";
            this.hastaTCKimlikNo.Size = new System.Drawing.Size(127, 20);
            this.hastaTCKimlikNo.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(256, 85);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Takip Türü";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(256, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Provizyon Tarihi";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(256, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Devredilen Kurum";
            this.toolTip1.SetToolTip(this.label21, "* sevk kabul (takip türü=2) durumunda boþ býrakýlmalýdýr.");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 134);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Yakýnlýk Kodu";
            this.toolTip1.SetToolTip(this.label20, resources.GetString("label20.ToolTip"));
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 110);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Sigortalý Türü";
            this.toolTip1.SetToolTip(this.label19, "* sevk kabul (takip türü=2) durumunda boþ býrakýlmalýdýr. Diðer\r\ndurumlarda mutla" +
                    "ka dolu olmalýdýr.");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Hasta Karne No";
            this.toolTip1.SetToolTip(this.label18, "* sevk kabul (takip türü=2) durumunda boþ býrakýlmalýdýr.");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Hasta Sos. Güv. No";
            this.toolTip1.SetToolTip(this.label17, resources.GetString("label17.ToolTip"));
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Saðlýk Tesis Kodu";
            this.toolTip1.SetToolTip(this.label16, "Saðlýk tesisinin GSS tarafýndan verilmiþ kodu");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(502, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabel1.Text = "Ýþlem Durumu : ";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 9000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // wS_Result1
            // 
            this.wS_Result1.Location = new System.Drawing.Point(16, 201);
            this.wS_Result1.Name = "wS_Result1";
            this.wS_Result1.Size = new System.Drawing.Size(410, 213);
            this.wS_Result1.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(249, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(17, 20);
            this.button2.TabIndex = 36;
            this.button2.TabStop = false;
            this.button2.Text = "...";
            this.toolTip1.SetToolTip(this.button2, "Yakýnlýk kodlarý için bilgi...");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // A00
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 471);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "A00";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hak Sahipliði ve Sözleþme Doðrulama -A00 (Provizyon Alma)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox yakinlikKodu;
        private System.Windows.Forms.TextBox hastaKarneNo;
        private System.Windows.Forms.TextBox hastaSosyalGuvNo;
        private System.Windows.Forms.TextBox saglikTesisKodu;
        private System.Windows.Forms.TextBox hastaTCKimlikNo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox sigortaliTuru;
        private System.Windows.Forms.ComboBox devredilenKurum;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox provizyonTipi;
        private System.Windows.Forms.ComboBox takipTuru;
        private System.Windows.Forms.TextBox takipNo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker provizyonTarihi;
        private WS_Result wS_Result1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
    }
}

