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
                strerr += "-Sevk Edilen Brans Kodu  b�l�m� ge�erli bir de�er i�ermeli.\r\n";
            try
            {
                int i = Convert.ToInt32(sevk_tkn.Text);
            }
            catch
            {
                strerr += "-Sa�l�k Tesis Kodu b�l�m� ge�erli bir de�er i�ermeli.\r\n";
            }

            if (sevk_tno.Text.Trim() == "")
                strerr += "-Takip No b�l�m� ge�erli bir de�er i�ermeli.\r\n";
            if (sevk_dr.Text.Trim() == "")
                strerr += "-Sevk Eden Dr.Tesc.No b�l�m� ge�erli bir de�er i�ermeli.\r\n";

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