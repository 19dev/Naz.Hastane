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

        private void sbClose_Click(object sender, EventArgs e)
        {
            _IsSelected = false;
            this.Close();
        }

        private void AddToSelectedProducts(Product product)
        {
            PatientVisitDetail pvd = PatientServices.GetNewPatientVisitDetailFromProduct(PatientVisit, product);
            foreach (PatientVisitDetail p in _SelectedProducts)
                if (p == pvd)
                    return;
            _SelectedProducts.Add(pvd);
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
            this.teCompanyTotal.EditValue = companyTotal;
        }

        private void sbSelect_Click(object sender, EventArgs e)
        {
            _IsSelected = true;
            this.Close();
        }

        private void SelectFunctionForm_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //string key = e.KeyChar.ToString();
            //key = key.ToUpper();
            //FindNode(this.tlFunctionGroups.FocusedNode, key[0]);
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
    }
}