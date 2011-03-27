namespace Naz.Hastane.Win.MDIChildForms
{
    partial class MDIChildForm {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // MDIChildForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(347, 201);
            this.Name = "MDIChildForm";
            this.Text = "frmMDIChild";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmPad_Closing);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIChildForm_FormClosing);
            this.ResumeLayout(false);

        }
 
        #endregion

        private System.ComponentModel.Container components = null;

    }
}
