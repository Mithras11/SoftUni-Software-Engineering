using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentColumn = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentColumn[col];
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] +
                        matrix[row, col + 1] +
                        matrix[row + 1, col] +
                        matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine(maxSum);

        }
    }
}
