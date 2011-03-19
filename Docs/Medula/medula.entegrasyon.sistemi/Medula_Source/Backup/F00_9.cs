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
                strerr += "-Rapor Tesis Kodu bölümü geçerli bir deðer içermeli.\r\n";
            
            if ( rap_no.Text.Trim()=="")
                strerr += "-Rapor No bölümü geçerli bir deðer içermeli.\r\n";

            if (GlobalClass.CheckInt(txttesis_kodu.Text) == false)
                strerr += "-Kullanýcý Tesis Kodu bölümü geçerli bir deðer içermeli.\r\n";

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
                    if (MessageBox.Show("Ýþleme devam edilsin mi?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
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