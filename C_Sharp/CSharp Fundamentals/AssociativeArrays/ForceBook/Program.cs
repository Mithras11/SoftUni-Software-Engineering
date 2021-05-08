using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            string input = string.Empty;


            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] data = new string[3];

                if (input.Contains('|'))
                {
                    data = input.Split(" | ").ToArray();

                    string side = data[0];
                    string user = data[1];

                    if (dictionary.ContainsKey(side) && !(dictionary[side].Contains(user)))
                    {

                        dictionary[side].Add(user);
                    }
                    else
                    {
                        dictionary.Add(side, new List<string>() { user });
                    }
                }

                else
                {
                    data = input.Split(" -> ").ToArray();

                    string currentUser = data[0];
                    string currentSide = data[1];


                    if (!(dictionary[currentSide].Contains(currentUser)))
                    {
                        dictionary[currentSide].Add(currentUser);

                    }


                    for (int i = 0; i < dictionary.Count; i++)
                    {
                        var currentItem = dictionary.Keys.ElementAt(i);

                        if (currentItem != currentSide && dictionary[currentItem].Contains(currentUser))
                        {
                            dictionary[currentItem].Remove(currentUser);

                            break;
                        }
                        
                    }
                    Console.WriteLine($"{currentUser} joins the {currentSide} side!");

                }

            }

            var orderedDictionary = dictionary
                .OrderBy(pair => pair.Value.Count)
                .ThenBy(pair => pair.Key)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var side in orderedDictionary)
            {
                if (side.Value.Count != 0)
                {

                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");


                    foreach (var user in side.Value.OrderBy(name => name))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }



        }
    }
}
