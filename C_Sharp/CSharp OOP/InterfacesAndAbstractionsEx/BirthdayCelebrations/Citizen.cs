using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizen : IID, IBirthday
    {

        private string name;
        private int age;
        private string id;
        private string birthdate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.name = name;
            this.age = age;
            this.ID = id;
            this.birthdate = birthdate;
        }

        public string ID
        {
            get => this.id;

            private set => this.id = value;
        }

        public string Birthdate
        {
            get => this.birthdate;
            set => this.birthdate = value;
        }




       public  bool FindYear(string year)
        {
            return this.Birthdate.Contains(year);
        }


        public bool FindLastDigits(string fakeId)
        {
            return this.ID.EndsWith(fakeId);
        }
    }

}
