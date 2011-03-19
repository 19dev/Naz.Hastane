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
                MessageBox.Show("Alanlar� doldurunuz!");
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
                
                MessageBox.Show("Mesaj�n�z g�nderilmi�tir.", "E-Posta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                button1.Enabled = true;
                MessageBox.Show("Hata olu�tu : " + ex);
            }            
        }
    }
}