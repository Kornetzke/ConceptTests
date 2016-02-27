using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Game;

namespace UserInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRunner runner = new GameRunner();
            runner.Run();
        }
    }
}
