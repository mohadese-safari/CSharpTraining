using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Tuple.Create(15, "Sara");
            Person p = new Person(new BirthDate(2000));
            BirthDate d = p.BirthDate;
            p.BirthDate = null;
            Console.WriteLine(d.Year);
        }
    }
    class Person
    {
        public BirthDate BirthDate { get; set; }
        public Person(BirthDate birthDate)
        {
            BirthDate = birthDate;
        }
    }

    class BirthDate
    {
        public int Year { get; set; }
        public BirthDate(int year)
        {
            Year = year;
        }
    }
}
