using System;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Hastane.Data.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using System.Collections.Generic;
using Naz.Hastane.Win.Utilities;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Win.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SelectMedicineForm : MDIChildForm
    {
        public PatientVisit PatientVisit;

        private bool _IsSelected = false;
        public bool IsSelected { get { return _IsSelected; } }

        private IList<PatientVisitDetail> _SelectedProducts = new List<PatientVisitDetail>();
        public IList<PatientVisitDetail> SelectedProducts { get { return _SelectedProducts; } }

        public string PriceListCode { get; set; }

        public SelectMedicineForm()
        {
            InitializeComponent();
            LoadLookUps();
        }

        public void InitForm()
        {
            deDate.DateTime = DateTime.Today;
            lueDoktor.EditValue = PatientVisit.DoctorCode;
            lueServis.EditValue = PatientVisit.Servis;
            rgSelection.EditValue = "İ";

            this.gcSelectedProducts.DataSource = _SelectedProducts;
        }

        private void LoadLookUps()
        {
            UIUtilities.BindLookUpEdit(lueDoktor, LookUpServices.Doctors);
            UIUtilities.BindLookUpEdit(lueServis, LookUpServices.Services);
        }

        private void OnSelectionMade()
        {
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            _IsSelected = false;
            this.Close();
        }

        private void AddToSelectedStocks(Stock stock, double aAmount)
        {
            PatientVisitDetail pvd = PatientServices.GetNewPatientVisitDetailFromStock(PatientVisit, stock);
            foreach (PatientVisitDetail p in _SelectedProducts)
                if (p.CODE == pvd.CODE)
                {
                    p.ADET += aAmount;
                    return;
                }
            pvd.ADET = aAmount;
            _SelectedProducts.Add(pvd);
            this.gcSelectedProducts.RefreshDataSource();
        }

        private void gvProducts_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null)
            {
                Stock stock = view.GetFocusedRow() as Stock;
                if (stock != null)
                {
                    double Amount = 1;
                    using (SimpleDialogForm frm = new SimpleDialogForm("Lütfen Adet Giriniz", Amount.ToString()))
                    {
                        frm.ShowDialog();
                        if (frm.IsOK)
                        {
                            if (Double.TryParse(frm.TheValue, out Amount) == false)
                                Amount = 1;
                        }
                    }
                   
                    AddToSelectedStocks(stock, Amount);
                }
            }
        }

        private void gvSelectedProducts_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null)
            {
                PatientVisitDetail pvd = view.GetFocusedRow() as PatientVisitDetail;
                if (pvd != null)
                {
                    _SelectedProducts.Remove(pvd);
                    this.gcSelectedProducts.RefreshDataSource();
                }
            }
        }

        private void CalculateProductTotals()
        {
            double patientTotal = 0;
            double companyTotal = 0;

            foreach (PatientVisitDetail pvd in SelectedProducts)
            {
                patientTotal += (pvd.PatientPrice * pvd.ADET) * (1 + pvd.KDV / 100);
                companyTotal += (pvd.CompanyPrice * pvd.ADET) * (1 + pvd.KDV / 100);
            }

            this.tePatientTotal.EditValue = patientTotal;
        }

        private void sbSelect_Click(object sender, EventArgs e)
        {
            _IsSelected = true;
            PatientServices.AddPatientVisitDetailsForStock(Session, UIUtilities.CurrentUser, PatientVisit, _SelectedProducts);
            this.Close();
        }

        private void SelectFunctionForm_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
        }

        private void rgSelection_EditValueChanged(object sender, EventArgs e)
        {
            LoadSelection();
        }
        private void LoadSelection()
        {
            if (rgSelection.EditValue.ToString() == "İ")
            {
                UIUtilities.BindLookUpEdit(lueDepo, LookUpServices.Depositories);
                lbcUrunTipi.DisplayMember = "Value";
                lbcUrunTipi.ValueMember = "GrupCode";
                lbcUrunTipi.DataSource = LookUpServices.MedicineCategorys;
            }
            else
            {
                UIUtilities.BindLookUpEdit(lueDepo, LookUpServices.Warehouses);
                lbcUrunTipi.DisplayMember = "Value";
                lbcUrunTipi.ValueMember = "GrupCode";
                lbcUrunTipi.DataSource = LookUpServices.Consumables;
            }
            lueDepo.ItemIndex = 0;
        }

        private void lbcUrunTipi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbcUrunTipi.SelectedValue == null)
                return;

            string stockType = (rgSelection.EditValue.ToString() == "İ") ? LookUpServices.GetMedicineTanim(Session) : LookUpServices.GetConsumableTanim(Session);

            gcProducts.DataSource = LookUpServices.GetStocks(Session, lueDepo.EditValue.ToString(), stockType, lbcUrunTipi.SelectedValue.ToString());
        }
    }
}