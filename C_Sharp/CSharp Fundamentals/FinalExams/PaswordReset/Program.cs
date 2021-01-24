using System;
using System.Linq;
using System.Text;

namespace PaswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] commands = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commands[0])
                {
                    case "TakeOdd":

                        StringBuilder sb = new StringBuilder();

                        for (int i = 1; i < password.Length; i += 2)
                        {
                            sb.Append(password[i]);
                        }

                        password = sb.ToString();

                        Console.WriteLine(password);

                        break;

                    case "Cut":

                        int index = int.Parse(commands[1]);
                        int length = int.Parse(commands[2]);

                        password = password.Remove(index, length);

                        Console.WriteLine(password);

                        break;

                    case "Substitute":

                        string substring = commands[1];
                        string substitute = commands[2];

                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, substitute);

                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }

                        break;
                }

            }

            Console.WriteLine($"Your password is: {password}");




        }
    }
}
