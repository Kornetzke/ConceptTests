﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneSoundBites.ConsoleInterface.Command
{
    public class PlayRandomCommand : AbstractCommand
    {

        public PlayRandomCommand(AirplaneSoundBites.Service.AirplanePlayer player) : base(player)
        {
            this.CommandString = "playrandom";
        }
        public override void Execute(string[] args = null)
        {
            player.PlayRandomClip();
        }
    }
}
