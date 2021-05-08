using System;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;

            string[] rooms = Console.ReadLine().Split("|");
            int roomCount = 1;

            foreach (var room in rooms)
            {
                string command = (room.Split())[0];
                int number = int.Parse(room.Split()[1]);

                if (command == "chest")
                {
                    int foundBitcoins = number;
                    bitcoins += foundBitcoins;
                    Console.WriteLine($"You found {foundBitcoins} bitcoins.");
                }
                else if (command == "potion")
                {
                    int cure = number;
                    

                    if (health + cure > 100)
                    {
                        cure = 100 - health;
                        health = 100;
                    }
                    else
                    {
                        health += cure;
                    }

                    Console.WriteLine($"You healed for {cure} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else
                {
                    string monster = command;
                    int attack = number;
                    health -= attack;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {roomCount}");

                        return;
                    }
                }

                roomCount++;
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
