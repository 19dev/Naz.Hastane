//=============================================================================
// © 2005  Nüfus ve Vatandaþlýk Ýþleri Genel Müdürlüðü.  
// Tüm haklarý saklýdýr. 
// Bu uygulama, Nüfus ve Vatandaþlýk Ýþleri Genel Müdürlüðü’nün  Kimlik Paylaþým Sistemi 
// kapsamýnda sunduðu web servislerinin kullanýmýna örnek olmasý için  hazýrlanmýþtýr. 
// Nüfus ve Vatandaþlýk Ýþleri Genel Müdürlüðü'nün önceden onayý olmadan
// içeriðinin yayýnlanmasý veya daðýtýlmasý yasaktýr.  
// Nüfus ve Vatandaþlýk Ýþleri Genel Müdürlüðü  bu örnek uygulamadan kaynaklanacak
// herhangi bir sorundan dolayý sorumlu tutulamaz.
//=============================================================================

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Mernis.Kps.Sample.WCF.Service;
using Mernis.Kps.Sample.WCF.Utilities;

namespace Mernis.Kps.Sample.WCF
{
	public class FmIdentityNumberValidation : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox ctlIdentityNumber;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblBornPlace;
		private System.Windows.Forms.Label lblFather;
		private System.Windows.Forms.Label lblMother;
		private System.ComponentModel.Container components = null;

		public FmIdentityNumberValidation()
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
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ctlIdentityNumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblBornPlace = new System.Windows.Forms.Label();
			this.lblFather = new System.Windows.Forms.Label();
			this.lblMother = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ctlIdentityNumber
			// 
			this.ctlIdentityNumber.Location = new System.Drawing.Point(144, 8);
			this.ctlIdentityNumber.MaxLength = 11;
			this.ctlIdentityNumber.Name = "ctlIdentityNumber";
			this.ctlIdentityNumber.Size = new System.Drawing.Size(136, 20);
			this.ctlIdentityNumber.TabIndex = 0;
			this.ctlIdentityNumber.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label1.Location = new System.Drawing.Point(40, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "T.C. Kimlik No:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(288, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "Arama Yap";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(144, 40);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(208, 23);
			this.lblName.TabIndex = 6;
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblLastName
			// 
			this.lblLastName.Location = new System.Drawing.Point(144, 64);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(208, 23);
			this.lblLastName.TabIndex = 7;
			this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
			// 
			// lblDate
			// 
			this.lblDate.Location = new System.Drawing.Point(144, 160);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(208, 23);
			this.lblDate.TabIndex = 8;
			this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label2.Location = new System.Drawing.Point(40, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Adý :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label3.Location = new System.Drawing.Point(40, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Soyadý :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label4.Location = new System.Drawing.Point(40, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Doðum Tarihi :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label5.Location = new System.Drawing.Point(40, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "Doðum Yeri :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label6.Location = new System.Drawing.Point(40, 112);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "Baba Adý :";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label7.Location = new System.Drawing.Point(40, 88);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 23);
			this.label7.TabIndex = 15;
			this.label7.Text = "Anne Adý :";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// lblBornPlace
			// 
			this.lblBornPlace.Location = new System.Drawing.Point(144, 136);
			this.lblBornPlace.Name = "lblBornPlace";
			this.lblBornPlace.Size = new System.Drawing.Size(208, 23);
			this.lblBornPlace.TabIndex = 14;
			this.lblBornPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblFather
			// 
			this.lblFather.Location = new System.Drawing.Point(144, 112);
			this.lblFather.Name = "lblFather";
			this.lblFather.Size = new System.Drawing.Size(208, 23);
			this.lblFather.TabIndex = 13;
			this.lblFather.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblMother
			// 
			this.lblMother.Location = new System.Drawing.Point(144, 88);
			this.lblMother.Name = "lblMother";
			this.lblMother.Size = new System.Drawing.Size(208, 23);
			this.lblMother.TabIndex = 12;
			this.lblMother.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblMother.Click += new System.EventHandler(this.lblMother_Click);
			// 
			// FmIdentityNumberValidation
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(370, 207);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblBornPlace);
			this.Controls.Add(this.lblFather);
			this.Controls.Add(this.lblMother);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ctlIdentityNumber);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FmIdentityNumberValidation";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "T.C. Kimlik No ile Kiþi Bilgisi Sorgulama";
			this.Load += new System.EventHandler(this.FmIdentityNumberValidation_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			try 
			{
				lblName.Text="";
				lblLastName.Text="";
				lblDate.Text="";

                KPSSoap service = KPSServiceFactory.Create();

				TCKimlikNoG[] list = new TCKimlikNoG[1];
				TCKimlikNoG gris= new TCKimlikNoG();
				gris.TCKimlikNo=long.Parse(ctlIdentityNumber.Text);
					list[0] =gris;
 
				KisiBilgisiC[] sonuc = service.TCKimlikNodanKisiBilgisiSorgula(list);
				
				if (sonuc.Length >0)
				{
					lblName.Text=sonuc[0].TemelBilgisi.Ad;
					lblLastName.Text=sonuc[0].TemelBilgisi.Soyad;
					lblDate.Text=sonuc[0].TemelBilgisi.DogumTarih.Gun.ToString()+"/"+
						sonuc[0].TemelBilgisi.DogumTarih.Ay.ToString()+"/"+
						sonuc[0].TemelBilgisi.DogumTarih.Yil.ToString();
					lblMother.Text=sonuc[0].TemelBilgisi.AnaAd;
					lblFather.Text=sonuc[0].TemelBilgisi.BabaAd;
					lblBornPlace.Text=sonuc[0].TemelBilgisi.DogumYer;
				}
				else
				{
					MessageBox.Show("Belirtilen T.C. Kimlik No bulunamadý.");

				}
			} 
			catch (Exception exc) 
			{
				MessageBox.Show(exc.Message);
	
			}
		}

		private void lblMother_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label7_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label3_Click(object sender, System.EventArgs e)
		{
		
		}

		private void FmIdentityNumberValidation_Load(object sender, System.EventArgs e)
		{
		
		}

		private void lblLastName_Click(object sender, System.EventArgs e)
		{
		
		}

	}
}
