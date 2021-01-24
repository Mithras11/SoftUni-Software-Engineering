using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            Stack<string> stack = new Stack<string>();

            stack.Push(sb.ToString());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    case "1":

                        sb.Append(command[1]);

                        stack.Push(sb.ToString());

                        break;

                    case "2":

                        sb.Remove(sb.Length - int.Parse(command[1]), int.Parse(command[1]));

                        stack.Push(sb.ToString());

                        break;

                    case "3":

                        Console.WriteLine(sb[int.Parse(command[1]) - 1]);

                        break;

                    case "4":

                        stack.Pop();
                        sb.Clear();
                        sb.Append(stack.Peek());

                        break;
                }
            }
        }
    }
}
