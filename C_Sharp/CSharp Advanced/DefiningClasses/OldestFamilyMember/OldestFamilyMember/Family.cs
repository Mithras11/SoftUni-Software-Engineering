using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public List<Person> People { get; set; } = new List<Person>();

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public  Person GetOldestMember()
        {
            return People.OrderByDescending(x=>x.Age).FirstOrDefault();
        }
    }
}
