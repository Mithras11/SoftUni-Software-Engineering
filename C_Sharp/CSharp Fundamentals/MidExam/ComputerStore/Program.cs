using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalPrice = 0;
            double taxes = 0;


            while (input!="regular" && input!="special")
            {
                double currentPrice = double.Parse(input);
                if (currentPrice<0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalPrice += currentPrice;

                }

                input = Console.ReadLine();
            }

            taxes = totalPrice * 0.2;
            double totalPriceWithTaxes = totalPrice + taxes;

            if (input=="special")
            {
                totalPriceWithTaxes *= 0.9;
            }

            if (totalPriceWithTaxes==0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPriceWithTaxes:f2}$");

        }
    }
}
