using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Utilities.Classes;

namespace Naz.Hastane.Win.Forms
{
    public partial class SimpleDialogForm : DevExpress.XtraEditors.XtraForm
    {
        private bool _IsOK = false;
        public bool IsOK { get { return _IsOK; } }

        public string TheValue { get; set; }

        private SimpleDialogForm()
        {
            InitializeComponent();
        }

        public SimpleDialogForm(string aMessage, string aValue) : this()
        {
            lciValue.Text = aMessage;
            teValue.Text = aValue;
            TheValue = aValue;
            _IsOK = false;
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            _IsOK = false;
            this.Close();
        }

        private void sbOK_Click(object sender, EventArgs e)
        {
            _IsOK = true;
            TheValue = teValue.Text;
            this.Close();

        }

    }
}
