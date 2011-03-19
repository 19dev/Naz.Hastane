/*
    Bu yazýlýmýn tasarýmý ve kaynak kodlarý Datakent'e aittir.
    istenildiði gibi geliþtirilebilir, tasarýmý deðiþtirilebilir.
    yazýlýmdaki kodlar ve tasarým referans gösterilerek kullanýlabilir.
    ücretle VEYA dengi nesne karþýlýðýnda SATILMAMALIDIR.
    gönlüm bu yazýlýmýn insanlar tarafýndan serbestçe kullanýlmasýndan yanadýr.
    emeðe haksýzlýk yapmak istemiyorsanýz yazýlýmdaki DATAKENT'e ait bilgileri KALDIRMAYINIZ.
    yok ben emeði önemsemem, enayi gibi kodlarý yayýnlamasaydýnýz diyorsanýz ÝSTEDÝÐÝNÝZÝ yapabilirsiniz.
 
    http://www.datakent.com
    http://forum.datakent.com
    14-06-07
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using meno.MyWSDL_F00;

namespace meno
{
    public partial class F00_6 : Form
    {
        public bool RapBlgKydtTkpNoDan_mi = false;
        public bool ViewF = false;
        public IlacRaporDVO TMPRap = null;
        public string ktkod = "";

        public F00_6()
        {
            InitializeComponent();
        }

        private void F00_6_Load(object sender, EventArgs e)
        {
            ilac_RaporDVO1.Setis_RaporBilgisiKaydetTakipNoDan(RapBlgKydtTkpNoDan_mi, 10, 11);

            if (ViewF == false)
            {
                if (RapBlgKydtTkpNoDan_mi == false)
                    this.Text = "Rapor Bilgisi Kaydet ( F00 ) - Ýlaç Raporu";
                else this.Text = "TakipNo ile Rapor Bilgisi Kaydet ( F00 ) - Ýlaç Raporu";
            }
            else
            {
                this.Text = "Ýlaç Raporu";
                button1.Tag = "1";
                button1.Text = "Formu Kapat";
                ilac_RaporDVO1.Get_RaporDVO(TMPRap.raporDVO);
                txttesis_kodu.Text = ktkod;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string)button1.Tag == "1")
            {
                this.Close();
                return;
            }

            string strerr = "";

            strerr = ilac_RaporDVO1.ChechThisForm();

            if (GlobalClass.CheckInt(txttesis_kodu.Text) == false)
                strerr += "-Kullanýcý Tesis Kodu bölümü geçerli bir deðer içermeli.\r\n";

            if (strerr != "")
            {
                ErrFrm erxf = new ErrFrm();
                erxf.ermessage = strerr;
                erxf.ShowDialog();
                erxf.Dispose();
                return;
            }

            try
            {
                button1.Enabled = false;
                toolStripStatusLabel1.Text = GlobalClass.msg01;
                this.Refresh();

                RaporIslemleriService servis = new RaporIslemleriService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;

                RaporGirisDVO RaporGiris = new RaporGirisDVO();

                RaporGiris.isgoremezlikRapor = null;
                RaporGiris.dogumOncesiCalisabilirRapor = null;
                RaporGiris.dogumRapor = null;
                RaporGiris.analikRapor = null;
                RaporGiris.protezRapor = null;
                //RaporGiris.ilacRapor = null;
                RaporGiris.tedaviRapor = null;
                RaporGiris.maluliyetRapor = null;

                RaporGiris.kullaniciTesisKodu = Convert.ToInt32(txttesis_kodu.Text);
                RaporGiris.ilacRapor.raporDVO = ilac_RaporDVO1.PrepareRaporDVO();

                RaporCevapDVO RaporCevap = new RaporCevapDVO();
                if (RapBlgKydtTkpNoDan_mi == false)
                    RaporCevap = servis.raporBilgisiKaydet(RaporGiris);
                else RaporCevap = servis.takipNoileRaporBilgisiKaydet(RaporGiris);                

                resultForm rsform = new resultForm();
                rsform.raporTuru = RaporCevap.raporTuru;
                rsform.sonucKodu = RaporCevap.sonucKodu.ToString();
                rsform.sonucAciklamasi = RaporCevap.sonucAciklamasi;
                if (RaporCevap.dogumOncesiCalisabilirRapor == null)
                    rsform.isNULL_ = true;
                else rsform.isNULL_ = false;

                button1.Enabled = true;
                toolStripStatusLabel1.Text = GlobalClass.msg02;
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = GlobalClass.msg03;
                ErrFrm erxf = new ErrFrm();
                erxf.ermessage = ex.Message;
                erxf.ShowDialog();
                erxf.Dispose();

                button1.Enabled = true;
            }
        }
    }
}