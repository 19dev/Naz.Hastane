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
    public partial class A00_4 : Form
    {
        public A00_4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strerr = "";
            try
            {
                int i = Convert.ToInt32(Text_SaglikTesisKodu.Text);
            }
            catch
            {
                strerr += "-Sa�l�k Tesis Kodu b�l�m� ge�erli bir de�er i�ermeli.\r\n";
            }

            if (strerr != "")
            {
                ErrFrm erxf = new ErrFrm();
                erxf.ermessage = strerr;
                erxf.ShowDialog();
                erxf.Dispose();
                return;
            }

            while (tblHastaTakipListBindingSource.Count > 0)
            {
                tblHastaTakipListBindingSource.RemoveAt(0);
            }

            try
            {
                button2.Enabled = false;
                toolStripStatusLabel1.Text = GlobalClass.msg01;                
                this.Refresh();
                
                ProvizyonIslemleriService servis = new ProvizyonIslemleriService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;

                HastaTakipAraGirisDVO bilgi = new HastaTakipAraGirisDVO();
                bilgi.hastaSosyalGuvenlikNo = Text_SosyalGuvenlikNo.Text;
                bilgi.hastaTCKimlikNo = Text_TCKimlikNo.Text; ;
                bilgi.karneNo = Text_KarneNo.Text;
                bilgi.saglikTesisKodu = Convert.ToInt32(Text_SaglikTesisKodu.Text.ToString());
                //bilgi.tesisKodu = Text_TesisKodu.Text;//HastaTakipAraGirisDVO   de bu alan var fakat d�k�manda yok!!!

                HastaTakipAraCevapDVO HastaTakipAraCevap_ = servis.hastaninTakipleriniBul(bilgi);
                wS_Result3.FillText(ref HastaTakipAraCevap_);

                DataRow myr;

                //if (HastaTakipAraCevap_.sonucKodu == "0000")
                if (HastaTakipAraCevap_.hastaTakipleri != null)
                {
                    if (HastaTakipAraCevap_.hastaTakipleri.Length > 0)
                    {
                        foreach (HastaTakipListDVO ix in HastaTakipAraCevap_.hastaTakipleri)
                        {
                            myr = c00_ds.Tables["tblHastaTakipList"].NewRow();
                            myr[0] = ix.takipNo.ToString();
                            myr[1] = ix.sevkEdenTesisKodu.ToString();
                            myr[2] = ix.sevkEdenTesisAdi.ToString();
                            myr[3] = ix.sevkEdilenBransKodu.ToString();
                            myr[4] = ix.sevkEdilenBransAdi.ToString();
                            myr[5] = ix.sevkEdilisTarihi.ToString();
                            c00_ds.Tables["tblHastaTakipList"].Rows.Add(myr);
                        }
                        dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
                    }
                }
                toolStripStatusLabel1.Text = GlobalClass.msg02;
                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = GlobalClass.msg03;
                ErrFrm erxf = new ErrFrm();
                erxf.ermessage = ex.Message;
                erxf.ShowDialog();
                erxf.Dispose();

                button2.Enabled = true;           
            }
        }
    }
}