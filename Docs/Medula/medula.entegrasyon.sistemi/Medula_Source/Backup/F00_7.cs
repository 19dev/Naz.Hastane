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
    public partial class F00_7 : Form
    {
        public bool RapBlgKydtTkpNoDan_mi = false;
        public bool ViewF = false;
        public TedaviRaporDVO TMPRap = null;
        public string ktkod = "";

        public F00_7()
        {
            InitializeComponent();
        }

        private void F00_7_Load(object sender, EventArgs e)
        {
            tedavi_RaporDVO1.Setis_RaporBilgisiKaydetTakipNoDan(RapBlgKydtTkpNoDan_mi, 1, 1);

            if (ViewF == false)
            {
                if (RapBlgKydtTkpNoDan_mi == false)
                    this.Text = "Rapor Bilgisi Kaydet ( F00 ) - Tedavi Raporu";
                else this.Text = "TakipNo ile Rapor Bilgisi Kaydet ( F00 ) - Tedavi Raporu";
            }
            else
            {
                this.Text = "Tedavi Raporu";
                button1.Tag = "1";
                button1.Text = "Formu Kapat";
                tedavi_RaporDVO1.Get_RaporDVO(TMPRap.raporDVO);
                txttesis_kodu.Text = ktkod;
                if (TMPRap.islemler != null)
                {
                    if (TMPRap.islemler.Length > 0)
                    {
                        DataRow myr;
                        foreach (TedaviIslemBilgisiDVO ix in TMPRap.islemler)
                        {
                            myr = f00_ds.Tables["tblTedaviIslemBilgisi"].NewRow();
                            myr[0] = ix.butKodu;
                            myr[1] = ix.seansSayi.ToString();
                            myr[2] = ix.seansGun.ToString();
                            if (ix.refakatVarMi == "E")
                                myr[3] = "E : Evet";
                            else myr[3] = "H : Hayýr";

                            f00_ds.Tables["tblTedaviIslemBilgisi"].Rows.Add(myr);
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

            strerr = tedavi_RaporDVO1.ChechThisForm();

            if (GlobalClass.CheckInt(txttesis_kodu.Text) == false)
                strerr += "-Kullanýcý Tesis Kodu bölümü geçerli bir deðer içermeli.\r\n";

            DataRowView RowText;
            if (tblTedaviIslemBilgisiBindingSource.Count == 0)
                strerr += "-Tedavi iþlem bilgileri deðer içermeli.\r\n";

            if (tblTedaviIslemBilgisiBindingSource.Count > 0)
            {
                tblTedaviIslemBilgisiBindingSource.MoveFirst();
                for (int i = 0; i < tblTedaviIslemBilgisiBindingSource.Count; i++)
                {
                    RowText = (DataRowView)tblTedaviIslemBilgisiBindingSource.Current;
                    if (RowText[0].ToString().Trim() == "")
                        strerr += "-BUT iþlem kodu " + i + 1.ToString() + ".satýr bir deðer içermeli.\r\n";
                    if (RowText[3].ToString().Trim() == "")
                        strerr += "-Refakat Var mý " + i + 1.ToString() + ".satýr bir deðer içermeli.\r\n";

                    if (GlobalClass.CheckInt(RowText[1].ToString()) == false)
                        strerr += "-Seans Sayý " + i + 1.ToString() + ".satýr geçersiz bilgi içeriyor.\r\n";
                    if (GlobalClass.CheckInt(RowText[2].ToString()) == false)
                        strerr += "-Seans Gün " + i + 1.ToString() + ".satýr geçersiz bilgi içeriyor.\r\n";

                    tblTedaviIslemBilgisiBindingSource.MoveNext();
                }
                tblTedaviIslemBilgisiBindingSource.MoveFirst();
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
                //RaporGiris.tedaviRapor = null;
                RaporGiris.maluliyetRapor = null;

                RaporGiris.kullaniciTesisKodu = Convert.ToInt32(txttesis_kodu.Text);
                RaporGiris.tedaviRapor.raporDVO = tedavi_RaporDVO1.PrepareRaporDVO();

                TedaviIslemBilgisiDVO[] TedaviIslemBilgisi = new TedaviIslemBilgisiDVO[tblTedaviIslemBilgisiBindingSource.Count];
                if (tblTedaviIslemBilgisiBindingSource.Count > 0)
                {
                    tblTedaviIslemBilgisiBindingSource.MoveFirst();
                    for (int i = 0; i < tblTedaviIslemBilgisiBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblTedaviIslemBilgisiBindingSource.Current;
                        TedaviIslemBilgisi[i] = new TedaviIslemBilgisiDVO();
                        TedaviIslemBilgisi[i].butKodu = RowText[0].ToString();
                        TedaviIslemBilgisi[i].seansSayi = Convert.ToInt32( RowText[1].ToString());
                        TedaviIslemBilgisi[i].seansGun = Convert.ToInt32(RowText[2].ToString());
                        TedaviIslemBilgisi[i].refakatVarMi = RowText[3].ToString()[0].ToString();

                        tblTedaviIslemBilgisiBindingSource.MoveNext();
                    }
                    tblTedaviIslemBilgisiBindingSource.MoveFirst();
                }
                RaporGiris.tedaviRapor.islemler = TedaviIslemBilgisi;

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