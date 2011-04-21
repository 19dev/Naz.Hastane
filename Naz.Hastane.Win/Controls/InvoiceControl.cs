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
        private Patient _Patient;
        private frmMain theMainForm;

        private double ProductTotal = 0;
        private double VATPercent = 0;
        private double Discount = 0;
        private double InvoiceTotal = 0;
        private double Payment = 0;
        private double AdvancePaymentTotal = 0;
        private double AdvancePaymentUsed = 0;
        private double AdvancePaymentRemaining = 0;
        private double GrandTotal = 0;
        private double RemainingTotal;
        private double VATTotal = 0;

        private GridCheckMarksSelectionWeb selectionVisit;
        private GridCheckMarksSelectionWeb selectionVisitDetail;

        public InvoiceControl()
        {
            InitializeComponent();

            selectionVisit = new GridCheckMarksSelectionWeb(this.gvPatientVisits);
            selectionVisit.CheckMarkColumn.VisibleIndex = 0;
            selectionVisit.OnSelectionChanged += new EventHandler<EventArgs>(selectionVisit_OnSelectionChanged);

            selectionVisitDetail = new GridCheckMarksSelectionWeb(this.gvPatientVisitDetails);
            selectionVisitDetail.CheckMarkColumn.VisibleIndex = 0;
            selectionVisitDetail.OnSelectionChanged += new EventHandler<EventArgs>(selectionVisitDetail_OnSelectionChanged);

        }

        private void InvoiceControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                LoadLookUps();
            }
        }

        private void LoadLookUps()
        {
            UIUtilities.BindLookUpEdit(this.luePaymentType, LookUpServices.PaymentTypes);
            this.luePaymentType.EditValue = LookUpServices.VATDefaultValue;
            UIUtilities.BindLookUpEdit(this.lueVAT, LookUpServices.VATs);
            this.lueVAT.EditValue = LookUpServices.PaymentTypeDefaultValue;
            UIUtilities.BindLookUpEdit(this.luePOS, LookUpServices.POSs);
        }

        public void SetMainForm(frmMain frm)
        {
            theMainForm = frm;
        }

        public void QueryPatientVisits(ISession session, Patient patient)
        {
            _Session = session;
            _Patient = patient;

            selectionVisit.ClearSelection();
            this.gcPatientVisits.DataSource = PatientServices.GetPatientVisitsForInvoice(session, patient);
            if (patient != null)
            {
                PatientVisit pv = null;
                if (this.gvPatientVisits.RowCount > 0)
                    pv = (PatientVisit)this.gvPatientVisits.GetRow(0);
                if (pv != null)
                    this.deCardDate.DateTime = pv.VisitDate;
                else
                    this.deCardDate.DateTime = DateTime.Today;

                this.meInvoiceAddress.Text = patient.HomeInvoiceAddress;
            }
            this.deInvoiceDate.DateTime = DateTime.Today;
            this.deExitDate.DateTime = DateTime.Today;

            this.teTaxNo.Text = "";
            this.teTaxOffice.Text = "";
            this.teInvoiceNo.Text = LookUpServices.GetNewTellerInvoiceNo(UIUtilities.CurrentUser, false);
            this.teVoucherNo.Text = LookUpServices.GetNewTellerVoucherNo(UIUtilities.CurrentUser, false);

            this.ceAdvancePayment.Checked = false;
            this.cePayment.Checked = false;
            this.luePaymentType.EditValue = LookUpServices.VATDefaultValue;
            this.lueVAT.EditValue = LookUpServices.PaymentTypeDefaultValue;
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
            gvPatientVisitDetails.BeginDataUpdate();
            this.gcPatientVisitDetails.DataSource = PatientServices.GetPatientVisitDetailsForInvoice(_Session, pvs);
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
            SelectVisitDetailsForVAT();

        }
        public void QueryPatientAdvancePayments(ISession session, Patient patient)
        {
            var aps = PatientServices.GetPatientAdvancePaymentsForInvoice(session, patient);
            this.gcAdvancePayments.DataSource = aps;

            AdvancePaymentTotal = 0;
            foreach (AdvancePayment ap in aps)
                AdvancePaymentTotal += ap.RemainingAmount;
            CalculateTotals();
        }

        void selectionVisit_OnSelectionChanged(object o, EventArgs e)
        {
            QueryPatientVisitDetails();
        }
        void selectionVisitDetail_OnSelectionChanged(object o, EventArgs e)
        {
            CalculatePatientVisitDetailTotal();
        }

        private void SelectVisitDetailsForVAT()
        {
            selectionVisitDetail.WillRaiseSelectionEvent = false;
            selectionVisitDetail.ClearSelection();
            Double.TryParse(this.lueVAT.Text, out VATPercent);

            for(int i = 0; i < this.gvPatientVisitDetails.RowCount; i++)
            {
                PatientVisitDetail pvd = (PatientVisitDetail)this.gvPatientVisitDetails.GetRow(i);
                if (pvd != null)
                    selectionVisitDetail.SelectRow(i, (pvd.KDV == VATPercent));
            }

            selectionVisitDetail.WillRaiseSelectionEvent = true;
            CalculatePatientVisitDetailTotal();
        }

        private void CalculatePatientVisitDetailTotal()
        {
            ProductTotal = 0;
            for (int i = 0; i < selectionVisitDetail.SelectedCount; i++)
            {
                PatientVisitDetail pvd = (PatientVisitDetail)selectionVisitDetail.GetSelectedRow(i);
                ProductTotal += pvd.ADET * pvd.SATISF;
            }
            CalculateTotals();
        }

        private IList<PatientVisitDetail> GetSelectedVisitDetails()
        {
            List<PatientVisitDetail> pvds = new List<PatientVisitDetail>();
            for (int i = 0; i < selectionVisitDetail.SelectedCount; i++)
            {
                PatientVisitDetail pvd = (PatientVisitDetail)selectionVisitDetail.GetSelectedRow(i);
                pvds.Add(pvd);
            }
            return pvds;
        }

        private IList<PatientVisit> GetSelectedVisits()
        {
            List<PatientVisit> pvd = new List<PatientVisit>();
            for (int i = 0; i < selectionVisit.SelectedCount; i++)
            {
                PatientVisit pv = (PatientVisit)selectionVisit.GetSelectedRow(i);
                pvd.Add(pv);
            }
            return pvd;
        }

        private void CalculateTotals()
        {
            this.teAdvancePaymentUsed.Enabled = this.ceAdvancePayment.Checked;
            if (!this.ceAdvancePayment.Checked)
                this.teAdvancePaymentUsed.EditValue = "0";

            this.tePayment.Enabled = this.cePayment.Checked;
            this.luePaymentType.Enabled = this.cePayment.Checked;

            if (!this.cePayment.Checked)
            {
                this.tePayment.EditValue = "0";
                this.luePaymentType.EditValue = LookUpServices.VATDefaultValue;
            }

            this.luePOS.Enabled = (this.luePaymentType.EditValue.ToString() == "K");

            VATPercent = Math.Round(VATPercent, 2);
            VATTotal = Math.Round(ProductTotal * VATPercent / 100.0, 2);
            InvoiceTotal = Math.Round(ProductTotal * (1 + VATPercent / 100.0), 2);

            double.TryParse(this.tePayment.Text, out Payment);
            double.TryParse(this.teAdvancePaymentUsed.Text, out AdvancePaymentUsed);

            Payment = Math.Round(Payment, 2);
            AdvancePaymentUsed = Math.Round(AdvancePaymentUsed, 2);

            AdvancePaymentRemaining = Math.Round(AdvancePaymentTotal - AdvancePaymentUsed, 2);
            GrandTotal = Math.Round(Payment + AdvancePaymentUsed, 2);
            RemainingTotal = Math.Round(InvoiceTotal - GrandTotal, 2);

            this.sbInvoice.Enabled = (InvoiceTotal > 0 && RemainingTotal == 0);

            this.tePatientVisitDetailTotal.EditValue = ProductTotal;
 
            this.teProductTotal.EditValue = ProductTotal;
            this.teVATTotal.EditValue = VATTotal;
            this.teInvoiceTotal.EditValue = InvoiceTotal;

            this.teAdvancePaymentTotal.EditValue = AdvancePaymentTotal;
            this.teAdvancePaymentRemaining.EditValue = AdvancePaymentRemaining;
            this.teGrandTotal.EditValue = GrandTotal;
            this.teRemainingTotal.EditValue = RemainingTotal;
        }

        private void cePayment_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }
        private void ceAdvancePayment_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }
        private void luePaymentType_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }
        private void lueVAT_EditValueChanged(object sender, EventArgs e)
        {
            SelectVisitDetailsForVAT();
        }
        private void teUsedAdvancePayment_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }
        private void tePayment_EditValueChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void sbInvoice_Click(object sender, EventArgs e)
        {
            string NewTellerInvoiceNo = this.teInvoiceNo.Text;
            string paymentType = this.luePaymentType.EditValue.ToString();
            string POSType = this.luePOS.EditValue.ToString();

            IList<PatientVisit> pvs = GetSelectedVisits();
            PatientVisit pv = null;
            if (pvs.Count > 0)
                pv = pvs[0];
            IList<PatientVisitDetail> pvds = GetSelectedVisitDetails();
            if (pv != null && pvds.Count>0)
            {
                theMainForm.PrintInvoice(_Session, _Patient, pvds,
                    paymentType, POSType,
                    ProductTotal,
                    VATTotal,
                    InvoiceTotal,
                    Discount,
                    VATPercent,
                    Payment,
                    AdvancePaymentUsed,
                    NewTellerInvoiceNo
                    );
                this.teInvoiceNo.Text = LookUpServices.GetNewTellerInvoiceNo(UIUtilities.CurrentUser, false);
            }
        }

        private void sbVoucher_Click(object sender, EventArgs e)
        {
            string NewTellerVoucherNo = this.teInvoiceNo.Text;
            string paymentType = this.luePaymentType.EditValue.ToString();
            string POSType = this.luePOS.EditValue.ToString();
            IList<PatientVisitDetail> pvds = GetSelectedVisitDetails();
            if (pvds.Count > 0)
            {
                theMainForm.PrintVoucher(_Session, _Patient, pvds,
                    paymentType, POSType,
                    Payment,
                    NewTellerVoucherNo
                    );
                this.teVoucherNo.Text = LookUpServices.GetNewTellerVoucherNo(UIUtilities.CurrentUser, false);
            }
        }

    }
}
