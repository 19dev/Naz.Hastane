namespace meno
{
    partial class F00_2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttesis_kodu = new System.Windows.Forms.TextBox();
            this.dogumcls_t2 = new System.Windows.Forms.DateTimePicker();
            this.dogumcls_t1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dogoncb_RaporDVO1 = new meno.WS_RaporDVO();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(598, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Formu Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Kullanýcý Tesis Kodu";
            // 
            // txttesis_kodu
            // 
            this.txttesis_kodu.Location = new System.Drawing.Point(598, 171);
            this.txttesis_kodu.Name = "txttesis_kodu";
            this.txttesis_kodu.Size = new System.Drawing.Size(104, 20);
            this.txttesis_kodu.TabIndex = 3;
            // 
            // dogumcls_t2
            // 
            this.dogumcls_t2.CustomFormat = "dd.MM.yyyy";
            this.dogumcls_t2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dogumcls_t2.Location = new System.Drawing.Point(598, 121);
            this.dogumcls_t2.Name = "dogumcls_t2";
            this.dogumcls_t2.Size = new System.Drawing.Size(104, 20);
            this.dogumcls_t2.TabIndex = 2;
            // 
            // dogumcls_t1
            // 
            this.dogumcls_t1.CustomFormat = "dd.MM.yyyy";
            this.dogumcls_t1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dogumcls_t1.Location = new System.Drawing.Point(598, 74);
            this.dogumcls_t1.Name = "dogumcls_t1";
            this.dogumcls_t1.Size = new System.Drawing.Size(104, 20);
            this.dogumcls_t1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Doðum Ýzni Baþl. Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Bebek Doðum Tarihi";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(723, 22);
            this.statusStrip1.TabIndex = 46;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabel1.Text = "Ýþlem Durumu : ";
            // 
            // dogoncb_RaporDVO1
            // 
            this.dogoncb_RaporDVO1.Location = new System.Drawing.Point(4, 4);
            this.dogoncb_RaporDVO1.Name = "dogoncb_RaporDVO1";
            this.dogoncb_RaporDVO1.Size = new System.Drawing.Size(591, 571);
            this.dogoncb_RaporDVO1.TabIndex = 0;
            // 
            // F00_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 601);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttesis_kodu);
            this.Controls.Add(this.dogoncb_RaporDVO1);
            this.Controls.Add(this.dogumcls_t2);
            this.Controls.Add(this.dogumcls_t1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F00_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor Bilgisi Kaydet ( F00 ) - Doðum Öncesi Çalýþabilir Raporu";
            this.Load += new System.EventHandler(this.F00_2_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttesis_kodu;
        private WS_RaporDVO dogoncb_RaporDVO1;
        private System.Windows.Forms.DateTimePicker dogumcls_t2;
        private System.Windows.Forms.DateTimePicker dogumcls_t1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}