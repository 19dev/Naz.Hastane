using System;
using DevExpress.Data;
using DevExpress.XtraGrid.Columns;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SelectInsuranceCompanyForm : MDIChildForm
    {
        private InsuranceCompany _InsuranceCompany = null;
        public InsuranceCompany InsuranceCompany { get { return _InsuranceCompany; } }

        private bool _IsSelected = false;
        public bool IsSelected { get { return _IsSelected; } }

        public SelectInsuranceCompanyForm()
        {
            InitializeComponent();

            var InsuranceCompanys = LookUpServices.InsuranceCompanys;
            gcGrid.DataSource = InsuranceCompanys;
            gvView.SortInfo.ClearAndAddRange(new GridColumnSortInfo[] { 
              new GridColumnSortInfo(colCode, ColumnSortOrder.Ascending), 
              new GridColumnSortInfo(colName, ColumnSortOrder.Ascending)});
        }

        private void sbSelect_Click(object sender, EventArgs e)
        {
            OnSelectionMade();
        }

        private void gvPolyclinics_DoubleClick(object sender, EventArgs e)
        {
            OnSelectionMade();
        }

        private void OnSelectionMade()
        {
            if (this.gvView.GetFocusedRow() != null)
            {
                _InsuranceCompany = (InsuranceCompany)this.gvView.GetFocusedRow();
                _IsSelected = (_InsuranceCompany != null);
                if (_IsSelected) this.Close();
            }
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            _IsSelected = false;
            this.Close();
        }
    }
}