using MathHelper.Input;
using MathHelper.MathProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserIO userIO = new ConsoleIO();
            BaseProblem problem = new AdditionProblem(userIO);


            userIO.WriteToUser("Hello");
            bool quit = false;
            do
            {
                problem.DoProblem(1, 2);
                userIO.WriteToUser("Would you like to do another? Y/N");
                string reply = userIO.GetUserInput<string>();
                if (reply.ToLower() == "n")
                    quit = true;

            } while (!quit);

        }
    }
}
