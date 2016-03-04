using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneSoundBites.Service
{
    public class AirplanePlayer : SoundPlayer
    {

        public string FolderPath { get; set; }

        public string[] AudioTitles { get { return GetAllClipsCompleteFilePath(); } }

        private string[] GetAllClipsCompleteFilePath()
        {
            return Directory.GetFiles(FolderPath, "*.wav");
        }

        public AirplanePlayer(string folderLocation)
        {
            this.FolderPath = folderLocation;
        }
        

        public void PlayRandomClip()
        {
            Random random = new Random();
            string[] allFileLocation = GetAllClipsCompleteFilePath();
            int i = random.Next(0, allFileLocation.Length-1);

            string filePath = allFileLocation[i];
            this.SoundLocation = filePath;
            this.Play();
        }
        
    }
}
