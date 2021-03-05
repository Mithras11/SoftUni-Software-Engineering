using System;
using System.Collections.Generic;
using System.Text;

using MilitaryElite.Contracts;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral:Private, ILieutenantGeneral
    {

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            :base(id, firstName,lastName,salary)
        {
            this.Privates = new List<ISoldier>();
        }

        public ICollection<ISoldier> Privates { get; private set; }


        public void AddPrivate(ISoldier @private)
        {
            this.Privates.Add(@private);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            sb.AppendLine("Privates:");
            foreach (var item in this.Privates)
            {
                sb.AppendLine($"  {item}");
            }
            return sb.ToString().TrimEnd();
        }


    }
}
