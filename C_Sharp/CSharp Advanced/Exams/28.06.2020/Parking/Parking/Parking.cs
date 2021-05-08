using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public Parking(string type, int capacity)
        {
            data = new List<Car>(Capacity);
            Type = type;
            Capacity = capacity;
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public int Count { get => data.Count; }



        public void Add(Car car)
        {
            if (data.Count < this.Capacity)
            {
                data.Add(car);

            }

        }

        public bool Remove(string manufacturer, string model)
        {
            var currCar = data.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);

            if (data.Contains(currCar))
            {
                data.Remove(currCar);

                return true;
            }

            return false;
        }


        public Car GetLatestCar()
        {
            if (data.Count > 0)
            {
                return data.OrderByDescending(c => c.Year).First();
            }

            return null;

        }


        public Car GetCar(string manufacturer, string model)
        {
            var currCar = data.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);

            if (data.Contains(currCar))
            {
                return currCar;
            }

            return null;
        }


        public string GetStatistics()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"The cars are parked in {this.Type}:");

            foreach (var car in this.data)
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
