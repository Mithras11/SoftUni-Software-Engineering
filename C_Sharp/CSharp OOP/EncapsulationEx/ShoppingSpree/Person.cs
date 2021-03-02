using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShoppingSpree
{
    public class Person
    {
        private List<Product> bagOfProducts;
        private string name;
        private decimal money;


        public Person(string name, decimal money)
        {
            bagOfProducts = new List<Product>();
            Name = name;
            Money = money;
        }


        public string Name
        {
            get { return name; }

           private  set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }


                name = value;
            }
        }




        public decimal Money
        {
            get { return money; }

          private   set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }



        public IReadOnlyList<Product> BagOfProducts
        {
            get { return bagOfProducts.AsReadOnly(); }
            
        }


        public void BuyProduct(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.bagOfProducts.Add(product);
                this.Money -= product.Cost;

                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                throw new ArgumentException($"{this.Name} can't afford {product.Name}");
                
            }
        }


        public void GetStatistics()
        {
            if (this.bagOfProducts.Count == 0)
            {
                Console.WriteLine($"{this.Name} - Nothing bought");
            }
            else
            {
                Console.WriteLine($"{this.Name} - {string.Join(", ", this.bagOfProducts.Select(p => p.Name))}");
            }
        }

    }
}
