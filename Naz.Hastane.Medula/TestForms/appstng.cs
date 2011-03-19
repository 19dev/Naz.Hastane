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
using Microsoft.Win32;

namespace Naz.Hastane.Medula.TestForms
{
    public partial class appstng : Form
    {
        public appstng()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey hcr = Registry.CurrentUser;                
                hcr.CreateSubKey(GlobalClass.rgsk1);
                hcr = hcr.OpenSubKey(GlobalClass.rgsk1, true);

                hcr.SetValue(GlobalClass.rgsk2, (string)textBox2.Text);
                hcr.SetValue(GlobalClass.rgsk3, (string)textBox3.Text);
                hcr.SetValue(GlobalClass.rgsk4, (string)textBox4.Text);
                hcr.SetValue(GlobalClass.rgsk0, (string)textBox1.Text);
                hcr.Close();

                GlobalClass.WSDLUserPassword = textBox2.Text;
                GlobalClass.WSDLUserName = textBox1.Text;
                GlobalClass.xuserpass = textBox3.Text;
                GlobalClass.xtesiskodu = textBox4.Text;
                MessageBox.Show("Ayarlarýnýz kayýt edilmiþtir.", "Genel Ayarlar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                ErrFrm erxf = new ErrFrm();
                erxf.ermessage = ex.Message;
                erxf.ShowDialog();
                erxf.Dispose();
            }
        }

        private void appstng_Load(object sender, EventArgs e)
        {
            textBox1.Text = GlobalClass.WSDLUserName;
            textBox2.Text = GlobalClass.WSDLUserPassword;
            textBox3.Text = GlobalClass.xuserpass;
            textBox4.Text = GlobalClass.xtesiskodu;

            if (GlobalClass.xuserpass != "")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                label4.Visible = false;
                textBox4.Visible = false;
                panel2.Visible = false;
                button1.Visible = false;
                
                panel3.Visible = true;
                panel3.Left = 42;
            }
        }

        private void Tamam_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == GlobalClass.xuserpass)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                label4.Visible = true;
                textBox4.Visible = true;
                panel3.Visible = true;
                panel2.Visible = true;
                button1.Visible = true;

                panel3.Visible = false;  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}