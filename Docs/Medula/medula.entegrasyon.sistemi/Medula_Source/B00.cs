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
using meno.MyWSDL_B00;

namespace meno
{
    public partial class B00 : Form
    {
        public B00()
        {
            InitializeComponent();
        }

        private void B00_Load(object sender, EventArgs e)
        {
            DataSet dbranjlar = new DataSet();
            dbranjlar.ReadXml(GlobalClass.GetAxPath() + @"\branslar.xml");
            sevk_brans.DataSource = dbranjlar.Tables[0];

            sevk_gtt.SelectedIndex = 0;
            sevk_brans.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strerr = "";
            object lst = sevk_brans.SelectedValue;
            if (lst == null)
                strerr += "-Sevk Edilen Brans Kodu  bölümü geçerli bir deðer içermeli.\r\n";
            try
            {
                int i = Convert.ToInt32(sevk_tkn.Text);
            }
            catch
            {
                strerr += "-Saðlýk Tesis Kodu bölümü geçerli bir deðer içermeli.\r\n";
            }

            if (sevk_tno.Text.Trim() == "")
                strerr += "-Takip No bölümü geçerli bir deðer içermeli.\r\n";
            if (sevk_dr.Text.Trim() == "")
                strerr += "-Sevk Eden Dr.Tesc.No bölümü geçerli bir deðer içermeli.\r\n";

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

                SevkBildirimIslemleriService servis = new SevkBildirimIslemleriService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;

                TakipGirisDVO MyInput = new TakipGirisDVO();
                TakipCevapDVO WSOutPut = new TakipCevapDVO();


                MyInput.saglikTesisKodu = Convert.ToInt32(sevk_tkn.Text);
                MyInput.takipNo = sevk_tno.Text;
                MyInput.sevkEdenDrTescilNo = sevk_dr.Text;
                MyInput.sevkEdilenBrans = Convert.ToString(sevk_brans.SelectedIndex + 1);
                MyInput.gidecegiTesisTuru = Convert.ToString(sevk_gtt.SelectedIndex + 1);

                WSOutPut = servis.sevkBildir(MyInput);

                wS_Result1.FillText(ref WSOutPut);
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmDr ftesx = new frmDr();
            ftesx.selectx = true;
            ftesx.ShowDialog();
            if (ftesx.stesis != "")
                sevk_dr.Text = ftesx.stesis;
            ftesx.Dispose();

        }
    }
}