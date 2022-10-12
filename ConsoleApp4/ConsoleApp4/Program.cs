using System;
using System.Collections.Generic;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tyzden = new string[,] { 
                 { "ANJ", "DEJ", "NEJ", "PRO", "PRO", "COW", "COW" },
                 { "PRX", "PRX", "PRX", "ELE", "CEE", "ANJ", "NBV" },
                 { "ANJ", "DEJ", "NEJ", "PRO", "PRO", "COW", "COW" },
                 { "ANJ", "DEJ", "NEJ", "PRO", "PRO", "COW", "COW" },
                 { "ANJ", "DEJ", "NEJ", "PRO", "PRO", "COW", "COW" }
            };
            Console.Write("zadaj hodinu: ");
            string user_input = Console.ReadLine();
            foreach (var den in tyzden)
            {
                Console.WriteLine(den);   
            }

        }

    }
}