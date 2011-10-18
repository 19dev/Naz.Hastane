using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Win.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PatientArchiveEditForm : MDIChildForm
    {
        Patient _Patient;

        public Patient Patient
        {
            get
            {
                return _Patient;
            }
            set
            {
                _Patient = PatientServices.GetPatientByID(value.PatientNo);
                InitBindings();
            }
        }

        public PatientArchiveEditForm()
        {
            InitializeComponent();
        }

        private void InitBindings()
        {
            UIUtilities.BindControl(teKutu, Patient, x => x.Kutu);
            UIUtilities.BindControl(teOda, Patient, x => x.Oda);
            UIUtilities.BindControl(teRaf, Patient, x => x.Raf);
            UIUtilities.BindControl(teYer, Patient, x => x.Yer);
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            try
            {
                PatientServices.SavePatient(Session, UIUtilities.CurrentUser, Patient);
                Close();
            }
            catch (Exception error)
            {
                SimpleMsgBoxForm.ShowMsgBox("Hasta Arşiv Bilgileri Kayıt Edilemedi:" + error.Message, "Hasta Arşiv Kayıt Hatası", true);
            }

        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}