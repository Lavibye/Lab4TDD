using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public abstract class Shape
    {
        public Point Center { get; set; }
        public string Color { get; set; }

        protected Shape(Point center)
        {
            Center = center;
        }

        public abstract void Move(double dx, double dy);
        public abstract void Resize(double factor);
    }
}
