using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class CestovnaKacelaria
    {
        List<zajazd> zajazdy = new List<zajazd>();

        public CestovnaKacelaria()
        {

        }
        public void vypis()
        {
            foreach (var item in zajazdy)
            {
                Console.WriteLine(item.getDestinacia()+" "+item.getCena()+"€ "+item.getOdDatum()+" "+item.getDoDatum());
            }
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

    }
}
