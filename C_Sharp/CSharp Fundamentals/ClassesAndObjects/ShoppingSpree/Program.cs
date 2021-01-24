using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] persons = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<Person> customers = new List<Person>();

            for (int i = 0; i < persons.Length; i++)
            {
                string[] personalData = persons[i].Split('=', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = personalData[0];
                int money = int.Parse(personalData[1]);

                customers.Add(new Person(name, money));
            }

            string[] products = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<Product> items = new List<Product>();

            for (int i = 0; i < products.Length; i++)
            {
                string[] productData = products[i].Split('=', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string product = productData[0];
                int cost = int.Parse(productData[1]);

                items.Add(new Product(product, cost));
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split().ToArray();

                string name = command[0];
                string item = command[1];

                Person currCustomer = customers.Find(x => x.Name == name);
                Product currProduct = items.Find(x => x.Name == item);

                if (currCustomer.Money >= currProduct.Cost)
                {
                    Console.WriteLine($"{currCustomer.Name} bought {currProduct.Name}");

                    currCustomer.BagOfProducts.Add(currProduct);
                    currCustomer.Money -= currProduct.Cost;

                }
                else
                {
                    Console.WriteLine($"{currCustomer.Name} can't afford {currProduct.Name}");
                }

            }

            foreach (Person person in customers)
            {
                List<string> bag = new List<string>();

                foreach (var item in person.BagOfProducts)
                {
                    bag.Add(item.Name);
                }

                if (bag.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", bag)}");

                }

            }


        }

        class Person
        {
            public string Name { get; set; }
            public int Money { get; set; }

            public List<Product> BagOfProducts { get; set; }

            public Person(string name, int money)
            {
                List<Product> bagOfProducts = new List<Product>();

                this.Name = name;
                this.Money = money;
                this.BagOfProducts = bagOfProducts;

            }
        }

        class Product
        {
            public string Name { get; set; }
            public int Cost { get; set; }

            public Product(string name, int cost)
            {
                this.Name = name;
                this.Cost = cost;
            }
        }
    }
}
