namespace meno
{
    partial class F00_5
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
            this.label8 = new System.Windows.Forms.Label();
            this.f00_ds = new meno.AppTables.f00_ds();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.malzemeKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMalzemeBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.txttesis_kodu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.protez_RaporDVO1 = new meno.WS_RaporDVO();
            ((System.ComponentModel.ISupportInitialize)(this.f00_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalzemeBilgisiBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(612, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 85;
            this.label8.Text = "Malzeme Bilgileri :";
            // 
            // f00_ds
            // 
            this.f00_ds.DataSetName = "f00_ds";
            this.f00_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malzemeKoduDataGridViewTextBoxColumn,
            this.malzemeAdiDataGridViewTextBoxColumn,
            this.malzemeTuruDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMalzemeBilgisiBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystrokeOrF2;
            this.dataGridView1.Location = new System.Drawing.Point(612, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(312, 443);
            this.dataGridView1.TabIndex = 2;
            // 
            // malzemeKoduDataGridViewTextBoxColumn
            // 
            this.malzemeKoduDataGridViewTextBoxColumn.DataPropertyName = "malzemeKodu";
            this.malzemeKoduDataGridViewTextBoxColumn.HeaderText = "Malzeme Kodu";
            this.malzemeKoduDataGridViewTextBoxColumn.Name = "malzemeKoduDataGridViewTextBoxColumn";
            this.malzemeKoduDataGridViewTextBoxColumn.Width = 110;
            // 
            // malzemeAdiDataGridViewTextBoxColumn
            // 
            this.malzemeAdiDataGridViewTextBoxColumn.DataPropertyName = "malzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.HeaderText = "Malzeme Adý";
            this.malzemeAdiDataGridViewTextBoxColumn.Name = "malzemeAdiDataGridViewTextBoxColumn";
            // 
            // malzemeTuruDataGridViewTextBoxColumn
            // 
            this.malzemeTuruDataGridViewTextBoxColumn.DataPropertyName = "malzemeTuru";
            this.malzemeTuruDataGridViewTextBoxColumn.HeaderText = "Malzeme Türü";
            this.malzemeTuruDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "1 : BUT kodlu",
            "2 : Emekli Sandýðý Protokol kodlu",
            "3 : kodsuz malzeme"});
            this.malzemeTuruDataGridViewTextBoxColumn.Name = "malzemeTuruDataGridViewTextBoxColumn";
            this.malzemeTuruDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.malzemeTuruDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            // 
            // tblMalzemeBilgisiBindingSource
            // 
            this.tblMalzemeBilgisiBindingSource.DataMember = "tblMalzemeBilgisi";
            this.tblMalzemeBilgisiBindingSource.DataSource = this.f00_ds;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(932, 22);
            this.statusStrip1.TabIndex = 74;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Kullanýcý Tesis Kodu";
            // 
            // txttesis_kodu
            // 
            this.txttesis_kodu.Location = new System.Drawing.Point(720, 71);
            this.txttesis_kodu.Name = "txttesis_kodu";
            this.txttesis_kodu.Size = new System.Drawing.Size(204, 20);
            this.txttesis_kodu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(800, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Formu Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // protez_RaporDVO1
            // 
            this.protez_RaporDVO1.Location = new System.Drawing.Point(4, 1);
            this.protez_RaporDVO1.Name = "protez_RaporDVO1";
            this.protez_RaporDVO1.Size = new System.Drawing.Size(591, 571);
            this.protez_RaporDVO1.TabIndex = 0;
            // 
            // F00_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 596);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttesis_kodu);
            this.Controls.Add(this.protez_RaporDVO1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F00_5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor Bilgisi Kaydet ( F00 ) - Protez Raporu";
            this.Load += new System.EventHandler(this.F00_5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f00_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalzemeBilgisiBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private meno.AppTables.f00_ds f00_ds;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblMalzemeBilgisiBindingSource;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttesis_kodu;
        private WS_RaporDVO protez_RaporDVO1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn malzemeTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
    }
}