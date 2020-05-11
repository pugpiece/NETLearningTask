using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cube
{
    class Point
    {
        private double y;
        public double Y {set { y = value; } get { return y; }}
        private double x;
        public double X { set { x = value; } get { return x; } }
        private double z;
        public double Z { set { z = value; } get { return z; } }

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return X + " " + Y + " " + Z;
        }

        public double DotLength(Point dot)
        {
            double squaresumx = Math.Pow((this.X - dot.X), 2);
            double squaresumy = Math.Pow((this.Y - dot.Y), 2);
            double squaresumz = Math.Pow((this.Z - dot.Z), 2);
            return Math.Sqrt(squaresumx + squaresumy + squaresumz);
        }


    }
}
