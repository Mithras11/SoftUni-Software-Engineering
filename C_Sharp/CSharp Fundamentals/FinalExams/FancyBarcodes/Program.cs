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

                Regex validBarcode = new Regex(@"@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+");
                Match matchedCode = validBarcode.Match(barcode);

                if (matchedCode.Success)
                {
                    string matchedBarCode = matchedCode.Groups["barcode"].Value;
                    int counter = 0;
                    string productGroup = "";

                    foreach (char symbol in matchedBarCode)
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
