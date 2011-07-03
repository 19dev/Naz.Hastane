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
    public partial class InvoiceVoucherForm : MDIChildForm
    {
        InsuranceCompany _InsuranceCompany = null;
        bool _IsLoading = true;

        public InvoiceVoucherForm()
        {
            _IsLoading = true;
            InitializeComponent();
            frmMain frm = (frmMain)this.MdiParent;
            invoiceControl.SetMainForm(frm);
            this.deStartDate.DateTime = DateTime.Today;
            this.deEndDate.DateTime = DateTime.Today;
            _IsLoading = false;
            QueryPatients();
        }

        private void QueryPatients()
        {
            if (_IsLoading) return;

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                this.Text = String.Format("Fatura Makbuz Basma Ekranı ({0})", GetSelectedInsuranceCompanyName());
                this.gcPatients.DataSource = PatientServices.GetPatientsForInvoice(Session, _InsuranceCompany, deStartDate.DateTime.Date, deEndDate.DateTime.Date);
                RefreshDetails();
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

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

        private string GetSelectedInsuranceCompanyName()
        {
            if (_InsuranceCompany == null)
                return "Hepsi";
            else
                return _InsuranceCompany.Name;
        }

        private void gvPatients_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RefreshDetails();
        }

                #region Change Insurance Company
        private void ddbChangeInsuranceCompany_Click(object sender, EventArgs e)
        {
            SelectInsuranceCompanyForm frm = new SelectInsuranceCompanyForm();
            frm.ShowDialog();
            if (frm.IsSelected)
                ChangeInsuranceCompany(frm.InsuranceCompany);
        }

        private void iSGK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeInsuranceCompany(LookUpServices.GetSGK(Session));
        }

        private void iSGKAcil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeInsuranceCompany(LookUpServices.GetSGKAcil(Session));
        }

        private void iNormal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeInsuranceCompany(LookUpServices.GetNormalPatientCode(Session));
        }

        private void iOzelHasta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeInsuranceCompany(LookUpServices.GetSpecialPatientCode(Session));
        }

        private void iAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeInsuranceCompany(null);
        }

        private void ChangeInsuranceCompany(InsuranceCompany newInsuranceCompany)
        {
            if (_InsuranceCompany == newInsuranceCompany) return;

            _InsuranceCompany = newInsuranceCompany;
            QueryPatients();
        }
                #endregion

    }
}