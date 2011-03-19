namespace meno
{
    partial class frmtesisler
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
            this.label3 = new System.Windows.Forms.Label();
            this.cb_iller = new System.Windows.Forms.ComboBox();
            this.stillerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.other_ds = new meno.AppTables.other_ds();
            this.cb_tesisturu = new System.Windows.Forms.ComboBox();
            this.sttesisturleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_kamoz = new System.Windows.Forms.ComboBox();
            this.stkamuozelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txttesisadi = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mn1x = new System.Windows.Forms.ToolStripMenuItem();
            this.mn2x = new System.Windows.Forms.ToolStripMenuItem();
            this.mn3x = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kODUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNVANIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttesislerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stillerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sttesisturleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stkamuozelBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sttesislerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ýl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tesis Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kamu/Özel";
            // 
            // cb_iller
            // 
            this.cb_iller.DataSource = this.stillerBindingSource;
            this.cb_iller.DisplayMember = "aciklama";
            this.cb_iller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_iller.FormattingEnabled = true;
            this.cb_iller.Location = new System.Drawing.Point(74, 9);
            this.cb_iller.MaxDropDownItems = 15;
            this.cb_iller.Name = "cb_iller";
            this.cb_iller.Size = new System.Drawing.Size(253, 21);
            this.cb_iller.TabIndex = 0;
            this.cb_iller.ValueMember = "rid";
            // 
            // stillerBindingSource
            // 
            this.stillerBindingSource.DataMember = "st_iller";
            this.stillerBindingSource.DataSource = this.other_ds;
            // 
            // other_ds
            // 
            this.other_ds.DataSetName = "other_ds";
            this.other_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_tesisturu
            // 
            this.cb_tesisturu.DataSource = this.sttesisturleriBindingSource;
            this.cb_tesisturu.DisplayMember = "aciklama";
            this.cb_tesisturu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tesisturu.FormattingEnabled = true;
            this.cb_tesisturu.Location = new System.Drawing.Point(74, 33);
            this.cb_tesisturu.MaxDropDownItems = 15;
            this.cb_tesisturu.Name = "cb_tesisturu";
            this.cb_tesisturu.Size = new System.Drawing.Size(253, 21);
            this.cb_tesisturu.TabIndex = 1;
            this.cb_tesisturu.ValueMember = "rid";
            // 
            // sttesisturleriBindingSource
            // 
            this.sttesisturleriBindingSource.DataMember = "st_tesis_turleri";
            this.sttesisturleriBindingSource.DataSource = this.other_ds;
            // 
            // cb_kamoz
            // 
            this.cb_kamoz.DataSource = this.stkamuozelBindingSource;
            this.cb_kamoz.DisplayMember = "aciklama";
            this.cb_kamoz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_kamoz.FormattingEnabled = true;
            this.cb_kamoz.Location = new System.Drawing.Point(402, 9);
            this.cb_kamoz.MaxDropDownItems = 15;
            this.cb_kamoz.Name = "cb_kamoz";
            this.cb_kamoz.Size = new System.Drawing.Size(209, 21);
            this.cb_kamoz.TabIndex = 2;
            this.cb_kamoz.ValueMember = "rid";
            // 
            // stkamuozelBindingSource
            // 
            this.stkamuozelBindingSource.DataMember = "st_kamu_ozel";
            this.stkamuozelBindingSource.DataSource = this.other_ds;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tesis Adý";
            // 
            // txttesisadi
            // 
            this.txttesisadi.ContextMenuStrip = this.contextMenuStrip1;
            this.txttesisadi.Location = new System.Drawing.Point(402, 33);
            this.txttesisadi.Name = "txttesisadi";
            this.txttesisadi.Size = new System.Drawing.Size(209, 20);
            this.txttesisadi.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn1x,
            this.mn2x,
            this.mn3x});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 70);
            // 
            // mn1x
            // 
            this.mn1x.Checked = true;
            this.mn1x.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mn1x.Name = "mn1x";
            this.mn1x.Size = new System.Drawing.Size(153, 22);
            this.mn1x.Text = "ile baþlayanlar";
            this.mn1x.Click += new System.EventHandler(this.mn1x_Click);
            // 
            // mn2x
            // 
            this.mn2x.Name = "mn2x";
            this.mn2x.Size = new System.Drawing.Size(153, 22);
            this.mn2x.Text = "içerisinde ara";
            this.mn2x.Click += new System.EventHandler(this.mn1x_Click);
            // 
            // mn3x
            // 
            this.mn3x.Name = "mn3x";
            this.mn3x.Size = new System.Drawing.Size(153, 22);
            this.mn3x.Text = "eþittir";
            this.mn3x.Click += new System.EventHandler(this.mn1x_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kODUDataGridViewTextBoxColumn,
            this.aDIDataGridViewTextBoxColumn,
            this.uNVANIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sttesislerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(723, 318);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // kODUDataGridViewTextBoxColumn
            // 
            this.kODUDataGridViewTextBoxColumn.DataPropertyName = "KODU";
            this.kODUDataGridViewTextBoxColumn.HeaderText = "Tesis Kodu";
            this.kODUDataGridViewTextBoxColumn.Name = "kODUDataGridViewTextBoxColumn";
            this.kODUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDIDataGridViewTextBoxColumn
            // 
            this.aDIDataGridViewTextBoxColumn.DataPropertyName = "ADI";
            this.aDIDataGridViewTextBoxColumn.HeaderText = "Tesis Adý";
            this.aDIDataGridViewTextBoxColumn.Name = "aDIDataGridViewTextBoxColumn";
            this.aDIDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDIDataGridViewTextBoxColumn.Width = 300;
            // 
            // uNVANIDataGridViewTextBoxColumn
            // 
            this.uNVANIDataGridViewTextBoxColumn.DataPropertyName = "UNVANI";
            this.uNVANIDataGridViewTextBoxColumn.HeaderText = "Tesis Ünvaný";
            this.uNVANIDataGridViewTextBoxColumn.Name = "uNVANIDataGridViewTextBoxColumn";
            this.uNVANIDataGridViewTextBoxColumn.ReadOnly = true;
            this.uNVANIDataGridViewTextBoxColumn.Width = 300;
            // 
            // sttesislerBindingSource
            // 
            this.sttesislerBindingSource.DataMember = "st_tesisler";
            this.sttesislerBindingSource.DataSource = this.other_ds;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(660, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sorgula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(660, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmtesisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 398);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttesisadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_kamoz);
            this.Controls.Add(this.cb_tesisturu);
            this.Controls.Add(this.cb_iller);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmtesisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tesisler & Tesis Türleri";
            this.Load += new System.EventHandler(this.frmtesisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stillerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sttesisturleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stkamuozelBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sttesislerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_iller;
        private System.Windows.Forms.ComboBox cb_tesisturu;
        private System.Windows.Forms.ComboBox cb_kamoz;
        private System.Windows.Forms.BindingSource stillerBindingSource;
        private meno.AppTables.other_ds other_ds;
        private System.Windows.Forms.BindingSource sttesisturleriBindingSource;
        private System.Windows.Forms.BindingSource stkamuozelBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttesisadi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sttesislerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn kODUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNVANIDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mn1x;
        private System.Windows.Forms.ToolStripMenuItem mn2x;
        private System.Windows.Forms.ToolStripMenuItem mn3x;
        private System.Windows.Forms.Button button2;
    }
}