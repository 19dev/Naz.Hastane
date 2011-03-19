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
                strerr += "-Sa�l�k Tesis Kodu b�l�m� ge�erli bir de�er i�ermeli.\r\n";
            }
            if (to_takip_no.Text.Trim()=="")
                strerr += "-Takip No b�l�m� ge�erli bir de�er i�ermeli.\r\n";

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