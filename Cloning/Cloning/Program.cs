using System;
using System.Collections.Generic;

namespace Cloning
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee(2, "e1", "e1", new Birthdate(1, 1, 1));
            Employee e2 = new Employee(3, "e2", "e2", new Birthdate(2, 2, 2));
            Employee boss = new Employee(1, "Boss", "Boss", new Birthdate(1380, 1, 1),
                new List<Employee> {
                e1,e2
                });

            Employee bossClone = (Employee)boss.Clone();
            bossClone.FirstName = "BossCloned";
            Console.WriteLine($"Source boss : {boss}");
            Console.WriteLine($"Cloned boss : {bossClone}");
            bossClone.Workers[0] = e2;
            Console.WriteLine(boss.Workers[0]);
            Console.WriteLine(bossClone.Workers[0]);
        }
    }

    class Employee : ICloneable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Birthdate Birthdate { get; set; }
        public List<Employee> Workers { get; set; }
        public string FullName { get; set; }

        public Employee(int id, string firstName, string lastName, Birthdate birthdate, List<Employee> workers)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            Workers = workers;
        }

        public Employee(int id, string firstName, string lastName, Birthdate birthdate)
            : this(id, firstName, lastName, birthdate, new List<Employee>())
        {
        }

        public object Clone()
        {
            List<Employee> workersCloned = new List<Employee>();
            foreach (Employee employee in Workers)
            {
                workersCloned.Add((Employee)employee.Clone());
            }
            return new Employee(Id, FirstName, LastName, Birthdate, workersCloned);
        }

        public override string ToString()
        {
            return $"Id={Id}, FirstName={FirstName}, LastName={LastName}, Birthdate={Birthdate}";
        }
    }

    struct Birthdate : ICloneable
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public Birthdate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public override string ToString()
        {
            return $"{Year}-{Month}-{Day}";
        }

        public object Clone()
        {
            return new Birthdate(Year, Month, Day);
        }
    }
}
