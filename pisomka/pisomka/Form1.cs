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

namespace pisomka
{
    public partial class Form1 : Form
    {
        string[] animationList = { null, null, null, null };
        int tempIndex = 0;
        bool runAnimation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try { animationList[0] = ChooseFile(); pictureBox1.Load(animationList[0]); }
            catch { animationList[0] = null; }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try { animationList[1] = ChooseFile(); pictureBox2.Load(animationList[1]); }
            catch { animationList[1] = null; }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try { animationList[2] = ChooseFile(); pictureBox3.Load(animationList[2]); }
            catch { animationList[2] = null; }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try { animationList[3] = ChooseFile(); pictureBox4.Load(animationList[3]); }
            catch { animationList[3] = null; }
        }
        public string ChooseFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK){return openFileDialog1.FileName;}
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!animationList.Any(o => o != animationList[0])) { return; }
            if (runAnimation){ runAnimation = false;button1.Text = "Spusti animaciu"; }
            else{ runAnimation = true;  button1.Text = "Zastav animaciu"; }
        }

        private int returnIndex(int idx)
        {
            for (int i = idx+1; i < animationList.Length; i++){if(animationList[i] != null) { return i; }}
            for (int i = 0; i < animationList.Length; i++){if (animationList[i] != null) { return i; }}
            return 0;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Interval = 1000 / hScrollBar1.Value;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (runAnimation)
            {
                tempIndex = returnIndex(tempIndex);
                pictureBox5.Load(animationList[tempIndex]);
            }
        }
    }
}