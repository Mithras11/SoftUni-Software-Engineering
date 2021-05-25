using System;

namespace WordDifferences
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine();
            var second = Console.ReadLine();

            var matrix = new int[first.Length + 1, second.Length + 1];

            for (int r = 1; r < matrix.GetLength(0); r++)
            {
                matrix[r, 0] = r;
            }

            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                matrix[0, c] = c;
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
                        matrix[r, c] = Math.Min(
                            matrix[r - 1, c] + 1,
                            matrix[r, c - 1] + 1);
                    }
                }
            }

            Console.WriteLine($"Deletions and Insertions: {matrix[first.Length, second.Length]}");
        }
    }
}
