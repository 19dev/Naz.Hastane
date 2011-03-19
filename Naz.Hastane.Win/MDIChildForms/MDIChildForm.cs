using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    /// <summary>
    /// Summary description for frmPad.
    /// </summary>
    public partial class MDIChildForm : DevExpress.XtraEditors.XtraForm {
        public MDIChildForm() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        bool modified = false;
        bool newDocument = true;

        public bool Modified {
            get { return modified; }
            set {
                if(value != modified) {
                    modified = value;
                    //this.Text = DocName + (Modified ? "*" : "");
                    //if(MdiParent != null) ((frmMain)MdiParent).UpdateText();
                }
            }
        }
        public bool NewDocument { get { return this.newDocument; } }

        bool SaveQuestion() {
            //if(Modified) {
            //    switch(DevExpress.XtraEditors.XtraMessageBox.Show("Do you want to save the changes you made to " + DocName + "?", "SimplePad Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
            //        case DialogResult.Cancel:
            //            return false;
            //        case DialogResult.Yes:
            //            SaveAs();
            //            break;
            //    }
            //}
            return true;
        }

        private void frmPad_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            e.Cancel = !SaveQuestion();
        }

        public event EventHandler ShowPopupMenu;

        void RaiseShowPopupMenu() {
            if(ShowPopupMenu != null)
                ShowPopupMenu(null, EventArgs.Empty);
        }
    }
}
