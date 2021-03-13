using System;
using System.Collections.Generic;
using System.Text;

using MilitaryElite.Enums;

using MilitaryElite.Contracts;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private Corp corp;

        protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corp)
            : base(id, firstName, lastName, salary)
        {
            this.Corp = corp;
        }



        public string Corp
        {
            get => this.corp.ToString();

            private set
            {
                if (Enum.TryParse<Corp>(value, out this.corp) == false)
                {
                    throw new ArgumentException();
                }

            }
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Corps: {this.Corp}";
        }


    }
}
