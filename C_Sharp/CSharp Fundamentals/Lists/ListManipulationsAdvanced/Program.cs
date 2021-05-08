using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationsAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            string input = Console.ReadLine();
            bool isChanged = false;

            while (input != "end")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Contains":
                        if (numbers.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        List<int> evenNums = numbers.Where(n => n % 2 == 0).ToList();
                        Console.WriteLine(string.Join(' ', evenNums));
                        break;

                    case "PrintOdd":
                        List<int> oddNums = numbers.Where(n => n % 2 != 0).ToList();
                        Console.WriteLine(string.Join(' ', oddNums));
                        break;

                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;

                    case "Filter":
                        if (command[1]=="<")
                        {
                            List<int> result = numbers.Where(n => n < int.Parse(command[2])).ToList();
                            Console.WriteLine(string.Join(' ', result));
                        }
                        else if (command[1] == ">")
                        {
                            List<int> result = numbers.Where(n => n > int.Parse(command[2])).ToList();
                            Console.WriteLine(string.Join(' ', result));
                        }
                        else if (command[1] == ">=")
                        {
                            List<int> result = numbers.Where(n => n >= int.Parse(command[2])).ToList();
                            Console.WriteLine(string.Join(' ', result));
                        }
                        else if (command[1] == "<=")
                        {
                            List<int> result = numbers.Where(n => n <= int.Parse(command[2])).ToList();
                            Console.WriteLine(string.Join(' ', result));
                        }
                        break;

                    case "Add":
                        int numberToAdd = int.Parse(command[1]);
                        numbers.Add(numberToAdd);
                        isChanged = true;
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(command[1]);
                        numbers.Remove(numberToRemove);
                        isChanged = true;
                        break;

                    case "RemoveAt":
                        int indexToRemove = int.Parse(command[1]);
                        numbers.RemoveAt(indexToRemove);
                        isChanged = true;
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(command[1]);
                        int indexToInsert = int.Parse(command[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        isChanged = true;
                        break;

                }

                input = Console.ReadLine();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(' ', numbers));

            }


        }
    }
}
