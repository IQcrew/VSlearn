using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pisomkaZaver
{
    public partial class Form1 : Form
    {
        List<Trieda> zoznam = new List<Trieda>{
                new Trieda("č1", "Novák", "2AI", "obsadená"),
                new Trieda("č2", "Pepík", "2BI", "obsadená"),
                new Trieda("č3", "Kubik", "2BI", "obsadená"),
                new Trieda("č4", "voľná"),
                new Trieda("č5", "Novák", "2CI", "obsadená")
            };
        List<TextBox> filterBoxes;
        public Form1()
        {
            InitializeComponent();
            filterBoxes = new List<TextBox>{textBox1, textBox2, textBox3, textBox4};
            vypis();
        }
        private void vypis()
        {
            richTextBox1.Clear();
            foreach (var item in zoznam)
            {
                if (fiterCheck(item)) { richTextBox1.AppendText(item.Cislo + "  " + item.Meno + "  " + item.Tieda + "  " + item.Status + "\n"); }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            vypis();
        }
        private bool fiterCheck(Trieda item)
        {
            string[] temp = { item.Cislo, item.Meno, item.Tieda, item.Status};
            for (int i = 0; i < 4; i++)
            {
                if(!(filterBoxes[i].Text == "" || temp[i].ToLower().Contains(filterBoxes[i].Text.ToLower())))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
