namespace meno
{
    partial class other_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblIllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.other_ds = new meno.AppTables.other_ds();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tesisIlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tesisAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tesisKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tesisSinifKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tesisTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSaglikTesisiListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblIllerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_ds)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaglikTesisiListBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(525, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sorgula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tesis kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tesis adý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tesisin ili";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tesis kodu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tesisin tür kodu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.tblIllerBindingSource;
            this.comboBox1.DisplayMember = "aciklama";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(313, 4);
            this.comboBox1.MaxDropDownItems = 15;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "kod";
            // 
            // tblIllerBindingSource
            // 
            this.tblIllerBindingSource.DataMember = "tblIller";
            this.tblIllerBindingSource.DataSource = this.other_ds;
            // 
            // other_ds
            // 
            this.other_ds.DataSetName = "other_ds";
            this.other_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(313, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(313, 51);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(436, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(17, 20);
            this.button2.TabIndex = 11;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(603, 344);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(595, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bulunan Tesisler";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tesisIlDataGridViewTextBoxColumn,
            this.tesisAdiDataGridViewTextBoxColumn,
            this.tesisKoduDataGridViewTextBoxColumn,
            this.tesisSinifKoduDataGridViewTextBoxColumn,
            this.tesisTuruDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSaglikTesisiListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(585, 248);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // tesisIlDataGridViewTextBoxColumn
            // 
            this.tesisIlDataGridViewTextBoxColumn.DataPropertyName = "tesisIl";
            this.tesisIlDataGridViewTextBoxColumn.HeaderText = "Tesisin ili";
            this.tesisIlDataGridViewTextBoxColumn.Name = "tesisIlDataGridViewTextBoxColumn";
            this.tesisIlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tesisAdiDataGridViewTextBoxColumn
            // 
            this.tesisAdiDataGridViewTextBoxColumn.DataPropertyName = "tesisAdi";
            this.tesisAdiDataGridViewTextBoxColumn.HeaderText = "Tesis adý";
            this.tesisAdiDataGridViewTextBoxColumn.Name = "tesisAdiDataGridViewTextBoxColumn";
            this.tesisAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tesisAdiDataGridViewTextBoxColumn.Width = 160;
            // 
            // tesisKoduDataGridViewTextBoxColumn
            // 
            this.tesisKoduDataGridViewTextBoxColumn.DataPropertyName = "tesisKodu";
            this.tesisKoduDataGridViewTextBoxColumn.HeaderText = "Tesisin kodu";
            this.tesisKoduDataGridViewTextBoxColumn.Name = "tesisKoduDataGridViewTextBoxColumn";
            this.tesisKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tesisSinifKoduDataGridViewTextBoxColumn
            // 
            this.tesisSinifKoduDataGridViewTextBoxColumn.DataPropertyName = "tesisSinifKodu";
            this.tesisSinifKoduDataGridViewTextBoxColumn.HeaderText = "Tesis sýnýf kodu";
            this.tesisSinifKoduDataGridViewTextBoxColumn.Name = "tesisSinifKoduDataGridViewTextBoxColumn";
            this.tesisSinifKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tesisTuruDataGridViewTextBoxColumn
            // 
            this.tesisTuruDataGridViewTextBoxColumn.DataPropertyName = "tesisTuru";
            this.tesisTuruDataGridViewTextBoxColumn.HeaderText = "Tesisin türü";
            this.tesisTuruDataGridViewTextBoxColumn.Name = "tesisTuruDataGridViewTextBoxColumn";
            this.tesisTuruDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblSaglikTesisiListBindingSource
            // 
            this.tblSaglikTesisiListBindingSource.DataMember = "tblSaglikTesisiList";
            this.tblSaglikTesisiListBindingSource.DataSource = this.other_ds;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(109, 29);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(480, 20);
            this.textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(109, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(143, 20);
            this.textBox6.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(7, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 2);
            this.panel1.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Sonuç mesajý";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Sonuç kodu";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(607, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel1.Text = "Ýþlem Durumu :";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(525, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Seç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // other_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 453);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "other_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saðlýk Tesisi Ara";
            this.Load += new System.EventHandler(this.other_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblIllerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_ds)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaglikTesisiListBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tblIllerBindingSource;
        private meno.AppTables.other_ds other_ds;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblSaglikTesisiListBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tesisIlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tesisAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tesisKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tesisSinifKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tesisTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}