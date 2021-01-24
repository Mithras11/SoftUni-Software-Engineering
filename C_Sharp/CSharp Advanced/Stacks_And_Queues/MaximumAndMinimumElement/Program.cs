using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string token = Console.ReadLine();

                if (token[0] == '1')
                {
                    int currNum = token.Split().Select(int.Parse).ToArray()[1];

                    stack.Push(currNum);
                }
                else if (token[0] == '2' && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (token[0] == '3' && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (token[0] == '4' && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }


            }

            Console.WriteLine(string.Join(", ", stack));


        }
    }
}
