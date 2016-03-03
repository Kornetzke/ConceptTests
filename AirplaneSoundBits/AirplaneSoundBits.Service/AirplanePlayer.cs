using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneSoundBits.Service
{
    public class AirplanePlayer : SoundPlayer
    {
        public string FolderPath { get; internal set; }

        public string[] AudioTitles { get { return GetTitles(); } }

        private string[] GetTitles()
        {
            return Directory.GetFiles(FolderPath, "*.wav");
        }

        public AirplanePlayer(string folderLocation)
        {
            this.FolderPath = folderLocation;
        }
        
    }
}
