using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        Image[] images = new Image[4];
        int x = 0;
        bool zapnute = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            images[0] = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.Image = images[0];
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            images[1] = Image.FromFile(openFileDialog1.FileName);
            pictureBox2.Image = images[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (zapnute)
            {
                zapnute = false;
            }
            else { zapnute = true; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (zapnute)
            {
                pictureBox3.Image = images[x];
                x += 1;
                if (x >= images.Length)
                {
                    x = 0;
                }
            }


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            images[2] = Image.FromFile(openFileDialog1.FileName);
            pictureBox4.Image = images[2];
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            images[3] = Image.FromFile(openFileDialog1.FileName);
            pictureBox5.Image = images[3];
        }
    }
}
