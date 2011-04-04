using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Naz.Hastane.Reports.Classes
{
    public partial class OZETAnaIslemReport : DevExpress.XtraReports.UI.XtraReport
    {
        private double SumHastaC = 0;
        private double SumHastaP = 0;
        private double SumHastaP1 = 0;
        private double SumToplamC = 0;
        private double SumToplamP = 0;
        private double SumToplamP1 = 0;

        public OZETAnaIslemReport()
        {
            InitializeComponent();
        }

        private void celSumHastaY_SummaryRowChanged(object sender, EventArgs e)
        {
            SumHastaC += Convert.ToDouble(GetCurrentColumnValue("HastaC"));
            SumHastaP += Convert.ToDouble(GetCurrentColumnValue("HastaP"));
        }

        private void celSumHastaY_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(SumHastaC, SumHastaP);
            e.Handled = true;
        }

        private void celSumHastaY1_SummaryRowChanged(object sender, EventArgs e)
        {
            SumHastaP1 += Convert.ToDouble(GetCurrentColumnValue("HastaP1"));
        }

        private void celSumHastaY1_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(SumHastaC, SumHastaP1);
            e.Handled = true;
        }

        private void celSumToplamY_SummaryRowChanged(object sender, EventArgs e)
        {
            SumToplamC += Convert.ToDouble(GetCurrentColumnValue("ToplamC"));
            SumToplamP += Convert.ToDouble(GetCurrentColumnValue("ToplamP"));
        }

        private void celSumToplamY_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(SumToplamC, SumToplamP);
            e.Handled = true;
        }

        private void celSumToplamY1_SummaryRowChanged(object sender, EventArgs e)
        {
            SumToplamP1 += Convert.ToDouble(GetCurrentColumnValue("ToplamP1"));
        }

        private void celSumToplamY1_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(SumToplamC, SumToplamP1);
            e.Handled = true;
        }

        private void celSumKisiBasiC_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiv(SumToplamC, SumHastaC);
            e.Handled = true;
        }

        private void celSumKisiBasiP_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiv(SumToplamP, SumHastaP);
            e.Handled = true;
        }

        private void celSumKisiBasiY_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(CalculateDiv(SumToplamC, SumHastaC), CalculateDiv(SumToplamP, SumHastaP));
            e.Handled = true;
        }

        private void celSumKisiBasiP1_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiv(SumToplamP1, SumHastaP1);
            e.Handled = true;
        }

        private void celSumKisiBasiY1_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(CalculateDiv(SumToplamC, SumHastaC), CalculateDiv(SumToplamP1, SumHastaP1));
            e.Handled = true;
        }

        private double CalculateDiff(double aFirst, double aSecond)
        {
            if (aSecond == 0)
                return 0;
            else
                return (aFirst - aSecond) / aSecond;
        }

        private double CalculateDiv(double aFirst, double aSecond)
        {
            if (aSecond == 0)
                return 0;
            else
                return aFirst / aSecond;
        }

    }
}
