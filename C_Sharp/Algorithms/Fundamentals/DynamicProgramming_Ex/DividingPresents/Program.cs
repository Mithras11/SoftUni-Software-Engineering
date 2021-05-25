using System;
using System.Collections.Generic;
using System.Linq;

namespace DividingPresents
{
    class Program
    {

        static int[] numbers;
        static int totalSum;
        static int targetSum;
        static int firstSum;
        static int secondSum;
        static Dictionary<int, int> subSums;
        static List<int> presents;

        static void Main(string[] args)
        {
            numbers = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            totalSum = numbers.Sum();
            targetSum = totalSum / 2;

            GetSubSums();
            GetPresents();
            PrintResult();

        }

        private static void PrintResult()
        {
            int difference = Math.Abs(firstSum - secondSum);

            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Alan:{firstSum} Bob:{secondSum}");
            Console.WriteLine($"Alan takes: {string.Join(' ', presents)}");
            Console.WriteLine("Bob takes the rest.");
        }

        private static void GetPresents()
        {
            firstSum = subSums.OrderByDescending(x => x.Key)
                           .FirstOrDefault(x => x.Key <= targetSum).Key;

            secondSum = totalSum - firstSum;

            presents = new List<int>();
            int sum = firstSum;
            int currNum;

            while (sum != 0)
            {
                currNum = subSums[sum];
                presents.Add(currNum);
                sum -= currNum;
            }
        }

        private static void GetSubSums()
        {
            subSums = new Dictionary<int, int>() { { 0, 0 } };

            int currSum;
            int[] keys;

            foreach (var num in numbers)
            {
                keys = subSums.Keys.ToArray();

                foreach (var key in keys)
                {
                    currSum = num + key;

                    if (!subSums.ContainsKey(currSum))
                    {
                        subSums[currSum] = num;
                    }
                }

            }
        }
    }
}
