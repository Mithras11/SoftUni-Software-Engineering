using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace MultiplyBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();

            while (x[0] == '0')
            {
                x = x.Remove(0, 1);
            }

            int y = int.Parse(Console.ReadLine());
            string z = string.Empty;

            StringBuilder sb = new StringBuilder();

            int currentDigit = 0;
            int remainder = 0;

            if (y == 0)
            {
                Console.WriteLine(0);
                return;
            }
            else
            {
                for (int i = x.Length - 1; i >= 0; i--)
                {
                    currentDigit = (int.Parse(x[i].ToString())) * y + remainder;
                    remainder = 0;

                    if (currentDigit >= 10)
                    {
                        remainder = currentDigit / 10;
                        currentDigit %= 10;
                    }

                    sb.Append(currentDigit);
                }

                if (remainder != 0)
                {
                    sb.Append(remainder);
                }

                char[] arr = sb.ToString().ToCharArray();
                Array.Reverse(arr);
                z = new string(arr);


                Console.WriteLine(z);


            }


        }
    }
}
