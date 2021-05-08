using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new Stack<int>();
            var threads = new Queue<int>();


            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList()
                .ForEach(x => tasks.Push(x));

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList()
                .ForEach(x => threads.Enqueue(x));


            int taskToKill = int.Parse(Console.ReadLine());
                       
            int winningThread = 0;

            while (true)
            {
                if (tasks.Peek() == taskToKill)
                {
                    winningThread = threads.Peek();
                    break;
                }


                if (threads.Peek() >= tasks.Peek())
                {                   

                    tasks.Pop();
                }

                threads.Dequeue();
            }


            Console.WriteLine($"Thread with value {winningThread} killed task {taskToKill}");
            Console.WriteLine(string.Join(' ',threads));

        }
    }
}
