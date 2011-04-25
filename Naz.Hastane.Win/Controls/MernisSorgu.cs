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

        public TCKimlikResponse TCKimlikResponse = new TCKimlikResponse();
        public KisiBilgisiC KisiBilgisi = new KisiBilgisiC();
        public NufusCuzdanC NufusCuzdani = new NufusCuzdanC();

        public bool IsOK = false;

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

        public void CallMernis(string TCID)
        {
            if (IsWorking) return;

            this.lcStatus.Text = "Mernis Sorgusu Yapılıyor!";
            IsWorking = true;
            IsOK = false;
            _TCID = long.Parse(TCID);
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

            TCKimlikResponse = new TCKimlikResponse();
            KPSSoap service = KPSServiceFactory.Create();

            //TC Kimlik No Giriş 
            TCKimlikNoG[] _TCKimlikNoGA = new TCKimlikNoG[1];
            TCKimlikNoG _TCKimlikNoG = new TCKimlikNoG();
            _TCKimlikNoG.TCKimlikNo = _TCID;
            _TCKimlikNoGA[0] = _TCKimlikNoG;

            NKOTCKimlikNoG[] _NKOTCKimlikNoGA = new NKOTCKimlikNoG[1];
            NKOTCKimlikNoG _NKOTCKimlikNoG = new NKOTCKimlikNoG();
            _NKOTCKimlikNoG.TCKimlikNo = _TCID;
            _NKOTCKimlikNoG.EskiEsListele = 0;
            _NKOTCKimlikNoG.NKOTipi = NufusKayitOrnegiTipi.KisiKayitOrnegi;
            _NKOTCKimlikNoG.Vukuatli = 1;

            _NKOTCKimlikNoGA[0] = _NKOTCKimlikNoG;

            try
            {
                //Service Gönderim  -Cevap Alma 
                _KisiBilgisi = service.TCKimlikNodanKisiBilgisiSorgula(_TCKimlikNoGA);
                TCKimlikResponse.Adı = _KisiBilgisi[0].TemelBilgisi.Ad;
                TCKimlikResponse.Soyadı = _KisiBilgisi[0].TemelBilgisi.Soyad;
                TCKimlikResponse.AnaAdı = _KisiBilgisi[0].TemelBilgisi.AnaAd;
                TCKimlikResponse.BabaAdı = _KisiBilgisi[0].TemelBilgisi.BabaAd;
                TCKimlikResponse.Cinsiyeti = _KisiBilgisi[0].TemelBilgisi.Cinsiyet.ToString();
                TCKimlikResponse.Dogumtarihi = _KisiBilgisi[0].TemelBilgisi.DogumTarih.Gun.ToString() + "." +
                    _KisiBilgisi[0].TemelBilgisi.DogumTarih.Ay.ToString() + "." +
                    _KisiBilgisi[0].TemelBilgisi.DogumTarih.Yil.ToString(); ;
                TCKimlikResponse.DoğumYeri = _KisiBilgisi[0].TemelBilgisi.DogumYer;
                TCKimlikResponse.OzurDurumu = _KisiBilgisi[0].TemelBilgisi.OzurOran;
                TCKimlikResponse.IlAd = _KisiBilgisi[0].KayitYeriBilgisi.IlAd;
                TCKimlikResponse.IlceAd = _KisiBilgisi[0].KayitYeriBilgisi.IlceAd;
                KisiBilgisi = _KisiBilgisi[0];

                var cevap = service.NufusCuzdaniDogrulama(_TCKimlikNoGA);
                NufusCuzdani = cevap[0];

                //var cevap1 = service.TcNodanNKOSorgula(_NKOTCKimlikNoGA);

                //var cevap1 = service.IlListesiGetir();

                //var cevap2 = service.IlceListesiGetir();
                IsOK = true;
            }
            catch (Exception ee)
            {
                IsOK = false;
            }

        }

        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            IsWorking = false;

            if (IsOK)
            {
                this.lcStatus.Text = "Mernis Sorgusu Başarılı!";
            }
            else
            {
                this.lcStatus.Text = "Mernis Sorgusu Yapılamadı!";
                XtraMessageBox.Show(e.Error.ToString(), "Mernis Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (RunWorkerCompleted != null)
                RunWorkerCompleted(this, e);

        }

    }
}
