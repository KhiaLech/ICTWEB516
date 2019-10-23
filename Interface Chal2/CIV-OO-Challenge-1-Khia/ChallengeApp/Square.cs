using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ChallengeApp1
{
    public class Square : Quadrilateral
    {
        public Square(string sColour, int SideLength) : base(sColour, SideLength, SideLength, SideLength, SideLength)
        {
        }

        public int GetArea()
        {
            return Side1Length * Side1Length;
        }
    }
}
