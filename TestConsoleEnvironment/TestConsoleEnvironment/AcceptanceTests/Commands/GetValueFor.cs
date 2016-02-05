using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsoleEnvironment.TDD_FizzBuzz;

namespace TDD_FizzBuzz.AcceptanceTests.Commands
{
    public class GetValueFor : Command
    {
        FizzBuzz fizzBuzz;

        
        public GetValueFor(string name, FizzBuzz fizzBuzz)
        {
            this.CommandName = name;
            this.fizzBuzz = fizzBuzz;
        }

        public override string CommandHelp
        {
            get
            {
                return "This is Command returns the value of the FizzBuzz problem of the inputed integer value \r\nExample: GetValueFor 8";
            }
        }
        

        public override string Execute(string fullCommandString)
        {
            string[] command = ParseCommandString(fullCommandString);
            // Get first parameter from command
            int value = int.Parse(command[1]);
            return fizzBuzz.GetValueFor(value);
        }
    }
}
