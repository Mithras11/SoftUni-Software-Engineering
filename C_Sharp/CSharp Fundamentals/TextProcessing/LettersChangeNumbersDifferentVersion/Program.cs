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
                    result = number  / firstNumber;
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

            switch (letter.ToString().ToUpper())
            {
                case "A":
                    result = 1;
                    break;
                case "B":
                    result = 2;
                    break;
                case "C":
                    result = 3;
                    break;
                case "D":
                    result = 4;
                    break;
                case "E":
                    result = 5;
                    break;
                case "F":
                    result = 6;
                    break;
                case "G":
                    result = 7;
                    break;
                case "H":
                    result = 8;
                    break;
                case "I":
                    result = 9;
                    break;
                case "J":
                    result = 10;
                    break;
                case "K":
                    result = 11;
                    break;
                case "L":
                    result = 12;
                    break;
                case "M":
                    result = 13;
                    break;
                case "N":
                    result = 14;
                    break;
                case "O":
                    result = 15;
                    break;
                case "P":
                    result = 16;
                    break;
                case "Q":
                    result = 17;
                    break;
                case "R":
                    result = 18;
                    break;
                case "S":
                    result = 19;
                    break;
                case "T":
                    result = 20;
                    break;
                case "U":
                    result = 21;
                    break;
                case "V":
                    result = 22;
                    break;
                case "W":
                    result = 23;
                    break;
                case "X":
                    result = 24;
                    break;
                case "Y":
                    result = 25;
                    break;
                case "Z":
                    result = 26;
                    break;
            }
            return result;
        }
    }
}
