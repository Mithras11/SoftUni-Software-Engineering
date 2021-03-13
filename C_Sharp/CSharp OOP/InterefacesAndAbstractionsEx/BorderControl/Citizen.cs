using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IID
    {

        private string name;
        private int age;
        private string id;
        public Citizen(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            this.ID = id;
        }

        public string ID
        {
            get => this.id;

            private set => this.id = value;
        }

        public bool findLastDigits(string fakeId)
        {
            return this.ID.EndsWith(fakeId);
        }
    }

}
