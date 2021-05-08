using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Craft!")
                {
                    break;
                }
                else
                {
                    string[] commands = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                    string command = commands[0];
                    string item = commands[1];

                    switch (command)
                    {
                        case "Collect":
                            if (!(inventory.Contains(item)))
                            {
                                inventory.Add(item);
                            }
                            break;

                        case "Drop":
                            if (inventory.Contains(item))
                            {
                                inventory.Remove(item);
                            }
                            break;

                        case "Combine Items":
                            string[] currentItems = item.Split(":");
                            string oldItem = currentItems[0];
                            string newItem = currentItems[1];

                            if (inventory.Contains(oldItem))
                            {                              
                                int index = inventory.IndexOf(oldItem);
                                inventory.Insert(index + 1, newItem);
                            }

                            break;

                        case "Renew":
                            if (inventory.Contains(item))
                            {
                                int index = inventory.IndexOf(item);
                                inventory.Remove(item);
                                inventory.Add(item);
                            }
                            break;

                    }
                }
            }


            Console.Write(string.Join(", ", inventory));

        }
    }
}
