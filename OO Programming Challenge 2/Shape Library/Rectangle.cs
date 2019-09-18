using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Library
{
    public class Rectangle : Quadrilateral
    {

        public Rectangle(string sColour, int Length, int Width) : base(sColour, Length, Width, Length, Width)
        {
        }

        public double GetArea()
        {
            return Side1Length * Side2Length;
        }
    }
}
