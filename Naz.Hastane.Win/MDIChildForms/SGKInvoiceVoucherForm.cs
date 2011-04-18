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
    public partial class SGKInvoiceVoucherForm : MDIChildForm
    {
        public SGKInvoiceVoucherForm()
        {
            InitializeComponent();
            QueryPatients();
            frmMain frm = (frmMain)this.MdiParent;
            invoiceControl.SetMainForm(frm);
        }

        private void QueryPatients()
        {
            this.gcPatients.DataSource = PatientServices.GetPatientsForInvoice(Session);
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

        private void gvPatients_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RefreshDetails();
        }
    }
}