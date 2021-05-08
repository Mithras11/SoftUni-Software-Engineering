using System;

namespace EncryptSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int stringNum = int.Parse(Console.ReadLine());
            int[] sums = new int[stringNum];

            for (int i = 0; i < stringNum; i++)
            {
                string input = Console.ReadLine();
                char[] charInput = input.ToCharArray();
                int currentChar = 0;
                int currentSum = 0;

                foreach (char c in charInput)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'||
                        c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                    {
                        currentChar = (int)c * input.Length;
                    }
                    else
                    {
                        currentChar = (int)c / input.Length;
                    }

                    currentSum += currentChar;
                }
                sums[i] += currentSum;
            }

            Array.Sort(sums);

            for (int i = 0; i < sums.Length; i++)
            {
                Console.WriteLine(sums[i]);
            }





        }
    }
}
