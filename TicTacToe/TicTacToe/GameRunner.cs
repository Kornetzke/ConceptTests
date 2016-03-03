using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Game.IO;

namespace TicTacToe.Game
{
    public class GameRunner
    {
        IUserIO ui;
        TicTacToeGame game;

        public GameRunner()
        {
            ui = new ConsoleIO();
            game = new TicTacToeGame();
        }

        public void Run()
        {

            do
            {
                game.Reset();
                Play();
            } while (Replay());
            
        }

        private void Play()
        {
            ui.PrintToUser("Welcome to TicTacToe");
            PrintBoard(game.Board);

            while (!game.IsWinner && !game.IsTied)
            {
                ui.PrintToUser("Play location : ");

                int location = ui.GetFromUser<int>();
                try
                {
                    game.Play(location);
                }
                catch (InvalidPlayException e)
                {
                    ui.PrintToUser(e.Message);
                }

                PrintBoard(game.Board);
            }
            if (game.IsWinner)
            {
                ui.PrintToUser("Winner");
            }
            if (game.IsTied)
            {
                ui.PrintToUser("Game is tied");
            }
        }

        private void PrintBoard(Markers[] board)
        {
            string space = " | ";
            ui.PrintToUser(board[0].ToString() + space + board[1].ToString() + space + board[2]);
            ui.PrintToUser("----------");
            ui.PrintToUser(board[3].ToString() + space + board[4].ToString() + space + board[5]);
            ui.PrintToUser("----------");
            ui.PrintToUser(board[6].ToString() + space + board[7].ToString() + space + board[8]);
        }

        private bool Replay()
        {
            bool replay = false;
            ui.PrintToUser("Play Again? [Y]es [N]o");
            string reply = ui.GetFromUser<string>();
            if(reply.ToLower() == "y")
            {
                replay = true;
            }
            return replay;
        }
    }
}
