using System;
using System.Collections.Generic;

namespace Help
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = new List<string>() { "ab", "bc", "cd", "de", "ef" };
            string x = string.Concat(nums[2], nums[3]);
            nums.RemoveRange(2, 2);
            nums.Insert(2, x);
            List<string> foo = new List<string>() { "sd", "jk", "lo" };
            nums.InsertRange(1, foo);
            Console.WriteLine();
        }
    }
}
