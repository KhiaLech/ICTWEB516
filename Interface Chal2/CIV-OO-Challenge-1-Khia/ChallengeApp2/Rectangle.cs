using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ChallengeApp2
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string sColour, int Length, int Width) : base(sColour, Length, Width, Length, Width)
        {
        }

        public int GetArea()
        {
            return Side1Length * Side2Length;
        }

    }
}
