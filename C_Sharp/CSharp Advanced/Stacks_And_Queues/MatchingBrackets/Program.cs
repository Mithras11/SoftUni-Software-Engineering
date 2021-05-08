using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (symbol == '(')
                {
                    stack.Push(i);
                }
                else if (symbol == ')')
                {
                    int startIndex = stack.Pop();

                    Console.WriteLine(text.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}
