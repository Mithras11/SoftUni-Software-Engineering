using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i <nums.Count; i++)
            {
                if (nums[i]== nums[i+1])
                {
                    nums[i] += nums[i + 1];
                    nums.RemoveAt(i + 1);
                    i -= 1;
                }


            }
            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
