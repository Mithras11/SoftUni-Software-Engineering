using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Common;
using WildFarm.Models.Animals;
using WildFarm.Models.Animals.Birds;


namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string[] animalInfo = null;
            string[] foodinfo = null;

            List<Animal> allAnimals = new List<Animal>();

            while (true)
            {
                input = Console.ReadLine();

                if (input=="End")
                {
                    break;
                }

                animalInfo = input.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                var animal = AnimalGenerator.Generate(animalInfo);

                foodinfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var food = FoodGenerator.Generate(foodinfo);

                animal.AskForFood();
                animal.Eat(food);

                allAnimals.Add(animal);
            }


            foreach (var item in allAnimals)
            {
                Console.WriteLine(item);
            }





        }
    }
}
