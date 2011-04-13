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
            this.gcPatients.DataSource = PatientServices.GetPatientsForInvoice(Session);
        }

        private void gvPatients_Click(object sender, EventArgs e)
        {
            RefreshDetails();
        }

        private void RefreshDetails()
        {
            this.invoiceControl.QueryPatientVisits(Session, (Patient)this.gvPatients.GetFocusedRow());
            this.invoiceControl.QueryPatientVisitDetails();
            this.invoiceControl.QueryPatientAdvancePayments(Session, (Patient)this.gvPatients.GetFocusedRow());
        }

        private void sbRefresh_Click(object sender, EventArgs e)
        {
            QueryPatients();
        }
    }
}