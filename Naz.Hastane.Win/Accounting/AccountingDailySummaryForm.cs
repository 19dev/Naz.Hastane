﻿using System;
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
    public partial class AccountingDailySummaryForm : MDIChildForm
    {
        public AccountingDailySummaryForm()
        {
            InitializeComponent();
        }

        private void AccountingDailySummaryForm_Load(object sender, EventArgs e)
        {
            this.deDate.EditValue = DateTime.Now;
        }

        private void deDate_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                var records = LookUpServices.GetAccountingDailySummary(this.deDate.DateTime.Date);
                this.gridControl1.DataSource = records;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void sbPrint_Click(object sender, EventArgs e)
        {
            //this.gridControl1.ShowPrintPreview();
            PrintPreviewForm newForm = new PrintPreviewForm();
            newForm.Text = "Muhasebe Günlük Fiş:" + this.deDate.DateTime.Date.ToString();
            ((frmMain)this.MdiParent).ShowNewDocument(newForm);
            newForm.ShowReport<AccountingDailySummaryReport>(this.gridControl1.DataSource);

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