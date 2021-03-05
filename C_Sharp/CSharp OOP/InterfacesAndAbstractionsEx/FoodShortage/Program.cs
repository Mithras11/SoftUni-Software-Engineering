using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] data = null;

            List<IBuyer> list = new List<IBuyer>();

            for (int i = 0; i < num; i++)
            {
                data = Console.ReadLine().Split().ToArray();

                string name = data[0];
                int age = int.Parse(data[1]);


                if (data.Length == 4)
                {
                    string id = data[2];
                    string birthdate = data[3];

                    list.Add(new Citizen(name, age, id, birthdate));
                }
                else
                {
                    string group = data[2];

                    list.Add(new Rebel(name, age, group));
                }
            }


            string input = string.Empty;
            

            while ((input = Console.ReadLine()) != "End")
            {


                if (list.Any(b => b.Name == input))
                {
                    var buyer= list.First(b => b.Name == input);

                    buyer.BuyGood();

                    
                }

            }

            int purchases = list.Sum(b => b.Food);

            Console.WriteLine(purchases);
        }
    }
}
