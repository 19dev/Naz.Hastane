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

        public void InitForm()
        {
            //deDate.DateTime = DateTime.Today;
            //lueDoktor.EditValue = PatientVisit.DoctorCode;
            //lueServis.EditValue = PatientVisit.Servis;
            //rgSelection.EditValue = "Ý";

            //this.gcSelectedProducts.DataSource = _SelectedProducts;
        }

        private void check_Click(object sender, EventArgs e)
        {
            CheckEdit ce = (CheckEdit)sender;
            if (ce != null)
            {
                FillListBox(ce);
            }
        }

        private void FillListBox(CheckEdit ce)
        {
            String text = ce.Text;
            if (ce.Checked)
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
    }
}
