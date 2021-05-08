using System;
using System.Collections.Generic;
using System.Linq;
using Raiding.Heroes;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<BaseHero> heroes = new List<BaseHero>(num);

            string heroName = string.Empty;
            string heroType = string.Empty;
            BaseHero hero = null;

            while (heroes.Count!=num)
            {
                heroName = Console.ReadLine();
                heroType = Console.ReadLine();

                if (heroType=="Druid")
                {
                    hero = new Druid(heroName);
                }
                else if (heroType=="Paladin")
                {
                    hero = new Paladin(heroName);
                }
                else if (heroType=="Rogue")
                {
                    hero = new Rogue(heroName);
                }
                else if (heroType=="Warrior")
                {
                    hero = new Warrior(heroName);
                }
                else 
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }

                heroes.Add(hero);

            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (var item in heroes)
            {
                Console.WriteLine(item.CastAbility());
            }

            int heroesTotalPower = heroes.Sum(h => h.Power);

            if (heroesTotalPower>=bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }

        }
    }
}
