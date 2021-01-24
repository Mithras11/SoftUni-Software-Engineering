using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                int decryptionKey = CalculateDecryptKey(message);
                string decryptedMessage = DecryptMessage(message, decryptionKey);


                string pattern =
                    @"@(?<planetName>[A-Za-z]+)[^@\-!:>]*:(?<population>[\d]+)[^@\-!:>]*!(?<attackType>[AD])![^@\-!:>]*->(?<soldierCount>[\d]+)";
                Regex regex = new Regex(pattern);

                Match match = regex.Match(decryptedMessage);

                if (match.Success)
                {


                    string planetName = match.Groups["planetName"].Value;
                    int population = int.Parse(match.Groups["population"].Value);
                    string attackType = match.Groups["attackType"].Value;
                    int soldierCount = int.Parse(match.Groups["soldierCount"].Value);

                    switch (attackType)
                    {
                        case "A":
                            attackedPlanets.Add(planetName);
                            break;

                        case "D":
                            destroyedPlanets.Add(planetName);
                            break;
                    }

                }
            }

            
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
            {
                foreach (var item in attackedPlanets.OrderBy(x=>x).ToList())
                {
                    Console.WriteLine($"-> {item}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (var item in destroyedPlanets.OrderBy(x=>x).ToList())
                {
                    Console.WriteLine($"-> {item}");
                }
            }


        }


        static int CalculateDecryptKey(string message)
        {
            List<char> letters = new List<char>() { 's', 't', 'a', 'r', 'S', 'T', 'A', 'R' };
            int result = message.Count(x => letters.Contains(x));
            return result;
        }

        static string DecryptMessage(string message, int Key)
        {
            StringBuilder sb = new StringBuilder();
            int key = Key;

            for (int i = 0; i < message.Length; i++)
            {
                char currentChar = (char)(message[i] - key);
                sb.Append(currentChar);
            }

            string result = sb.ToString();
            return result;
        }



    }
}
