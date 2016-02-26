using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game
{

    public enum Markers
    {
        _,X,O
    }

    public class TicTacToeGame
    {
        private Markers[] board;
        public Markers[] Board { get { return board; } }


        public TicTacToeGame()
        {
            board = new Markers[9];
        }

        public void Play(int location)
        {
            board[location] = Markers.X;
        }
        
    }
}
