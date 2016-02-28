using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game.IO
{
    interface IUserIO
    {
        void PrintToUser(string message);
        T GetFromUser<T>();
    }
}
