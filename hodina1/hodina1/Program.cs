using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {

        static void Main(string[] args)
        {
            int x = 0;
            Random r = new Random();
            while (x != 3)
            {
                x = r.Next(1,15+1);
                Console.WriteLine(x);
            }
        }
    }
}