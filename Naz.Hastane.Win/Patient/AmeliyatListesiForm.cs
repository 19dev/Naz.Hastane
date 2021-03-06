﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraGrid.Views.Grid;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class AmeliyatListesiForm : MDIChildForm
    {
        public AmeliyatListesiForm()
        {
            InitializeComponent();

            sbAdd.Click += (o, args) => AddDetail<AmeliyatListeEditForm, AmeliyatListe>();
            sbEdit.Click += (o, args) => EditDetail<AmeliyatListeEditForm, AmeliyatListe>(gvAmeliyatListe);
            sbDelete.Click += (o, args) => DeleteDetail<AmeliyatListe>(gvAmeliyatListe, "Ameliyat Kaydını Silmek İstiyor Musunuz?", "Ameliyat Kaydı Silinmiştir.",
                "Ameliyat Kaydı Silinemedi:", "Ameliyat Kaydı Silme İşlemi");

            deDate.DateTime = DateTime.Today;
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbRefresh_Click(object sender, EventArgs e)
        {
            ReLoadForm();
        }

        protected override void ReLoadForm()
        {
            ReOpenSession();
            gcAmeliyatListe.DataSource = PatientServices.GetDailyAmeliyatListe(Session, deDate.DateTime.Date);
        }

        private void sbBasladi_Click(object sender, EventArgs e)
        {
            SetStatus(2);
        }

        private void sbBitti_Click(object sender, EventArgs e)
        {
            SetStatus(3);
        }

        private void sbIptal_Click(object sender, EventArgs e)
        {
            SetStatus(4);
        }

        private void SetStatus(int statusCode)
        {
            AmeliyatListe al = gvAmeliyatListe.GetFocusedRow() as AmeliyatListe;
            if (al != null)
            {
                PatientServices.UpdateAmeliyatListeStatus(Session, UIUtilities.CurrentUser, al, statusCode);
                ReLoadForm();
            }
        }

        private void deDate_DateTimeChanged(object sender, EventArgs e)
        {
            ReLoadForm();
        }
    }
}