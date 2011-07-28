using System;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Hastane.Data.Services;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SelectPolyclinicForm : MDIChildForm
    {
        private Doctor _Doctor = null;
        public Doctor Doctor { get { return _Doctor; } }

        private InsuranceCompany _InsuranceCompany = null;
        public InsuranceCompany InsuranceCompany { 
            get { return _InsuranceCompany; } 
            set
            {
                if (_InsuranceCompany == value)
                    return;
                _InsuranceCompany = value;
                lblOldInsuranceCompany.Text = "Eski Kurum: " + _InsuranceCompany.Code;
                NewInsuranceCompany = value;
            }
        }

        private InsuranceCompany _NewInsuranceCompany = null;
        public InsuranceCompany NewInsuranceCompany {
            get { return _NewInsuranceCompany; }
            set
            {
                if (_NewInsuranceCompany == value)
                    return;
                _NewInsuranceCompany = value;
                lblNewInsuranceCompany.Text = "Yeni Kurum: " + _NewInsuranceCompany.Code;
            }
        }

        private bool _IsSelected = false;
        public bool IsSelected { 
            get { return _IsSelected; }
        }
        public bool SameDay;

        public SelectPolyclinicForm()
        {
            InitializeComponent();
        }
        public SelectPolyclinicForm(bool sameDay) :this()
        {

            //this.AcceptButton = this.sbSelect;
            //if (sameDay)
            //    this.lciSameDay.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            //else
            //    this.lciSameDay.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            //this.ceSameDay.Visible = sameDay;
            //this.ceSameDay.Checked = sameDay;
            SameDay = sameDay;

            var doctors = LookUpServices.GetSGKDoctors(Session);
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

        private void ceSameDay_CheckedChanged(object sender, EventArgs e)
        {
            SameDay = this.ceSameDay.Checked;
        }

        #region Change Insurance Company
        private void ddbChangeInsuranceCompany_Click(object sender, EventArgs e)
        {
            SelectInsuranceCompanyForm frm = new SelectInsuranceCompanyForm();
            frm.ShowDialog();
            if (frm.IsSelected)
                ChangeInsuranceCompany(frm.InsuranceCompany);
        }

        private void iSGK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeInsuranceCompany(LookUpServices.GetSGK(Session));
        }

        private void iSGKAcil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeInsuranceCompany(LookUpServices.GetSGKAcil(Session));
        }

        private void iNormal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeInsuranceCompany(LookUpServices.GetNormalPatientCode(Session));
        }

        private void iOzelHasta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeInsuranceCompany(LookUpServices.GetSpecialPatientCode(Session));
        }

        private void ChangeInsuranceCompany(InsuranceCompany newInsuranceCompany)
        {
            NewInsuranceCompany = newInsuranceCompany;
        }
        #endregion

    }
}