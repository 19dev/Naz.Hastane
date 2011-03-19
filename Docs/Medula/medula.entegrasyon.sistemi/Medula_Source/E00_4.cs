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
    public partial class E00_4 : Form
    {
        public IcmalFaturaCevapDVO IcmalFaturaCevap = new IcmalFaturaCevapDVO();

        public E00_4()
        {
            InitializeComponent();
        }

        private void E00_4_Load(object sender, EventArgs e)
        {
            textBox1.Text = IcmalFaturaCevap.sonucKodu.ToString();
            textBox2.Text = IcmalFaturaCevap.sonucMesaji.ToString();
            textBox3.Text = IcmalFaturaCevap.faturaTeslimNo.ToString();
            textBox4.Text = IcmalFaturaCevap.hesaplananTutar.ToString();

            DataRow myr;

            try
            {
                if (IcmalFaturaCevap.hataliKayitlar != null)
                {
                    if (IcmalFaturaCevap.hataliKayitlar.Length > 0)
                    {
                        foreach (FaturaHataliKayitDVO ix in IcmalFaturaCevap.hataliKayitlar)
                        {
                            myr = c00_ds.Tables["tblFaturaHataliKayit"].NewRow();
                            myr[0] = ix.takipNo.ToString();
                            myr[1] = ix.hataKodu.ToString();
                            myr[2] = ix.hataMesaji.ToString();
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
    }
}