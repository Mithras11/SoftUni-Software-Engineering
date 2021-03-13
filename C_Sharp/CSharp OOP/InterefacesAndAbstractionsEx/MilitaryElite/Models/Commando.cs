using System;
using System.Collections.Generic;
using System.Text;

using MilitaryElite.Contracts;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corp)
            : base(id, firstName, lastName, salary, corp)
        {
            this.Missions = new List<IMission>();
        }

        public ICollection<IMission> Missions { get; private set; }

        public void AddMission(Mission mission)
        {
            this.Missions.Add(mission);
        }


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");

            foreach (var item in this.Missions)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }


    }
}
