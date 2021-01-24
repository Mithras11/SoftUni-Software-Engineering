using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] message = Console.ReadLine()
                .ToCharArray();


            List<int> numbers = new List<int>();
            List<char> nonNumbers = new List<char>();

            for (int i = 0; i < message.Length; i++)
            {
                char currentChar = message[i];

                if (Char.IsDigit(currentChar))
                {
                    numbers.Add((int)Char.GetNumericValue(currentChar));
                }
                else
                {
                    nonNumbers.Add(currentChar);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }


            int counter = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                int takeSteps = takeList[i];

                for (int j = counter; j < counter + takeSteps; j++)
                {
                    if (j >= nonNumbers.Count)
                    {
                        return;
                    }
                    char currentChar = nonNumbers[j];
                    Console.Write(currentChar);
                }

                counter += takeSteps;

                int skipSteps = skipList[i];

                counter += skipSteps;

            }












        }
    }
}
