using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            //1233

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqualSum = false;
            

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }

                for (int k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }

                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    isEqualSum = true;
                    break;
                }
                
            }
            if (isEqualSum==false)
            {
                Console.WriteLine("no");
            }



        }
    }
}
