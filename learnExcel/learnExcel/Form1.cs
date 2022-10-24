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
using OfficeOpenXml;

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
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            saveFileDialog1.Filter = "Data Files (*.xlsx)|*.xlsx";
            saveFileDialog1.AddExtension = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {



            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //string saveFile = @"C:\Users\tobol\Downloads\testWrite.xlsx";
            //Microsoft.Office.Interop.Excel.Application excelAPP = new Microsoft.Office.Interop.Excel.Application();
            //Workbook wb;
            //Worksheet ws;
            //wb = excelAPP.Workbooks.Add();
            //ws = wb.Worksheets[1];
            //ws.Columns["A"].ColumnWidth = 50;
            //ws.Cells[1,1] = "test";
            //wb.SaveAs(saveFile);
            //wb.Close();




            var package = new ExcelPackage();


            var wb = package.Workbook;
            wb.Worksheets.Add("prva");
            var ws = wb.Worksheets[1];
            ws.Cells[1,1].Value = "ahoj";
            saveFileDialog1.ShowDialog();
            package.SaveAs(saveFileDialog1.FileName);
        }
    }
}
