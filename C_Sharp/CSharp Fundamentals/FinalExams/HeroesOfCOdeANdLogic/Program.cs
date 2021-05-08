using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCOdeANdLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroCount = int.Parse(Console.ReadLine());

            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();


            for (int i = 0; i < heroCount; i++)
            {
                string[] newHero = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string heroName = newHero[0];
                int hitPoints = int.Parse(newHero[1]);
                int manaPoints = int.Parse(newHero[2]);

                heroes.Add(heroName, new int[] { hitPoints, manaPoints });
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "CastSpell")
                {
                    string currentHeroName = command[1];
                    int ManaNeeded = int.Parse(command[2]);
                    string spellName = command[3];

                    if (ManaNeeded <= heroes[currentHeroName][1])
                    {
                        heroes[currentHeroName][1] -= ManaNeeded;

                        Console.WriteLine($"{currentHeroName} has successfully cast {spellName} and now has {heroes[currentHeroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{currentHeroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command[0] == "TakeDamage")
                {
                    string currentHeroName = command[1];
                    int damage = int.Parse(command[2]);
                    string attacker = command[3];

                    heroes[currentHeroName][0] -= damage;

                    if (heroes[currentHeroName][0] > 0)
                    {
                        Console.WriteLine($"{currentHeroName} was hit for {damage} HP by {attacker} and now has {heroes[currentHeroName][0]} HP left!");
                    }
                    else
                    {
                        heroes.Remove(currentHeroName);

                        Console.WriteLine($"{currentHeroName} has been killed by {attacker}!");
                    }
                }
                else if (command[0] == "Recharge")
                {
                    string currentHeroName = command[1];
                    int amount = int.Parse(command[2]);

                    if (heroes[currentHeroName][1] + amount > 200)
                    {
                        amount = 200 - heroes[currentHeroName][1];

                        heroes[currentHeroName][1] = 200;

                    }
                    else
                    {
                        heroes[currentHeroName][1] += amount;
                    }

                    Console.WriteLine($"{currentHeroName} recharged for {amount} MP!");

                }
                else if (command[0]=="Heal")
                {
                    string currentHeroName = command[1];
                    int amount = int.Parse(command[2]);

                    if (heroes[currentHeroName][0] + amount > 100)
                    {
                        amount = 100 - heroes[currentHeroName][0];

                        heroes[currentHeroName][0] = 100;

                    }
                    else
                    {
                        heroes[currentHeroName][0] += amount;
                    }

                    Console.WriteLine($"{currentHeroName} healed for {amount} HP!");
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int[]> sortedHeroes = heroes
                .OrderByDescending(x => x.Value[0])
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var hero in sortedHeroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
        }
    }
}
