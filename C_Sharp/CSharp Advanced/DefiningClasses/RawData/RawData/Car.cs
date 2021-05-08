using System;

namespace RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tire[] Tires { get; set; }

        public Car(string model,
            int speed, int power,
            int weight, string type,
            double pressure1, int age1,
            double pressure2, int age2,
            double pressure3, int age3,
            double pressure4, int age4)
        {

            this.Model = model;
            this.Engine = new Engine(speed, power);
            this.Cargo = new Cargo(weight, type);
            this.Tires = new Tire[]
            {
                 new Tire(pressure1,age1),
                 new Tire(pressure2,age2),
                 new Tire(pressure3,age3),
                 new Tire(pressure4,age4)

            };

        }
    }
}
