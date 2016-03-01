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
        public Markers Turn { get { return firstPlayer ? Markers.X : Markers.O; } }
        private bool firstPlayer;


        public bool IsWinner { get { return IsWinningCondition(); } }
        public bool IsTied { get { return IsTiedCondition(); } }
       

        public TicTacToeGame()
        {
            board = new Markers[9];
            firstPlayer = true;
        }

        public void Play(int location)
        {
            if (location < 0 || location > Board.Length - 1)
                throw new InvalidPlayException("Invalid Location Selected");
            if (board[location] != Markers._)
                throw new InvalidPlayException("Location already taken");

            if (firstPlayer)
            {
                board[location] = Markers.X;
            }
            else
            {
                board[location] = Markers.O;
            }

            NextPlayer();

        }

        private void NextPlayer()
        {
            firstPlayer = !firstPlayer;
        }

        private bool IsWinningCondition()
        {
            bool horizontal = BoardSpacesMatchAndNotEmpty(0, 1, 2) || BoardSpacesMatchAndNotEmpty(3, 4, 5) || BoardSpacesMatchAndNotEmpty(6, 7, 8);
            bool vertical = BoardSpacesMatchAndNotEmpty(0, 3, 6) || BoardSpacesMatchAndNotEmpty(1, 4, 7) || BoardSpacesMatchAndNotEmpty(2, 5, 8);
            bool cross = BoardSpacesMatchAndNotEmpty(0, 4, 8) || BoardSpacesMatchAndNotEmpty(2, 4, 6);
            return horizontal || vertical || cross;
            
        }

        private bool BoardSpacesMatchAndNotEmpty(params int[] spaces)
        {
            if(spaces == null || spaces.Length < 1)
            {
                throw new ArgumentException("parameter array can not be null or length less than 1", "spaces");
            }
            Markers expected = board[spaces[0]];
            bool matchingAndNotEmpty = expected != Markers._;

            for(int i =1; i< spaces.Length; i++)
            {
                if (matchingAndNotEmpty)
                {
                    Markers actual = board[spaces[i]];
                    matchingAndNotEmpty = actual == expected;
                }
            }
            

            return matchingAndNotEmpty;
        }

        private bool IsTiedCondition()
        {
            return !IsWinner && !board.Contains(Markers._);
        }

        public void Reset()
        {
            for(int i=0; i < board.Length; i++)
            {
                board[i] = Markers._;
            }
            firstPlayer = true;
            
        }
    }
}
