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
    public partial class F00_8 : Form
    {
        public bool RapBlgKydtTkpNoDan_mi = false;
        public bool ViewF = false;
        public MaluliyetRaporDVO TMPRap = null;
        public string ktkod = "";

        public F00_8()
        {
            InitializeComponent();
        }

        private void F00_8_Load(object sender, EventArgs e)
        {
            malul_RaporDVO1.Setis_RaporBilgisiKaydetTakipNoDan(RapBlgKydtTkpNoDan_mi, 9, 9);

            if (ViewF == false)
            {
                if (RapBlgKydtTkpNoDan_mi == false)
                    this.Text = "Rapor Bilgisi Kaydet ( F00 ) - Maluliyet Raporu";
                else this.Text = "TakipNo ile Rapor Bilgisi Kaydet ( F00 ) - Maluliyet Raporu";
            }
            else
            {
                this.Text = "Maluliyet Raporu";
                button1.Tag = "1";
                button1.Text = "Formu Kapat";
                malul_RaporDVO1.Get_RaporDVO(TMPRap.raporDVO);
                textBox1.Text = TMPRap.maluliyetYuzdesi;
                textBox2.Text = TMPRap.aciklama;
                txttesis_kodu.Text = ktkod;
                if (TMPRap.bransGorusleri != null)
                {
                    if (TMPRap.bransGorusleri.Length > 0)
                    {
                        DataRow myr;
                        foreach (BransGorusBilgisiDVO ix in TMPRap.bransGorusleri)
                        {
                            myr = f00_ds.Tables["tblBransGorusBilgisi"].NewRow();
                            myr[0] = ix.bransKodu;
                            myr[1] = ix.aciklama;
                            f00_ds.Tables["tblBransGorusBilgisi"].Rows.Add(myr);
                        }
                    }
                }
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

            strerr = malul_RaporDVO1.ChechThisForm();

            try
            {
                int i = Convert.ToInt32(textBox1.Text);
                if (i>100 | i<0)
                    strerr += "-Maluliyet Yüzdesi bölümü 0-100 arasý bilgi içermeli.\r\n";                 
            }
            catch
            {
                strerr += "-Maluliyet Yüzdesi bölümü 0-100 arasý bilgi içermeli.\r\n";                 
            }

            if (GlobalClass.CheckInt(txttesis_kodu.Text) == false)
                strerr += "-Kullanýcý Tesis Kodu bölümü geçerli bir deðer içermeli.\r\n";

            DataRowView RowText;
            if (tblBransGorusBilgisiBindingSource.Count == 0)
                strerr += "-Branþ görüþ bilgileri deðer içermeli.\r\n";

            if (tblBransGorusBilgisiBindingSource.Count > 0)
            {
                tblBransGorusBilgisiBindingSource.MoveFirst();
                for (int i = 0; i < tblBransGorusBilgisiBindingSource.Count; i++)
                {
                    RowText = (DataRowView)tblBransGorusBilgisiBindingSource.Current;
                    if (RowText[0].ToString().Trim() == "")
                        strerr += "-Branþ Kodu " + i + 1.ToString() + ".satýr bir deðer içermeli.\r\n";
                    if (RowText[1].ToString().Trim() == "")
                        strerr += "-Açýklama " + i + 1.ToString() + ".satýr bir deðer içermeli.\r\n";

                    tblBransGorusBilgisiBindingSource.MoveNext();
                }
                tblBransGorusBilgisiBindingSource.MoveFirst();
            }

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
                RaporGiris.ilacRapor = null;
                RaporGiris.tedaviRapor = null;
                //RaporGiris.maluliyetRapor = null;
                
                RaporGiris.kullaniciTesisKodu = Convert.ToInt32(txttesis_kodu.Text);
                RaporGiris.maluliyetRapor.raporDVO = malul_RaporDVO1.PrepareRaporDVO();
                RaporGiris.maluliyetRapor.aciklama = textBox2.Text;
                RaporGiris.maluliyetRapor.maluliyetYuzdesi = textBox1.Text;

                BransGorusBilgisiDVO[] BransGorusBilgisi = new BransGorusBilgisiDVO[tblBransGorusBilgisiBindingSource.Count];
                if (tblBransGorusBilgisiBindingSource.Count > 0)
                {
                    tblBransGorusBilgisiBindingSource.MoveFirst();
                    for (int i = 0; i < tblBransGorusBilgisiBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblBransGorusBilgisiBindingSource.Current;
                        BransGorusBilgisi[i] = new BransGorusBilgisiDVO();
                        BransGorusBilgisi[i].bransKodu = RowText[0].ToString();
                        BransGorusBilgisi[i].aciklama = RowText[1].ToString();

                        tblBransGorusBilgisiBindingSource.MoveNext();
                    }
                    tblBransGorusBilgisiBindingSource.MoveFirst();
                }
                RaporGiris.maluliyetRapor.bransGorusleri = BransGorusBilgisi;

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