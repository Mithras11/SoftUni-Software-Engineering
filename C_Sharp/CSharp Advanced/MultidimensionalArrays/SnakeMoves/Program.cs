using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[size[0], size[1]];

            string snake = Console.ReadLine();
            int index = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 != 0)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[index];
                        index++;

                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[index];
                        index++;

                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
