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
    public partial class E00_7 : Form
    {
        public E00_7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strerr = "";
            try
            {
                int i = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                strerr += "-Sa�l�k Tesis Kodu b�l�m� ge�erli bir de�er i�ermeli.\r\n";
            }
            if (textBox9.Text.Trim()=="")
                strerr += "-Fatura teslim Numaras� b�l�m� ge�erli bir de�er i�ermeli.\r\n";


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

                while (tbl3x.Count > 0)
                {
                    tbl3x.RemoveAt(0);
                }

                FaturaBilgisiIslemleriService servis = new FaturaBilgisiIslemleriService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;

                FaturaOkuGirisDVO FaturaOkuGiris = new FaturaOkuGirisDVO();
                FaturaOkuGiris.saglikTesisKodu = Convert.ToInt32(textBox1.Text);
                FaturaOkuGiris.faturaTeslimNo = textBox9.Text;

                FaturaOkuCevapDVO FaturaOkuCevap = new FaturaOkuCevapDVO();
                FaturaOkuCevap = servis.faturaBilgisiOku(FaturaOkuGiris);

                textBox2.Text = FaturaOkuCevap.sonucKodu.ToString();
                textBox3.Text = FaturaOkuCevap.sonucMesaji.ToString();

                textBox4.Text = FaturaOkuCevap.faturaKurumKodu.ToString();
                textBox5.Text = FaturaOkuCevap.faturaSeriNo.ToString();
                textBox6.Text = FaturaOkuCevap.faturaTarihi.ToString();
                textBox7.Text = FaturaOkuCevap.faturaTutari.ToString();
                textBox8.Text = FaturaOkuCevap.takipSayisi.ToString();
                textBox10.Text = FaturaOkuCevap.faturaTeslimNo.ToString();
                if (FaturaOkuCevap.takipler != null)
                {
                    if (FaturaOkuCevap.takipler.Length > 0)
                    {
                        DataRow myr;
                        foreach (string ix in FaturaOkuCevap.takipler)
                        {
                            myr = c00_ds.Tables["tblTakipNumaralari"].NewRow();
                            myr[0] = ix;
                            c00_ds.Tables["tblTakipNumaralari"].Rows.Add(myr);
                        }
                    }
                }
                button1.Enabled = true;
                toolStripStatusLabel1.Text = GlobalClass.msg02;
            }
            catch (Exception ex)
            {
                button1.Enabled = true;
                toolStripStatusLabel1.Text = GlobalClass.msg03;
                ErrFrm erxf = new ErrFrm();
                erxf.ermessage = ex.Message;
                erxf.ShowDialog();
                erxf.Dispose();
            }
        }
    }
}