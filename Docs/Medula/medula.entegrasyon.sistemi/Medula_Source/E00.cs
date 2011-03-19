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
    public partial class E00 : Form
    {
        public E00()
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

                FaturaBilgisiIslemleriService servis = new FaturaBilgisiIslemleriService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;

                FaturaGirisDVO FaturaGiris = new FaturaGirisDVO();
                FaturaGiris.saglikTesisKodu = Convert.ToInt32(textBox1.Text);

                DataRowView RowText;
                FaturaBilgisiDVO[] FaturaBilgisi = new FaturaBilgisiDVO[tblFaturaBilgisiBindingSource.Count];
                if (tblFaturaBilgisiBindingSource.Count > 0)
                {
                    tblFaturaBilgisiBindingSource.MoveFirst();
                    for (int i = 0; i < tblFaturaBilgisiBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblFaturaBilgisiBindingSource.Current;
                        FaturaBilgisi[i] = new FaturaBilgisiDVO();
                        FaturaBilgisi[i].takipNo = RowText[0].ToString();
                        FaturaBilgisi[i].faturaNo = RowText[1].ToString();
                        FaturaBilgisi[i].faturaTarihi = RowText[2].ToString();
                        FaturaBilgisi[i].faturaKurumKodu = Convert.ToString(comboBox1.SelectedIndex + 1);

                        tblFaturaBilgisiBindingSource.MoveNext();
                    }
                    tblFaturaBilgisiBindingSource.MoveFirst();
                }
                FaturaGiris.faturaBilgileri = FaturaBilgisi;

                //veriler gödneriliyor....            
                E00_2 E00_2x = new E00_2();
                E00_2x.FaturaCevap = servis.faturaBilgisiKaydet(FaturaGiris);
                E00_2x.ShowDialog();

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

        private void E00_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}