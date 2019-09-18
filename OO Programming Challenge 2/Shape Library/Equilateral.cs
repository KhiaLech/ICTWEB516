using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Library
{
    public class Equilateral : Triangle
    {

        public Equilateral(string sColour, double s1, double s2, double s3):base(sColour, s1, s2, s3)
        {
        }

        public double GetArea()
        {

            return (double)(1.73 * Side1 * Side1) / 4;
        }

    }
}
