using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

             ReadMiddleChar(text);

            
        }

        static void ReadMiddleChar(string text)
        {
            char middleChar = (char)0x00;

            if (text.Length % 2 != 0)
            {
                int i = text.Length / 2;
                middleChar = text[i];

                Console.WriteLine(middleChar);
            }
            else
            {
                int i = text.Length / 2;
                middleChar = text[i-1];

                Console.Write(middleChar);
                
                middleChar = text[i];

                Console.Write(middleChar);
            }
        }
    }
}
// 12345678