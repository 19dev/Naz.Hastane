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
using meno.MyWSDL_A00;

namespace meno
{
    public partial class A00_3 : Form
    {
        public A00_3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strerr = "";
            try
            {
                int i = Convert.ToInt32(to_tesiskodu.Text);
            }
            catch
            {
                strerr += "-Saðlýk Tesis Kodu bölümü geçerli bir deðer içermeli.\r\n";
            }
            if (to_takip_no.Text.Trim()=="")
                strerr += "-Takip No bölümü geçerli bir deðer içermeli.\r\n";

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
                button5.Enabled = false;
                toolStripStatusLabel1.Text = GlobalClass.msg01;
                this.Refresh();

                ProvizyonIslemleriService servis = new ProvizyonIslemleriService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;

                TakipOkuGirisDVO MyInput = new TakipOkuGirisDVO();
                TakipDVO WSOutPut = new TakipDVO();

                MyInput.saglikTesisKodu = Convert.ToInt32(to_tesiskodu.Text);
                MyInput.takipNo = to_takip_no.Text;

                WSOutPut = servis.takipOku(MyInput);

                wS_Result21.FillText(ref WSOutPut);
                toolStripStatusLabel1.Text = GlobalClass.msg02;
                button5.Enabled = true;
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = GlobalClass.msg03;
                ErrFrm erxf = new ErrFrm();
                erxf.ermessage = ex.Message;
                erxf.ShowDialog();
                erxf.Dispose();

                button5.Enabled = true;
            }
        }
    }
}