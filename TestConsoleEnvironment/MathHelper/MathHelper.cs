using MathHelper.Input;
using MathHelper.MathProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MathHelper
{
    public class MathHelper
    {
        IUserIO userIO;
        List<BaseProblem> problems;

        public MathHelper(IUserIO userIO)
        {
            this.userIO = userIO;
        }

        private Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToArray();
        }

        public void FindProblem()
        {
            Type[] typelist = GetTypesInNamespace(Assembly.GetExecutingAssembly(), "MathHelper.MathProblems");
            for (int i = 0; i < typelist.Length; i++)
            {
                userIO.WriteToUser(typelist[i].Name);
            }
        }

        private void DoProblem(BaseProblem problem)
        {
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
        private void AskUserWhatToDo()
        {
            userIO.WriteToUser("Press any key to exit");
            userIO.GetUserInput<string>();
        }
    }
}
