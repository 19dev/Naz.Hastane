using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Naz.Hastane.Reports.Classes
{
    public partial class OZETAYPKurumReport : DevExpress.XtraReports.UI.XtraReport
    {
        private double SumHastaC = 0;
        private double SumHastaP = 0;
        private double SumHastaP1 = 0;
        private double SumToplamC = 0;
        private double SumToplamP = 0;
        private double SumToplamP1 = 0;

        private double SumHastaGC = 0;
        private double SumHastaGP = 0;
        private double SumHastaGP1 = 0;
        private double SumToplamGC = 0;
        private double SumToplamGP = 0;
        private double SumToplamGP1 = 0;

        public OZETAYPKurumReport()
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

        private void celSumHastaGY_SummaryReset(object sender, EventArgs e)
        {
            //SumHastaGC = 0;
            //SumHastaGP = 0;
        }

        private void celSumHastaGY_SummaryRowChanged(object sender, EventArgs e)
        {
            SumHastaGC += Convert.ToDouble(GetCurrentColumnValue("HastaC"));
            SumHastaGP += Convert.ToDouble(GetCurrentColumnValue("HastaP"));
        }

        private void celSumHastaGY_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(SumHastaGC, SumHastaGP);
            e.Handled = true;
        }

        private void celSumHastaGY1_SummaryReset(object sender, EventArgs e)
        {
            //SumHastaGP1 = 0;
        }

        private void celSumHastaGY1_SummaryRowChanged(object sender, EventArgs e)
        {
            SumHastaGP1 += Convert.ToDouble(GetCurrentColumnValue("HastaP1"));
        }

        private void celSumHastaGY1_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(SumHastaGC, SumHastaGP1);
            e.Handled = true;
        }

        private void celSumToplamGY_SummaryReset(object sender, EventArgs e)
        {
            SumToplamGC = 0;
            SumToplamGP = 0;
        }

        private void celSumToplamGY_SummaryRowChanged(object sender, EventArgs e)
        {
            //SumToplamGC += Convert.ToDouble(GetCurrentColumnValue("ToplamC"));
            //SumToplamGP += Convert.ToDouble(GetCurrentColumnValue("ToplamP"));
        }

        private void celSumToplamGY_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(SumToplamGC, SumToplamGP);
            e.Handled = true;
        }

        private void celSumToplamGY1_SummaryReset(object sender, EventArgs e)
        {
            //SumToplamGP1 = 0;
        }

        private void celSumToplamGY1_SummaryRowChanged(object sender, EventArgs e)
        {
            SumToplamGP1 += Convert.ToDouble(GetCurrentColumnValue("ToplamP1"));
        }

        private void celSumToplamGY1_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(SumToplamGC, SumToplamGP1);
            e.Handled = true;
        }

        private void celSumKisiBasiGC_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiv(SumToplamGC, SumHastaGC);
            e.Handled = true;
        }

        private void celSumKisiBasiGP_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiv(SumToplamGP, SumHastaGP);
            e.Handled = true;
        }

        private void celSumKisiBasiGY_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(CalculateDiv(SumToplamGC, SumHastaGC), CalculateDiv(SumToplamGP, SumHastaGP));
            e.Handled = true;
        }

        private void celSumKisiBasiGP1_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiv(SumToplamGP1, SumHastaGP1);
            e.Handled = true;
        }

        private void celSumKisiBasiGY1_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(CalculateDiv(SumToplamGC, SumHastaGC), CalculateDiv(SumToplamGP1, SumHastaGP1));
            e.Handled = true;
        }

        private void GroupHeader1_AfterPrint(object sender, EventArgs e)
        {
            SumHastaGC = 0;
            SumHastaGP = 0;
            SumHastaGP1 = 0;
            SumToplamGC = 0;
            SumToplamGP = 0;
            SumToplamGP1 = 0;
        }

    }
}
