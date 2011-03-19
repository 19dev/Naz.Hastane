namespace meno
{
    partial class F00_B
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rap_no = new System.Windows.Forms.TextBox();
            this.raporTesisKodu = new System.Windows.Forms.TextBox();
            this.rap_tarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txttesis_kodu = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yatisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblHastaYatisBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f00_ds = new meno.AppTables.f00_ds();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.drTescilNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drBransKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblDoktorBilgisiDVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.taniKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTaniBilgisiDVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaYatisBilgisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f00_ds)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorBilgisiDVOBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaniBilgisiDVOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rap_no);
            this.groupBox1.Controls.Add(this.raporTesisKodu);
            this.groupBox1.Controls.Add(this.rap_tarih);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rapor Bilgisi";
            // 
            // rap_no
            // 
            this.rap_no.Location = new System.Drawing.Point(119, 67);
            this.rap_no.MaxLength = 20;
            this.rap_no.Name = "rap_no";
            this.rap_no.Size = new System.Drawing.Size(167, 20);
            this.rap_no.TabIndex = 2;
            // 
            // raporTesisKodu
            // 
            this.raporTesisKodu.Location = new System.Drawing.Point(119, 21);
            this.raporTesisKodu.Name = "raporTesisKodu";
            this.raporTesisKodu.Size = new System.Drawing.Size(167, 20);
            this.raporTesisKodu.TabIndex = 0;
            // 
            // rap_tarih
            // 
            this.rap_tarih.CustomFormat = "dd.MM.yyyy";
            this.rap_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rap_tarih.Location = new System.Drawing.Point(119, 44);
            this.rap_tarih.Name = "rap_tarih";
            this.rap_tarih.Size = new System.Drawing.Size(100, 20);
            this.rap_tarih.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rapor No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rapor Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rapor Tesis Kodu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bitiþ Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Düzenleme Türü";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Heyet",
            "Tek Hekim"});
            this.comboBox1.Location = new System.Drawing.Point(99, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kontrol Mu";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "E : Evet (Kontrol)",
            "H : Hayýr (Ýþ Baþý)"});
            this.comboBox2.Location = new System.Drawing.Point(99, 164);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kontrol Tarihi";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(99, 188);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Protokol No";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Checked = false;
            this.dateTimePicker3.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(316, 113);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowCheckBox = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker3.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Protokol Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(209, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Açýklama";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 159);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(311, 68);
            this.textBox2.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Kullanýcý Tesis Kodu";
            // 
            // txttesis_kodu
            // 
            this.txttesis_kodu.Location = new System.Drawing.Point(316, 136);
            this.txttesis_kodu.Name = "txttesis_kodu";
            this.txttesis_kodu.Size = new System.Drawing.Size(150, 20);
            this.txttesis_kodu.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(633, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel1.Text = "Ýþlem Durumu :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(8, 259);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 225);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(610, 199);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hasta Yatýþ bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(6, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(363, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Sigortalýnýn hastanede yatýþý varsa aþaðýki listeyi doldurunuz. (Zorunlu Deðil )";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yatisTarihiDataGridViewTextBoxColumn,
            this.cikisTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblHastaYatisBilgisiBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystrokeOrF2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(217, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // yatisTarihiDataGridViewTextBoxColumn
            // 
            this.yatisTarihiDataGridViewTextBoxColumn.DataPropertyName = "yatisTarihi";
            this.yatisTarihiDataGridViewTextBoxColumn.HeaderText = "Yatiþ Tarihi";
            this.yatisTarihiDataGridViewTextBoxColumn.Name = "yatisTarihiDataGridViewTextBoxColumn";
            this.yatisTarihiDataGridViewTextBoxColumn.Width = 80;
            // 
            // cikisTarihiDataGridViewTextBoxColumn
            // 
            this.cikisTarihiDataGridViewTextBoxColumn.DataPropertyName = "cikisTarihi";
            this.cikisTarihiDataGridViewTextBoxColumn.HeaderText = "Çýkýþ Tarihi";
            this.cikisTarihiDataGridViewTextBoxColumn.Name = "cikisTarihiDataGridViewTextBoxColumn";
            this.cikisTarihiDataGridViewTextBoxColumn.Width = 80;
            // 
            // tblHastaYatisBilgisiBindingSource
            // 
            this.tblHastaYatisBilgisiBindingSource.DataMember = "tblHastaYatisBilgisi";
            this.tblHastaYatisBilgisiBindingSource.DataSource = this.f00_ds;
            // 
            // f00_ds
            // 
            this.f00_ds.DataSetName = "f00_ds";
            this.f00_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(610, 199);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doktor bilgileri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drTescilNoDataGridViewTextBoxColumn,
            this.drAdiDataGridViewTextBoxColumn,
            this.drSoyadiDataGridViewTextBoxColumn,
            this.drBransKoduDataGridViewTextBoxColumn,
            this.tipiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblDoktorBilgisiDVOBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystrokeOrF2;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(604, 193);
            this.dataGridView2.TabIndex = 2;
            // 
            // drTescilNoDataGridViewTextBoxColumn
            // 
            this.drTescilNoDataGridViewTextBoxColumn.DataPropertyName = "drTescilNo";
            this.drTescilNoDataGridViewTextBoxColumn.HeaderText = "Dr. Tescil No";
            this.drTescilNoDataGridViewTextBoxColumn.Name = "drTescilNoDataGridViewTextBoxColumn";
            // 
            // drAdiDataGridViewTextBoxColumn
            // 
            this.drAdiDataGridViewTextBoxColumn.DataPropertyName = "drAdi";
            this.drAdiDataGridViewTextBoxColumn.HeaderText = "Adý";
            this.drAdiDataGridViewTextBoxColumn.Name = "drAdiDataGridViewTextBoxColumn";
            // 
            // drSoyadiDataGridViewTextBoxColumn
            // 
            this.drSoyadiDataGridViewTextBoxColumn.DataPropertyName = "drSoyadi";
            this.drSoyadiDataGridViewTextBoxColumn.HeaderText = "Soyadý";
            this.drSoyadiDataGridViewTextBoxColumn.Name = "drSoyadiDataGridViewTextBoxColumn";
            // 
            // drBransKoduDataGridViewTextBoxColumn
            // 
            this.drBransKoduDataGridViewTextBoxColumn.DataPropertyName = "drBransKodu";
            this.drBransKoduDataGridViewTextBoxColumn.HeaderText = "Branþ Kodu";
            this.drBransKoduDataGridViewTextBoxColumn.Name = "drBransKoduDataGridViewTextBoxColumn";
            // 
            // tipiDataGridViewTextBoxColumn
            // 
            this.tipiDataGridViewTextBoxColumn.DataPropertyName = "tipi";
            this.tipiDataGridViewTextBoxColumn.HeaderText = "Tipi";
            this.tipiDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "1 : Raporu Ýsteyen Doktor",
            "2 : Raporu Düzenleyen Doktor"});
            this.tipiDataGridViewTextBoxColumn.Name = "tipiDataGridViewTextBoxColumn";
            this.tipiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tblDoktorBilgisiDVOBindingSource
            // 
            this.tblDoktorBilgisiDVOBindingSource.DataMember = "tblDoktorBilgisiDVO";
            this.tblDoktorBilgisiDVOBindingSource.DataSource = this.f00_ds;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(610, 199);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tani bilgileri";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taniKoduDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.tblTaniBilgisiDVOBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystrokeOrF2;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(604, 193);
            this.dataGridView3.TabIndex = 3;
            // 
            // taniKoduDataGridViewTextBoxColumn
            // 
            this.taniKoduDataGridViewTextBoxColumn.DataPropertyName = "taniKodu";
            this.taniKoduDataGridViewTextBoxColumn.HeaderText = "Taný Kodu";
            this.taniKoduDataGridViewTextBoxColumn.Name = "taniKoduDataGridViewTextBoxColumn";
            // 
            // tblTaniBilgisiDVOBindingSource
            // 
            this.tblTaniBilgisiDVOBindingSource.DataMember = "tblTaniBilgisiDVO";
            this.tblTaniBilgisiDVOBindingSource.DataSource = this.f00_ds;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(535, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F00_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txttesis_kodu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F00_B";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor Uzat";
            this.Load += new System.EventHandler(this.F00_B_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaYatisBilgisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f00_ds)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorBilgisiDVOBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaniBilgisiDVOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rap_no;
        private System.Windows.Forms.TextBox raporTesisKodu;
        private System.Windows.Forms.DateTimePicker rap_tarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttesis_kodu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private meno.AppTables.f00_ds f00_ds;
        private System.Windows.Forms.BindingSource tblHastaYatisBilgisiBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yatisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tblDoktorBilgisiDVOBindingSource;
        private System.Windows.Forms.BindingSource tblTaniBilgisiDVOBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn drTescilNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drBransKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn taniKoduDataGridViewTextBoxColumn;
    }
}