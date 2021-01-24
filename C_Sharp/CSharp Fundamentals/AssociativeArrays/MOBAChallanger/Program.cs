using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBAChallanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> allPlayers = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] data = input.Split(" -> ").ToArray();
                    string player = data[0];
                    string position = data[1];
                    int skill = int.Parse(data[2]);

                    if (!(allPlayers.ContainsKey(player)))
                    {
                        allPlayers.Add(player, new Dictionary<string, int>() { { position, skill } });
                    }
                    else
                    {
                        if (!(allPlayers[player].ContainsKey(position)))
                        {
                            allPlayers[player].Add(position, skill);
                        }
                        else
                        {
                            if (allPlayers[player][position] < skill)
                            {
                                allPlayers[player][position] = skill;
                            }
                        }
                    }
                }

                else if (input.Contains(" vs "))

                {
                    string[] contestants = input.Split(" vs ").ToArray();
                    string player1 = contestants[0];
                    string player2 = contestants[1];

                    if (allPlayers.ContainsKey(player1) && allPlayers.ContainsKey(player2))
                    {
                        bool sharePosition = false;

                        foreach (var position in allPlayers[player1])
                        {
                            if (allPlayers[player2].ContainsKey(position.Key))
                            {
                                sharePosition = true;
                                break;
                            }
                        }

                        if (sharePosition)
                        {
                            int totalSkill1 = allPlayers[player1].Sum(x => x.Value);
                            int totalSkill2 = allPlayers[player2].Sum(x => x.Value);

                            if (totalSkill1 > totalSkill2)
                            {
                                allPlayers.Remove(player2);
                            }
                            else if (totalSkill2 > totalSkill1)
                            {
                                allPlayers.Remove(player1);
                            }
                        }
                    }
                }
            }

            Dictionary<string, int> sortedPoints = new Dictionary<string, int>();

            foreach (var player in allPlayers)
            {
                sortedPoints.Add(player.Key, player.Value.Sum(x => x.Value));
            }

            var result = sortedPoints.OrderByDescending(pair => pair.Value)
                .ThenBy(pair => pair.Key)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value} skill");

                string currentPlayer = item.Key;

                var currentResult = allPlayers[currentPlayer].OrderByDescending(pair => pair.Value)
                .ThenBy(pair => pair.Key)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

                foreach (var data in currentResult)
                {
                    Console.WriteLine($" - {data.Key} <::> {data.Value}");
                }
            }

        }
    }
}
