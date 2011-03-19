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
                it = "�� Kazas�";
            else if (ix == "3")
                it = "Meslek Hastal���";
            else if (ix == "4")
                it = "Hastal�k";
            else if (ix == "5")
                it = "Do�um �ncesi �al��abilir";
            else if (ix == "6")
                it = "Anal�k";
            else if (ix == "7")
                it = "Do�um";
            else if (ix == "8")
                it = "Protez";
            else if (ix == "9")
                it = "Maluliyet";
            else if (ix == "10")
                it = "�la� Kullan�m";
            else if (ix == "11")
                it = "�la� Muafiyet";

            return it;
        }

        private void F00_A_Load(object sender, EventArgs e)
        {
            if (RaporCevap == null)
            {
                label3.Text = "��lem ba�ar�s�z <Geriye D�nen De�er : NULL>!!!";
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
                    label3.Text = "��lem ba�ar�s�z <Geriye D�nen De�er : NULL>!!!";
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