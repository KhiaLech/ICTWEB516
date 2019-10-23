using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Shape_Library
{
    public class Square : Quadrilateral
    {
        public Square(string sColour, double SideLength) : base(sColour, SideLength, SideLength, SideLength, SideLength)
        {

        }

        public double GetArea()
        {
            return Side1Length * Side1Length;
        }

        public override string ToString()
        {
            return Colour + ", " + Side1Length * Side1Length;
        }

     
    }
}
