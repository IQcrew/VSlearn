using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CestovnaKacelaria CestovnaK = new CestovnaKacelaria();
            CestovnaK.add(new zajazd("turecko", 204.5f, "10.4.2021", "15.4.2021"));
            CestovnaK.add(new zajazd("taliansko", 765f, "12.12.2021", "20.12.2021"));
            CestovnaK.add(new zajazd("rakusko", 765f, "12.8.2021", "20.8.2021"));
            CestovnaK.add(new zajazd("francuzko", 765f, "1.3.2021", "8.3.2021"));

            CestovnaK.vypis();
        }
    }
}
