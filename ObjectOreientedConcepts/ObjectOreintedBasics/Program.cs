using System;

namespace ObjectOreintedBasics
{
    class Program
    {

        static void Main(string[] args)
        {

            //var x = (double)5.ToString().Length / 2;



            //float i = 5f / 2;
            //Console.WriteLine(i);
            //double a = 13.8;
            //Console.WriteLine("{0:F2}", a);
            
            Console.WriteLine("Hello World!");

            Wierd.b = 9;
        }
    }

    public class Wierd
    {
        static int a = setA();
        public static int b;
        static int setA()
        {
            Console.WriteLine("A is inited");
            return 6;
        }
    }
}
