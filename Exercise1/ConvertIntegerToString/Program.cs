using System;

namespace ConvertIntegerToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertIntToString(43243871));
        }

        static string ConvertIntToString(int number)
        {
            string result = "";
            while (number > 0)
            {
                result = number % 10 + result;
                number /= 10;
            }
            return result;
        }
    }
}
