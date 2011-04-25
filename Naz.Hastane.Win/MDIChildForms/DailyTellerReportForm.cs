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
            this.lueUser.Properties.DataSource = LookUpServices.Tellers;
        }

        private void AccountingDailySummaryForm_Load(object sender, EventArgs e)
        {
            this.deStartDate.DateTime = DateTime.Today;
            this.deEndDate.DateTime = DateTime.Today;
        }

        private void RefreshData()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (this.deEndDate.DateTime == null || this.deEndDate.DateTime < this.deStartDate.DateTime)
                    this.deEndDate.DateTime = this.deStartDate.DateTime;

                var records = LookUpServices.GetDailyTellerReportData(this.lueUser.Text, this.deStartDate.DateTime.Date, this.deEndDate.DateTime.Date);
                this.gridControl1.DataSource = records;
                this.gridView1.ExpandAllGroups();
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void sbPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewForm newForm = new PrintPreviewForm();
            newForm.Text = "Günlük Kasa Raporu:" + this.deStartDate.DateTime.Date.ToString() + " - " + this.deEndDate.DateTime.Date.ToString();
            ((frmMain)this.MdiParent).ShowNewDocument(newForm);
            newForm.ShowReport<Naz.Hastane.Reports.Classes.DailyTellerReport>(this.gridControl1.DataSource);

        }

        private void sbMonthly_Click(object sender, EventArgs e)
        {
            //for (DateTime day = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); day < DateTime.Today; day = day.AddDays(1))
            //{
            //    this.lbStatus.Text = day.ToString();
            //    AccountingDailySummaryReport report = new AccountingDailySummaryReport();
            //    report.DataSource = LookUpServices.GetAccountingDailySummary(day);
            //    report.ExportToPdf(@"D:\SurpPirgic\Muhasebe\Reports\" + day.ToString("yyyyMMdd") + ".pdf");
            //    report.ExportToXlsx(@"D:\SurpPirgic\Muhasebe\Reports\" + day.ToString("yyyyMMdd") + ".xlsx");
            //}
        }

        private void sbRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}