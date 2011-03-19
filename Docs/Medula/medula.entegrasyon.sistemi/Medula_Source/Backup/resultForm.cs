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

namespace meno
{
    public partial class resultForm : Form
    {
        public string sonucKodu;
        public string sonucAciklamasi;
        public string raporTuru;
        public bool isNULL_;

        public resultForm()
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

        private void resultForm_Load(object sender, EventArgs e)
        {
            textBox3.Text = RapType(raporTuru);

            textBox1.Text = sonucKodu;
            textBox2.Text = sonucAciklamasi;
            if (isNULL_)
                label3.Text = "��lem ba�ar�s�z <Geriye D�nen De�er : NULL>!!!";
            else label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}