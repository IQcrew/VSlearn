using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal static class random_plus
    {
        static Random random = new Random();
        public static int Next(int maxNum)
        {
            return random.Next(maxNum);
        }
    }
}
