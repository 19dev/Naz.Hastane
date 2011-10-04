using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NHibernate;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Win.Forms;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data.Entities.LookUp.General;

namespace Naz.Hastane.Win.Controls
{
    public partial class AdvancePaymentsControl : DevExpress.XtraEditors.XtraUserControl
    {
        private ISession _Session;
        private Patient _Patient;
        private PatientVisit currentPatientVisit;

        public AdvancePaymentsControl()
        {
            InitializeComponent();
        }

        private void AdvancePaymentsControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                LoadLookUps();
                teVoucherNo.Text = LookUpServices.GetNewTellerVoucherNo(UIUtilities.GetVoucherUser(), false);
                teAmount.Text = "0";
            }
        }

        private void LoadLookUps()
        {
            UIUtilities.BindLookUpEdit(this.luePaymentType, LookUpServices.PaymentTypes);
            this.luePaymentType.EditValue = PaymentType.DefaultValue;

            UIUtilities.BindLookUpEdit(this.luePOS, LookUpServices.POSs);
        }

        public void QueryPatientVisits(ISession session, Patient patient)
        {
            _Session = session;
            _Patient = patient;
            QueryPatientVisits();
        }

        private void QueryPatientVisits()
        {
            try
            {
                gcPatientVisits.DataSource = _Patient.PatientVisits;

                QueryAdvancePayments();
            }
            catch (Exception ex)
            {
                SimpleMsgBoxForm.ShowMsgBox("Avans Kayıtları Okunamadı:" + ex.Message, "Avans Kayıtları Okuma Uyarısı", true);
            }

        }
        private void QueryAdvancePayments()
        {
            currentPatientVisit = (PatientVisit)gvPatientVisits.GetFocusedRow();
            if (currentPatientVisit != null)
                gcAdvancePayments.DataSource = currentPatientVisit.AdvancePayments;
        }

        private void gvPatientVisits_Click(object sender, EventArgs e)
        {
            QueryAdvancePayments();
        }

        private void sbAddAdvancePayment_Click(object sender, EventArgs e)
        {
            AddAdvancePayment();
        }

        private void AddAdvancePayment()
        {
            double Payment;

            double.TryParse(this.teAmount.Text, out Payment);
            Payment = Math.Round(Payment, 2);

            if (Payment == 0)
            {
                SimpleMsgBoxForm.ShowMsgBox("Lütfen Avans Miktarını Giriniz!", "Vezne Uyarısı", true);
                return;
            }

            string tellerVoucherNo = this.teVoucherNo.Text;
            if (String.IsNullOrWhiteSpace(tellerVoucherNo))
            {
                SimpleMsgBoxForm.ShowMsgBox("Bu Kullanıcıya Vezne Tanımlı Değildir!", "Vezne Uyarısı", true);
                return;
            }

            string paymentType = this.luePaymentType.EditValue.ToString();

            string POSType = "";
            if (this.luePOS.EditValue != null)
                POSType = this.luePOS.EditValue.ToString();

            try
            {
                PatientServices.AddNewAdvancePayment(_Session, UIUtilities.GetVoucherUser(), currentPatientVisit, paymentType, POSType, tellerVoucherNo, Payment);
                teVoucherNo.Text = LookUpServices.GetNewTellerVoucherNo(UIUtilities.GetVoucherUser(), false);
                teAmount.Text = "0";
            }
            catch (Exception ex)
            {
                SimpleMsgBoxForm.ShowMsgBox("Avans Girişi Yapılamadı:" + ex.Message, "Avans Girişi Uyarısı", true);
            }
        }

        private void sbCancelAdvancePayment_Click(object sender, EventArgs e)
        {
            CancelAdvancePayment();
        }

        private void CancelAdvancePayment()
        {
            AdvancePayment advancePayment = (AdvancePayment)gvAdvancePayments.GetFocusedRow();

            if (advancePayment != null &&
                SimpleMsgBoxForm.ShowYesNo(String.Format("{0} Tutarında Avansı İade Edilecektir.\r\nDevam Etmek İstadiğinizden Emin Misiniz?", advancePayment.KALAN ?? 0), "Avans İade Uyarısı", true) == DialogResult.Yes)
            {
                try
                {
                    PatientServices.RebateAdvancePayment(_Session, UIUtilities.CurrentUser, advancePayment);
                }
                catch (Exception ex)
                {
                    SimpleMsgBoxForm.ShowMsgBox("Avans İade Edilemedi:" + ex.Message, "Avans İade Uyarısı", true);
                }
            }
        }

        private void luePaymentType_EditValueChanged(object sender, EventArgs e)
        {
            this.luePOS.Enabled = (this.luePaymentType.EditValue.ToString() == "K");
        }
    }
}
