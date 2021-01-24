using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();

                Regex regex = new Regex(@"\@\#+[A-Z][A-Za-z0-9]{4,}[A-Z]\@\#+");

                Match match = regex.Match(barcode);

                if (match.Success)
                {
                    char[] code = barcode.ToCharArray();
                    int counter = 0;
                    string productGroup = string.Empty;

                    foreach (char symbol in code)
                    {
                        if (Char.IsDigit(symbol))
                        {
                            productGroup += symbol;
                            counter++;
                        }
                    }

                    if (counter == 0)
                    {
                        productGroup = "00";
                    }

                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}