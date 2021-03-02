using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        //fields
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        //constructor

        public Pizza(string name)
        {

            this.Name = name;
            this.Toppings = new List<Topping>();
           // this.Dough = new Dough();  
        }


        //properties
        public double Totalcalories
        {
            get
            {
                return this.Dough.CalculateCalories() + this.Toppings.Sum(t => t.CalculateCalories());
            }

        }



        public Dough Dough
        {
            get
            {
                return dough;
            }

            set
            {
                dough = value;
            }
        }

        public List<Topping> Toppings
        {
            get
            {
                return toppings;
            }

            private set
            {
                toppings = value;
            }
        }




        public string Name
        {
            get
            {
                return name;
            }

            private set
            {

                if ( string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }


        //methods

        public void AddTopping(Topping topping)
        {
            if (this.Toppings.Count == 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }

            this.Toppings.Add(topping);
        }



        public void PrintCalories()
        {
            Console.WriteLine($"{this.Name} - {this.Totalcalories:F2} Calories.");
        }

    }
}
