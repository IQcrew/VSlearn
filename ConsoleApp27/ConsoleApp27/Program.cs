using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool value = false;
            var watch = new System.Diagnostics.Stopwatch();
            string idk = "takze string na porovnanie";
            watch.Start();

            for (int i = 0; i < 1000000000; i++)
            {
                if (idk == "takze string na porovnanie")
                {
                    value = true;
                }
                else
                {
                    value = false;
                }
            }

            watch.Stop();
            Console.WriteLine("petov sposob: "+watch.ElapsedMilliseconds.ToString());
            value = false ;

            watch.Restart();
            watch.Start();
            for (int i = 0; i < 1000000000; i++)
            {
                value = idk == "takze string na porovnanie";
            }
            
            watch.Stop();
            Console.WriteLine("tobov sposob: " + watch.ElapsedMilliseconds.ToString());
            
        }
    }
}
