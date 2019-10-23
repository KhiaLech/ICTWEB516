using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Library
{
    public class Circle : Shape
    {
        public double Pi { get; set; }
        public double Radius { get; set; }


        public Circle(string sColour, double pi, double r) : base (sColour)
        {
            Pi = pi;
            Radius = r;
        }

        public double GetPerimeter()
        {
            return (2 * Pi * Radius);
        }

        public double GetArea()
        {
            return Pi * (Radius * Radius);
        }

        public override string ToString()
        {
            return Colour + ", " + Pi * (Radius * Radius);
        }
    }
}
