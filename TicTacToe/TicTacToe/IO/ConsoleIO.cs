using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game.IO
{
    public class ConsoleIO : IUserIO
    {
        public void PrintToUser(string message)
        {
            Console.WriteLine(message);
        }

        public T GetFromUser<T>()
        {
            T value = default(T);
            bool invalidInput = true;
            do
            {
                try
                {
                    value = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                    invalidInput = false;
                }catch(Exception e)
                {
                    PrintToUser(e.Message);
                }
            } while (invalidInput);

            return value;
        }
    }
}
