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
    public partial class F00_B : Form
    {
        public F00_B()
        {
            InitializeComponent();
        }

        private void F00_B_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strerr = "";

            if ( GlobalClass.CheckInt(txttesis_kodu.Text)==false)                            
                strerr += "-Kullanýcý Tesis Kodu bölümü geçerli bir deðer içermeli.\r\n";

            if (GlobalClass.CheckInt(raporTesisKodu.Text) == false)                            
                strerr += "-Rapor Tesis Kodu bölümü geçerli bir deðer içermeli.\r\n";
            
            if ( rap_no.Text.Trim()=="")
                strerr += "-Rapor No bölümü geçerli bir deðer içermeli.\r\n";

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

            if (tblDoktorBilgisiDVOBindingSource.Count == 0)
                strerr += "-Doktor bilgileri girilmemiþ.\r\n";
            if (tblTaniBilgisiDVOBindingSource.Count == 0)
                strerr += "-Taný bilgileri girilmemiþ.\r\n";
            
            if (tblTaniBilgisiDVOBindingSource.Count > 0)
            {
                tblTaniBilgisiDVOBindingSource.MoveFirst();
                for (int i = 0; i < tblTaniBilgisiDVOBindingSource.Count; i++)
                {
                    RowText = (DataRowView)tblTaniBilgisiDVOBindingSource.Current;
                    if (RowText[0].ToString().Trim() == "")
                        strerr += "-Taný bilgileri " + i + 1.ToString() + ".satýr geçersiz bilgi içeriyor.\r\n";
                    tblTaniBilgisiDVOBindingSource.MoveNext();
                }
                tblTaniBilgisiDVOBindingSource.MoveFirst();
            }

            if (tblDoktorBilgisiDVOBindingSource.Count > 0)
            {
                tblDoktorBilgisiDVOBindingSource.MoveFirst();
                for (int i = 0; i < tblDoktorBilgisiDVOBindingSource.Count; i++)
                {
                    RowText = (DataRowView)tblDoktorBilgisiDVOBindingSource.Current;
                    if (RowText[0].ToString().Trim() == "")
                        strerr += "-Doktor bilgileri " + i + 1.ToString() + ".satýr Doktor Tescil Numarasý geçersiz bilgi içeriyor.\r\n";
                    if (RowText[3].ToString().Trim() == "")
                        strerr += "-Doktor bilgileri " + i + 1.ToString() + ".satýr Doktor Branþ Kodu geçersiz bilgi içeriyor.\r\n";
                    if (RowText[3].ToString().Trim() == "")
                        strerr += "-Doktor bilgileri " + i + 1.ToString() + ".satýr Tipi geçersiz bilgi içeriyor.\r\n";
                    tblDoktorBilgisiDVOBindingSource.MoveNext();
                }
                tblDoktorBilgisiDVOBindingSource.MoveFirst();
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

                IsgoremezlikRaporEkDVO RaporGiris = new IsgoremezlikRaporEkDVO();



                RaporGiris.kullaniciTesisKodu = Convert.ToInt32(txttesis_kodu.Text);
                RaporGiris.raporBilgisiDVO.raporTesisKodu = Convert.ToInt32(raporTesisKodu.Text);
                RaporGiris.raporBilgisiDVO.no = rap_no.Text;
                RaporGiris.raporBilgisiDVO.tarih = rap_tarih.Text;

                RaporGiris.bitisTarihi = dateTimePicker1.Text;
                RaporGiris.duzenlemeTuru = Convert.ToString(comboBox1.SelectedIndex + 1);
                if (comboBox2.SelectedIndex == 0)
                    RaporGiris.kontrolMu = "E";
                else RaporGiris.kontrolMu = "H";
                RaporGiris.kontrolTarihi = dateTimePicker2.Text;
                RaporGiris.protokolNo = textBox1.Text;
                if (dateTimePicker3.Checked)
                    RaporGiris.protokolTarihi = dateTimePicker3.Text;
                //RaporGiris.durum = "";      
                RaporGiris.aciklama = textBox2.Text;                

                HastaYatisBilgisiDVO[] HastaYatisBilgisi = new HastaYatisBilgisiDVO[tblHastaYatisBilgisiBindingSource.Count];
                if (tblHastaYatisBilgisiBindingSource.Count > 0)
                {
                    RaporGiris.hastaYatisVarMi = "E";

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
                    RaporGiris.hastaYatisVarMi = "H";
                }                

                DoktorBilgisiDVO[] DoktorBilgisi = new DoktorBilgisiDVO[tblDoktorBilgisiDVOBindingSource.Count];
                if (tblDoktorBilgisiDVOBindingSource.Count > 0)
                {
                    tblDoktorBilgisiDVOBindingSource.MoveFirst();
                    for (int i = 0; i < tblDoktorBilgisiDVOBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblDoktorBilgisiDVOBindingSource.Current;
                        DoktorBilgisi[i] = new DoktorBilgisiDVO();
                        DoktorBilgisi[i].drTescilNo = RowText[0].ToString();
                        DoktorBilgisi[i].drAdi = RowText[1].ToString();
                        DoktorBilgisi[i].drSoyadi = RowText[2].ToString();
                        DoktorBilgisi[i].drBransKodu = RowText[3].ToString();
                        DoktorBilgisi[i].tipi = RowText[4].ToString()[0].ToString();

                        tblDoktorBilgisiDVOBindingSource.MoveNext();
                    }
                    tblDoktorBilgisiDVOBindingSource.MoveFirst();
                }

                TaniBilgisiDVO[] TaniBilgisi = new TaniBilgisiDVO[tblTaniBilgisiDVOBindingSource.Count];

                if (tblTaniBilgisiDVOBindingSource.Count > 0)
                {
                    tblTaniBilgisiDVOBindingSource.MoveFirst();
                    for (int i = 0; i < tblTaniBilgisiDVOBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblTaniBilgisiDVOBindingSource.Current;
                        TaniBilgisi[i] = new TaniBilgisiDVO();
                        TaniBilgisi[i].taniKodu = RowText[0].ToString();
                        tblTaniBilgisiDVOBindingSource.MoveNext();
                    }
                    tblTaniBilgisiDVOBindingSource.MoveFirst();
                }
                
                RaporGiris.yatislar = HastaYatisBilgisi;
                RaporGiris.doktorlar = DoktorBilgisi;
                RaporGiris.tanilar = TaniBilgisi;

                RaporUzatCevapDVO RaporCevap = new RaporUzatCevapDVO();
                RaporCevap = servis.raporUzat(RaporGiris);

                F00_C f0x = new F00_C();
                f0x.RaporCevap = RaporCevap;
                f0x.ShowDialog();
                f0x.Dispose();

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