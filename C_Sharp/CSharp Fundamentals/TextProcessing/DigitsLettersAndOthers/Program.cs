using System;

namespace DigitsLettersAndOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string digits = string.Empty;
            string chars = string.Empty;
            string letters = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digits += input[i];
                }
                else if (char.IsLetter(input[i]))
                {
                    letters += input[i];
                }
                else 
                {
                    chars += input[i];
                }
            }

            Console.WriteLine($"{digits}\n{letters}\n{chars}");
        }
    }
}
