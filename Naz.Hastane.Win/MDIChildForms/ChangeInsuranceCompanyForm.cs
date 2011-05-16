using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Win.Utilities;
using NHibernate;
using Naz.Hastane.Data.DTO;

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
        public IList<PatientVisitDetailWithProduct> PatientVisitDetailWithProducts = new List<PatientVisitDetailWithProduct>();

        private GridCheckMarksSelectionWeb selectionVisit;

        private ChangeInsuranceCompanyForm()
        {
            InitializeComponent();

            selectionVisit = new GridCheckMarksSelectionWeb(this.gvPatientVisits);
            selectionVisit.CheckMarkColumn.VisibleIndex = 0;
            selectionVisit.OnSelectionChanged += new EventHandler<EventArgs>(selectionVisit_OnSelectionChanged);

        }

        public ChangeInsuranceCompanyForm(ISession session, Patient patient, InsuranceCompany insuranceCompany, IList<PatientVisit> pvs)
            : this()
        {
            _Session = session;
            _Patient = patient;
            _InsuranceCompany = insuranceCompany;
            _PatientVisits = pvs;
            this.gcPatientVisits.DataSource = pvs;
        }

        public void QueryPatientVisitDetails()
        {
            if (_InsuranceCompany == null) return;
            gvPatientVisitDetails.BeginDataUpdate();
            try
            {
                PatientVisitDetailWithProducts = PatientServices.GetPatientVisitDetailsForInsuranceCompanyChange(_Session, GetSelectedVisits(), _InsuranceCompany.YFIYLIST);
                this.gcPatientVisitDetails.DataSource = PatientVisitDetailWithProducts;

                gvPatientVisitDetails.ClearSorting();
                gvPatientVisitDetails.Columns["PatientVisitDetail.PatientVisit.VisitNo"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
                gvPatientVisitDetails.Columns["PatientVisitDetail.DetailNo"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
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

        public IList<PatientVisit> GetSelectedVisits()
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
