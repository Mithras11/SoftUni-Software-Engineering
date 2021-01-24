using System;
using System.Collections.Generic;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;

            HashSet<string> names = new HashSet<string>();


            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();

                if (names.Contains(input) == false)
                {
                    names.Add(input);
                }
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
