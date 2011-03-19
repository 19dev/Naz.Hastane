namespace meno
{
    partial class A00_3
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wS_Result21 = new meno.WS_Result2();
            this.button5 = new System.Windows.Forms.Button();
            this.to_takip_no = new System.Windows.Forms.TextBox();
            this.to_tesiskodu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel1);
            this.tabPage5.Controls.Add(this.wS_Result21);
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.to_takip_no);
            this.tabPage5.Controls.Add(this.to_tesiskodu);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(543, 379);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Takip Oku";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(11, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 2);
            this.panel1.TabIndex = 33;
            // 
            // wS_Result21
            // 
            this.wS_Result21.Location = new System.Drawing.Point(8, 55);
            this.wS_Result21.Name = "wS_Result21";
            this.wS_Result21.Size = new System.Drawing.Size(528, 318);
            this.wS_Result21.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(406, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Takip Oku";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // to_takip_no
            // 
            this.to_takip_no.Location = new System.Drawing.Point(290, 9);
            this.to_takip_no.Name = "to_takip_no";
            this.to_takip_no.Size = new System.Drawing.Size(100, 20);
            this.to_takip_no.TabIndex = 1;
            // 
            // to_tesiskodu
            // 
            this.to_tesiskodu.Location = new System.Drawing.Point(107, 9);
            this.to_tesiskodu.Name = "to_tesiskodu";
            this.to_tesiskodu.Size = new System.Drawing.Size(100, 20);
            this.to_tesiskodu.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Takip No";
            this.toolTip1.SetToolTip(this.label7, "Detay bilgileri sorgulanmak isteyen takibin numarasý. Tesis sadece\r\nkendi takip n" +
                    "umaralarýný sorgulayabilecektir.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Saðlýk Tesis Kodu";
            this.toolTip1.SetToolTip(this.label6, "Saðlýk tesisinin GSS tarafýndan verilmiþ kodu");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(551, 22);
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
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 9000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // A00_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 429);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "A00_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hak Sahipliði ve Sözleþme Doðrulama -A00 (Provizyon Alma)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private WS_Result2 wS_Result21;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox to_tesiskodu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox to_takip_no;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}