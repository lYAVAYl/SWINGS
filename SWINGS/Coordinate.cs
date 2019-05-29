﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWINGS
{
    class Coordinate
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double Z1 { get; set; }

        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double Z2 { get; set; }

        public Coordinate(double x1, double y1, double z1,
                          double x2, double y2, double z2)
        {
            X1 = x1; Y1 = y1; Z1 = z1;
            X2 = x2; Y2 = y2; Z2 = z2;
        }
    }
}
