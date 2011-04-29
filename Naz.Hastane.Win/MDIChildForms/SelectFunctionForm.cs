using System;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Hastane.Data.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SelectFunctionForm : MDIChildForm
    {
        private bool _IsSelected = false;
        public bool IsSelected { get { return _IsSelected; } }

        public SelectFunctionForm()
        {
            InitializeComponent();

            var functions = LookUpServices.FunctionGroups;
            gcView.DataSource = functions;
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
                //var = (Doctor)this.gvPolyclinics.GetFocusedRow();
                //_IsSelected = (_Doctor != null);
                //if (_IsSelected) this.Close();
            }
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}