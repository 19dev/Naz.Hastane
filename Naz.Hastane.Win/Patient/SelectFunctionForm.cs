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
using System.Windows.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SelectFunctionForm : MDIChildForm
    {
        public PatientVisit PatientVisit;

        private bool _IsSelected = false;
        public bool IsSelected { get { return _IsSelected; } }

        private IList<PatientVisitDetail> _SelectedProducts = new List<PatientVisitDetail>();
        public IList<PatientVisitDetail> SelectedProducts { get { return _SelectedProducts; } }

        public string PriceListCode { get; set; }
        public SelectFunctionForm()
        {
            InitializeComponent();

            CreateColumns(this.tlFunctionGroups);
            CreateNodes(this.tlFunctionGroups, LookUpServices.FunctionGroups);

            this.gcSelectedProducts.DataSource = _SelectedProducts;
            gcProducts.Focus();
        }

        private void CreateColumns(TreeList tl)
        {
            tl.BeginUpdate();
            tl.Columns.Add();
            tl.Columns[0].Caption = "Açıklama";
            tl.Columns[0].VisibleIndex = 0;

            tl.EndUpdate();
        }

        private void CreateNodes(TreeList tl, IList<FunctionGroup> functions)
        {
            tl.BeginUnboundLoad();
            // Create a root node . 
            TreeListNode parentForRootNodes = null;
            foreach (var fg in functions)
            {
                TreeListNode rootNode = tl.AppendNode(new object[] { fg.Value}, parentForRootNodes, fg.Code);
                foreach (var fsg in fg.SubFunctionGroups)
                {
                    tl.AppendNode(new object[] { fsg.Value }, rootNode, fsg.GrupCode);
                }
            }
            tl.EndUnboundLoad();
        }

        private void OnSelectionMade()
        {
        }

        private void CloseForm()
        {
            _IsSelected = false;
            this.Close();
        }
        private void sbClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void AddToSelectedProducts(Product product)
        {
            PatientVisitDetail pvd = PatientServices.GetNewPatientVisitDetailFromProduct(PatientVisit, product);
            foreach (PatientVisitDetail p in _SelectedProducts)
                if (p == pvd)
                    return;
            _SelectedProducts.Add(pvd);
            CalculateProductTotals();

            this.gcSelectedProducts.RefreshDataSource();
        }

        private void tlFunctionGroups_Click(object sender, EventArgs e)
        {
            //DisplayFunctions();
        }

        private void DisplayFunctions()
        {
            TreeListNode node = this.tlFunctionGroups.FocusedNode;
            if (node.ParentNode != null)
            {
                string tanim = node.ParentNode.Tag.ToString();
                string grup = node.Tag.ToString();
                IList<Product> products = LookUpServices.GetProducts(tanim, grup, PriceListCode);
                this.gcProducts.DataSource = products;
            }
            else
            {
                string tanim = node.Tag.ToString();
                IList<Product> products = LookUpServices.GetProducts(tanim, PriceListCode);
                this.gcProducts.DataSource = products;
            }
        }
        private void gvProducts_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null)
            {
                Product product = view.GetFocusedRow() as Product;
                if (product != null)
                {
                    AddToSelectedProducts(product);
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
                    RemoveSelectedProduct(pvd);
            }
        }

        private void RemoveSelectedProduct(PatientVisitDetail pvd)
        {
            if (SimpleMsgBoxForm.ShowYesNo("Seçili Hizmeti Kaldırmak İstiyor Musunuz?", "Hizmet Silme Uyarısı", true) == System.Windows.Forms.DialogResult.Yes)
            {
                    _SelectedProducts.Remove(pvd);
                    CalculateProductTotals();
                    this.gcSelectedProducts.RefreshDataSource();
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
            this.teCompanyTotal.EditValue = companyTotal;
        }

        private void SelectAndClose()
        {
            _IsSelected = true;
            this.Close();
        }
        private void sbSelect_Click(object sender, EventArgs e)
        {
            SelectAndClose();
        }

        private void SelectFunctionForm_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Product product = gvProducts.GetFocusedRow() as Product;
                if (product != null)
                {
                    AddToSelectedProducts(product);
                    gvProducts.ApplyFindFilter("");
                    gvProducts.ShowFindPanel();
                    e.Handled = true;
                }

            }
        }

        private void FindNode(TreeListNode parentNode, char searchChar)
        {
            if (parentNode == null) return;

            if (parentNode.Expanded)
            {
                foreach (TreeListNode n in parentNode.Nodes)
                {
                    if (n.GetDisplayText(0)[0] == searchChar)
                    {
                        this.tlFunctionGroups.SetFocusedNode(n);
                        return;
                    }
                }
            }
            else
            {
                foreach (TreeListNode n in this.tlFunctionGroups.Nodes)
                {
                    if (n.ParentNode == null && n.GetDisplayText(0)[0] == searchChar)
                    {
                        this.tlFunctionGroups.SetFocusedNode(n);
                        return;
                    }
                }
            }
        }

        private void tlFunctionGroups_AfterFocusNode(object sender, NodeEventArgs e)
        {
            DisplayFunctions();
        }

        private void sbChangeAmount_Click(object sender, EventArgs e)
        {
            PatientVisitDetail pvd = gvSelectedProducts.GetFocusedRow() as PatientVisitDetail;
            if (pvd != null)
            {
                double Amount = pvd.ADET;
                using (SimpleDialogForm frm = new SimpleDialogForm("Lütfen Adet Giriniz", Amount.ToString()))
                {
                    frm.ShowDialog();
                    if (frm.IsOK)
                    {
                        if (Double.TryParse(frm.TheValue, out Amount))
                        {
                            pvd.ADET = Amount;
                            //this.gcSelectedProducts.RefreshDataSource();
                            CalculateProductTotals();
                        }
                    }
                }

            }

        }

        private void SelectFunctionForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
                CloseForm();
            else if (e.KeyCode == Keys.F5)
                SelectAndClose();
        }
    }
}