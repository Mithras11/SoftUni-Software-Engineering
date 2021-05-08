using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string input = string.Empty;
            string name = string.Empty;
            double price = 0.0;
            int quantity = 0;



            while ((input = Console.ReadLine()) != "buy")
            {
                string[] currentProduct = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                name = currentProduct[0];
                price = double.Parse(currentProduct[1]);
                quantity = int.Parse(currentProduct[2]);

                if (products.ContainsKey(name) == false)
                {
                    products.Add(name, new Product(price, quantity));
                }
                else
                {
                    products[name].Quantity += quantity;

                    if (products[name].Price!=price)
                    {
                        products[name].Price = price;
                    }
                }
            }

            foreach (var product in products)
            {
                double totalPrice = product.Value.Price * product.Value.Quantity;

                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }
        }

        public class Product
        {
            public double Price { get; set; }
            public int Quantity { get; set; }

            public Product(double price, int quantity)
            {
                this.Price = price;
                this.Quantity = quantity;
            }
        }
    }
}
