using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class MedulaDiabetReportForm : Naz.Hastane.Win.MDIChildForms.MDIChildForm
    {
        public MedulaDiabetReportForm()
        {
            InitializeComponent();

            this.deSentReportsStartDate.EditValue = DateTime.Now.Date;
            this.deSentReportsEndDate.EditValue = DateTime.Now.Date;
            this.deUnSentReportsStartDate.EditValue = DateTime.Now.Date;
            this.deUnSentReportsEndDate.EditValue = DateTime.Now.Date;

            this.gvSentReports.Columns.AddField("TCKIMLIKNO").Visible = true;
            this.gvSentReports.Columns.AddField("AD").Visible = true;
            this.gvSentReports.Columns.AddField("SOYAD").Visible = true;
            this.gvSentReports.Columns.AddField("PROTOKOLNO").Visible = true;

            //this.gvSentReports.Columns.AddField("VisitDate").Visible = true;
            //this.gvSentReports.Columns.AddField("VisitNo").Visible = true;
            //this.gvSentReports.Columns.AddField("FirstName").Visible = true;
            //this.gvSentReports.Columns.AddField("LastName").Visible = true;

            this.gvUnSentReports.Columns.AddField("TCKIMLIKNO").Visible = true;
            this.gvUnSentReports.Columns.AddField("AD").Visible = true;
            this.gvUnSentReports.Columns.AddField("SOYAD").Visible = true;
            this.gvUnSentReports.Columns.AddField("PROTOKOLNO").Visible = true;

            //this.gvUnSentReports.Columns.AddField("VisitDate").Visible = true;
            //this.gvUnSentReports.Columns.AddField("VisitNo").Visible = true;
            //this.gvUnSentReports.Columns.AddField("FirstName").Visible = true;
            //this.gvUnSentReports.Columns.AddField("LastName").Visible = true;

            RefreshSentDiabetReports();
            RefreshUnSentDiabetReports();

            //UIUtilities.BindGrid(this.gvUnSentReports, PatientServices.GetUnSentMedulaDiabetReports(Session));
        }

        private void RefreshSentDiabetReports()
        {
            this.gcSentReports.DataSource = MedulaReportServices.GetSentMedulaDiabetReports(Session, this.deSentReportsStartDate.DateTime.Date, this.deSentReportsEndDate.DateTime.Date);
        }
        private void RefreshUnSentDiabetReports()
        {
            this.gcUnSentReports.DataSource = MedulaReportServices.GetUnSentMedulaDiabetReports(Session, this.deUnSentReportsStartDate.DateTime.Date, this.deUnSentReportsEndDate.DateTime.Date);
        }

        private void sbSentReportsRefresh_Click(object sender, EventArgs e)
        {
            RefreshSentDiabetReports();
        }

        private void sbUnSentReportsRefresh_Click(object sender, EventArgs e)
        {
            RefreshUnSentDiabetReports();
        }

        private void deSentReportsStartDate_Click(object sender, EventArgs e)
        {
            RefreshSentDiabetReports();
        }

        private void deSentReportsEndDate_Click(object sender, EventArgs e)
        {
            RefreshSentDiabetReports();
        }

        private void deUnSentReportsStartDate_Click(object sender, EventArgs e)
        {
            RefreshUnSentDiabetReports();
        }

        private void deUnSentReportsEndDate_Click(object sender, EventArgs e)
        {
            RefreshUnSentDiabetReports();
        }
    }
}
