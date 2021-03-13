using System;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var smartphone = new Smartphone();
            var stationaryPhone = new StationaryPhone();

            var numbers = Console.ReadLine()
                .Split().ToArray();

            var urls = Console.ReadLine()
                .Split().ToArray();

            foreach (var number in numbers)
            {
                if (number.Length == 10)
                {
                    smartphone.Call(number);
                }
                else 
                {
                    stationaryPhone.Call(number);
                }
            }

            foreach (var url in urls)
            {
                smartphone.Browse(url);
            }

        }
    }
}
