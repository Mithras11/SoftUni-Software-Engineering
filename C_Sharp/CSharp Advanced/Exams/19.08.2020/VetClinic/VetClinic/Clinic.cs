using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Pet>(Capacity);
        }

        public int Capacity { get; private set; }

        public int Count { get => this.data.Count; }


        public void Add(Pet pet)
        {
            this.data.Add(pet);

        }


        public bool Remove(string name)
        {

            if (this.data.Any(p => p.Name == name))
            {
                var petToRemove = this.data.FirstOrDefault(p => p.Name == name);

                this.data.Remove(petToRemove);

                return true;
            }

            return false;

        }


        public Pet GetPet(string name, string owner)
        {

            return this.data.FirstOrDefault(p => p.Name == name && p.Owner == owner);


        }


        public Pet GetOldestPet()
        {
            return this.data.OrderByDescending(p => p.Age).First();

        }

        public string GetStatistics()
        {
            var sb = new StringBuilder();

            sb.AppendLine("The clinic has the following patients:");

            foreach (var pet in this.data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: { pet.Owner}");
            }


            return sb.ToString().TrimEnd();

        }

    }

}
