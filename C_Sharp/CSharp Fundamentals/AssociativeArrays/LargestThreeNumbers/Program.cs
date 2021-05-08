using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] sortedNumbers = numbers.OrderByDescending(n => n).ToArray();

            if (sortedNumbers.Length <= 3)
            {
                Console.Write(string.Join(' ', sortedNumbers));
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(sortedNumbers[i] + " ");
                }
            }
        }
    }
}
