using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine(MysteryFunc("A5B7"));
            static string MysteryFunc(string str)
            {
                string temp_string = "";
                for (int i = 0; i < str.Length; i++)
                {
                    if ("0123456789".Contains(str[i]))
                    {
                        for (int x = 0; x < int.Parse(str[i].ToString()); x++)
                        {
                            temp_string += str[(i - 1)];
                        }
                    }
                }
                return temp_string;
            }
        }
    }
}
