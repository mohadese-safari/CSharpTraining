using System;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {

            //Shallow copy
            int newValue = 6;
            int[] a = new int[5] { 1, 2, 3, 4, 5 };

            int[] b = new int[a.Length + 1];

            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
            b[a.Length] = newValue;
            a = b;

            Console.Write("b : ");
            foreach (int n in b)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();


            //Deep copy
            int[] c = new int[a.Length + 1];
            a.CopyTo(c, 0);

            Console.Write("c : ");
            foreach (int n in c)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            //Modifing source array
            a[0] = 9;
            Console.WriteLine("a[0]={0}, b[0]={1}, c[0]={2}", a[0], b[0], c[0]);

        }
    }
}
