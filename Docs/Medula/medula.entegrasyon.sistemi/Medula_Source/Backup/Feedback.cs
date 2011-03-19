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
                MessageBox.Show("Alanlarý doldurunuz!");
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
                
                MessageBox.Show("Mesajýnýz gönderilmiþtir.", "E-Posta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                button1.Enabled = true;
                MessageBox.Show("Hata oluþtu : " + ex);
            }            
        }
    }
}