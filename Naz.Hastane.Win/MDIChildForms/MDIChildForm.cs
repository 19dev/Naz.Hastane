using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using NHibernate;
using Naz.Hastane.Data.Entities;
using DevExpress.XtraGrid.Views.Grid;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using Naz.Hastane.Win.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class MDIChildForm : DevExpress.XtraEditors.XtraForm
    {
        public MDIChildForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        #region Session

        private ISession session;
        private IStatelessSession statelessSession;
        protected ISessionFactory SessionFactory
        {
            get { return Naz.Hastane.Data.NHibernateSessionManager.Instance.GetSessionFactory(); }
        }

        protected ISession Session
        {
            get
            {
                if (session == null)
                    session = SessionFactory.OpenSession();
                return session;
            }
        }

        protected IStatelessSession StatelessSession
        {
            get
            {
                if (statelessSession == null)
                    statelessSession = SessionFactory.OpenStatelessSession();
                return statelessSession;
            }
        }
        protected void ReplaceSessionAfterError()
        {
            if (session != null)
            {
                session.Dispose();
                session = SessionFactory.OpenSession();
                ReplaceEntitiesLoadedByFaultedSession();
            }
            if (statelessSession != null)
            {
                statelessSession.Dispose();
                statelessSession = SessionFactory.OpenStatelessSession();
            }
        }
        protected virtual void ReplaceEntitiesLoadedByFaultedSession()
        {
            throw new InvalidOperationException(
                @"ReplaceSessionAfterError was called, but the presenter does not override ReplaceEntitiesLoadedByFaultedSession!
You must override ReplaceEntitiesLoadedByFaultedSession to call ReplaceSessionAfterError.");
        }

        public void ReOpenSession()
        {
            session.Clear();
            session.Close();
            session.Dispose();
            session = SessionFactory.OpenSession();
        }

        public virtual void MyDispose()
        {
            if (session != null)
            {
                session.Clear();
                session.Dispose();
            }
            if (statelessSession != null)
                statelessSession.Dispose();
            //View.Close();
            //Disposed();
        }
        #endregion

        bool modified = false;
        bool newDocument = true;

        public bool Modified
        {
            get { return modified; }
            set
            {
                if (value != modified)
                {
                    modified = value;
                    //this.Text = DocName + (Modified ? "*" : "");
                    //if(MdiParent != null) ((frmMain)MdiParent).UpdateText();
                }
            }
        }
        public bool NewDocument { get { return this.newDocument; } }

        bool SaveQuestion()
        {
            //if(Modified) {
            //    switch(DevExpress.XtraEditors.SimpleMsgBoxForm.ShowMsgBox("Do you want to save the changes you made to " + DocName + "?", "SimplePad Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
            //        case DialogResult.Cancel:
            //            return false;
            //        case DialogResult.Yes:
            //            SaveAs();
            //            break;
            //    }
            //}
            return true;
        }

        private void frmPad_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //e.Cancel = !SaveQuestion();
        }

        public event EventHandler ShowPopupMenu;

        void RaiseShowPopupMenu()
        {
            if (ShowPopupMenu != null)
                ShowPopupMenu(null, EventArgs.Empty);
        }

        private void MDIChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyDispose();
        }

        protected virtual void ReLoadForm(){}

        #region DetailTemplates
        protected void AddDetail<TForm, T>()
            where TForm : DetailEditForm<T>, new()
            where T : IDBase, new()
        {
            using (TForm frm = new TForm())
            {
                frm.DetailFormParams(0);
                frm.ShowDialog();
                if (frm.IsOK)
                    ReLoadForm();
            }
        }

        protected void ChangeDetail<TForm, T>(GridView gv)
            where TForm : DetailEditForm<T>, new()
            where T : IDBase, new()
        {
            T o = gv.GetFocusedRow() as T;
            if (o != null)
                using (TForm frm = new TForm())
                {
                    frm.DetailFormParams(o.ID);
                    frm.ShowDialog();
                    if (frm.IsOK)
                        ReLoadForm();
                }
        }

        protected void DeleteDetail<TObject>(GridView gv, string deleteSuccesful, string deleteFail, string msgCaption) where TObject : IDBase
        {
            TObject o = gv.GetFocusedRow() as TObject;
            if (o != null)
            {
                try
                {
                    LookUpServices.Delete(Session, o);
                    ReLoadForm();
                    SimpleMsgBoxForm.ShowMsgBox(deleteSuccesful, msgCaption, false);
                }
                catch (Exception error)
                {
                    SimpleMsgBoxForm.ShowMsgBox(deleteFail + error.Message, msgCaption);
                }
            }
        }
        #endregion

    }

}
