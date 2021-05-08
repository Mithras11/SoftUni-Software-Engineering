using System;
using System.Linq;

namespace MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input < 0)
            {
                input = Math.Abs(input);
            }




            int sumEven = SumEven(input);
            int sumOdd = SumOdd(input);
            int multiplication = MultiplySums(sumEven, sumOdd);

            Console.WriteLine(multiplication);
        }

        static int SumEven(int input)
        {
            int sumEven = 0;

            string digits = input.ToString();

            for (int i = 0; i < digits.Length; i++)
            {
                int currentDigit = int.Parse(digits[i].ToString());

                if (currentDigit % 2 == 0)
                {
                    sumEven += currentDigit;
                }
            }

            return sumEven;
        }

        static int SumOdd(int input)
        {
            int sumOdd = 0;

            string digits = input.ToString();

            for (int i = 0; i < digits.Length; i++)
            {
                int currentDigit = int.Parse(digits[i].ToString());

                if (currentDigit % 2 != 0)
                {
                    sumOdd += currentDigit;
                }
            }
            return sumOdd;

        }

        static int MultiplySums(int sumEven, int sumOdd)
        {
            int multiplication = sumEven * sumOdd;

            return multiplication;
        }


    }
}
