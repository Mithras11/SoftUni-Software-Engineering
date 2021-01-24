using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Complete")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "Make")
                {
                    if (command[1] == "Upper")
                    {
                        text = text.ToUpper();
                        Console.WriteLine(text);
                    }
                    else if (command[1] == "Lower")
                    {
                        text = text.ToLower();
                        Console.WriteLine(text);
                    }
                }
                else if (command[0] == "GetDomain")
                {
                    int count = int.Parse(command[1]);

                    string domain = text.Substring(text.Length  - count);
                    Console.WriteLine(domain);
                }
                else if (command[0] == "GetUsername")
                {
                    if (text.Contains('@'))
                    {
                        int index = text.IndexOf('@');
                        string username = text.Substring(0, index);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The email {text} doesn't contain the @ symbol.");
                    }
                }
                else if (command[0] == "Replace")
                {
                    char symbol = char.Parse(command[1]);

                    text = text.Replace(symbol, '-');
                    Console.WriteLine(text);
                }
                else if (command[0] == "Encrypt")
                {
                    List<int> ascii = new List<int>();

                    for (int i = 0; i < text.Length; i++)
                    {
                        int code = (int)text[i];
                        ascii.Add(code);
                    }

                    Console.WriteLine(string.Join(' ',ascii));
                }


            }
        }
    }
}
