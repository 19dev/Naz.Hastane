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
using Microsoft.Win32;

namespace meno
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
                MessageBox.Show("Ayarlarınız kayıt edilmiştir.", "Genel Ayarlar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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