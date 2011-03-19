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
    public partial class E00_5 : Form
    {
        public E00_5()
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
            if (tblTakipNumaralariBindingSource.Count == 0)
                strerr += "-Takip numaralarý bölümü geçerli bir deðer içermeli.\r\n";


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
                    if (MessageBox.Show("Ýþleme devam edilsin mi?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;

                button1.Enabled = false;
                toolStripStatusLabel1.Text = GlobalClass.msg01;
                this.Refresh();

                FaturaBilgisiIslemleriService servis = new FaturaBilgisiIslemleriService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;

                FaturaIptalGirisDVO FaturaIptalGiris = new FaturaIptalGirisDVO();
                FaturaIptalGiris.saglikTesisKodu = Convert.ToInt32(textBox1.Text);

                string[] stra = new string[tblTakipNumaralariBindingSource.Count];
                DataRowView RowText;
                if (tblTakipNumaralariBindingSource.Count > 0)
                {
                    tblTakipNumaralariBindingSource.MoveFirst();
                    for (int i = 0; i < tblTakipNumaralariBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblTakipNumaralariBindingSource.Current;
                        stra[i] = RowText[0].ToString();
                        tblTakipNumaralariBindingSource.MoveNext();
                    }
                    tblTakipNumaralariBindingSource.MoveFirst();
                }
                FaturaIptalGiris.faturaTeslimNo = stra;

                //veriler gödneriliyor....            
                E00_6 E00_6x = new E00_6();
                E00_6x.FaturaIptalCevap = servis.faturaBilgisiSil(FaturaIptalGiris);
                E00_6x.ShowDialog();

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