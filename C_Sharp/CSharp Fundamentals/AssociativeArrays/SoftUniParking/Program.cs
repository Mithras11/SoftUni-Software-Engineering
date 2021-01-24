using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();


            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = input[0];
                string username = input[1];

                switch (command)
                {
                    case "register":

                        string licensePlateNumber = input[2];

                        if (users.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {users[username]}");
                        }
                        else
                        {
                            users.Add(username, licensePlateNumber);
                            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        }

                        break;

                    case "unregister":

                        if (users.ContainsKey(username) == false)
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            users.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }

                        break;
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
