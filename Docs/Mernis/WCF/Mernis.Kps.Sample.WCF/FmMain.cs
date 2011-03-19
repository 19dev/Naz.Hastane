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
using System.Data;
using Mernis.Kps.Sample.WCF.Utilities;

namespace Mernis.Kps.Sample.WCF
{
	public class FmMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBarButton ctlOptions;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton ctlAbout;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.ToolBar ctlToolBar;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton ctldentity;
		private System.Windows.Forms.ToolBarButton ctlPersonList;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.ComponentModel.IContainer components;

		public FmMain()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FmMain));
			this.ctlToolBar = new System.Windows.Forms.ToolBar();
			this.ctlOptions = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.ctldentity = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.ctlPersonList = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.ctlAbout = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			this.SuspendLayout();
			// 
			// ctlToolBar
			// 
			this.ctlToolBar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.ctlToolBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ctlToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						  this.ctlOptions,
																						  this.toolBarButton1,
																						  this.ctldentity,
																						  this.toolBarButton2,
																						  this.ctlPersonList,
																						  this.toolBarButton3,
																						  this.ctlAbout});
			this.ctlToolBar.DropDownArrows = true;
			this.ctlToolBar.ImageList = this.imageList1;
			this.ctlToolBar.Location = new System.Drawing.Point(0, 0);
			this.ctlToolBar.Name = "ctlToolBar";
			this.ctlToolBar.ShowToolTips = true;
			this.ctlToolBar.Size = new System.Drawing.Size(584, 45);
			this.ctlToolBar.TabIndex = 0;
			this.ctlToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ctlToolBar_ButtonClick);
			// 
			// ctlOptions
			// 
			this.ctlOptions.ImageIndex = 3;
			this.ctlOptions.Text = "Tanýmlar";
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// ctldentity
			// 
			this.ctldentity.Text = "Kiþi Sorgulama";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// ctlPersonList
			// 
			this.ctlPersonList.Text = "Kiþi Listesi";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// ctlAbout
			// 
			this.ctlAbout.ImageIndex = 0;
			this.ctlAbout.Text = "Hakkýnda";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Lime;
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 423);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(584, 22);
			this.statusBar1.TabIndex = 1;
			this.statusBar1.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.statusBar1_PanelClick);
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanel1.Text = "© 2005 Nüfus ve Vatandaþlýk Ýþleri Genel Müdürlüðü";
			this.statusBarPanel1.Width = 568;
			// 
			// FmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(584, 445);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.ctlToolBar);
			this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.MaximizeBox = false;
			this.Name = "FmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "KPS Microsoft.NET Örnek Uygulamasý";
			this.Load += new System.EventHandler(this.FmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void checkParameters ()
		{
			if (string.IsNullOrEmpty(KPSConfiguration.Instance.EndPoint))
				throw new InvalidOperationException("Lütfen iþleme baþlamadan önce parametre düzenleme iþlemini yapýnýz");
            if (string.IsNullOrEmpty(KPSConfiguration.Instance.Username))
                throw new InvalidOperationException("Lütfen iþleme baþlamadan önce parametre düzenleme iþlemini yapýnýz");
            if (string.IsNullOrEmpty(KPSConfiguration.Instance.Password))
                throw new InvalidOperationException("Lütfen iþleme baþlamadan önce parametre düzenleme iþlemini yapýnýz");
        }

		
		private void ctlToolBar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			try 
			{
				if (e.Button == ctlOptions)				
					new FmParameters().ShowDialog();
				else if(e.Button == ctlPersonList) 
				{
					checkParameters();
					new FmQueryIdentityList().ShowDialog();
				}
				else if(e.Button == ctldentity) 
				{
					checkParameters();
					new FmIdentityNumberValidation().ShowDialog();
				}
				else if (e.Button == ctlAbout)
					new FmAbout().ShowDialog();
			}
			catch (Exception exc) 
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void FmMain_Load(object sender, System.EventArgs e)
		{
			
		}

		private void statusBar1_PanelClick(object sender, System.Windows.Forms.StatusBarPanelClickEventArgs e)
		{
		
		}
	}
}
