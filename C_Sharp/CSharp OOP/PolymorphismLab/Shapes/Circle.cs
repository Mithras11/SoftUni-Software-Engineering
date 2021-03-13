using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; private set; }

        public override double CalculateArea()
        {
            double result = Math.PI * this.Radius * this.Radius;
            return result;
        }

        public override double CalculatePerimeter()
        {
            double result = Math.PI * 2 * this.Radius;
            return result;
        }

        public override string Draw()
        {
            return $"{base.Draw()} {this.GetType().Name}";
        }
    }
}
