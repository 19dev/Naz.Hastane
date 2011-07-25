using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class LastVisitedPatientsForm : MDIChildForm
    {
        public LastVisitedPatientsForm()
        {
            InitializeComponent();
        }

        private void sbRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            gcUserPatientVisit.DataSource = LookUpServices.GetAllUserPatientVisits(UIUtilities.CurrentUser);
        }

        private void gvUserPatientVisit_DoubleClick(object sender, EventArgs e)
        {
            string cellValue = gvUserPatientVisit.GetFocusedRowCellDisplayText("PatientNo");
            (this.MdiParent as frmMain).OpenSGKPatient(cellValue);

        }

        private void LastVisitedPatientsForm_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}