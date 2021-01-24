using System;
using System.Collections.Generic;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                string row = Console.ReadLine();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = row[c];
                }
            }


            int removeKnights = 0;

            while (true)
            {
                int maxAttackedKnights = 0;
                int maxRow = -1;
                int maxCol = -1;

                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    for (int c = 0; c < matrix.GetLength(1); c++)
                    {
                        if (matrix[r, c] == 'K')
                        {
                            int attakedKnights = GetNumOfAttackedKnights(matrix, r, c);

                            if (attakedKnights > maxAttackedKnights)
                            {
                                maxAttackedKnights = attakedKnights;
                                maxRow = r;
                                maxCol = c;

                            }

                        }
                    }
                }

                if (maxAttackedKnights == 0)
                {
                    break;
                }


                matrix[maxRow, maxCol] = '0';
                removeKnights++;

            }

            Console.WriteLine(removeKnights);

        }

        static int GetNumOfAttackedKnights(char[,] matrix, int r, int c)
        {
            int counter = 0;

            if (r - 2 >= 0 && c - 1 >= 0 && matrix[r - 2, c - 1] == 'K')
            {
                counter++;
            }

            if (r - 2 >= 0 && c + 1 < matrix.GetLength(1) && matrix[r - 2, c + 1] == 'K')
            {
                counter++;
            }

            if (r + 2 < matrix.GetLength(0) && c - 1 >= 0 && matrix[r + 2, c - 1] == 'K')
            {
                counter++;
            }

            if (r + 2 < matrix.GetLength(0) && c + 1 < matrix.GetLength(1) && matrix[r + 2, c + 1] == 'K')
            {
                counter++;
            }



            if (r - 1 >= 0 && c - 2 >= 0 && matrix[r - 1, c - 2] == 'K')
            {
                counter++;
            }

            if (r - 1 >= 0 && c + 2 < matrix.GetLength(1) && matrix[r - 1, c + 2] == 'K')
            {
                counter++;
            }

            if (r + 1 < matrix.GetLength(0) && c - 2 >= 0 && matrix[r + 1, c - 2] == 'K')
            {
                counter++;
            }

            if (r + 1 < matrix.GetLength(0) && c + 2 < matrix.GetLength(1) && matrix[r + 1, c + 2] == 'K')
            {
                counter++;
            }

            return counter;
        }
    }
}
