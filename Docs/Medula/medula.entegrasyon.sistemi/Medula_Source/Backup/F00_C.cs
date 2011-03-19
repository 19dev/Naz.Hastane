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
    public partial class F00_C : Form
    {
        public RaporUzatCevapDVO RaporCevap = null;

        public F00_C()
        {
            InitializeComponent();
        }

        private void F00_C_Load(object sender, EventArgs e)
        {
            if (RaporCevap == null)
            {
                label3.Text = "��lem ba�ar�s�z <Geriye D�nen De�er : NULL>!!!";
                button1.Enabled = false;
            }
            else
            {
                textBox1.Text = RaporCevap.sonucKodu.ToString();
                textBox2.Text = RaporCevap.sonucAciklamasi;
                if (RaporCevap.isgoremezlikRaporEk == null)
                    label3.Text = "��lem ba�ar�s�z <Girilen Veriler ��in Geriye D�nen De�er : NULL>!!!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}