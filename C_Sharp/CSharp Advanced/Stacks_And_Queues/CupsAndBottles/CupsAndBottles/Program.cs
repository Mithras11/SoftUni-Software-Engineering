using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cups = new Queue<int>(
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            var bottles = new Stack<int>(
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int currentCup;
            int currentBottle;

            int wastedWater = 0;

            while (cups.Any() && bottles.Any())
            {
                currentCup = cups.Peek();
                currentBottle = bottles.Peek();

                if (currentCup <= currentBottle)
                {
                    cups.Dequeue();
                    bottles.Pop();

                    wastedWater += (currentBottle - currentCup);
                }
                else
                {
                    while (true)
                    {
                        currentCup -= currentBottle;
                        bottles.Pop();

                        if (currentCup <= 0)
                        {
                            cups.Dequeue();
                            wastedWater += (Math.Abs(currentCup));

                            break;

                        }
                        currentBottle = bottles.Peek();
                    }



                }


            }

            var result = new StringBuilder();

            if (cups.Any())
            {

                result.AppendJoin(' ', cups);


                Console.WriteLine($"Cups: {result.ToString()}");
            }
            else if (bottles.Any())
            {
                result.AppendJoin(' ', bottles);

                Console.WriteLine($"Bottles: {result.ToString()}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");


        }
    }
}
