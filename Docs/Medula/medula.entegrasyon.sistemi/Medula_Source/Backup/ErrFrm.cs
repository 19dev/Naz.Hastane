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
    public partial class ErrFrm : Form
    {
        public string ermessage;

        public ErrFrm()
        {
            InitializeComponent();
        }

        private void ErrFrm_Shown(object sender, EventArgs e)
        {
            textBox1.Text = ermessage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}