using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));


            string[] token = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (token[0].ToLower() != "end")
            {
                switch (token[0].ToLower())
                {
                    case "add":

                        int num1 = int.Parse(token[1]);
                        int num2 = int.Parse(token[2]);

                        stack.Push(num1);
                        stack.Push(num2);

                        break;

                    case "remove":

                        int count = int.Parse(token[1]);

                        if (count <= stack.Count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                stack.Pop();
                            }
                        }


                        break;
                }

                token = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            int sum = 0;

            while (stack.Count > 0)
            {
                sum += stack.Pop();

            }


            Console.WriteLine($"Sum: {sum}");


        }
    }
}
