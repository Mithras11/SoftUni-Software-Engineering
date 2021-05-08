using System;
using System.Text;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());


            char[,] matrix = new char[size, size];

            int currentRow = -1;
            int currentColumn = -1;
            int firstPillarRow = -1;
            int firstPillarColumn = -1;
            int secondPillarRow = -1;
            int secondPillarColumn = -1;


            for (int row = 0; row < size; row++)
            {
                char[] tokens = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {

                    matrix[row, col] = tokens[col];

                    if (matrix[row, col] == 'S')
                    {
                        currentRow = row;
                        currentColumn = col;
                    }
                    else if (matrix[row, col] == 'O')
                    {
                        if (firstPillarRow < 0 && firstPillarColumn < 0)
                        {
                            firstPillarRow = row;
                            firstPillarColumn = col;
                        }
                        else
                        {
                            secondPillarRow = row;
                            secondPillarColumn = col;
                        }

                    }
                }
            }

            int newRow;
            int newColumn;

            int money = 0;

            bool outIfBakery = false;
            bool enoughMoney = false;



            while (true)
            {
                newRow = currentRow;
                newColumn = currentColumn;

                var command = Console.ReadLine();


                if (command == "up")
                {
                    newRow--;

                }

                else if (command == "down")
                {
                    newRow++;
                }

                else if (command == "left")
                {
                    newColumn--;

                }
                else if (command == "right")
                {
                    newColumn++;
                }



                if (CheckIndexIsOutOfRange(newRow, newColumn, size))
                {
                    outIfBakery = true;
                    break;

                }
                else
                {
                    matrix[currentRow, currentColumn] = '-';

                    currentRow = newRow;
                    currentColumn = newColumn;
                }



                if (matrix[currentRow, currentColumn] == 'O')
                {
                    matrix[currentRow, currentColumn] = '-';

                    currentRow = secondPillarRow;
                    currentColumn = secondPillarColumn;

                   
                }
                else if (Char.IsDigit(matrix[currentRow, currentColumn]))
                {
                    money += (int)char.GetNumericValue(matrix[currentRow, currentColumn]);

                    if (money >= 50)
                    {


                        enoughMoney = true;
                        break;
                    }
                }

            }

            if (enoughMoney)
            {
                matrix[currentRow, currentColumn] = 'S';
                Console.WriteLine("Good news! You succeeded in collecting enough money!");

            }

            else if (outIfBakery)
            {
                matrix[currentRow, currentColumn] = '-';

                Console.WriteLine("Bad news, you are out of the bakery.");
            }


            Console.WriteLine($"Money: {money}");


            PrintMatrix(matrix, size);



        }



        static bool CheckIndexIsOutOfRange(int currentRow, int currentColumn, int matrixSize)
        {
            if (currentColumn >= matrixSize || currentColumn < 0
                || currentRow >= matrixSize || currentRow < 0)
            {

                return true;
            }

            return false;

        }


        static void PrintMatrix(char[,] matrix, int size)
        {

            for (int row = 0; row < size; row++)
            {

                for (int col = 0; col < size; col++)
                {

                    Console.Write(matrix[row, col]);

                }
                Console.WriteLine();
            }
        }

    }





}

