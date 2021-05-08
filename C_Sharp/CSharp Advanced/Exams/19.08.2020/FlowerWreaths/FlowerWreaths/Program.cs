using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {

            var input1 = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var lilies = new Stack<int>(input1);
                     


            var input2 = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var roses = new Queue<int>(input2);
                     

            int wreaths = 0;
            int currSum = 0;
            int storedFlowers = 0;

            while (lilies.Any()&&roses.Any())
            {

                currSum = lilies.Pop() + roses.Dequeue();

                while (currSum > 15)
                {
                    currSum -= 2;
                }

                if (currSum == 15)
                {
                    wreaths++;

                }

                else if (currSum < 15)
                {
                    storedFlowers += currSum;

                }

            }


            if (storedFlowers >= 15)
            {


                wreaths += storedFlowers / 15;


            }


            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                var neededWreaths = 5 - wreaths;

                Console.WriteLine($"You didn't make it, you need {neededWreaths} wreaths more!");
            }



        }



    }
}
