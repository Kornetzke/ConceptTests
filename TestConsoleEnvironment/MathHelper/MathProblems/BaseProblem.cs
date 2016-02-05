using MathHelper.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.MathProblems
{
    public abstract class BaseProblem
    {
        protected IUserIO userIO;
        public string ProblemType {get;protected set;}
        public double AnswerDelta { get; protected set; }

        public BaseProblem(IUserIO userIO)
        {
            this.userIO = userIO;
        }

        public abstract void DoProblem(double value0, double value1);

        public virtual void CheckAnswer(double userAnser, double expectedAnswer)
        {
            double lowerBounds = expectedAnswer - AnswerDelta;
            double upperBounds = expectedAnswer + AnswerDelta;

            if(userAnser >= lowerBounds && userAnser <= upperBounds)
            {
                userIO.WriteToUser("Your answer, " + userAnser + " is correct");
            }
            else
            {
                userIO.WriteToUser("Your answer, " + userAnser + " is not correct.\nThe correct answer was " + expectedAnswer);
            }
        }
    }
}
