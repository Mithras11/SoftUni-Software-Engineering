using System;
using System.Linq;

namespace MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int currentLength = 1;
            int maxLength = 0;
            int start = 0;
            int bestStart = 0;


            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentLength++;
                    
                }
                else
                {
                    currentLength = 1;
                    start = i;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    bestStart = start;
                }
            }

            for (int i = bestStart; i < bestStart + maxLength; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
