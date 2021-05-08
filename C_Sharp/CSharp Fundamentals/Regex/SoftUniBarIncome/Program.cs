using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern =
                @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.\d]*(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            Regex regex = new Regex(pattern);
            double totalIncome = 0;

            string input = Console.ReadLine();

            while (input != "end of shift")
            {
                    Match match = regex.Match(input);

                if (match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double totalPrice = count * price;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");






        }
    }
}
