using System;

namespace RawData
{
    public class Tire
    {
        private double pressure;
        private int age;

        public double Pressure { get; set; }
        public int Age { get; set; }

        public Tire(double pressure, int age)

        {
            this.Pressure = pressure;
            this.Age = age;
        }
    }
}
