using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using MilitaryElite.Models;

namespace MilitaryElite.Core
{
    public class Engine
    {
        public void Run()
        {
            List<ISoldier> soldiers = new List<ISoldier>();
            ISoldier soldier = null;


            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                var data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string type = data[0];
                string id = data[1];
                string firstName = data[2];
                string lastName = data[3];


                if (type == "Private")
                {
                    decimal salary = decimal.Parse(data[4]);

                    soldier = new Private(id, firstName, lastName, salary);


                }
                else if (type == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(data[4]);
                    var general = new LieutenantGeneral(id, firstName, lastName, salary);

                    foreach (var item in data.Skip(5))
                    {
                        ISoldier @private = soldiers.First(s => s.ID == item);
                        general.AddPrivate(@private);
                    }

                    soldier = general;

                }
                else if (type == "Engineer")
                {
                    decimal salary = decimal.Parse(data[4]);
                    string corp = data[5];

                    try
                    {
                        var engineer = new Engineer(id, firstName, lastName, salary, corp);

                        for (int i = 6; i < data.Length; i++)
                        {
                            var repair = new Repair(data[i], int.Parse(data[++i]));

                            engineer.AddRepairs(repair);
                        }

                        soldier = engineer;
                    }
                    catch (ArgumentException)
                    {

                        continue;
                    }

                }
                else if (type == "Commando")
                {
                    decimal salary = decimal.Parse(data[4]);
                    string corp = data[5];

                    try
                    {
                        var commando = new Commando(id, firstName, lastName, salary, corp);

                        for (int i = 6; i < data.Length; i++)
                        {
                            try
                            {
                                var mission = new Mission(data[i], data[++i]);

                                commando.AddMission(mission);

                            }
                            catch (ArgumentException)
                            {

                                continue;
                            }
                        }

                        soldier = commando;
                    }
                    catch (Exception)
                    {

                        throw;
                    }


                }
                else if (type == "Spy")
                {
                    int codenumber = int.Parse(data[4]);

                    var spy = new Spy(id, firstName, lastName, codenumber);

                    soldier = spy;
                }


                if (soldier != null)
                {
                    soldiers.Add(soldier);

                }
            }

            foreach (var item in soldiers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
