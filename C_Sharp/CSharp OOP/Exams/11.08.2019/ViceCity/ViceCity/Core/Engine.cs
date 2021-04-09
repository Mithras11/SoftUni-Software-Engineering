using ViceCity.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.IO.Contracts;
using ViceCity.IO;

namespace ViceCity.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IController controller;


        public Engine()
        {
            this.reader = new Reader();
            this.writer = new Writer();
            this.controller = new Controller();

        }
        public void Run()
        {
            string message = null;

            while (true)
            {
                var input = reader.ReadLine().Split();
                if (input[0] == "Exit")
                {
                    Environment.Exit(0);
                }
                try
                {
                    if (input[0] == "AddPlayer")
                    {
                        message = controller.AddPlayer(input[1]);
                    }
                    else if (input[0] == "AddGun")
                    {
                        message = controller.AddGun(input[1], input[2]);
                    }
                    else if (input[0] == "AddGunToPlayer")
                    {
                        message = controller.AddGunToPlayer(input[1]);
                    }
                    else if (input[0] == "Fight")
                    {
                        message = controller.Fight();
                    }
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
                finally
                {
                    writer.WriteLine(message);
                }

            }
        }
    }
}
