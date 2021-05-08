using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split();
                string operation = command[0];

                switch (operation)
                {
                    case "Add":
                        double newNumber = double.Parse(command[1]);
                        numbers.Add(newNumber);

                        break;

                    case "Insert":
                        double numberToInsert = double.Parse(command[1]);
                        int index = int.Parse(command[2]);

                        if (index >= 0 && index < numbers.Count)
                        {
                            numbers.Insert(index, numberToInsert);

                        }
                        else
                        {
                            Console.WriteLine("Invalid index");

                        }

                        break;

                    case "Remove":
                        int indexToRemove = int.Parse(command[1]);
                        if (indexToRemove >= 0 && indexToRemove < numbers.Count)
                        {
                            numbers.RemoveAt(indexToRemove);

                        }
                        else
                        {
                            Console.WriteLine("Invalid index");

                        }

                        break;

                    case "Shift":

                        int count = int.Parse(command[2]);

                        if (command[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                double firstNum = numbers[0];
                                numbers.Add(firstNum);
                                numbers.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                            double lastNum = numbers[numbers.Count - 1];
                            numbers.Insert(0, lastNum);
                            numbers.RemoveAt(numbers.Count - 1);

                            }
                        }

                        break;





                }

                input = Console.ReadLine();

            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
