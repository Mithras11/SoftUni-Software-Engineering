using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gifts = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "No Money")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "OutOfStock":

                        string gift = command[1];

                        for (int i = 0; i < gifts.Count; i++)
                        {
                            if (gifts[i] == gift)
                            {
                                gifts[i] = "None";
                            }
                        }

                        break;

                    case "Required":

                        string currentGift = command[1];
                        int currentIndex = int.Parse(command[2]);

                        if (currentIndex >= 0 && currentIndex < gifts.Count)
                        {
                            gifts[currentIndex] = currentGift;
                        }
                        break;

                    case "JustInCase":

                        string newGift = command[1];
                        gifts[gifts.Count - 1] = newGift;

                        break;
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < gifts.Count; i++)
            {
                if (gifts[i] == "None")
                {
                    gifts.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join(' ', gifts));
        }
    }
}