using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int strength = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (currentChar == '>')
                {
                    strength += int.Parse(text[i + 1].ToString());
                }
                else if (currentChar != '>' && strength > 0)
                {
                    text = text.Remove(i, 1);
                    i--;
                    strength--;
                }
            }

            Console.WriteLine(text);
                



        }
    }
}
