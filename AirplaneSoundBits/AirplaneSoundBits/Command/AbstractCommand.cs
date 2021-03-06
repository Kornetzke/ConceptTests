﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirplaneSoundBites.Service;

namespace AirplaneSoundBites.ConsoleInterface.Command
{
    public abstract class AbstractCommand
    {
        protected ClipPlayer player;
        public string CommandString { get; protected set; }

        public AbstractCommand(ClipPlayer player)
        {
            this.player = player;
        }

        public abstract void Execute(string[] args = null);
    }
}
