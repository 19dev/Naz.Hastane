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
using Mernis.Kps.Sample.WCF.Utilities;

namespace Mernis.Kps.Sample.WCF
{
	public class FmParameters : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ctlSecurityCode;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox ctlURI;
		private System.Windows.Forms.Button ctlOK;
		private System.Windows.Forms.Button ctlCancel;
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox ctlUserName;

		public FmParameters()
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ctlSecurityCode = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ctlURI = new System.Windows.Forms.TextBox();
			this.ctlOK = new System.Windows.Forms.Button();
			this.ctlCancel = new System.Windows.Forms.Button();
			this.ctlUserName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "KPS Kullanýcý Adý:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "KPS Güvenlik Kodu:";
			// 
			// ctlSecurityCode
			// 
			this.ctlSecurityCode.Location = new System.Drawing.Point(128, 40);
			this.ctlSecurityCode.Name = "ctlSecurityCode";
			this.ctlSecurityCode.PasswordChar = '*';
			this.ctlSecurityCode.TabIndex = 1;
			this.ctlSecurityCode.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 16);
			this.label6.TabIndex = 9;
			this.label6.Text = "KPS Web Adresi:";
			// 
			// ctlURI
			// 
			this.ctlURI.Location = new System.Drawing.Point(128, 72);
			this.ctlURI.Name = "ctlURI";
			this.ctlURI.Size = new System.Drawing.Size(272, 20);
			this.ctlURI.TabIndex = 2;
			this.ctlURI.Text = "";
			// 
			// ctlOK
			// 
			this.ctlOK.Location = new System.Drawing.Point(8, 104);
			this.ctlOK.Name = "ctlOK";
			this.ctlOK.TabIndex = 3;
			this.ctlOK.Text = "Tamam";
			this.ctlOK.Click += new System.EventHandler(this.ctlOK_Click);
			// 
			// ctlCancel
			// 
			this.ctlCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ctlCancel.Location = new System.Drawing.Point(96, 104);
			this.ctlCancel.Name = "ctlCancel";
			this.ctlCancel.TabIndex = 4;
			this.ctlCancel.Text = "Ýptal";
			// 
			// ctlUserName
			// 
			this.ctlUserName.Location = new System.Drawing.Point(128, 8);
			this.ctlUserName.Name = "ctlUserName";
			this.ctlUserName.TabIndex = 0;
			this.ctlUserName.Text = "";
			// 
			// FmParameters
			// 
			this.AcceptButton = this.ctlOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.ctlCancel;
			this.ClientSize = new System.Drawing.Size(418, 143);
			this.Controls.Add(this.ctlUserName);
			this.Controls.Add(this.ctlCancel);
			this.Controls.Add(this.ctlOK);
			this.Controls.Add(this.ctlURI);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.ctlSecurityCode);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FmParameters";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parametreler";
			this.Load += new System.EventHandler(this.FmParameters_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void showParameters() 
		{
			ctlUserName.Text = KPSConfiguration.Instance.Username;
			ctlSecurityCode.Text = KPSConfiguration.Instance.Password;
			ctlURI.Text = KPSConfiguration.Instance.EndPoint;
		}

		private void FmParameters_Load(object sender, System.EventArgs e)
		{
			showParameters();		
		}

		private void ctlOK_Click(object sender, System.EventArgs e)
		{
			if (ctlSecurityCode.Text.Length == 0)
				MessageBox.Show("Lütfen güvenlik kodu giriniz");
			else if (ctlURI.Text.Length == 0)
				MessageBox.Show("Lütfen web servisi için adres belirtiniz");
			else if (ctlUserName.Text.Length == 0)
				MessageBox.Show("Lütfen kullanýcý adý giriniz");

			else 
			{
                KPSConfiguration.Instance.Username = ctlUserName.Text;
                KPSConfiguration.Instance.Password = ctlSecurityCode.Text;
				KPSConfiguration.Instance.EndPoint = ctlURI.Text;
				DialogResult = DialogResult.OK;
			}
		}
	}
}
