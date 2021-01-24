using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split('!').ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Go Shopping!")
                {
                    break;
                }
                else
                {
                    string[] data = input.Split();
                    string command = data[0];
                    string item = data[1];

                    switch (command)
                    {
                        case "Urgent":
                            if (!(shoppingList.Contains(item)))
                            {
                                shoppingList.Insert(0, item);
                            }
                            break;

                        case "Unnecessary":
                            if ((shoppingList.Contains(item)))
                            {
                                shoppingList.Remove(item);
                            }
                            break;

                        case "Correct":
                            
                            string oldItem = data[1];
                            string newItem = data[2];

                            if ((shoppingList.Contains(oldItem)))
                            {
                                int index = shoppingList.IndexOf(oldItem);
                                shoppingList[index] = newItem;
                            }
                            break;

                        case "Rearrange":
                            if ((shoppingList.Contains(item)))
                            {
                                shoppingList.Remove(item);
                                shoppingList.Add(item);
                            }
                            break;
                    }


                }
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
