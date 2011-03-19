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
using meno.MyWSDL_C00;

namespace meno
{
    public partial class C00_2 : Form
    {
        public OdemeSorguCevapDVO OdemeSorguCevap = new OdemeSorguCevapDVO();

        public C00_2()
        {
            InitializeComponent();
        }

        string Durum_(string drmc)
        {
            string rst = "";
            switch (drmc)
            {
                case "0":
                    rst = "Ýlk kayýt";
                    break;
                case "1":
                    rst = "hatasýz";
                    break;
                case "2":
                    rst = "hatalý";
                    break;
                case "3":
                    rst = "faturalandý";
                    break;
                case "4":
                    rst = "dönem sonlandýrýldý";
                    break;
                case "5":
                    rst = "incelendi";
                    break;
                default:
                    rst = "";
                    break;
            }
            return rst;
        }

        private void C00_2_Load(object sender, EventArgs e)
        {
            textBox1.Text = OdemeSorguCevap.sonucKodu.ToString();
            textBox2.Text = OdemeSorguCevap.sonucMesaji.ToString();
            textBox4.Text = OdemeSorguCevap.toplamTutar.ToString();
            textBox3.Text = Durum_(OdemeSorguCevap.durum.ToString());
            DataRow myr;

            try
            {
                if (OdemeSorguCevap.hataliKayitlar != null)
                {
                    if (OdemeSorguCevap.hataliKayitlar.Length > 0)
                    {
                        foreach (OdemeSorguHataBilgisiDVO ix in OdemeSorguCevap.hataliKayitlar)
                        {
                            myr = c00_ds.Tables["tblOdemeSorguHataBilgisi"].NewRow();
                            myr[0] = ix.hataKodu.ToString();
                            myr[1] = ix.hataMesaji.ToString();
                            myr[2] = ix.hizmetSunucuRefNo.ToString();
                            myr[3] = ix.islemSiraNo.ToString();
                            myr[4] = ix.islemButKodu.ToString();
                            c00_ds.Tables["tblOdemeSorguHataBilgisi"].Rows.Add(myr);
                        }
                    }
                }

                if (OdemeSorguCevap.islemBilgileri != null)
                {
                    if (OdemeSorguCevap.islemBilgileri.Length > 0)
                    {
                        foreach (IslemFiyatBilgisiDVO ix in OdemeSorguCevap.islemBilgileri)
                        {
                            myr = c00_ds.Tables["tblIslemFiyatBilgisi"].NewRow();
                            myr[0] = ix.tutar.ToString();
                            myr[1] = ix.hizmetSunucuRefNo.ToString();
                            myr[2] = ix.islemSiraNo.ToString();
                            myr[3] = ix.islemButKodu.ToString();
                            c00_ds.Tables["tblIslemFiyatBilgisi"].Rows.Add(myr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrFrm erxf = new ErrFrm();
                erxf.ermessage = ex.Message;
                erxf.ShowDialog();
                erxf.Dispose();
            }            
        }
    }
}