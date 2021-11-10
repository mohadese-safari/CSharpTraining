using System;
using System.Collections;

namespace Enummerators
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenNumbers evenNumbers = new EvenNumbers();
           foreach(int i in evenNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }

    class EvenNumbers : IEnumerable
    {
        const int First = 2;
        public IEnumerator GetEnumerator()
        {
            int current = First;
            while (true)
            {                
                yield return current;
                current += 2;
            }
        }
    }
}
