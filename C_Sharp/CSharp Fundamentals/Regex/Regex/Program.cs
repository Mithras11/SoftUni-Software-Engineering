using System;
using System.Linq;
using System.Text.RegularExpressions;

class NetherRealms
{
    static void Main()
    {
        var input = Console.ReadLine();

        

        var daemons = input.Split(',').Select(x => x.Trim()).ToArray();
        Array.Sort(daemons);

        foreach (var daemon in daemons)
        {
            var name = Regex.Matches(daemon, @"[^/\*\d\.+-]").Cast<Match>();

            var health = 0;
            foreach (var letter in name)
            {
                health += (int)letter.Value[0];
            }

            var asterisks = daemon.Count(x => x == '*');
            var slashes = daemon.Count(x => x == '/');
            var damageArray = Regex.Matches(daemon, @"-?\d+\.?\d*").Cast<Match>().Select(x => double.Parse(x.Value)).ToArray();
            var damage = damageArray.Sum() * Math.Pow(2, asterisks) / Math.Pow(2, slashes);

            Console.WriteLine($"{daemon} - {health} health, {damage:f2} damage");
        }
    }
}