using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IID> list = new List<IID>();


            string input = string.Empty;
            string[] data = null;

            while ((input = Console.ReadLine()) != "End")
            {
                data = input.Split().ToArray();

                if (data.Length == 2)
                {
                    string model = data[0];
                    string id = data[1];

                    var robot = new Robot(model, id);

                    list.Add(robot);
                }
                else
                {
                    string name = data[0];
                    int age = int.Parse(data[1]);
                    string id = data[2];

                    var citizen = new Citizen(name, age, id);

                    list.Add(citizen);

                }
            }


            string fakeId = Console.ReadLine();

            list = list.Where(x => x.findLastDigits(fakeId)).ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.ID}");
            }
        }
    }
}
