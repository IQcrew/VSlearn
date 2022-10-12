using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string data = @" [ {""name"": ""John Doe"", ""occupation"": ""gardener""},  {""name"": ""Peter Novak"", ""occupation"": ""driver""} ]";

            JsonDocument doc = JsonDocument.Parse(data);
            JsonElement root = doc.RootElement;

            Console.WriteLine(root);

            var u1 = root[0];
            var u2 = root[1];
            Console.WriteLine(u1);
            Console.WriteLine(u2);

            Console.WriteLine(u1.GetProperty("name"));
            Console.WriteLine(u1.GetProperty("occupation"));

            Console.WriteLine(u2.GetProperty("name"));
            Console.WriteLine(u2.GetProperty("occupation"));
            
            



        }
    }
}
