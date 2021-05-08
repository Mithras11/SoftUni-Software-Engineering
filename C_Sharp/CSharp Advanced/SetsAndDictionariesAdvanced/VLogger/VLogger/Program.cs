using System;
using System.Collections.Generic;
using System.Linq;

namespace VLogger
{
    class Program
    {

        static void Main(string[] args)
        {

            var vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                var tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (tokens[1] == "joined")
                {
                    string vlogger = tokens[0];

                    if (vloggers.ContainsKey(vlogger) == false)
                    {
                        vloggers.Add(vlogger, new Dictionary<string, HashSet<string>>());

                        vloggers[vlogger].Add("followers", new HashSet<string>());
                        vloggers[vlogger].Add("following", new HashSet<string>());


                    }

                }
                else if (tokens[1] == "followed")
                {
                    string vlogger1 = tokens[0];
                    string vlogger2 = tokens[2];

                    if (vloggers.ContainsKey(vlogger1)
                        && vloggers.ContainsKey(vlogger2))
                    {
                        if (vlogger1 == vlogger2)
                        {
                            continue;
                        }

                        else
                        {
                            vloggers[vlogger1]["following"].Add(vlogger2);
                            vloggers[vlogger2]["followers"].Add(vlogger1);
                        }
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");


            var result = vloggers
                .OrderByDescending(v => v.Value["followers"].Count)
                .ThenBy(v => v.Value["following"].Count)
                .ToDictionary(x => x.Key, y => y.Value);

            int counter = 1;

            foreach (var vlogger in result)
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (counter == 1)
                {
                    foreach (var follower in vlogger.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                counter++;

            }




        }
    }
}
