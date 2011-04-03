using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Naz.Hastane.Reports.Classes
{
    public partial class OZETKurumAnaIslemReport : DevExpress.XtraReports.UI.XtraReport
    {
        private double SumHastaC = 0;
        private double SumHastaP = 0;
        private double SumHastaP1 = 0;
        private double SumToplamC = 0;
        private double SumToplamP = 0;
        private double SumToplamP1 = 0;


        class Sums
        {
            public double SumHastaGC = 0;
            public double SumHastaGP = 0;
            public double SumHastaGP1 = 0;
            public double SumToplamGC = 0;
            public double SumToplamGP = 0;
            public double SumToplamGP1 = 0;
        }

        Sums SumsHastaGY;
        Sums SumsHastaGY1;
        Sums SumsToplamGY;
        Sums SumsToplamGY1;
        Sums SumsKisiBasiGC;
        Sums SumsKisiBasiGP;
        Sums SumsKisiBasiGY;
        Sums SumsKisiBasiGP1;
        Sums SumsKisiBasiGY1;


        public OZETKurumAnaIslemReport()
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
            SumsHastaGY = new Sums();
        }

        private void celSumHastaGY_SummaryRowChanged(object sender, EventArgs e)
        {
            SumsHastaGY.SumHastaGC += Convert.ToDouble(GetCurrentColumnValue("HastaC"));
            SumsHastaGY.SumHastaGP += Convert.ToDouble(GetCurrentColumnValue("HastaP"));
        }

        private void celSumHastaGY_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(SumsHastaGY.SumHastaGC, SumsHastaGY.SumHastaGP);
            e.Handled = true;
        }

        private void celSumHastaGY1_SummaryReset(object sender, EventArgs e)
        {
            SumsHastaGY1 = new Sums();
        }

        private void celSumHastaGY1_SummaryRowChanged(object sender, EventArgs e)
        {
            SumsHastaGY1.SumHastaGC += Convert.ToDouble(GetCurrentColumnValue("HastaC"));
            SumsHastaGY1.SumHastaGP1 += Convert.ToDouble(GetCurrentColumnValue("HastaP1"));
        }

        private void celSumHastaGY1_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(SumsHastaGY1.SumHastaGC, SumsHastaGY1.SumHastaGP1);
            e.Handled = true;
        }

        private void celSumToplamGY_SummaryReset(object sender, EventArgs e)
        {
            SumsToplamGY = new Sums();
        }

        private void celSumToplamGY_SummaryRowChanged(object sender, EventArgs e)
        {
            SumsToplamGY.SumToplamGC += Convert.ToDouble(GetCurrentColumnValue("ToplamC"));
            SumsToplamGY.SumToplamGP += Convert.ToDouble(GetCurrentColumnValue("ToplamP"));
        }

        private void celSumToplamGY_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(SumsToplamGY.SumToplamGC, SumsToplamGY.SumToplamGP);
            e.Handled = true;
        }

        private void celSumToplamGY1_SummaryReset(object sender, EventArgs e)
        {
            SumsToplamGY1 = new Sums();
        }

        private void celSumToplamGY1_SummaryRowChanged(object sender, EventArgs e)
        {
            SumsToplamGY1.SumToplamGC += Convert.ToDouble(GetCurrentColumnValue("ToplamC"));
            SumsToplamGY1.SumToplamGP1 += Convert.ToDouble(GetCurrentColumnValue("ToplamP1"));
        }

        private void celSumToplamGY1_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(SumsToplamGY1.SumToplamGC, SumsToplamGY1.SumToplamGP1);
            e.Handled = true;
        }

        private void celSumKisiBasiGC_SummaryReset(object sender, EventArgs e)
        {
            SumsKisiBasiGC = new Sums();
        }

        private void celSumKisiBasiGC_SummaryRowChanged(object sender, EventArgs e)
        {
            SumsKisiBasiGC.SumHastaGC += Convert.ToDouble(GetCurrentColumnValue("HastaC"));
            SumsKisiBasiGC.SumToplamGC += Convert.ToDouble(GetCurrentColumnValue("ToplamC"));
        }

        private void celSumKisiBasiGC_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiv(SumsKisiBasiGC.SumToplamGC, SumsKisiBasiGC.SumHastaGC);
            e.Handled = true;
        }

        private void celSumKisiBasiGP_SummaryReset(object sender, EventArgs e)
        {
            SumsKisiBasiGP = new Sums();
        }

        private void celSumKisiBasiGP_SummaryRowChanged(object sender, EventArgs e)
        {
            SumsKisiBasiGP.SumHastaGP += Convert.ToDouble(GetCurrentColumnValue("HastaP"));
            SumsKisiBasiGP.SumToplamGP += Convert.ToDouble(GetCurrentColumnValue("ToplamP"));
        }

        private void celSumKisiBasiGP_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiv(SumsKisiBasiGP.SumToplamGP, SumsKisiBasiGP.SumHastaGP);
            e.Handled = true;
        }

        private void celSumKisiBasiGY_SummaryReset(object sender, EventArgs e)
        {
            SumsKisiBasiGY = new Sums();
        }

        private void celSumKisiBasiGY_SummaryRowChanged(object sender, EventArgs e)
        {
            SumsKisiBasiGY.SumHastaGC += Convert.ToDouble(GetCurrentColumnValue("HastaC"));
            SumsKisiBasiGY.SumHastaGP += Convert.ToDouble(GetCurrentColumnValue("HastaP"));
            SumsKisiBasiGY.SumToplamGC += Convert.ToDouble(GetCurrentColumnValue("ToplamC"));
            SumsKisiBasiGY.SumToplamGP += Convert.ToDouble(GetCurrentColumnValue("ToplamP"));
        }

        private void celSumKisiBasiGY_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(CalculateDiv(SumsKisiBasiGY.SumToplamGC, SumsKisiBasiGY.SumHastaGC), CalculateDiv(SumsKisiBasiGY.SumToplamGP, SumsKisiBasiGY.SumHastaGP));
            e.Handled = true;
        }

        private void celSumKisiBasiGP1_SummaryReset(object sender, EventArgs e)
        {
            SumsKisiBasiGP1 = new Sums();
        }

        private void celSumKisiBasiGP1_SummaryRowChanged(object sender, EventArgs e)
        {
            SumsKisiBasiGP1.SumHastaGP1 += Convert.ToDouble(GetCurrentColumnValue("HastaP1"));
            SumsKisiBasiGP1.SumToplamGP1 += Convert.ToDouble(GetCurrentColumnValue("ToplamP1"));
        }

        private void celSumKisiBasiGP1_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiv(SumsKisiBasiGP1.SumToplamGP1, SumsKisiBasiGP1.SumHastaGP1);
            e.Handled = true;
        }

        private void celSumKisiBasiGY1_SummaryReset(object sender, EventArgs e)
        {
            SumsKisiBasiGY1 = new Sums();
        }

        private void celSumKisiBasiGY1_SummaryRowChanged(object sender, EventArgs e)
        {
            SumsKisiBasiGY1.SumHastaGC += Convert.ToDouble(GetCurrentColumnValue("HastaC"));
            SumsKisiBasiGY1.SumHastaGP1 += Convert.ToDouble(GetCurrentColumnValue("HastaP1"));
            SumsKisiBasiGY1.SumToplamGC += Convert.ToDouble(GetCurrentColumnValue("ToplamC"));
            SumsKisiBasiGY1.SumToplamGP1 += Convert.ToDouble(GetCurrentColumnValue("ToplamP1"));
        }

        private void celSumKisiBasiGY1_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = CalculateDiff(CalculateDiv(SumsKisiBasiGY1.SumToplamGC, SumsKisiBasiGY1.SumHastaGC), CalculateDiv(SumsKisiBasiGY1.SumToplamGP1, SumsKisiBasiGY1.SumHastaGP1));
            e.Handled = true;
        }

    }
}
