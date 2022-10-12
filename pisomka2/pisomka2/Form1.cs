using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pisomka2
{
    public partial class Form1 : Form
    {
        CestovnaKacelaria kancelaria;
        public Form1()
        {
            InitializeComponent();
           kancelaria = new CestovnaKacelaria();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> allZajazdy = kancelaria.vypis();
            richTextBox1.Clear();
            foreach (string s in allZajazdy)
            {
                richTextBox1.AppendText(s);
            }
        }  
        private void button3_Click(object sender, EventArgs e)
        {
            kancelaria.remove(int.Parse(textBox6.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kancelaria.createZajazd(textBox5.Text,textBox4.Text,int.Parse(textBox3.Text),textBox2.Text,textBox1.Text);
        }

    }
}
