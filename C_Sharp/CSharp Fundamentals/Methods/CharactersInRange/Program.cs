using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char lastChar = char.Parse(Console.ReadLine());

            PrintCharacters(firstChar, lastChar);


        }

        static void PrintCharacters(char firstChar, char lastChar)
        {
            char currentChar = (char)0x00;

            if (firstChar < lastChar)
            {
                for (int i = (int)firstChar + 1; i < (int)lastChar; i++)
                {
                    currentChar = (char)i;

                    Console.Write($"{currentChar} ");
                }

            }
            else
            {
                for (int i = (int)lastChar + 1; i < (int)firstChar; i++)
                {
                    currentChar = (char)i;

                    Console.Write($"{currentChar} ");
                }

            }



        }
    }
}
