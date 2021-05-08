using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();

                string model = data[0];
                int speed = int.Parse(data[1]);
                int power = int.Parse(data[2]);
                int weight = int.Parse(data[3]);
                string type = data[4];
                double pressure1 = double.Parse(data[5]);
                int age1 = int.Parse(data[6]);
                double pressure2 = double.Parse(data[7]);
                int age2 = int.Parse(data[8]);
                double pressure3 = double.Parse(data[9]);
                int age3 = int.Parse(data[10]);
                double pressure4 = double.Parse(data[11]);
                int age4 = int.Parse(data[12]);

                var car = new Car(model,
                    speed, power,
                    weight, type,
                    pressure1, age1,
                    pressure2, age2,
                    pressure3, age3,
                    pressure4, age4);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == "fragile"))
                {
                    if (car.Tires.Any(t => t.Pressure < 1))
                    {
                        Console.WriteLine($"{car.Model}");
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == "flamable")
                    .Where(c => c.Engine.Power > 250))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}
