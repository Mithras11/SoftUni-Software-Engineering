using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

                matrix[row] = new int[nums.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = nums[col];
                }
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split();

                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row >= matrix.Length || row < 0 || col >= matrix[row].Length || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (tokens[0] == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (tokens[0] == "Subtract")
                    {
                        matrix[row][col] -= value;

                    }
                }

                input = Console.ReadLine();
            }


            foreach (int[] array in matrix)
            {
                Console.WriteLine(string.Join(' ', array));
            }
        }
    }
}
