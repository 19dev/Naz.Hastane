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
using meno.MyWSDL_F00;

namespace meno
{
    public partial class F00_3 : Form
    {
        public bool RapBlgKydtTkpNoDan_mi = false;
        public bool ViewF = false;
        public DogumRaporDVO TMPRap = null;
        public string ktkod = "";

        public F00_3()
        {
            InitializeComponent();
        }

        private void F00_3_Load(object sender, EventArgs e)
        {
            dogra_RaporDVO1.Setis_RaporBilgisiKaydetTakipNoDan(RapBlgKydtTkpNoDan_mi, 7, 7);

            if (ViewF == false)
            {
                if (RapBlgKydtTkpNoDan_mi == false)
                    this.Text = "Rapor Bilgisi Kaydet ( F00 ) - Do�um Raporu";
                else this.Text = "TakipNo ile Rapor Bilgisi Kaydet ( F00 ) - Do�um Raporu";

                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
            }
            else
            {
                this.Text = "Do�um Raporu";
                button1.Tag = "1";
                button1.Text = "Formu Kapat";
                dogra_RaporDVO1.Get_RaporDVO(TMPRap.raporDVO);
                txttesis_kodu.Text = ktkod;
                dogumcls_t1.Text = TMPRap.bebekDogumTarihi;
                textBox1.Text = TMPRap.cocukSayisi.ToString();
                textBox2.Text = TMPRap.canliCocukSayisi.ToString();
                comboBox1.SelectedIndex = Convert.ToInt32(TMPRap.dogumTipi) - 1;
                comboBox2.SelectedIndex = Convert.ToInt32(TMPRap.epizyotemi) - 1;
                comboBox3.SelectedIndex = Convert.ToInt32(TMPRap.anesteziTipi) - 1;

                if (TMPRap.cocuklar != null)
                {
                    if (TMPRap.cocuklar.Length > 0)
                    {
                        DataRow myr;
                        foreach (CocukBilgisiDVO ix in TMPRap.cocuklar)
                        {                           
                            myr = f00_ds.Tables["tblCocukBilgisi"].NewRow();
                            if ( ix.cinsiyet == "K")
                                myr[0] = "K�z";
                            else myr[0] = "Erkek";
                            myr[1] = ix.kilo;
                            myr[2] = ix.dogumSaati;
                            f00_ds.Tables["tblCocukBilgisi"].Rows.Add(myr);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string)button1.Tag == "1")
            {
                this.Close();
                return;
            }

            string strerr = "";

            strerr = dogra_RaporDVO1.ChechThisForm();

            try
            {
                int i = Convert.ToInt32(txttesis_kodu.Text);
            }
            catch
            {
                strerr += "-Kullan�c� Tesis Kodu b�l�m� ge�erli bir de�er i�ermeli.\r\n";
            }

            try
            {
                int i = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                strerr += "-�ocuk Say�s� b�l�m� ge�erli bir de�er i�ermeli.\r\n";
            }

            try
            {
                int i = Convert.ToInt32(textBox2.Text);
                if (i != tblCocukBilgisiBindingSource.Count)
                    strerr += "-Canl� �ocuk Say�s� ile �ocuk bilgileri kay�t say�s� e�it olmal�.\r\n";
            }
            catch
            {
                strerr += "-Canl� �ocuk Say�s� b�l�m� ge�erli bir de�er i�ermeli.\r\n";
            }


            DataRowView RowText;            
            if (tblCocukBilgisiBindingSource.Count > 0)
            {
                tblCocukBilgisiBindingSource.MoveFirst();
                for (int i = 0; i < tblCocukBilgisiBindingSource.Count; i++)
                {
                    RowText = (DataRowView)tblCocukBilgisiBindingSource.Current;
                    if (RowText[0].ToString().Trim() == "")
                        strerr += "-�ocuk bilgileri " + i + 1.ToString() + ".sat�r Cinsiyet ge�ersiz bilgi i�eriyor.\r\n";

                    if (RowText[1].ToString().IndexOf(".") > 0)
                        strerr += "-�ocuk bilgileri " + i + 1.ToString() + ".sat�r Kilo ge�ersiz bilgi i�eriyor.�rnek:2,9\r\n";
                    else if ( GlobalClass.CheckDouble( RowText[1].ToString() ) == false)
                        strerr += "-�ocuk bilgileri " + i + 1.ToString() + ".sat�r Kilo ge�ersiz bilgi i�eriyor.�rnek:2,9\r\n";
                    
                    if ( GlobalClass.CheckTime( RowText[2].ToString()) == false)
                        strerr += "-�ocuk bilgileri " + i + 1.ToString() + ".sat�r Do�um Saati ge�ersiz bilgi i�eriyor.�rnek:12:30\r\n";

                    tblCocukBilgisiBindingSource.MoveNext();
                }
                tblCocukBilgisiBindingSource.MoveFirst();
            }

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

                RaporIslemleriService servis = new RaporIslemleriService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;

                RaporGirisDVO RaporGiris = new RaporGirisDVO();

                RaporGiris.isgoremezlikRapor = null;
                RaporGiris.dogumOncesiCalisabilirRapor = null;
                //RaporGiris.dogumRapor = null;
                RaporGiris.analikRapor = null;
                RaporGiris.protezRapor = null;
                RaporGiris.ilacRapor = null;
                RaporGiris.tedaviRapor = null;
                RaporGiris.maluliyetRapor = null;

                RaporGiris.kullaniciTesisKodu = Convert.ToInt32(txttesis_kodu.Text);
                RaporGiris.dogumRapor.raporDVO = dogra_RaporDVO1.PrepareRaporDVO();
                RaporGiris.dogumRapor.bebekDogumTarihi = dogumcls_t1.Text;
                RaporGiris.dogumRapor.cocukSayisi = Convert.ToInt32( textBox1.Text );
                RaporGiris.dogumRapor.canliCocukSayisi = Convert.ToInt32(textBox2.Text);
                RaporGiris.dogumRapor.dogumTipi = Convert.ToString(comboBox1.SelectedIndex + 1);
                RaporGiris.dogumRapor.epizyotemi = comboBox1.Text[0].ToString();
                RaporGiris.dogumRapor.anesteziTipi = Convert.ToString(comboBox3.SelectedIndex + 1);
                
                CocukBilgisiDVO[] CocukBilgisi = new CocukBilgisiDVO[tblCocukBilgisiBindingSource.Count];
                if (tblCocukBilgisiBindingSource.Count > 0)
                {
                    tblCocukBilgisiBindingSource.MoveFirst();
                    for (int i = 0; i < tblCocukBilgisiBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblCocukBilgisiBindingSource.Current;
                        CocukBilgisi[i] = new CocukBilgisiDVO();
                        CocukBilgisi[i].cinsiyet = RowText[0].ToString()[0].ToString();
                        CocukBilgisi[i].kilo = RowText[1].ToString();
                        CocukBilgisi[i].dogumSaati = RowText[2].ToString();

                        tblCocukBilgisiBindingSource.MoveNext();
                    }
                    tblCocukBilgisiBindingSource.MoveFirst();
                }
                RaporGiris.dogumRapor.cocuklar = CocukBilgisi;

                RaporCevapDVO RaporCevap = new RaporCevapDVO();
                if (RapBlgKydtTkpNoDan_mi == false)
                    RaporCevap = servis.raporBilgisiKaydet(RaporGiris);
                else RaporCevap = servis.takipNoileRaporBilgisiKaydet(RaporGiris);                

                resultForm rsform = new resultForm();
                rsform.raporTuru = RaporCevap.raporTuru;
                rsform.sonucKodu = RaporCevap.sonucKodu.ToString();
                rsform.sonucAciklamasi = RaporCevap.sonucAciklamasi;
                if (RaporCevap.dogumOncesiCalisabilirRapor == null)
                    rsform.isNULL_ = true;
                else rsform.isNULL_ = false;

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
    }
}