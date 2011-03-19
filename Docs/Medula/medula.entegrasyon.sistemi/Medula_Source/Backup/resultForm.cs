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

        private void resultForm_Load(object sender, EventArgs e)
        {
            textBox3.Text = RapType(raporTuru);

            textBox1.Text = sonucKodu;
            textBox2.Text = sonucAciklamasi;
            if (isNULL_)
                label3.Text = "Ýþlem baþarýsýz <Geriye Dönen Deðer : NULL>!!!";
            else label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}