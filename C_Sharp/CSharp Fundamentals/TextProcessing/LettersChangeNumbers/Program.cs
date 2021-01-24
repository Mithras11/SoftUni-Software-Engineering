using System;
using System.Linq;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            double finalSum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                string currentString = text[i];

                char firstLetter = currentString[0];
                char lastLetter = currentString[currentString.Length - 1];

                double number = double.Parse(currentString.Substring(1, currentString.Length - 2));


                int firstNumber = LetterPosition(firstLetter);
                int lastNumber = LetterPosition(lastLetter);

                double result = 0;

                if (Char.IsUpper(firstLetter))
                {
                    result = number / firstNumber;
                }
                else if (Char.IsLower(firstLetter))
                {
                    result = number * firstNumber;
                }

                if (Char.IsUpper(lastLetter))
                {
                    result -= lastNumber; ;
                }
                else if (Char.IsLower(lastLetter))
                {
                    result += lastNumber;
                }

                
                
                finalSum += result;
            }

            Console.WriteLine($"{finalSum:f2}");



        }

        static int LetterPosition(char letter)
        {
            int result = 0;

            if (Char.IsUpper(letter))
            {
                result = letter - 'A' + 1;
            }
            else if(Char.IsLower(letter))
            {
                result = letter - 'a' + 1;
            }
            return result;
        }
    }
}
