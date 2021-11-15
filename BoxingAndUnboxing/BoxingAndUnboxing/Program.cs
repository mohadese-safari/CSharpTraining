using System;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 9;
            //object o = i;
            //object p = o;
            //Console.WriteLine(o);
            //o = 5.6;
            //Console.WriteLine(o);

            //i = 4;
            //Console.WriteLine(o);
            //Console.WriteLine(p);
            object o = 10;
            double d1 = (double)(int)o; // unbox and explicit cast
            double d2 = (int)o; //unbox and implicit cast
            double d3 = (double)o; // Exception

            object[] a2 = new object[] { 1, 2, 3 };
            a2[2] = 8;
            Console.WriteLine(a2[2]);
        }
    }
}
