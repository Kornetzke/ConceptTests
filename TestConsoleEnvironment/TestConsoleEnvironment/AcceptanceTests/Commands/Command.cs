using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_FizzBuzz.AcceptanceTests.Commands
{
    public abstract class Command
    {

        public string CommandName { get; set; }

        public virtual string CommandHelp { get; set; }

        public List<string> parameters;

        public abstract string Execute(string command);

        protected string[] ParseCommandString(string fullCommandString)
        {
            return fullCommandString.Split(' ');
        }
        
    }
}
