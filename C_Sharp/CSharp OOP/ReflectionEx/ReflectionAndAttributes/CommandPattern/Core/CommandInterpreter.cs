using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            var input = args.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            var commandName = input[0];
            var commandArguments = input.Skip(1).ToArray();

            var type = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .Where(t => t.Name == $"{commandName}Command")
                .FirstOrDefault();

            var instance = (ICommand)Activator.CreateInstance(type);

            return instance.Execute(commandArguments);

        }
    }
}
