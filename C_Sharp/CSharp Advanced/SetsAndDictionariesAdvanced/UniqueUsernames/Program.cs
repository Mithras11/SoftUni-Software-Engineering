using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                if (usernames.Contains(name) == false)
                {
                    usernames.Add(name);
                    Console.WriteLine(name);
                }
            }
        }
    }
}
