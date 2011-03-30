using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Services;

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
            var records = LookUpServices.GetAccountingDailySummary(this.deDate.DateTime.Date);
            UIUtilities.BindGrid(this.gridView1, records);
        }

        private void sbPrint_Click(object sender, EventArgs e)
        {
            this.gridControl1.ShowPrintPreview();
        }
    }
}