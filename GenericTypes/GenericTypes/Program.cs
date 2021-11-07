using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<Adress, Person>();
            var adress1 = new Adress("Iran", "Teh");
            var adress2 = new Adress("Fars", "Shiraz");
            var p1 = new Person(adress1, "Sima");
            var p2 = new Person(adress2, "Amir");
            dict.Add(adress1, p1);
            dict.Add(adress2, p2);
            Console.WriteLine( dict[adress1]);
            object

        }

        static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }

    class Person : IComparable<Person>
    {
        public Person(Adress adress, string name) 
        {
            Adress = adress;
            Name = name;
        }
        public Adress Adress { get; set; }
        public string Name { get; set; }

        public int CompareTo([AllowNull] Person other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Name : {Name}";
        }
    }
    class Adress
    {
        public Adress(string city, string street)
        {
            City = city;
            Street = street;
        }
        public string Street { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"city : {City}, street : {Street} ";
        }
    }
}
