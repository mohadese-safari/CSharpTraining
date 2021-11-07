using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(reverseString(str));
        }

      static string reverseString(string str)
        {
            string result = "";
            foreach (char ch in str)
            {
                result = ch + result;
            }
            return result;
        }
    }
}
