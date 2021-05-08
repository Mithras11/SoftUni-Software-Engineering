using System;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var matrix = new char[size, size];

            int snakeRow = 0;
            int snakeCol = 0;

            int firstBurrowRow = 0;
            int firstBurrowCol = 0;

            int secondBurrowRow = 0;
            int secondBurrowCol = 0;


            for (int row = 0; row < size; row++)
            {
                var currRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currRow[col];

                    if (currRow[col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                    else if (currRow[col] == 'B')
                    {
                        if (firstBurrowRow == 0 && firstBurrowCol == 0)
                        {
                            firstBurrowRow = row;
                            firstBurrowCol = col;
                        }
                        else
                        {
                            secondBurrowRow = row;
                            secondBurrowCol = col;
                        }
                    }
                }

            }


            string command = string.Empty;

            int foodEaten = 0;

            while (true)
            {
                command = Console.ReadLine();

                matrix[snakeRow, snakeCol] = '.';

                if (command == "up")
                {
                    snakeRow--;

                    if (!CheckBoundaries(size, snakeRow, snakeCol))
                    {
                        Console.WriteLine("Game over!");
                        break;
                    }

                }
                else if (command == "down")
                {
                    snakeRow++;

                    if (!CheckBoundaries(size, snakeRow, snakeCol))
                    {
                        Console.WriteLine("Game over!");
                        break;
                    }
                }
                else if (command == "left")
                {
                    snakeCol--;

                    if (!CheckBoundaries(size, snakeRow, snakeCol))
                    {
                        Console.WriteLine("Game over!");
                        break;
                    }
                }
                else if (command == "right")
                {
                    snakeCol++;

                    if (!CheckBoundaries(size, snakeRow, snakeCol))
                    {
                        Console.WriteLine("Game over!");
                        break;
                    }
                }

                if (matrix[snakeRow, snakeCol] == '*')
                {
                    foodEaten++;

                }
                else if (snakeRow == firstBurrowRow && snakeCol == firstBurrowCol)
                {
                    matrix[snakeRow, snakeCol] = '.';

                    snakeRow = secondBurrowRow;
                    snakeCol = secondBurrowCol;
                }



                matrix[snakeRow, snakeCol] = 'S';

                if (foodEaten == 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    break;
                }
            }

            Console.WriteLine($"Food eaten: {foodEaten}");
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

        private static bool CheckBoundaries(int size, int snakeRow, int snakeCol)
        {
            if (snakeRow < 0 || snakeRow >= size
               || snakeCol < 0 || snakeCol >= size)
            {
                return false;
            }

            return true;
        }
    }
}
