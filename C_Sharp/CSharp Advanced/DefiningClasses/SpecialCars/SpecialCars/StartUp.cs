using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> allTires = new List<Tire[]>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tireInfo = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Tire[] currentTires = new Tire[4]
                {
                    new Tire(int.Parse(tireInfo[0]),double.Parse(tireInfo[1])),
                    new Tire(int.Parse(tireInfo[2]),double.Parse(tireInfo[3])),
                    new Tire(int.Parse(tireInfo[4]),double.Parse(tireInfo[5])),
                    new Tire(int.Parse(tireInfo[6]),double.Parse(tireInfo[7])),

                };

                allTires.Add(currentTires);
            }

            List<Engine> engines = new List<Engine>();

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfo = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Engine currentEngine = new Engine(int.Parse(engineInfo[0]), double.Parse(engineInfo[1]));

                engines.Add(currentEngine);
            }

            List<Car> cars = new List<Car>();

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                Engine engine = engines[engineIndex];
                Tire[] tires = allTires[tiresIndex];



                var currentCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);


                cars.Add(currentCar);
            };

            FindSpecialCars(cars);

        }

        public static void FindSpecialCars(List<Car> cars)
        {
            cars = cars.Where(x => x.Year >= 2017)
                .Where(x => x.Engine.HorsePower > 330)
                .Where(x => x.Tires.Sum(y => y.Pressure) >= 9)
                .Where(x => x.Tires.Sum(y => y.Pressure) <= 10)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var car in cars)
            {

                car.Drive(20);
                sb.AppendLine($"Make: {car.Make}");
                sb.AppendLine($"Model: {car.Model}");
                sb.AppendLine($"Year: {car.Year}");
                sb.AppendLine($"HorsePowers: {car.Engine.HorsePower}");
                sb.AppendLine($"FuelQuantity: {car.FuelQuantity}");
            }

            Console.WriteLine(sb.ToString());





        }
    }
}
