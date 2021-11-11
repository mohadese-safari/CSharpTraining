using System;
using System.Collections;

namespace Enummerators
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenNumbers evenNumbers = new EvenNumbers(100);
            foreach (int i in evenNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }

    class EvenNumbers : IEnumerable
    {
        public const int First = -2;
        public int Limit { get; private set; }
        public EvenNumbers(int limit)
        {
            Limit = limit;
        }

        public IEnumerator GetEnumerator()
        {
            return new EvenNumberEnummerator(Limit);
        }

        /*
        public IEnumerator GetEnumerator()
        {
            int current = First;
            while (true)
            {
                yield return current;
                current += 2;
            }
        }
        */
    }

    class EvenNumberEnummerator : IEnumerator
    {
        public int Limit { get; private set; }
        public int Count { get; set; } = EvenNumbers.First;
        public EvenNumberEnummerator(int limit)
        {
            Limit = limit;
        }
        public object Current
        {
            get
            {
                if (Count > Limit)
                {
                    throw new InvalidOperationException("No current");
                }
                return Count;
            }
        }

        public bool MoveNext()
        {
            Count += 2;
            return Count <= Limit;
        }

        public void Reset()
        {
            Count = EvenNumbers.First;
        }
    }
}
