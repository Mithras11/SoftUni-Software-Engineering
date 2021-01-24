using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})([\.|\-|\/])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match date in matches)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
