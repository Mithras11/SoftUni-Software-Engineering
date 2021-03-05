using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Pet : IBirthday
    {
        private string name;
        private string birthdate;

        public Pet(string name, string birthdate)
        {
            this.name = birthdate;
            this.Birthdate = birthdate;
        }

        public string Birthdate
        {
            get => this.birthdate;
            set => this.birthdate = value;
        }


        public bool FindYear(string year)
        {
            return this.Birthdate.Contains(year);
        }

    }

}
