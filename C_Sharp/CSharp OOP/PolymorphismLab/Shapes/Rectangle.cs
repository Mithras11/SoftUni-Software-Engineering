using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }



        public double Height { get; private set; }

        public double Width { get; private set; }




        public override double CalculateArea()
        {
            double result = this.Height * this.Width;

            return result;
        }

        public override double CalculatePerimeter()
        {
            double result = 2 * this.Height + 2 * this.Width;

            return result;
        }


        public override string Draw()
        {
            return $"{base.Draw()} {this.GetType().Name}";
        }


    }
}
