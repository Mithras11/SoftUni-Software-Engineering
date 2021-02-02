using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Froggy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var lake = new Lake(
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            var path = new List<int>();

            foreach (var stone in lake)
            {
                path.Add(stone);
            }

            Console.WriteLine(string.Join(", ", path));


        }
    }
}
