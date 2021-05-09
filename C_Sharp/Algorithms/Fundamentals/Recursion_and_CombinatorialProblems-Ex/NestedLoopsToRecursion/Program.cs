using System;

namespace NestedLoopsToRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var arr = new int[num];

            GetCombinations(num, arr, 0);
        }

        private static void GetCombinations(int num, int[] arr, int index)
        {
            if (index==num)
            {
                Print(arr);

                return;
            }


            for (int i = 1; i <= num; i++)
            {
                arr[index] = i;

                GetCombinations(num, arr, index + 1);
            }



        }

        private static void Print(int[] arr)
        {
            Console.WriteLine(string.Join(' ',arr));
        }
    }
}
