/*
    Bu yazılımın tasarımı ve kaynak kodları Datakent'e aittir.
    istenildiği gibi geliştirilebilir, tasarımı değiştirilebilir.
    yazılımdaki kodlar ve tasarım referans gösterilerek kullanılabilir.
    ücretle VEYA dengi nesne karşılığında SATILMAMALIDIR.
    gönlüm bu yazılımın insanlar tarafından serbestçe kullanılmasından yanadır.
    emeğe haksızlık yapmak istemiyorsanız yazılımdaki DATAKENT'e ait bilgileri KALDIRMAYINIZ.
    yok ben emeği önemsemem, enayi gibi kodları yayınlamasaydınız diyorsanız İSTEDİĞİNİZİ yapabilirsiniz.
 
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