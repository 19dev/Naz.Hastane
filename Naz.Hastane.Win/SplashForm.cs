using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;

namespace Naz.Hastane.Win
{
	/// <summary>
	/// Summary description for SplashForm.
	/// </summary>
	public class SplashForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// A hack constant specifying how many cells the animation has
		/// </summary>
		const int kNumAnimationCells = 8;

		/// <summary>
		/// Splash screen background bitmap
		/// </summary>
		Bitmap bmpSplash = null;

		/// <summary>
		/// Splash screen animation bitmap
		/// </summary>
		Bitmap bmpAnim = null;

		/// <summary>
		/// Current screen position of the animation
		/// </summary>
		Rectangle animPos = new Rectangle(0,0,0,0);

		/// <summary>
		/// Graphics object used to render splash screen.
		/// Cached for performance.
		/// </summary>
		Graphics g = null;

		/// <summary>
		/// The region of the screen filled by the background.
		/// Cached for performance.
		/// </summary>
		Rectangle splashRegion = new Rectangle(0,0,0,0);

		/// <summary>
		/// The source region of the background draw.
		/// Cached for performance.
		/// </summary>
		Rectangle splashSrc = new Rectangle(0,0,0,0);

		/// <summary>
		/// Image attributes specifying transperancy color.
		/// Cached for performance.
		/// </summary>
		ImageAttributes attr = new ImageAttributes();

		/// <summary>
		/// Timer used to update the screen at regular intervals.
		/// </summary>
		System.Threading.Timer splashTimer = null;

		/// <summary>
		/// Source region for redrawing the background.
		/// Cached for performance.
		/// </summary>
		Rectangle redrawSrc = new Rectangle(0,0,0,0);

		/// <summary>
		/// Current cell being displayed in the animation.
		/// </summary>
		int curAnimCell = 0;

		/// <summary>
		/// The number of updates that the splash screen timer triggered.
		/// </summary>
		int numUpdates = 0;

		/// <summary>
		/// Time between screen updates (ms)
		/// </summary>
		int timerInterval_ms = 0;

		/// <summary>
		/// Constructor for the splash screen form.  Creates the background
		/// and animation Bitmap objects
		/// </summary>
		/// <param name="timerInterval">Length of time between screen updates (ms)</param>
		public SplashForm(int timerInterval)
		{
			// Store the timer interval
			timerInterval_ms = timerInterval;

            string[] resourceNames = this.GetType().Assembly.GetManifestResourceNames();
            //string[] resourceNames1 = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            // Load the embedded splash image resources
			Assembly asm = Assembly.GetExecutingAssembly();
//            bmpSplash = new Bitmap(asm.GetManifestResourceStream(asm.GetName().Name + ".splash.jpg"));
            bmpSplash = new Bitmap(asm.GetManifestResourceStream("Naz.Hastane.Win.Resources" + ".Ring.png"));
//            bmpSplash = new Bitmap(asm.GetManifestResourceStream("Naz.Hastane.Win.Resources" + ".splash.jpg"));
            bmpAnim = new Bitmap(asm.GetManifestResourceStream("Naz.Hastane.Win.Resources" + ".animation.bmp"));

			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			// 
			// SplashForm
			// 
			this.Load += new System.EventHandler(this.SplashForm_Load);

		}
		#endregion

		/// <summary>
		/// Return the amount of time the splash screen has been displayed in
		/// milliseconds.  This is based on the number of times the timer has
		/// triggered and the interval of the timer.  This is not completely
		/// accurate but good enough for the purposes of this function.
		/// </summary>
		/// <returns></returns>
		public int GetUpMilliseconds()
		{
			return numUpdates * timerInterval_ms;
		}

		/// <summary>
		/// The form is ready to be displayed so initialize all of the
		/// splash screen data and draw the first frame.
		/// </summary>
		/// <param name="sender">Sending object</param>
		/// <param name="e">Event arguments</param>
		private void SplashForm_Load(object sender, System.EventArgs e)
		{
			// Make the form full screen
			this.Text = "";
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.ControlBox = false;
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;
			this.Menu = null;

			// Center the splash screen background
			splashRegion.X = (Screen.PrimaryScreen.Bounds.Width - bmpSplash.Width) / 2;
			splashRegion.Y = (Screen.PrimaryScreen.Bounds.Height - bmpSplash.Height) / 2;
			splashRegion.Width = bmpSplash.Width;
			splashRegion.Height = bmpSplash.Height;

			// Set up the rectangle from which the background will be drawn
			splashSrc.X = 0;
			splashSrc.Y = 0;
			splashSrc.Width = bmpSplash.Width;
			splashSrc.Height = bmpSplash.Height;

			// Set up the destination region of the animatino draw 
			animPos.X = splashRegion.X - bmpAnim.Width / kNumAnimationCells;
			animPos.Y = splashRegion.Y + splashRegion.Height - bmpAnim.Height;
			animPos.Width = bmpAnim.Width / kNumAnimationCells;
			animPos.Height = bmpAnim.Height;

			// Initialize the draw region used to optimize animation updates
			redrawSrc.Width = bmpAnim.Width / kNumAnimationCells;
			redrawSrc.Height = bmpAnim.Height;

			// Cache the transparent color
			attr.SetColorKey(bmpAnim.GetPixel(0,0), bmpAnim.GetPixel(0,0));

			// Create the graphics object and set its clipping region
			g = CreateGraphics();
			g.Clip = new Region(splashRegion);

			// Draw the screen once with the full background update
			// No need to use Application.DoEvents to force OnPaint.
			Draw(true, false);

			// Start a timer that will call Draw every 200 ms
			System.Threading.TimerCallback splashDelegate = new System.Threading.TimerCallback(this.Draw);
			this.splashTimer = new System.Threading.Timer(splashDelegate, null, timerInterval_ms, timerInterval_ms);
		}

		/// <summary>
		/// If a paint event is generated then redraw the splash screen
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPaint(PaintEventArgs e)
		{
			Draw(true, false);
		}

		/// <summary>
		/// Do not respond to paint background events
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPaintBackground(PaintEventArgs e){}

		/// <summary>
		/// Kill this form
		/// </summary>
		/// <param name="o">Not used</param>
		/// <param name="e">Not used</param>
		public void KillMe(object o, EventArgs e)
		{
			// Stop the timer first so there are no racing issues
			splashTimer.Dispose();

			// Shut down the form
			this.Close();
		}

		/// <summary>
		/// Draw the screen.  This is the callback for the timer
		/// </summary>
		/// <param name="state">Not used - timer data</param>
		protected void Draw(Object state)
		{
			numUpdates++;

			Draw(false, true);
		}

		/// <summary>
		/// Draw the screen
		/// </summary>
		/// <param name="bFullImage">true if the entire background should be updated</param>
		/// <param name="bUpdateAnim">true if the animation position and cell should be updated</param>
		protected void Draw(bool bFullImage, bool bUpdateAnim)
		{
			if (g == null)
				return;

			// Make sure it is safe to access the form
			lock (this)
			{
				// Draw the background
				if (bFullImage)
				{
					g.DrawImage(bmpSplash, splashRegion, splashSrc, GraphicsUnit.Pixel);
				}
				else if (bUpdateAnim)
				{
					// If not drawing the full background then only upate the
					// location of the animation
					redrawSrc.X = animPos.X - splashRegion.X;
					redrawSrc.Y = animPos.Y - splashRegion.Y;
					g.DrawImage(bmpSplash, animPos, redrawSrc, GraphicsUnit.Pixel);
				}

				if (bUpdateAnim)
				{
					// Update the current animation cell
					curAnimCell++;
					if (curAnimCell >= kNumAnimationCells)
						curAnimCell = 0;

					// Move the animation (yes hard-coded for the example)
					animPos.X += 5;
					if (animPos.X > splashRegion.X + splashRegion.Width)
						animPos.X = splashRegion.X - bmpAnim.Width / kNumAnimationCells;
				}

				// Draw the animation
				g.DrawImage(bmpAnim, animPos, curAnimCell * bmpAnim.Width / kNumAnimationCells, 0, bmpAnim.Width / kNumAnimationCells, bmpAnim.Height, GraphicsUnit.Pixel, attr);
			}
		}
	}
}
