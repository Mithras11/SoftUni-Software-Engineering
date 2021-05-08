using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[][] matrix = new string[size[0]][];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            }

            string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "END")
            {


                if (tokens.Length == 5 &&
                   tokens[0] == "swap")
                {
                    int rowX = int.Parse(tokens[1]);
                    int colX = int.Parse(tokens[2]);
                    int rowY = int.Parse(tokens[3]);
                    int colY = int.Parse(tokens[4]);

                    if (rowX >= 0 && rowX < size[0] &&
                        colX >= 0 && colX < size[1] &&
                        rowY >= 0 && rowY < size[0] &&
                        colY >= 0 && colY < size[1])
                    {
                        string temp = matrix[rowX][colX];
                        matrix[rowX][colX] = matrix[rowY][colY];
                        matrix[rowY][colY] = temp;

                        foreach (string[] row in matrix)
                        {
                            Console.WriteLine(string.Join(' ', row));
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }


                tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }


        }


    }
}
