using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Multicast;
using System.Net;
using Naz.Hastane.Data.Services;
using NHibernate;
using Nini.Config;
using System.IO;
using Naz.Hastane.Data;

namespace Naz.Hastane.Ameliyathane
{
    public partial class MainForm : Form
    {

        private int counter = 0;
        private string message;
        private byte[] receivedData;

        MulticastSettings testSettings = new MulticastSettings()
        {
            Address = IPAddress.Parse("239.1.2.3"),
            Port = 40404,
            TimeToLive = 0
        };

        IMulticastListener receiver;

        public MainForm()
        {
            InitializeComponent();

            receiver = new MulticastListener(testSettings);
            receiver.StartListening(ReceiveCallback);

            IConfigSource cs = ConfigurationSource;

            NHibernateSessionManager.Instance.DatabaseServer = cs.Configs["Database"].Get("Server", "DBSERVER");
            NHibernateSessionManager.Instance.DatabaseName = cs.Configs["Database"].Get("Name", "TIPDATA");
            NHibernateSessionManager.Instance.DatabaseUserName = cs.Configs["Database"].Get("UserName", "sa");
            NHibernateSessionManager.Instance.DatabasePassword = cs.Configs["Database"].Get("Password", "");

            ReLoadForm();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        public void ReceiveCallback(byte[] data)
        {
            receivedData = data;
            Invoke(new MethodInvoker(ProcessMessage));
        }

        public void ProcessMessage()
        {
            //string s = Encoding.UTF8.GetString(receivedData);
            //var messages = s.Split(';');
            //if (messages.Length > 1)
            //{
            //    if (Properties.Settings.Default.DoctorID.Contains(messages[0]))
            //    {
            //        message = messages[1];
            //        lblQueue.Text = message;
            //        lblQueue.Visible = true;
            //        countDown = 0;
            //        timer.Enabled = true;
            //    }
            //}
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lciAmeliyatListe.Text = "Ameliyat Listesi (" + DateTime.Now + ")";
            counter++;
            if (counter > 10)
            {
                counter = 0;
                ReLoadForm();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyDispose();
        }

        protected void ReLoadForm()
        {
            ReOpenSession();
            gcAmeliyatListe.DataSource = PatientServices.GetDailyAmeliyatListe(Session, DateTime.Today);
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
            if (session != null)
            {
                session.Clear();
                session.Close();
                session.Dispose();
                session = SessionFactory.OpenSession();
            }
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

        private static IConfigSource _Configuration = null;
        public static IConfigSource ConfigurationSource
        {
            get
            {
                string appPath = Application.StartupPath;
                appPath = Path.Combine(appPath, "Naz.Hastane.Ameliyathane.ini");
                if (_Configuration == null)
                {
                    try
                    {
                        _Configuration = new IniConfigSource(appPath);
                        if (_Configuration.Configs["User"] == null)
                        {
                            _Configuration.AddConfig("User");
                            _Configuration.Save();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message + "\n\r" + appPath);
                    }

                }
                return _Configuration;
            }
        }


    }
}
