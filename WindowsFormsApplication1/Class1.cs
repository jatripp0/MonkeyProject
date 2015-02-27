using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyProject
{
    class ShapeCalculator
    {
        static public double PointDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(
                Math.Pow((x2 - x1), 2)
                + Math.Pow((y2 - y1), 2));
        }

        static public double PointDistance(Point p1, Point p2)
        {
            return Math.Sqrt(
                Math.Pow((p1.X - p2.X), 2)
                + Math.Pow((p1.Y - p2.Y), 2));
        }

    }
}
