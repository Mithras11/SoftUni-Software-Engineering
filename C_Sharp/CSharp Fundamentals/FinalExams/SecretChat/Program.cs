using System;
using System.Linq;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {

            string message = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] command = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "InsertSpace")
                {
                    int index = int.Parse(command[1]);
                    message = message.Insert(index, " ");
                }
                else if (command[0] == "Reverse")
                {
                    string subString = command[1];

                    if (message.Contains(subString))
                    {
                        int index = message.IndexOf(subString);
                        message = message.Remove(index, subString.Length);

                        string reversedSubString = new string(subString.Reverse().ToArray());

                        message += reversedSubString;

                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else if (command[0] == "ChangeAll")
                {
                    string subString = command[1];
                    string replacement = command[2];

                    if (message.Contains(subString))
                    {
                        message = message.Replace(subString, replacement);
                    }
                }

                Console.WriteLine(message);

            }

            Console.WriteLine($"You have a new text message: {message}");



        }
    }
}
