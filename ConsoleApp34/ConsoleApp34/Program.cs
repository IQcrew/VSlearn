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
            char[] s = { 'a', 's', 'd' };
            char[] c = new char[s.Length];
            int x = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                c[x] = s[i];
                x++;
            }
            s = c;
            Console.WriteLine(s);
            Array.Reverse(s);
            Console.WriteLine(s);
        }
    }
}
