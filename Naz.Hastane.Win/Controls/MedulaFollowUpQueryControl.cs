using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Medula.YardimciIslemler;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Medula.HastaKabulIslemleri;

namespace Naz.Hastane.Win.Controls
{
    public partial class MedulaFollowUpQueryControl : DevExpress.XtraEditors.XtraUserControl
    {
        public event System.EventHandler<takipAraCompletedEventArgs> OnTakipAraCompleted;
        public event System.EventHandler<hastaKabulIptalCompletedEventArgs> OnHastaKabulIptalCompleted;

        private YardimciIslemlerClient yic;
        private HastaKabulIslemleriClient hki;

        private bool _IsLoaded = false;
        private string _TCId;

        public string TCId 
        {
            get { return _TCId; }
            set
            {
                _TCId = value;
                if (this.deStartDate.DateTime == null)
                {
                    this.deStartDate.DateTime = DateTime.Today;
                    this.deEndDate.DateTime = DateTime.Today;
                }
            }
        }

        public MedulaFollowUpQueryControl()
        {
            InitializeComponent();
        }

        private bool _IsWorking;
        public bool IsWorking
        {
            get { return _IsWorking; }
            set
            {
                _IsWorking = value;
                EnableControls(!_IsWorking);
            }
        }

        public bool IsOK { get; set; }

        private void EnableControls(bool enable)
        {
            foreach (Control c in this.layoutControl1.Controls)
                c.Enabled = enable;
        }

        private void MedulaFollowUpQueryControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode) LoadLookUps();
            this.lueOnlyExternalTransfers.EditValue = "H";
            this.deStartDate.DateTime = DateTime.Today;
            this.deEndDate.DateTime = DateTime.Today;
            _IsLoaded = true;
        }

        public void CallMedulaTakipAra()
        {
            if (IsWorking) return;
            if (String.IsNullOrWhiteSpace(TCId)) return;

            IsWorking = true;

            yic = new YardimciIslemlerClient();
            System.Net.ServicePointManager.Expect100Continue = false;

            yic.ClientCredentials.UserName.UserName = "10343154";
            yic.ClientCredentials.UserName.Password = "19031903";

            yic.takipAraCompleted += new EventHandler<takipAraCompletedEventArgs>(TakipAraCompleted);

            TakipAraGirisDVO tag = new TakipAraGirisDVO();
            tag.baslangicTarihi  = this.deStartDate.DateTime.ToString("dd.MM.yyyy");
            tag.bitisTarihi      = this.deEndDate.DateTime.ToString("dd.MM.yyyy");
            tag.hastaTCK         = TCId;
            tag.sevkDurumu       = this.lueOnlyExternalTransfers.EditValue.ToString();
            tag.saglikTesisKodu  = 10343154;

            this.lblStatus.Text = "Medula Sorgusu Yapılıyor...";
            IsOK = false;

            yic.takipAraAsync(tag);

        }

        void TakipAraCompleted(Object sender, takipAraCompletedEventArgs e)
        {
            IsWorking = false;
            try
            {
                this.lblStatus.Text = e.Result.sonucKodu + ": " + e.Result.sonucMesaji;

                if (e.Result.sonucKodu == "0000")
                {
                    Naz.Hastane.Medula.YardimciIslemler.TakipDVO[] takipDVOs = e.Result.takipler;
                    this.gcResult.DataSource = takipDVOs;
                }
                IsOK = true;
            }
            catch
            {
                this.lblStatus.Text = "Medula Takip Sorgusu Yapılamadı!";

                IsOK = false;
            }
            finally
            {
                yic = null;
                if (OnTakipAraCompleted != null)
                    OnTakipAraCompleted(this, e);
            }
        }

        public void CallMedulaHastaKabulIptal(string takipNo)
        {
            if (IsWorking) return;
            if (String.IsNullOrWhiteSpace(TCId)) return;

            IsWorking = true;

            hki = new HastaKabulIslemleriClient();

            System.Net.ServicePointManager.Expect100Continue = false;

            hki.ClientCredentials.UserName.UserName = "10343154";
            hki.ClientCredentials.UserName.Password = "19031903";

            hki.hastaKabulIptalCompleted += new EventHandler<hastaKabulIptalCompletedEventArgs>(HastaKabulIptalCompleted);

            TakipSilGirisDVO tsg = new TakipSilGirisDVO();
            tsg.takipNo = takipNo;
            tsg.saglikTesisKodu = 10343154;

            this.lblStatus.Text = "Medula Hasta Kabul İptal Sorgusu Yapılıyor...";
            IsOK = false;

            hki.hastaKabulIptalAsync(tsg);

        }

        void HastaKabulIptalCompleted(Object sender, hastaKabulIptalCompletedEventArgs e)
        {
            IsWorking = false;
            try
            {
                this.lblStatus.Text = e.Result.sonucKodu + ": " + e.Result.sonucMesaji;

                if (e.Result.sonucKodu == "0000")
                {
                    XtraMessageBox.Show(e.Result.takipNo + " Nolu Takip İptal Edildi!", "Hasta Kabul İptal");
                    IsOK = true;
                }
            }
            catch
            {
                this.lblStatus.Text = "Hasta Kabul İptal Sorgusu Yapılamadı!";
                IsOK = false;
            }
            finally
            {
                yic = null;
                if (OnHastaKabulIptalCompleted != null)
                    OnHastaKabulIptalCompleted(this, e);
                if (IsOK && _IsLoaded)
                    CallMedulaTakipAra();
            }
        }


        private void LoadLookUps()
        {
            UIUtilities.BindLookUpEdit(this.lueOnlyExternalTransfers, LookUpServices.YesNos);

        }

        private void sbQuery_Click(object sender, EventArgs e)
        {
            CallMedulaTakipAra();
        }

        private void sbExcel_Click(object sender, EventArgs e)
        {

        }

        private void sbPrint_Click(object sender, EventArgs e)
        {

        }

        private void sbDelete_Click(object sender, EventArgs e)
        {
            Naz.Hastane.Medula.YardimciIslemler.TakipDVO takipDVO = this.gvResult.GetFocusedRow() as Naz.Hastane.Medula.YardimciIslemler.TakipDVO;
            if (takipDVO == null) return;

            if (XtraMessageBox.Show("Seçili Kayıdı Silmek İstiyor Musunuz", "Provizyon Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                CallMedulaHastaKabulIptal(takipDVO.takipNo);
        }
    
    }
}
