using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisomkaZaver
{
    internal class Trieda
    {
        string cislo = "";
        string meno = "";
        string trieda = "";
        string status = "";
        public Trieda(string cislo, string meno, string trieda, string status)
        {
            this.cislo = cislo;
            this.meno = meno;
            this.trieda = trieda;
            this.status = status;
        }
        public Trieda(string cislo, string status)
        {
            this.cislo = cislo;
            this.status = status;
        }
        public string Cislo { get { return cislo; } }
        public string Meno { get { return meno; } }
        public string Tieda { get { return trieda; } }
        public string Status { get { return status; } }
    }
}
