using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_FizzBuzz.AcceptanceTests.Commands;
using TestConsoleEnvironment.TDD_FizzBuzz;

namespace TDD_FizzBuzz.AcceptanceTests
{
    public class FizzBuzzAcceptanceTests
    {
        FizzBuzz fizzBuzz;
        Dictionary<string, Command> commandDictionary;

        public FizzBuzzAcceptanceTests()
        {
            fizzBuzz = new FizzBuzz();
            commandDictionary = new Dictionary<string, Command>();
            Command getValue = new GetValueFor("getvaluefor",fizzBuzz);
            AddCommand(getValue);
        }

        public List<string> FindMatchingCommands(string partialCommandName)
        {
            partialCommandName = partialCommandName.ToLower();
            List<string> possibleCommands = new List<string>();

            foreach(string commandName in commandDictionary.Keys)
            {
                if(commandName.Substring(0,partialCommandName.Length) == partialCommandName)
                {
                    possibleCommands.Add(commandName);
                }
            }

            return possibleCommands;
        }

        public string GetCommandHelp(string commandName)
        {
            Command command = commandDictionary[commandName];
            string commandHelp = command == null ? "No matching Command Found" : command.CommandHelp;
            return commandHelp;
        }

        public List<string> GetAllCommandNames()
        {
            return new List<string>(this.commandDictionary.Keys);
        }

        public string ExecuteStringCommand(string fullCommandString)
        {
            Command command = FindCommand(fullCommandString);
            return command.Execute(fullCommandString);

        }

        private Command FindCommand(string fullCommandString)
        {
            string commandName = fullCommandString.Split(' ').FirstOrDefault();
            Command command = commandDictionary[commandName];
            return command;
        }

        private void AddCommand(Command command)
        {
            commandDictionary.Add(command.CommandName.ToLower(), command);
        }
    }
}
