using System;
using System.Diagnostics.Contracts;

namespace MethodsDefaultParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Sqrt(8,3));
            // Console.WriteLine(Sqrt(number: 16, rootBase: 4));
            Console.WriteLine(Add(2,4,9,1));
        }

        public static double Sqrt(double number, int rootBase = 2)
        {
            return Math.Pow(number, (1.0 / rootBase));
        }

        public static double Sqrt(double number)
        {
            return Math.Pow(number, (1 / 2.0));
        }

        public static int Add(params int[] nums)
        {
            int sum = 0;
            foreach(int n in nums)
            {
                sum += n;
            }
            return sum;
        }
    }
}
