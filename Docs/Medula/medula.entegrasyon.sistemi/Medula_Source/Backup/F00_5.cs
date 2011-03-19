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
    public partial class F00_5 : Form
    {
        public bool RapBlgKydtTkpNoDan_mi = false;
        public bool ViewF = false;
        public ProtezRaporDVO TMPRap = null;
        public string ktkod = "";

        public F00_5()
        {
            InitializeComponent();
        }

        private void F00_5_Load(object sender, EventArgs e)
        {
            protez_RaporDVO1.Setis_RaporBilgisiKaydetTakipNoDan(RapBlgKydtTkpNoDan_mi, 8, 8);

            if (ViewF == false)
            {
                if (RapBlgKydtTkpNoDan_mi == false)
                    this.Text = "Rapor Bilgisi Kaydet ( F00 ) - Protez Raporu";
                else this.Text = "TakipNo ile Rapor Bilgisi Kaydet ( F00 ) - Protez Raporu";
            }
            else
            {
                this.Text = "Protez Raporu";
                button1.Tag = "1";
                button1.Text = "Formu Kapat";
                protez_RaporDVO1.Get_RaporDVO(TMPRap.raporDVO);
                txttesis_kodu.Text = ktkod;
                if (TMPRap.malzemeler != null)
                {
                    if (TMPRap.malzemeler.Length > 0)
                    {
                        DataRow myr;
                        foreach (MalzemeBilgisiDVO ix in TMPRap.malzemeler)
                        {
                            myr = f00_ds.Tables["tblMalzemeBilgisi"].NewRow();
                            myr[0] = ix.malzemeKodu;
                            myr[1] = ix.malzemeAdi;
                            if (ix.malzemeTuru == "1")
                                myr[2] = "1 : BUT kodlu";
                            else if (ix.malzemeTuru == "2")
                                myr[2] = "2 : Emekli Sand��� Protokol kodlu";
                            else if (ix.malzemeTuru == "3")
                                myr[2] = "3 : kodsuz malzeme";

                            myr[3] = ix.adet.ToString();                            

                            f00_ds.Tables["tblMalzemeBilgisi"].Rows.Add(myr);
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

            strerr = protez_RaporDVO1.ChechThisForm();

            if ( GlobalClass.CheckInt(txttesis_kodu.Text)==false)
                strerr += "-Kullan�c� Tesis Kodu b�l�m� ge�erli bir de�er i�ermeli.\r\n";

            DataRowView RowText;
            if (tblMalzemeBilgisiBindingSource.Count == 0)
                strerr += "-Malzeme bilgileri de�er i�ermeli.\r\n";

            if (tblMalzemeBilgisiBindingSource.Count > 0)
            {
                tblMalzemeBilgisiBindingSource.MoveFirst();
                for (int i = 0; i < tblMalzemeBilgisiBindingSource.Count; i++)
                {
                    RowText = (DataRowView)tblMalzemeBilgisiBindingSource.Current;
                    if (RowText[2].ToString().Trim() == "")
                        strerr += "-Protez Malzeme T�r� " + i + 1.ToString() + ".sat�r bir de�er i�ermeli.\r\n";

                    if (GlobalClass.CheckInt(RowText[3].ToString()) == false)
                        strerr += "-Protez Malzeme say�s� " + i + 1.ToString() + ".sat�r ge�ersiz bilgi i�eriyor.\r\n";

                    tblMalzemeBilgisiBindingSource.MoveNext();
                }
                tblMalzemeBilgisiBindingSource.MoveFirst();
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
                RaporGiris.dogumRapor = null;
                RaporGiris.analikRapor = null;
                //RaporGiris.protezRapor = null;
                RaporGiris.ilacRapor = null;
                RaporGiris.tedaviRapor = null;
                RaporGiris.maluliyetRapor = null;

                RaporGiris.kullaniciTesisKodu = Convert.ToInt32(txttesis_kodu.Text);
                RaporGiris.protezRapor.raporDVO = protez_RaporDVO1.PrepareRaporDVO();

                MalzemeBilgisiDVO[] MalzemeBilgisi = new MalzemeBilgisiDVO[tblMalzemeBilgisiBindingSource.Count];
                if (tblMalzemeBilgisiBindingSource.Count > 0)
                {
                    tblMalzemeBilgisiBindingSource.MoveFirst();
                    for (int i = 0; i < tblMalzemeBilgisiBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblMalzemeBilgisiBindingSource.Current;
                        MalzemeBilgisi[i] = new MalzemeBilgisiDVO();
                        MalzemeBilgisi[i].malzemeKodu = RowText[0].ToString();
                        MalzemeBilgisi[i].malzemeAdi = RowText[1].ToString();
                        MalzemeBilgisi[i].malzemeTuru = RowText[2].ToString()[0].ToString();
                        MalzemeBilgisi[i].adet = Convert.ToInt32( RowText[3].ToString() );

                        tblMalzemeBilgisiBindingSource.MoveNext();
                    }
                    tblMalzemeBilgisiBindingSource.MoveFirst();
                }
                RaporGiris.protezRapor.malzemeler = MalzemeBilgisi;

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