using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Library
{
    public class RightAngle : Triangle
    {
        public RightAngle(string sColour, double s1, double s2) : base(sColour, s1, s2, (float)Math.Sqrt(s1 * s1 + s2 * s2))
        {

        }

        public double GetArea()
        {

            return (double)(0.5 * Side1 * Side2);
        }
    }
}
}
