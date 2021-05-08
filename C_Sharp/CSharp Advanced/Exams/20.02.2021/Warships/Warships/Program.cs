using System;
using System.Linq;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var attackCommands = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var matrix = new char[size, size];


            int playerOne = 0;
            int playerTwo = 0;

            int shipsDestroyed = 0;



            for (int row = 0; row < size; row++)
            {
                var currRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currRow[col];

                    if (matrix[row, col] == '<')
                    {
                        playerOne++;
                    }
                    else if (matrix[row, col] == '>')
                    {
                        playerTwo++;
                    }
                }
            }


            for (int i = 0; i < attackCommands.Length; i++)
            {
                int[] currCoordinates = attackCommands[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int rowAttacked = currCoordinates[0];
                int colAttacked = currCoordinates[1];

                if (CheckCoordinates(size, rowAttacked, colAttacked) == false)
                {
                    continue;
                }




                if ((matrix[rowAttacked, colAttacked] == '<') || (matrix[rowAttacked, colAttacked] == '>'))
                {
                    Attack(matrix, ref playerOne, ref playerTwo, ref shipsDestroyed, rowAttacked, colAttacked);
                }
                else if (matrix[rowAttacked, colAttacked] == '#')
                {
                    DetonateMine(size, matrix, ref playerOne, ref playerTwo, ref shipsDestroyed, rowAttacked, colAttacked);

                }


                if (playerOne == 0)
                {
                    Console.WriteLine($"Player Two has won the game! {shipsDestroyed} ships have been sunk in the battle.");
                    return;
                }
                if (playerTwo == 0)
                {
                    Console.WriteLine($"Player One has won the game! {shipsDestroyed} ships have been sunk in the battle.");
                    return;
                }
            }


            Console.WriteLine($"It's a draw! Player One has {playerOne} ships left. Player Two has {playerTwo} ships left.");






        }

        private static void DetonateMine(int size, char[,] matrix, ref int playerOne, ref int playerTwo, ref int shipsDestroyed, int rowAttacked, int colAttacked)
        {
            matrix[rowAttacked, colAttacked] = 'X';

            if (CheckCoordinates(size, rowAttacked - 1, colAttacked))
            {
                Attack(matrix, ref playerOne, ref playerTwo, ref shipsDestroyed, rowAttacked - 1, colAttacked);
            }
            if (CheckCoordinates(size, rowAttacked - 1, colAttacked - 1))
            {
                Attack(matrix, ref playerOne, ref playerTwo, ref shipsDestroyed, rowAttacked - 1, colAttacked - 1);
            }
            if (CheckCoordinates(size, rowAttacked - 1, colAttacked + 1))
            {
                Attack(matrix, ref playerOne, ref playerTwo, ref shipsDestroyed, rowAttacked - 1, colAttacked + 1);
            }
            if (CheckCoordinates(size, rowAttacked, colAttacked - 1))
            {
                Attack(matrix, ref playerOne, ref playerTwo, ref shipsDestroyed, rowAttacked, colAttacked - 1);
            }
            if (CheckCoordinates(size, rowAttacked, colAttacked + 1))
            {
                Attack(matrix, ref playerOne, ref playerTwo, ref shipsDestroyed, rowAttacked, colAttacked + 1);
            }


            if (CheckCoordinates(size, rowAttacked + 1, colAttacked))
            {
                Attack(matrix, ref playerOne, ref playerTwo, ref shipsDestroyed, rowAttacked + 1, colAttacked);
            }
            if (CheckCoordinates(size, rowAttacked + 1, colAttacked - 1))
            {
                Attack(matrix, ref playerOne, ref playerTwo, ref shipsDestroyed, rowAttacked + 1, colAttacked - 1);
            }
            if (CheckCoordinates(size, rowAttacked + 1, colAttacked + 1))
            {
                Attack(matrix, ref playerOne, ref playerTwo, ref shipsDestroyed, rowAttacked + 1, colAttacked + 1);
            }
        }




        private static void Attack(char[,] matrix, ref int playerOne, ref int playerTwo, ref int shipsDestroyed, int row, int col)
        {
            if (matrix[row, col] == '<')
            {
                matrix[row, col] = 'X';
                playerOne--;
                shipsDestroyed++;
            }
            else if (matrix[row, col] == '>')
            {
                matrix[row, col] = 'X';
                playerTwo--;
                shipsDestroyed++;
            }
        }

        private static bool CheckCoordinates(int size, int row, int col)
        {
            return (row >= 0 && row < size
                && col >= 0 && col < size);
        }
    }
}
