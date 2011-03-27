using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Services;
using System.Reflection;
using DevExpress.XtraGrid.Columns;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class LookUpForm<T> : MDIChildForm where T : new()
    {
        IList<T> _LookUpTable;
        public LookUpForm()
        {
            InitializeComponent();
        }
        public LookUpForm(IList<T> lookUpTable)
        {
            _LookUpTable = lookUpTable;
            InitializeComponent();

            UIUtilities.BindGrid(this.gvLookUp, _LookUpTable);
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}