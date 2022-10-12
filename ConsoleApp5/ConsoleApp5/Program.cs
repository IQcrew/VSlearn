using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = Create5Numbers();
            Console.WriteLine(GetSecond(x));


        }
        static double[] Create5Numbers()
        {
            double[] cisla = { 5.42, 5.12, 1.54, 9.74, 2.54 };
            return cisla;
        }

        static double GetSecond(double[] numbers)
        {
            return numbers[1];
        }
    }
}
