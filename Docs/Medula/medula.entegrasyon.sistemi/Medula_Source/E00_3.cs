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
    public partial class E00_3 : Form
    {
        public E00_3()
        {
            InitializeComponent();
        }

        private void E00_3_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
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

            if (textBox2.Text.Trim()=="")
                strerr += "-Fatura No bölümü geçerli bir deðer içermeli.\r\n";

            if (tblTakipNumaralariBindingSource.Count==0)
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
                button1.Enabled = false;
                toolStripStatusLabel1.Text = GlobalClass.msg01;
                this.Refresh();

                FaturaBilgisiIslemleriService servis = new FaturaBilgisiIslemleriService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;


                IcmalFaturaGirisDVO IcmalFaturaGiris = new IcmalFaturaGirisDVO();
                IcmalFaturaGiris.saglikTesisKodu = Convert.ToInt32(textBox1.Text);
                IcmalFaturaGiris.faturaKurumKodu = Convert.ToString(comboBox1.SelectedIndex + 1);
                IcmalFaturaGiris.faturaNo = textBox2.Text;
                IcmalFaturaGiris.faturaTarihi = FatTarihi.Text;
                
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
                IcmalFaturaGiris.takipNumaralari = stra;

                //veriler gödneriliyor....            
                E00_4 E00_4x = new E00_4();
                E00_4x.IcmalFaturaCevap = servis.icmalFaturaBilgisiKaydet(IcmalFaturaGiris);
                E00_4x.ShowDialog();

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