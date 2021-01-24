using System;
using System.Collections.Generic;

namespace BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            bool isInvalid = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                {
                    stack.Push(input[i]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        isInvalid = true;
                    }
                    else if ((input[i] == '}' && stack.Peek() == '{')
                        || (input[i] == ']' && stack.Peek() == '[')
                        || (input[i] == ')' && stack.Peek() == '('))
                    {
                        stack.Pop();

                    }
                    else
                    {
                        isInvalid = true;
                    }
                }


                if (isInvalid)
                {
                    break;
                }
            }

            if (stack.Count > 0)
            {
                isInvalid = true;
            }

            if (isInvalid)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }


        }
    }
}
