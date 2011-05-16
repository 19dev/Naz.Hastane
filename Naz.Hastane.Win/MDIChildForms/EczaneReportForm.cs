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
    public partial class EczaneReportForm : MDIChildForm
    {
        public EczaneReportForm()
        {
            InitializeComponent();
        }

        private void EczaneReportForm_Load(object sender, EventArgs e)
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

                var records = LookUpServices.GetEczaneDagilim(this.deStartDate.DateTime.Date, this.deEndDate.DateTime.Date);
                this.pgcParasiGeriOdenecek.DataSource = records;

                var records2 = LookUpServices.GetEczaneDagilimYatakli(this.deStartDate.DateTime.Date, this.deEndDate.DateTime.Date);
                this.pgcYatakliServisler.DataSource = records2;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void sbPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewForm newForm = new PrintPreviewForm();
            newForm.Text = "Eczane Raporu:" + this.deStartDate.DateTime.Date.ToString() + " - " + this.deEndDate.DateTime.Date.ToString();
            ((frmMain)this.MdiParent).ShowNewDocument(newForm);
            Naz.Hastane.Reports.Classes.EczaneReport report = new Naz.Hastane.Reports.Classes.EczaneReport();

            report.pgcParasiGeriOdenecek.DataSource = this.pgcParasiGeriOdenecek.DataSource;
            report.pgcYatakliServisler.DataSource = this.pgcYatakliServisler.DataSource;

            newForm.ShowReport(report);
        }

        private void sbRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}