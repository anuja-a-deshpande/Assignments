using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTCP.SimpleTcpClient client;

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            ConnectBtn.Enabled = false;
            client.Connect("127.0.0.1", 8910);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTCP.SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += client_DataReceived;
        }

        void client_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate()
            {
                txtStatus.Text += e.MessageString;
            });
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(textMessage.Text, TimeSpan.FromSeconds(3));
        }
    }
}
