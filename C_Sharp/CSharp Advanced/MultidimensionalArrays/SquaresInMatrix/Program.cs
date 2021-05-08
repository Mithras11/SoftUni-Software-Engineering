using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int count = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char ch1 = matrix[row, col];
                    char ch2 = matrix[row, col + 1];
                    char ch3 = matrix[row + 1, col];
                    char ch4 = matrix[row + 1, col + 1];

                    if (CompareChars(ch1, ch2, ch3, ch4))
                    {
                        count++;
                    }

                   

                }

            }

            Console.WriteLine(count);
        }

        public static bool CompareChars(char ch1, char ch2, char ch3, char ch4)
        {
            bool result = false;

            if (ch1.Equals(ch2) &&
                ch1.Equals(ch3) &&
                ch1.Equals(ch4))
            {
                result = true;
            }

            return result;
        }
    }
}
