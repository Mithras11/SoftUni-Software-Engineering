using System;
using System.Collections.Generic;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 14, 5, 12, 7, 8, 9, 11, 10, 1 };

            var solutions = new int[numbers.Length];
            var prevSolIndexes = new int[numbers.Length];


            var maxSolution = 0;
            var maxSolIndex = 0;

            for (int currIndex = 0; currIndex < numbers.Length; currIndex++)
            {
                var solution = 1;
                var prevIndex = -1;

                var currNumber = numbers[currIndex];

                for (int solIndex = 0; solIndex < currIndex; solIndex++)
                {
                    var prevNumber = numbers[solIndex];
                    var prevSolution = solutions[solIndex];

                    if (currNumber > prevNumber
                        && solution <= prevSolution)
                    {
                        solution = prevSolution + 1;
                        prevIndex = solIndex;
                    }

                }

                solutions[currIndex] = solution;
                prevSolIndexes[currIndex] = prevIndex;

                if (solution > maxSolution)
                {
                    maxSolution = solution;
                    maxSolIndex = currIndex;
                }
            }

            var index = maxSolIndex;

            var result = new List<int>();

            while (index != -1)
            {
                var currentNumber = numbers[index];

                result.Add(currentNumber);

                index = prevSolIndexes[index];
            }

            result.Reverse();

            Console.WriteLine(string.Join(' ', result));

        }
    }
}
