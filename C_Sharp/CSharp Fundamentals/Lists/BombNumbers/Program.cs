using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bombNumber = input[0];
            int bombPower = input[1];

            int bombIndex = numbers.IndexOf(bombNumber);

            while (bombIndex != -1)
            {
                int indexLeftNumbers = bombIndex - bombPower;
                int indexRightNumbers = bombIndex + bombPower;

                if (indexLeftNumbers < 0)
                {
                    indexLeftNumbers = 0;
                }
                else if (indexRightNumbers > numbers.Count - 1)
                {
                    indexRightNumbers = numbers.Count - 1;
                }

                numbers.RemoveRange(indexLeftNumbers, indexRightNumbers - indexLeftNumbers + 1);



                bombIndex = numbers.IndexOf(bombNumber);
            }

            Console.WriteLine(numbers.Sum());






        }
    }
}
