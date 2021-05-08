using System;
using System.Text;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var matrix = new char[size, size];



            int beeRow = 0;
            int beeCol = 0;



            char[] currRow;

            for (int row = 0; row < size; row++)
            {
                currRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currRow[col];

                    if (matrix[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }

                }
            }


            int pollinatedFlowers = 0;

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                matrix[beeRow, beeCol] = '.';

                if (command == "up")
                {
                    beeRow--;

                    if (!CheckBoundary(beeRow, beeCol, size))
                    {
                        break;
                    }

                    if (matrix[beeRow, beeCol] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';

                        beeRow--;
                    }

                }
                else if (command == "down")
                {
                    beeRow++;

                    if (!CheckBoundary(beeRow, beeCol, size))
                    {
                        break;
                    }

                    if (matrix[beeRow, beeCol] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';

                        beeRow++;
                    }
                }
                else if (command == "left")
                {
                    beeCol--;

                    if (!CheckBoundary(beeRow, beeCol, size))
                    {
                        break;
                    }

                    if (matrix[beeRow, beeCol] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';

                        beeCol--;
                    }
                }
                else if (command == "right")
                {
                    beeCol++;

                    if (!CheckBoundary(beeRow, beeCol, size))
                    {
                        break;
                    }

                    if (matrix[beeRow, beeCol] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';

                        beeCol++;
                    }
                }





                if (matrix[beeRow, beeCol] == 'f')
                {
                    pollinatedFlowers++;
                }


                matrix[beeRow, beeCol] = 'B';
            }

            if (pollinatedFlowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
            }

            var sb = new StringBuilder();

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    sb.Append(matrix[row, col]);
                }

                Console.WriteLine(sb.ToString().Trim());
                sb.Clear();
            }



        }

        private static bool CheckBoundary(int beeRow, int beeCol, int size)
        {
            if (beeRow < 0 || beeRow >= size
                    || beeCol < 0 || beeCol >= size)
            {

                Console.WriteLine("The bee got lost!");

                return false;
            }

            return true;


        }



    }
}
