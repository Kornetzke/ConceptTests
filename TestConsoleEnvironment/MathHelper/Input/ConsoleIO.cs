using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.Input
{
    class ConsoleIO : IUserIO
    {
        public T GetUserInput<T>()
        {
            bool invalidInput = false;
            T value = default(T);
            do
            {
                try {
                    string input = Console.ReadLine();
                    value = (T)Convert.ChangeType(input, typeof(T));
                    invalidInput = false;
                }catch(Exception e)
                {
                    WriteToUser(e.Message);
                    invalidInput = true;
                }
                    

            } while (invalidInput);

            return value;
        }

        public void WriteToUser(string message)
        {
            Console.WriteLine(message);
        }
    }
}
