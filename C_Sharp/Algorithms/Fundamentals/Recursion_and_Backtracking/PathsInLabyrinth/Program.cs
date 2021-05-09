using System;
using System.Collections.Generic;
using System.Text;

namespace PathsInLabyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            var labyrinth = ReadLabyrinth();
            var path = new List<char>();

            FindPaths(labyrinth, path, 0, 0, '\0');

        }

        static char[,] ReadLabyrinth()
        {
            int rowSize = int.Parse(Console.ReadLine());
            int colSize = int.Parse(Console.ReadLine());

            var labyrinth = new char[rowSize, colSize];

            var currRow = string.Empty;

            for (int i = 0; i < rowSize; i++)
            {
                currRow = Console.ReadLine();

                for (int j = 0; j < colSize; j++)
                {
                    labyrinth[i, j] = currRow[j];
                }
            }

            return labyrinth;
        }


        static void FindPaths(char[,] labyrinth, List<char> path, int row, int col, char direction)
        {
            if (isInBounds(labyrinth, row, col))
            {
                return;
            }

            path.Add(direction);

            if (isExit(labyrinth, row, col))
            {
                PrintPath(path);
            }
            else if (!isVisited(labyrinth, row, col) &&
                isFree(labyrinth, row, col))
            {
                Mark(labyrinth, row, col);

                FindPaths(labyrinth, path, row, col + 1, 'R');
                FindPaths(labyrinth, path, row, col - 1, 'L');
                FindPaths(labyrinth, path, row - 1, col, 'U');
                FindPaths(labyrinth, path, row + 1, col, 'D');

                Unmark(labyrinth, row, col);

            }



            path.RemoveAt(path.Count - 1);

        }

        private static void Unmark(char[,] labyrinth, int row, int col)
        {
            labyrinth[row, col] = '-';
        }

        private static void Mark(char[,] labyrinth, int row, int col)
        {
            labyrinth[row, col] = 'x';
        }

        private static bool isFree(char[,] labyrinth, int row, int col)
        {
            return labyrinth[row, col] == '-';
        }

        private static bool isVisited(char[,] labyrinth, int row, int col)
        {
            return labyrinth[row, col] == 'x';
        }

        private static void PrintPath(List<char> path)
        {
            Console.WriteLine(string.Concat(path));
        }

        private static bool isExit(char[,] labyrinth, int row, int col)
        {
            return labyrinth[row, col] == 'e';

        }

        private static bool isInBounds(char[,] labyrinth, int row, int col)
        {
            return row < 0 ||
                   row >= labyrinth.GetLength(0) ||
                   col < 0 ||
                   col >= labyrinth.GetLength(1);
        }


    }
}
