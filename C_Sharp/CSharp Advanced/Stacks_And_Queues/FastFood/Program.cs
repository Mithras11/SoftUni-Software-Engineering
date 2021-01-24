using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());

            Queue<int> orders = new Queue<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));


            Console.WriteLine(orders.Max());

            bool enoughFood = true;

            while (orders.Count > 0)
            {

                if (food >= orders.Peek())
                {
                    food -= orders.Dequeue();


                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(' ', orders)}");

                    enoughFood = false;
                    break;
                }

            }

            if (enoughFood)
            {
                Console.WriteLine("Orders complete");
            }
            
        }
    }
}
