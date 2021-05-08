using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthday> list = new List<IBirthday>();


            string input = string.Empty;
            string[] data = null;

            while ((input = Console.ReadLine()) != "End")
            {
                data = input.Split().ToArray();
                string type = data[0];

                if (type == "Citizen")
                {
                    string name = data[1];
                    int age = int.Parse(data[2]);
                    string id = data[3];
                    string birthdate = data[4];

                    list.Add(new Citizen(name, age, id, birthdate));
                }
                else if (type == "Robot")
                {
                    //string model = data[1];
                    //string id = data[2];


                }
                else if (type == "Pet")
                {
                    string name = data[1];
                    string birthdate = data[2];

                    list.Add(new Pet(name, birthdate));
                }
            }


            string year = Console.ReadLine();

            list = list.Where(x => x.FindYear(year)).ToList();

            if (list.Count == 0)
            {
                Console.WriteLine("");
            }
            else
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"{item.Birthdate}");
                }

            }

        }
    }
}
