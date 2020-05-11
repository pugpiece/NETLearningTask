using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cube
{
    class Cube
    {
        private List<Point> dots = new List<Point>(8);
        private double length;
        public double Length { set { length = value; } get { return length; } }

        public Cube(List<double> new_dots)
        {
                dots.Add(new Point(new_dots[0], new_dots[1], new_dots[2]));
                dots.Add(new Point(new_dots[3], new_dots[4], new_dots[5]));
                Length = Math.Round(dots[1].DotLength(dots[0]),5);
                double Length2 = Math.Round(Math.Sqrt(Length * Length + Length * Length),5);
                double Length3 = Math.Round(Math.Sqrt(Length2 * Length2 + Length * Length),5);


                for (int i = 6; i < new_dots.Count(); i += 3)
                {
                    Point temp_dot = new Point(new_dots[i], new_dots[i + 1], new_dots[i + 2]);
                    foreach (Point dot in dots)
                    {
                        double tempLength = Math.Round(temp_dot.DotLength(dot),5);
                        if ((tempLength != Length) && (tempLength != Length2) && (tempLength != Length3) && (tempLength != 0))
                        {
                            throw new System.ArgumentException("This list of dots can't be interprited as a cube. Better luck next time :^)");
                        }
                    }
                    dots.Add(new Point(new_dots[i], new_dots[i + 1], new_dots[i + 2]));
                }
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, dots);
        }

        public double Volume()
        {
            return Math.Pow(Length, 3);
        }

        public double SurfaceArea()
        {
            return Length*Length*6;
        }
        
    }
}
