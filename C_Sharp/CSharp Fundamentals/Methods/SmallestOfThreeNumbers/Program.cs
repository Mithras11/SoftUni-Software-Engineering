using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); 
            int b = int.Parse(Console.ReadLine()); 
            int c = int.Parse(Console.ReadLine());

            int result = CompareNumbers(a, b, c);

            Console.WriteLine(result);
        }

        static int CompareNumbers(int num1, int num2, int num3)
        {
            int result = 0;

            int[] nums = { num1, num2, num3 };

            Array.Sort(nums);

            result = nums[0];

            return result;

        }
    }
}
