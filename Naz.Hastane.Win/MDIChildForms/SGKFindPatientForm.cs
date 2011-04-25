using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using DevExpress.Tutorials.Controls;
using DevExpress.XtraEditors.Controls;
using DevExpress.LookAndFeel;
using DevExpress.Data.Filtering;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SGKFindPatientForm : MDIChildForm
    {
        public SGKFindPatientForm
            ()
        {
            InitializeComponent();
        }

        private void bntSec_Click(object sender, EventArgs e)
        {
            OpenDetail();
        }

        private void OpenDetail()
        {
            if (gridView1.GetFocusedRow() != null)
            {
                Cursor.Current = Cursors.WaitCursor;

                try
                {
                    string patientNo;
                    patientNo = gridView1.GetFocusedRowCellDisplayText("PatientNo");
                    (this.MdiParent as frmMain).OpenSGKPatient(patientNo);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            HastaAra();
        }

        private void HastaAra()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (SearchByTCID()) return;
                if (SearchByPatientNo()) return;

                string criteriaString = "";

                GetCriteria(this.teTCKimlikNo, ref criteriaString, "TCId");
                GetCriteria(this.teHastaNo, ref criteriaString, "PatientNo");
                GetCriteria(this.teAdi, ref criteriaString, "FirstName");
                GetCriteria(this.teSoyadi, ref criteriaString, "LastName");
                GetCriteria(this.teBabaAdi, ref criteriaString, "FatherName");

                if (criteriaString.Length > 0)
                {
                    IList<Patient> patients = PatientServices.GetByWhere(criteriaString);
                    this.lcHastaAdeti.Text = "Bulunan:" + patients.Count.ToString();
                    this.gridHastaArama.DataSource = patients;
                    if (patients.Count == 1)
                    {
                        (this.MdiParent as frmMain).OpenSGKPatient(patients[0].PatientNo);
                    }
                }
                this.AcceptButton = this.sbSec;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        private bool SearchByTCID()
        {
            string TCID = this.teTCKimlikNo.Text;
            if (PatientServices.IsValidTCID(TCID))
            {
                Patient patient = PatientServices.GetByTCId(TCID);
                if (patient == null)
                {
                    if (XtraMessageBox.Show("Bu TC Kimlik Numaralı Bir Hasta Kayıtlı Değil, Yeni Hasta Kayıtı Yaratmak İster Misiniz?", "Hasta Kayıtı Arama", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        (this.MdiParent as frmMain).OpenNewSGKPatientWithTCID(TCID);
                    }
                }
                else
                {
                    (this.MdiParent as frmMain).OpenSGKPatient(patient.PatientNo);
                }
                return true;
            }

            return false;
        }

        private bool SearchByPatientNo()
        {
            string patientNo = this.teHastaNo.Text;
            if (PatientServices.IsValidPatientNo(patientNo))
            {
                Patient patient = PatientServices.GetPatientByID(patientNo);
                if (patient == null)
                {
                    if (XtraMessageBox.Show("Bu Hasta Numaralı Bir Hasta Kayıtlı Değil, Yeni Hasta Kayıtı Yaratmak İster Misiniz?", "Hasta Kayıtı Arama", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        (this.MdiParent as frmMain).OpenNewSGKPatient();
                    }
                }
                else
                {
                    (this.MdiParent as frmMain).OpenSGKPatient(patientNo);
                }
                return true;
            }

            return false;
        }

        private void AddCriteria(ref string aCriteria1, string aCriteria2)
        {
            if (aCriteria1.Length > 0)
            {
                aCriteria1 = aCriteria1 + " AND " + aCriteria2;
            }
            else
            {
                aCriteria1 = aCriteria2;
            }
        }

        private void GetCriteria(Control c, ref string aCriteria, string aFieldName)
        {
            if (c.Text.Length > 0) AddCriteria(ref aCriteria, "patient." + aFieldName + " Like '%" + c.Text + "%'");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            this.teTCKimlikNo.Text = "";
            this.teHastaNo.Text = "";
            this.teAdi.Text = "";
            this.teSoyadi.Text = "";
            this.teBabaAdi.Text = "";

            this.AcceptButton = this.sbAra;
        }

        private void gridHastaArama_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenDetail();
        }

        private void frmHastaAra_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Closing");
        }

        private void frmHastaAra_Shown(object sender, EventArgs e)
        {
            this.teTCKimlikNo.Focus();
        }

        private void sbYeni_Click(object sender, EventArgs e)
        {
            //string YeniHastaNo = "";

            //YeniHastaNo = session.ExecuteSproc("a_YeniHastaNo").ResultSet[0].Rows[0].Values[0].ToString();
            //MessageBox.Show("Yeni Hasta No:" + YeniHastaNo);


            (this.MdiParent as frmMain).OpenNewSGKPatient();
        }
    }
}