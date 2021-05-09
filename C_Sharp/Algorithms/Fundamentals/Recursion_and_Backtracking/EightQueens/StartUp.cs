using System;
using System.Collections.Generic;

namespace EightQueens
{
    class StartUp
    {

        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedCols = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals = new HashSet<int>();


        static void PutQueens(int row)
        {
            if (row == 8)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < 8; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAllAttackedPositions(row, col);
                        PutQueens(row + 1);
                        UnmarkAllAttackedPositions(row, col);
                    }
                }
            }
        }

        private static void UnmarkAllAttackedPositions(int row, int col)
        {
            Chess.Board[row, col] = false;

            attackedRows.Remove(row);
            attackedCols.Remove(col);
            attackedLeftDiagonals.Remove(col - row);
            attackedRightDiagonals.Remove(col + row);
        }

        private static void MarkAllAttackedPositions(int row, int col)
        {
            Chess.Board[row, col] = true;

            attackedRows.Add(row);
            attackedCols.Add(col);
            attackedLeftDiagonals.Add(col - row);
            attackedRightDiagonals.Add(col + row);


        }

        private static bool CanPlaceQueen(int row, int col)
        {
            return !(attackedRows.Contains(row) ||
                     attackedCols.Contains(col) ||
                     attackedLeftDiagonals.Contains(col - row) ||
                     attackedRightDiagonals.Contains(col + row));
        }

        static void PrintSolution()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (Chess.Board[row, col] == true)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

        }


        private class Chess
        {
            private static bool[,] board = new bool[8, 8];


            public static bool[,] Board
            {
                get => board;

                set => board = value;
            }
        }



        static void Main(string[] args)
        {
            PutQueens(0);

        }
    }

}
