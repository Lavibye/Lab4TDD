using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Point
    {
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public void Move(double dx, double dy)
    {
        X += dx;
        Y += dy;
    }

    public void Rotate(double angleInDegrees)
    {
        double angleInRadians = angleInDegrees * (Math.PI / 180);
        double newX = X * Math.Cos(angleInRadians) - Y * Math.Sin(angleInRadians);
        double newY = X * Math.Sin(angleInRadians) + Y * Math.Cos(angleInRadians);

        X = newX;
        Y = newY;
    }
    }
}
