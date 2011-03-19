using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using System.IO;
using System.Threading;

namespace Naz.Hastane.Win
{
	/// <summary>
	/// Main form of the application
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;

		const int kSplashUpdateInterval_ms = 200;
		const int kMinAmountOfSplashTime_ms = 8000;

		/// <summary>
		/// Main form's contructor only calls InitializeComponent
		/// </summary>
		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

		}

		/// <summary>
		/// Instance of the splash form.
		/// </summary>
		static SplashForm splash = null;

		/// <summary>
		/// Starts the splash screen on a separate thread
		/// </summary>
		static public void StartSplash()
		{
			// Instance a splash form given the image names
			splash = new SplashForm(kSplashUpdateInterval_ms);

			// Run the form
			Application.Run(splash);
		}

		/// <summary>
		/// Clean up
		/// </summary>
		/// <param name="disposing"></param>
		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.label1 = new System.Windows.Forms.Label();
			// 
			// label1
			// 
			this.label1.Enabled = false;
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Size = new System.Drawing.Size(120, 80);
			this.label1.Text = "Empty Application";
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(234, 288);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Text = "Splash Sample";
			this.Load += new System.EventHandler(this.MainForm_Load);

		}
		#endregion

		/// <summary>
		/// Application main
		/// </summary>
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		/// <summary>
		/// A lable to show our application does something
		/// </summary>
		private System.Windows.Forms.Label label1;

		/// <summary>
		/// Paint the form only if the splash screen is gone
		/// </summary>
		/// <param name="e">Paint event arguments</param>
		protected override void OnPaint(PaintEventArgs e)
		{
			if (splash != null)
				return;

			base.OnPaint (e);
		}

		/// <summary>
		/// Paint the form background only if the splash screen is gone
		/// </summary>
		/// <param name="e">Paint event arguments</param>
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			if (splash != null)
				return;

			base.OnPaintBackground (e);
		}

		/// <summary>
		/// Shuts down and cleans up the splash screen
		/// </summary>
		private void CloseSplash()
		{
			if (splash == null)
				return;

			// Shut down the splash screen
			splash.Invoke(new EventHandler(splash.KillMe));
			splash.Dispose();
			splash = null;
		}

		/// <summary>
		/// The form is ready so do our application specific loading and
		/// initialization
		/// </summary>
		/// <param name="sender">Sender of the event</param>
		/// <param name="e">Event arguments</param>
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			// Create a new thread from which to start the splash screen form
			Thread splashThread = new Thread(new ThreadStart(StartSplash));
			splashThread.Start();

			// Pretend that our application is doing a bunch of loading and
			// initialization
			Thread.Sleep(kMinAmountOfSplashTime_ms / 2);

			// Sit and spin while we wait for the minimum timer interval if
			// the interval has not already passed
			while (splash.GetUpMilliseconds() < kMinAmountOfSplashTime_ms)
			{
				Thread.Sleep(kSplashUpdateInterval_ms / 4);
			}

			// Close the splash screen
			CloseSplash();
		}

		/// <summary>
		/// Ensures that if the form is somehow closed before loading is complete,
		/// the splash form will be closed and released as well.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
		{
			// Make sure the splash screen is closed
			CloseSplash();

			base.OnClosing (e);
		}

	}
}
