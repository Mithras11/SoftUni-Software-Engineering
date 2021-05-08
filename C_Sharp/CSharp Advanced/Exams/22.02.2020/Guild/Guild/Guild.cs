using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            this.roster = new List<Player>(Capacity);
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get => roster.Count; }


        public void AddPlayer(Player player)
        {
            if (Count < Capacity)
            {
                roster.Add(player);
            }
        }


        public bool RemovePlayer(string name)
        {
            var currPlayer = roster.FirstOrDefault(p => p.Name == name);

            if (roster.Contains(currPlayer))
            {
                roster.Remove(currPlayer);

                return true;
            }

            return false;
        }


        public void PromotePlayer(string name)
        {
            var currPlayer = roster.FirstOrDefault(p => p.Name == name);

            if (roster.Contains(currPlayer) && currPlayer.Rank != "Member")
            {
                currPlayer.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            var currPlayer = roster.FirstOrDefault(p => p.Name == name);

            if (roster.Contains(currPlayer) && currPlayer.Rank != "Trial")
            {
                currPlayer.Rank = "Trial";
            }

        }


        public Player[] KickPlayersByClass(string @class)
        {
            Player[] result = roster.Where(p => p.Class == @class).ToArray();

            roster.RemoveAll(p => p.Class == @class);

            return result;

        }


        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Players in the guild: {Name}");

            foreach (var player in roster)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().Trim();
        }


    }
}
