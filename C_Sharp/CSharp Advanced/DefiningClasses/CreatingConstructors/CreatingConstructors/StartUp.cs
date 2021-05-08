using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var firstPerson = new Person();
            var secondPerson = new Person(18);
            var thirdPerson = new Person("Stamat", 43);
        }
    }
}

