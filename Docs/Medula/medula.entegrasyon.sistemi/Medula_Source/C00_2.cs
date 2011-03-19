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
                    rst = "�lk kay�t";
                    break;
                case "1":
                    rst = "hatas�z";
                    break;
                case "2":
                    rst = "hatal�";
                    break;
                case "3":
                    rst = "faturaland�";
                    break;
                case "4":
                    rst = "d�nem sonland�r�ld�";
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