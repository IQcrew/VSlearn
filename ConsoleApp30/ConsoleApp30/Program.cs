using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> test = new List<int>() { 1,6,2,6,3,54,24,2,6,8,9,2};
            int[] lol = test
                .Where(x => x > 2)
                .OrderBy(x => x)
                .ToArray();


            Console.WriteLine(lol.ToString());
        }



    }

}
