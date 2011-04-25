using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Naz.Hastane.Reports.Classes
{
    public partial class DailyTellerReport : DevExpress.XtraReports.UI.XtraReport
    {
        private double PaymentTotal;
        private double UserTotal;

        public DailyTellerReport()
        {
            InitializeComponent();
        }

        private void lblPaymentTotal_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = PaymentTotal;
            e.Handled = true;
        }

        private void lblPaymentTotal_SummaryReset(object sender, EventArgs e)
        {
            PaymentTotal = 0;
        }

        private void lblPaymentTotal_SummaryRowChanged(object sender, EventArgs e)
        {
            PaymentTotal += Convert.ToDouble(GetCurrentColumnValue("GirenTutar")) - Convert.ToDouble(GetCurrentColumnValue("CikanTutar"));
        }

        private void lblUserTotal_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = UserTotal;
            e.Handled = true;
        }

        private void lblUserTotal_SummaryReset(object sender, EventArgs e)
        {
            UserTotal = 0;
        }

        private void lblUserTotal_SummaryRowChanged(object sender, EventArgs e)
        {
            UserTotal += Convert.ToDouble(GetCurrentColumnValue("GirenTutar")) - Convert.ToDouble(GetCurrentColumnValue("CikanTutar"));
        }

    }
}
