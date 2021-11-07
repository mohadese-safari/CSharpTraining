using System;

namespace NestedTypes
{
    public delegate void PersonAbilities();
    public delegate TResult GenericDelegate<T, TResult>(params T[] parameters);
    class Program
    {
        static void Main(string[] args)
        {
            //Test1
            //Console.WriteLine(DefaultTest<int>());

            //Test 2
            //Person p1 = new Person();
            //DefaultTest<Person>(p);

            //Test3
            //Person p2 = new Person();
            //PersonAbilities personAbilities = p2.sayHello;
            //personAbilities.Invoke();

            GenericDelegate<int, int> genericAdd = Add;
            int res = genericAdd(4,5,1,-4);
            Console.WriteLine(res);
        }

        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach(int i in numbers)
            {
                sum += i;
            }
            return sum;
        }

        public static T DefaultTest<T>(T t) where T : Person, new()
        {
            t.sayHello();
            return default(T);
        }
    }

    class Person
    {
        public void sayHello()
        {
            Console.WriteLine("Hi");
        }
    }
}