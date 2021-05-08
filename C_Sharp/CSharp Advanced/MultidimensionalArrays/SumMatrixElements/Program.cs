using System;
using System.Linq;

namespace SumMatrixElements

{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Console.WriteLine($"{size[0]}");
            Console.WriteLine($"{size[1]}");

            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentColumn = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentColumn[col];
                }
            }

            int sum = 0;

            foreach (var num in matrix)
            {
                sum += num;
            }

            Console.WriteLine(sum);


        }
    }
}
