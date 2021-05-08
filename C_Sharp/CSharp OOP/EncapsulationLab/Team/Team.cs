using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;


        public Team(string name)
        {
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
            this.name = name;
        }

        public IReadOnlyList<Person> FirstTeam { get => firstTeam.AsReadOnly(); }
        public IReadOnlyList<Person> ReserveTeam { get => reserveTeam.AsReadOnly(); }


        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                this.firstTeam.Add(person);

            }
            else
            {
                this.reserveTeam.Add(person);
            }
        }
    }
}
