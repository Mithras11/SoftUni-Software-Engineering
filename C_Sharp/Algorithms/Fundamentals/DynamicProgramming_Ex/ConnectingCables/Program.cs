using System;
using System.Linq;

namespace ConnectingCables
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var second = first.OrderBy(x => x).ToArray();
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
                        matrix[r, c] = Math.Max(
                            matrix[r - 1, c],
                            matrix[r, c - 1]);
                    }
                }
            }

            Console.WriteLine($"Maximum pairs connected: {matrix[first.Length, second.Length]}");
        }
    }
}
