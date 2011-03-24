using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class DBTestForm : Naz.Hastane.Win.MDIChildForms.MDIChildForm
    {
        public DBTestForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = LookUpServices.GetAll<MEDDIABETALISKANLIKLAR>();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = LookUpServices.GetAll<MEDDIABETDOKTORLAR>();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = LookUpServices.GetAll<MEDDIABETHASTALIKLAR>();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = LookUpServices.GetAll<MEDDIABETILACLAR>();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = LookUpServices.GetAll<MEDDIABETTAKIPFORMU>();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = LookUpServices.GetAll<MEDESWLTASBILGISI>();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = LookUpServices.GetAll<MEDILACRAPOR>();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = LookUpServices.GetAll<MEDRAPORDOKTOR>();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = LookUpServices.GetAll<MEDRAPORETKENMADDE>();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = LookUpServices.GetAll<MEDRAPORTESHIS>();
        }
    }
}
