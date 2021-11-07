using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Constrcutors
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Console.WriteLine(c.Radius);
            Direction d = Direction.Top | Direction.Left;
            Console.WriteLine((d & Direction.Top) == Direction.Top);
            Console.WriteLine(d);

            var l = new List<Circle>()
            {
                new Circle(5),
                new Circle(2)
            };

            Console.WriteLine(l[0]);

            object o = new FileInfo(@"F:\SG C# course\beginner videos\09.mp4");

            Shape s = new Circle(5);
            Type t = s.GetType();
            foreach (var p in t.GetProperties())
            {
                Console.WriteLine(p.Name);
            }

        }
    }

    abstract class Shape
    {
        public abstract double Area();
    }


    class Circle : Shape
    {
        private int _radius;

        public Circle() : this(1)
        {
        }
        public Circle(int radius)
        {
            _radius = radius;
        }

        public int Radius
        {
            get
            {
                return _radius;
            }
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }


    enum Gender
    {
        Female,
        Male,
        Other
    }
    class GenderOperations
    {
        public String GenderToText(Gender gender)
        {
            switch (gender)
            {
                case Gender.Female:
                    return "زن";
                case Gender.Male:
                    return "مرد";
                case Gender.Other:
                    return "سایر";
                default:
                    return "نامعلوم";
            }
        }
    }

    [Flags]
    public enum Direction : byte
    {
        Top = 1,
        Bottom = 2,
        Left = 4,
        Right = 8
    }

}
