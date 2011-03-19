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
using meno.MyWSDL_F00;

namespace meno
{
    public partial class F00_A : Form
    {
        public RaporCevapDVO RaporCevap=null;
        public string ktkod = "";

        public F00_A()
        {
            InitializeComponent();
        }

        string RapType(string ix)
        {
            string it = "";

            if (ix == "1")
                it = "Tedavi";
            else if (ix == "2")
                it = "Ýþ Kazasý";
            else if (ix == "3")
                it = "Meslek Hastalýðý";
            else if (ix == "4")
                it = "Hastalýk";
            else if (ix == "5")
                it = "Doðum Öncesi Çalýþabilir";
            else if (ix == "6")
                it = "Analýk";
            else if (ix == "7")
                it = "Doðum";
            else if (ix == "8")
                it = "Protez";
            else if (ix == "9")
                it = "Maluliyet";
            else if (ix == "10")
                it = "Ýlaç Kullaným";
            else if (ix == "11")
                it = "Ýlaç Muafiyet";

            return it;
        }

        private void F00_A_Load(object sender, EventArgs e)
        {
            if (RaporCevap == null)
            {
                label3.Text = "Ýþlem baþarýsýz <Geriye Dönen Deðer : NULL>!!!";
                button1.Enabled = false;
            }
            else
            {
                textBox3.Text = RapType(RaporCevap.raporTuru);
                textBox1.Text = RaporCevap.sonucKodu.ToString();
                textBox2.Text = RaporCevap.sonucAciklamasi;

                if (RaporCevap.isgoremezlikRapor == null &&
                RaporCevap.dogumOncesiCalisabilirRapor == null &&
                RaporCevap.dogumRapor == null &&
                RaporCevap.analikRapor == null &&
                RaporCevap.protezRapor == null &&
                RaporCevap.ilacRapor == null &&
                RaporCevap.tedaviRapor == null &&
                RaporCevap.maluliyetRapor == null)
                {
                    label3.Text = "Ýþlem baþarýsýz <Geriye Dönen Deðer : NULL>!!!";
                    button1.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show form...
            if (RaporCevap.maluliyetRapor != null)
            {
                F00_8 Fx8 = new F00_8();
                Fx8.ViewF = true;
                Fx8.ktkod = ktkod;
                Fx8.TMPRap = RaporCevap.maluliyetRapor;
                Fx8.Dispose();
            }
            if (RaporCevap.tedaviRapor != null)
            {
                F00_7 Fx7 = new F00_7();
                Fx7.ViewF = true;
                Fx7.ktkod = ktkod;
                Fx7.TMPRap = RaporCevap.tedaviRapor;
                Fx7.Dispose();
            }
            if (RaporCevap.ilacRapor != null)
            {
                F00_6 Fx6 = new F00_6();
                Fx6.ViewF = true;
                Fx6.ktkod = ktkod;
                Fx6.TMPRap = RaporCevap.ilacRapor;
                Fx6.Dispose();
            }
            if (RaporCevap.protezRapor != null)
            {
                F00_5 Fx5 = new F00_5();
                Fx5.ViewF = true;
                Fx5.ktkod = ktkod;
                Fx5.TMPRap = RaporCevap.protezRapor;
                Fx5.Dispose();
            }
            if (RaporCevap.analikRapor != null)
            {
                F00_4 Fx4 = new F00_4();
                Fx4.ViewF = true;
                Fx4.ktkod = ktkod;
                Fx4.TMPRap = RaporCevap.analikRapor;
                Fx4.Dispose();
            }
            if (RaporCevap.dogumRapor != null)
            {
                F00_3 Fx3 = new F00_3();
                Fx3.ViewF = true;
                Fx3.ktkod = ktkod;
                Fx3.TMPRap = RaporCevap.dogumRapor;
                Fx3.Dispose();
            }
            if (RaporCevap.dogumOncesiCalisabilirRapor != null)
            {
                F00_2 Fx2 = new F00_2();
                Fx2.ViewF = true;
                Fx2.ktkod = ktkod;
                Fx2.TMPRap = RaporCevap.dogumOncesiCalisabilirRapor;
                Fx2.Dispose();
            }
            if (RaporCevap.isgoremezlikRapor != null)
            {
                F00_1 Fx1 = new F00_1();
                Fx1.ViewF = true;
                Fx1.ktkod = ktkod;
                Fx1.TMPRap = RaporCevap.isgoremezlikRapor;
                Fx1.Dispose();
            }
        }
    }
}