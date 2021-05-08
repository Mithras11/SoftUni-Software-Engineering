using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();

            Stack<string> stack = new Stack<string>(input);

            while (stack.Count > 1)
            {
                int operand1 = int.Parse(stack.Pop());
                string @operator = stack.Pop();
                int operand2 = int.Parse(stack.Pop());

                int result = 0;

                if (@operator == "+")
                {
                     result = operand1 + operand2;

                }
                else if (@operator == "-")
                {
                    result = operand1 - operand2;
                }

                stack.Push(result.ToString());
            }

            Console.WriteLine(stack.Pop());




        }
    }
}
