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
    public partial class C00 : Form
    {
        public C00()
        {
            InitializeComponent();
        }

        private void C00_Load(object sender, EventArgs e)
        {
            DataSet dbranjlar = new DataSet();
            dbranjlar.ReadXml(GlobalClass.GetAxPath() + @"\branslar.xml");
            tblBrjx.DataSource = dbranjlar.Tables[0];            

            os_brans.SelectedIndex = 0;
            os_tedavi_turu.SelectedIndex = 0;
            os_odeme_s_tr.SelectedIndex = 0;
            os_taburcu_kodu.SelectedIndex = 0;
            os_istisna.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;
                toolStripStatusLabel1.Text = GlobalClass.msg01;
                this.Refresh();

                OdemeBilgisiIslemleriService servis = new OdemeBilgisiIslemleriService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;

                OdemeSorguGirisDVO MyInput = new OdemeSorguGirisDVO();
                MyInput.takipNo = os_takip_no.Text;
                MyInput.saglikTesisKodu = Convert.ToInt32(os_tesis_kodu.Text);
                MyInput.bransKodu = os_brans.SelectedValue.ToString();
                MyInput.tedaviTuru = os_tedavi_turu.Text[0].ToString();
                MyInput.sorguTuru = os_odeme_s_tr.SelectedIndex.ToString();
                MyInput.protokolNo = os_protokol_no.Text;
                MyInput.hastaCikisTarihi = os_cikis_tarihi.Text;
                MyInput.taburcuKodu = Convert.ToString(os_taburcu_kodu.SelectedIndex + 1);
                MyInput.aciklama = os_aciklama.Text;
                MyInput.istisnaiDurum = os_istisna.SelectedIndex.ToString();
                DataRowView RowText;


                TaniBilgisiDVO[] TaniBilgisi = new TaniBilgisiDVO[tblTaniBlgBindingSource.Count];
                if (tblTaniBlgBindingSource.Count > 0)
                {
                    tblTaniBlgBindingSource.MoveFirst();
                    for (int i = 0; i < tblTaniBlgBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblTaniBlgBindingSource.Current;
                        TaniBilgisi[i] = new TaniBilgisiDVO();
                        TaniBilgisi[i].taniKodu = RowText[0].ToString();
                        TaniBilgisi[i].taniTipi = RowText[1].ToString()[0].ToString();
                        TaniBilgisi[i].birincilTani = RowText[2].ToString()[0].ToString();
                        TaniBilgisi[i].hizmetSunucuRefNo = RowText[3].ToString();

                        tblTaniBlgBindingSource.MoveNext();
                    }
                    tblTaniBlgBindingSource.MoveFirst();
                }
                MyInput.tanilar = TaniBilgisi;


                MuayeneBilgisiDVO MuayeneBilgisi = new MuayeneBilgisiDVO();
                MuayeneBilgisi.butKodu = mu_but.Text;
                MuayeneBilgisi.drTescilNo = mu_do.Text;
                MuayeneBilgisi.muayeneTarihi = mu_ta.Text;
                MuayeneBilgisi.hizmetSunucuRefNo = mu_hi.Text;
                MyInput.muayeneBilgisi = MuayeneBilgisi;


                //(!!!fix) tarih alaný için check sistemi buraya eklenecek. grid'e tarih gömülemedi... 
                KonsultasyonBilgisiDVO[] KonsultasyonBilgisi = new KonsultasyonBilgisiDVO[tblKonsultasyonBilgisiBindingSource.Count];
                if (tblKonsultasyonBilgisiBindingSource.Count > 0)
                {
                    tblKonsultasyonBilgisiBindingSource.MoveFirst();
                    for (int i = 0; i < tblKonsultasyonBilgisiBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblKonsultasyonBilgisiBindingSource.Current;
                        KonsultasyonBilgisi[i] = new KonsultasyonBilgisiDVO();
                        KonsultasyonBilgisi[i].butKodu = RowText[0].ToString();
                        KonsultasyonBilgisi[i].bransKodu = RowText[1].ToString();
                        KonsultasyonBilgisi[i].drTescilNo = RowText[2].ToString();
                        KonsultasyonBilgisi[i].islemTarihi = RowText[3].ToString();
                        KonsultasyonBilgisi[i].hizmetSunucuRefNo = RowText[4].ToString();

                        tblKonsultasyonBilgisiBindingSource.MoveNext();
                    }
                    tblKonsultasyonBilgisiBindingSource.MoveFirst();
                }
                MyInput.konsultasyonBilgileri = KonsultasyonBilgisi;


                //(!!!fix) tarih alaný için check sistemi buraya eklenecek. grid'e tarih gömülemedi... 
                HastaYatisBilgisiDVO[] HastaYatisBilgisi = new HastaYatisBilgisiDVO[tbkHastaYatisBilgisiBindingSource.Count];
                if (tbkHastaYatisBilgisiBindingSource.Count > 0)
                {
                    tbkHastaYatisBilgisiBindingSource.MoveFirst();
                    for (int i = 0; i < tbkHastaYatisBilgisiBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tbkHastaYatisBilgisiBindingSource.Current;
                        HastaYatisBilgisi[i] = new HastaYatisBilgisiDVO();
                        HastaYatisBilgisi[i].butKodu = RowText[0].ToString();
                        HastaYatisBilgisi[i].yatisBaslangicTarihi = RowText[1].ToString();
                        HastaYatisBilgisi[i].yatisBitisTarihi = RowText[2].ToString();
                        HastaYatisBilgisi[i].drTescilNo = RowText[3].ToString();
                        HastaYatisBilgisi[i].bransKodu = RowText[4].ToString();
                        HastaYatisBilgisi[i].refakatciGunSayisi = RowText[5].ToString();
                        HastaYatisBilgisi[i].hizmetSunucuRefNo = RowText[6].ToString();

                        tbkHastaYatisBilgisiBindingSource.MoveNext();
                    }
                    tbkHastaYatisBilgisiBindingSource.MoveFirst();
                }
                MyInput.hastaYatisBilgileri = HastaYatisBilgisi;


                //(!!!fix) tarih alaný için check sistemi buraya eklenecek. grid'e tarih gömülemedi... 
                DisBilgisiDVO[] DisBilgisi = new DisBilgisiDVO[tblDisBilgisiBindingSource.Count];
                if (tblDisBilgisiBindingSource.Count > 0)
                {
                    tblDisBilgisiBindingSource.MoveFirst();

                    for (int i = 0; i < tblDisBilgisiBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblDisBilgisiBindingSource.Current;
                        DisBilgisi[i] = new DisBilgisiDVO();
                        DisBilgisi[i].butKodu = RowText[0].ToString();
                        DisBilgisi[i].adet = Convert.ToInt32(RowText[1].ToString());
                        DisBilgisi[i].sagAltCene = RowText[2].ToString();
                        DisBilgisi[i].sagUstCene = RowText[3].ToString();
                        DisBilgisi[i].solAltCene = RowText[4].ToString();
                        DisBilgisi[i].solUstCene = RowText[5].ToString();
                        DisBilgisi[i].islemTarihi = RowText[6].ToString();
                        DisBilgisi[i].acilDurum = RowText[7].ToString()[0].ToString();
                        DisBilgisi[i].hizmetSunucuRefNo = RowText[8].ToString();

                        tblDisBilgisiBindingSource.MoveNext();
                    }

                    tblDisBilgisiBindingSource.MoveFirst();
                }
                MyInput.disBilgileri = DisBilgisi;


                //(!!!fix) tarih alaný için check sistemi buraya eklenecek. grid'e tarih gömülemedi... 
                AmeliyatveGirisimBilgisiDVO[] AmeliyatveGirisimBilgisi = new AmeliyatveGirisimBilgisiDVO[tblAmeliyatveGirisimBilgisiBindingSource.Count];
                if (tblAmeliyatveGirisimBilgisiBindingSource.Count > 0)
                {
                    tblAmeliyatveGirisimBilgisiBindingSource.MoveFirst();
                    for (int i = 0; i < tblAmeliyatveGirisimBilgisiBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblAmeliyatveGirisimBilgisiBindingSource.Current;
                        AmeliyatveGirisimBilgisi[i] = new AmeliyatveGirisimBilgisiDVO();
                        AmeliyatveGirisimBilgisi[i].butKodu = RowText[0].ToString();
                        AmeliyatveGirisimBilgisi[i].adet = Convert.ToInt32(RowText[1].ToString());
                        AmeliyatveGirisimBilgisi[i].islemTarihi = RowText[2].ToString();
                        AmeliyatveGirisimBilgisi[i].drTescilNo = RowText[3].ToString();
                        AmeliyatveGirisimBilgisi[i].bransKodu = RowText[4].ToString();
                        AmeliyatveGirisimBilgisi[i].ayniFarkliKesi = RowText[5].ToString()[0].ToString();
                        AmeliyatveGirisimBilgisi[i].sagSol = RowText[6].ToString()[0].ToString();
                        AmeliyatveGirisimBilgisi[i].acilDurum = RowText[7].ToString()[0].ToString();
                        AmeliyatveGirisimBilgisi[i].aciklama = RowText[8].ToString();
                        AmeliyatveGirisimBilgisi[i].hizmetSunucuRefNo = RowText[9].ToString();

                        tblAmeliyatveGirisimBilgisiBindingSource.MoveNext();
                    }

                    tblAmeliyatveGirisimBilgisiBindingSource.MoveFirst();
                }
                MyInput.ameliyatveGirisimBilgileri = AmeliyatveGirisimBilgisi;


                //(!!!fix) tarih alaný için check sistemi buraya eklenecek. grid'e tarih gömülemedi... 
                TetkikveRadyolojiBilgisiDVO[] TetkikveRadyolojiBilgisi = new TetkikveRadyolojiBilgisiDVO[tblTetkikveRadyolojiBilgisiBindingSource.Count];
                if (tblTetkikveRadyolojiBilgisiBindingSource.Count > 0)
                {
                    tblTetkikveRadyolojiBilgisiBindingSource.MoveFirst();
                    for (int i = 0; i < tblTetkikveRadyolojiBilgisiBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblTetkikveRadyolojiBilgisiBindingSource.Current;
                        TetkikveRadyolojiBilgisi[i] = new TetkikveRadyolojiBilgisiDVO();
                        TetkikveRadyolojiBilgisi[i].butKodu = RowText[0].ToString();
                        TetkikveRadyolojiBilgisi[i].adet = Convert.ToInt32(RowText[1].ToString());
                        TetkikveRadyolojiBilgisi[i].islemTarihi = RowText[2].ToString();
                        TetkikveRadyolojiBilgisi[i].drTescilNo = RowText[3].ToString();
                        TetkikveRadyolojiBilgisi[i].bransKodu = RowText[4].ToString();
                        TetkikveRadyolojiBilgisi[i].hizmetSunucuRefNo = RowText[5].ToString();

                        tblTetkikveRadyolojiBilgisiBindingSource.MoveNext();
                    }

                    tblTetkikveRadyolojiBilgisiBindingSource.MoveFirst();
                }
                MyInput.tetkikveRadyolojiBilgileri = TetkikveRadyolojiBilgisi;


                //(!!!fix) tarih alaný için check sistemi buraya eklenecek. grid'e tarih gömülemedi... 
                TahlilBilgisiDVO[] TahlilBilgisi = new TahlilBilgisiDVO[tbkTahlilBilgisiBindingSource.Count];
                if (tbkTahlilBilgisiBindingSource.Count > 0)
                {
                    tbkTahlilBilgisiBindingSource.MoveFirst();
                    for (int i = 0; i < tbkTahlilBilgisiBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tbkTahlilBilgisiBindingSource.Current;
                        TahlilBilgisi[i] = new TahlilBilgisiDVO();
                        TahlilBilgisi[i].butKodu = RowText[0].ToString();
                        TahlilBilgisi[i].adet = Convert.ToInt32(RowText[1].ToString());
                        TahlilBilgisi[i].islemTarihi = RowText[2].ToString();
                        TahlilBilgisi[i].drTescilNo = RowText[3].ToString();
                        TahlilBilgisi[i].bransKodu = RowText[4].ToString();
                        TahlilBilgisi[i].hizmetSunucuRefNo = RowText[5].ToString();

                        tbkTahlilBilgisiBindingSource.MoveNext();
                    }

                    tbkTahlilBilgisiBindingSource.MoveFirst();
                }
                MyInput.tahlilBilgileri = TahlilBilgisi;


                //(!!!fix) tarih alaný için check sistemi buraya eklenecek. grid'e tarih gömülemedi... 
                DigerIslemBilgisiDVO[] DigerIslemBilgisi = new DigerIslemBilgisiDVO[tblDigerIslemBilgileriBindingSource.Count];
                if (tblDigerIslemBilgileriBindingSource.Count > 0)
                {
                    tblDigerIslemBilgileriBindingSource.MoveFirst();
                    for (int i = 0; i < tblDigerIslemBilgileriBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblDigerIslemBilgileriBindingSource.Current;
                        DigerIslemBilgisi[i] = new DigerIslemBilgisiDVO();
                        DigerIslemBilgisi[i].butKodu = RowText[0].ToString();
                        DigerIslemBilgisi[i].adet = Convert.ToInt32(RowText[1].ToString());
                        DigerIslemBilgisi[i].islemTarihi = RowText[2].ToString();
                        DigerIslemBilgisi[i].drTescilNo = RowText[3].ToString();
                        DigerIslemBilgisi[i].bransKodu = RowText[4].ToString();

                        if (RowText[5].ToString() != "")
                            DigerIslemBilgisi[i].bransKodu = RowText[5].ToString()[0].ToString();
                        else
                        {
                            DigerIslemBilgisi[i].bransKodu = "";
                        }

                        DigerIslemBilgisi[i].hizmetSunucuRefNo = RowText[6].ToString();

                        tblDigerIslemBilgileriBindingSource.MoveNext();
                    }

                    tblDigerIslemBilgileriBindingSource.MoveFirst();
                }
                MyInput.digerIslemBilgileri = DigerIslemBilgisi;


                IlacBilgisiDVO[] IlacBilgisi = new IlacBilgisiDVO[tblIlacBilgisiBindingSource.Count];
                if (tblIlacBilgisiBindingSource.Count > 0)
                {
                    tblIlacBilgisiBindingSource.MoveFirst();
                    for (int i = 0; i < tblIlacBilgisiBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblIlacBilgisiBindingSource.Current;
                        IlacBilgisi[i] = new IlacBilgisiDVO();
                        IlacBilgisi[i].barkod = RowText[0].ToString();
                        IlacBilgisi[i].adet = Convert.ToDouble(RowText[1].ToString());
                        IlacBilgisi[i].islemTarihi = RowText[2].ToString();
                        IlacBilgisi[i].ilacTuru = RowText[3].ToString()[0].ToString();
                        IlacBilgisi[i].aciklama = RowText[4].ToString();
                        IlacBilgisi[i].tutar = Convert.ToDouble(RowText[5].ToString());
                        IlacBilgisi[i].hizmetSunucuRefNo = RowText[6].ToString();

                        tblIlacBilgisiBindingSource.MoveNext();
                    }

                    tblIlacBilgisiBindingSource.MoveFirst();
                }
                MyInput.ilacBilgileri = IlacBilgisi;


                MalzemeBilgisiDVO[] MalzemeBilgisi = new MalzemeBilgisiDVO[tblMalzemeBilgileriBindingSource.Count];
                if (tblMalzemeBilgileriBindingSource.Count > 0)
                {
                    tblMalzemeBilgileriBindingSource.MoveFirst();
                    for (int i = 0; i < tblMalzemeBilgileriBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblMalzemeBilgileriBindingSource.Current;
                        MalzemeBilgisi[i] = new MalzemeBilgisiDVO();
                        MalzemeBilgisi[i].malzemeKodu = RowText[0].ToString();
                        MalzemeBilgisi[i].adet = Convert.ToInt32(RowText[1].ToString());
                        MalzemeBilgisi[i].islemTarihi = RowText[2].ToString();
                        MalzemeBilgisi[i].malzemeTuru = RowText[3].ToString()[0].ToString();
                        MalzemeBilgisi[i].kodsuzMalzemeAdi = RowText[4].ToString();
                        MalzemeBilgisi[i].kodsuzMalzemeFiyati = Convert.ToDouble(RowText[5].ToString());
                        MalzemeBilgisi[i].hizmetSunucuRefNo = RowText[6].ToString();

                        tblMalzemeBilgileriBindingSource.MoveNext();
                    }

                    tblMalzemeBilgileriBindingSource.MoveFirst();
                }
                MyInput.malzemeBilgileri = MalzemeBilgisi;


                RaporBilgisiDVO[] RaporBilgisi = new RaporBilgisiDVO[tblRaporBilgileriBindingSource.Count];
                if (tblRaporBilgileriBindingSource.Count > 0)
                {
                    tblRaporBilgileriBindingSource.MoveFirst();
                    for (int i = 0; i < tblRaporBilgileriBindingSource.Count; i++)
                    {
                        RowText = (DataRowView)tblRaporBilgileriBindingSource.Current;
                        RaporBilgisi[i] = new RaporBilgisiDVO();
                        RaporBilgisi[i].raporNo = RowText[0].ToString();
                        RaporBilgisi[i].raporVerenTesisKodu = Convert.ToInt32(RowText[1].ToString());
                        RaporBilgisi[i].raporVerilisTarihi = RowText[2].ToString();
                        RaporBilgisi[i].hizmetSunucuRefNo = RowText[3].ToString();

                        tblRaporBilgileriBindingSource.MoveNext();
                    }

                    tblRaporBilgileriBindingSource.MoveFirst();
                }
                MyInput.raporBilgileri = RaporBilgisi;


                //veriler gödneriliyor....            
                C00_2 C00_2x = new C00_2();
                C00_2x.OdemeSorguCevap = servis.odemeBilgisiKaydet(MyInput);
                C00_2x.ShowDialog();

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

        private void button2_Click(object sender, EventArgs e)
        {
            frmDr ftesx = new frmDr();
            ftesx.selectx = true;
            ftesx.ShowDialog();
            if (ftesx.stesis != "")
                mu_do.Text = ftesx.stesis;
            ftesx.Dispose();

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                frmDr ftesx = new frmDr();
                ftesx.selectx = true;
                ftesx.ShowDialog();
                if (ftesx.stesis != "")
                {
                    dataGridView2[e.ColumnIndex, e.RowIndex].Value = ftesx.stesis;
                    dataGridView2.RefreshEdit();
                }
                ftesx.Dispose();
            }
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                frmDr ftesx = new frmDr();
                ftesx.selectx = true;
                ftesx.ShowDialog();
                if (ftesx.stesis != "")
                {
                    dataGridView3[e.ColumnIndex, e.RowIndex].Value = ftesx.stesis;
                    dataGridView3.RefreshEdit();
                }
                ftesx.Dispose();
            }
        }

        private void dataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                frmDr ftesx = new frmDr();
                ftesx.selectx = true;
                ftesx.ShowDialog();
                if (ftesx.stesis != "")
                {
                    dataGridView5[e.ColumnIndex, e.RowIndex].Value = ftesx.stesis;
                    dataGridView5.RefreshEdit();
                }
                ftesx.Dispose();
            }

        }

        private void dataGridView6_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                frmDr ftesx = new frmDr();
                ftesx.selectx = true;
                ftesx.ShowDialog();
                if (ftesx.stesis != "")
                {
                    dataGridView6[e.ColumnIndex, e.RowIndex].Value = ftesx.stesis;
                    dataGridView6.RefreshEdit();
                }
                ftesx.Dispose();
            }

        }

        private void dataGridView7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                frmDr ftesx = new frmDr();
                ftesx.selectx = true;
                ftesx.ShowDialog();
                if (ftesx.stesis != "")
                {
                    dataGridView7[e.ColumnIndex, e.RowIndex].Value = ftesx.stesis;
                    dataGridView7.RefreshEdit();
                }
                ftesx.Dispose();
            }

        }

        private void dataGridView8_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                frmDr ftesx = new frmDr();
                ftesx.selectx = true;
                ftesx.ShowDialog();
                if (ftesx.stesis != "")
                {
                    dataGridView8[e.ColumnIndex, e.RowIndex].Value = ftesx.stesis;
                    dataGridView8.RefreshEdit();
                }
                ftesx.Dispose();
            }

        }
    }
}