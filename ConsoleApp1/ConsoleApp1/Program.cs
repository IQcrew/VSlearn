using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> hody = new List<int>();
            int hod = 0;
            while (hod != 6){
                hod = hod_kockou();
                hody.Add(hod);}
            Console.WriteLine("kockou sa hádzalo: " + hody.Count + "-krát");
            Console.Write("Jednotlivé hody boli: ");
            for (int i = 0; i<hody.Count; i++)
            {Console.Write(hody[i]+ " ");}
        }
        static int hod_kockou(){
            Random rand = new Random();
            int x = rand.Next(1, 7);
            return x;}
    }
}
