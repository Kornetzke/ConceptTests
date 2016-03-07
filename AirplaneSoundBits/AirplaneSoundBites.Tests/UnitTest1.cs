using System;
using AirplaneSoundBites.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AirplaneSoundBites.Tests
{
    [TestClass]
    public class UnitTest1
    {

        private ClipPlayer player;

        [TestInitialize]
        public void Init()
        {
            //player = new Player(@"C:\Users\Kyle\Desktop\Airplane");
        }

        [TestMethod]
        public void GetFileNames()
        {
            string[] titles = player.GetClipNames();

            Assert.IsTrue(titles.Length > 0);
            
        }
    }
}
