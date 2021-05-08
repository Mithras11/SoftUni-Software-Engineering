using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;


        public Race(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;

            this.data = new List<Racer>(Capacity);

        }


        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count { get => this.data.Count; }


        public void Add(Racer racer)
        {
            if (data.Count < this.Capacity)
            {
                this.data.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            var currRacer = data.FirstOrDefault(r => r.Name == name);

            if (data.Contains(currRacer))
            {
                data.Remove(currRacer);

                return true;
            }

            return false;
        }

        public Racer GetOldestRacer()
        {
            if (data.Count > 0)
            {
                return data.OrderByDescending(c => c.Age).First();
            }

            return null;

        }

        public Racer GetRacer(string name)
        {
            var currRacer = data.FirstOrDefault(r => r.Name == name);

            if (data.Contains(currRacer))
            {
                return currRacer;
            }

            return null;
        }


        public Racer GetFastestRacer()
        {
            if (data.Count > 0)
            {
                return data.OrderByDescending(r => r.Car.Speed).First();
            }

            return null;

        }


        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Racers participating at {this.Name}:");

            foreach (var racer in this.data)
            {
                sb.AppendLine(racer.ToString());
            }

            return sb.ToString().Trim();
        }






    }





}

