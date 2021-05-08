
using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string str1 = arr[0];
            string str2 = arr[1];

            int sum = Sum(str1, str2);
            Console.WriteLine(sum);

        }

        static int Sum(string str1, string str2)
        {
            int sum = 0;

            int result = string.Compare(str1, str2);


            if (result == 0)
            {
                int multiple = 0;
                for (int i = 0; i < str1.Length; i++)
                {
                    multiple = str1[i] * str2[i];
                    sum += multiple;
                }
            }

            else if (result == -1)
            {
                int multiple = 0;

                for (int i = 0; i < str1.Length; i++)
                {
                    multiple = str1[i] * str2[i];
                    sum += multiple;
                }

                for (int i = str1.Length; i < str2.Length; i++)
                {
                    sum += str2[i];
                }
            }
            else if (result == 1)
            {
                int multiple = 0;

                for (int i = 0; i < str2.Length; i++)
                {
                    multiple = str1[i] * str2[i];
                    sum += multiple;
                }

                for (int i = str2.Length; i < str1.Length; i++)
                {
                    sum += str1[i];
                }
            }

            return sum;
        }
    }
}
