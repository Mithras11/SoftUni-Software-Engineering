using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            Dictionary<string, Data> users = new Dictionary<string, Data>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] command = input.Split('=', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "Add")
                {
                    string username = command[1];
                    int sent = int.Parse(command[2]);
                    int received = int.Parse(command[3]);

                    if (users.ContainsKey(username) == false)
                    {
                        users.Add(username, new Data(sent, received));
                    }
                }
                else if (command[0] == "Message")
                {
                    string sender = command[1];
                    string receiver = command[2];

                    if (users.ContainsKey(sender) && users.ContainsKey(receiver))
                    {
                        users[sender].Sent++;
                        users[sender].TotalCount++;

                        users[receiver].Received++;
                        users[receiver].TotalCount++;

                        if (users[sender].TotalCount == capacity)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");

                            users.Remove(sender);
                        }

                        if (users[receiver].TotalCount == capacity)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");

                            users.Remove(receiver);
                        }
                    }
                }
                else if (command[0] == "Empty")
                {
                    string username = command[1];

                    if (username == "All")
                    {
                        users.Clear();

                        continue;
                    }

                    if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                    }
                }

            }

            Dictionary<string, Data> sortedUsers = users
                .OrderByDescending(x => x.Value.Received)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Users count: {sortedUsers.Count}");

            foreach (var user in sortedUsers)
            {
                Console.WriteLine($"{user.Key} - {user.Value.TotalCount}");
            }



        }


        class Data
        {
            public int Sent { get; set; }
            public int Received { get; set; }
            public int TotalCount { get; set; }

            public Data(int sent, int received)
            {
                this.Sent = sent;
                this.Received = received;
                this.TotalCount = sent + received;
            }
        }
    }
}
