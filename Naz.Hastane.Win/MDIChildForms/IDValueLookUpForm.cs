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
using Naz.Hastane.Data.Entities.LookUp.Special;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class IDValueLookUpForm<T> : MDIChildForm where T : new()
    {
        public IDValueLookUpForm()
        {
            InitializeComponent();
        }
        public IDValueLookUpForm(IList<T> lookUpTable)
        {
            InitializeComponent();

            UIUtilities.BindGrid(this.gvLookUp, lookUpTable);
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbEdit_Click(object sender, EventArgs e)
        {

        }

        private void sbNew_Click(object sender, EventArgs e)
        {

        }

        private void sbDelete_Click(object sender, EventArgs e)
        {

        }

        private void gvLookUp_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}