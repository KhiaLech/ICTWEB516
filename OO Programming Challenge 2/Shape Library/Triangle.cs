using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Library
{
    public class Triangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(string sColour, double s1, double s2, double s3): base(sColour)
        {
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
        }

        public double GetPerimeter()
        {

            return Side1 + Side2 + Side3;
        }
    }
}
