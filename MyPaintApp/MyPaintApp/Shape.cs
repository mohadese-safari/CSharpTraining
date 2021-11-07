using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaintApp
{
    public abstract class Shape : DrawingTool
    {
        public Shape(Point position,Color color)
        {
            Position = position;
            Color = color;
        }

        Point Position
        {
            get;set;
        }

        Color Color
        {
            get;set;
        }
        public abstract void Draw();

    }
}
