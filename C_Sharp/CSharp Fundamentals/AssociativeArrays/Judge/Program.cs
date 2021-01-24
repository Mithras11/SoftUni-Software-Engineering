using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> allContests = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] data = input.Split(" -> ").ToArray();
                string userName = data[0];
                string contest = data[1];
                int points = int.Parse(data[2]);

                if (allContests.ContainsKey(contest) == false)
                {
                    allContests.Add(contest, new Dictionary<string, int>() { { userName, points } });
                }
                else
                {
                    if (allContests[contest].ContainsKey(userName) == false)
                    {
                        allContests[contest].Add(userName, points);
                    }
                    else
                    {
                        if (allContests[contest][userName] < points)
                        {
                            allContests[contest][userName] = points;
                        }
                    }
                }
            }


            SortedDictionary<string, int> totalPoints = new SortedDictionary<string, int>();

            foreach (var contest in allContests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                Dictionary<string, int> sortedUsers = contest.Value
                    .OrderByDescending(pair => pair.Value)
                    .ThenBy(pair => pair.Key)
                    .ToDictionary(pair => pair.Key, pair => pair.Value);

                for (int i = 0; i < sortedUsers.Count; i++)
                {
                    string currentUser = sortedUsers.Keys.ElementAt(i);
                    int currentPoints = sortedUsers.Values.ElementAt(i);

                    Console.WriteLine($"{i + 1}. {currentUser} <::> {currentPoints}");

                    if (totalPoints.ContainsKey(currentUser) == false)
                    {
                        totalPoints.Add(currentUser, currentPoints);
                    }
                    else
                    {
                        totalPoints[currentUser] += currentPoints;
                    }
                }
            }

            var sortedTotalPoints = totalPoints.OrderByDescending(pair => pair.Value)
                .ToDictionary(piar => piar.Key, pair => pair.Value);

            Console.WriteLine("Individual standings:");

            for (int i = 0; i < sortedTotalPoints.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sortedTotalPoints.Keys.ElementAt(i)} -> {sortedTotalPoints.Values.ElementAt(i)}");
            }



        }
    }
}
