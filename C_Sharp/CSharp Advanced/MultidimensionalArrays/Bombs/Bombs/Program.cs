using System;
using System.Linq;
using System.Text;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var matrix = new int[size, size];
            int[] currRow;

            for (int row = 0; row < size; row++)
            {
                currRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }


            string[] bombs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int[] currCoordinates;
            int bombRow;
            int bombCol;
            int currBomb;

            for (int i = 0; i < bombs.Length; i++)
            {
                currCoordinates = bombs[i]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                bombRow = currCoordinates[0];
                bombCol = currCoordinates[1];

                currBomb = matrix[bombRow, bombCol];

                if (currBomb > 0)
                {


                    if (CheckCoordinates(bombRow - 1, bombCol - 1, size) && matrix[bombRow - 1, bombCol - 1] > 0)
                    {
                        matrix[bombRow - 1, bombCol - 1] -= currBomb;
                    }

                    if (CheckCoordinates(bombRow - 1, bombCol, size) && matrix[bombRow - 1, bombCol] > 0)
                    {
                        matrix[bombRow - 1, bombCol] -= currBomb;
                    }

                    if (CheckCoordinates(bombRow - 1, bombCol + 1, size) && matrix[bombRow - 1, bombCol + 1] > 0)
                    {

                        matrix[bombRow - 1, bombCol + 1] -= currBomb;
                    }

                    if (CheckCoordinates(bombRow, bombCol - 1, size) && matrix[bombRow, bombCol - 1] > 0)
                    {
                        matrix[bombRow, bombCol - 1] -= currBomb;
                    }

                    if (CheckCoordinates(bombRow, bombCol + 1, size) && matrix[bombRow, bombCol + 1] > 0)
                    {
                        matrix[bombRow, bombCol + 1] -= currBomb;
                    }

                    if (CheckCoordinates(bombRow + 1, bombCol - 1, size) && matrix[bombRow + 1, bombCol - 1] > 0)
                    {
                        matrix[bombRow + 1, bombCol - 1] -= currBomb;
                    }

                    if (CheckCoordinates(bombRow + 1, bombCol, size) && matrix[bombRow + 1, bombCol] > 0)
                    {
                        matrix[bombRow + 1, bombCol] -= currBomb;
                    }

                    if (CheckCoordinates(bombRow + 1, bombCol + 1, size) && matrix[bombRow + 1, bombCol + 1] > 0)
                    {
                        matrix[bombRow + 1, bombCol + 1] -= currBomb;
                    }

                    matrix[bombRow, bombCol] = 0;
                }
            }

            int aliveCells = 0;
            int sum = 0;

            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sum += matrix[row, col];
                    }

                    sb.Append($"{matrix[row, col]} ");

                }

                sb.AppendLine();

            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            Console.WriteLine(sb.ToString().Trim());

        }

        private static bool CheckCoordinates(int row, int col, int size)
        {
            if (row >= 0 && row < size
                && col >= 0 && col < size)
            {
                return true;
            }

            return false;
        }
    }
}
