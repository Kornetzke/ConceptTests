using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleEnvironment.TDD_FizzBuzz
{
    public class FizzBuzz
    {
        public string GetValueFor(int v)
        {
            string output;

            if (v % 15 == 0)
                output = "FizzBuzz";
            else if (v % 5 == 0)
                output = "Buzz";
            else if (v % 3 == 0)
                output = "Fizz";
            else
                output = v.ToString();


            return output;
            
        }

        public string GetRangeOfValues(int start, int end)
        {
            StringBuilder output = new StringBuilder();

            for(int index = start; index <= end; index++)
            {
                if (output.Length > 0)
                    output.Append("\r\n");
                output.Append(GetValueFor(index));
            }

            return output.ToString();
        }
    }
}
