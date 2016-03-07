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
        public PlayCommand(ClipPlayer player) : base(player)
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
                player.PlayClip(userClipChoice);
            }
            
        }
    }
}
