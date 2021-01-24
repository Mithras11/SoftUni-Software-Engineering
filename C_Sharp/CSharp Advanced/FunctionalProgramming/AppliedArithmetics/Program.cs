using System;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "print")
                {
                    Console.WriteLine(string.Join(' ', numbers));
                }
                else

                {
                    Func<int[], int[]> manipulteNumbers = ManipulateNumbers(command);

                    numbers = manipulteNumbers(numbers);

                }

                command = Console.ReadLine();

            }
        }

        static Func<int[], int[]> ManipulateNumbers(string command)
        {
            Func<int[], int[]> manipulator = null;

            if (command == "add")
            {
                manipulator = new Func<int[], int[]>((arr) =>
                  {
                      for (int i = 0; i < arr.Length; i++)
                      {
                          arr[i]++;
                      }

                      return arr;
                  });
            }
            else if (command == "multiply")
            {
                manipulator = new Func<int[], int[]>((arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] *= 2;
                    }

                    return arr;
                });
            }
            else if (command == "subtract")
            {
                manipulator = new Func<int[], int[]>((arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i]--;
                    }

                    return arr;
                });
            }

            return manipulator;
        }
    }

}


