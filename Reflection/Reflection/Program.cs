using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly info = typeof(int).Assembly;
            var info2 = typeof(int).IsNestedAssembly;
            Console.WriteLine(info);
            Console.WriteLine(info2);
        }

        internal static void InternalMethod()
        {

        }
    }
}
