using System;
using System.Linq;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] pizzaInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            // string pizzaName = doughInfo[0];
            string name = pizzaInfo[1];

            Pizza pizza = null;

            try
            {
                pizza = new Pizza(name);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }


            input = Console.ReadLine();

            string[] doughInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            // string doughName = doughInfo[0];
            string type = doughInfo[1];
            string bakingTechnique = doughInfo[2];
            double weight = double.Parse(doughInfo[3]);


            try
            {
                Dough dough = new Dough(type, bakingTechnique, weight);
                //double calories = dough.CalculateCalories();
                //Console.WriteLine($"{calories:F2}");


                pizza.Dough = dough;


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }



            while ((input = Console.ReadLine()) != "END")
            {

                string[] toppingInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                // string toppingName = doughInfo[0];
                string toppingType = toppingInfo[1];
                double toppinWeight = double.Parse(toppingInfo[2]);

                try
                {
                    Topping topping = new Topping(toppingType, toppinWeight);
                    //double calories = topping.CalculateCalories();
                    //Console.WriteLine($"{calories:F2}");


                    pizza.AddTopping(topping);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }

            }

            pizza.PrintCalories();
        }
    }
}
