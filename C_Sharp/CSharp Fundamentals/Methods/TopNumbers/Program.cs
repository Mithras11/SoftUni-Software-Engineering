using System;

namespace TopNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            CheckIfTopNumber(n);
        }

        static void CheckIfTopNumber(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int currentNum = i;
                int sumOfDigits = 0;
                int currentDigit = 0;
                int oddDigitsCount = 0;

                while (currentNum > 0)
                {
                    currentDigit = currentNum % 10;
                    sumOfDigits += currentDigit;
                    currentNum /= 10;

                    if (currentDigit % 2 != 0)
                    {
                        oddDigitsCount++;
                    }
                }

                if (sumOfDigits % 8 == 0 && oddDigitsCount != 0)
                {

                    Console.WriteLine(i);
                }


            }
        }
    }
}
