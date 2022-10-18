using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;

namespace learnExcel
{
    public partial class Form1 : Form
    {
        FileStream stream;
        DataSet result;
        public Form1()
        {
            InitializeComponent();
            stream = File.Open(@"C:\Users\tobol\Downloads\Zošit 1.xlsx", FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            result = excelReader.AsDataSet();
            

        }


        private void button1_Click(object sender, EventArgs e)
        {


            DataTable dt = result.Tables[0];
            
            string text = dt.Rows[1][0].ToString();
            dt.Rows[1][0] = "wow";
            textBox1.Text = text;
            
        }
    }
}
