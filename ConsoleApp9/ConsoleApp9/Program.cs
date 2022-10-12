using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLongestCommonSequence("mojstriko", "ladstrik"));
        }
        static string GetLongestCommonSequence(string str1, string str2)
        {
            string temp_string = "";
            string biggest_string = "";
            for (int i = 0; i < str1.Length; i++)
            {
                temp_string = "";
                for (int x = i; x < str1.Length; x++)
                {
                    temp_string += Convert.ToString(str1[x]);
                    if (str2.Contains(temp_string))
                    {
                        if (temp_string.Length > biggest_string.Length)
                        {
                            biggest_string = temp_string;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return biggest_string;
        }



    }
}
