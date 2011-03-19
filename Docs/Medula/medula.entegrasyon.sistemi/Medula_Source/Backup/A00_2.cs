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
    public partial class A00_2 : Form
    {
        public A00_2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strerr = "";
            object lst = tno_brans.SelectedValue;
            if (lst == null)
                strerr += "-Sevk Edilen Brans Kodu  bölümü geçerli bir deðer içermeli.\r\n";
            try
            {
                int i = Convert.ToInt32(tno_saglik_tesiskodu.Text);
            }
            catch
            {
                strerr += "-Saðlýk Tesis Kodu bölümü geçerli bir deðer içermeli.\r\n";
            }
            if (tno_sevk_eden_tesis_kd.Text.Trim() == "")
                strerr += "-Sevk Eden Tesis Kodu bölümü geçerli bir deðer içermeli.\r\n";
            if (tno_dok_tesc.Text.Trim() == "")
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
                button4.Enabled = false;
                toolStripStatusLabel1.Text = GlobalClass.msg01;
                this.Refresh();

                ProvizyonIslemleriService servis = new ProvizyonIslemleriService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;

                SistemDisiSevkGirisDVO MyInput = new SistemDisiSevkGirisDVO();
                SistemDisiSevkCevapDVO WSOutPut = new SistemDisiSevkCevapDVO();

                MyInput.saglikTesisKodu = Convert.ToInt32(tno_saglik_tesiskodu.Text);
                MyInput.sevkKabulTarihi = tno_sevk_kab_tar.Text;
                MyInput.hastaTCKimlikNo = tno_tc_no.Text;
                MyInput.hastaSosyalGuvNo = tno_hasta_sos_guv_no.Text;
                MyInput.hastaKarneNo = tno_hasta_kar_no.Text;
                MyInput.sigortaliTuru = Convert.ToString(tno_sig_tur.SelectedIndex + 1);
                MyInput.yakinlikKodu = tno_yakinlik_kodu.Text;
                MyInput.devredilenKurum = Convert.ToString(tno_devredilen_kurum.SelectedIndex + 1);
                MyInput.sevkEdenTesisKodu = tno_sevk_eden_tesis_kd.Text;
                MyInput.sevkEdilenBransKodu = tno_brans.ValueMember;
                MyInput.sevkEdenDrTescilNo = tno_dok_tesc.Text;
                MyInput.muayeneAcilisTarihi = tno_ac_tar.Text;
                MyInput.provizyonTipi = tno_pro_tur.Text[0].ToString();
                MyInput.sevkTuru = Convert.ToString(tno_sevk_tur.SelectedIndex + 3);

                WSOutPut = servis.takipNumarasiOlmayanSevkiKabul(MyInput);

                wS_Result2.FillText(ref WSOutPut);
                button4.Enabled = true;
                toolStripStatusLabel1.Text = GlobalClass.msg02;
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = GlobalClass.msg03;
                ErrFrm erxf = new ErrFrm();
                erxf.ermessage = ex.Message;
                erxf.ShowDialog();
                erxf.Dispose();

                button4.Enabled = true;
            }
        }

        private void A00_2_Load(object sender, EventArgs e)
        {
            DataSet dbranjlar = new DataSet();
            dbranjlar.ReadXml(GlobalClass.GetAxPath() + @"\branslar.xml");
            tno_brans.DataSource = dbranjlar.Tables[0];
            tno_brans.SelectedIndex = 0;
            tno_sig_tur.SelectedIndex = 0;
            tno_devredilen_kurum.SelectedIndex = 0;
            tno_pro_tur.SelectedIndex = 0;
            tno_sevk_tur.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDr ftesx = new frmDr();
            ftesx.selectx = true;
            ftesx.ShowDialog();
            if (ftesx.stesis != "")
                tno_dok_tesc.Text = ftesx.stesis;
            ftesx.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            other_1 ftesx = new other_1();
            ftesx.selectx = true;
            ftesx.ShowDialog();
            if (ftesx.stesis != "")
                tno_sevk_eden_tesis_kd.Text = ftesx.stesis;
            ftesx.Dispose();
        }
    }
}