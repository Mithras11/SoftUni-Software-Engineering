using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(clothes);

            int rackCapacity = int.Parse(Console.ReadLine());
            int racks = 1;

            int sum = 0;

            while (stack.Count > 0)
            {

                if (sum + stack.Peek() <= rackCapacity)
                {
                    sum += stack.Pop();
                }
                else
                {
                    racks++;
                    sum = stack.Pop();
                }

            }

            Console.WriteLine(racks);




        }
    }
}
