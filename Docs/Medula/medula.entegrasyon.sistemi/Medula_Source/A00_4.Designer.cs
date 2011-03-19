namespace meno
{
    partial class A00_4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.takipNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sevkEdenTesisKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sevkEdenTesisAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sevkEdilenBransKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sevkEdilenBransAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sevkEdilisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblHastaTakipListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c00_ds = new meno.AppTables.c00_ds();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wS_Result3 = new meno.WS_Result();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Text_SaglikTesisKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_KarneNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Text_TCKimlikNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Text_SosyalGuvenlikNo = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaTakipListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c00_ds)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 533);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(852, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hastanin Takiplerini Bul";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(3, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(846, 279);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sonuçlar : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 24;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.takipNoDataGridViewTextBoxColumn,
            this.sevkEdenTesisKoduDataGridViewTextBoxColumn,
            this.sevkEdenTesisAdiDataGridViewTextBoxColumn,
            this.sevkEdilenBransKoduDataGridViewTextBoxColumn,
            this.sevkEdilenBransAdiDataGridViewTextBoxColumn,
            this.sevkEdilisTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblHastaTakipListBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(840, 260);
            this.dataGridView1.TabIndex = 12;
            // 
            // takipNoDataGridViewTextBoxColumn
            // 
            this.takipNoDataGridViewTextBoxColumn.DataPropertyName = "takipNo";
            this.takipNoDataGridViewTextBoxColumn.HeaderText = "Takip numarasý";
            this.takipNoDataGridViewTextBoxColumn.Name = "takipNoDataGridViewTextBoxColumn";
            this.takipNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.takipNoDataGridViewTextBoxColumn.Width = 139;
            // 
            // sevkEdenTesisKoduDataGridViewTextBoxColumn
            // 
            this.sevkEdenTesisKoduDataGridViewTextBoxColumn.DataPropertyName = "sevkEdenTesisKodu";
            this.sevkEdenTesisKoduDataGridViewTextBoxColumn.HeaderText = "Sevk eden tesisin kodu";
            this.sevkEdenTesisKoduDataGridViewTextBoxColumn.Name = "sevkEdenTesisKoduDataGridViewTextBoxColumn";
            this.sevkEdenTesisKoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.sevkEdenTesisKoduDataGridViewTextBoxColumn.Width = 140;
            // 
            // sevkEdenTesisAdiDataGridViewTextBoxColumn
            // 
            this.sevkEdenTesisAdiDataGridViewTextBoxColumn.DataPropertyName = "sevkEdenTesisAdi";
            this.sevkEdenTesisAdiDataGridViewTextBoxColumn.HeaderText = "Sevk eden tesisin adý";
            this.sevkEdenTesisAdiDataGridViewTextBoxColumn.Name = "sevkEdenTesisAdiDataGridViewTextBoxColumn";
            this.sevkEdenTesisAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.sevkEdenTesisAdiDataGridViewTextBoxColumn.Width = 140;
            // 
            // sevkEdilenBransKoduDataGridViewTextBoxColumn
            // 
            this.sevkEdilenBransKoduDataGridViewTextBoxColumn.DataPropertyName = "sevkEdilenBransKodu";
            this.sevkEdilenBransKoduDataGridViewTextBoxColumn.HeaderText = "Sevk edilen branþýn kodu";
            this.sevkEdilenBransKoduDataGridViewTextBoxColumn.Name = "sevkEdilenBransKoduDataGridViewTextBoxColumn";
            this.sevkEdilenBransKoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.sevkEdilenBransKoduDataGridViewTextBoxColumn.Width = 139;
            // 
            // sevkEdilenBransAdiDataGridViewTextBoxColumn
            // 
            this.sevkEdilenBransAdiDataGridViewTextBoxColumn.DataPropertyName = "sevkEdilenBransAdi";
            this.sevkEdilenBransAdiDataGridViewTextBoxColumn.HeaderText = "Sevk edilen branþýn adý";
            this.sevkEdilenBransAdiDataGridViewTextBoxColumn.Name = "sevkEdilenBransAdiDataGridViewTextBoxColumn";
            this.sevkEdilenBransAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.sevkEdilenBransAdiDataGridViewTextBoxColumn.Width = 141;
            // 
            // sevkEdilisTarihiDataGridViewTextBoxColumn
            // 
            this.sevkEdilisTarihiDataGridViewTextBoxColumn.DataPropertyName = "sevkEdilisTarihi";
            this.sevkEdilisTarihiDataGridViewTextBoxColumn.HeaderText = "Sevk ediliþ tarihi";
            this.sevkEdilisTarihiDataGridViewTextBoxColumn.Name = "sevkEdilisTarihiDataGridViewTextBoxColumn";
            this.sevkEdilisTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.sevkEdilisTarihiDataGridViewTextBoxColumn.Width = 140;
            // 
            // tblHastaTakipListBindingSource
            // 
            this.tblHastaTakipListBindingSource.DataMember = "tblHastaTakipList";
            this.tblHastaTakipListBindingSource.DataSource = this.c00_ds;
            // 
            // c00_ds
            // 
            this.c00_ds.DataSetName = "c00_ds";
            this.c00_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wS_Result3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 222);
            this.panel1.TabIndex = 12;
            // 
            // wS_Result3
            // 
            this.wS_Result3.Location = new System.Drawing.Point(328, 6);
            this.wS_Result3.Name = "wS_Result3";
            this.wS_Result3.Size = new System.Drawing.Size(412, 213);
            this.wS_Result3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Text_SaglikTesisKodu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Text_KarneNo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Text_TCKimlikNo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Text_SosyalGuvenlikNo);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Takipleri Sorgulama";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(182, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sorgula";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Saðlýk Tesis Kodu";
            // 
            // Text_SaglikTesisKodu
            // 
            this.Text_SaglikTesisKodu.Location = new System.Drawing.Point(182, 27);
            this.Text_SaglikTesisKodu.Name = "Text_SaglikTesisKodu";
            this.Text_SaglikTesisKodu.Size = new System.Drawing.Size(111, 20);
            this.Text_SaglikTesisKodu.TabIndex = 0;
            this.Text_SaglikTesisKodu.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.label3.Location = new System.Drawing.Point(14, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta Karne Numarasý";
            // 
            // Text_KarneNo
            // 
            this.Text_KarneNo.Location = new System.Drawing.Point(182, 108);
            this.Text_KarneNo.Name = "Text_KarneNo";
            this.Text_KarneNo.Size = new System.Drawing.Size(111, 20);
            this.Text_KarneNo.TabIndex = 3;
            this.Text_KarneNo.Tag = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.label13.Location = new System.Drawing.Point(14, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Hasta TC Kimlik Numarasý";
            // 
            // Text_TCKimlikNo
            // 
            this.Text_TCKimlikNo.Location = new System.Drawing.Point(182, 53);
            this.Text_TCKimlikNo.Name = "Text_TCKimlikNo";
            this.Text_TCKimlikNo.Size = new System.Drawing.Size(111, 20);
            this.Text_TCKimlikNo.TabIndex = 1;
            this.Text_TCKimlikNo.Tag = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(15, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Hasta Sosyal Güvenlik Numarasý";
            // 
            // Text_SosyalGuvenlikNo
            // 
            this.Text_SosyalGuvenlikNo.Location = new System.Drawing.Point(182, 79);
            this.Text_SosyalGuvenlikNo.Name = "Text_SosyalGuvenlikNo";
            this.Text_SosyalGuvenlikNo.Size = new System.Drawing.Size(110, 20);
            this.Text_SosyalGuvenlikNo.TabIndex = 2;
            this.Text_SosyalGuvenlikNo.Tag = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(860, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabel1.Text = "Ýþlem Durumu : ";
            // 
            // A00_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 556);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "A00_4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hak Sahipliði ve Sözleþme Doðrulama -A00 (Provizyon Alma)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaTakipListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c00_ds)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private WS_Result wS_Result3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Text_SaglikTesisKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_KarneNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Text_TCKimlikNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Text_SosyalGuvenlikNo;
        private System.Windows.Forms.BindingSource tblHastaTakipListBindingSource;
        private meno.AppTables.c00_ds c00_ds;
        private System.Windows.Forms.DataGridViewTextBoxColumn takipNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sevkEdenTesisKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sevkEdenTesisAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sevkEdilenBransKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sevkEdilenBransAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sevkEdilisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}