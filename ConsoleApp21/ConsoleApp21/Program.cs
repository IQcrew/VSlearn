using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> mena = new List<string>() { "Miso", "tobo", "jano", "miso", "Miso", "lukas", "Lukas"};
            string user_input = Console.ReadLine(); int pocet = 0;
            foreach (var item in mena){if (item.ToLower() == user_input.ToLower()) { pocet++; } }
            Console.WriteLine(pocet != 0 ?  "Meno sa v databaze nachadza: "+pocet.ToString() + " krat." : "Meno sa nenaslo");
        }
    }
}
