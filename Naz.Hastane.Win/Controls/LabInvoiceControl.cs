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
using Naz.Hastane.Data.Entities.LookUp.General;
using Naz.Hastane.Win.Forms;

namespace Naz.Hastane.Win.Controls
{
    public partial class LabInvoiceControl : DevExpress.XtraEditors.XtraUserControl
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

        private GridCheckMarksSelectionWeb selectionVisitDetail;

        public LabInvoiceControl()
        {
            InitializeComponent();

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
            this.luePaymentType.EditValue = PaymentType.DefaultValue;

            UIUtilities.BindLookUpEdit(this.lueVAT, LookUpServices.VATs);
            this.lueVAT.EditValue = VAT.DefaultValue;

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
            QueryPatientVisits();
        }

        private void QueryPatientVisits()
        {
            this.ceAdvancePayment.Checked = false;
            this.cePayment.Checked = false;
            this.luePaymentType.EditValue = VAT.DefaultValue;
            this.lueVAT.EditValue = PaymentType.DefaultValue;
        }

        public void QueryPatientVisitDetails()
        {
            selectionVisitDetail.ClearSelection();
            gvPatientVisitDetails.BeginDataUpdate();
            this.gcPatientVisitDetails.DataSource = PatientServices.GetPatientVisitDetailsForLabInvoice(_Session, _Patient);
            try
            {
                gvPatientVisitDetails.ClearSorting();
                gvPatientVisitDetails.Columns["PatientVisit.VisitNo"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
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
            //selectionVisit.WillRaiseSelectionEvent = false;
            //for (int i = 0; i < this.gvPatientVisitDetails.RowCount; i++)
            //{
            //    PatientVisitDetail pvd = (PatientVisitDetail)this.gvPatientVisitDetails.GetRow(i);
            //    if (pvd != null && selectionVisitDetail.IsRowSelected(i))
            //        if (pvd.KDV != VATPercent)
            //            selectionVisitDetail.InvertRowSelection(i);
            //}
            //selectionVisit.WillRaiseSelectionEvent = true;

            CalculatePatientVisitDetailTotal();
        }

        private void SelectVisitDetailsForVAT()
        {
            selectionVisitDetail.WillRaiseSelectionEvent = false;
            selectionVisitDetail.ClearSelection();
            Double.TryParse(this.lueVAT.Text, out VATPercent);

            for (int i = 0; i < this.gvPatientVisitDetails.RowCount; i++)
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
                ProductTotal += pvd.ADET * pvd.PatientPrice;
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
            //for (int i = 0; i < selectionVisit.SelectedCount; i++)
            //{
            //    PatientVisit pv = (PatientVisit)selectionVisit.GetSelectedRow(i);
            //    pvd.Add(pv);
            //}
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
                this.luePaymentType.EditValue = VAT.DefaultValue;
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

            if (InvoiceTotal > 0 && RemainingTotal == 0)
                if (VATPercent == 0)
                {
                    sbInvoice.Enabled = false;
                }
                else
                {
                    sbInvoice.Enabled = true;
                }
            else
            {
                sbInvoice.Enabled = false;
            }

            this.tePatientVisitDetailTotal.EditValue = InvoiceTotal;

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
            if (cePayment.Checked)
                tePayment.EditValue = Math.Round(InvoiceTotal - AdvancePaymentUsed, 2);
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
            //AddInvoice();
        }

        private void AddInvoice()
        {
            string paymentType = this.luePaymentType.EditValue.ToString();
            string POSType = "";

            //if (String.IsNullOrWhiteSpace(NewTellerInvoiceNo))
            //{
            //    SimpleMsgBoxForm.ShowMsgBox("Bu Kullanıcıya Vezne Tanımlı Değildir!", "Vezne Uyarısı", true);
            //    return;
            //}

            if (this.luePOS.EditValue != null)
                POSType = this.luePOS.EditValue.ToString();

            IList<PatientVisit> pvs = GetSelectedVisits();
            PatientVisit pv = null;
            if (pvs.Count > 0)
                pv = pvs[0];
            IList<PatientVisitDetail> pvds = GetSelectedVisitDetails();
            if (pv != null && pvds.Count > 0)
            {
                UIUtilities.PrintInvoice(_Session, _Patient, pvds,
                    paymentType, POSType,
                    ProductTotal,
                    VATTotal,
                    InvoiceTotal,
                    Discount,
                    VATPercent,
                    Payment,
                    AdvancePaymentUsed,
                    "",
                    true
                    );
                QueryPatientVisits();
            }
        }
        private void sbVoucher_Click(object sender, EventArgs e)
        {
            string paymentType = this.luePaymentType.EditValue.ToString();
            string POSType = "";

            //if (String.IsNullOrWhiteSpace(NewTellerVoucherNo))
            //{
            //    SimpleMsgBoxForm.ShowMsgBox("Bu Kullanıcıya Vezne Tanımlı Değildir!", "Vezne Uyarısı", true);
            //    return;
            //}

            if (VATPercent != 0)
                return;

            if (!cePayment.Checked)
                cePayment.Checked = true;

            if (Payment == 0)
                return;

            if (this.luePOS.EditValue != null)
                POSType = this.luePOS.EditValue.ToString();

            IList<PatientVisitDetail> pvds = GetSelectedVisitDetails();
            if (pvds.Count > 0)
            {
                UIUtilities.PrintVoucher(_Session, _Patient, pvds,
                    paymentType, POSType,
                    Payment,
                    "",
                    true
                    );
                QueryPatientVisits();
            }
        }

        private void sbRefresh_Click(object sender, EventArgs e)
        {
            QueryPatientVisits();
        }

    }
}
