using System;
using System.Linq;

namespace RecursiveArraySum
{
    class RecursiveArraySum
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var result = Sum(arr, 0);

            Console.WriteLine(result);
        }

        static int Sum(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }

            return arr[index] + Sum(arr, index + 1);
        }
    }
}
