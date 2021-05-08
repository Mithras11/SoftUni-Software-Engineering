using System;

namespace PasswordValidator1
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordValidator(password);

        }

        static void PasswordValidator(string text)
        {
            bool invalid = false;

            if (text.Length < 6 || text.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalid = true;
            }

            if (CheckIfCOntainsOnlyDigits(text) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                invalid = true;
            }

            if (CountDigits(text) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalid = true;
            }

            if (invalid == false)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckIfCOntainsOnlyDigits(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (!((currentChar >= 48 && currentChar <= 57)
                    || (currentChar >= 65 && currentChar <= 90)
                    || (currentChar >= 97 && currentChar <= 122)))
                {
                    return false;
                }
            }
            return true;
        }

        static int CountDigits(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 48 && text[i] <= 57)
                {
                    counter++;
                }
            }

            return counter;
        }

    }
}
