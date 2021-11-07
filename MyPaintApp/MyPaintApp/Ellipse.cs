using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaintApp
{
    class Ellipse : Shape
    {
        public int Radius
        {
            get;set;
        }
        public Ellipse(Point position, Color color,int radius) : base(position, color)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
