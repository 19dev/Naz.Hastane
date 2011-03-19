namespace meno
{
    partial class F00_3
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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.txttesis_kodu = new System.Windows.Forms.TextBox();
            this.dogra_RaporDVO1 = new meno.WS_RaporDVO();
            this.dogumcls_t1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumSaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCocukBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f00_ds = new meno.AppTables.f00_ds();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCocukBilgisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f00_ds)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabel1.Text = "Ýþlem Durumu : ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(931, 22);
            this.statusStrip1.TabIndex = 55;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Kullanýcý Tesis Kodu";
            // 
            // txttesis_kodu
            // 
            this.txttesis_kodu.Location = new System.Drawing.Point(719, 190);
            this.txttesis_kodu.Name = "txttesis_kodu";
            this.txttesis_kodu.Size = new System.Drawing.Size(134, 20);
            this.txttesis_kodu.TabIndex = 7;
            // 
            // dogra_RaporDVO1
            // 
            this.dogra_RaporDVO1.Location = new System.Drawing.Point(4, 2);
            this.dogra_RaporDVO1.Name = "dogra_RaporDVO1";
            this.dogra_RaporDVO1.Size = new System.Drawing.Size(591, 571);
            this.dogra_RaporDVO1.TabIndex = 0;
            // 
            // dogumcls_t1
            // 
            this.dogumcls_t1.CustomFormat = "dd.MM.yyyy";
            this.dogumcls_t1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dogumcls_t1.Location = new System.Drawing.Point(719, 48);
            this.dogumcls_t1.Name = "dogumcls_t1";
            this.dogumcls_t1.Size = new System.Drawing.Size(89, 20);
            this.dogumcls_t1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Çocuk Sayýsý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Bebek Doðum Tarihi";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(805, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Formu Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(719, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Canlý Çocuk Sayýsý";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(719, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Doðum Tipi";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Normal",
            "Sezaryen",
            "Forseps"});
            this.comboBox1.Location = new System.Drawing.Point(719, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Epizyotemi Mi";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Evet",
            "Hayýr"});
            this.comboBox2.Location = new System.Drawing.Point(719, 141);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Anestezi Tipi";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Genel",
            "Spinal",
            "Epidural",
            "Lokal (Pudental)"});
            this.comboBox3.Location = new System.Drawing.Point(719, 165);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(134, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cinsiyetDataGridViewTextBoxColumn,
            this.kiloDataGridViewTextBoxColumn,
            this.dogumSaatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCocukBilgisiBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystrokeOrF2;
            this.dataGridView1.Location = new System.Drawing.Point(611, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(312, 308);
            this.dataGridView1.TabIndex = 8;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Kýz",
            "Erkek"});
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            this.cinsiyetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cinsiyetDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cinsiyetDataGridViewTextBoxColumn.Width = 80;
            // 
            // kiloDataGridViewTextBoxColumn
            // 
            this.kiloDataGridViewTextBoxColumn.DataPropertyName = "kilo";
            this.kiloDataGridViewTextBoxColumn.HeaderText = "Kilo";
            this.kiloDataGridViewTextBoxColumn.Name = "kiloDataGridViewTextBoxColumn";
            this.kiloDataGridViewTextBoxColumn.Width = 70;
            // 
            // dogumSaatiDataGridViewTextBoxColumn
            // 
            this.dogumSaatiDataGridViewTextBoxColumn.DataPropertyName = "dogumSaati";
            this.dogumSaatiDataGridViewTextBoxColumn.HeaderText = "Doðum Saati";
            this.dogumSaatiDataGridViewTextBoxColumn.Name = "dogumSaatiDataGridViewTextBoxColumn";
            // 
            // tblCocukBilgisiBindingSource
            // 
            this.tblCocukBilgisiBindingSource.DataMember = "tblCocukBilgisi";
            this.tblCocukBilgisiBindingSource.DataSource = this.f00_ds;
            // 
            // f00_ds
            // 
            this.f00_ds.DataSetName = "f00_ds";
            this.f00_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(611, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Çocuk Bilgileri :";
            // 
            // F00_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 598);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttesis_kodu);
            this.Controls.Add(this.dogra_RaporDVO1);
            this.Controls.Add(this.dogumcls_t1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F00_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor Bilgisi Kaydet ( F00 ) - Doðum Raporu";
            this.Load += new System.EventHandler(this.F00_3_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCocukBilgisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f00_ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttesis_kodu;
        private WS_RaporDVO dogra_RaporDVO1;
        private System.Windows.Forms.DateTimePicker dogumcls_t1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumSaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblCocukBilgisiBindingSource;
        private meno.AppTables.f00_ds f00_ds;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;

    }
}