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
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        public void ReceiveCallback(byte[] data)
        {
            string s = Encoding.UTF8.GetString(data);
            message = s;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (message != lblQueue.Text)
            {
                lblQueue.Text = message;
                lblQueue.Visible = false;
                countDown = 0;
            }
            if (countDown < 21)
            {
                countDown++;
                lblQueue.Visible = !lblQueue.Visible;
            }
        }
    }
}
