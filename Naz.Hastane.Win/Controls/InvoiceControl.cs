using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using NHibernate;
using Naz.Hastane.Win.Utilities;
using DevExpress.XtraGrid.Views.Base;

namespace Naz.Hastane.Win.Controls
{
    public partial class InvoiceControl : DevExpress.XtraEditors.XtraUserControl
    {
        private ISession _Session;
        private GridCheckMarksSelectionWeb selectionVisit;
        private GridCheckMarksSelectionWeb selectionVisitDetail;

        public InvoiceControl()
        {
            InitializeComponent();
        }

        private void InvoiceControl_Load(object sender, EventArgs e)
        {
            selectionVisit = new GridCheckMarksSelectionWeb(this.gvPatientVisits);
            selectionVisit.CheckMarkColumn.VisibleIndex = 0;
            selectionVisitDetail = new GridCheckMarksSelectionWeb(this.gvPatientVisitDetails);
            selectionVisitDetail.CheckMarkColumn.VisibleIndex = 0;

            if (!DesignMode) LoadLookUps();

        }

        private void LoadLookUps()
        {
            UIUtilities.BindLookUpEdit(this.luePaymentType, LookUpServices.PaymentTypes);
            UIUtilities.BindLookUpEdit(this.lueVAT, LookUpServices.VATs);
            this.lueVAT.EditValue = "0";
        }

        public void QueryPatientVisits(ISession session, Patient patient)
        {
            _Session = session;
            if (patient != null)
            {
                selectionVisit.ClearSelection();
                this.gcPatientVisits.DataSource = PatientServices.GetPatientVisitsForInvoice(session, patient);
            }
        }

        public void QueryPatientVisitDetails()
        {
            IList<PatientVisit> pvs = new List<PatientVisit>();

            for (int i = 0; i < selectionVisit.SelectedCount; i++)
            {
                PatientVisit pv = (PatientVisit)selectionVisit.GetSelectedRow(i);
                pvs.Add(pv);
            }

            selectionVisitDetail.ClearSelection();
            this.gcPatientVisitDetails.DataSource = PatientServices.GetPatientVisitDetailsForInvoice(_Session, pvs);
            gvPatientVisitDetails.BeginDataUpdate();
            try
            {
                gvPatientVisitDetails.ClearSorting();
                gvPatientVisitDetails.Columns["PatientVisit.VisitNo"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
                gvPatientVisitDetails.Columns["DetailNo"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
            finally
            {
                gvPatientVisitDetails.EndDataUpdate();
            }
        }

        public void QueryPatientAdvancePayments(ISession session, Patient patient)
        {
            if (patient != null)
                this.gcAdvancePayments.DataSource = PatientServices.GetPatientAdvancePaymentsForInvoice(session, patient);
        }

        private void gvPatientVisits_Click(object sender, EventArgs e)
        {
            QueryPatientVisitDetails();
        }

        private void gvAdvancePayments_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Total" && e.IsGetData)
            {
                AdvancePayment ap = (AdvancePayment)(sender as ColumnView).GetRow(e.ListSourceRowIndex);
                if (ap != null)
                    e.Value = ap.TUTAR - (ap.KULLANILAN + ap.IADEEDILEN);
            }
        }

    }
}
