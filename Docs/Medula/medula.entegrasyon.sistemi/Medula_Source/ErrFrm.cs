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