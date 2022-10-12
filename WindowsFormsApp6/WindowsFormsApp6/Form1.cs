using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private bool check(ziak item)
        {
            if (item.name.Contains(textBox1.Text)) { break; }
            return true;
        }
    }

}
public class ziak{
    public string name;
    public string trieda;
    public string status;
    public string cislo;
}
