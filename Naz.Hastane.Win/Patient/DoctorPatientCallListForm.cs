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
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class DoctorPatientCallListForm : MDIChildForm
    {
        private String[] doctorCodeList;
        public DoctorPatientCallListForm()
        {
            InitializeComponent();

            String doctorCodes = UIUtilities.ConfigurationSource.Configs["User"].Get("Doktorlar", "");
            doctorCodeList = doctorCodes.Split(',');

            lstDoctors.DataSource = LookUpServices.GetDoctorsInList(doctorCodeList);

        }

        private void lstDoctors_Click(object sender, EventArgs e)
        {
            Doctor doctor = lstDoctors.SelectedItem as Doctor;

            if (doctor != null)
            {
                IList<PatientVisit> patients = PatientServices.GetPatientVisitsForDoctor(Session, doctor, deDate.DateTime.Date, deDate.DateTime.Date);
                gcPatients.DataSource = patients;
            }
        }
    }
}