using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            long[][] triangle = new long[size][];

            for (int row = 0; row < size; row++)
            {
                triangle[row] = new long[row + 1];
                triangle[row][0] = 1;
                triangle[row][triangle[row].Length - 1] = 1;

                if (row > 1)
                {
                    for (int i = 1; i < triangle[row].Length - 1; i++)
                    {
                        triangle[row][i] = triangle[row - 1][i] + triangle[row - 1][i - 1];
                    }
                }

                Console.WriteLine(string.Join(' ', triangle[row]));
            }




        }
    }
}
