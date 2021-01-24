using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> nums = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int controlSum = 0;

            while (controlSum < nums.Sum())
            {
                if (nums.Peek() % 2 == 0)
                {
                    controlSum += nums.Peek();

                    nums.Enqueue(nums.Dequeue());
                }
                else
                {
                    nums.Dequeue();
                }
            }



            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
