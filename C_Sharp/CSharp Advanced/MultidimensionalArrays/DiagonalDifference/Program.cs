using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] currCol = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currCol[col];
                }

            }

            int sum1 = 0;

            for (int i = 0; i < n; i++)
            {
                sum1 += matrix[i, i];
            }

            int sum2 = 0;
            int p = n - 1;

            for (int i = 0; i < n; i++)
            {
                sum2 += matrix[i, p];

                p--;
            }

            int diff = Math.Abs(sum1 - sum2);

            Console.WriteLine(diff);
        }
    }
}
