using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Predicate<int> checkIfDivisible = n =>
            {
                bool isDivisible = true;

                foreach (int num in numbers)
                {
                    if (n % num == 0)
                    {
                        continue;
                    }
                    else
                    {
                        isDivisible = false;
                        break;

                    }

                }

                return isDivisible;

            };

            Func<int[], List<int>> sortNumbers = ((arr) =>
              {
                  List<int> sortedNumbers = new List<int>();

                  for (int i = 1; i <= range; i++)
                  {
                      if (checkIfDivisible(i))
                      {
                          sortedNumbers.Add(i);
                      }

                  }

                  return sortedNumbers;


              });

            Action<List<int>> print = ((list) =>
              {
                  Console.WriteLine(string.Join(' ', list));
              });


            var result = sortNumbers(numbers);
            print(result);

        }
    }
}
