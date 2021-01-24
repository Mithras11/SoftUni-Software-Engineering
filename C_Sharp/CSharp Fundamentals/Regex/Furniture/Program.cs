using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string pattern = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";

            List<string> furniture = new List<string>();


            decimal totalPrice = 0;

            while ((input = Console.ReadLine()) != "Purchase")
            {

                Match data = Regex.Match(input, pattern, RegexOptions.IgnoreCase);

                if (data.Success)
                {

                    string furnitureName = data.Groups["name"].Value;
                    decimal price = decimal.Parse(data.Groups["price"].Value);
                    long quantity = long.Parse(data.Groups["quantity"].Value);

                    furniture.Add(furnitureName);

                    totalPrice += (price * quantity);
                }

            }


            Console.WriteLine("Bought furniture:");

            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");

        }
    }
}
