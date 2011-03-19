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
    public partial class other_1 : Form
    {
        public string stesis;
        public bool selectx = false;

        public other_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strerr = "";
            object lst = comboBox1.SelectedValue;            

            try
            {
                int i = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                strerr += "-Sa�l�k Tesis Kodu b�l�m� ge�erli bir de�er i�ermeli.\r\n";
            }
            if (textBox2.Text.Length<4)
                strerr += "-Sa�l�k Tesis Ad� b�l�m� ge�erli bir de�er i�ermeli.(en az 4 karakter)\r\n";
            if (lst == null)
                strerr += "-Tesisin ili b�l�m� ge�erli bir de�er i�ermeli.(en az 4 karakter)\r\n";
            
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

                while (tblSaglikTesisiListBindingSource.Count > 0)
                {
                    tblSaglikTesisiListBindingSource.RemoveAt(0);
                }

                YardimciIslemlerService servis = new YardimciIslemlerService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;
                
                SaglikTesisiAraGirisDVO SaglikTesisiAraGiris = new SaglikTesisiAraGirisDVO();
                SaglikTesisiAraGiris.saglikTesisKodu = Convert.ToInt32(textBox1.Text);
                SaglikTesisiAraGiris.tesisAdi = textBox2.Text;
                SaglikTesisiAraGiris.tesisIlKodu = lst.ToString();
                SaglikTesisiAraGiris.tesisKodu = textBox3.Text;
                SaglikTesisiAraGiris.tesisTuru = textBox4.Text;

                SaglikTesisiAraCevapDVO SaglikTesisiAraCevap = new SaglikTesisiAraCevapDVO();
                SaglikTesisiAraCevap = servis.saglikTesisiAra(SaglikTesisiAraGiris);
                textBox6.Text = SaglikTesisiAraCevap.sonucKodu;
                textBox5.Text = SaglikTesisiAraCevap.sonucMesaji;

                DataRow myr;

                if (SaglikTesisiAraCevap.tesisler != null)
                {
                    if (SaglikTesisiAraCevap.tesisler.Length > 0)
                    {
                        foreach (SaglikTesisiListDVO ix in SaglikTesisiAraCevap.tesisler)
                        {
                            myr = other_ds.Tables["tblSaglikTesisiList"].NewRow();
                            myr[0] = ix.tesisIl.ToString();
                            myr[1] = ix.tesisAdi.ToString();
                            myr[2] = ix.tesisKodu.ToString();
                            myr[3] = ix.tesisSinifKodu.ToString();
                            myr[4] = ix.tesisTuru.ToString();
                            other_ds.Tables["tblSaglikTesisiList"].Rows.Add(myr);
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

        private void other_1_Load(object sender, EventArgs e)
        {
            DataSet dbiller = new DataSet();
            dbiller.ReadXml(GlobalClass.GetAxPath() + @"\iller.xml");
            tblIllerBindingSource.DataSource = dbiller.Tables[0];
            button3.Visible = selectx;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmtesisler ftesx = new frmtesisler();
            ftesx.selectx = true;
            ftesx.ShowDialog();
            if (ftesx.stesis != "")
                textBox4.Text = ftesx.stesis;
            ftesx.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tblSaglikTesisiListBindingSource.Count == 0) return;
            DataRowView RowText;
            RowText = (DataRowView)tblSaglikTesisiListBindingSource.Current;
            stesis = RowText[2].ToString();
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (button3.Visible)
                button3_Click(button3, new System.EventArgs());

        }
    }
}