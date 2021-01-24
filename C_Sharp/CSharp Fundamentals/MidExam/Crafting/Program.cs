using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> weaponName = Console.ReadLine().Split('|').ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }
                else
                {
                    string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    switch (command[0])
                    {
                        case "Move":
                            if (command[1] == "Left")
                            {
                                int index = int.Parse(command[2]);
                                if (index > 0 && index < weaponName.Count)
                                {
                                    string temp = weaponName[index];
                                    weaponName.RemoveAt(index);
                                    weaponName.Insert(index - 1, temp);
                                }
                            }
                            else if (command[1] == "Right")
                            {
                                int index = int.Parse(command[2]);
                                if (index >= 0 && index < weaponName.Count - 1)
                                {
                                    string temp = weaponName[index];
                                    weaponName.RemoveAt(index);
                                    weaponName.Insert(index + 1, temp);
                                }
                            }

                            break;


                        case "Check":
                            if (command[1] == "Even")
                            {
                                for (int i = 0; i < weaponName.Count; i++)
                                {
                                    if (i % 2 == 0)
                                    {
                                        Console.Write(weaponName[i]+" ");
                                    }
                                }
                                Console.WriteLine();
                            }
                            else if (command[1] == "Odd")
                            {
                                for (int i = 0; i < weaponName.Count; i++)
                                {
                                    if (i % 2 != 0)
                                    {
                                        Console.Write(weaponName[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                            }

                            break;

                    }

                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (var item in weaponName)
            {
                sb.Append(item);

            }
            string weapon = sb.ToString();

            Console.WriteLine($"You crafted {weapon}!");
        }
    }
}
