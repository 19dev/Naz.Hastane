namespace meno
{
    partial class E00
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.takipNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFaturaBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c00_ds = new meno.AppTables.c00_ds();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFaturaBilgisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c00_ds)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tesis kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fatura kurum kodu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(5, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 279);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fatura Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 24;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.takipNoDataGridViewTextBoxColumn,
            this.faturaNoDataGridViewTextBoxColumn,
            this.faturaTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblFaturaBilgisiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(371, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // takipNoDataGridViewTextBoxColumn
            // 
            this.takipNoDataGridViewTextBoxColumn.DataPropertyName = "takipNo";
            this.takipNoDataGridViewTextBoxColumn.HeaderText = "Takip No";
            this.takipNoDataGridViewTextBoxColumn.Name = "takipNoDataGridViewTextBoxColumn";
            // 
            // faturaNoDataGridViewTextBoxColumn
            // 
            this.faturaNoDataGridViewTextBoxColumn.DataPropertyName = "faturaNo";
            this.faturaNoDataGridViewTextBoxColumn.HeaderText = "Fatura No";
            this.faturaNoDataGridViewTextBoxColumn.Name = "faturaNoDataGridViewTextBoxColumn";
            // 
            // faturaTarihiDataGridViewTextBoxColumn
            // 
            this.faturaTarihiDataGridViewTextBoxColumn.DataPropertyName = "faturaTarihi";
            this.faturaTarihiDataGridViewTextBoxColumn.HeaderText = "Fatura Tarihi";
            this.faturaTarihiDataGridViewTextBoxColumn.Name = "faturaTarihiDataGridViewTextBoxColumn";
            // 
            // tblFaturaBilgisiBindingSource
            // 
            this.tblFaturaBilgisiBindingSource.DataMember = "tblFaturaBilgisi";
            this.tblFaturaBilgisiBindingSource.DataSource = this.c00_ds;
            // 
            // c00_ds
            // 
            this.c00_ds.DataSetName = "c00_ds";
            this.c00_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(387, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel1.Text = "Ýþlem Durumu :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(288, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 : GSS",
            "2 : SSK",
            "3 : Emekli Sandýðý",
            "4 : Baðkur",
            "5 : Yeþil Kart",
            "6 : Muhasebat"});
            this.comboBox1.Location = new System.Drawing.Point(109, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // E00
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 383);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "E00";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Bilgisi Kayýt (E00)";
            this.Load += new System.EventHandler(this.E00_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFaturaBilgisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c00_ds)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblFaturaBilgisiBindingSource;
        private meno.AppTables.c00_ds c00_ds;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn takipNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}