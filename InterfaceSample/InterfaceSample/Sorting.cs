using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    class Sorting
    {
        public static void Run()
        {
            var persons = new List<Person> {
             new Person
            {
                FirstName = "Ayda",
                LastName = "Karimi"
            },

             new Person
            {
                FirstName = "Ali",
                LastName = "Amini"
            }
        };
            var c = Comparer<Person>.Default;
            persons.Sort();           
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
