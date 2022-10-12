using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Itertools;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            
            List<int> idkTest = new List<int> { 1,6,36,63,346,234,6432};

            watch.Start();
            IEnumerable<int> jop = Functions.Cycle<int>(idkTest);
            for (int i = 0; i < 18; i++)
            {
                Console.WriteLine(jop.AsParallel());
            }

            Thread.Sleep(1000);
            watch.Stop();
            watch.Restart();
            watch.Stop();

            Thread.Sleep(500);
            Console.WriteLine(watch.ElapsedMilliseconds.ToString());
            Console.WriteLine(watch.ElapsedMilliseconds.ToString());




        }
    }
}
