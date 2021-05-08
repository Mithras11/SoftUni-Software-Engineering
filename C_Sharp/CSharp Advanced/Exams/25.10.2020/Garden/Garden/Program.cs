using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < size[0]; row++)
            {
                for (int col = 0; col < size[1]; col++)
                {
                    matrix[row, col] = 0;
                }
            }
                        

            var plantedFLowers = new Dictionary<int, int>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] coordinates = input.Split().Select(int.Parse).ToArray();

                int currRow = coordinates[0];
                int currColumn = coordinates[1];


                if (currRow < 0 || currRow >= size[0]
                    || currColumn < 0 || currColumn >= size[1])
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }

                matrix[currRow, currColumn] = -1;
                plantedFLowers.Add(currRow, currColumn);

            }

            foreach (var flower in plantedFLowers)
            {

                for (int i = 0; i < size[1]; i++)
                {
                    matrix[flower.Key, i] += 1;
                }

                for (int i = 0; i < size[0]; i++)
                {
                    matrix[i, flower.Value] += 1;
                }
            }



            for (int row = 0; row < size[0]; row++)
            {
                var sb = new StringBuilder();

                for (int col = 0; col < size[1]; col++)
                {
                    sb.Append(matrix[row, col]);
                    sb.Append(" ");
                }
                Console.WriteLine(sb.ToString());
            }






        }
    }
}
