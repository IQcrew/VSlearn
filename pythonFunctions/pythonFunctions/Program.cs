using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pythonFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> testik = new List<string> { "3213", "!š+ľšdsa", "dsadsa", "assdfbzbu", "ahoj", "hi"};
            Functions.cycle test = new Functions.cycle(testik);
            for (int i = 0; i < 41; i++)
            {
                Console.WriteLine(test.Next());
            }




            
        }

        
    }
}
