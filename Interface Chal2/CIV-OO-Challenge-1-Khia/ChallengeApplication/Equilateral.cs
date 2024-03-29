﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Library
{
    public class Equilateral : Triangle
    {
        public Equilateral(string sColour, double s1, double s2, double s3) : base (sColour, s1, s2, s3)
        {
            Side1Length = s1;
            Side2Length = s2;
            Side3Length = s3;
        }

        public double GetArea()
        {

            return Math.Sqrt(3)/(4) * (Side1Length * Side1Length);
        }
    }
}
