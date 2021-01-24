using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();


            while (input != "end")
            {
                List<string> data = input.Split("/").ToList();

                if (data[0] == "Truck")
                {
                    Truck currentTruck = new Truck(data[1], data[2], int.Parse(data[3]));
                    trucks.Add(currentTruck);
                }
                else
                {
                    Car currentCar = new Car(data[1], data[2], int.Parse(data[3]));
                    cars.Add(currentCar);
                }
                input = Console.ReadLine();
            }

            trucks = trucks.OrderBy(truck => truck.Brand).ToList();
            cars = cars.OrderBy(car => car.Brand).ToList();

            if (cars.Count == 0)
            {

            }
            else
            {
                Console.WriteLine("Cars:");

                foreach (Car car in cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }

            }

            if (trucks.Count == 0)
            {

            }
            else
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");

                }

            }



        }

        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }

            public Truck(string brand, string model, int weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }
        }

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }

            public Car(string brand, string model, int horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }
        }

        public class Catalogue
        {
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();
        }
    }
}
