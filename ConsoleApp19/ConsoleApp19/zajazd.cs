using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class zajazd
    {
        string destinacia;
        float cena;
        string odDatum;
        string doDatum;
        public zajazd(string destinacia, float cena, string odDatum, string doDatum)
        {
            this.destinacia = destinacia;
            this.cena = cena;
            this.odDatum = odDatum;
            this.doDatum = doDatum;
        }
        public string getDestinacia()
        {
            return destinacia;
        }
        public float getCena()
        {
            return cena;
        }
        public string getOdDatum()
        {
            return odDatum;
        }
        public string getDoDatum()
        {
            return doDatum;
        }

    }
}
