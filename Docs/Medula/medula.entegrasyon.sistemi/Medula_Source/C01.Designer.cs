namespace meno
{
    partial class C01
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemSiraNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemBUTKoduDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblIslemFiyatBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c00_ds = new meno.AppTables.c00_ds();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hataKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hataMesajiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemSiraNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemBUTKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOdemeSorguHataBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.to_takip_no = new System.Windows.Forms.TextBox();
            this.to_tesiskodu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIslemFiyatBilgisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c00_ds)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdemeSorguHataBilgisiBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ýþlem Fiyat Bilgisi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tutarDataGridViewTextBoxColumn,
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn1,
            this.islemSiraNoDataGridViewTextBoxColumn1,
            this.islemBUTKoduDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.tblIslemFiyatBilgisiBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(690, 295);
            this.dataGridView2.TabIndex = 0;
            // 
            // tutarDataGridViewTextBoxColumn
            // 
            this.tutarDataGridViewTextBoxColumn.DataPropertyName = "tutar";
            this.tutarDataGridViewTextBoxColumn.HeaderText = "Ýþlem tutarý";
            this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
            this.tutarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hizmetSunucuRefNoDataGridViewTextBoxColumn1
            // 
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn1.DataPropertyName = "hizmetSunucuRefNo";
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn1.HeaderText = "Hizmet sunucu referans";
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn1.Name = "hizmetSunucuRefNoDataGridViewTextBoxColumn1";
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn1.Width = 160;
            // 
            // islemSiraNoDataGridViewTextBoxColumn1
            // 
            this.islemSiraNoDataGridViewTextBoxColumn1.DataPropertyName = "islemSiraNo";
            this.islemSiraNoDataGridViewTextBoxColumn1.HeaderText = "Ýþlem sýra no";
            this.islemSiraNoDataGridViewTextBoxColumn1.Name = "islemSiraNoDataGridViewTextBoxColumn1";
            this.islemSiraNoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.islemSiraNoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // islemBUTKoduDataGridViewTextBoxColumn1
            // 
            this.islemBUTKoduDataGridViewTextBoxColumn1.DataPropertyName = "islemBUTKodu";
            this.islemBUTKoduDataGridViewTextBoxColumn1.HeaderText = "Ýþlem BUT kodu";
            this.islemBUTKoduDataGridViewTextBoxColumn1.Name = "islemBUTKoduDataGridViewTextBoxColumn1";
            this.islemBUTKoduDataGridViewTextBoxColumn1.ReadOnly = true;
            this.islemBUTKoduDataGridViewTextBoxColumn1.Width = 150;
            // 
            // tblIslemFiyatBilgisiBindingSource
            // 
            this.tblIslemFiyatBilgisiBindingSource.DataMember = "tblIslemFiyatBilgisi";
            this.tblIslemFiyatBilgisiBindingSource.DataSource = this.c00_ds;
            // 
            // c00_ds
            // 
            this.c00_ds.DataSetName = "c00_ds";
            this.c00_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(95, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Durum";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(269, 68);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(441, 48);
            this.textBox2.TabIndex = 13;
            this.textBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sonuç mesajý";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(95, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sonuç kodu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Toplam tutar";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 140);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 327);
            this.tabControl1.TabIndex = 18;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ödeme Sorgu Hata Bilgisi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hataKoduDataGridViewTextBoxColumn,
            this.hataMesajiDataGridViewTextBoxColumn,
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn,
            this.islemSiraNoDataGridViewTextBoxColumn,
            this.islemBUTKoduDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOdemeSorguHataBilgisiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(690, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // hataKoduDataGridViewTextBoxColumn
            // 
            this.hataKoduDataGridViewTextBoxColumn.DataPropertyName = "hataKodu";
            this.hataKoduDataGridViewTextBoxColumn.HeaderText = "Hata kodu";
            this.hataKoduDataGridViewTextBoxColumn.Name = "hataKoduDataGridViewTextBoxColumn";
            this.hataKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hataMesajiDataGridViewTextBoxColumn
            // 
            this.hataMesajiDataGridViewTextBoxColumn.DataPropertyName = "hataMesaji";
            this.hataMesajiDataGridViewTextBoxColumn.HeaderText = "Hata mesajý";
            this.hataMesajiDataGridViewTextBoxColumn.Name = "hataMesajiDataGridViewTextBoxColumn";
            this.hataMesajiDataGridViewTextBoxColumn.ReadOnly = true;
            this.hataMesajiDataGridViewTextBoxColumn.Width = 300;
            // 
            // hizmetSunucuRefNoDataGridViewTextBoxColumn
            // 
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn.DataPropertyName = "hizmetSunucuRefNo";
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn.HeaderText = "Hizmet sunucu referans";
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn.Name = "hizmetSunucuRefNoDataGridViewTextBoxColumn";
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn.Width = 160;
            // 
            // islemSiraNoDataGridViewTextBoxColumn
            // 
            this.islemSiraNoDataGridViewTextBoxColumn.DataPropertyName = "islemSiraNo";
            this.islemSiraNoDataGridViewTextBoxColumn.HeaderText = "Ýþlem sýra no";
            this.islemSiraNoDataGridViewTextBoxColumn.Name = "islemSiraNoDataGridViewTextBoxColumn";
            this.islemSiraNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // islemBUTKoduDataGridViewTextBoxColumn
            // 
            this.islemBUTKoduDataGridViewTextBoxColumn.DataPropertyName = "islemBUTKodu";
            this.islemBUTKoduDataGridViewTextBoxColumn.HeaderText = "Ýþlem BUT kodu";
            this.islemBUTKoduDataGridViewTextBoxColumn.Name = "islemBUTKoduDataGridViewTextBoxColumn";
            this.islemBUTKoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.islemBUTKoduDataGridViewTextBoxColumn.Width = 130;
            // 
            // tblOdemeSorguHataBilgisiBindingSource
            // 
            this.tblOdemeSorguHataBilgisiBindingSource.DataMember = "tblOdemeSorguHataBilgisi";
            this.tblOdemeSorguHataBilgisiBindingSource.DataSource = this.c00_ds;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(95, 99);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(139, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.TabStop = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(408, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Ödeme Durum Kontrol";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // to_takip_no
            // 
            this.to_takip_no.Location = new System.Drawing.Point(292, 12);
            this.to_takip_no.Name = "to_takip_no";
            this.to_takip_no.Size = new System.Drawing.Size(100, 20);
            this.to_takip_no.TabIndex = 1;
            // 
            // to_tesiskodu
            // 
            this.to_tesiskodu.Location = new System.Drawing.Point(109, 12);
            this.to_tesiskodu.Name = "to_tesiskodu";
            this.to_tesiskodu.Size = new System.Drawing.Size(100, 20);
            this.to_tesiskodu.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Takip No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Saðlýk Tesis Kodu";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(720, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabel1.Text = "Ýþlem Durumu : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(8, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 2);
            this.panel1.TabIndex = 34;
            // 
            // C01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.to_takip_no);
            this.Controls.Add(this.to_tesiskodu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "C01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Durum Kontrol (C01)";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIslemFiyatBilgisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c00_ds)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdemeSorguHataBilgisiBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblOdemeSorguHataBilgisiBindingSource;
        private meno.AppTables.c00_ds c00_ds;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hizmetSunucuRefNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemSiraNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemBUTKoduDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource tblIslemFiyatBilgisiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn hizmetSunucuRefNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemSiraNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemBUTKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn hataKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hataMesajiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox to_takip_no;
        private System.Windows.Forms.TextBox to_tesiskodu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}