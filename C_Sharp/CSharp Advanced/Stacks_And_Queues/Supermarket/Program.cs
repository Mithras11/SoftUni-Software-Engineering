using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Queue<string> clients = new Queue<string>();

            while ((input = Console.ReadLine()) != "End")
            {
                if (input != "Paid")
                {
                    clients.Enqueue(input);
                }
                else
                {
                    while (clients.Count > 0)
                    {
                        Console.WriteLine(clients.Dequeue());
                    }
                }
            }

            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
