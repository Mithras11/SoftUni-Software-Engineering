using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> guests = Console.ReadLine()
                .Split()
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] command = input.Split();

                Predicate<string> checkName = CheckIfNameIsValid(command);

                if (command[0] == "Double")
                {
                    for (int i = 0; i < guests.Count; i++)
                    {
                        string currentGuest = guests[i];

                        if (checkName(currentGuest))
                        {
                            guests.Insert(i + 1, currentGuest);
                            i++;
                        }
                    }
                }
                else if (command[0] == "Remove")
                {
                    for (int i = 0; i < guests.Count; i++)
                    {
                        string currentGuest = guests[i];

                        if (checkName(currentGuest))
                        {
                            guests.Remove(currentGuest);
                            i--;
                        }
                    }
                }

            }

            Action<List<string>> print = ((list) =>
            {
                string result;

                if (list.Count == 0)
                {
                    result = "Nobody is going to the party!";
                }
                else
                {
                    result = $"{string.Join(", ", list)} are going to the party!";
                }

                  Console.WriteLine((result));

            });

            print(guests);
            


        }
              

        static Predicate<string> CheckIfNameIsValid(string[] command)
        {
            Predicate<string> checkName = null;

            {
                bool nameIsValid = false;

                if (command[1] == "StartsWith")
                {
                    checkName = new Predicate<string>(n =>
                    {
                        if (n.StartsWith(command[2]))
                        {
                            nameIsValid = true;
                        }
                        else
                        {
                            nameIsValid = false;
                        }

                        return nameIsValid;
                    });


                }
                else if (command[1] == "EndsWith")
                {
                    checkName = new Predicate<string>(n =>
                    {
                        if (n.EndsWith(command[2]))
                        {
                            nameIsValid = true;
                        }
                        else
                        {
                            nameIsValid = false;
                        }

                        return nameIsValid;
                    });

                }
                else if (command[1] == "Length")
                {
                    checkName = new Predicate<string>(n =>
                    {
                        if (n.Length == int.Parse(command[2]))
                        {
                            nameIsValid = true;
                        }
                        else
                        {
                            nameIsValid = false;
                        }
                        return nameIsValid;
                    });

                };
            }

            return checkName;
        }
    }
}
