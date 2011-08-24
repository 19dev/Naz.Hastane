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
using System.Linq.Expressions;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SearchPatientForm : MDIChildForm
    {
        public SearchPatientForm()
        {
            InitializeComponent();
        }

        private void bntSelect_Click(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
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

                GetCriteria(this.teTCId, ref criteriaString, "TCId");
                GetCriteria(this.tePatientNo, ref criteriaString, "PatientNo");
                GetCriteria(this.teFirstName, ref criteriaString, "FirstName");
                GetCriteria(this.teLastName, ref criteriaString, "LastName");
                GetCriteria(this.teFatherName, ref criteriaString, "FatherName");
                GetCriteria(this.teBirthPlace, ref criteriaString, "BirthPlace");

                //List<Expression<Func<Patient, bool>>> predicates = new List<Expression<Func<Patient, bool>>>();
                //predicates.Add(x => x.TCId == "");

                if (criteriaString.Length > 0)
                {
                    IList<Patient> patients = PatientServices.GetByWhere(criteriaString);
                    this.lcHastaAdeti.Text = "Bulunan:" + patients.Count.ToString();
                    this.gridHastaArama.DataSource = patients;
                    if (patients.Count == 1)
                    {
                        (this.MdiParent as frmMain).OpenSGKPatient(patients[0].PatientNo);
                    }
                    else if (patients.Count == 0)
                    {
                        if (XtraMessageBox.Show("Bu Kriterlerle Bir Hasta Kayıtlı Değil, Yeni Hasta Kayıtı Yaratmak İster Misiniz?", "Hasta Kayıtı Arama", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            (this.MdiParent as frmMain).OpenNewSGKPatient();
                        }
                    }
                }
                //this.AcceptButton = this.sbSec;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        private bool SearchByTCID()
        {
            string TCID = this.teTCId.Text;
            if (LookUpServices.IsValidTCID(TCID))
            {
                IList<Patient> result = PatientServices.GetByTCId(TCID);
                if (result.Count == 0)
                {
                    if (XtraMessageBox.Show("Bu TC Kimlik Numaralı Bir Hasta Kayıtlı Değil, Yeni Hasta Kayıtı Yaratmak İster Misiniz?", "Hasta Kayıtı Arama", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        (this.MdiParent as frmMain).OpenNewSGKPatientWithTCID(TCID);
                        return true;
                    }
                }
                else if (result.Count == 1)
                {
                    (this.MdiParent as frmMain).OpenSGKPatient(result[0].PatientNo);
                    return true;
                }
            }

            return false;
        }

        private bool SearchByPatientNo()
        {
            string patientNo = this.tePatientNo.Text;
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
        //private void AddPredicate(List<Expression<Func<Patient, bool>>> predicates, Control c, )
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

        private void btnClean_Click(object sender, EventArgs e)
        {
            this.teTCId.Text = "";
            this.tePatientNo.Text = "";
            this.teFirstName.Text = "";
            this.teLastName.Text = "";
            this.teFatherName.Text = "";

            this.gridHastaArama.DataSource = new List<Patient>();

            this.AcceptButton = this.sbSearch;
        }

        private void gridHastaArama_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenDetail();
        }

        private void sbNew_Click(object sender, EventArgs e)
        {
            (this.MdiParent as frmMain).OpenNewSGKPatient();
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SGKFindPatientForm_Shown(object sender, EventArgs e)
        {
            this.teTCId.Focus();
        }
    }
}