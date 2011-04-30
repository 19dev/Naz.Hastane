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
        //private GridCheckMarksSelectionWeb selectionProducts;
        //private GridCheckMarksSelectionWeb selectionSelectedProducts;

        private bool _IsSelected = false;
        public bool IsSelected { get { return _IsSelected; } }

        private IList<Product> _SelectedProducts = new List<Product>();
        public IList<Product> SelectedProducts { get { return _SelectedProducts; } }

        public string PriceListCode { get; set; }
        public SelectFunctionForm()
        {
            InitializeComponent();

            //selectionProducts = new GridCheckMarksSelectionWeb(this.gvProducts);
            //selectionProducts.CheckMarkColumn.VisibleIndex = 0;
            //selectionProducts.OnSelectionChanged += new EventHandler<EventArgs>(selectionProducts_OnSelectionChanged);

            //selectionSelectedProducts = new GridCheckMarksSelectionWeb(this.gvSelectedProducts);
            //selectionSelectedProducts.CheckMarkColumn.VisibleIndex = 0;
            //selectionSelectedProducts.OnSelectionChanged += new EventHandler<EventArgs>(selectionSelectedProducts_OnSelectionChanged);

            CreateColumns(this.tlFunctionGroups);
            CreateNodes(this.tlFunctionGroups, LookUpServices.FunctionGroups);

            this.gcSelectedProducts.DataSource = _SelectedProducts;
        }

        private void CreateColumns(TreeList tl)
        {
            // Create three columns. 
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
            this.Close();
        }
        //void selectionProducts_OnSelectionChanged(object o, EventArgs e)
        //{
        //    //QueryPatientProductsDetails();
        //}
        //void selectionSelectedProducts_OnSelectionChanged(object o, EventArgs e)
        //{
        //    //QueryPatientProductsDetails();
        //}

        private void AddToSelectedProducts(Product product)
        {
            foreach (Product p in _SelectedProducts)
                if (p == product)
                    return;
            _SelectedProducts.Add(product);
            this.gcSelectedProducts.RefreshDataSource();
        }

        private void tlFunctionGroups_Click(object sender, EventArgs e)
        {
            TreeListNode node = this.tlFunctionGroups.FocusedNode;
            if (node.ParentNode != null)
            {
                string tanim = node.ParentNode.Tag.ToString();
                string grup = node.Tag.ToString();
                IList<Product> products = LookUpServices.GetProducts(tanim, grup, PriceListCode);
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
                Product product = view.GetFocusedRow() as Product;
                if (product != null)
                {
                    _SelectedProducts.Remove(product);
                    this.gcSelectedProducts.RefreshDataSource();
                }
            }
        }
    }
}