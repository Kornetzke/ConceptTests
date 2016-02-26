using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game
{
    public class InvalidPlayException : Exception
    {
        public InvalidPlayException() : base("Invalid Play"){}
        public InvalidPlayException(string message) : base(message){}
        
    }
}
