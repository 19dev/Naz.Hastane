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

namespace Naz.Hastane.QueueDisplay
{
    public partial class MainForm : Form
    {
        private int countDown = 0;
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
                if (messages[0] == Properties.Settings.Default.DoctorID)
                {
                    message = messages[1];
                    lblQueue.Text = message;
                    lblQueue.Visible = true;
                    countDown = 0;
                    timer.Enabled = true;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //if (message != lblQueue.Text)
            //{
            //    lblQueue.Text = message;
            //    lblQueue.Visible = false;
            //    countDown = 0;
            //}
            if (countDown < 20)
            {
                countDown++;
                lblQueue.Visible = !lblQueue.Visible;
            }
            else
            {
                timer.Enabled = false;
                lblQueue.Visible = true;
            }
        }
    }
}
