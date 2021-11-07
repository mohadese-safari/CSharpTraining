using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        public delegate int NumberOperation(int a, int b);
        public delegate int SequentialNumberOperation(int a,int b);
        static void Main(string[] args)
        {
            NumberOperation numberOperation = Multiply;
            Console.WriteLine(numberOperation(1,8));
            SequentialNumberOperation ops = new SequentialNumberOperation(Add) + new SequentialNumberOperation(Multiply);
            
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    
}
