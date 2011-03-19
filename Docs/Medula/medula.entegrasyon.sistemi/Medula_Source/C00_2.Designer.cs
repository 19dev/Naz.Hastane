namespace meno
{
    partial class C00_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hataKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hataMesajiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemSiraNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemBUTKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOdemeSorguHataBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c00_ds = new meno.AppTables.c00_ds();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hizmetSunucuRefNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemSiraNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemBUTKoduDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblIslemFiyatBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdemeSorguHataBilgisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c00_ds)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIslemFiyatBilgisiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sonuç kodu";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(99, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sonuç mesajý";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(273, 25);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(443, 48);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Durum";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(99, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toplam tutar";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(99, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(139, 20);
            this.textBox4.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 327);
            this.tabControl1.TabIndex = 4;
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
            // c00_ds
            // 
            this.c00_ds.DataSetName = "c00_ds";
            this.c00_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // C00_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "C00_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Sorgulama Sonuç";
            this.Load += new System.EventHandler(this.C00_2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdemeSorguHataBilgisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c00_ds)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIslemFiyatBilgisiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblOdemeSorguHataBilgisiBindingSource;
        private meno.AppTables.c00_ds c00_ds;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tblIslemFiyatBilgisiBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hataKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hataMesajiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hizmetSunucuRefNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemSiraNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemBUTKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hizmetSunucuRefNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemSiraNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemBUTKoduDataGridViewTextBoxColumn1;
    }
}