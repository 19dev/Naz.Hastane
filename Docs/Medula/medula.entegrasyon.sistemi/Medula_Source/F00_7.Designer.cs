namespace meno
{
    partial class F00_7
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttesis_kodu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seansSayiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seansGunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refakatVarMiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblTedaviIslemBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f00_ds = new meno.AppTables.f00_ds();
            this.tedavi_RaporDVO1 = new meno.WS_RaporDVO();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTedaviIslemBilgisiBindingSource)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Kullanýcý Tesis Kodu";
            // 
            // txttesis_kodu
            // 
            this.txttesis_kodu.Location = new System.Drawing.Point(720, 70);
            this.txttesis_kodu.Name = "txttesis_kodu";
            this.txttesis_kodu.Size = new System.Drawing.Size(240, 20);
            this.txttesis_kodu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(840, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Formu Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(972, 22);
            this.statusStrip1.TabIndex = 90;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(612, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "Tedavi Ýþlem bilgileri :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.butKoduDataGridViewTextBoxColumn,
            this.seansSayiDataGridViewTextBoxColumn,
            this.seansGunDataGridViewTextBoxColumn,
            this.refakatVarMiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTedaviIslemBilgisiBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystrokeOrF2;
            this.dataGridView1.Location = new System.Drawing.Point(612, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 443);
            this.dataGridView1.TabIndex = 2;
            // 
            // butKoduDataGridViewTextBoxColumn
            // 
            this.butKoduDataGridViewTextBoxColumn.DataPropertyName = "butKodu";
            this.butKoduDataGridViewTextBoxColumn.HeaderText = "BUT iþlem kodu";
            this.butKoduDataGridViewTextBoxColumn.Name = "butKoduDataGridViewTextBoxColumn";
            this.butKoduDataGridViewTextBoxColumn.Width = 120;
            // 
            // seansSayiDataGridViewTextBoxColumn
            // 
            this.seansSayiDataGridViewTextBoxColumn.DataPropertyName = "seansSayi";
            this.seansSayiDataGridViewTextBoxColumn.HeaderText = "Seans Sayý";
            this.seansSayiDataGridViewTextBoxColumn.Name = "seansSayiDataGridViewTextBoxColumn";
            // 
            // seansGunDataGridViewTextBoxColumn
            // 
            this.seansGunDataGridViewTextBoxColumn.DataPropertyName = "seansGun";
            this.seansGunDataGridViewTextBoxColumn.HeaderText = "Seans Gün";
            this.seansGunDataGridViewTextBoxColumn.Name = "seansGunDataGridViewTextBoxColumn";
            // 
            // refakatVarMiDataGridViewTextBoxColumn
            // 
            this.refakatVarMiDataGridViewTextBoxColumn.DataPropertyName = "refakatVarMi";
            this.refakatVarMiDataGridViewTextBoxColumn.HeaderText = "Refakat Var mý";
            this.refakatVarMiDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "E : Evet",
            "H : Hayýr"});
            this.refakatVarMiDataGridViewTextBoxColumn.Name = "refakatVarMiDataGridViewTextBoxColumn";
            this.refakatVarMiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.refakatVarMiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.refakatVarMiDataGridViewTextBoxColumn.Width = 120;
            // 
            // tblTedaviIslemBilgisiBindingSource
            // 
            this.tblTedaviIslemBilgisiBindingSource.DataMember = "tblTedaviIslemBilgisi";
            this.tblTedaviIslemBilgisiBindingSource.DataSource = this.f00_ds;
            // 
            // f00_ds
            // 
            this.f00_ds.DataSetName = "f00_ds";
            this.f00_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tedavi_RaporDVO1
            // 
            this.tedavi_RaporDVO1.Location = new System.Drawing.Point(4, 0);
            this.tedavi_RaporDVO1.Name = "tedavi_RaporDVO1";
            this.tedavi_RaporDVO1.Size = new System.Drawing.Size(591, 571);
            this.tedavi_RaporDVO1.TabIndex = 0;
            // 
            // F00_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttesis_kodu);
            this.Controls.Add(this.tedavi_RaporDVO1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F00_7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor Bilgisi Kaydet ( F00 ) - Tedavi Raporu";
            this.Load += new System.EventHandler(this.F00_7_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTedaviIslemBilgisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f00_ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private meno.AppTables.f00_ds f00_ds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttesis_kodu;
        private WS_RaporDVO tedavi_RaporDVO1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblTedaviIslemBilgisiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn butKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seansSayiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seansGunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn refakatVarMiDataGridViewTextBoxColumn;
    }
}