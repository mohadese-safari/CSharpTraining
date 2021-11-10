using System;
using System.Collections;
using System.Collections.Generic;

namespace Variance
{
    class Program
    {
        static void Main(string[] args)
        {
            void GetAction(Action<Animal> action)
            {
                action(new Cat());

            }

            void GetAction2(Action<Cat> action)
            {
                action(new PersianCat());

            }
            void MyDog(Dog dog)
            {

            }

            void MyAnimal(Animal animal)
            {

            }

            GetAction(MyDog);
            GetAction2(MyAnimal);

        }

    }

    class Animal
    {

    }
    class Dog : Animal
    {

    }
    class Cat : Animal
    {

    }

    class PersianCat : Cat
    {

    }
}
