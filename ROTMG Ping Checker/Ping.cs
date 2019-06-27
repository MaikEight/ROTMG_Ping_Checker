using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Threading;

namespace ROTMG_Ping_Checker
{
    public partial class Ping : UserControl
    {
        List<Label> serverNames = new List<Label>();
        List<Label> serverPings = new List<Label>();
        List<ServerInfo> servers = new List<ServerInfo>();
        int pings = 0;
        const int pingPort = 2050;
        public Ping()
        {
            InitializeComponent();
            AddServerLabelsToList();
            AddPingLabelsToList();
            GetServerInfos();
            PingAllServer();
        }

        private void GetServerInfos()
        {
            const string webrequestSite = "https://realmofthemadgodhrd.appspot.com/char/list";
            const string serverSearch = "<Server><Name>";
            const string endNameSearch = "</Name>";
            const string endDNSSearch = "</DNS><Lat>";

            WebRequest request = WebRequest.Create(webrequestSite);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            System.IO.StreamReader read = new System.IO.StreamReader(response.GetResponseStream());
            string responseString = read.ReadToEnd();
            while (responseString.Contains(serverSearch))
            {
                responseString = responseString.Substring(responseString.IndexOf(serverSearch) + 14, responseString.Length - (responseString.IndexOf(serverSearch) + 14));
                string server = responseString.Substring(0, responseString.IndexOf(endNameSearch));
                responseString = responseString.Remove(0, server.Length + 12);
                string ip = responseString.Substring(0, responseString.IndexOf(endDNSSearch));
                servers.Add(new ServerInfo(server, ip));
            }
        }

        private void AddServerLabelsToList()
        {
            #region AddServerLabels
            serverNames.Add(lServer1);
            serverNames.Add(lServer2);
            serverNames.Add(lServer3);
            serverNames.Add(lServer4);
            serverNames.Add(lServer5);
            serverNames.Add(lServer6);
            serverNames.Add(lServer7);
            serverNames.Add(lServer8);
            serverNames.Add(lServer9);
            serverNames.Add(lServer10);
            serverNames.Add(lServer11);
            serverNames.Add(lServer12);
            serverNames.Add(lServer13);
            serverNames.Add(lServer14);
            serverNames.Add(lServer15);
            serverNames.Add(lServer16);
            serverNames.Add(lServer17);
            serverNames.Add(lServer18);
            serverNames.Add(lServer19);
            serverNames.Add(lServer20);
            serverNames.Add(lServer21);
            serverNames.Add(lServer22);
            serverNames.Add(lServer23);
            #endregion
        }

        private void AddPingLabelsToList()
        {
            #region AddPingLabels
            serverPings.Add(lPing1);
            serverPings.Add(lPing2);
            serverPings.Add(lPing3);
            serverPings.Add(lPing4);
            serverPings.Add(lPing5);
            serverPings.Add(lPing6);
            serverPings.Add(lPing7);
            serverPings.Add(lPing8);
            serverPings.Add(lPing9);
            serverPings.Add(lPing10);
            serverPings.Add(lPing11);
            serverPings.Add(lPing12);
            serverPings.Add(lPing13);
            serverPings.Add(lPing14);
            serverPings.Add(lPing15);
            serverPings.Add(lPing16);
            serverPings.Add(lPing17);
            serverPings.Add(lPing18);
            serverPings.Add(lPing19);
            serverPings.Add(lPing20);
            serverPings.Add(lPing21);
            serverPings.Add(lPing22);
            serverPings.Add(lPing23);
            #endregion
        }

        public void PingAllServer()
        {
            pings = 0;
            timerClearError.Start();

            foreach (ServerInfo server in servers)
                server.lastPing = 999999;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (ServerInfo server in servers)
            {
                Thread pingThread = new Thread(delegat => PingThreadInfo(server));
                pingThread.IsBackground = true;
                pingThread.Start();
            }
            while (pings < servers.Count)
            {
                Application.DoEvents();
            }
            stopwatch.Stop();
            AddInfoToUI();
            lTotalTime.Text = stopwatch.ElapsedMilliseconds + " m/s";
            timerClearError.Stop();
        }
        private void PingThreadInfo(ServerInfo server)
        {
            PingServerInfo(server);
            pings++;
            Thread.CurrentThread.Abort();
        }

        private void PingServerInfo(ServerInfo server)
        {
            try
            {
                System.Net.Sockets.TcpClient c = new System.Net.Sockets.TcpClient();
                Stopwatch watch = new Stopwatch();
                watch.Start();
                c.Connect(server.ip, pingPort);
                watch.Stop();
                server.lastPing = watch.ElapsedMilliseconds;
            }
            catch (Exception)
            {
                server.lastPing = 99999;
            }            
        }

        private void AddInfoToUI()
        {
            int labelID = 0;
            ServerInfo[] serversCopyArr = new ServerInfo[servers.Count];
            servers.CopyTo(serversCopyArr);
            List<ServerInfo> serversCopy = new List<ServerInfo>();

            foreach (ServerInfo s in serversCopyArr)
                serversCopy.Add(s);

            while (serversCopy.Count > 0)
            {
                ServerInfo minPing = serversCopy[0];

                foreach (ServerInfo s in serversCopy)
                {
                    if (minPing.lastPing > s.lastPing)
                        minPing = s;
                }

                if (labelID < serverNames.Count)
                {
                    serverNames[labelID].Text = minPing.name;
                    serverPings[labelID].Text = minPing.lastPing + " m/s";
                    serverPings[labelID].ForeColor = GetLabelColor(minPing.lastPing);
                    labelID++;
                }
                else
                    return;
                serversCopy.Remove(minPing);
            }
            btnRetry.Enabled = true;
        }

        private Color GetLabelColor(long ping)
        {
            if (ping < 50)
                return Color.Green;
            if (ping < 75)
                return Color.Black;
            if (ping < 100)
                return Color.Orange;
            if (ping < 150)
                return Color.IndianRed;
            if (ping == 99999)
                return Color.DarkRed;

            return Color.Red;
        }

        private void BtnRetry_Click(object sender, EventArgs e)
        {
            btnRetry.Enabled = false;
            PingAllServer();
        }

        private void BtnRetry_MouseEnter(object sender, EventArgs e)
        {
            btnRetry.BackColor = Color.FromArgb(83, 146, 223);
            btnRetry.Image = Properties.Resources.UI_Icon_History;
        }

        private void BtnRetry_MouseLeave(object sender, EventArgs e)
        {
            btnRetry.BackColor = Color.Transparent;
            btnRetry.Image = Properties.Resources.UI_Icon_History_Dark;
        }

        private void BtnRetry_MouseUp(object sender, MouseEventArgs e)
        {
            btnRetry.BackColor = Color.FromArgb(83, 146, 223);
            btnRetry.Image = Properties.Resources.UI_Icon_History;
        }

        private void BtnRetry_MouseDown(object sender, MouseEventArgs e)
        {
            btnRetry.BackColor = Color.Transparent;
            btnRetry.Image = Properties.Resources.UI_Icon_History_Dark;
        }

        private void TimerClearError_Tick(object sender, EventArgs e)
        {
            timerClearError.Stop();
            pings = 9999;
            PingAllServer();
        }
    }
}
