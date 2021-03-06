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
using System.Net.Mail;


namespace meno
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
            textBox2.Text = textBox2.Text.Trim();

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Alanları doldurunuz!");
                return;
            }

            try
            {
                button1.Enabled = false;
                MailMessage oMsg = new MailMessage();
                oMsg.SubjectEncoding = System.Text.Encoding.Default;
                oMsg.BodyEncoding = System.Text.Encoding.Default;
                
                MailAddress madd = new MailAddress("info@datakent.com");
                oMsg.From = madd;
                
                oMsg.To.Add( madd );                
                oMsg.Subject = textBox2.Text;
                oMsg.Body = textBox1.Text + "\r\nUser ID:" + GlobalClass.xuserID;

                SmtpClient client = new SmtpClient("mail.datakent.com");                
                client.Send(oMsg);

                oMsg = null;
                
                MessageBox.Show("Mesajınız gönderilmiştir.", "E-Posta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                button1.Enabled = true;
                MessageBox.Show("Hata oluştu : " + ex);
            }            
        }
    }
}