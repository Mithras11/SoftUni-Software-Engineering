using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = data[0];
                int engineSpeed = int.Parse(data[1]);
                int enginePower = int.Parse(data[2]);
                int cargoWeight = int.Parse(data[3]);
                string cargoType = data[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                cars.Add(new Car(model, engine, cargo));

            }


            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<Car> fragileCars = cars.Where(x => x.Cargo.Type == "fragile" && x.Cargo.Weight < 1000).ToList();

                foreach (Car car in fragileCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")
            {
                List<Car> flamableCars = cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250).ToList();

                foreach (Car car in flamableCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }

        public class Car
        {
            public string Model { get; set; }
            public Engine Engine { get; set; }
            public Cargo Cargo { get; set; }

            public Car(string model, Engine engine, Cargo cargo)
            {
                this.Model = model;
                this.Engine = engine;
                this.Cargo = cargo;
            }
        }

        public class Engine
        {
            public int Speed { get; set; }
            public int Power { get; set; }

            public Engine(int speed, int power)
            {
                this.Speed = speed;
                this.Power = power;
            }
        }

        public class Cargo
        {
            public string Type { get; set; }
            public int Weight { get; set; }

            public Cargo(int weight, string type)
            {
                this.Weight = weight;
                this.Type = type;

            }
        }
    }
}
