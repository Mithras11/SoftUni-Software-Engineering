using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;
            int number = 0;

            Dictionary<string, int> resources = new Dictionary<string, int>();

            while ((text = Console.ReadLine()) != "stop")
            {
                number = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(text))
                {
                    resources[text] += number;
                }
                else
                {
                    resources.Add(text, number);
                }

            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
