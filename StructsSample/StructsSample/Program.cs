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
            Gender g1 = Gender.Male;
            Console.WriteLine((byte)g1);
            
        }
    }

    struct Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public enum Gender : uint
    {
        Male = uint.MaxValue / 2 + 1,
        Female
    }
}
