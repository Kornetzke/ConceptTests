using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Game;
using TicTacToe;
using System.Linq;

namespace TicTacToe.Test
{
    [TestClass]
    public class TicTacToeTest
    {
        TicTacToeGame game;

        [TestInitialize]
        public void TestInit()
        {
            game = new TicTacToeGame();
        }

        [TestMethod]
        public void TestPlayerOnePlaysTopRightCorner()
        {
            game.Play(0);
            Markers[] expected = new Markers[9] { Markers.X, Markers._, Markers._, Markers._, Markers._, Markers._, Markers._, Markers._, Markers._ };
            Markers[] actual = game.Board;

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPlayException))]
        public void TestPlayBelowZero()
        {
            game.Play(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPlayException))]
        public void TestPlayAboveEight()
        {
            game.Play(9);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidPlayException))]
        public void TestPlaySameBoardLocation()
        {
            game.Play(0);
            game.Play(0);
        }

        [TestMethod]
        public void TestPlayerOnePlaysTopRightCornerPlayerTwoPlaysTopCenter()
        {
            game.Play(0);
            game.Play(1);
            Markers[] expected = new Markers[9] { Markers.X, Markers.O, Markers._, Markers._, Markers._, Markers._, Markers._, Markers._, Markers._ };
            Markers[] actual = game.Board;

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HorizontalWinningCondition()
        {
            //playerOne
            game.Play(0);
            //playerTwo
            game.Play(5);
            //playerOne
            game.Play(1);
            //playerTwo
            game.Play(4);
            //playerOne, winning
            game.Play(2);

            bool winner = game.IsWinner;
            Assert.IsTrue(winner);
        }
        [TestMethod]
        public void VerticalWinningCondition()
        {
            //playerOne
            game.Play(0);
            //playerTwo
            game.Play(5);
            //playerOne
            game.Play(3);
            //playerTwo
            game.Play(4);
            //playerOne, winning
            game.Play(6);

            bool winner = game.IsWinner;
            Assert.IsTrue(winner);
        }
        [TestMethod]
        public void CrossWinningCondition()
        {
            //playerOne
            game.Play(0);
            //playerTwo
            game.Play(5);
            //playerOne
            game.Play(4);
            //playerTwo
            game.Play(1);
            //playerOne, winning
            game.Play(8);

            bool winner = game.IsWinner;
            Assert.IsTrue(winner);
        }

        [TestMethod]
        public void NoWinningCondition()
        {
            game.Play(0);
            game.Play(1);
            bool actual = game.IsWinner;
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void TieCondition()
        {
            game.Play(0);
            game.Play(2);

            game.Play(1);
            game.Play(3);

            game.Play(4);
            game.Play(7);

            game.Play(5);
            game.Play(8);

            game.Play(6);

            bool tie = game.IsTied;
            Assert.IsTrue(tie);
        }

        [TestMethod]
        public void BoardReset()
        {
            game.Play(0);
            game.Reset();
            bool notReset = game.Board.Contains(Markers.X);

            Assert.IsFalse(notReset);
        }
    }
}
