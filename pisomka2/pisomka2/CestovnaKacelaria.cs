using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisomka2
{
    internal class CestovnaKacelaria
    {
        List<zajazd> zajazdy = new List<zajazd>();

        public CestovnaKacelaria()
        {

        }
        public void add(zajazd vstup)
        {
            zajazdy.Add(vstup);
        }
        public void remove(int index)
        {
            try { zajazdy.RemoveAt(index); }
            catch { }
        }
        public void createZajazd(string name, string destinacia, float cena, string odDatum, string doDatum)
        {
            add(new zajazd(name,destinacia,cena,odDatum,doDatum));
        }
        public List<string> vypis()
        {
            List<string> temp = new List<string>();
            foreach (var item in zajazdy)
            {
                temp.Add(item.getNazov+" v "+ item.getDestinacia + " " + item.getCena + "€ od: " + item.getOdDatum + " do: " + item.getDoDatum+"\n");
            }
            return temp;
        }

    }
}
