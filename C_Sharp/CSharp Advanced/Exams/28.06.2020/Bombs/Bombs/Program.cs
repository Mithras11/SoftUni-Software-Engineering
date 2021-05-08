using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {

            var effects = new Queue<int>(
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            var casings = new Stack<int>(
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int datura = 0; //40
            int cherry = 0; //60
            int smoke = 0;  //120
                        

            int currBomb = effects.Dequeue() + casings.Pop();

            while (true)
            {

                if (currBomb == 40)
                {
                    datura++;
                }
                else if (currBomb == 60)
                {
                    cherry++;
                }
                else if (currBomb == 120)
                {
                    smoke++;
                }
                else
                {
                    currBomb -= 5;
                    continue;
                }



                if (datura >= 3 && cherry >= 3 && smoke >= 3)
                {
                    break;
                }

                if (effects.Any() && casings.Any())
                {
                    currBomb = effects.Dequeue() + casings.Pop();
                }
                else
                {
                    break;
                }

            }

            if (datura >= 3 && cherry >= 3 && smoke >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (!effects.Any())
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effects)}");
            }


            if (!casings.Any())
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casings)}");
            }

            Console.WriteLine($"Cherry Bombs: {cherry}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smoke}");


        }



    }
}
