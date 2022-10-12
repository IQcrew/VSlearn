using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Data Files (*.pdf)|*.pdf";
            saveFileDialog1.AddExtension = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (pictureBox1.Image != null)
            {


                //Create PDF Document
                PdfDocument document = new PdfDocument();
                //You will have to add Page in PDF Document
                PdfPage page = document.AddPage();
                //For drawing in PDF Page you will nedd XGraphics Object
                XGraphics gfx = XGraphics.FromPdfPage(page);
                //For Test you will have to define font to be used
                XFont font = new XFont("Arial", 20, XFontStyle.Bold);

                //Finally use XGraphics & font object to draw text in PDF Page
                gfx.DrawString("tomas skusa rozmyslat", font, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawString("nemam rad nemcinu", font, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height), XStringFormats.TopRight);
                gfx.DrawString("nechcem prepadnut lebo by som si skazil zivot", font, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
                XImage image = XImage.FromFile(openFileDialog1.FileName);
                gfx.DrawImage(image, page.Width/2-100, page.Height/2+100, 200, 200);

                //Save PDF File
                document.Save(saveFileDialog1.FileName);
                //Load PDF File for viewing
                Process.Start(saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("nevybral si si obrazok");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
