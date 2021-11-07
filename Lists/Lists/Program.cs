using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "";
            char c = '\x049e';
            //Console.WriteLine(c);
            int? a = 7 < 2 ? 6 : (int?)null;
            Console.WriteLine("nullable int : {0}",a);
            List<int> list = new List<int>() { 2, 3, 4 };
            list.Add(1);
            list[2] = 78;
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);
            Console.WriteLine(list.Count);
        }
    }

    class Person
    {


    }
}
