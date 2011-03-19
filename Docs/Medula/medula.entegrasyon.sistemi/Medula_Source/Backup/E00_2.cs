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
using meno.MyWSDL_E00;

namespace meno
{
    public partial class E00_2 : Form
    {
        public FaturaCevapDVO FaturaCevap = new FaturaCevapDVO();
        
        public E00_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void E00_2_Load(object sender, EventArgs e)
        {
            textBox1.Text = FaturaCevap.sonucKodu.ToString();
            textBox2.Text = FaturaCevap.sonucMesaji.ToString();
            DataRow myr;

            try
            {
                if (FaturaCevap.hataliKayitlar != null)
                {
                    if (FaturaCevap.hataliKayitlar.Length > 0)
                    {
                        foreach (FaturaHataliKayitDVO ix in FaturaCevap.hataliKayitlar)
                        {
                            myr = c00_ds.Tables["tblFaturaHataliKayit"].NewRow();
                            myr[0] = ix.takipNo.ToString();
                            myr[1] = ix.hataKodu.ToString();
                            myr[2] = ix.hataMesaji.ToString();
                            c00_ds.Tables["tblFaturaHataliKayit"].Rows.Add(myr);
                        }
                    }
                }

                if (FaturaCevap.basariliKayitlar != null)
                {
                    if (FaturaCevap.basariliKayitlar.Length > 0)
                    {
                        foreach (FaturaBasariliKayitDVO ix in FaturaCevap.basariliKayitlar)
                        {
                            myr = c00_ds.Tables["tblFaturaBasariliKayit"].NewRow();
                            myr[0] = ix.takipNo.ToString();
                            myr[1] = ix.faturaTeslimNo.ToString();
                            myr[2] = ix.hesaplananTutar.ToString();
                            c00_ds.Tables["tblFaturaBasariliKayit"].Rows.Add(myr);
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