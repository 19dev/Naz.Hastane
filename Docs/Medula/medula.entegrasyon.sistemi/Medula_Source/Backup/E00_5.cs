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
                strerr += "-Sa�l�k Tesis Kodu b�l�m� ge�erli bir de�er i�ermeli.\r\n";
            }
            if (tblTakipNumaralariBindingSource.Count == 0)
                strerr += "-Takip numaralar� b�l�m� ge�erli bir de�er i�ermeli.\r\n";


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
                    if (MessageBox.Show("��leme devam edilsin mi?", "Uyar�", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
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

                //veriler g�dneriliyor....            
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