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
    public partial class F00_1 : Form
    {
        public bool RapBlgKydtTkpNoDan_mi = false;
        public bool ViewF = false;
        public IsgoremezlikRaporDVO TMPRap = null;
        public string ktkod = "";

        public F00_1()
        {
            InitializeComponent();
        }

        private void F00_1_Load(object sender, EventArgs e)
        {
            isgoremelik_RaporDVO.Setis_RaporBilgisiKaydetTakipNoDan(RapBlgKydtTkpNoDan_mi, 2, 4);

            if (ViewF == false)
            {
                if (RapBlgKydtTkpNoDan_mi == false)
                    this.Text = "Rapor Bilgisi Kaydet ( F00 ) - Ýþgöremezlik Raporu";
                else this.Text = "TakipNo ile Rapor Bilgisi Kaydet ( F00 ) - Ýþgöremezlik Raporu";
                isgrm_kontrolMu.SelectedIndex = 0;
            }
            else
            {
                this.Text = "Ýþgöremezlik Raporu";
                button1.Tag = "1";
                button1.Text = "Formu Kapat";
                isgoremelik_RaporDVO.Get_RaporDVO(TMPRap.raporDVO);
                txttesis_kodu.Text = ktkod;
                isgrm_kontrolTarihi.Text = TMPRap.kontrolTarihi;
                if (TMPRap.kontrolMu == "E")
                    isgrm_kontrolMu.SelectedIndex = 0;
                else isgrm_kontrolMu.SelectedIndex = 1;

                if (TMPRap.yatislar != null)
                {
                    if (TMPRap.yatislar.Length > 0)
                    {
                        DataRow myr;
                        foreach (HastaYatisBilgisiDVO ix in TMPRap.yatislar)
                        {
                            myr = f00_ds.Tables["tblHastaYatisBilgisi"].NewRow();
                            myr[0] = ix.yatisTarihi;
                            myr[1] = ix.cikisTarihi;
                            f00_ds.Tables["tblHastaYatisBilgisi"].Rows.Add(myr);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strerr = "";

            strerr = isgoremelik_RaporDVO.ChechThisForm();

            try
            {
                int i = Convert.ToInt32(txttesis_kodu.Text);
            }
            catch
            {
                strerr += "-Kullanýcý Tesis Kodu bölümü geçerli bir deðer içermeli.\r\n";
            }

            DataRowView RowText;
            if (tblHastaYatisBilgisiBindingSource.Count > 0)
            {
                tblHastaYatisBilgisiBindingSource.MoveFirst();
                for (int i = 0; i < tblHastaYatisBilgisiBindingSource.Count; i++)
                {
                    RowText = (DataRowView)tblHastaYatisBilgisiBindingSource.Current;
                    if (GlobalClass.CheckDate(RowText[0].ToString()) == false)
                        strerr += "-Yatýþ tarihi " + i + 1.ToString() + ".satýr geçersiz bilgi içeriyor.Örnek:25.10.2007\r\n";

                    if (GlobalClass.CheckDate(RowText[1].ToString()) == false)
                        strerr += "-Çýkýþ tarihi " + i + 1.ToString() + ".satýr geçersiz bilgi içeriyor.Örnek:25.10.2007\r\n";

                    tblHastaYatisBilgisiBindingSource.MoveNext();
                }
                tblHastaYatisBilgisiBindingSource.MoveFirst();
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

                //RaporGiris.isgoremezlikRapor = null;
                RaporGiris.dogumOncesiCalisabilirRapor = null;
                RaporGiris.dogumRapor = null;
                RaporGiris.analikRapor = null;
                RaporGiris.protezRapor = null;
                RaporGiris.ilacRapor = null;
                RaporGiris.tedaviRapor = null;
                RaporGiris.maluliyetRapor = null;

                RaporGiris.kullaniciTesisKodu = Convert.ToInt32(txttesis_kodu.Text);
                RaporGiris.isgoremezlikRapor.kontrolMu = isgrm_kontrolMu.Text[0].ToString();
                RaporGiris.isgoremezlikRapor.kontrolTarihi = isgrm_kontrolTarihi.Text;
                
                HastaYatisBilgisiDVO[] HastaYatisBilgisi = new HastaYatisBilgisiDVO[tblHastaYatisBilgisiBindingSource.Count];
                if (tblHastaYatisBilgisiBindingSource.Count > 0)
                {
                    RaporGiris.isgoremezlikRapor.hastaYatisVarMi = "E";

                    tblHastaYatisBilgisiBindingSource.MoveFirst();
                    for (int i = 0; i < tblHastaYatisBilgisiBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblHastaYatisBilgisiBindingSource.Current;
                        HastaYatisBilgisi[i] = new HastaYatisBilgisiDVO();
                        HastaYatisBilgisi[i].yatisTarihi = RowText[0].ToString();
                        HastaYatisBilgisi[i].cikisTarihi = RowText[1].ToString();

                        tblHastaYatisBilgisiBindingSource.MoveNext();
                    }
                    tblHastaYatisBilgisiBindingSource.MoveFirst();
                }
                else
                {
                    RaporGiris.isgoremezlikRapor.hastaYatisVarMi = "H";
                }
                RaporGiris.isgoremezlikRapor.yatislar = HastaYatisBilgisi;
                RaporGiris.isgoremezlikRapor.raporDVO = isgoremelik_RaporDVO.PrepareRaporDVO();

                RaporCevapDVO RaporCevap = new RaporCevapDVO();
                if (RapBlgKydtTkpNoDan_mi==false)
                    RaporCevap = servis.raporBilgisiKaydet(RaporGiris);
                else RaporCevap = servis.takipNoileRaporBilgisiKaydet(RaporGiris);

                resultForm rsform = new resultForm();
                rsform.raporTuru = RaporCevap.raporTuru;
                rsform.sonucKodu = RaporCevap.sonucKodu.ToString();
                rsform.sonucAciklamasi = RaporCevap.sonucAciklamasi;
                if (RaporCevap.isgoremezlikRapor == null)
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