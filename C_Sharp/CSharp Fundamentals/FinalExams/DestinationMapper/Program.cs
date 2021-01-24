using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"([=\/])(?<place>[A-Z][A-Za-z]{2,})\1");
            MatchCollection validDestinations = regex.Matches(text);

            int travelPoints = 0;
            List<string> places = new List<string>();

            foreach (Match destination in validDestinations)
            {
                travelPoints += destination.Groups["place"].Value.Length;
                places.Add(destination.Groups["place"].Value);

            }

            Console.WriteLine($"Destinations: {string.Join(", ",places)}");
            Console.WriteLine($"Travel Points: {travelPoints}");

        }
    }
}
