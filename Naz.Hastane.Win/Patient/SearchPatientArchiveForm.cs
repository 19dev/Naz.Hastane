using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Win.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SearchPatientArchiveForm : MDIChildForm
    {
        public SearchPatientArchiveForm()
        {
            InitializeComponent();
        }

        private void bntSelect_Click(object sender, EventArgs e)
        {
            OpenDetail();
        }

        private void OpenDetail()
        {
            Patient patient = gvPatients.GetFocusedRow() as Patient;
            if (patient != null)
            {
                using (PatientArchiveEditForm paef = new PatientArchiveEditForm())
                {
                    paef.Patient = patient;
                    paef.ShowDialog();
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

                //GetCriteria(this.teTCId, ref criteriaString, "TCId");
                //GetCriteria(this.tePatientNo, ref criteriaString, "PatientNo");
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
                    this.gcPatients.DataSource = patients;
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
                    NoPatientRecord();
                }
                else
                    this.gcPatients.DataSource = result;

                return true;
            }

            return false;
        }

        private bool SearchByPatientNo()
        {
            string patientNo = this.tePatientNo.Text;
            if (!String.IsNullOrWhiteSpace(patientNo) && patientNo.Length < 6)
                patientNo = patientNo.PadLeft(6, '0');

            if (PatientServices.IsValidPatientNo(patientNo))
            {
                IList<Patient> result = PatientServices.GetByPatientNo(patientNo);
                if (result.Count == 0)
                {
                    NoPatientRecord();
                }
                else
                    this.gcPatients.DataSource = result;
                return true;
            }

            return false;
        }

        private void NoPatientRecord()
        {
            SimpleMsgBoxForm.ShowMsgBox("Bu Kriterlere Uygun Kayıt Bulunamadı", "Hasta Kayıtı Arama", true);
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

            this.gcPatients.DataSource = new List<Patient>();

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