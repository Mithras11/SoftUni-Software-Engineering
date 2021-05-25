using System;
using System.Collections.Generic;
using System.Linq;

namespace SumWithLimitedAmountOfCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var target = int.Parse(Console.ReadLine());

            var result = new Dictionary<int, int>() { { 0, 1 } };

            foreach (var num in numbers)
            {
                var sums = result.Keys.ToArray();
                int currSum;

                foreach (var sum in sums)
                {
                    currSum = sum + num;

                    if (!result.ContainsKey(currSum))
                    {
                        result.Add(currSum, 1);
                    }
                    else
                    {
                        result[currSum]++;
                    }
                }

            }

            Console.WriteLine(result[target]);
        }
    }
}
