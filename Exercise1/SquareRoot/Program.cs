using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double d;
            bool isValidPositiveDouble;
            do
            {
                Console.WriteLine("Enter a valid positive number :");
                isValidPositiveDouble = double.TryParse(Console.ReadLine(),out d);
            } while (!isValidPositiveDouble);
            Console.WriteLine("Square root is : {0:.##}",Math.Sqrt(d));
            
        }
    }
}
