
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> data;

        public Bakery(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;

            this.data = new List<Employee>(Capacity); //??
        }


        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => this.data.Count;



        public void Add(Employee employee)
        {
            this.data.Add(employee);
        }

        public string Remove(string name)
        {
            if (this.data.Exists(e => e.Name == name))
            {
                this.data.RemoveAll(e => e.Name == name);
                return true.ToString();
            }

            return false.ToString();
        }


        public Employee GetOldestEmployee()
        {
            int highestAge = -1;

            Employee oldest = default(Employee);

            foreach (var employee in this.data)
            {
                if (employee.Age > highestAge)
                {
                    highestAge = employee.Age;

                    oldest = employee;
                }
            }

            return oldest;
        }


        public Employee GetEmployee(string name)
        {
            return this.data.FirstOrDefault(e => e.Name == name);
        }

               

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Employees working at Bakery {this.Name}:");

            foreach (var employee in this.data)
            {
                sb.AppendLine($"{employee.ToString()}");
            }

            return sb.ToString();

        }

    }
}
