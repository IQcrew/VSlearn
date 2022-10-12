using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
        }
        public string ChooseFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { return openFileDialog1.FileName; }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Load(openFileDialog1.FileName);
        }
    }
}
