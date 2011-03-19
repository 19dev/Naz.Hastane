using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class LookUpForm<T> : MDIChildForm where T : new()
    {
        IList<T> _lookUpTable;
        public LookUpForm()
        {
            InitializeComponent();
        }
        public LookUpForm(IList<T> lookUpTable)
        {
            _lookUpTable = lookUpTable;
            InitializeComponent();
            this.gcLookUp.DataSource = _lookUpTable;
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}