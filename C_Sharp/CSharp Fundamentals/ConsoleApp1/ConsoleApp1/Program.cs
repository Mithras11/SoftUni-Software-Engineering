using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);

            int currentNum = number;
            int totalSum = 0;


            for (int i = 0; i < input.Length; i++)
            {
                int currentDigit = currentNum % 10;

                int result = 1;

                while (currentDigit != 1)
                {
                    result *= currentDigit;
                    currentDigit--;
                }
                totalSum += result;

                currentNum = (currentNum - currentDigit) / 10;
            }

            if (totalSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}


