using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Reports.Classes;
using Naz.Hastane.Data.Entities.StoredProcedure;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class DailyTellerReportForm : MDIChildForm
    {
        public DailyTellerReportForm()
        {
            InitializeComponent();
        }

        private void AccountingDailySummaryForm_Load(object sender, EventArgs e)
        {
            this.deFirstDate.DateTime = DateTime.Today;
            this.deLastDate.DateTime = DateTime.Today;
        }

        private void deDate_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                var records = LookUpServices.GetDailyTellerReportData(UIUtilities.CurrentUser.USER_ID, this.deFirstDate.DateTime.Date, this.deLastDate.DateTime.Date);
                this.gridControl1.DataSource = records;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void sbPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewForm newForm = new PrintPreviewForm();
            newForm.Text = "Günlük Kasa Raporu:" + this.deFirstDate.DateTime.Date.ToString() + " - " + this.deLastDate.DateTime.Date.ToString();
            ((frmMain)this.MdiParent).ShowNewDocument(newForm);
            //newForm.ShowReport<DailyTellerReport>(this.gridControl1.DataSource);

        }

        private void sbMonthly_Click(object sender, EventArgs e)
        {
            for (DateTime day = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); day < DateTime.Today; day = day.AddDays(1))
            {
                this.lbStatus.Text = day.ToString();
                AccountingDailySummaryReport report = new AccountingDailySummaryReport();
                report.DataSource = LookUpServices.GetAccountingDailySummary(day);
                report.ExportToPdf(@"D:\SurpPirgic\Muhasebe\Reports\" + day.ToString("yyyyMMdd") + ".pdf");
                report.ExportToXlsx(@"D:\SurpPirgic\Muhasebe\Reports\" + day.ToString("yyyyMMdd") + ".xlsx");
            }
        }
    }
}