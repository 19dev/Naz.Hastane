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
using meno.MyWSDL_F00;

namespace meno
{
    public partial class F00_9 : Form
    {
        public bool DelReport = false;

        public F00_9()
        {
            InitializeComponent();
        }

        private void F00_9_Load(object sender, EventArgs e)
        {
            if (DelReport)
                this.Text = "Rapor Bilgisi Sil";
            else this.Text = "Rapor Bilgisi Bul";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strerr = "";

            if (GlobalClass.CheckInt(raporTesisKodu.Text) == false)
                strerr += "-Rapor Tesis Kodu b�l�m� ge�erli bir de�er i�ermeli.\r\n";
            
            if ( rap_no.Text.Trim()=="")
                strerr += "-Rapor No b�l�m� ge�erli bir de�er i�ermeli.\r\n";

            if (GlobalClass.CheckInt(txttesis_kodu.Text) == false)
                strerr += "-Kullan�c� Tesis Kodu b�l�m� ge�erli bir de�er i�ermeli.\r\n";

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
                if (DelReport)
                {
                    if (MessageBox.Show("��leme devam edilsin mi?", "Uyar�", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;
                }

                button1.Enabled = false;
                toolStripStatusLabel1.Text = GlobalClass.msg01;
                this.Refresh();

                RaporIslemleriService servis = new RaporIslemleriService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;

                RaporSorguDVO RaporSorgu = new RaporSorguDVO();

                RaporSorgu.kullaniciTesisKodu = Convert.ToInt32(txttesis_kodu.Text);
                RaporSorgu.raporBilgisi.raporTesisKodu = Convert.ToInt32(raporTesisKodu.Text);
                RaporSorgu.raporBilgisi.no = rap_no.Text;
                RaporSorgu.raporBilgisi.tarih = rap_tarih.Text;

                RaporCevapDVO RaporCevap = new RaporCevapDVO();
                if (DelReport == true)
                    RaporCevap = servis.raporBilgisiSil(RaporSorgu);
                else RaporCevap = servis.raporBilgisiBul(RaporSorgu);

                F00_A fxa = new F00_A();
                fxa.ktkod = txttesis_kodu.Text;
                fxa.RaporCevap = RaporCevap;
                fxa.ShowDialog();
                fxa.Dispose();

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