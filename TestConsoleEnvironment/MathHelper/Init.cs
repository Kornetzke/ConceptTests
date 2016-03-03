using MathHelper.Input;
using MathHelper.MathProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    class Init
    {
        static void Main(string[] args)
        {
            IUserIO userIO = new ConsoleIO();
            MathHelper helper = new MathHelper(userIO);
            helper.FindProblem();

        }
    }
}
