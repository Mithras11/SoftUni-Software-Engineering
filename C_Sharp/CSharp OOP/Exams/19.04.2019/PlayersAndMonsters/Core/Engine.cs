using PlayersAndMonsters.Core.Contracts;
using PlayersAndMonsters.IO;
using PlayersAndMonsters.IO.Contracts;
using PlayersAndMonsters.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Core
{
    public class Engine : IEngine
    {
        IManagerController managerController;
        IWriter writer;
        //IWriter fileWriter;
        IReader reader;


        public Engine()
        {
            this.managerController = new ManagerController();
            this.writer = new Writer();
            //this.fileWriter = new FileWriter();
            this.reader = new Reader();
        }

        public void Run()
        {
            string input;

            while ((input = reader.ReadLine()) != "Exit")
            {
                var args = input.Split().ToArray();
                var command = args[0];

                try
                {
                    if (command == "AddPlayer")
                    {
                        var playerType = args[1];
                        var playerUsername = args[2];

                        writer.WriteLine(managerController.AddPlayer(playerType, playerUsername));
                        //fileWriter.WriteLine(managerController.AddPlayer(playerType, playerUsername));

                    }
                    else if (command == "AddCard")
                    {
                        var cardType = args[1];
                        var cardName = args[2];


                        writer.WriteLine(managerController.AddCard(cardType, cardName));
                        //fileWriter.WriteLine(managerController.AddCard(cardType, cardName));
                    }
                    else if (command == "AddPlayerCard")
                    {
                        var userName = args[1];
                        var cardName = args[2];

                        writer.WriteLine(managerController.AddPlayerCard(userName, cardName));
                        //fileWriter.WriteLine(managerController.AddPlayerCard(userName, cardName));
                    }
                    else if (command == "Fight")
                    {
                        var attacker = args[1];
                        var enemy = args[2];

                        writer.WriteLine(managerController.Fight(attacker, enemy));
                        // fileWriter.WriteLine(managerController.Fight(attacker, enemy));
                    }
                    else if (command == "Report")
                    {

                        writer.WriteLine(managerController.Report());
                        //fileWriter.WriteLine(managerController.Report());
                    }



                }
                catch (ArgumentException ex)
                {

                    writer.WriteLine(ex.Message);
                    //fileWriter.WriteLine(ex.Message);
                }

            }
        }
    }
}
