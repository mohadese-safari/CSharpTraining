using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Person e1 = new Employee();
            //print(e);
            //print((Employee) e);
            //e1.SayHello();
            //((Employee)e1).SayHello();

            Shape s = new Circle(5);
            Type t = s.GetType();
            foreach (var p in t.GetProperties())
            {
                Console.WriteLine(p.Name);
            }

        }
        static void print(Person p)
        {
            Console.WriteLine("A person");
        }

        static void print(Employee e)
        {
            Console.WriteLine("An employee");
        }

    }

    abstract class Shape
    {

    }
    class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
    }
    class Person
    {
        public virtual void SayHello()
        {
            Console.WriteLine("Person says hello");
        }

    }

    class Employee : Person
    {
        public override void SayHello()
        {
            Console.WriteLine("Employee says hello");
        }

    }

    class Student : Person
    {

    }


}
