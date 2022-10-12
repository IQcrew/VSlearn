using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class auto
    {
        private string nazov;
        int rok_vyroby;
        string farba;

        public auto(string Nazov, int Rok_vyroby, string Farba)
        {
            nazov = Nazov;
            rok_vyroby = Rok_vyroby;
            farba = Farba;
        }
        public string Nazov {
            get { return nazov; } 
            set { nazov = value; } 
        }
        public int Rok_vyroby
        {
            get { return rok_vyroby; }
            set {
                if (value <= 2022)
                {
                    rok_vyroby = value;
                }
            }
        }
        public string Farba
        {
            get { return farba; }
            set { farba = value; }
        }

        public int getVek()
        {
            return 2022-rok_vyroby;
        }
        public void popisAuto()
        {
            Console.WriteLine("auto z nazvom " + nazov+" a rokom vyroby "+rok_vyroby+" ma farbu "+farba);
        }

    }
}
