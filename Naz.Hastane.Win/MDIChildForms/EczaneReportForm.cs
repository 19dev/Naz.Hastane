using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Reports.Classes;
using Naz.Hastane.Data.Entities.StoredProcedure;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class EczaneReportForm : MDIChildForm
    {
        public EczaneReportForm()
        {
            InitializeComponent();
        }

        private void EczaneReportForm_Load(object sender, EventArgs e)
        {
            this.deStartDate.DateTime = DateTime.Today;
            this.deEndDate.DateTime = DateTime.Today;
        }

        private void RefreshData()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (this.deEndDate.DateTime == null || this.deEndDate.DateTime < this.deStartDate.DateTime)
                    this.deEndDate.DateTime = this.deStartDate.DateTime;

                var EczaneSiparisFaturalariRecords = LookUpServices.GetEczaneSiparisFaturalari(this.deStartDate.DateTime.Date, this.deEndDate.DateTime.Date);
                this.gcSiparisFaturalari.DataSource = EczaneSiparisFaturalariRecords;

                var ToplamSatisRecords = LookUpServices.GetEczaneYatanHastaEczanedenTahsilEdilmeyen(this.deStartDate.DateTime.Date, this.deEndDate.DateTime.Date);
                var records11 = LookUpServices.GetEczaneYatanHastaParasiTahsilEdilmeyen(this.deStartDate.DateTime.Date, this.deEndDate.DateTime.Date);
                var records12 = LookUpServices.GetEczaneYatanHastaParasiPesin(this.deStartDate.DateTime.Date, this.deEndDate.DateTime.Date);
                var records13 = LookUpServices.GetEczanePoliklinikHastaParasiPesin(this.deStartDate.DateTime.Date, this.deEndDate.DateTime.Date);

                ToplamSatisRecords[0].Key1 = "YATAN HASTA HESABINA GEÇEN";
                ToplamSatisRecords[0].Value += records11[0].Value;
                ToplamSatisRecords.Add(records12[0]);
                ToplamSatisRecords.Add(records13[0]);
                this.gcToplamSatis.DataSource = ToplamSatisRecords;

                var EczaneParasiGeriDonecekRecords = LookUpServices.GetEczaneParasiGeriDonecek(this.deStartDate.DateTime.Date, this.deEndDate.DateTime.Date);

                var UcretsizlerRecords = LookUpServices.GetEczaneYatanHastaUcretsiz(this.deStartDate.DateTime.Date, this.deEndDate.DateTime.Date);
                var UcretsizlerRecords2 = LookUpServices.GetEczanePoliklinikHastaUcretsiz(this.deStartDate.DateTime.Date, this.deEndDate.DateTime.Date);
                UcretsizlerRecords.Add(UcretsizlerRecords2[0]);
                this.gcUcretsizler.DataSource = UcretsizlerRecords;

                var EczaneParasiGeriDonmeyenRecords = LookUpServices.GetEczaneParasiGeriDonmeyen(this.deStartDate.DateTime.Date, this.deEndDate.DateTime.Date);

                List<Key1Key2ValueRecord> tempRecords = new List<Key1Key2ValueRecord>();

                foreach (var record in EczaneParasiGeriDonecekRecords)
                {
                    if (record.Key1.StartsWith("ÇAMAŞIRHANE") || record.Key1.StartsWith("HUZUREV") || record.Key1.StartsWith("MUTFAK"))
                    {
                        tempRecords.Add(record);
                    }
                }
                foreach (var record in tempRecords)
                {
                    EczaneParasiGeriDonmeyenRecords.Add(record);
                    EczaneParasiGeriDonecekRecords.Remove(record);
                }

                this.pgcParasiGeriDonecek.DataSource = EczaneParasiGeriDonecekRecords;
                this.pgcParasiGeriDonmeyen.DataSource = EczaneParasiGeriDonmeyenRecords;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void sbPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewForm newForm = new PrintPreviewForm();
            newForm.Text = "Eczane Raporu:" + this.deStartDate.DateTime.Date.ToString() + " - " + this.deEndDate.DateTime.Date.ToString();
            ((frmMain)this.MdiParent).ShowNewDocument(newForm);
            Naz.Hastane.Reports.Classes.EczaneReport report = new Naz.Hastane.Reports.Classes.EczaneReport();

            report.pgParasiGeriDonecek.DataSource = this.pgcParasiGeriDonecek.DataSource;
            report.pgParasiGeriDonmeyen.DataSource = this.pgcParasiGeriDonmeyen.DataSource;

            newForm.ShowReport(report);
        }

        private void sbRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}