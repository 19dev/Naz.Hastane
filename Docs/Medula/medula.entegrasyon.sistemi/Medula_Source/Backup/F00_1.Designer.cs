namespace meno
{
    partial class F00_1
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
            this.tblHastaYatisBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f00_ds = new meno.AppTables.f00_ds();
            this.txttesis_kodu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yatisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.isgrm_kontrolTarihi = new System.Windows.Forms.DateTimePicker();
            this.isgrm_kontrolMu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.isgoremelik_RaporDVO = new meno.WS_RaporDVO();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaYatisBilgisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f00_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // txttesis_kodu
            // 
            this.txttesis_kodu.Location = new System.Drawing.Point(722, 56);
            this.txttesis_kodu.Name = "txttesis_kodu";
            this.txttesis_kodu.Size = new System.Drawing.Size(121, 20);
            this.txttesis_kodu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(714, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Formu Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Kullanýcý Tesis Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 46;
            this.label3.Text = "Sigortalýnýn hastanede yatýþý varsa\r\naþaðýki listeyi doldurunuz";
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
            this.dataGridView1.Location = new System.Drawing.Point(607, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(230, 226);
            this.dataGridView1.TabIndex = 4;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Kontrol Tarihi";
            // 
            // isgrm_kontrolTarihi
            // 
            this.isgrm_kontrolTarihi.CustomFormat = "dd.MM.yyyy";
            this.isgrm_kontrolTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.isgrm_kontrolTarihi.Location = new System.Drawing.Point(722, 103);
            this.isgrm_kontrolTarihi.Name = "isgrm_kontrolTarihi";
            this.isgrm_kontrolTarihi.Size = new System.Drawing.Size(84, 20);
            this.isgrm_kontrolTarihi.TabIndex = 3;
            // 
            // isgrm_kontrolMu
            // 
            this.isgrm_kontrolMu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isgrm_kontrolMu.FormattingEnabled = true;
            this.isgrm_kontrolMu.Items.AddRange(new object[] {
            "E : Evet (Kontrol)",
            "H : Hayýr (Ýþ baþý)"});
            this.isgrm_kontrolMu.Location = new System.Drawing.Point(722, 79);
            this.isgrm_kontrolMu.Name = "isgrm_kontrolMu";
            this.isgrm_kontrolMu.Size = new System.Drawing.Size(121, 21);
            this.isgrm_kontrolMu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Kontrol Mu";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(849, 22);
            this.statusStrip1.TabIndex = 49;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabel1.Text = "Ýþlem Durumu : ";
            // 
            // isgoremelik_RaporDVO
            // 
            this.isgoremelik_RaporDVO.Location = new System.Drawing.Point(2, 2);
            this.isgoremelik_RaporDVO.Name = "isgoremelik_RaporDVO";
            this.isgoremelik_RaporDVO.Size = new System.Drawing.Size(591, 571);
            this.isgoremelik_RaporDVO.TabIndex = 0;
            // 
            // F00_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 598);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txttesis_kodu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isgrm_kontrolTarihi);
            this.Controls.Add(this.isgrm_kontrolMu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isgoremelik_RaporDVO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F00_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor Bilgisi Kaydet ( F00 ) - Ýþgöremezlik Raporu";
            this.Load += new System.EventHandler(this.F00_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaYatisBilgisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f00_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblHastaYatisBilgisiBindingSource;
        private meno.AppTables.f00_ds f00_ds;
        private System.Windows.Forms.TextBox txttesis_kodu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker isgrm_kontrolTarihi;
        private System.Windows.Forms.ComboBox isgrm_kontrolMu;
        private System.Windows.Forms.Label label1;
        private WS_RaporDVO isgoremelik_RaporDVO;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yatisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisTarihiDataGridViewTextBoxColumn;
    }
}