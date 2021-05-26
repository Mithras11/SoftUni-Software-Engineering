using System;
using System.Collections.Generic;
using System.Linq;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var second = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new int[first.Length + 1, second.Length + 1];

            for (int r = 1; r < matrix.GetLength(0); r++)
            {
                for (int c = 1; c < matrix.GetLength(1); c++)
                {
                    if (first[r - 1] == second[c - 1])
                    {
                        matrix[r, c] = matrix[r - 1, c - 1] + 1;
                    }
                    else
                    {
                        matrix[r, c] = Math.Max(matrix[r - 1, c], matrix[r, c - 1]);
                    }
                }
            }

            var rows = first.Length;
            var cols = second.Length;

            var path = new Stack<int>();

            while (rows > 0 && cols > 0)
            {
                if (first[rows - 1] == second[cols - 1])
                {
                    rows--;
                    cols--;
                    path.Push(first[rows]);
                }
                else
                {
                    if (matrix[rows - 1, cols] > matrix[rows, cols - 1])
                    {
                        rows--;
                    }
                    else
                    {
                        cols--;
                    }
                }
            }

            Console.WriteLine(string.Join(' ', path));
            Console.WriteLine(path.Count);
        }
    }
}
