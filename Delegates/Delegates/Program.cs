using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        public delegate int NumberOperation(int a, int b);
        public delegate int SequentialNumberOperation(int a, int b);
        static void Main(string[] args)
        {
            //Beginner
            //NumberOperation numberOperation = new NumberOperation( Multiply);
            // NumberOperation numberOperation = Multiply;
            //Console.WriteLine(numberOperation(1, 8));
            //SequentialNumberOperation ops = new SequentialNumberOperation(Add) + new SequentialNumberOperation(Multiply);

            //Advanced
            Func<int, bool> isEven = (int i) => i % 2 == 0;

            int i = 1;
            Action loopTest = new Action(
                () => Console.WriteLine(i)
                );

            //for ( i = 1; i < 10; i++)
            //{
         
            loopTest += () => Console.WriteLine(i);
            i = 10;
            //}
            //i += 10;
            loopTest();
            

            //Using lambda
            //Action loopTest2 = new Action(
            //    () => Console.WriteLine(1)
            //    );
            //for ( i = 1; i < 10; i++)
            //{
            //    loopTest2 += () =>
            //    {
            //        Console.WriteLine(i);
            //    };
            //}
            //loopTest2();

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static void sayHi(int i)
        {
            Console.WriteLine("hi" + i);
        }
    }

}
