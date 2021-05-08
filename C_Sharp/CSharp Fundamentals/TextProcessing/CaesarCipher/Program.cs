using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Encrypt(text);


        }

        static void Encrypt(string text)
        {
            
            StringBuilder sb = new StringBuilder();
            char currentChar;

            for (int i = 0; i < text.Length; i++)
            {
                currentChar = (char)(text[i] + 3);
                sb.Append(currentChar);
            }

            Console.WriteLine(sb);

            
        }
    }
}
