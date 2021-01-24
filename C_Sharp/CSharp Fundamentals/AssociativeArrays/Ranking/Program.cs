using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, string> allContests = new Dictionary<string, string>();

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] data = input.Split(':').ToArray();
                string contest = data[0];
                string password = data[1];

                allContests.Add(contest, password);
            }


            Dictionary<string, Dictionary<string, int>> allUsers = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] data = input.Split("=>").ToArray();
                string contest = data[0];
                string password = data[1];
                string userName = data[2];
                int points = int.Parse(data[3]);


                if (allContests.ContainsKey(contest) && allContests[contest] == password)
                {
                    if (allUsers.ContainsKey(userName) == false)
                    {
                        allUsers.Add(userName, new Dictionary<string, int>() { { contest, points } });
                    }
                    else
                    {
                        if (allUsers[userName].ContainsKey(contest) == false)
                        {
                            allUsers[userName].Add(contest, points);
                        }
                        else
                        {
                            if (allUsers[userName][contest] < points)
                            {
                                allUsers[userName][contest] = points;

                            }

                        }
                    }


                }
            }

            Dictionary<string, int> bestUser = new Dictionary<string, int>();

            foreach (var user in allUsers)
            {
                int totalPoints = 0;

                foreach (var points in user.Value)
                {
                    totalPoints += points.Value;
                }

                bestUser.Add(user.Key, totalPoints);
            }

            int maxPoints = 0;
            string winner = string.Empty;

            foreach (var user in bestUser)
            {
                if (user.Value > maxPoints)
                {
                    maxPoints = user.Value;
                    winner = user.Key;
                }
            }

            Console.WriteLine($"Best candidate is {winner} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");

            var result = allUsers.OrderBy(name => name.Key).ToDictionary(pair=>pair.Key, pair=>pair.Value);

            foreach (var user in result)
            {
                Console.WriteLine($"{user.Key}");

                var sortedPoints = user.Value
                    .OrderByDescending(points => points.Value)
                    .ToDictionary(pair => pair.Key, pair => pair.Value);

                foreach (var points in sortedPoints)
                {
                    Console.WriteLine($"#  {points.Key} -> {points.Value}");
                }
            }





        }
    }
}
