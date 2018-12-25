using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP.Server;
using SimpleTCP;

namespace TcpIpDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTCP.SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += server_DataReceived;
        }

        private void server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate()
            {
                txtStatus.Text += e.MessageString;
                e.ReplyLine(string.Format("You said : {0}", e.MessageString));
            });
        }

        private void StratBtn_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Server Starting...";
            //long address = 127001;//long.Parse(txtHost.Text);
            // System.Net.IPAddress ip = new System.Net.IPAddress();
            int port = 8910;
            server.Start((System.Net.IPAddress.Parse(txtHost.Text)), port);
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
        }
    }
}
