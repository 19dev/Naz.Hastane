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
                strerr += "-Saðlýk Tesis Kodu bölümü geçerli bir deðer içermeli.\r\n";
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
                //bilgi.tesisKodu = Text_TesisKodu.Text;//HastaTakipAraGirisDVO   de bu alan var fakat dökümanda yok!!!

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