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
                label3.Text = "Ýþlem baþarýsýz <Geriye Dönen Deðer : NULL>!!!";
                button1.Enabled = false;
            }
            else
            {
                textBox1.Text = RaporCevap.sonucKodu.ToString();
                textBox2.Text = RaporCevap.sonucAciklamasi;
                if (RaporCevap.isgoremezlikRaporEk == null)
                    label3.Text = "Ýþlem baþarýsýz <Girilen Veriler Ýçin Geriye Dönen Deðer : NULL>!!!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}