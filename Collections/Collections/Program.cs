using System;
using System.Collections.ObjectModel;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<int> myCollection = new MyCollection<int>();
            myCollection.Add(6);
            Console.WriteLine(myCollection[0]);
        }
    }

    class MyCollection<T> : Collection<T>
    {
        public new void Add(T item)
        {
            base.Add((T)(object)1);
        }
    }
}
