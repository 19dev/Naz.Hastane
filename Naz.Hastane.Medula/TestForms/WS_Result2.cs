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
using Naz.Hastane.Medula;

namespace Naz.Hastane.Medula.TestForms
{
    public partial class WS_Result2 : UserControl
    {

        public void SetErrvalue(string errx)
        {
            hk_sonuc_mesaj.Text = errx;
        }

        string GetTakipDrm(string TTID)
        {
            string sxx = "";
            switch (TTID)
            {
                case "0":
                    sxx= "�deme sorgusu yap�lmad�";
                    break;
                case "1":
                    sxx = "�deme sorgusu yap�ld�";
                    break;
                default:
                    sxx = "";
                    break;
            }
            return sxx;
        }

        string GetTesisTuru(string TTID)
        {
            string sxx = "";
            switch (TTID)
            {
                case "1":
                    sxx= "1.Basamak kurum ve kurulu�lara sevk";
                    break;
                case "2":
                    sxx = "2.Basamak kurum ve kurulu�lara sevk";
                    break;
                case "3":
                    sxx = "3.Basamak kurum ve kurulu�lara sevk";
                    break;
                case "4":
                    sxx = "A��z ve di� sa�l��� merkezleri";
                    break;
                case "5":
                    sxx = "Eczaneler";
                    break;
                case "6":
                    sxx = "Optik firmalar�";
                    break;
                case "7":
                    sxx = "G�r�nt�leme merkezleri";
                    break;
                case "8":
                    sxx = "Acil hizmet merkezleri";
                    break;
                case "9":
                    sxx = "Laboratuarlar";
                    break;
                case "10":
                    sxx = "Tedavi merkezleri";
                    break;
                case "11":
                    sxx = "T�bbi malzeme tedarik�ileri";
                    break;
                default:
                    sxx = "";
                    break;
            }
            return sxx;
        }

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

        void ClearAllObj()
        {
            hk_sonuc_kodu.Text = "";
            hk_sonuc_mesaj.Text = "";
            hk_takip_no.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            hk_adi.Text = "";
            hk_soyadi.Text = "";
            hk_cins.Text = "";
            hk_dt.Text = "";
            hk_tc_no.Text = "";
            hk_sosgno.Text = "";
            hk_karne_no.Text = "";
            hk_yakinlik.Text = "";        
        }

        //public void FillText(ref TakipDVO WSOutPut)
        //{
        //    ClearAllObj();
        //    hk_sonuc_kodu.Text = WSOutPut.sonucKodu.ToString();
        //    hk_sonuc_mesaj.Text = WSOutPut.sonucMesaji.ToString();
        //    hk_takip_no.Text = WSOutPut.takipNo.ToString();
        //    textBox1.Text = WSOutPut.takipTarihi.ToString();
        //    textBox2.Text = WSOutPut.kayitTarihi.ToString();
        //    textBox3.Text = WSOutPut.tesisKodu.ToString();
        //    textBox4.Text = GetTesisTuru(WSOutPut.gidecegiTesisTuru.ToString());
        //    textBox5.Text = WSOutPut.sevkEdenTesis.ToString();
        //    if (WSOutPut.sevkEdilenBransKodu!=null)
        //        textBox6.Text = WSOutPut.sevkEdilenBransKodu.ToString();//db deb kontrol edilecek...
        //    textBox7.Text = WSOutPut.sevkEdilisTarihi.ToString();
        //    textBox8.Text = WSOutPut.sevkEdenDrTescil.ToString();
        //    textBox9.Text = GetTakipDrm( WSOutPut.takipDurumu.ToString() );

        //    hk_adi.Text = WSOutPut.hastaBilgileri.ad.ToString().Trim();
        //    hk_soyadi.Text = WSOutPut.hastaBilgileri.soyad.ToString().Trim();
        //    hk_cins.Text = WSOutPut.hastaBilgileri.cinsiyet.ToString().Trim();
        //    hk_dt.Text = WSOutPut.hastaBilgileri.dogumTarihi.ToString().Trim();
        //    hk_tc_no.Text = WSOutPut.hastaBilgileri.tcKimlikNo.ToString().Trim();
        //    hk_sosgno.Text = WSOutPut.hastaBilgileri.sosyalGuvenlikNo.ToString().Trim();
        //    hk_karne_no.Text = WSOutPut.hastaBilgileri.karneNo.ToString().Trim();
        //    hk_yakinlik.Text = WSOutPut.hastaBilgileri.yakinlikKodu.ToString().Trim() + " - " + GetYakinlikodu(WSOutPut.hastaBilgileri.yakinlikKodu.ToString());
        //}
        public WS_Result2()
        {
            InitializeComponent();
        }
    }
}
