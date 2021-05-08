using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());

            int barrelSize = int.Parse(Console.ReadLine());

            var bullets = new Stack<int>(
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray())
                ;
            var locks = new Queue<int>(
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int intelligence = int.Parse(Console.ReadLine());

            int loadedBullets = barrelSize;
            int shots = 0;



            while (bullets.Any() && locks.Any())
            {
                if (bullets.Peek() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");

                    locks.Dequeue();

                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                bullets.Pop();
                shots++;
                loadedBullets--;

                if (loadedBullets == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");

                    loadedBullets = barrelSize;
                }
            }

            if (bullets.Count == 0 && locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else if (locks.Count == 0)
            {
                int moneyEarned = intelligence - (shots * bulletPrice);

                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }

        }
    }
}
