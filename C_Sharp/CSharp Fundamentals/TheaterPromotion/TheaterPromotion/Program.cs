using System;

namespace TheaterPromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 18)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        Console.WriteLine("12$");
                        break;

                    case "Weekend":
                        Console.WriteLine("15$");
                        break;

                    case "Holiday":
                        Console.WriteLine("5$");
                        break;
                }
            }
            else if (age > 18 && age <= 64)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        Console.WriteLine("18$");
                        break;

                    case "Weekend":
                        Console.WriteLine("20$");
                        break;

                    case "Holiday":
                        Console.WriteLine("12$");
                        break;
                }
            }
            else if (age > 64 && age <= 122)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        Console.WriteLine("12$");
                        break;

                    case "Weekend":
                        Console.WriteLine("15$");
                        break;

                    case "Holiday":
                        Console.WriteLine("10$");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
