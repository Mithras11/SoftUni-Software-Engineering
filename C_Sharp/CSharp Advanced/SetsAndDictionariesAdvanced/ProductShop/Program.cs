using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<Product>> shops = new SortedDictionary<string, List<Product>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] data = input.Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string shop = data[0];
                Product product = new Product(data[1], double.Parse(data[2]));

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new List<Product>());

                }
                
                    shops[shop].Add(product);

                
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
                }
            }


        }


        class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }


            public Product(string name, double price)
            {
                this.Name = name;
                this.Price = price;

            }
        }
    }
}
