using System;
using System.Collections.Generic;
using System.Text;

using MilitaryElite.Enums;

using MilitaryElite.Contracts;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        private State state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; private set; }
        public string State
        {
            get
            {
                return this.state.ToString();
            }
            private set
            {
                if (Enum.TryParse<State>(value, out this.state) == false)
                {
                    throw new ArgumentException();
                }

            }
        }



        public void CompleteMission()
        {
            if (this.state == Enums.State.Finished)
            {
                throw new ArgumentException();
            }

            this.state = Enums.State.Finished;
        }



        public override string ToString()
        {
            return $"  Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
