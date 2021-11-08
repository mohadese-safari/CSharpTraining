using System;

namespace StructsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point();
            //Point p2;
            //Point p3 = new Point(12,19);
            //p1.x = 3;
            //p1.y = 3;

            //p2 = p1;
            //p1.x = 8;
            //Console.WriteLine($"({p2.x},{p2.y})");
            //Console.WriteLine($"({p3.x},{p3.y})");

            //Gender g1 = Gender.Male;
            //Console.WriteLine((byte)g1);

            //Point p3 = new Point(2,3);
            //Console.WriteLine(p3);

            Circle c = new Circle(4,10);
            // Console.WriteLine(c);
            // Point p4 = c.Center;
            // Console.WriteLine(p4);
            c.Center.Color.B = 4;
            /* c.Center.x = 9;*/ //Compile error
            Console.WriteLine(c);
        }
    }

    public struct Circle
    {
        public Point Center { get; set; }
        public Circle(int x, int y)
        {
            Center = new Point(x, y);
        }
        public override string ToString()
        {
            return $"Circle[{Center}]";
        }
    }

    public struct Point
    {
        public int x, y;
        public Color Color { get; set; }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            Color = new Color(1, 1, 1);
        }

        public override string ToString()
        {
            return $"({x},{y},{Color})";
        }
    }

    public class Color
    {
        public Color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public override string ToString()
        {
            return $"RGB=({R},{G},{B})";
        }
    }
    public enum Gender : uint
    {
        Male = uint.MaxValue / 2 + 1,
        Female
    }
}
