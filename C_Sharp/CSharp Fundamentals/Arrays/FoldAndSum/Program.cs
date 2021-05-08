using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] firstNums = new int[k];

            for (int i = 0; i < k; i++)
            {
                firstNums[i] = arr[i];
            }



            int[] lastNums = new int[k];
            int[] reverseArr = arr.Reverse().ToArray();

            for (int i = 0; i < k; i++)
            {
                lastNums[i] = reverseArr[i];
            }

            int[] firstRow = firstNums.Reverse().Concat(lastNums).ToArray();

            int[] secondRow = new int[2 * k];



            for (int i = k, j = 0; i < arr.Length - k; i++, j++)
            {

                secondRow[j] = arr[i];

            }

            for (int i = 0; i < firstRow.Length; i++)
            {
                int n = firstRow[i] + secondRow[i];
                Console.Write($"{n} ");
            }








        }
    }
}
