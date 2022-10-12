using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        bool temp = false;
        int[] tmp = { 0 ,0, 0, 0};
        int x = 0;
        Button tempB = new Button();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            textBox1.Text = Convert.ToString(Cursor.Position.X + ":" + Cursor.Position.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Cursor.Position.X + ":" + Cursor.Position.Y);
            textBox2.Text = this.Height.ToString();
            textBox3.Text = this.Width.ToString();
            textBox4.Text = this.Location.X.ToString();
            textBox5.Text = this.Location.Y.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newButton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (temp)
            {
                temp = false;
                button3.BackColor = Color.White;
            }
            else
            {
                tmp[0] = Cursor.Position.X; tmp[1] = Cursor.Position.Y;
                tmp[2] = button3.Location.X; tmp[3] = button3.Location.Y;
                temp = true;
                button3.BackColor = Color.Red;
            }
            textBox6.Text = temp.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (temp)
            {
                button3.Location = new Point(tmp[2]-(tmp[0]-Cursor.Position.X), tmp[3]-(tmp[1] -Cursor.Position.Y));
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            textBox7.Text = x.ToString();
            x += 1;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            textBox7.Text = x.ToString();
            x += 1;
        }

        private void button5_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.newButton();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.newButton();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }
    }
    
}
