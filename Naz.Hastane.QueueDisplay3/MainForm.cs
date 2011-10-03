using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Multicast;
using System.Net;

namespace Naz.Hastane.QueueDisplay3
{
    public partial class MainForm : Form
    {
        private int countDown1 = 0;
        private int countDown2 = 0;
        private int countDown3 = 0;
        private string message;
        private byte[] receivedData;

        MulticastSettings testSettings = new MulticastSettings()
        {
            Address = IPAddress.Parse("239.1.2.3"),
            Port = 40404,
            TimeToLive = 0
        };

        IMulticastListener receiver;

        public MainForm()
        {
            InitializeComponent();

            receiver = new MulticastListener(testSettings);
            receiver.StartListening(ReceiveCallback);

            pictureBox1.Load(Properties.Settings.Default.ImageFileName);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        public void ReceiveCallback(byte[] data)
        {
            receivedData = data;
            Invoke(new MethodInvoker(ProcessDisplayMessage));
            //string s = Encoding.UTF8.GetString(data);
            //var messages = s.Split(';');
            //if (messages.Length > 1)
            //{
            //    if (messages[0] == Properties.Settings.Default.DoctorID)
            //        message = messages[1];
            //}
        }

        public void ProcessDisplayMessage()
        {
            string s = Encoding.UTF8.GetString(receivedData);
            var messages = s.Split(';');
            if (messages.Length > 1)
            {
                if (messages[0] == Properties.Settings.Default.DoctorID1)
                {
                    message = messages[1];
                    lblQueue1.Text = message;
                    lblQueue1.Visible = true;
                    countDown1 = 0;
                    timer1.Enabled = true;
                }
                else if (messages[0] == Properties.Settings.Default.DoctorID1)
                {
                    message = messages[1];
                    lblQueue2.Text = message;
                    lblQueue2.Visible = true;
                    countDown2 = 0;
                    timer2.Enabled = true;
                }
                else if (messages[0] == Properties.Settings.Default.DoctorID1)
                {
                    message = messages[1];
                    lblQueue3.Text = message;
                    lblQueue3.Visible = true;
                    countDown3 = 0;
                    timer3.Enabled = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (message != lblQueue.Text)
            //{
            //    lblQueue.Text = message;
            //    lblQueue.Visible = false;
            //    countDown = 0;
            //}
            if (countDown1 < 20)
            {
                countDown1++;
                lblQueue1.Visible = !lblQueue1.Visible;
            }
            else
            {
                timer1.Enabled = false;
                lblQueue1.Visible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (countDown2 < 20)
            {
                countDown2++;
                lblQueue2.Visible = !lblQueue2.Visible;
            }
            else
            {
                timer2.Enabled = false;
                lblQueue2.Visible = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (countDown3 < 20)
            {
                countDown3++;
                lblQueue3.Visible = !lblQueue3.Visible;
            }
            else
            {
                timer3.Enabled = false;
                lblQueue3.Visible = true;
            }
        }
    }
}
