using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();

            List<Product> products = new List<Product>();


            try
            {
                people = Console.ReadLine()
                            .Split(';', StringSplitOptions.RemoveEmptyEntries)
                            .Select(t => t.Split('='))
                            .Select(t => new Person(t[0], decimal.Parse(t[1])))
                            .ToList();


                products = Console.ReadLine()
                          .Split(';', StringSplitOptions.RemoveEmptyEntries)
                          .Select(t => t.Split('='))
                          .Select(t => new Product(t[0], decimal.Parse(t[1])))
                          .ToList();
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }






            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {

                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                Person customer = people.First(p => p.Name == tokens[0]);
                Product purchase = products.First(products => products.Name == tokens[1]);

                try
                {
                    customer.BuyProduct(purchase);

                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                    continue;
                }


            }


            foreach (var person in people)
            {
                person.GetStatistics();
            }




        }
    }
}
