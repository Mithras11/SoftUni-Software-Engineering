using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 0; i < n; i++)
            {
                char x = char.Parse(Console.ReadLine());
                int codeNum = (int)x;

                totalSum += codeNum;

            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
