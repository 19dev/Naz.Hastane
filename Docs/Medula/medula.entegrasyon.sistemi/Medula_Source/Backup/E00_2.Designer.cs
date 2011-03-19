namespace meno
{
    partial class E00_2
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.takipNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hataKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hataMesajiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFaturaHataliKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c00_ds = new meno.AppTables.c00_ds();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.takipNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTeslimNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesaplananTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFaturaBasariliKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFaturaHataliKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c00_ds)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFaturaBasariliKayitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(8, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 327);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hatalý kayýtlar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.takipNoDataGridViewTextBoxColumn,
            this.hataKoduDataGridViewTextBoxColumn,
            this.hataMesajiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblFaturaHataliKayitBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(690, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // takipNoDataGridViewTextBoxColumn
            // 
            this.takipNoDataGridViewTextBoxColumn.DataPropertyName = "takipNo";
            this.takipNoDataGridViewTextBoxColumn.HeaderText = "Takip numarasý";
            this.takipNoDataGridViewTextBoxColumn.Name = "takipNoDataGridViewTextBoxColumn";
            this.takipNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.takipNoDataGridViewTextBoxColumn.Width = 120;
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
            this.hataMesajiDataGridViewTextBoxColumn.Width = 450;
            // 
            // tblFaturaHataliKayitBindingSource
            // 
            this.tblFaturaHataliKayitBindingSource.DataMember = "tblFaturaHataliKayit";
            this.tblFaturaHataliKayitBindingSource.DataSource = this.c00_ds;
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
            this.tabPage2.Text = "Baþarýlý kayýtlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.takipNoDataGridViewTextBoxColumn1,
            this.faturaTeslimNoDataGridViewTextBoxColumn,
            this.hesaplananTutarDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblFaturaBasariliKayitBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(690, 295);
            this.dataGridView2.TabIndex = 0;
            // 
            // takipNoDataGridViewTextBoxColumn1
            // 
            this.takipNoDataGridViewTextBoxColumn1.DataPropertyName = "takipNo";
            this.takipNoDataGridViewTextBoxColumn1.HeaderText = "Takip numarasý";
            this.takipNoDataGridViewTextBoxColumn1.Name = "takipNoDataGridViewTextBoxColumn1";
            this.takipNoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.takipNoDataGridViewTextBoxColumn1.Width = 130;
            // 
            // faturaTeslimNoDataGridViewTextBoxColumn
            // 
            this.faturaTeslimNoDataGridViewTextBoxColumn.DataPropertyName = "faturaTeslimNo";
            this.faturaTeslimNoDataGridViewTextBoxColumn.HeaderText = "Fatura teslim numarasý";
            this.faturaTeslimNoDataGridViewTextBoxColumn.Name = "faturaTeslimNoDataGridViewTextBoxColumn";
            this.faturaTeslimNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.faturaTeslimNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // hesaplananTutarDataGridViewTextBoxColumn
            // 
            this.hesaplananTutarDataGridViewTextBoxColumn.DataPropertyName = "hesaplananTutar";
            this.hesaplananTutarDataGridViewTextBoxColumn.HeaderText = "Fatura için hesaplanan Tutar";
            this.hesaplananTutarDataGridViewTextBoxColumn.Name = "hesaplananTutarDataGridViewTextBoxColumn";
            this.hesaplananTutarDataGridViewTextBoxColumn.ReadOnly = true;
            this.hesaplananTutarDataGridViewTextBoxColumn.Width = 180;
            // 
            // tblFaturaBasariliKayitBindingSource
            // 
            this.tblFaturaBasariliKayitBindingSource.DataMember = "tblFaturaBasariliKayit";
            this.tblFaturaBasariliKayitBindingSource.DataSource = this.c00_ds;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(95, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(443, 48);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sonuç mesajý";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(95, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sonuç kodu";
            // 
            // E00_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "E00_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Bilgisi Sonuç (E00)";
            this.Load += new System.EventHandler(this.E00_2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFaturaHataliKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c00_ds)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFaturaBasariliKayitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tblFaturaHataliKayitBindingSource;
        private meno.AppTables.c00_ds c00_ds;
        private System.Windows.Forms.BindingSource tblFaturaBasariliKayitBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn takipNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hataKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hataMesajiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takipNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTeslimNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesaplananTutarDataGridViewTextBoxColumn;
    }
}