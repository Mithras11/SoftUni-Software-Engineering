using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICall
    {
        public void Call(string number)
        {
            if (number.All(char.IsDigit) == false)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Dialing... {number}");

            }

        }
    }
}
