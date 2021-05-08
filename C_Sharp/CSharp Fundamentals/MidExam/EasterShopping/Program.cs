using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Include":
                        string shop = command[1];
                        shops.Add(shop);

                        break;

                    case "Visit":
                        int num = int.Parse(command[2]);
                        if (num > shops.Count)
                        {
                            continue;
                        }

                        if (command[1] == "first")
                        {
                            shops.RemoveRange(0, num);
                        }
                        else
                        {
                            shops.RemoveRange(shops.Count - num, num);
                        }
                        break;

                    case "Prefer":
                        int index1 = int.Parse(command[1]);
                        int index2 = int.Parse(command[2]);

                        if (index1 >= 0 && index2 < shops.Count && index2 >= 0 && index2 < shops.Count)
                        {
                            string temp = shops[index1];
                            shops[index1] = shops[index2];
                            shops[index2] = temp;
                        }

                        break;

                    case "Place":
                        string newShop = command[1];
                        int newShopIndex = int.Parse(command[2]) + 1;

                        if (newShopIndex >= 0 && newShopIndex < shops.Count)
                        {
                            shops.Insert(newShopIndex, newShop);
                        }


                        break;
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(' ',shops));



        }
    }
}
