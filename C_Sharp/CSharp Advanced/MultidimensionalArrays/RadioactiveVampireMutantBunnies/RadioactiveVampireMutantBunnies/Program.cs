using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadioactiveVampireMutantBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[size[0], size[1]];



            int playerR = 0;
            int playerC = 0;

            for (int r = 0; r < size[0]; r++)
            {
                char[] currRow = Console.ReadLine().ToCharArray();

                for (int c = 0; c < size[1]; c++)
                {
                    matrix[r, c] = currRow[c];

                    if (matrix[r, c] == 'P')
                    {
                        playerR = r;
                        playerC = c;
                    }
                }
            }

            bool playerWins = false;
            bool playerDies = false;

            char[] commands = Console.ReadLine().ToCharArray();


            var bunnies = new Queue<int>();

            foreach (var command in commands)
            {
                matrix[playerR, playerC] = '.';

                if (command == 'U')
                {
                    if (playerR - 1 < 0)
                    {
                        playerWins = true;

                    }
                    else
                    {
                        playerR--;

                    }
                }
                else if (command == 'D')
                {
                    if (playerR + 1 == size[0])
                    {
                        playerWins = true;
                    }
                    else
                    {
                        playerR++;
                    }

                }
                else if (command == 'L')
                {
                    if (playerC - 1 < 0)
                    {
                        playerWins = true;
                    }
                    else
                    {
                        playerC--;
                    }


                }
                else if (command == 'R')
                {
                    if (playerC + 1 == size[1])
                    {
                        playerWins = true;
                    }
                    else
                    {
                        playerC++;
                    }
                }


                if (matrix[playerR, playerC] == 'B')
                {
                    playerDies = true;
                }
                else if (matrix[playerR, playerC] == '.' && playerWins == false)
                {
                    matrix[playerR, playerC] = 'P';
                }



                for (int r = 0; r < size[0]; r++)
                {
                    for (int c = 0; c < size[1]; c++)
                    {
                        if (matrix[r, c] == 'B')
                        {
                            bunnies.Enqueue(r);
                            bunnies.Enqueue(c);
                        }
                    }
                }

                while (bunnies.Any())
                {
                    int br = bunnies.Dequeue();
                    int bc = bunnies.Dequeue();

                    if (br - 1 >= 0)
                    {
                        if (matrix[br - 1, bc] != 'B')
                        {
                            if (matrix[br - 1, bc] == 'P')
                            {
                                playerDies = true;
                            }

                            matrix[br - 1, bc] = 'B';
                        }

                    }
                    if (br + 1 < size[0])
                    {
                        if (matrix[br + 1, bc] != 'B')
                        {
                            if (matrix[br + 1, bc] == 'P')
                            {
                                playerDies = true;
                            }

                            matrix[br + 1, bc] = 'B';
                        }

                    }
                    if (bc - 1 >= 0)
                    {
                        if (matrix[br, bc - 1] != 'B')
                        {
                            if (matrix[br, bc - 1] == 'P')
                            {
                                playerDies = true;
                            }
                            matrix[br, bc - 1] = 'B';
                        }


                    }
                    if (bc + 1 < size[1])
                    {
                        if (matrix[br, bc + 1] != 'B')
                        {

                            if (matrix[br, bc + 1] == 'P')
                            {
                                playerDies = true;
                            }
                            matrix[br, bc + 1] = 'B';
                        }


                    }
                }


                
                if (playerWins || playerDies)
                {
                    break;
                }

            }





            var sb = new StringBuilder();

            for (int r = 0; r < size[0]; r++)
            {
                for (int c = 0; c < size[1]; c++)
                {
                    sb.Append(matrix[r, c]);
                }

                Console.WriteLine(sb.ToString().Trim());
                sb.Clear();
            }




            if (playerWins)
            {
                Console.WriteLine($"won: {playerR} {playerC}");

            }
            else if (playerDies)
            {
                Console.WriteLine($"dead: {playerR} {playerC}");
            }



        }



    }
}
