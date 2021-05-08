using System;
using System.Linq;
using System.Collections.Generic;

namespace _02CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> firstRacerNums = new List<int>();
            List<int> secondRacerNums = new List<int>();

            double firstSum = 0;
            double secondSum = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                firstRacerNums.Add(numbers[i]);
            }
            for (int i = numbers.Count - 1; i >= numbers.Count / 2 + 1; i--)
            {
                secondRacerNums.Add(numbers[i]);
            }
            for (int i = 0; i < firstRacerNums.Count; i++)
            {
                int currNum = firstRacerNums[i];
                firstSum += currNum;
                if (currNum == 0)
                {
                    firstSum = firstSum * 0.8;
                }
            }
            for (int i = 0; i < secondRacerNums.Count; i++)
            {
                int currNum = secondRacerNums[i];
                secondSum += currNum;
                if (currNum == 0)
                {
                    secondSum = secondSum * 0.8;
                }
            }
            if (firstSum < secondSum)
            {
                Console.WriteLine("The winner is left with total time: {0}", firstSum);
            }
            else
            {
                Console.WriteLine("The winner is right with total time: {0}", secondSum);
            }


        }
    }
}