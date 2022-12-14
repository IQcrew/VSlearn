using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using openLabProjekt;

namespace Parkovisko
{
    public partial class ParkoviskoManager : Form
    {
        public string IpOfClient = "";
        List<Panel> allPanels;
        List<PictureBox> parkovacieMiesta;
        public List<string> menaZamestnancov;
        string[] response;
        string LastID = "";
        System.Diagnostics.Stopwatch watch;
        bool wait = false;
        Zamestnanec selectedZamestnanec;
        bool setCard = false;
        bool manualneOtvorenie = false;
        bool rozpoznavanie = false;

        public ParkoviskoManager()
        {
            InitializeComponent();
        }

        private void ParkoviskoManager_Load(object sender, EventArgs e)
        {
            allPanels = new List<Panel> { panel1, panel2, panel3, panel4, panel5, panel6 };
            menaZamestnancov = new List<string> { label1.Text, label9.Text, label13.Text, label17.Text, label21.Text, label25.Text };
            parkovacieMiesta = new List<PictureBox>() { pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36 };
            databaseManager.SetUp(menaZamestnancov);
            watch = new System.Diagnostics.Stopwatch();
            zmenitStavZavory(false);
            for (int i = 0; i < 6; i++)
            {
                (allPanels[i].Controls[4] as PictureBox).BackColor = databaseManager.findZamestnanec(menaZamestnancov[i]).Prichod == "" ? Color.Red : Color.Green;
                (allPanels[i].Controls[3] as Label).Text = "Prichod: " + databaseManager.findZamestnanec(menaZamestnancov[i]).Prichod;
            }


        }

        // update loop
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "Aktuálny čas: " + DateTime.Now.ToString();
            if (LeftMouseButton) { this.Location = new Point(BarCoords.X - (CursorCoords.X - Cursor.Position.X), BarCoords.Y - (CursorCoords.Y - Cursor.Position.Y)); }
            komunikaciaESP();

        }

        private void komunikaciaESP()
        {
            response = (Owner as connect).reportFromESP.Text.Split(',');

            try
                {
                    for (int i = 0; i < parkovacieMiesta.Count; i++)
                    {
                        parkovacieMiesta[i].BackColor = response[1][i] == 'y' ? Color.Red : Color.Green;
                    }
                }
            catch { }
                
            if (setCard && response[0] != "           ")
            {
                setCard = false;
                label4.Visible = false;
                if (rozpoznavanie)
                {
                    string tempVypis = "je voľná";
                    rozpoznavanie = false;
                    foreach (var item in databaseManager.zamestnanci)
                    {
                        if(item.cardID == response[0]) { tempVypis = "patri " + item.Meno; }
                    }
                    MessageBox.Show("Karta (" + response[0] + ")  " + tempVypis);
                }
                else
                {
                    if (databaseManager.validID(response[0]))
                    {
                        MessageBox.Show("Karta je už priradena k inému uzivatelovi !!!");
                    }
                    else
                    {
                        selectedZamestnanec.cardID = response[0];
                        databaseManager.updateZamestnanca(selectedZamestnanec);
                        MessageBox.Show("Karta z ID:  " + response[0] + "  bola nastavena pre " + selectedZamestnanec.Meno);
                    }
                }
                wait = true;
                watch.Restart();
            }
            else if (wait)
            {
                if (watch.ElapsedMilliseconds > 5000)
                {
                    watch.Restart(); watch.Stop(); 
                    wait = false;
                    if (manualneOtvorenie) { zmenitStavZavory(false); manualneOtvorenie = false; }
                }

            }
            else
            {
                if (response[0] != LastID && response[0] != "           ")
                {

                    selectedZamestnanec = databaseManager.findZamestnanecByID(response[0]);
                    wait = true;
                    watch.Restart();
                    if (!databaseManager.validID(response[0])) {
                        UdpClient udpClient = new UdpClient();
                        udpClient.Connect(IpOfClient, Convert.ToInt16(8080));
                        Byte[] senddata = Encoding.ASCII.GetBytes("w");
                        udpClient.Send(senddata, senddata.Length);
                        
                    }
                    else
                    {
                        zmenitStavZavory(true);
                        prechodZamestnanca();
                    }
                }
                LastID = response[0];
            }
        }

        private void setCard_Click(object sender, EventArgs e)
        {
            selectedZamestnanec = databaseManager.findZamestnanec(menaZamestnancov[allPanels.IndexOf((sender as Button).Parent as Panel)]);
            label4.Visible = true;
            setCard = true;
            wait = true;
            watch.Restart();
            watch.Stop();
            komunikaciaESP();
        }


        private void zmenitStavZavory(bool hodnota)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(IpOfClient, Convert.ToInt16(8080));
            Byte[] senddata = Encoding.ASCII.GetBytes(hodnota ? "y" : "n");
            udpClient.Send(senddata, senddata.Length);
        }
        private void prechodZamestnanca()
        {
            if (selectedZamestnanec.Prichod == "")
            {
                selectedZamestnanec.Prichod = DateTime.Now.ToString();
                (allPanels[menaZamestnancov.IndexOf(selectedZamestnanec.Meno)].Controls[4] as PictureBox).BackColor = Color.Green;



            }
            else
            {
                selectedZamestnanec.historia.Add("prichod: " + selectedZamestnanec.Prichod + "     odchod: " + DateTime.Now.ToString());
                selectedZamestnanec.Prichod = "";
                (allPanels[menaZamestnancov.IndexOf(selectedZamestnanec.Meno)].Controls[4] as PictureBox).BackColor = Color.Red;
            }
            databaseManager.updateZamestnanca(selectedZamestnanec);
            (allPanels[menaZamestnancov.IndexOf(selectedZamestnanec.Meno)].Controls[3] as Label).Text = "Prichod: " + selectedZamestnanec.Prichod;
        }
        private void vypisatHistoriu_Click(object sender, EventArgs e)
        {
            selectedZamestnanec = databaseManager.findZamestnanec(menaZamestnancov[allPanels.IndexOf((sender as Button).Parent as Panel)]);
            listBox1.Items.Clear();
            foreach (string item in selectedZamestnanec.historia)
            {
                listBox1.Items.Add(item);
            }

        }
        private void manualneOtvorenieBrany_Click(object sender, EventArgs e)
        {
            manualneOtvorenie = true;
            wait = true;
            watch.Restart();
            zmenitStavZavory(true);
        }

        private void odstranitKatru_Click(object sender, EventArgs e)
        {
            selectedZamestnanec = databaseManager.findZamestnanec(menaZamestnancov[allPanels.IndexOf((sender as Button).Parent as Panel)]);
            selectedZamestnanec.cardID = "           ";
            databaseManager.updateZamestnanca(selectedZamestnanec);
            MessageBox.Show("karta použivateľa " + selectedZamestnanec.Meno + " bola odstranena");
        }

        private void rozpoznatKartu_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            rozpoznavanie = true;
            setCard = true;
            wait = true;
            watch.Restart();
            watch.Stop();
            komunikaciaESP();
        }

        // WINDOW DESINGN
        Point CursorCoords = new Point();
        Point BarCoords = new Point();
        bool LeftMouseButton = false;



        // Bar
        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            CursorCoords = Cursor.Position;
            BarCoords = Location;
            LeftMouseButton = true;
        }
        private void bar_MouseUp(object sender, MouseEventArgs e)
        {
            LeftMouseButton = false;
        }


        // minimize button
        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.Black;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.FromArgb(255, 39, 163, 188);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //exit button
        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.Red;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.FromArgb(255, 39, 163, 188);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            (Owner as connect).exitApplication();
            Application.Exit();
        }

    }
}
