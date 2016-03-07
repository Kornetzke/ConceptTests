using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneSoundBites.Service
{
    public class ClipPlayer
    {
        private IClipRepository clipRepo;
        private SoundPlayer player;

        public ClipPlayer(IClipRepository repo)
        {
           retrieving clipRepo = repo;
            player = new SoundPlayer();
        }

        public string[] GetClipNames()
        {
            return clipRepo.GetClipFileNames();
        }

        public void PlayClip(string name)
        {
            string clipFullPath = clipRepo.GetClipFullPath(name);
            SetLocationAndPlay(clipFullPath);
        }

        public void PlayRandomClip()
        {
            string[] allclipFullPath = clipRepo.GetAllClipsFullPath();
            Random random = new Random();
            int index = random.Next(0, allclipFullPath.Length - 1);
            SetLocationAndPlay(allclipFullPath[index]);
        }

        public void StopPlaying()
        {
            player.Stop();
        }

        private void SetLocationAndPlay(string location)
        {
            player.SoundLocation = location;
            player.Play();
        }
    }




}
