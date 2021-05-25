using System;
using System.Linq;

namespace SumWithUnlimitedAmountOfCoins
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

            var sums = new int[target + 1];

            sums[0] = 1;

            foreach (var num in numbers)
            {
                for (int i = num; i < sums.Length; i++)
                {
                    sums[i] += sums[i - num];

                }
            }

            Console.WriteLine(sums[target]);
        }
    }
}
