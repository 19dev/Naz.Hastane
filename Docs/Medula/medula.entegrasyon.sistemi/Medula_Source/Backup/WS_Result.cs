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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using meno.MyWSDL_A00;
using meno.MyWSDL_B00;

namespace meno
{
    public partial class WS_Result : UserControl
    {

        string GetYakinlikodu(string _ykkd)
        {
            if (_ykkd == "1")
                return "Kendisi";
            else if (_ykkd == "2")
                return "E�i";
            else if (_ykkd == "3")
                return "�ocu�u";
            else if (_ykkd == "4")
                return "Anas�";
            else if (_ykkd == "5")
                return "Babas�";
            else return "";
        }

        public void SetErrvalue(string errx)
        {
            hk_sonuc_mesaj.Text = errx;
        }

        void ClearAllObj()
        {
            hk_sonuc_kodu.Text = "";
            hk_sonuc_mesaj.Text = "";
            hk_takip_no.Text = "";
            hk_adi.Text = "";
            hk_soyadi.Text = "";
            hk_cins.Text = "";
            hk_dt.Text = "";
            hk_tc_no.Text = "";
            hk_sosgno.Text = "";
            hk_karne_no.Text = "";
            hk_yakinlik.Text = "";
        }

        public void FillText(ref SistemDisiSevkCevapDVO WSOutPut)
        {
            ClearAllObj();

            if (WSOutPut.sonucMesaji != "")
            {
                hk_sonuc_kodu.Text = WSOutPut.sonucKodu.ToString().Trim();
                hk_sonuc_mesaj.Text = WSOutPut.sonucMesaji.ToString().Trim();
                hk_takip_no.Text = WSOutPut.takipNo.ToString().Trim();
                hk_adi.Text = WSOutPut.hastaBilgileri.ad.ToString().Trim();
                hk_soyadi.Text = WSOutPut.hastaBilgileri.soyad.ToString().Trim();
                hk_cins.Text = WSOutPut.hastaBilgileri.cinsiyet.ToString().Trim();
                hk_dt.Text = WSOutPut.hastaBilgileri.dogumTarihi.ToString().Trim();
                hk_tc_no.Text = WSOutPut.hastaBilgileri.tcKimlikNo.ToString().Trim();
                hk_sosgno.Text = WSOutPut.hastaBilgileri.sosyalGuvenlikNo.ToString().Trim();
                hk_karne_no.Text = WSOutPut.hastaBilgileri.karneNo.ToString().Trim();
                hk_yakinlik.Text = WSOutPut.hastaBilgileri.yakinlikKodu.ToString().Trim() + " - " + GetYakinlikodu(WSOutPut.hastaBilgileri.yakinlikKodu.ToString());
            }
            else hk_sonuc_mesaj.Text = WSOutPut.sonucMesaji.ToString();
        }

        public void FillText(ref ProvizyonCevapDVO WSOutPut)
        {
            ClearAllObj();

            if (WSOutPut.sonucMesaji != "")
            {
                hk_sonuc_kodu.Text = WSOutPut.sonucKodu.ToString().Trim();
                hk_sonuc_mesaj.Text = WSOutPut.sonucMesaji.ToString().Trim();
                hk_takip_no.Text = WSOutPut.takipNo.ToString().Trim();
                hk_adi.Text = WSOutPut.hastaBilgileri.ad.ToString().Trim();
                hk_soyadi.Text = WSOutPut.hastaBilgileri.soyad.ToString().Trim();
                hk_cins.Text = WSOutPut.hastaBilgileri.cinsiyet.ToString().Trim();
                hk_dt.Text = WSOutPut.hastaBilgileri.dogumTarihi.ToString().Trim();
                hk_tc_no.Text = WSOutPut.hastaBilgileri.tcKimlikNo.ToString().Trim();
                hk_sosgno.Text = WSOutPut.hastaBilgileri.sosyalGuvenlikNo.ToString().Trim();
                hk_karne_no.Text = WSOutPut.hastaBilgileri.karneNo.ToString().Trim();
                hk_yakinlik.Text = WSOutPut.hastaBilgileri.yakinlikKodu.ToString().Trim() + " - " + GetYakinlikodu(WSOutPut.hastaBilgileri.yakinlikKodu.ToString());
            }
            else hk_sonuc_mesaj.Text = WSOutPut.sonucMesaji.ToString();
        }

        public void FillText(ref HastaTakipAraCevapDVO WSOutPut)
        {
            ClearAllObj();

            if (WSOutPut.sonucMesaji != "")
            {
                hk_sonuc_kodu.Text = WSOutPut.sonucKodu.ToString().Trim();
                hk_sonuc_mesaj.Text = WSOutPut.sonucMesaji.ToString().Trim();
                //hk_takip_no.Text = WSOutPut.takipNo.ToString();
                hk_adi.Text = WSOutPut.hastaBilgileri.ad.ToString().Trim();
                hk_soyadi.Text = WSOutPut.hastaBilgileri.soyad.ToString().Trim();
                hk_cins.Text = WSOutPut.hastaBilgileri.cinsiyet.ToString().Trim();
                hk_dt.Text = WSOutPut.hastaBilgileri.dogumTarihi.ToString().Trim();
                hk_tc_no.Text = WSOutPut.hastaBilgileri.tcKimlikNo.ToString().Trim();
                hk_sosgno.Text = WSOutPut.hastaBilgileri.sosyalGuvenlikNo.ToString().Trim();
                hk_karne_no.Text = WSOutPut.hastaBilgileri.karneNo.ToString().Trim();
                hk_yakinlik.Text = WSOutPut.hastaBilgileri.yakinlikKodu.ToString().Trim() + " - " + GetYakinlikodu(WSOutPut.hastaBilgileri.yakinlikKodu.ToString());
            }
            else hk_sonuc_mesaj.Text = WSOutPut.sonucMesaji.ToString();
        }

        public void FillText(ref TakipCevapDVO WSOutPut)
        {
            ClearAllObj();

            if (WSOutPut.sonucMesaji != "")
            {
                hk_sonuc_kodu.Text = WSOutPut.sonucKodu.ToString().Trim();
                hk_sonuc_mesaj.Text = WSOutPut.sonucMesaji.ToString().Trim();
                hk_takip_no.Text = WSOutPut.takipNo.ToString().Trim();
                hk_adi.Text = WSOutPut.hastaBilgileri.ad.ToString().Trim();
                hk_soyadi.Text = WSOutPut.hastaBilgileri.soyad.ToString().Trim();
                hk_cins.Text = WSOutPut.hastaBilgileri.cinsiyet.ToString().Trim();
                hk_dt.Text = WSOutPut.hastaBilgileri.dogumTarihi.ToString().Trim();
                hk_tc_no.Text = WSOutPut.hastaBilgileri.tcKimlikNo.ToString().Trim();
                hk_sosgno.Text = WSOutPut.hastaBilgileri.sosyalGuvenlikNo.ToString().Trim();
                hk_karne_no.Text = WSOutPut.hastaBilgileri.karneNo.ToString().Trim();
                hk_yakinlik.Text = WSOutPut.hastaBilgileri.yakinlikKodu.ToString().Trim() + " - " + GetYakinlikodu(WSOutPut.hastaBilgileri.yakinlikKodu.ToString());
            }
            else hk_sonuc_mesaj.Text = WSOutPut.sonucMesaji.ToString();
        }

        public WS_Result()
        {
            InitializeComponent();
        }
    }
}
