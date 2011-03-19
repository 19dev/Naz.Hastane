namespace meno
{
    partial class B00
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B00));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wS_Result1 = new meno.WS_Result();
            this.button1 = new System.Windows.Forms.Button();
            this.sevk_gtt = new System.Windows.Forms.ComboBox();
            this.sevk_brans = new System.Windows.Forms.ComboBox();
            this.sevk_dr = new System.Windows.Forms.TextBox();
            this.sevk_tno = new System.Windows.Forms.TextBox();
            this.sevk_tkn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(424, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.wS_Result1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.sevk_gtt);
            this.tabPage1.Controls.Add(this.sevk_brans);
            this.tabPage1.Controls.Add(this.sevk_dr);
            this.tabPage1.Controls.Add(this.sevk_tno);
            this.tabPage1.Controls.Add(this.sevk_tkn);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(416, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sevk Bildir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(271, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(17, 20);
            this.button2.TabIndex = 35;
            this.button2.TabStop = false;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(12, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 2);
            this.panel1.TabIndex = 34;
            // 
            // wS_Result1
            // 
            this.wS_Result1.Location = new System.Drawing.Point(3, 168);
            this.wS_Result1.Name = "wS_Result1";
            this.wS_Result1.Size = new System.Drawing.Size(412, 213);
            this.wS_Result1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(144, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sevk Bildir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sevk_gtt
            // 
            this.sevk_gtt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sevk_gtt.FormattingEnabled = true;
            this.sevk_gtt.Items.AddRange(new object[] {
            "1.Basamak kurum ve kuruluþlara sevk",
            "2.Basamak kurum ve kuruluþlara sevk",
            "3.Basamak kurum ve kuruluþlara sevk",
            "Aðýz ve diþ saðlýðý merkezleri",
            "Eczaneler",
            "Optik firmalarý",
            "Görüntüleme merkezleri",
            "Acil hizmet merkezleri",
            "Laboratuarlar",
            "Tedavi merkezleri",
            "Týbbi malzeme tedarikçileri"});
            this.sevk_gtt.Location = new System.Drawing.Point(144, 100);
            this.sevk_gtt.MaxDropDownItems = 15;
            this.sevk_gtt.Name = "sevk_gtt";
            this.sevk_gtt.Size = new System.Drawing.Size(260, 21);
            this.sevk_gtt.TabIndex = 4;
            // 
            // sevk_brans
            // 
            this.sevk_brans.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sevk_brans.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sevk_brans.DisplayMember = "aciklama";
            this.sevk_brans.FormattingEnabled = true;
            this.sevk_brans.Location = new System.Drawing.Point(144, 76);
            this.sevk_brans.MaxDropDownItems = 15;
            this.sevk_brans.Name = "sevk_brans";
            this.sevk_brans.Size = new System.Drawing.Size(260, 21);
            this.sevk_brans.TabIndex = 3;
            this.sevk_brans.ValueMember = "kod";
            // 
            // sevk_dr
            // 
            this.sevk_dr.Location = new System.Drawing.Point(144, 53);
            this.sevk_dr.Name = "sevk_dr";
            this.sevk_dr.Size = new System.Drawing.Size(125, 20);
            this.sevk_dr.TabIndex = 2;
            // 
            // sevk_tno
            // 
            this.sevk_tno.Location = new System.Drawing.Point(144, 30);
            this.sevk_tno.Name = "sevk_tno";
            this.sevk_tno.Size = new System.Drawing.Size(125, 20);
            this.sevk_tno.TabIndex = 1;
            // 
            // sevk_tkn
            // 
            this.sevk_tkn.Location = new System.Drawing.Point(144, 7);
            this.sevk_tkn.Name = "sevk_tkn";
            this.sevk_tkn.Size = new System.Drawing.Size(125, 20);
            this.sevk_tkn.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gideceði Tesis Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sevk Edilen Branþ Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sevk Eden Dr. Tescil No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Takip No";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saðlýk Tesis Kodu";
            this.toolTip1.SetToolTip(this.label1, "Sevk bildirimi yapan saðlýk tesisinin kodu.");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(424, 22);
            this.statusStrip1.TabIndex = 1;
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
            // B00
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 435);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "B00";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reçete, Tetkik ve Sevk Bildirim (Sevk Bildirim - B00)";
            this.Load += new System.EventHandler(this.B00_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sevk_dr;
        private System.Windows.Forms.TextBox sevk_tno;
        private System.Windows.Forms.TextBox sevk_tkn;
        private System.Windows.Forms.ComboBox sevk_brans;
        private System.Windows.Forms.ComboBox sevk_gtt;
        private System.Windows.Forms.Button button1;
        private WS_Result wS_Result1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}