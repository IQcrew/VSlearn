using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinDistance("intention","execution"));
            


        }
        public  static int MinDistance(string word1, string word2)
        {
            int temp = -1;
            int lenght = 0;
            List<int> d = new List<int>();
            for (int i = 0; i < word2.Length; i++)
            {
                if (word1.Contains(word2[i])) 
                {
                    temp = i;
                    d.Add(i);
                    if (word1.IndexOf(word2[i]) > temp)
                    {
                    }
                }
                else
                {
                    d.Add(-1);
                }
            }

            foreach (var item in d)
            {
                Console.WriteLine(item);
            }
            return lenght;
        }
    }
}
