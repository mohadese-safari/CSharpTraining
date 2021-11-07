using System;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int @base = int.Parse(Console.ReadLine());
            PrintLeftwardTriangle(@base);
            PrintRightwardTriangle(@base);

        }

        static void PrintLeftwardTriangle(int @base)
        {
            for (int i = @base; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void PrintRightwardTriangle(int @base)
        {
            for (int i = 0; i < @base; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < @base - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static int factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * factorial(n - 1);
        }

    }

}
