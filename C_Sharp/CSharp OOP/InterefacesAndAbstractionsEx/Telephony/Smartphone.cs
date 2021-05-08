using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICall, IBrowse
    {
        public void Browse(string url)
        {
            if (url.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {url}!");
            }
        }

        public void Call(string number)
        {
            if (number.All(char.IsDigit) == false)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Calling... {number}");

            }

        }
    }
}
