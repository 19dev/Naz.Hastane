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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Naz.Hastane.Medula.TestForms;

namespace Naz.Hastane.Medula.TestForms
{
    public partial class WS_RaporDVO : UserControl
    {        
        bool is_RaporBilgisiKaydetTakipNoDan = false;
        int beg_ = 0, end_ = 0;        

        public void Setis_RaporBilgisiKaydetTakipNoDan(bool _Value,int beg__,int end__)
        {
            beg_ = beg__ - 1;
            end_ = end__ - 1;            
            rapor_turu.SelectedIndex = beg_;
            is_RaporBilgisiKaydetTakipNoDan = _Value;

            if (_Value == true)
                groupBox2.Enabled = false;

            rapor_turu.SelectedIndex = beg_;
            rapor_duzenleme_turu.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        public string ChechThisForm()
        {
            string serr = "";

            if (!(rapor_turu.SelectedIndex >= beg_ && rapor_turu.SelectedIndex <= end_))
                serr += "-Rapor Türü veri giriþi yaptýðýnýz forma uygun deðil!\r\n";

            try
            {
                int i = Convert.ToInt32(raporTesisKodu.Text);
            }
            catch
            {
                serr += "-Rapor Tesis Kodu Geçerli bir deðer içermiyor.\r\n";
            }

            if (rap_no.Text.Trim()=="")
                serr += "-Rapor Bilgisi; Rapor No Geçerli bir deðer içermeli.\r\n";
            if (tblDoktorBilgisiDVOBindingSource.Count == 0)
                serr += "-Doktor bilgileri girilmemiþ.\r\n";
            if (tblTaniBilgisiDVOBindingSource.Count == 0)
                serr += "-Taný bilgileri girilmemiþ.\r\n";
            DataRowView RowText; 
            if (tblTaniBilgisiDVOBindingSource.Count > 0)
            {
                tblTaniBilgisiDVOBindingSource.MoveFirst();
                for (int i = 0; i < tblTaniBilgisiDVOBindingSource.Count; i++)
                {
                    RowText = (DataRowView)tblTaniBilgisiDVOBindingSource.Current;
                    if (RowText[0].ToString().Trim()=="")
                        serr += "-Taný bilgileri "+i+1.ToString()+".satýr geçersiz bilgi içeriyor.\r\n";
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
                        serr += "-Doktor bilgileri " + i+1.ToString() + ".satýr Doktor Tescil Numarasý geçersiz bilgi içeriyor.\r\n";
                    if (RowText[3].ToString().Trim() == "")
                        serr += "-Doktor bilgileri " + i+1.ToString() + ".satýr Doktor Branþ Kodu geçersiz bilgi içeriyor.\r\n";
                    if (RowText[3].ToString().Trim() == "")
                        serr += "-Doktor bilgileri " + i+1.ToString() + ".satýr Tipi geçersiz bilgi içeriyor.\r\n";
                    tblDoktorBilgisiDVOBindingSource.MoveNext();
                }
                tblDoktorBilgisiDVOBindingSource.MoveFirst();
            }

            return serr;
        }

        //public RaporDVO PrepareRaporDVO()
        //{
        //    RaporDVO Rapor = new RaporDVO();
        //    Rapor.raporBilgisi.raporTesisKodu = Convert.ToInt32(raporTesisKodu.Text);
        //    Rapor.raporBilgisi.no = rap_no.Text;
        //    Rapor.raporBilgisi.tarih = rap_tarih.Text;

        //    Rapor.turu = Convert.ToString(rapor_turu.SelectedIndex + 1);
        //    Rapor.baslangicTarihi = baslangic_tarihi.Text;
        //    Rapor.bitisTarihi = bitis_tarihi.Text;
        //    Rapor.duzenlemeTuru = Convert.ToString(rapor_duzenleme_turu.SelectedIndex + 1);

        //    if (groupBox2.Enabled == false)
        //        Rapor.hakSahibi = null;
        //    else
        //    {
        //        Rapor.hakSahibi.tckimlikNo = textBox1.Text;
        //        Rapor.hakSahibi.karneNo = textBox2.Text;
        //        Rapor.hakSahibi.sosyalGuvenlikNo = textBox3.Text;
        //        Rapor.hakSahibi.yakinlikKodu = textBox4.Text;
        //        Rapor.hakSahibi.sigortaliTuru = Convert.ToString(comboBox1.SelectedIndex + 1);
        //        Rapor.hakSahibi.devredilenKurum = Convert.ToString(comboBox2.SelectedIndex + 1);
        //        if (comboBox3.SelectedIndex == 0) Rapor.hakSahibi.provizyonTipi = "N";
        //        else if (comboBox3.SelectedIndex == 1) Rapor.hakSahibi.provizyonTipi = "I";
        //        else if (comboBox3.SelectedIndex == 2) Rapor.hakSahibi.provizyonTipi = "A";
        //        Rapor.hakSahibi.provizyonTarihi = dateTimePicker1.Text;
        //        Rapor.hakSahibi.adi = textBox5.Text;
        //        Rapor.hakSahibi.soyadi = textBox6.Text;                                
        //    }

        //    Rapor.protokolNo = textBox7.Text;
        //    Rapor.protokolTarihi = dateTimePicker2.Text;
        //    Rapor.durum = Convert.ToString(comboBox4.SelectedIndex + 1);
        //    Rapor.aciklama = textBox9.Text;
        //    Rapor.takipNo = textBox8.Text;
        //    Rapor.klinikTani = textBox10.Text;

        //    DataRowView RowText;
        //    DoktorBilgisiDVO[] DoktorBilgisi = new DoktorBilgisiDVO[tblDoktorBilgisiDVOBindingSource.Count];
        //    if (tblDoktorBilgisiDVOBindingSource.Count > 0)
        //    {
        //        tblDoktorBilgisiDVOBindingSource.MoveFirst();
        //        for (int i = 0; i < tblDoktorBilgisiDVOBindingSource.Count; i++)
        //        {
        //            RowText = (DataRowView)tblDoktorBilgisiDVOBindingSource.Current;
        //            DoktorBilgisi[i] = new DoktorBilgisiDVO();
        //            DoktorBilgisi[i].drTescilNo = RowText[0].ToString();
        //            DoktorBilgisi[i].drAdi = RowText[1].ToString();
        //            DoktorBilgisi[i].drSoyadi = RowText[2].ToString();
        //            DoktorBilgisi[i].drBransKodu = RowText[3].ToString();
        //            DoktorBilgisi[i].tipi = RowText[4].ToString()[0].ToString();

        //            tblDoktorBilgisiDVOBindingSource.MoveNext();
        //        }
        //        tblDoktorBilgisiDVOBindingSource.MoveFirst();
        //    }
            
        //    TaniBilgisiDVO[] TaniBilgisi = new TaniBilgisiDVO[tblTaniBilgisiDVOBindingSource.Count];
            
        //    if (tblTaniBilgisiDVOBindingSource.Count > 0)
        //    {
        //        tblTaniBilgisiDVOBindingSource.MoveFirst();
        //        for (int i = 0; i < tblTaniBilgisiDVOBindingSource.Count; i++)
        //        {
        //            RowText = (DataRowView)tblTaniBilgisiDVOBindingSource.Current;
        //            TaniBilgisi[i] = new TaniBilgisiDVO();
        //            TaniBilgisi[i].taniKodu = RowText[0].ToString();
        //            tblTaniBilgisiDVOBindingSource.MoveNext();
        //        }
        //        tblTaniBilgisiDVOBindingSource.MoveFirst();
        //    }

        //    Rapor.doktorlar = DoktorBilgisi;
        //    Rapor.tanilar = TaniBilgisi;

        //    return Rapor;
        //}

        public WS_RaporDVO()
        {
            InitializeComponent();
        }       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        //    if (e.ColumnIndex == 0)
        //    {
        //        frmDr ftesx = new frmDr();
        //        ftesx.selectx = true;
        //        ftesx.ShowDialog();
        //        if (ftesx.stesis != "")
        //        {
        //            dataGridView2[e.ColumnIndex, e.RowIndex].Value = ftesx.stesis;
        //            dataGridView2.RefreshEdit();
        //        }
        //        ftesx.Dispose();
        //    }
        }

        //public void Get_RaporDVO(RaporDVO Rapor)
        //{            
        //    raporTesisKodu.Text = Rapor.raporBilgisi.raporTesisKodu.ToString();
        //    rap_no.Text=Rapor.raporBilgisi.no;
        //    rap_tarih.Text=Rapor.raporBilgisi.tarih;

        //    rapor_turu.SelectedIndex = Convert.ToInt32(Rapor.turu)-1;
        //    baslangic_tarihi.Text = Rapor.baslangicTarihi;
        //    bitis_tarihi.Text = Rapor.bitisTarihi;
        //    rapor_duzenleme_turu.SelectedIndex = Convert.ToInt32(Rapor.duzenlemeTuru) - 1;

        //    if (Rapor.hakSahibi != null)
        //    {
        //        groupBox2.Enabled = true;
        //        textBox1.Text = Rapor.hakSahibi.tckimlikNo;
        //        textBox2.Text = Rapor.hakSahibi.karneNo;
        //        textBox3.Text = Rapor.hakSahibi.sosyalGuvenlikNo;
        //        textBox4.Text = Rapor.hakSahibi.yakinlikKodu;
        //        comboBox1.SelectedIndex = Convert.ToInt32(Rapor.hakSahibi.sigortaliTuru) - 1;
        //        comboBox2.SelectedIndex = Convert.ToInt32(Rapor.hakSahibi.devredilenKurum) - 1;

        //        if (Rapor.hakSahibi.provizyonTipi == "N")
        //            comboBox3.SelectedIndex = 0;
        //        else if (Rapor.hakSahibi.provizyonTipi == "I")
        //            comboBox3.SelectedIndex = 1;
        //        else if (Rapor.hakSahibi.provizyonTipi == "A")
        //            comboBox3.SelectedIndex = 2;


        //        dateTimePicker1.Text = Rapor.hakSahibi.provizyonTarihi;
        //        textBox5.Text = Rapor.hakSahibi.adi;
        //        textBox6.Text = Rapor.hakSahibi.soyadi;
        //    }
        //    else groupBox2.Enabled = false;

        //    textBox7.Text = Rapor.protokolNo;
        //    dateTimePicker2.Text = Rapor.protokolTarihi;
        //    comboBox4.SelectedIndex = Convert.ToInt32(Rapor.durum) - 1;
        //    textBox9.Text = Rapor.aciklama;
        //    textBox8.Text = Rapor.takipNo;
        //    textBox10.Text = Rapor.klinikTani;


        //    DataRow myr;
        //    if (Rapor.doktorlar != null)
        //    {
        //        if (Rapor.doktorlar.Length > 0)
        //        {
        //            foreach (DoktorBilgisiDVO ix in Rapor.doktorlar)
        //            {
        //                myr = f00_ds.Tables["tblDoktorBilgisiDVO"].NewRow();
        //                myr[0] = ix.drTescilNo;
        //                myr[1] = ix.drAdi;
        //                myr[2] = ix.drSoyadi;
        //                myr[3] = ix.drBransKodu;
        //                if (ix.tipi == "1")
        //                    myr[4] = "1 : Raporu Ýsteyen Doktor";
        //                else myr[4] = "2 : Raporu Düzenleyen Doktor";

        //                f00_ds.Tables["tblDoktorBilgisiDVO"].Rows.Add(myr);
        //            }
        //        }
        //    }

        //    if (Rapor.tanilar != null)
        //    {
        //        if (Rapor.tanilar.Length > 0)
        //        {
        //            foreach (TaniBilgisiDVO ix in Rapor.tanilar)
        //            {
        //                myr = f00_ds.Tables["tblTaniBilgisiDVO"].NewRow();
        //                myr[0] = ix.taniKodu;
        //                f00_ds.Tables["tblTaniBilgisiDVO"].Rows.Add(myr);
        //            }
        //        }
        //    }            
        //}
    }
}