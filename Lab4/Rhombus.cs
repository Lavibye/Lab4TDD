using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Rhombus : Shape
    {
        public double DiagonalX { get; private set; }
        public double DiagonalY { get; private set; }

        public Rhombus(Point center, double diagonalX, double diagonalY) : base(center)
        {
            DiagonalX = diagonalX;
            DiagonalY = diagonalY;
        }

        public override void Move(double dx, double dy)
        {
            Center.Move(dx, dy);
        }

        public override void Resize(double factor)
        {
            DiagonalX *= factor;
            DiagonalY *= factor;
        }
    }
}
