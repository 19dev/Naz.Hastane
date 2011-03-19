using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Mernis.Utilities.WCF;
using Naz.Mernis.Service;
using Naz.Hastane.Medula.HastaKabulIslemleri;
using Naz.Utilities.Classes;
using Naz.Mernis.Utilities;

namespace Naz.Hastane.Win.Controls
{
    public partial class MernisSorgu : DevExpress.XtraEditors.XtraUserControl
    {
        public event RunWorkerCompletedEventHandler RunWorkerCompleted;

        public TCKimlikResponse _TCKimlikResponse = new TCKimlikResponse();
        private long _TCID = 0;

        private bool _IsWorking = false;
        public bool IsWorking { 
            get { return _IsWorking; }
            private set { _IsWorking = value; }
        }

        public MernisSorgu()
        {
            InitializeComponent();
        }
        
        private StandartBackgroundWorker backgroundWorker;
        private KisiBilgisiC[] _KisiBilgisi;

        public void CallMernis(int TCID)
        {
            if (IsWorking) return;

            IsWorking = true;

            _TCID = TCID;
            backgroundWorker = new StandartBackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
            backgroundWorker.DoWork += new DoWorkEventHandler(Generate);
            backgroundWorker.RunWorkerAsync();
        }

        void Generate(object sender, DoWorkEventArgs e)
        {
            //Hastane Kullanıcı Bilgileri Doldurma 
            string HUser = "surppirgichst";
            string HPass = "1255524531";

            KPSConfiguration.Instance.Username = HUser;
            KPSConfiguration.Instance.Password = HPass;

            _TCKimlikResponse = new TCKimlikResponse();
            KPSSoap service = KPSServiceFactory.Create();

            //TC Kimlik No Giriş 
            TCKimlikNoG[] _TCKimlikNoGA = new TCKimlikNoG[1];
            TCKimlikNoG _TCKimlikNoG = new TCKimlikNoG();
            _TCKimlikNoG.TCKimlikNo = _TCID;
            _TCKimlikNoGA[0] = _TCKimlikNoG;

            try
            {
                //Service Gönderim  -Cevap Alma 
                _KisiBilgisi = service.TCKimlikNodanKisiBilgisiSorgula(_TCKimlikNoGA);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }

        }

        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Servis Cevap Dönüş Bilgileri
            _TCKimlikResponse.Adı = _KisiBilgisi[0].TemelBilgisi.Ad.ToString();
            _TCKimlikResponse.Soyadı = _KisiBilgisi[0].TemelBilgisi.Soyad.ToString();
            _TCKimlikResponse.AnaAdı = _KisiBilgisi[0].TemelBilgisi.AnaAd.ToString();
            _TCKimlikResponse.BabaAdı = _KisiBilgisi[0].TemelBilgisi.BabaAd.ToString();
            _TCKimlikResponse.Cinsiyeti = _KisiBilgisi[0].TemelBilgisi.Cinsiyet.ToString();
            _TCKimlikResponse.Dogumtarihi = _KisiBilgisi[0].TemelBilgisi.DogumTarih.Gun.ToString() + "." + 
                _KisiBilgisi[0].TemelBilgisi.DogumTarih.Ay.ToString() + "." + 
                _KisiBilgisi[0].TemelBilgisi.DogumTarih.Yil.ToString(); ;
            _TCKimlikResponse.DoğumYeri = _KisiBilgisi[0].TemelBilgisi.DogumYer.ToString();
            _TCKimlikResponse.OzurDurumu = _KisiBilgisi[0].TemelBilgisi.OzurOran;
            _TCKimlikResponse.IlAd = _KisiBilgisi[0].KayitYeriBilgisi.IlAd.ToString();
            _TCKimlikResponse.IlceAd = _KisiBilgisi[0].KayitYeriBilgisi.IlceAd.ToString();

            IsWorking = false;

            if (RunWorkerCompleted != null) RunWorkerCompleted(this, e);
        }

    }
}
