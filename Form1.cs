using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoTRobotWorldUDPServer
{
    public partial class Form1 : Form
    {

        const int CMaxVisibleLogLines = 20;

        string UDPReceiveBuffer = "";

        string remoteAddress; // хост для отправки данных
        int remotePort; // порт для отправки данных
        int localPort; // локальный порт для прослушивания входящих подключений

        public delegate void ShowUDPMessage(string message);
        public ShowUDPMessage myDelegate;

        int N=20, M, F, B, T;

        UdpClient udpClient; // = new UdpClient(11000);
        Thread thread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создадим делегата метода распечатки сообщения от удаленного сервера
            myDelegate = new ShowUDPMessage(ShowUDPMessageMethod);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopUDPClient();
        }

        private void PrintLog(string s)
        {
            // CMaxVisibleLogLines
            ReportListBox.Items.Add(s);
            while (ReportListBox.Items.Count > CMaxVisibleLogLines)
            {
                ReportListBox.Items.RemoveAt(0);
            }
            ReportListBox.SelectedIndex = ReportListBox.Items.Count - 1;
            ReportListBox.SelectedIndex = -1;
        }

        private void CheckStartStopUDPClient()
        {
            if (udpClient != null)
            {
                StartStopUDPClientButton.Text = "Stop";
                RemoteIPTextBox.Enabled = false;
                RemoteIPTextBox.BackColor = Color.LightGray;
                RemotePortTextBox.Enabled = false;
                RemotePortTextBox.BackColor = Color.LightGray;
                LocalIPTextBox.Enabled = false;
                LocalIPTextBox.BackColor = Color.LightGray;
                LocalPortTextBox.Enabled = false;
                LocalPortTextBox.BackColor = Color.LightGray;
            }
            else
            {
                StartStopUDPClientButton.Text = "Start";
                RemoteIPTextBox.Enabled = true;
                RemoteIPTextBox.BackColor = Color.White;
                RemotePortTextBox.Enabled = true;
                RemotePortTextBox.BackColor = Color.White;
                LocalIPTextBox.Enabled = true;
                LocalIPTextBox.BackColor = Color.White;
                LocalPortTextBox.Enabled = true;
                LocalPortTextBox.BackColor = Color.White;
            }
        }

        private void StopUDPClient()
        {
            if ((thread != null) && (udpClient != null))
            { 
                thread.Abort();
                udpClient.Close();
                thread = null;
                udpClient = null;
            }
            PrintLog("UDPClient stopped");
            CheckStartStopUDPClient();
        }

        private void StartUDPClient()
        {
            if (thread != null)
            {
                thread.Abort();
            }
            if (udpClient != null)
            {
                udpClient.Close();
            }

            localPort = Int32.Parse(LocalPortTextBox.Text);
            try
            {
                udpClient = new UdpClient(localPort);
                thread = new Thread(new ThreadStart(ReceiveUDPMessage));
                thread.IsBackground = true;
                thread.Start();
                PrintLog("UDPClient started");
            }
            catch
            {
                PrintLog("UDPClient's start failed");
            }
            CheckStartStopUDPClient();
        }

        private void StartStopUDPClientButton_Click(object sender, EventArgs e)
        {
            if (udpClient == null)
            {
                StartUDPClient();
            }
            else
            {
                StopUDPClient();
            }
        }

        private void ShowUDPMessageMethod(string message)
        {
            PrintLog("Remote >" + message);
        }

        private void ReceiveUDPMessage()
        {                      
            while (true)
            {
                try
                {

                    IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, 0); // port);
                    byte[] content = udpClient.Receive(ref remoteIPEndPoint);
                    if (content.Length > 0)
                    {
                        string message = Encoding.ASCII.GetString(content);
                        this.Invoke(myDelegate, new object[] { message });
                    }
                }
                catch
                {
                    string errmessage = "RemoteHost lost";
                    this.Invoke(myDelegate, new object[] { errmessage });
                }
            }
        }

        private void SendUDPMessage(string s)
        {
            if (udpClient != null)
            {
                Int32 port = Int32.Parse(RemotePortTextBox.Text); 
                IPAddress ip = IPAddress.Parse(RemoteIPTextBox.Text.Trim());
                IPEndPoint ipEndPoint = new IPEndPoint(ip,port);
                byte[] content = Encoding.ASCII.GetBytes(s);
                try
                {
                    int count = udpClient.Send(content, content.Length, ipEndPoint);
                    if (count > 0)
                    {
                        PrintLog("Message has been sent.");
                    }
                }
                catch
                {
                    PrintLog("Error occurs.");
                }

            }
        }

        private void SendUDPMessageButton_Click(object sender, EventArgs e)
        {
            string s = UDPMessageTextBox.Text;
            if (AppendLFSymbolCheckBox.Checked) { s += "\n"; };
            SendUDPMessage(s);
        }

        private void RegularUDPSendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RegularUDPSendCheckBox.Checked)
            {
                UDPRegularSenderTimer.Enabled = true;
            }
            else
            {
                UDPRegularSenderTimer.Enabled = false;
            }
        }

        private void UDPRegularSenderTimer_Tick(object sender, EventArgs e)
        {
            SendUDPMessage(UDPMessageTextBox.Text);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            Bitmap control = new Bitmap(120, 120);
            Graphics g = Graphics.FromImage(control);
            Rectangle[] rectangles = 
            {
                new Rectangle(-1,70,51,50),
                new Rectangle(70,70,50,50),
                new Rectangle(-1,-1,51,51),
                new Rectangle(70,-1,50,51),
            };
            g.DrawRectangles(new Pen(Color.Black,1),rectangles);
            g.DrawLine(new Pen(Color.Red, 1), e.X, e.Y+5, e.X, e.Y-5);
            g.DrawLine(new Pen(Color.Red, 1), e.X+5, e.Y, e.X-5, e.Y);
            pictureBox_control.Image = control;
            if (e.X < 50){
                B=e.X-50;
            }
            else if (e.X > 70) {
                B = e.X - 70;        
            }
            else { B = 0; }
            if (e.Y< 50)
            {
                F = 50-e.Y ;
            }
            else if (e.Y > 70)
            {
                F = 70-e.Y ;
            }
            else { F = 0; }
            B = B * 2;
            F = F * 2;
            N++;
            string text= "{ \"N\":" + N + ", \"M\":" + M + ", \"F\":" + F + ", \"B\":" + B + ", \"T\":" + T + "}";
            if (AppendLFSymbolCheckBox.Checked) { text += "\n"; };
            UDPMessageTextBox.Text = text;
            UpD();
            SendUDPMessage(text);
        }

        public void UpD()
        {
            up_B.Value = B;
            up_F.Value = F;
            up_M.Value= M;  
            up_T.Value = T;
            up_N.Value = N;
        }
    }
}
