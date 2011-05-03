using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Win.Utilities;
using NHibernate;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class ChangeInsuranceCompanyForm : MDIChildForm
    {
        private ISession _Session;
        private Patient _Patient;
        private InsuranceCompany _InsuranceCompany;

        private bool _IsOK = false;
        public bool IsOK { get { return _IsOK; } }

        private IList<PatientVisit> _PatientVisits = new List<PatientVisit>();
        private IList<PatientVisitDetail> _PatientVisitDetails = new List<PatientVisitDetail>();

        private GridCheckMarksSelectionWeb selectionVisit;

        public ChangeInsuranceCompanyForm()
        {
            InitializeComponent();

            selectionVisit = new GridCheckMarksSelectionWeb(this.gvPatientVisits);
            selectionVisit.CheckMarkColumn.VisibleIndex = 0;
            selectionVisit.OnSelectionChanged += new EventHandler<EventArgs>(selectionVisit_OnSelectionChanged);

        }

        public void QueryPatientVisits(ISession session, Patient patient, InsuranceCompany insuranceCompany)
        {
            _Session = session;
            _Patient = patient;
            _InsuranceCompany = insuranceCompany;

            selectionVisit.ClearSelection();
            _PatientVisits = PatientServices.GetPatientVisitsForInsuranceCompanyChange(session, patient);
            this.gcPatientVisits.DataSource = _PatientVisits;
        }

        public void QueryPatientVisitDetails()
        {
            gvPatientVisitDetails.BeginDataUpdate();
            try
            {
                _PatientVisitDetails = PatientServices.GetPatientVisitDetailsForInsuranceCompanyChange(_Session, GetSelectedVisits());
                this.gcPatientVisitDetails.DataSource = _PatientVisitDetails;

                gvPatientVisitDetails.ClearSorting();
                gvPatientVisitDetails.Columns["PatientVisit.VisitNo"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
                gvPatientVisitDetails.Columns["DetailNo"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
            finally
            {
                gvPatientVisitDetails.EndDataUpdate();
            }

        }

        void selectionVisit_OnSelectionChanged(object o, EventArgs e)
        {
            QueryPatientVisitDetails();
        }

        private IList<PatientVisit> GetSelectedVisits()
        {
            List<PatientVisit> pvs = new List<PatientVisit>();
            for (int i = 0; i < selectionVisit.SelectedCount; i++)
            {
                PatientVisit pv = (PatientVisit)selectionVisit.GetSelectedRow(i);
                pvs.Add(pv);
            }
            return pvs;
        }

        private void sbSave_Click(object sender, EventArgs e)
        {

            _IsOK = true;
            this.Close();
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            _IsOK = false;
            this.Close();
        }

    }
}
