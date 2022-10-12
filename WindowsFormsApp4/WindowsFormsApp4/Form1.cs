using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 3)
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.StandardInput.WriteLine("cd ../..");
                cmd.StandardInput.WriteLine("cd python");
                cmd.StandardInput.WriteLine("tobovpython.exe crypting_machine.py");
                cmd.StandardInput.WriteLine(textBox1.Text);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                string[] temp = cmd.StandardOutput.ReadToEnd().Split('÷');
                textBox2.Text = temp[1];
            }
            else
            {
                textBox2.Text = "Vstup musi mat aspon 4 znaky!!!!!!!!";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 3)
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.StandardInput.WriteLine("cd ../..");
                cmd.StandardInput.WriteLine("cd python");
                cmd.StandardInput.WriteLine("tobovpython.exe crypting_machine.py");
                cmd.StandardInput.WriteLine(textBox1.Text);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                string[] temp = cmd.StandardOutput.ReadToEnd().Split('¤');
                textBox2.Text = temp[1];
            }
            else
            {
                textBox2.Text = "Vstup musi mat aspon 4 znaky!!!!!!!!";
            }
        }

    }
}
