using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

           double[][] matrix = new double[n][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

            }

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;
                    }
                    for (int col1 = 0; col1 < matrix[row + 1].Length; col1++)
                    {
                        matrix[row + 1][col1] /= 2;
                    }
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                double value = double.Parse(command[3]);

                if (row >= 0 && row < matrix.Length &&
                    col >= 0 && col < matrix[row].Length)
                {


                    if (command[0] == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (command[0] == "Subtract")
                    {

                        matrix[row][col] -= value;
                    }
                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join(' ', matrix[row]));
            }
        }
    }
}
