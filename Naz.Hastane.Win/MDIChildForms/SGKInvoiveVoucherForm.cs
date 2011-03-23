using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SGKInvoiveVoucherForm : MDIChildForm
    {
        public SGKInvoiveVoucherForm()
        {
            InitializeComponent();
            QueryPatients();
        }

        private void QueryPatients()
        {
            this.gcPatients.DataSource = PatientServices.GetPatientsForInvoice();
        }

        private void QueryPatientVisits()
        {
            Patient p = (Patient)this.gvPatients.GetFocusedRow();
            if (p != null)
                this.gcPatientVisits.DataSource = PatientServices.GetPatientVisitsForInvoice(p);
        }

        private void QueryPatientVisitDetails()
        {
            PatientVisit pv = (PatientVisit)this.gvPatientVisits.GetFocusedRow();
            if (pv != null)
            {
                this.gcPatientVisitDetails.DataSource = PatientServices.GetPatientVisitDetailsForInvoice(pv);
            }
        }

        private void gvPatients_Click(object sender, EventArgs e)
        {
            QueryPatientVisits();
            QueryPatientVisitDetails();
        }

        private void gvPatientVisits_Click(object sender, EventArgs e)
        {
            QueryPatientVisitDetails();
        }

    }
}