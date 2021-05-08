using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        //fields
        private double length;
        private double width;
        private double height;


        //constructor

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        //properties
        public double Length
        {
            get { return this.length; }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value;
            }
        }



        public double Width
        {
            get { return width; }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }



        public double Height
        {
            get { return height; }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }



        //methods

        public void GetSurfaceArea()
        {
            //Surface Area = 2lw + 2lh + 2wh

            double l = this.Length;
            double w = this.Width;
            double h = this.Height;


            double area = (2 * l * w) + (2 * l * h) + (2 * w * h);

            Console.WriteLine($"Surface Area - {area:F2}");
        }


        public void GetLateralSurfaceArea()
        {
            //Lateral Surface Area = 2lh + 2wh

            double l = this.Length;
            double w = this.Width;
            double h = this.Height;


            double area = (2 * l * h) + (2 * w * h);

            Console.WriteLine($"Lateral Surface Area - {area:F2}");
        }


        public void GetVolume()
        {
            //Volume = lwh

            double l = this.Length;
            double w = this.Width;
            double h = this.Height;

            double volume = l * w * h;

            Console.WriteLine($"Volume - {volume:F2}");
        }





    }
}
