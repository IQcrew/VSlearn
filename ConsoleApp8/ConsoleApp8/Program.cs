using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            Item idk = new Item{};

            idk.xy();
        }
    }


    class Item
    {
        public int x = 3;

        public void xy()
        {
            Console.WriteLine(x);
        }

    }

}
