using System;
using System.Text;

namespace ReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            var matrix = new char[size, size];

            char[] currRow;

            int playerRow = 0;
            int playerCol = 0;


            for (int row = 0; row < size; row++)
            {
                currRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currRow[col];

                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }


            bool playerWins = false;

            string command;

            for (int i = 0; i < n; i++)
            {
                matrix[playerRow, playerCol] = '-';


                command = Console.ReadLine();

                if (command == "up")
                {
                    playerRow--;

                    if (!CheckBoundaries(size, playerRow, playerCol))
                    {
                        playerRow = size - 1;
                    }

                    if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerRow--;

                        if (!CheckBoundaries(size, playerRow, playerCol))
                        {
                            playerRow = size - 1;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerRow++;

                    }
                }
                else if (command == "down")
                {
                    playerRow++;

                    if (!CheckBoundaries(size, playerRow, playerCol))
                    {
                        playerRow = 0;
                    }

                    if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerRow++;

                        if (!CheckBoundaries(size, playerRow, playerCol))
                        {
                            playerRow = 0;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerRow--;
                    }
                }
                else if (command == "left")
                {
                    playerCol--;

                    if (!CheckBoundaries(size, playerRow, playerCol))
                    {
                        playerCol = size - 1;
                    }

                    if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerCol--;

                        if (!CheckBoundaries(size, playerRow, playerCol))
                        {
                            playerCol = size - 1;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerCol++;
                    }
                }
                else if (command == "right")
                {
                    playerCol++;

                    if (!CheckBoundaries(size, playerRow, playerCol))
                    {
                        playerCol = 0;
                    }

                    if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerCol++;

                        if (!CheckBoundaries(size, playerRow, playerCol))
                        {
                            playerCol = 0;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerCol--;
                    }
                }

                if (matrix[playerRow, playerCol] == 'F')
                {
                    matrix[playerRow, playerCol] = 'f';

                    playerWins = true;

                    break;
                }


                matrix[playerRow, playerCol] = 'f';
            }


            if (playerWins)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }


            var sb = new StringBuilder();

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    sb.Append(matrix[row, col]);
                }

                Console.WriteLine(sb.ToString().Trim());

                sb.Clear();
            }


        }

        private static bool CheckBoundaries(int size, int playerRow, int playerCol)
        {
            if (playerRow < 0 || playerRow >= size
               || playerCol < 0 || playerCol >= size)
            {
                return false;
            }

            return true;
        }
    }
}
