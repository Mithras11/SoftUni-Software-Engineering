using System;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var matrix = new char[size, size];

            string[] commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int playerR = 0;
            int playerC = 0;

            int totalCoals = 0;
            int collectedCoals = 0;

            for (int r = 0; r < size; r++)
            {
                var currRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = currRow[c];

                    if (matrix[r, c] == 's')
                    {
                        playerR = r;
                        playerC = c;
                    }
                    else if (matrix[r, c] == 'c')
                    {
                        totalCoals++;
                    }
                }
            }





            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    if (playerR - 1 < 0)
                    {
                        continue;
                    }

                    playerR--;


                }
                else if (commands[i] == "down")
                {
                    if (playerR + 1 == size)
                    {
                        continue;
                    }

                    playerR++;
                }
                else if (commands[i] == "left")
                {
                    if (playerC - 1 < 0)
                    {
                        continue;
                    }

                    playerC--;
                }
                else if (commands[i] == "right")
                {
                    if (playerC + 1 == size)
                    {
                        continue;
                    }

                    playerC++;
                }



                if (matrix[playerR, playerC] == 'c')
                {
                    matrix[playerR, playerC] = '*';
                    collectedCoals++;
                    totalCoals--;

                    if (totalCoals == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({playerR}, {playerC})");
                        return;
                    }

                }
                else if (matrix[playerR, playerC] == 'e')
                {
                    Console.WriteLine($"Game over! ({playerR}, {playerC})");
                    return;
                }
            }


            Console.WriteLine($"{totalCoals} coals left. ({playerR}, {playerC})");







        }
    }
}
