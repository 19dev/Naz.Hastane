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
    public partial class SelectPolyclinicForm : MDIChildForm
    {
        public SelectPolyclinicForm()
        {
            InitializeComponent();

            var doctors = LookUpServices.GetSGKDoctors();

            gcView.DataSource = doctors;
        }
    }
}