using System;
using System.Linq;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            try
            {




                string input = Console.ReadLine();

                string[] pizzaInfo = input.Split().ToArray();
                string name = pizzaInfo[1];

                Pizza pizza = new Pizza(name);




                input = Console.ReadLine();

                string[] doughInfo = input.Split().ToArray();

                string type = doughInfo[1];
                string bakingTechnique = doughInfo[2];
                double weight = double.Parse(doughInfo[3]);

                Dough dough = new Dough(type, bakingTechnique, weight);
                //double calories = dough.CalculateCalories();
                //Console.WriteLine($"{calories:F2}");

                pizza.Dough = dough;

                input = Console.ReadLine();

                while ((input != "END"))
                {

                    string[] toppingInfo = input.Split().ToArray();

                    string toppingType = toppingInfo[1];
                    double toppinWeight = double.Parse(toppingInfo[2]);


                    Topping topping = new Topping(toppingType, toppinWeight);
                    //double calories = topping.CalculateCalories();
                    //Console.WriteLine($"{calories:F2}");


                    pizza.AddTopping(topping);

                    input = Console.ReadLine();

                }

                pizza.PrintCalories();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
