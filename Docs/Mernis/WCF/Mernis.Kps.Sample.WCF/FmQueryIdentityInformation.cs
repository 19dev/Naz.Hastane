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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.Common;
using Mernis.Kps.Sample.WCF.Service;
using Mernis.Kps.Sample.WCF.Utilities;

namespace Mernis.Kps.Sample.WCF
{
	public class FmQueryIdentityList : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ctlIlceCode;
		private System.Windows.Forms.TextBox ctlEndDate;
		private System.Windows.Forms.TextBox ctlStartDate;
		private System.Windows.Forms.Button ctlQuery;
		private System.Windows.Forms.Panel pnlPage;
		private System.Windows.Forms.Button ctlPaging;
		private System.Windows.Forms.Label ctlPage;
		private System.Windows.Forms.ListView ctlResultView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private System.Windows.Forms.ColumnHeader columnHeader20;
		private System.Windows.Forms.ColumnHeader columnHeader21;
		private System.Windows.Forms.ColumnHeader columnHeader22;
		private System.Windows.Forms.ComboBox ctlSex;
		private System.ComponentModel.Container components = null;

		public FmQueryIdentityList()
		{
			InitializeComponent();
			ctlSex.SelectedIndex=0;
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
			this.label1 = new System.Windows.Forms.Label();
			this.ctlIlceCode = new System.Windows.Forms.TextBox();
			this.ctlEndDate = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ctlStartDate = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ctlQuery = new System.Windows.Forms.Button();
			this.pnlPage = new System.Windows.Forms.Panel();
			this.ctlPage = new System.Windows.Forms.Label();
			this.ctlPaging = new System.Windows.Forms.Button();
			this.ctlResultView = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader20 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader21 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader22 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.ctlSex = new System.Windows.Forms.ComboBox();
			this.pnlPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Ýlçe Kodu :";
			// 
			// ctlIlceCode
			// 
			this.ctlIlceCode.BackColor = System.Drawing.Color.White;
			this.ctlIlceCode.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.ctlIlceCode.Location = new System.Drawing.Point(136, 8);
			this.ctlIlceCode.Name = "ctlIlceCode";
			this.ctlIlceCode.Size = new System.Drawing.Size(136, 24);
			this.ctlIlceCode.TabIndex = 1;
			this.ctlIlceCode.Text = "1485";
			// 
			// ctlEndDate
			// 
			this.ctlEndDate.BackColor = System.Drawing.Color.White;
			this.ctlEndDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.ctlEndDate.Location = new System.Drawing.Point(424, 48);
			this.ctlEndDate.Name = "ctlEndDate";
			this.ctlEndDate.Size = new System.Drawing.Size(136, 24);
			this.ctlEndDate.TabIndex = 3;
			this.ctlEndDate.Text = "1/2/1985";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label2.Location = new System.Drawing.Point(320, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "Bitiþ Tarihi :";
			// 
			// ctlStartDate
			// 
			this.ctlStartDate.BackColor = System.Drawing.Color.White;
			this.ctlStartDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.ctlStartDate.Location = new System.Drawing.Point(136, 48);
			this.ctlStartDate.Name = "ctlStartDate";
			this.ctlStartDate.Size = new System.Drawing.Size(136, 24);
			this.ctlStartDate.TabIndex = 5;
			this.ctlStartDate.Text = "1/1/1985";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label3.Location = new System.Drawing.Point(8, 48);
			this.label3.Name = "label3";
			this.label3.TabIndex = 4;
			this.label3.Text = "Baþlangýç Tarihi :";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label4.Location = new System.Drawing.Point(320, 8);
			this.label4.Name = "label4";
			this.label4.TabIndex = 6;
			this.label4.Text = "Cinsiyet :";
			// 
			// ctlQuery
			// 
			this.ctlQuery.BackColor = System.Drawing.SystemColors.Control;
			this.ctlQuery.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.ctlQuery.Location = new System.Drawing.Point(8, 80);
			this.ctlQuery.Name = "ctlQuery";
			this.ctlQuery.Size = new System.Drawing.Size(136, 23);
			this.ctlQuery.TabIndex = 9;
			this.ctlQuery.Text = "Sorgula";
			this.ctlQuery.Click += new System.EventHandler(this.ctlQuery_Click);
			// 
			// pnlPage
			// 
			this.pnlPage.Controls.Add(this.ctlPage);
			this.pnlPage.Controls.Add(this.ctlPaging);
			this.pnlPage.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.pnlPage.Location = new System.Drawing.Point(8, 408);
			this.pnlPage.Name = "pnlPage";
			this.pnlPage.Size = new System.Drawing.Size(552, 40);
			this.pnlPage.TabIndex = 11;
			// 
			// ctlPage
			// 
			this.ctlPage.AutoSize = true;
			this.ctlPage.BackColor = System.Drawing.Color.Transparent;
			this.ctlPage.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.ctlPage.Location = new System.Drawing.Point(8, 8);
			this.ctlPage.Name = "ctlPage";
			this.ctlPage.Size = new System.Drawing.Size(38, 20);
			this.ctlPage.TabIndex = 1;
			this.ctlPage.Text = "label5";
			// 
			// ctlPaging
			// 
			this.ctlPaging.BackColor = System.Drawing.SystemColors.Control;
			this.ctlPaging.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.ctlPaging.Location = new System.Drawing.Point(464, 8);
			this.ctlPaging.Name = "ctlPaging";
			this.ctlPaging.TabIndex = 0;
			this.ctlPaging.Text = ">";
			this.ctlPaging.Visible = false;
			this.ctlPaging.Click += new System.EventHandler(this.ctlPaging_Click);
			// 
			// ctlResultView
			// 
			this.ctlResultView.AllowColumnReorder = true;
			this.ctlResultView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																							this.columnHeader1,
																							this.columnHeader2,
																							this.columnHeader10,
																							this.columnHeader5,
																							this.columnHeader3,
																							this.columnHeader9,
																							this.columnHeader8,
																							this.columnHeader7,
																							this.columnHeader20,
																							this.columnHeader21,
																							this.columnHeader22,
																							this.columnHeader15,
																							this.columnHeader16,
																							this.columnHeader13,
																							this.columnHeader14,
																							this.columnHeader11,
																							this.columnHeader12});
			this.ctlResultView.FullRowSelect = true;
			this.ctlResultView.GridLines = true;
			this.ctlResultView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.ctlResultView.LabelEdit = true;
			this.ctlResultView.Location = new System.Drawing.Point(16, 112);
			this.ctlResultView.Name = "ctlResultView";
			this.ctlResultView.Size = new System.Drawing.Size(560, 288);
			this.ctlResultView.TabIndex = 12;
			this.ctlResultView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "T.C. Kimlik No";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Adý";
			this.columnHeader2.Width = 90;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Soyadý";
			this.columnHeader10.Width = 94;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Baba Adý";
			this.columnHeader5.Width = 89;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Anne Adý";
			this.columnHeader3.Width = 82;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Doðum Yeri";
			this.columnHeader9.Width = 81;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Doðum Tarihi";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Cinsiyeti";
			// 
			// columnHeader20
			// 
			this.columnHeader20.Text = "Durumu";
			// 
			// columnHeader21
			// 
			this.columnHeader21.Text = "Medeni Hali";
			// 
			// columnHeader22
			// 
			this.columnHeader22.Text = "Ölüm Tarihi";
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Ýl Adý";
			// 
			// columnHeader16
			// 
			this.columnHeader16.Text = "Ýlçe Adý";
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Mahalle / Köy";
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Cilt Kodu";
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Aile Sýra No";
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Birey Sýra No";
			// 
			// ctlSex
			// 
			this.ctlSex.Items.AddRange(new object[] {
														"Bilinmiyor",
														"Erkek",
														"Kadin"});
			this.ctlSex.Location = new System.Drawing.Point(424, 8);
			this.ctlSex.Name = "ctlSex";
			this.ctlSex.Size = new System.Drawing.Size(136, 21);
			this.ctlSex.TabIndex = 13;
			// 
			// FmQueryIdentityList
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(600, 470);
			this.Controls.Add(this.ctlSex);
			this.Controls.Add(this.ctlResultView);
			this.Controls.Add(this.pnlPage);
			this.Controls.Add(this.ctlQuery);
			this.Controls.Add(this.ctlStartDate);
			this.Controls.Add(this.ctlEndDate);
			this.Controls.Add(this.ctlIlceCode);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FmQueryIdentityList";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kiþi Listesi";
			this.Load += new System.EventHandler(this.FmQueryIdentityList_Load);
			this.pnlPage.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ctlQuery_Click(object sender, System.EventArgs e)
		{

			try
			{
				KPSSoap service = KPSServiceFactory.Create();
				KisiBilgisiCT  kpstable = service.KisiListesiSorgula(int.Parse(ctlIlceCode.Text),DateTime.Parse(ctlStartDate.Text),DateTime.Parse(ctlEndDate.Text),(CinsiyetTipi)ctlSex.SelectedIndex);
				showResults(kpstable);				
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void showResults(KisiBilgisiCT kpstable)
		{
			ctlResultView.Items.Clear();
			for(int i = 0; i < kpstable.Liste.Length; i++)
			{
				ListViewItem item = new ListViewItem(kpstable.Liste[i].TCKimlikNo.ToString());
				item.SubItems.Add(kpstable.Liste[i].TemelBilgisi.Ad);
				item.SubItems.Add(kpstable.Liste[i].TemelBilgisi.Soyad);
				item.SubItems.Add(kpstable.Liste[i].TemelBilgisi.BabaAd);
				item.SubItems.Add(kpstable.Liste[i].TemelBilgisi.AnaAd);
				item.SubItems.Add(kpstable.Liste[i].TemelBilgisi.DogumYer);
				item.SubItems.Add(kpstable.Liste[i].TemelBilgisi.DogumTarih.Gun.ToString()+
					"/"+kpstable.Liste[i].TemelBilgisi.DogumTarih.Ay.ToString()+
					"/"+kpstable.Liste[i].TemelBilgisi.DogumTarih.Yil.ToString());				
				item.SubItems.Add(kpstable.Liste[i].TemelBilgisi.Cinsiyet.ToString());
				item.SubItems.Add(kpstable.Liste[i].DurumBilgisi.Durum.ToString());
				item.SubItems.Add(kpstable.Liste[i].DurumBilgisi.MedeniHal.ToString());	
				item.SubItems.Add(kpstable.Liste[i].DurumBilgisi.OlumTarih.Gun.ToString()+
					"/"+kpstable.Liste[i].DurumBilgisi.OlumTarih.Ay.ToString()+
					"/"+kpstable.Liste[i].DurumBilgisi.OlumTarih.Yil.ToString());
				item.SubItems.Add(kpstable.Liste[i].KayitYeriBilgisi.IlAd);	
				item.SubItems.Add(kpstable.Liste[i].KayitYeriBilgisi.IlceAd);
				item.SubItems.Add(kpstable.Liste[i].KayitYeriBilgisi.CiltAd);
				item.SubItems.Add(kpstable.Liste[i].KayitYeriBilgisi.CiltKod.ToString());						
				item.SubItems.Add(kpstable.Liste[i].KayitYeriBilgisi.AileSiraNo.ToString());
				item.SubItems.Add(kpstable.Liste[i].KayitYeriBilgisi.BireySiraNo.ToString());
				
				ctlResultView.Items.Add(item);
			}			

			SayfalamaBilgisi sayfa = kpstable.SayfaBilgisi;
			pnlPage.Visible = (sayfa != null && sayfa.SayfaNo < sayfa.ToplamSayfa);
			this.Tag = sayfa;
			if (pnlPage.Visible) 
			{
				ctlPage.Visible=true;
				ctlPaging.Visible=true;
				ctlPage.Text = sayfa.SayfaNo.ToString() + "/" + sayfa.ToplamSayfa.ToString();
			}
		}

		private void FmQueryIdentityList_Load(object sender, System.EventArgs e)
		{
			ctlPage.Visible=false;
		}

		private void ctlPaging_Click(object sender, System.EventArgs e)
		{
			SayfalamaBilgisi sayfa = (SayfalamaBilgisi)this.Tag;
			KPSSoap service = KPSServiceFactory.Create();
			SayfaIstekKomutu komut = new SayfaIstekKomutu();
			komut.IstekNo = sayfa.IstekNo;
			KisiBilgisiCT  kpstable = service.KisiListesiSayfala(komut);
			ctlResultView.Items.Clear();
			showResults(kpstable);				

		}		
	}
}
