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
            int result = 0;

            if (str1.Length == str2.Length)
            {
                int multiple = 0;
                for (int i = 0; i < str1.Length; i++)
                {
                    multiple = str1[i] * str2[i];
                    result += multiple;
                }
            }
            else
            {
                if (str1.Length < str2.Length)
                {
                    int multiple = 0;

                    for (int i = 0; i < str1.Length; i++)
                    {
                        multiple = str1[i] * str2[i];
                        result += multiple;
                    }

                    for (int i = str1.Length; i < str2.Length; i++)
                    {
                        result += str2[i];
                    }
                }
                else
                {
                    int multiple = 0;

                    for (int i = 0; i < str2.Length; i++)
                    {
                        multiple = str1[i] * str2[i];
                        result += multiple;
                    }

                    for (int i = str2.Length; i < str1.Length; i++)
                    {
                        result += str1[i];
                    }
                }

            }


            return result;
        }
    }
}
