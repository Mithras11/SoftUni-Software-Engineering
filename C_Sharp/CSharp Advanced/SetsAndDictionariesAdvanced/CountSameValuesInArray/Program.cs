using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var number in nums)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }


            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
