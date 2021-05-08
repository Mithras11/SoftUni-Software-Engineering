using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int box = int.Parse(Console.ReadLine());

                list.Add(box);
            }

            int[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            GenericSwap.SwapList(list, command);

        }
    }
}
