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
using meno.MyWSDL_OTHER;

namespace meno
{
    public partial class frmDr : Form
    {
        public string stesis;
        public bool selectx = false;

        public frmDr()
        {
            InitializeComponent();
        }

        private void frmDr_Load(object sender, EventArgs e)
        {
            button3.Visible = selectx;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strerr = "";

            try
            {
                int i = Convert.ToInt32(textBox6.Text);
            }
            catch
            {
                strerr += "-Sa�l�k Tesis Kodu b�l�m� ge�erli bir de�er i�ermeli.\r\n";
            }
            //if (textBox2.Text.Length < 4)
            //    strerr += "-Sa�l�k Tesis Ad� b�l�m� ge�erli bir de�er i�ermeli.(en az 4 karakter)\r\n";
            //if (lst == null)
            //    strerr += "-Tesisin ili b�l�m� ge�erli bir de�er i�ermeli.(en az 4 karakter)\r\n";

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

                while (tblDoktorListBindingSource.Count > 0)
                {
                    tblDoktorListBindingSource.RemoveAt(0);
                }

                YardimciIslemlerService servis = new YardimciIslemlerService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;

                DoktorAraGirisDVO DoktorAraGiris = new DoktorAraGirisDVO();
                DoktorAraGiris.drAdi = textBox1.Text;
                DoktorAraGiris.drSoyadi = textBox2.Text;
                DoktorAraGiris.drBransKodu = textBox3.Text;
                DoktorAraGiris.drDiplomaNo = textBox4.Text;
                DoktorAraGiris.drTescilNo = textBox5.Text;
                DoktorAraGiris.saglikTesisiKodu = Convert.ToInt32( textBox6.Text );

                DoktorAraCevapDVO DoktorAraCevap = new DoktorAraCevapDVO();
                DoktorAraCevap = servis.doktorAra(DoktorAraGiris);

                textBox8.Text = DoktorAraCevap.sonucKodu;
                textBox7.Text = DoktorAraCevap.sonucMesaji;

                DataRow myr;

                if (DoktorAraCevap.doktorlar != null)
                {
                    if (DoktorAraCevap.doktorlar.Length > 0)
                    {
                        foreach (DoktorListDVO ix in DoktorAraCevap.doktorlar)
                        {
                            myr = other_ds.Tables["tblDoktorList"].NewRow();
                            myr[0] = ix.drAdi.ToString();
                            myr[1] = ix.drSoyadi.ToString();
                            myr[2] = ix.drDiplomaNo.ToString();
                            myr[3] = ix.drTescilNo.ToString();
                            other_ds.Tables["tblDoktorList"].Rows.Add(myr);
                        }
                    }
                }
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (tblDoktorListBindingSource.Count == 0) return;
            DataRowView RowText;
            RowText = (DataRowView)tblDoktorListBindingSource.Current;
            stesis = RowText[3].ToString().Trim();
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (button3.Visible)
                button3_Click(button3, new System.EventArgs());
        }
    }
}