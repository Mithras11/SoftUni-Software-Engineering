using System;
using System.Collections.Generic;
using System.Linq;

namespace MoveDownRight
{
    class Program
    {
        static int[,] matrix;
        static int[,] sums;
        static Stack<string> path;
        static int rows;
        static int cols;
        static void Main(string[] args)
        {
            ReadMatrix();
            FillSums();
            FindPath();
            PrintResult();


        }

        private static void PrintResult()
        {
            Console.WriteLine(string.Join(' ', path));
        }

        private static void FindPath()
        {
            path = new Stack<string>();

            var currRow = rows - 1;
            var currCol = cols - 1;

            path.Push($"[{currRow}, {currCol}]");

            while (currRow > 0 && currCol > 0)
            {
                var upperCell = sums[currRow - 1, currCol];
                var leftCell = sums[currRow, currCol - 1];

                if (upperCell > leftCell)
                {
                    currRow--;
                }
                else
                {
                    currCol--;
                }

                path.Push($"[{currRow}, {currCol}]");
            }

            while (currRow > 0)
            {
                currRow--;
                path.Push($"[{currRow}, {currCol}]");
            }

            while (currCol > 0)
            {
                currCol--;
                path.Push($"[{currRow}, {currCol}]");
            }


        }

        private static void FillSums()
        {
            sums = new int[rows, cols];

            sums[0, 0] = matrix[0, 0];

            for (int row = 1; row < rows; row++)
            {
                sums[row, 0] = matrix[row, 0] + sums[row - 1, 0];
            }

            for (int col = 1; col < cols; col++)
            {
                sums[0, col] = matrix[0, col] + sums[0, col - 1];
            }




            for (int row = 1; row < rows; row++)
            {
                for (int col = 1; col < cols; col++)
                {
                    sums[row, col] = Math.Max(
                        sums[row, col - 1],
                        sums[row - 1, col]) +
                        matrix[row, col];

                }
            }

        }

        private static void ReadMatrix()
        {
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());

            matrix = new int[rows, cols];

            int[] line;

            for (int i = 0; i < rows; i++)
            {
                line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
        }
    }
}
