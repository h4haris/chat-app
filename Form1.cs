using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public string textToSend;

        public Form1()
        {
            InitializeComponent();

            //Set IP Address in textbox by default 
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtServerIP.Text = address.ToString();
                    //txtClientIP.Text = address.ToString();
                }
            }
        }

        private void btnServerStart_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(txtServerPort.Text));

            // Start listening for client requests.
            listener.Start();

            MessageBox.Show("Server Started");

            //Disable buttons and textboxes
            btnServerStart.Enabled = false;
            btnClientConnect.Enabled = false;
            txtClientIP.Enabled = txtClientPort.Enabled = false;
            txtServerIP.Enabled = txtServerPort.Enabled = false;

            //Set focus on message textbox
            txtMessage.Select();

            // Perform a call to accept requests.
            client = listener.AcceptTcpClient();

            // Get stream
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void btnClientConnect_Click(object sender, EventArgs e)
        {
            // Create a TcpClient.
            // Note, for this client to work you need to have a TcpServer 
            // connected to the same address as specified by the server, port
            // combination.

            client = new TcpClient();
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(txtClientIP.Text), int.Parse(txtClientPort.Text));
            try
            {
                //Connect client
                client.Connect(iPEndPoint);
                if (client.Connected)
                {
                    MessageBox.Show("Connected to Server");

                    //Disable buttons and textboxes
                    btnServerStart.Enabled = false;
                    btnClientConnect.Enabled = false;
                    txtClientIP.Enabled = txtClientPort.Enabled = false;
                    txtServerIP.Enabled = txtServerPort.Enabled = false;

                    //Set focus on message textbox
                    txtMessage.Select();

                    // Get stream
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    // Read received stream message and show in chat textbox
                    receive =  STR.ReadLine();
                    txtChatBox.Invoke(new MethodInvoker(delegate ()
                    {
                        txtChatBox.AppendText("You:" + receive);
                        txtChatBox.AppendText(Environment.NewLine);
                    }));
                    receive = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                // Write message to sender chat textbox
                STW.WriteLine(textToSend);
                txtChatBox.Invoke(new MethodInvoker(delegate ()
                {
                    txtChatBox.AppendText("Me:" + textToSend);
                    txtChatBox.AppendText(Environment.NewLine);
                }));
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker2.CancelAsync();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtMessage.Text != "")
            {
                // Set message to variable and start background process
                textToSend = txtMessage.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            txtMessage.Text = "";
        }
    }
}
