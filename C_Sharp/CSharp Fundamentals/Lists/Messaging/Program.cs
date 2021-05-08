using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            char[] input = Console.ReadLine()
                .ToCharArray();

            List<char> text = input.ToList();



            foreach (var num in numbers)
            {
                int sumOfDigits = 0;
                int currentNumber = num;

                while (currentNumber != 0)
                {
                    sumOfDigits += currentNumber % 10;
                    currentNumber /= 10;
                }

                int currentIndex = sumOfDigits;

                if (currentIndex >= text.Count)
                {
                    currentIndex -= text.Count;
                }


                    char currentChar = text[currentIndex];

                    Console.Write(currentChar);

                    text.RemoveAt(currentIndex);





            }
        }
    }
}
// 01234
// 012345