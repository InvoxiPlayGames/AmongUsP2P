using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AmongUsP2P
{
    public partial class MainWindow : Form
    {
        UdpClient broadcaster = new UdpClient();
        UdpClient game = new UdpClient();
        UdpClient joined = new UdpClient();
        string IPtoJoin = "";
        bool connected = false;
        bool asking = false;
        IPEndPoint currentClient = new IPEndPoint(0, 0);

        ulong lastPoll = 0;
        System.Timers.Timer bcTimer = new System.Timers.Timer(500);

        public MainWindow()
        {
            InitializeComponent();
        }
        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            try
            {
                game.Client.Bind(new IPEndPoint(0, 22023));
            } catch(Exception)
            {
                MessageBox.Show("Could not bind to port 22023. Please make sure you're only running 1 instance of the program, and that you're not hosting any games already on Among Us.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            joined.Client.Bind(new IPEndPoint(0, 0));
            bcTimer.Elapsed += SendBroadcast;
            bcTimer.Start();
            Task.Run(() => { while (true) { HandleOutboundPackets(); } });
            Task.Run(() => { while (true) { HandleInboundPackets(); } });
        }

        private void SendBroadcast(Object source, ElapsedEventArgs e)
        {
            string nameToBroadcast = "Join via IP";
            if (IPtoJoin != "" && !askForIPBox.Checked) nameToBroadcast = IPtoJoin;
            string broadcastString = "  " + nameToBroadcast + "~Open~?~";
            byte[] broadcastData = Encoding.ASCII.GetBytes(broadcastString);
            broadcastData[0] = 0x04;
            broadcastData[1] = 0x02;
            IPAddress IPtoSend = IPAddress.Loopback;
            if (broadcastCheckBox.Checked) IPtoSend = IPAddress.Broadcast;
            broadcaster.EnableBroadcast = broadcastCheckBox.Checked;
            IPEndPoint bcEndpoint = new IPEndPoint(IPtoSend, 47777);
            if (IPtoJoin == "" && !askForIPBox.Checked) return; // stop people from joining because it gets stuck
            broadcaster.Send(broadcastData, broadcastData.Length, bcEndpoint);
        }

        void HandleOutboundPackets()
        {
            try
            {
                var recvBuffer = game.Receive(ref currentClient);
                if (asking) return;
                Console.WriteLine("OUT->" + IPtoJoin + ": " + ByteArrayToString(recvBuffer));
                if (recvBuffer[0] == 0x08 && !connected && askForIPBox.Checked)
                {
                    asking = true;
                    AskForIP();
                    return;
                }
                if (recvBuffer[0] == 0x08 && !connected) connected = true;
                if (recvBuffer[0] == 0x09 && connected) connected = false;
                joined.Send(recvBuffer, recvBuffer.Length, IPtoJoin, 22023);
            } catch (Exception) { }
        }

        void AskForIP()
        {
            SystemSounds.Question.Play();
            IPAskDialog ask = new IPAskDialog();
            ask.BringToFront();
            ask.TopMost = true;
            ask.ShowDialog();
            IPtoJoin = ask.ipAddr;
            connected = true;
            asking = false;
        }

        void HandleInboundPackets()
        {
            try
            {
                var ipLol = new IPEndPoint(0, 0);
                var recvBuffer = joined.Receive(ref ipLol);
                Console.WriteLine("IN->" + currentClient.Address.ToString() + ": " + ByteArrayToString(recvBuffer));
                if (recvBuffer[0] == 0x09 && connected) connected = false;
                game.Send(recvBuffer, recvBuffer.Length, currentClient);
            }
            catch (Exception) { }
        }

        private void ipTextbox_TextChanged(object sender, EventArgs e)
        {
            IPtoJoin = ipTextbox.Text;
        }

        private void askForIPBox_CheckedChanged(object sender, EventArgs e)
        {
            ipTextbox.Enabled = !askForIPBox.Checked;
        }

        private void updateConnected_Tick(object sender, EventArgs e)
        {
            if (!connected) statusLabel.Text = "Not Connected";
            if (connected) statusLabel.Text = "Connected to " + IPtoJoin;
            if (!connected && !askForIPBox.Checked) ipTextbox.Enabled = true;
            if (connected && !askForIPBox.Checked) ipTextbox.Enabled = false;
        }
    }
}
