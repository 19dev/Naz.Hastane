//=============================================================================
// � 2005  N�fus ve Vatanda�l�k ��leri Genel M�d�rl���.  
// T�m haklar� sakl�d�r. 
// Bu uygulama, N�fus ve Vatanda�l�k ��leri Genel M�d�rl����n�n  Kimlik Payla��m Sistemi 
// kapsam�nda sundu�u web servislerinin kullan�m�na �rnek olmas� i�in  haz�rlanm��t�r. 
// N�fus ve Vatanda�l�k ��leri Genel M�d�rl���'n�n �nceden onay� olmadan
// i�eri�inin yay�nlanmas� veya da��t�lmas� yasakt�r.  
// N�fus ve Vatanda�l�k ��leri Genel M�d�rl���  bu �rnek uygulamadan kaynaklanacak
// herhangi bir sorundan dolay� sorumlu tutulamaz.
//=============================================================================

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Mernis.Kps.Sample.WCF
{
	public class FmAbout : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.ComponentModel.Container components = null;

		public FmAbout()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "� 2005 N�fus ve Vatanda�l�k ��leri Genel M�d�rl���";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(231, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Kimlik Payla��m Sistemi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Microsoft.NET �rnek Uygulamas�";
			// 
			// FmAbout
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(274, 135);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FmAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hakk�nda ...";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
