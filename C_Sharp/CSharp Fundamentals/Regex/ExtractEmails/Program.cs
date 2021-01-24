using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"\s(?<email>[a-z0-9]+[\.\-_]?[a-z0-9]+@[a-z\-]+(\.[a-z]+){1,})");

            MatchCollection validEmails = regex.Matches(text);

            foreach (Match email in validEmails)
            {
                Console.WriteLine(email.Groups["email"]);
            }


        }
    }
}
