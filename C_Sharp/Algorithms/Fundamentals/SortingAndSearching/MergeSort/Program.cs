using System;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        static int[] arr;

        static void Main(string[] args)
        {
            arr = ReadArray();
            var result = Sort(arr);

            Print(result);
        }

        private static int[] Sort(int[] arr)
        {
            int[] left;
            int[] right;
            int[] result;


            //base case
            if (arr.Length <= 1)
            {
                return arr;
            }


            //initialize subarrays

            int midPoint = arr.Length / 2;

            left = new int[midPoint];

            if (arr.Length % 2 == 0)
            {
                right = new int[midPoint];
            }
            else
            {
                right = new int[midPoint + 1];
            }


            //populate subarrays

            for (int i = 0; i < midPoint; i++)
            {
                left[i] = arr[i];
            }

            int k = 0;

            for (int j = midPoint; j < arr.Length; j++)
            {
                right[k] = arr[j];
                k++;
            }


            //recursively sort subarrays
            left = Sort(left);
            right = Sort(right);

            //merge sorted subarrays
            result = Merge(left, right);

            return result;
        }


        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];

            int leftIndx = 0;
            int rightIndx = 0;
            int resultIndx = 0;

            //while either array still has elements
            while (true)
            {

                if (leftIndx == left.Length && rightIndx == right.Length)
                {
                    break;
                }


                //if both have elements
                if (leftIndx < left.Length && rightIndx < right.Length)
                {
                    if (left[leftIndx] <= right[rightIndx])
                    {
                        result[resultIndx] = left[leftIndx];
                        leftIndx++;
                    }
                    else
                    {
                        result[resultIndx] = right[rightIndx];
                        rightIndx++;
                    }
                }

                //if only left array has elements
                else if (leftIndx < left.Length)
                {
                    result[resultIndx] = left[leftIndx];
                    leftIndx++;
                }

                //if only right has elements
                else if (rightIndx < right.Length)
                {
                    result[resultIndx] = right[rightIndx];
                    rightIndx++;
                }

                resultIndx++;

            }


            return result;
        }

        private static int[] ReadArray()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
        private static void Print(int[] result)
        {
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
