using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class EquilateralTriangle : Shape
    {
        public double SideLength { get; private set; }

        public EquilateralTriangle(Point center, double sideLength) : base(center)
        {
            SideLength = sideLength;
        }

        public override void Move(double dx, double dy)
        {
            Center.Move(dx, dy);
        }

        public override void Resize(double factor)
        {
            SideLength *= factor;
        }
    }
}
