using System;

namespace InterfaceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting.Run();
            IFlyable flyer = new Plane
            {
                Description = new PlaneDescription
                {
                    Name = "Bowing",
                    ConstructorCountry = "Russia"
                }
            };
            Console.WriteLine(flyer.Description);
            Plane p = (Plane)flyer;
            Console.WriteLine(  p.Description);

        }
    }

    interface IFlyable
    {
        string Description { get; }
        void fly();
    }

    class Plane : IFlyable
    {
        public PlaneDescription Description { get; set; }
        string IFlyable.Description
        {
            get
            {
                return "It can fly";

            }
        }

        void IFlyable.fly()
        {
            Console.WriteLine("Next flight : 13:30");
        }
    }

    class PlaneDescription
    {
        public string ConstructorCountry { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}\nConstructor:{ConstructorCountry}";
        }
    }
}
