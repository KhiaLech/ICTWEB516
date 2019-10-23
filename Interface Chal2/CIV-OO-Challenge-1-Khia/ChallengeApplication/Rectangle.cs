using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Shape_Library
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string sColour, double Length, double Width) : base(sColour, Length, Width, Length, Width)
        {
        }

        public double GetArea()
        {
            return Side1Length * Side2Length;
        }

       

        public override string ToString()
        {
            return Colour + ", " + Side1Length * Side2Length;
        }

    }
}
