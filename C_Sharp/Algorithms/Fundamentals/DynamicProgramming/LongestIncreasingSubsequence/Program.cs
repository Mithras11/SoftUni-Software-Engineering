using System;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine();
            var second = Console.ReadLine();

            var matrix = new int[first.Length + 1, second.Length + 1];

            char currChar1;
            char currChar2;
            int upper;
            int left;

            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    currChar1 = first[row - 1];
                    currChar2 = second[col - 1];

                    if (currChar1 == currChar2)
                    {
                        matrix[row, col] = matrix[row - 1, col - 1] + 1;
                    }
                    else
                    {
                        upper = matrix[row - 1, col];
                        left = matrix[row, col - 1];

                        matrix[row, col] = Math.Max(upper, left);
                    }
                }
            }

            Console.WriteLine(matrix[first.Length, second.Length]);
        }
    }
}
