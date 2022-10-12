using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Parkovisko
{
    public partial class connect : Form
    {
        Thread thdUDPServer;
        bool active = true;
        string animation = "";
        System.Diagnostics.Stopwatch watch;

        public connect()
        {
            InitializeComponent();
        }
         
        private void connect_Load(object sender, EventArgs e)
        {
            thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
            watch = new System.Diagnostics.Stopwatch();
            watch.Start();
        }
        public void serverThread() //SERVER
        {
            bool active = false;
            UdpClient udpClient = new UdpClient(8080);
            while (true)
            {


                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 8080);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);

                this.Invoke(new MethodInvoker(delegate ()
                {
                    if (active)
                    {

                        this.reportFromESP.Text = returnData;
                        return;
                    }
                    Form form = new ParkoviskoManager();
                    form.Owner = this;
                    (form as ParkoviskoManager).IpOfClient = RemoteIpEndPoint.Address.ToString();
                    this.Hide();
                    form.Show();
                    active = true;

                }));
            }
        }
        public void exitApplication()
        {
            thdUDPServer.Abort();
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!active)
                return;
            label1.Text = "Connecting to ESP32" + animation;
            animation = String.Concat(Enumerable.Repeat(".", (Int32.Parse(watch.ElapsedMilliseconds.ToString())/200)%4) );

        }
    }
}
