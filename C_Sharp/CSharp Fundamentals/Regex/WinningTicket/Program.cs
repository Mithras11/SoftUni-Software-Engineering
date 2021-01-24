using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ' ', ',', }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Regex regex = new Regex(@"(?<symbol>[@#$^]){6,10}");

            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    string leftHalf = ticket.Substring(0, 10);
                    string rightHalf = ticket.Substring(10);

                    Match leftMatch = regex.Match(leftHalf);
                    Match rightMatch = regex.Match(rightHalf);

                    if (leftMatch.Success && leftMatch.Value == rightMatch.Value)
                    {

                        if (leftMatch.Value.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {leftMatch.Value.Length}{leftMatch.Groups["symbol"]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {leftMatch.Value.Length}{leftMatch.Groups["symbol"]}");
                        }


                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }





                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }


        }
    }
}
