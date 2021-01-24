using System;
using System.Linq;

namespace RoundingNums
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            int[] roundedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                roundedNums[i] =(int) Math.Round(nums[i], MidpointRounding.AwayFromZero);

                if (roundedNums[i]==-0)
                {
                    roundedNums[i] = 0;
                }

                if (nums[i]== 0)
                {
                    nums[i] = 0;
                }
            }

            for (int i = 0; i < roundedNums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} => {roundedNums[i]}");
            }

        }
    }
}
