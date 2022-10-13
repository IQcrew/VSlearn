 using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCS_StockProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(MaxProfit(x));

        }

        public static int MaxProfit(int[] prices)
        {
            int res = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                int t = prices[i]-prices[i-1];
                res += t>0 ? t : 0;
            }
            return res;
        }
    }
}
