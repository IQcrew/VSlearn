using System;
using System.Threading;

namespace MyFirstProgram
{
    
    class Program
    {

        static void Main(string[] args)
        {

            Thread mainThread = new Thread(() => underTreds());
            mainThread.Start();
            
            
            Console.WriteLine("Main Thred");
            Thread.Sleep(1000);
            Console.WriteLine("Main Thred");
            Thread.Sleep(1000);
            Console.WriteLine("Main Thred");
            Thread.Sleep(1000);
            Console.WriteLine("Main Thred");
            Thread.Sleep(1000);
            Console.WriteLine("Main Thred");
            Thread.Sleep(1000);

        }
        public static void CountDown()
        {
            
                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine("Timer #1 : " + i + " seconds");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Timer #1 is complete!");
            
        }
        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!");
        }
        //private static void reset(Thread tred)
        //{
        //    tred.Abort();
        //    tred = new Thread(CountDown);
        //    tred.Start();

        //}
        public static void underTreds()
        {
            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);
            thread1.Start();
            thread2.Start();
            thread1.Suspend();
            Thread.Sleep(4000);
            thread1.Resume();
        }
    }
}