using System;
using System.Linq;
using System.Collections.Generic;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            string name = string.Empty;
            string age = string.Empty;

            for (int i = 0; i < n; i++)
            {
                text = Console.ReadLine();

                int indeBeforeName = text.IndexOf('@');
                int indexAfterName = text.IndexOf('|');
                int indexBeforeAge = text.IndexOf('#');
                int indexAfterAge = text.IndexOf('*');

                name = text.Substring(indeBeforeName + 1, indexAfterName - 1 - indeBeforeName);
                age = text.Substring(indexBeforeAge + 1, indexAfterAge - 1 - indexBeforeAge);

                Console.WriteLine($"{name} is {age} years old.");

            }




        }
    }
}
