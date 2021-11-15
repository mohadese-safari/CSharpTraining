using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            var persons = GetPersons();
            var query1 = persons.OrderByDescending(p => p.LastName).ThenBy(p => p.FirstName).Where(p => p.Age > 13);
            var query2 = from person in GetPersons()
                         orderby person.LastName descending, person.FirstName
                         where person.Age > 13
                         select person;


            foreach (var p in query2)
            {
                Console.WriteLine(p);
            }

        }
        public static List<Person> GetPersons()
        {
            return new List<Person>
            {
                new Person(){ FirstName ="Nazi",LastName ="Saeedi",Age =18},
                new Person(){ FirstName ="Omid",LastName ="Rezaei",Age =10},
                new Person(){ FirstName ="Ava",LastName ="Zamani",Age =11},
                new Person(){ FirstName ="Delvin",LastName ="Saeedi",Age =33}
            };
        }

    }
    class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
