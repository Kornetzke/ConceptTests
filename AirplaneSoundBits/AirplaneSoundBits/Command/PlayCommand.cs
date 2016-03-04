using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirplaneSoundBites.Service;
using System.Threading;

namespace AirplaneSoundBites.ConsoleInterface.Command
{
    public class PlayCommand : AbstractCommand
    {
        public PlayCommand(AirplanePlayer player) : base(player)
        {
            this.CommandString = "play";
        }
        public override void Execute(string[] args = null)
        {
            if (null == args || args.Length < 1)
            {
                Console.WriteLine("command arguments needed");
            }
            else {
                string userClipChoice = args[0];
                string[] matchingFullClipPath = player.AudioTitles.Where(t => t.Contains(userClipChoice)).ToArray();

                if (matchingFullClipPath.Length == 0)
                {
                    Console.WriteLine("Clip not found");
                }
                else if (matchingFullClipPath.Length > 1)
                {
                    Console.WriteLine("Could not narrow down the clips to one, clips found");
                    foreach (string s in matchingFullClipPath)
                    {
                        Console.WriteLine(s);
                    }
                }
                else
                {
                    player.SoundLocation = matchingFullClipPath[0];
                    player.Play();
                    
                }
            }
            
        }
    }
}
