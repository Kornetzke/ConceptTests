using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirplaneSoundBites.Service;
using AirplaneSoundBites.ConsoleInterface.Command;

namespace AirplaneSoundBites
{
    public class ConsoleRunner
    {
        private AirplanePlayer player;
        private string command;
        private Dictionary<string, AbstractCommand> commandDictionary;
        private string prevCommand;

        public ConsoleRunner(AirplanePlayer player)
        {
            this.player = player;
            //command = new StringBuilder();
            commandDictionary = new Dictionary<string, AbstractCommand>();
        }

        public void AddCommand(AbstractCommand command)
        {
            commandDictionary.Add(command.CommandString, command);
        }

        public void Run()
        {
            bool endInput = true;
            do
            {
                command = Console.ReadLine();
                ExecuteCommand(command);
            } while (endInput);
        }

        public void ExecuteCommand(string commandStr)
        {
            prevCommand = commandStr;
            Console.Clear();

            string[] commandArray = commandStr.Split(' ');
            
            AbstractCommand c;
            commandDictionary.TryGetValue(commandArray[0], out c);

            if(null != c)
            {
                Console.WriteLine("Executing {0}...", c.CommandString);

                //skip command name and send the arguments to the execute methode
                c.Execute(commandArray.Skip(1).ToArray());
            }
            else
            {
                Console.WriteLine("Command, {0} not found",commandStr);
            }

            Console.WriteLine(commandStr);
        }
        
    }
}
