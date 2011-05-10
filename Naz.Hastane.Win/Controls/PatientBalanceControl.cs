using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Win.Controls
{
    public partial class PatientBalanceControl : DevExpress.XtraEditors.XtraUserControl
    {
        private Patient _Patient;
        public Patient Patient 
        { 
            get { return _Patient; }
            set
            {
                if (value != _Patient)
                {
                    _Patient = value;
                    RefreshView();
                }
            }
        }
        public double Balance { get; set; }
        public PatientBalanceControl()
        {
            InitializeComponent();
        }

        public void RefreshView()
        {
            var records = LookUpServices.GetPatientBalanceRecordData(Patient);
            foreach (var record in records)
            {
                Balance += record.Alacak;
                Balance -= record.Borc;
            }
            this.gcPatientBalance.DataSource = records;
            this.teBorcBakiyesi.EditValue = Balance;
            if (Balance < 0)
                this.teBorcBakiyesi.ForeColor = Color.Red;
            else
                this.teBorcBakiyesi.ForeColor = Color.Black;
        }

        private void sbRefresh_Click(object sender, EventArgs e)
        {
            RefreshView();
        }
    }
}
