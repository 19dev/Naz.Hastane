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
    public partial class E00_6 : Form
    {
        public FaturaIptalCevapDVO FaturaIptalCevap = new FaturaIptalCevapDVO();

        public E00_6()
        {
            InitializeComponent();
        }

        private void E00_6_Load(object sender, EventArgs e)
        {
            textBox1.Text = FaturaIptalCevap.sonucKodu.ToString();
            textBox2.Text = FaturaIptalCevap.sonucMesaji.ToString();

            DataRow myr;

            try
            {
                if (FaturaIptalCevap.hataliKayitlar != null)
                {
                    if (FaturaIptalCevap.hataliKayitlar.Length > 0)
                    {
                        foreach (FaturaIptalHataliKayitDVO ix in FaturaIptalCevap.hataliKayitlar)
                        {
                            myr = c00_ds.Tables["tblFaturaHataliKayit"].NewRow();
                            myr[0] = ix.hataKodu.ToString();
                            myr[1] = ix.hataMesaji.ToString();
                            myr[2] = ix.faturaTeslimNo.ToString();
                            c00_ds.Tables["tblFaturaHataliKayit"].Rows.Add(myr);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}