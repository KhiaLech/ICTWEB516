using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Library
{
    public class Square : Quadrilateral
    {
        public Square(string sColour, int SideLength) : base(sColour, SideLength, SideLength, SideLength, SideLength)
        {

        }

        public double GetArea()
        {
            return Side1Length * Side1Length;
        }
    }
}
