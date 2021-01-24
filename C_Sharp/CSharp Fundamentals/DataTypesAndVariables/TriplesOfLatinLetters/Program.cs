using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char firtsChar = (char)('a' + i);

                for (int j = 0; j < n; j++)
                {
                    char secondChar = (char)('a' + j);

                    for (int k = 0; k < n; k++)
                    {
                        char thirdChar = (char)('a' + k);

                        Console.Write(firtsChar);
                        Console.Write(secondChar);
                        Console.WriteLine(thirdChar);
                    }
                }
            }





        }
    }
}
