using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalSum = 0;
            double price = 0;
            double totalPrice = 0;
          

            while (input != "Start")
            {
                double currentCoin = double.Parse(input);
                if (currentCoin == 0.1 || currentCoin == 0.2 || currentCoin == 0.5 || currentCoin == 1 || currentCoin == 2)
                {
                    totalSum += currentCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoin}");
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                switch (input)
                {
                    case "Nuts":
                        price = 2.0;
                        break;

                    case "Water":
                        price = 0.7;
                        break;

                    case "Crisps":
                        price = 1.5;
                        break;

                    case "Soda":
                        price = 0.8;
                        break;

                    case "Coke":
                        price = 1.0;
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        input = Console.ReadLine();
                        continue;
                }
                totalPrice += price;

                if (totalPrice > totalSum)
                {
                    Console.WriteLine("Sorry, not enough money");
                    totalPrice -= price;
                    
                }
                else
                {
                   
                Console.WriteLine($"Purchased {input.ToLower()}");
                input = Console.ReadLine();
                }

            }
            Console.WriteLine($"Change: {(totalSum - totalPrice):F2}");





        }
    }
}
