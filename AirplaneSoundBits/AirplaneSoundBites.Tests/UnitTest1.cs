using System;
using AirplaneSoundBites.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AirplaneSoundBites.Tests
{
    [TestClass]
    public class UnitTest1
    {

        private AirplanePlayer player;

        [TestInitialize]
        public void Init()
        {
            player = new AirplanePlayer(@"C:\Users\Kyle\Desktop\Airplane");
        }

        [TestMethod]
        public void GetFileNames()
        {
            string[] titles = player.AudioTitles;

            Assert.IsTrue(titles.Length > 0);
            
        }
    }
}
