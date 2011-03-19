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
using meno.MyWSDL_C00;

namespace meno
{
    public partial class C00_3 : Form
    {
        public C00_3()
        {
            InitializeComponent();
        }

        int CheckIndex(string str)
        {
            int ix = -1;
            try
            {
                ix = Convert.ToInt32(str);
            }
            catch (Exception)
            {
                ix = -1;                
            }
            return ix;
        }

        string GetYakinlikodu(string _ykkd)
        {
            if (_ykkd == "1")
                return "Kendisi";
            else if (_ykkd == "2")
                return "Eþi";
            else if (_ykkd == "3")
                return "Çocuðu";
            else if (_ykkd == "4")
                return "Anasý";
            else if (_ykkd == "5")
                return "Babasý";
            else return "";
        }

        string GetayniFarkliKesi(string _kd)
        {
            string rtx = "";
            if (_kd == "1")
                rtx = "Ayný seans + ayný kesi";
            else if (_kd == "2")
                rtx = "Farklý seans + farklý kesi";
            else if (_kd == "3")
                rtx = "Ayný seansta + farklý kesi";
            else if (_kd == "4")
                rtx = "Ayný seansta + farklý kesi + farklý klinik kod";

            return rtx;
        }

        string GetSagSol(string _kd)
        {
            string rtx = "";
            if (_kd == "1")
                rtx = "Sað";
            else if (_kd == "2")
                rtx = "Sol";
            else if (_kd == "3")
                rtx = "Sað-Sol ayrýmý yok";

            return rtx;
        }

        string GetMalzemeturu(string _kd)
        {
            string rtx = "";
            if (_kd == "1")
                rtx = "BUT kodlu";
            else if (_kd == "2")
                rtx = "Emekli Sandýðý Protokol kodlu";
            else if (_kd == "3")
                rtx = "kodsuz malzeme";

            return rtx;
        }

        string findBranj(string brjkod)
        {
            string snc = "";
            tblBrjx.Filter = "kod=" + brjkod;
            if (tblBrjx.Count > 0)
            {
                object tes = tblBrjx.Current;
                snc = (tes as DataRowView)["aciklama"].ToString();
            }
            return snc;
        }

        void DelAllRec(ref BindingSource objx)
        {
            while (objx.Count > 0)
            {
                objx.RemoveAt(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(txtText1.Text);
            }
            catch
            {
                ErrFrm erxf = new ErrFrm();
                erxf.ermessage = "Saðlýk tesis kodu sayýsal deðer içermeli.";
                erxf.ShowDialog();
                erxf.Dispose();                
                return;                
            }

            try
            {
                button1.Enabled = false;
                toolStripStatusLabel1.Text = GlobalClass.msg01;
                this.Refresh();

                DelAllRec(ref tblDigerIslemBilgileriBindingSource);
                DelAllRec(ref tbkTahlilBilgisiBindingSource);
                DelAllRec(ref tblIlacBilgisiBindingSource);
                DelAllRec(ref tblTetkikveRadyolojiBilgisiBindingSource);
                DelAllRec(ref tblRaporBilgileriBindingSource);
                DelAllRec(ref tblMalzemeBilgileriBindingSource);
                DelAllRec(ref tblKonsultasyonBilgisiBindingSource);
                DelAllRec(ref tbkHastaYatisBilgisiBindingSource);
                DelAllRec(ref tblTaniBlgBindingSource);
                DelAllRec(ref tblDisBilgisiBindingSource);
                DelAllRec(ref tblAmeliyatveGirisimBilgisiBindingSource);

                OdemeBilgisiIslemleriService servis = new OdemeBilgisiIslemleriService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;

                OdemeSorguOkuGirisDVO OdemeSorguOkuGiris = new OdemeSorguOkuGirisDVO();
                OdemeSorguOkuGiris.saglikTesisKodu = Convert.ToInt32(txtText1.Text);
                OdemeSorguOkuGiris.takipNo = txtText2.Text;

                OdemeSorguOkuCevapDVO OdemeSorguOkuCevap = new OdemeSorguOkuCevapDVO();
                OdemeSorguOkuCevap = servis.odemeBilgisiOku(OdemeSorguOkuGiris);

                os_takip_no.Text = OdemeSorguOkuCevap.takipNo.ToString();
                os_tesis_kodu.Text = OdemeSorguOkuCevap.saglikTesisKodu.ToString();
                os_brans.Text = findBranj(OdemeSorguOkuCevap.bransKodu.ToString());
                string tmpS = "";

                tmpS = OdemeSorguOkuCevap.tedaviTuru.ToString();
                if (tmpS == "A")
                    os_tedavi_turu.Text = "Ayaktan";
                else if (tmpS == "Y")
                    os_tedavi_turu.Text = "Yatarak";

                tmpS = OdemeSorguOkuCevap.sorguTuru.ToString();
                if (tmpS == "0")
                    os_odeme_s_tr.Text = "Normal";
                else if (tmpS == "1")
                    os_odeme_s_tr.Text = "Diyaliz";
                else if (tmpS == "2")
                    os_odeme_s_tr.Text = "FTR";
                else if (tmpS == "3")
                    os_odeme_s_tr.Text = "Tüp bebek";

                tmpS = OdemeSorguOkuCevap.taburcuKodu.ToString();
                if (tmpS == "1")
                    os_taburcu_kodu.Text = "Þifa ile taburcu";
                else if (tmpS == "2")
                    os_taburcu_kodu.Text = "Haliyle taburcu";
                else if (tmpS == "3")
                    os_taburcu_kodu.Text = "Tedaviden vazgeçme";
                else if (tmpS == "4")
                    os_taburcu_kodu.Text = "Eve geri gönderilme";
                else if (tmpS == "5")
                    os_taburcu_kodu.Text = "Ayný kapsamlý baþka bir hastaneye sevk";
                else if (tmpS == "6")
                    os_taburcu_kodu.Text = "Daha kapsamlý baþka bir hastaneye sevk";
                else if (tmpS == "7")
                    os_taburcu_kodu.Text = "Orta dereceli bir baþka bakým kuruluþuna sevk";
                else if (tmpS == "8")
                    os_taburcu_kodu.Text = "Aile hekimi bakýmý altýnda eve geri gönderilme";
                else if (tmpS == "9")
                    os_taburcu_kodu.Text = "Hastane içinde baþka bir branþa sevk";
                else if (tmpS == "10")
                    os_taburcu_kodu.Text = "Vefat";
                else if (tmpS == "11")
                    os_taburcu_kodu.Text = "Diðer";

                tmpS = OdemeSorguOkuCevap.istisnaiDurum.ToString();
                if (tmpS == "0")
                    os_istisna.Text = "Normal";
                else if (tmpS == "1")
                    os_istisna.Text = "Acil baþvurular";
                else if (tmpS == "2")
                    os_istisna.Text = "Kemoterapi";
                else if (tmpS == "3")
                    os_istisna.Text = "Onkolojik vakalar (bütün dallarda)";
                else if (tmpS == "4")
                    os_istisna.Text = "Nükleer týp";
                else if (tmpS == "5")
                    os_istisna.Text = "Radyasyon onkolojisi";
                else if (tmpS == "6")
                    os_istisna.Text = "Anjiografi";
                else if (tmpS == "7")
                    os_istisna.Text = "Giriþimsel radyoloji";
                else if (tmpS == "8")
                    os_istisna.Text = "Genetik";                
                
                os_protokol_no.Text = OdemeSorguOkuCevap.protokolNo.ToString();
                os_cikis_tarihi.Text = OdemeSorguOkuCevap.hastaCikisTarihi.ToString();
                os_aciklama.Text = OdemeSorguOkuCevap.hizmetAciklama.ToString();
                os_toptut.Text = OdemeSorguOkuCevap.toplamTutar.ToString();

                hk_adi.Text = OdemeSorguOkuCevap.hastaBilgileri.ad.ToString();
                hk_soyadi.Text = OdemeSorguOkuCevap.hastaBilgileri.soyad.ToString();
                hk_cins.Text = OdemeSorguOkuCevap.hastaBilgileri.cinsiyet.ToString();
                hk_dt.Text = OdemeSorguOkuCevap.hastaBilgileri.dogumTarihi.ToString();
                hk_tc_no.Text = OdemeSorguOkuCevap.hastaBilgileri.tcKimlikNo.ToString();
                hk_sosgno.Text = OdemeSorguOkuCevap.hastaBilgileri.sosyalGuvenlikNo.ToString();
                hk_karne_no.Text = OdemeSorguOkuCevap.hastaBilgileri.karneNo.ToString();
                hk_yakinlik.Text = GetYakinlikodu(OdemeSorguOkuCevap.hastaBilgileri.yakinlikKodu.ToString());

                //muayene bilgileri
                mu_but.Text = OdemeSorguOkuCevap.muayeneBilgisi.butKodu.ToString();
                mu_do.Text = OdemeSorguOkuCevap.muayeneBilgisi.drTescilNo.ToString();
                mu_hi.Text = OdemeSorguOkuCevap.muayeneBilgisi.hizmetSunucuRefNo.ToString();
                mu_ta.Text = OdemeSorguOkuCevap.muayeneBilgisi.muayeneTarihi.ToString();

                DataRow myr;//global datarow

                //tanýlar
                if (OdemeSorguOkuCevap.tanilar !=null)
                {
                    if (OdemeSorguOkuCevap.tanilar.Length > 0)
                    {
                        foreach (TaniBilgisiDVO ix in OdemeSorguOkuCevap.tanilar)
                        {
                            myr = c00_ds.Tables["tbl_TaniBlg"].NewRow();
                            myr[0] = ix.taniKodu.ToString();

                            if (ix.taniTipi.ToString() == "1")
                                myr[1] = "1-Ön taný";
                            if (ix.taniTipi.ToString() == "2")
                                myr[1] = "2-Kesin taný";
                            if (ix.taniTipi.ToString() == "3")
                                myr[1] = "3-Ayýrýcý taný";

                            if (ix.birincilTani.ToString() == "E")
                                myr[2] = "Evet";
                            else if (ix.birincilTani.ToString() == "H")
                                myr[2] = "Hayýr";

                            myr[3] = ix.hizmetSunucuRefNo.ToString();
                            c00_ds.Tables["tbl_TaniBlg"].Rows.Add(myr);
                        }
                    }
                }

                //konsultasyonBilgileri
                if (OdemeSorguOkuCevap.konsultasyonBilgileri != null)
                {
                    if (OdemeSorguOkuCevap.konsultasyonBilgileri.Length > 0)
                    {
                        foreach (KonsultasyonBilgisiDVO ix in OdemeSorguOkuCevap.konsultasyonBilgileri)
                        {
                            myr = c00_ds.Tables["tblKonsultasyonBilgisi"].NewRow();
                            myr[0] = ix.butKodu.ToString();
                            myr[1] = findBranj(ix.bransKodu.ToString());
                            myr[2] = ix.drTescilNo.ToString();
                            myr[3] = ix.islemTarihi.ToString();
                            myr[4] = ix.hizmetSunucuRefNo.ToString();
                            c00_ds.Tables["tblKonsultasyonBilgisi"].Rows.Add(myr);
                        }
                    }
                }

                //hastaYatisBilgileri
                if (OdemeSorguOkuCevap.hastaYatisBilgileri != null)
                {
                    if (OdemeSorguOkuCevap.hastaYatisBilgileri.Length > 0)
                    {
                        foreach (HastaYatisBilgisiDVO ix in OdemeSorguOkuCevap.hastaYatisBilgileri)
                        {
                            myr = c00_ds.Tables["tbkHastaYatisBilgisi"].NewRow();
                            myr[0] = ix.butKodu.ToString();
                            myr[1] = ix.yatisBaslangicTarihi.ToString();
                            myr[2] = ix.yatisBitisTarihi.ToString();
                            myr[3] = ix.drTescilNo.ToString();
                            myr[4] = findBranj(ix.bransKodu.ToString());
                            myr[5] = ix.refakatciGunSayisi.ToString();
                            myr[6] = ix.hizmetSunucuRefNo.ToString();
                            c00_ds.Tables["tbkHastaYatisBilgisi"].Rows.Add(myr);
                        }
                    }
                }

                //diþ bilgileri
                if (OdemeSorguOkuCevap.disBilgileri != null)
                {
                    if (OdemeSorguOkuCevap.disBilgileri.Length > 0)
                    {
                        foreach (DisBilgisiDVO ix in OdemeSorguOkuCevap.disBilgileri)
                        {
                            myr = c00_ds.Tables["tblDisBilgisi"].NewRow();
                            myr[0] = ix.butKodu.ToString();
                            myr[1] = ix.adet.ToString();
                            myr[2] = ix.sagAltCene.ToString();
                            myr[3] = ix.sagUstCene.ToString();
                            myr[4] = ix.solAltCene.ToString();
                            myr[5] = ix.solUstCene.ToString();
                            myr[6] = ix.islemTarihi.ToString();

                            if (ix.acilDurum.ToString() == "E")
                                myr[7] = "Evet";
                            else if (ix.acilDurum.ToString() == "H")
                                myr[7] = "Hayýr";

                            myr[8] = ix.hizmetSunucuRefNo.ToString();

                            c00_ds.Tables["tblDisBilgisi"].Rows.Add(myr);
                        }
                    }
                }


                //Ameliyat ve giriþim bilgileri
                if (OdemeSorguOkuCevap.paketAmeliyatBilgileri != null)
                {
                    if (OdemeSorguOkuCevap.paketAmeliyatBilgileri.Length > 0)
                    {
                        foreach (AmeliyatveGirisimBilgisiDVO ix in OdemeSorguOkuCevap.paketAmeliyatBilgileri)
                        {
                            myr = c00_ds.Tables["tblAmeliyatveGirisimBilgisi"].NewRow();
                            myr[0] = ix.butKodu.ToString();
                            myr[1] = ix.adet.ToString();
                            myr[2] = ix.islemTarihi.ToString();
                            myr[3] = ix.drTescilNo.ToString();
                            myr[4] = findBranj(ix.bransKodu.ToString());
                            myr[5] = GetayniFarkliKesi(ix.ayniFarkliKesi.ToString());
                            myr[6] = GetSagSol(ix.sagSol.ToString());

                            if (ix.acilDurum.ToString() == "E")
                                myr[7] = "Evet";
                            else if (ix.acilDurum.ToString() == "H")
                                myr[7] = "Hayýr";

                            myr[8] = ix.aciklama.ToString();
                            myr[9] = ix.hizmetSunucuRefNo.ToString();

                            c00_ds.Tables["tblAmeliyatveGirisimBilgisi"].Rows.Add(myr);
                        }
                    }
                }


                //radyolojiGoruntuBilgileri
                if (OdemeSorguOkuCevap.radyolojiGoruntuBilgileri != null)
                {
                    if (OdemeSorguOkuCevap.radyolojiGoruntuBilgileri.Length > 0)
                    {
                        foreach (TetkikveRadyolojiBilgisiDVO ix in OdemeSorguOkuCevap.radyolojiGoruntuBilgileri)
                        {
                            myr = c00_ds.Tables["tblTetkikveRadyolojiBilgisi"].NewRow();
                            myr[0] = ix.butKodu.ToString();
                            myr[1] = ix.adet.ToString();
                            myr[2] = ix.islemTarihi.ToString();
                            myr[3] = ix.drTescilNo.ToString();
                            myr[4] = findBranj(ix.bransKodu.ToString());
                            myr[5] = ix.hizmetSunucuRefNo.ToString();
                            c00_ds.Tables["tblTetkikveRadyolojiBilgisi"].Rows.Add(myr);
                        }
                    }
                }

                //tahlilBilgileri
                if (OdemeSorguOkuCevap.tahlilBilgileri != null)
                {
                    if (OdemeSorguOkuCevap.tahlilBilgileri.Length > 0)
                    {
                        foreach (TahlilBilgisiDVO ix in OdemeSorguOkuCevap.tahlilBilgileri)
                        {
                            myr = c00_ds.Tables["tbkTahlilBilgisi"].NewRow();
                            myr[0] = ix.butKodu.ToString();
                            myr[1] = ix.adet.ToString();
                            myr[2] = ix.islemTarihi.ToString();
                            myr[3] = ix.drTescilNo.ToString();
                            myr[4] = findBranj(ix.bransKodu.ToString());
                            myr[5] = ix.hizmetSunucuRefNo.ToString();
                            c00_ds.Tables["tbkTahlilBilgisi"].Rows.Add(myr);
                        }
                    }
                }

                //digerÝslemBilgileri
                if (OdemeSorguOkuCevap.digerIslemBilgileri != null)
                {
                    if (OdemeSorguOkuCevap.digerIslemBilgileri.Length > 0)
                    {
                        foreach (DigerIslemBilgisiDVO ix in OdemeSorguOkuCevap.digerIslemBilgileri)
                        {
                            myr = c00_ds.Tables["tblDigerIslemBilgileri"].NewRow();
                            myr[0] = ix.butKodu.ToString();
                            myr[1] = ix.adet.ToString();
                            myr[2] = ix.islemTarihi.ToString();
                            myr[3] = ix.drTescilNo.ToString();
                            myr[4] = findBranj(ix.bransKodu.ToString());

                            if (ix.acilDurum.ToString() == "E")
                                myr[5] = "Evet";
                            else if (ix.acilDurum.ToString() == "H")
                                myr[5] = "Hayýr";
                            else myr[5] = " ";

                            myr[6] = ix.hizmetSunucuRefNo.ToString();
                            c00_ds.Tables["tblDigerIslemBilgileri"].Rows.Add(myr);
                        }
                    }
                }

                //ilacBilgileri
                if (OdemeSorguOkuCevap.ilacBilgileri != null)
                {
                    if (OdemeSorguOkuCevap.ilacBilgileri.Length > 0)
                    {
                        foreach (IlacBilgisiDVO ix in OdemeSorguOkuCevap.ilacBilgileri)
                        {
                            myr = c00_ds.Tables["tblIlacBilgisi"].NewRow();
                            myr[0] = ix.barkod.ToString();
                            myr[1] = ix.adet.ToString();
                            myr[2] = ix.islemTarihi.ToString();

                            if (ix.ilacTuru.ToString() == "1")
                                myr[3] = "Barkodlu ilaç";
                            else if (ix.ilacTuru.ToString() == "2")
                                myr[3] = "Majistral ilaç";
                            else myr[3] = " ";

                            myr[4] = ix.aciklama.ToString();
                            myr[5] = ix.tutar.ToString();
                            myr[6] = ix.hizmetSunucuRefNo.ToString();

                            c00_ds.Tables["tblIlacBilgisi"].Rows.Add(myr);
                        }
                    }
                }

                //malzemeBilgileri
                if (OdemeSorguOkuCevap.malzemeBilgileri != null)
                {
                    if (OdemeSorguOkuCevap.malzemeBilgileri.Length > 0)
                    {
                        foreach (MalzemeBilgisiDVO ix in OdemeSorguOkuCevap.malzemeBilgileri)
                        {
                            myr = c00_ds.Tables["tblMalzemeBilgileri"].NewRow();
                            myr[0] = ix.malzemeKodu.ToString();
                            myr[1] = ix.adet.ToString();
                            myr[2] = ix.islemTarihi.ToString();
                            myr[3] = GetMalzemeturu(ix.malzemeTuru.ToString());
                            myr[4] = ix.kodsuzMalzemeAdi.ToString();
                            myr[5] = ix.kodsuzMalzemeFiyati.ToString();
                            myr[6] = ix.hizmetSunucuRefNo.ToString();

                            c00_ds.Tables["tblMalzemeBilgileri"].Rows.Add(myr);
                        }
                    }
                }

                //raporBilgileri
                if (OdemeSorguOkuCevap.raporBilgileri != null)
                {
                    if (OdemeSorguOkuCevap.raporBilgileri.Length > 0)
                    {
                        foreach (RaporBilgisiDVO ix in OdemeSorguOkuCevap.raporBilgileri)
                        {
                            myr = c00_ds.Tables["tblRaporBilgileri"].NewRow();
                            myr[0] = ix.raporNo.ToString();
                            myr[1] = ix.raporVerenTesisKodu.ToString();
                            myr[2] = ix.raporVerilisTarihi.ToString();
                            myr[3] = ix.hizmetSunucuRefNo.ToString();

                            c00_ds.Tables["tblRaporBilgileri"].Rows.Add(myr);
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

        private void C00_3_Load(object sender, EventArgs e)
        {
            DataSet dbranjlar = new DataSet();
            dbranjlar.ReadXml(GlobalClass.GetAxPath() + @"\branslar.xml");
            tblBrjx.DataSource = dbranjlar.Tables[0];
        }
    }
}