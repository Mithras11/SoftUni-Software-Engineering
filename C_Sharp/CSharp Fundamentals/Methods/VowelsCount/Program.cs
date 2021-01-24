using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int vowelsCount = VowelCounter(input);

            Console.WriteLine(vowelsCount);
        }

        static int VowelCounter(string text)
        {
            int result = 0;

            char[] letters = text.ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == 'a'
                                    || letters[i] == 'e'
                                    || letters[i] == 'i'
                                    || letters[i] == 'o'
                                    || letters[i] == 'u'
                                    || letters[i] == 'A'
                                    || letters[i] == 'E'
                                    || letters[i] == 'I'
                                    || letters[i] == 'O'
                                    || letters[i] == 'U')
                {
                    result++;
                }
            }

            return result;
        }

    }
}
