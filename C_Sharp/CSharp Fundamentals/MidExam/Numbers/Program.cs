using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            double average = numbers.Average();

            List<int> greaterNums = new List<int>();
            foreach (int number in numbers)
            {
                if (number > average)
                {
                    greaterNums.Add(number);
                }
            }

            greaterNums.Sort();

            greaterNums.Reverse();

            List<int> topNums = new List<int>();

            if (greaterNums.Count >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    topNums.Add(greaterNums[i]);
                }

            }
            else
            {
                for (int i = 0; i < greaterNums.Count; i++)
                {
                    topNums.Add(greaterNums[i]);
                }
            }

            if (topNums.Count==0)
            {
                Console.WriteLine("No");
            }
            else
            {
            Console.WriteLine(string.Join(' ',topNums));

            }





        }
    }
}
