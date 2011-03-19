/*
    Bu yaz�l�m�n tasar�m� ve kaynak kodlar� Datakent'e aittir.
    istenildi�i gibi geli�tirilebilir, tasar�m� de�i�tirilebilir.
    yaz�l�mdaki kodlar ve tasar�m referans g�sterilerek kullan�labilir.
    �cretle VEYA dengi nesne kar��l���nda SATILMAMALIDIR.
    g�nl�m bu yaz�l�m�n insanlar taraf�ndan serbest�e kullan�lmas�ndan yanad�r.
    eme�e haks�zl�k yapmak istemiyorsan�z yaz�l�mdaki DATAKENT'e ait bilgileri KALDIRMAYINIZ.
    yok ben eme�i �nemsemem, enayi gibi kodlar� yay�nlamasayd�n�z diyorsan�z �STED���N�Z� yapabilirsiniz.
 
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