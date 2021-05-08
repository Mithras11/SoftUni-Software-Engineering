using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cooking
{

    class Ingredient
    {
        public int Value { get; set; }

        public Ingredient(int value)
        {
            this.Value = value;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            int[] liquidsInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> liquids = new Queue<int>();

            foreach (var item in liquidsInfo)
            {
                liquids.Enqueue(item);
            }

            int[] ingredientsInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<Ingredient> ingredients = new Queue<Ingredient>();

            foreach (var value in ingredientsInfo.Reverse())
            {
                Ingredient ingredient = new Ingredient(value);

                ingredients.Enqueue(ingredient);
            }


            Dictionary<string, int> food = new Dictionary<string, int>
            {
                {"Bread", 0 },
                {"Cake", 0 },
                {"Pastry", 0 },
                {"Fruit Pie", 0 }
            };

            while (liquids.Any() && ingredients.Any())
            {
                int sum = liquids.Peek() + ingredients.Peek().Value;

                if (sum == 25 || sum == 50 || sum == 75 || sum == 100)
                {
                    if (sum == 25)
                    {
                        food["Bread"]++;

                    }
                    else if (sum == 50)
                    {
                        food["Cake"]++;
                    }
                    else if (sum == 75)
                    {
                        food["Pastry"]++;
                    }
                    else if (sum == 100)
                    {
                        food["Fruit Pie"]++;
                    }

                    ingredients.Dequeue();
                }
                else
                {
                    ingredients.Peek().Value += 3;
                }
                liquids.Dequeue();

            }

            if (food.Values.Contains(0) == false)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");

            }

            if (liquids.Any())
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (ingredients.Any())
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients.Select(i => i.Value))}");
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            foreach (var item in food.OrderBy(f => f.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


        }
    }
}
