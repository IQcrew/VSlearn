using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisomka2
{
    internal class zajazd
    {
        string nazov;
        string destinacia;
        float cena;
        string odDatum;
        string doDatum;
        public zajazd(string name, string destinacia, float cena, string odDatum, string doDatum)
        {
            this.nazov = name;
            this.destinacia = destinacia;
            this.cena = cena;
            this.odDatum = odDatum;
            this.doDatum = doDatum;
        }
        public string getDestinacia { get { return destinacia; } }
        public float getCena { get { return cena; } }
        public string getOdDatum { get{ return odDatum; } }
        public string getDoDatum { get{ return doDatum; } }
        public string getNazov { get { return nazov; } }

    }
}
