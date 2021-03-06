﻿using System;
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
using Multicast;
using System.Net;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class DoctorPatientCallListForm : MDIChildForm
    {
        MulticastSettings testSettings = new MulticastSettings()
        {
            Address = IPAddress.Parse("239.1.2.3"),
            Port = 40404,
            TimeToLive = 16
        };

        private IList<PatientVisit> _PatientVisits;
        private String[] doctorCodeList;
        private IList<Doctor> doctors;

        public DoctorPatientCallListForm()
        {
            InitializeComponent();

            string doctorCodes = UIUtilities.CurrentUser.Doctors;
            doctorCodeList = doctorCodes.Split(';');
            doctors = LookUpServices.GetDoctorsInList(doctorCodeList);
            lstDoctors.DataSource = doctors;

            deDate.DateTime = DateTime.Today;
        }

        private void lstDoctors_Click(object sender, EventArgs e)
        {
            DisplayDoctorPatients();
        }

        private void DisplayDoctorPatients()
        {
            if (doctors.Count == 0)
                return;

            if (chkAll.Checked)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    _PatientVisits = PatientServices.GetPatientVisitsForDoctor(Session, doctors[0], deDate.DateTime.Date, deDate.DateTime.Date);
                    for (int i = 1; i < doctors.Count; i++)
                    {
                        Doctor d = doctors[i];
                        IList<PatientVisit> pvs = PatientServices.GetPatientVisitsForDoctor(Session, d, deDate.DateTime.Date, deDate.DateTime.Date);
                        foreach (PatientVisit pv in pvs)
                            _PatientVisits.Add(pv);
                    }
                    foreach (PatientVisit pv in _PatientVisits)
                    {
                        if (pv.QueueStatusCode == '0')
                        {
                            pv.QueueStatus = LookUpServices.GetQueueStatus(QueueStatus.Waiting);
                            Session.Update(pv);
                        }
                    }
                    gcPatients.DataSource = _PatientVisits;
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                Doctor doctor = lstDoctors.SelectedItem as Doctor;

                if (doctor != null)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        _PatientVisits = PatientServices.GetPatientVisitsForDoctor(Session, doctor, deDate.DateTime.Date, deDate.DateTime.Date);
                        foreach (PatientVisit pv in _PatientVisits)
                        {
                            if (pv.QueueStatusCode == '0')
                            {
                                pv.QueueStatus = LookUpServices.GetQueueStatus(QueueStatus.Waiting);
                                Session.Update(pv);
                            }
                        }
                        gcPatients.DataSource = _PatientVisits;
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
        }

        private void ResetInExam()
        {
            foreach (PatientVisit pv in _PatientVisits)
            {
                if (pv.QueueStatusCode == QueueStatus.InExam)
                {
                    pv.QueueStatus = LookUpServices.GetQueueStatus(QueueStatus.Finished);
                    Session.Update(pv);
                }
            }
            gvPatients.RefreshData();
        }

        private void CallPatient()
        {
            ResetInExam();
            PatientVisit pvNext = gvPatients.GetFocusedRow() as PatientVisit;
            if (pvNext != null)
            {
                SendPatientInfo();
                if (pvNext.QueueStatusCode != QueueStatus.InExam)
                {
                    pvNext.QueueStatus = LookUpServices.GetQueueStatus(QueueStatus.InExam);
                    gvPatients.RefreshData();
                    Session.Update(pvNext);
                }
            }
        }

        private void sbNextPatient_Click(object sender, EventArgs e)
        {
            ResetInExam();

            int i = gvPatients.FocusedRowHandle + 1;
            if (i < gvPatients.DataRowCount)
            {
                gvPatients.FocusedRowHandle = i;
                CallPatient();
            }
        }

        private void FocusNextRow()
        {
            int i = gvPatients.FocusedRowHandle + 1;
            if (i < gvPatients.DataRowCount)
                gvPatients.FocusedRowHandle = i;
        }

        private void sbPatientAbsent_Click(object sender, EventArgs e)
        {
            PatientVisit pv = gvPatients.GetFocusedRow() as PatientVisit;
            if (pv != null)
            {
                pv.QueueStatus = LookUpServices.GetQueueStatus(QueueStatus.NoShow);
                Session.Update(pv);
                FocusNextRow();
            }
        }

        private void sbDoctorAbsent_Click(object sender, EventArgs e)
        {

        }

        private void sbResend_Click(object sender, EventArgs e)
        {
            SendPatientInfo();
        }

        private void SendPatientInfo()
        {
            PatientVisit pv = gvPatients.GetFocusedRow() as PatientVisit;
            if (pv != null)
            {
                SendMessage(String.Format("{0};{1} {2}", pv.Doctor.Code, pv.QueueNo, pv.Patient.Initials));
            }
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SendMessage(string message)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);

            using (IMulticastBroadcaster broadcaster = new MulticastBroadcaster(testSettings))
            {
                broadcaster.Broadcast(messageBytes);
            }

        }

        private void sbCall_Click(object sender, EventArgs e)
        {
            CallPatient();
        }

        private void deDate_DateTimeChanged(object sender, EventArgs e)
        {
            DisplayDoctorPatients();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDoctorPatients();
        }
    }
}