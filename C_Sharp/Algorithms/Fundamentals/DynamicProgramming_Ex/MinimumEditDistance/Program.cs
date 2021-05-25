using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimumEditDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            var replace = int.Parse(Console.ReadLine());
            var insert = int.Parse(Console.ReadLine());
            var delete = int.Parse(Console.ReadLine());

            var first = Console.ReadLine();
            var second = Console.ReadLine();

            var matrix = new int[first.Length + 1, second.Length + 1];

            for (int r = 1; r < matrix.GetLength(0); r++)
            {
                matrix[r, 0] = matrix[r - 1, 0] + delete;
            }

            for (int c = 1; c < matrix.GetLength(1); c++)
            {
                matrix[0, c] = matrix[0, c - 1] + insert;
            }




            for (int r = 1; r < matrix.GetLength(0); r++)
            {
                for (int c = 1; c < matrix.GetLength(1); c++)
                {
                    if (first[r - 1] == second[c - 1])
                    {
                        matrix[r, c] = matrix[r - 1, c - 1];
                    }
                    else
                    {
                        var neiboughrs = new List<int>(){
                            matrix[r - 1, c] + delete,
                            matrix[r, c - 1] + insert,
                            matrix[r - 1, c - 1] + replace };

                        matrix[r, c] = neiboughrs.Min();

                    }
                }
            }

            Console.WriteLine($"Minimum edit distance: {matrix[first.Length, second.Length]}");

        }
    }
}
