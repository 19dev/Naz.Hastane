using System;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Hastane.Data.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SelectFromLookUpForm : MDIChildForm
    {
        private Doctor _Doctor = null;
        public Doctor Doctor { get { return _Doctor; } }

        private bool _IsSelected = false;
        public bool IsSelected { get { return _IsSelected; } }

        public SelectFromLookUpForm()
        {
            InitializeComponent();

            var doctors = LookUpServices.SGKDoctors;
            gcView.DataSource = doctors;
            gvPolyclinics.SortInfo.ClearAndAddRange(new GridColumnSortInfo[] { 
              new GridColumnSortInfo(colService, ColumnSortOrder.Ascending), 
              new GridColumnSortInfo(colDoctor, ColumnSortOrder.Ascending)});
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
            if (this.gvPolyclinics.GetFocusedRow() != null)
            {
                _Doctor = (Doctor)this.gvPolyclinics.GetFocusedRow();
                _IsSelected = (_Doctor != null);
                if (_IsSelected) this.Close();
            }
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}