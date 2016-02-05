using MathHelper.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.MathProblems
{
    public class AdditionProblem : BaseProblem
    {

        public AdditionProblem(IUserIO userIO) : base(userIO)
        {
            this.AnswerDelta = 0;
            this.ProblemType = "Addition";
        }

        public override void DoProblem(double value0, double value1)
        {
            userIO.WriteToUser("Solve the following problem\n" + value0+" + " + value1 + " =");
            double userAnswer = userIO.GetUserInput<double>();
            double expectedAnser = value0 + value1;
            CheckAnswer(userAnswer, expectedAnser);
        }
    }
}
