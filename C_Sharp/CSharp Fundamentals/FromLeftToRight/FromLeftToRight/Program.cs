using System;
using System.Numerics;

namespace FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string num = Console.ReadLine();

                bool isRightNum = false;
                string leftNum = "";
                string rightNum = "";

                for (int j = 0; j < num.Length; j++)
                {
                    char currentDigit = num[j];

                    if (currentDigit == ' ')
                    {
                        isRightNum = true;
                        continue;
                    }

                    if (isRightNum == false)
                    {
                        leftNum += currentDigit;
                    }
                    else
                    {
                        rightNum += currentDigit;
                    }

                }
                BigInteger right = BigInteger.Parse(rightNum);
                BigInteger left = BigInteger.Parse(leftNum);
                BigInteger sum = 0;

                if (left >= right)
                {
                    while (left > 0)
                    {
                        sum += left % 10;
                        left /= 10;
                    }

                    Console.WriteLine(sum);
                }
                else
                {
                    while (right > 0)
                    {
                        sum += right % 10;
                        right /= 10;
                    }

                    Console.WriteLine(sum);
                }

            }
        }
    }
}
