using System;
using System.Numerics;

namespace Tribonacci_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(' ',Tribonacci(n)));

        }

        public static BigInteger[] Tribonacci(int n)
        {
            BigInteger[] result = new BigInteger[n];

            switch (n)
            {
                case 1:
                    result[0] = 1;
                    break;

                case 2:
                    result[0] = 1;
                    result[1] = 1;
                    break;

                case 3:
                    result[0] = 1;
                    result[1] = 1;
                    result[2] = 2;
                    break;

                default:
                    result[0] = 1;
                    result[1] = 1;
                    result[2] = 2;

                    BigInteger currNum = 0;
                    for (int i = 3; i < n; i++)
                    {
                        currNum = result[i - 1] + result[i - 2] + result[i - 3];
                        result[i] = currNum;
                    }
                    break;
            }

            return result;

        }
    }
}
