﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirplaneSoundBites.Service;

namespace AirplaneSoundBites.ConsoleInterface.Command
{
    public class ListCommand : AbstractCommand
    {
        public ListCommand(ClipPlayer player) : base(player)
        {
            CommandString = "list";
        }

        public override void Execute(string[] args = null)
        {
            Console.WriteLine("Listing Titles");
            foreach(string s in player.GetClipNames())
            {
                Console.WriteLine(s);
            }
            
        }
    }
}
