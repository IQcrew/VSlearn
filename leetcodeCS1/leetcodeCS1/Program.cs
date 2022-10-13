using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeCS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] x = { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(x));
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            string res = strs[0];
            foreach (var item in strs.Skip(1))
            {
                if (item.StartsWith(res)) { continue;}
                else
                {
                    while (true)
                    {
                        if(res == "") { return ""; }
                        res = res.Remove(res.Length - 1);
                        if (item.StartsWith(res)) { break; }
                    }
                }
            }
            return res;
        }
    }
}
