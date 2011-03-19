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
                strerr += "-Saðlýk Tesis Kodu bölümü geçerli bir deðer içermeli.\r\n";
            }
            if (textBox9.Text.Trim()=="")
                strerr += "-Fatura teslim Numarasý bölümü geçerli bir deðer içermeli.\r\n";


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