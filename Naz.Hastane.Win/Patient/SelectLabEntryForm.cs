using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using NHibernate;
using Naz.Hastane.Data.Entities;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class SelectLabEntryForm : MDIChildForm
    {
        public PatientVisit PatientVisit;

        private bool _IsSelected = false;
        public bool IsSelected { get { return _IsSelected; } }

        private IList<PatientVisitDetail> _SelectedProducts = new List<PatientVisitDetail>();
        public IList<PatientVisitDetail> SelectedProducts { get { return _SelectedProducts; } }

        public string PriceListCode { get; set; }

        public SelectLabEntryForm()
        {
            InitializeComponent();
        }

        public void InitForm(IList<PatientVisitDetail> selectedVisitDetails)
        {
            foreach (PatientVisitDetail pvd in selectedVisitDetails)
            {
                if (pvd.TANIM == "06")
                {
                    foreach (Control c in layoutControl2.Controls)
                    {
                        CheckEdit ce = c as CheckEdit;
                        if (ce != null && ce.Tag == pvd.CODE)
                        {
                            ce.Checked = true;
                            FillListBox(ce.Text, true);
                        }
                    }
                }
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            CheckEdit ce = (CheckEdit)sender;
            if (ce != null)
            {
                FillListBox(ce.Text, !ce.Checked);
            }
        }

        private void FillListBox(string text, bool add)
        {
            if (!add)
                foreach (string item in listBoxControl1.Items)
                {
                    if (item == text)
                    {
                        listBoxControl1.Items.Remove(item);
                        return;
                    }
                }
            else
            {
                foreach (string item in listBoxControl1.Items)
                {
                    if (item == text)
                        return;
                }
                listBoxControl1.Items.Add(text);
            }
        }

        private void listBoxControl1_DoubleClick(object sender, EventArgs e)
        {
            string item = (string)listBoxControl1.SelectedItem;
            listBoxControl1.Items.Remove(item);
            foreach (Control c in layoutControl2.Controls)
            {
                CheckEdit ce = c as CheckEdit;
                if (ce != null && ce.Text == item)
                    ce.Checked = false;
            }
        }

        private void AddToSelectedProducts(Product product)
        {
            PatientVisitDetail pvd = PatientServices.GetNewPatientVisitDetailFromProduct(PatientVisit, product);
            foreach (PatientVisitDetail p in _SelectedProducts)
                if (p == pvd)
                    return;
            _SelectedProducts.Add(pvd);

        }

        private void RemoveFromSelectedProducts()
        {

        }

    }
}
