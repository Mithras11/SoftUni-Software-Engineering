using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbers = Console.ReadLine();
            string pattern = @"(\+359)( ?\-?)(2)\2([0-9]{3})\2([0-9]{4})\b";

            Regex regex = new Regex(pattern);

            var phones = regex.Matches(phoneNumbers);

            
            
            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
