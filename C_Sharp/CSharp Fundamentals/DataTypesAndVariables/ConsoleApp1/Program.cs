using System;

namespace RefactorSpecialNums
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            
            bool isSpecialNum = false;
            for (int ch = 1; ch <= n; ch++)
            {
               int digits = ch;
                while (ch > 0)
                {
                    sum += ch % 10;
                    ch = ch / 10;
                }
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", digits, isSpecialNum);
                sum = 0;
                ch = digits;
            }

        }
    }
}
