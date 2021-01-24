using System;
using System.Linq;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {

                bool isPalindrome = CheckIfPalindrome(input);

                if (isPalindrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                

                input = Console.ReadLine();
            }
        }

        static bool CheckIfPalindrome(string number)
        {
            bool isPalindrome = false;

            string reverse = String.Join("", number.ToCharArray().Reverse());

            if (number==reverse)
            {
                isPalindrome = true;
            }
                 
            return isPalindrome;


        }
    }
}
