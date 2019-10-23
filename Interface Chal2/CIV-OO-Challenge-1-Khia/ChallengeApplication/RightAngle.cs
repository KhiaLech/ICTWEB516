using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Library
{
    public class RightAngleTriangle : Triangle
    {
        public RightAngleTriangle(string sColour, double s1, double s2) : base(sColour, s1, s2, (double)Math.Sqrt(s1 * s1 + s2 * s2))
        {

        }

        public double GetArea()
        {

            return (0.5 * Side1Length * Side2Length * Math.Sqrt(Side1Length * Side1Length + Side2Length * Side2Length));
        }
    }
}
