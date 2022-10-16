using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] idk = { 1, 7, 3, 8, 7, 9, 6, 3, 2, 7, 3, 2, 7, 32 };
            Console.WriteLine(spocitajCisla(idk, 378));

            string example = "4948A;;HO'J9";
            Console.WriteLine(ibaPismena(example));
        }



        static int spocitajCisla(int[] cisla, int hladaneCislo)
        {
            int res = 0;
            foreach (int cislo in cisla){if(cislo == hladaneCislo) { res++; }}
            return res;
        } 
        static string ibaPismena (string vstup)
        {
            string res = "";
            foreach (char pismeno in vstup)
            {
                if (char.IsLetter(pismeno)) { res += pismeno.ToString(); }
            }

            return res;
        }


    }
}
