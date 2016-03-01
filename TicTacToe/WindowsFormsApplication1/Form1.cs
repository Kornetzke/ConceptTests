using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Game;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        TicTacToeGame game;
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            locationButtons[0].Click += (sender, e) => { Play(locationButtons[0], 0); };
            locationButtons[1].Click += (sender, e) => { Play(locationButtons[1], 1); };
            locationButtons[2].Click += (sender, e) => { Play(locationButtons[2], 2); };
            locationButtons[3].Click += (sender, e) => { Play(locationButtons[3], 3); };
            locationButtons[4].Click += (sender, e) => { Play(locationButtons[4], 4); };
            locationButtons[5].Click += (sender, e) => { Play(locationButtons[5], 5); };
            locationButtons[6].Click += (sender, e) => { Play(locationButtons[6], 6); };
            locationButtons[7].Click += (sender, e) => { Play(locationButtons[7], 7); };
            locationButtons[8].Click += (sender, e) => { Play(locationButtons[8], 8); };
            resetButton.Click += (sender, e) => { Reset(); };
            game = new TicTacToeGame();
            Reset();
        }

        private bool Play(Button b,int location)
        {
            bool success = false;
            try
            {
                game.Play(location);
                success = true;
                textBox1.Clear();
                b.Text = game.Board[location].ToString();
                CheckForGameEndingCondition();
            }
            catch (InvalidPlayException e)
            {
                textBox1.Text = e.Message;
                success = false;
            }
            return success;
        }

        private void CheckForGameEndingCondition()
        {
            bool endGame = false;
            if (game.IsWinner)
            {
                textBox1.Text = "Winner";
                endGame = true;
            }
            else if (game.IsTied)
            {
                textBox1.Text = "Game is a tie";
                endGame = true;
            }
            if (endGame)
            {
                foreach(Button b in locationButtons){
                    b.Enabled = false;
                }
            }
        }

        public void Reset()
        {
            game.Reset();
            foreach(Button b in locationButtons)
            {
                b.Text = Markers._.ToString();
                b.Enabled = true;
            }
            textBox1.Text = "";
        }

    }
}
