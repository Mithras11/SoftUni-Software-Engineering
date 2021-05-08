using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Stack<int> stack = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int items = 0;

            while (queue.Any() && stack.Any())
            {
                if ((queue.Peek() + stack.Peek()) % 2 == 0)
                {
                    items += (queue.Dequeue() + stack.Pop());

                }
                else
                {
                    queue.Enqueue(stack.Pop());
                }

            }

            if (queue.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (items >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {items}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {items}");
            }

        }
    }
}
